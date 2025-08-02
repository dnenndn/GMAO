using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Telerik.WinControls.Localization;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Data;
using Telerik.WinControls.UI.Localization;

namespace GMAO
{
	// Token: 0x0200009C RID: 156
	public partial class modifier_devis : Form
	{
		// Token: 0x0600070E RID: 1806 RVA: 0x00135988 File Offset: 0x00133B88
		public modifier_devis()
		{
			this.InitializeComponent();
			LocalizationProvider<RadGridLocalizationProvider>.CurrentProvider = new test_rad();
			this.radGridView1.ViewCellFormatting += new CellFormattingEventHandler(fonction.select_change);
			this.radGridView1.ViewRowFormatting += new RowFormattingEventHandler(fonction.select_changee);
			this.radGridView1.CellValueChanged += new GridViewCellEventHandler(this.RadGridView1_CellValueChanged);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00135A00 File Offset: 0x00133C00
		private void RadGridView1_CellValueChanged(object sender, GridViewCellEventArgs e)
		{
			bool flag = this.radGridView1.Rows.Count != 0;
			if (flag)
			{
				double num = 0.0;
				fonction fonction = new fonction();
				for (int i = 0; i < this.radGridView1.Rows.Count; i++)
				{
					bool flag2 = fonction.is_reel(this.radGridView1.Rows[i].Cells[3].Value.ToString()) & fonction.is_reel(this.radGridView1.Rows[i].Cells[4].Value.ToString()) & fonction.is_reel(this.radGridView1.Rows[i].Cells[5].Value.ToString());
					if (flag2)
					{
						double num2 = Convert.ToDouble(this.radGridView1.Rows[i].Cells[3].Value) * Convert.ToDouble(this.radGridView1.Rows[i].Cells[4].Value);
						num2 -= num2 * Convert.ToDouble(this.radGridView1.Rows[i].Cells[5].Value) / 100.0;
						num += num2;
						this.radGridView1.Rows[i].Cells[6].Value = num2.ToString("0.000");
					}
				}
				this.label14.Text = num.ToString("0.000");
			}
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00135BC8 File Offset: 0x00133DC8
		private void modifier_devis_Load(object sender, EventArgs e)
		{
			this.label14.Text = "";
			this.label8.Text = "";
			this.label9.Text = "";
			this.label10.Text = "";
			this.label11.Text = "";
			this.label4.Hide();
			this.label5.Hide();
			this.label6.Hide();
			this.label7.Hide();
			this.label12.Hide();
			this.pictureBox2.Hide();
			this.radDropDownList1.Hide();
			this.label3.Text = liste_dop.id_dop;
			this.select_fournisseur();
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00135C98 File Offset: 0x00133E98
		private void select_fournisseur()
		{
			this.radDropDownList6.Items.Clear();
			string cmdText = "select fournisseur.nom, fournisseur.id from dop_fournisseur inner join fournisseur on dop_fournisseur.id_fournisseur = fournisseur.id  where id_dop = @i";
			bd bd = new bd();
			SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
			sqlCommand.Parameters.Add("@i", SqlDbType.Int).Value = liste_dop.id_dop;
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count != 0;
			if (flag)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					string cmdText2 = "select devis_fournisseur.id from devis_fournisseur inner join devis on devis_fournisseur.id_devis = devis.id inner join dop on devis.id_dop = dop.id where id_fournisseur = @i1 and dop.id = @i2";
					SqlCommand sqlCommand2 = new SqlCommand(cmdText2, bd.cnn);
					sqlCommand2.Parameters.Add("@i1", SqlDbType.Int).Value = dataTable.Rows[i].ItemArray[1].ToString();
					sqlCommand2.Parameters.Add("@i2", SqlDbType.Int).Value = liste_dop.id_dop;
					SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);
					DataTable dataTable2 = new DataTable();
					sqlDataAdapter2.Fill(dataTable2);
					bool flag2 = dataTable2.Rows.Count != 0;
					if (flag2)
					{
						this.radDropDownList6.Items.Add(dataTable.Rows[i].ItemArray[0].ToString());
						this.radDropDownList6.Items[this.radDropDownList6.Items.Count - 1].Tag = dataTable.Rows[i].ItemArray[1].ToString();
					}
				}
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00135E4C File Offset: 0x0013404C
		private void select_article()
		{
			this.radGridView1.Rows.Clear();
			bool flag = this.radDropDownList6.Text != "";
			if (flag)
			{
				string cmdText = "select article.id, article.code_article, article.designation, qt_disponible, devis_article.prix_ht, devis_article.remise from devis_article inner join article on devis_article.id_article = article.id where id_devis = @i";
				bd bd = new bd();
				SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
				sqlCommand.Parameters.Add("@i", SqlDbType.Int).Value = this.label8.Text;
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				DataTable dataTable = new DataTable();
				sqlDataAdapter.Fill(dataTable);
				bool flag2 = dataTable.Rows.Count != 0;
				if (flag2)
				{
					for (int i = 0; i < dataTable.Rows.Count; i++)
					{
						this.radGridView1.Rows.Add(new object[]
						{
							dataTable.Rows[i].ItemArray[0].ToString(),
							dataTable.Rows[i].ItemArray[1].ToString(),
							dataTable.Rows[i].ItemArray[2].ToString(),
							dataTable.Rows[i].ItemArray[3].ToString(),
							dataTable.Rows[i].ItemArray[4].ToString(),
							dataTable.Rows[i].ItemArray[5].ToString()
						});
					}
				}
				bool flag3 = this.radGridView1.Rows.Count != 0;
				if (flag3)
				{
					double num = 0.0;
					fonction fonction = new fonction();
					for (int j = 0; j < this.radGridView1.Rows.Count; j++)
					{
						bool flag4 = fonction.is_reel(this.radGridView1.Rows[j].Cells[3].Value.ToString()) & fonction.is_reel(this.radGridView1.Rows[j].Cells[4].Value.ToString()) & fonction.is_reel(this.radGridView1.Rows[j].Cells[5].Value.ToString());
						if (flag4)
						{
							double num2 = Convert.ToDouble(this.radGridView1.Rows[j].Cells[3].Value) * Convert.ToDouble(this.radGridView1.Rows[j].Cells[4].Value);
							num2 -= num2 * Convert.ToDouble(this.radGridView1.Rows[j].Cells[5].Value) / 100.0;
							num += num2;
							this.radGridView1.Rows[j].Cells[6].Value = num2.ToString("0.000");
						}
					}
					this.label14.Text = num.ToString("0.000");
				}
			}
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x001361B4 File Offset: 0x001343B4
		private void radDropDownList6_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
		{
			bool flag = this.radDropDownList6.Text != "";
			if (flag)
			{
				this.radDropDownList1.Items.Clear();
				this.radDropDownList1.Items.Add("Oui");
				this.radDropDownList1.Items.Add("Non");
				bd bd = new bd();
				string cmdText = "select devis_fournisseur.id_devis, devis.createur, devis.date_devis, devis.heure_devis, devis.livr from devis_fournisseur inner join devis on devis_fournisseur.id_devis = devis.id where devis.id_dop = @i1 and devis_fournisseur.id_fournisseur = @i2";
				SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
				sqlCommand.Parameters.Add("@i1", SqlDbType.Int).Value = this.label3.Text;
				sqlCommand.Parameters.Add("@i2", SqlDbType.Int).Value = this.radDropDownList6.SelectedItem.Tag;
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				DataTable dataTable = new DataTable();
				sqlDataAdapter.Fill(dataTable);
				bool flag2 = dataTable.Rows.Count != 0;
				if (flag2)
				{
					this.label4.Show();
					this.label5.Show();
					this.label6.Show();
					this.label7.Show();
					this.label12.Show();
					this.radDropDownList1.Show();
					this.label8.Text = dataTable.Rows[0].ItemArray[0].ToString();
					this.label9.Text = this.select_utilisateur(dataTable.Rows[0].ItemArray[1].ToString());
					this.label10.Text = fonction.Mid(dataTable.Rows[0].ItemArray[2].ToString(), 1, 10);
					this.label11.Text = dataTable.Rows[0].ItemArray[3].ToString();
					this.radDropDownList1.Text = dataTable.Rows[0].ItemArray[4].ToString();
					this.select_article();
					this.recherche_fichier();
				}
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x001363D0 File Offset: 0x001345D0
		private string select_utilisateur(string i)
		{
			bd bd = new bd();
			string result = "";
			string cmdText = "select login from utilisateur where id = @i";
			SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
			sqlCommand.Parameters.Add("@i", SqlDbType.Int).Value = i;
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count != 0;
			if (flag)
			{
				result = dataTable.Rows[0].ItemArray[0].ToString();
			}
			return result;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00136468 File Offset: 0x00134668
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			bd bd = new bd();
			bool flag = this.radGridView1.Rows.Count != 0;
			if (flag)
			{
				bool flag2 = this.format_qt() == 1;
				if (flag2)
				{
					bool flag3 = this.format_prix() == 1;
					if (flag3)
					{
						bool flag4 = this.format_remise() == 1;
						if (flag4)
						{
							string cmdText = "update devis set livr = @i1 where id = @i2";
							SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
							sqlCommand.Parameters.Add("@i2", SqlDbType.Int).Value = this.label8.Text;
							sqlCommand.Parameters.Add("@i1", SqlDbType.VarChar).Value = this.radDropDownList1.Text;
							bd.ouverture_bd(bd.cnn);
							sqlCommand.ExecuteNonQuery();
							bd.cnn.Close();
							for (int i = 0; i < this.radGridView1.Rows.Count; i++)
							{
								string cmdText2 = "update devis_article set qt_disponible = @v1, prix_ht = @v2, remise = @v3 where id_devis = @i and id_article = @i2";
								SqlCommand sqlCommand2 = new SqlCommand(cmdText2, bd.cnn);
								sqlCommand2.Parameters.Add("@v1", SqlDbType.Real).Value = this.radGridView1.Rows[i].Cells[3].Value.ToString();
								sqlCommand2.Parameters.Add("@v2", SqlDbType.Real).Value = this.radGridView1.Rows[i].Cells[4].Value.ToString();
								sqlCommand2.Parameters.Add("@v3", SqlDbType.Real).Value = this.radGridView1.Rows[i].Cells[5].Value.ToString();
								sqlCommand2.Parameters.Add("@i", SqlDbType.Int).Value = this.label8.Text;
								sqlCommand2.Parameters.Add("@i2", SqlDbType.Int).Value = this.radGridView1.Rows[i].Cells[0].Value.ToString();
								bd.ouverture_bd(bd.cnn);
								sqlCommand2.ExecuteNonQuery();
								bd.cnn.Close();
							}
							MessageBox.Show("Modification avec succés");
						}
						else
						{
							MessageBox.Show("Erreur : Vérifier le format des cellules remise", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
					}
					else
					{
						MessageBox.Show("Erreur : Vérifier le format des cellules prix ht", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				else
				{
					MessageBox.Show("Erreur : Vérifier le format des cellules quantité disponible", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				MessageBox.Show("Erreur : Le tableau est vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0013673C File Offset: 0x0013493C
		private int format_qt()
		{
			int result = 0;
			fonction fonction = new fonction();
			bool flag = this.radGridView1.Rows.Count != 0;
			if (flag)
			{
				result = 1;
				for (int i = 0; i < this.radGridView1.Rows.Count; i++)
				{
					bool flag2 = !fonction.is_reel(this.radGridView1.Rows[i].Cells[3].Value.ToString());
					if (flag2)
					{
						result = 0;
					}
				}
			}
			return result;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x001367D0 File Offset: 0x001349D0
		private int format_prix()
		{
			int result = 0;
			fonction fonction = new fonction();
			bool flag = this.radGridView1.Rows.Count != 0;
			if (flag)
			{
				result = 1;
				for (int i = 0; i < this.radGridView1.Rows.Count; i++)
				{
					bool flag2 = !fonction.is_reel(this.radGridView1.Rows[i].Cells[4].Value.ToString());
					if (flag2)
					{
						result = 0;
					}
				}
			}
			return result;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00136864 File Offset: 0x00134A64
		private int format_remise()
		{
			int result = 0;
			fonction fonction = new fonction();
			bool flag = this.radGridView1.Rows.Count != 0;
			if (flag)
			{
				result = 1;
				for (int i = 0; i < this.radGridView1.Rows.Count; i++)
				{
					bool flag2 = !fonction.is_reel(this.radGridView1.Rows[i].Cells[5].Value.ToString());
					if (flag2)
					{
						result = 0;
					}
				}
			}
			return result;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x001368F8 File Offset: 0x00134AF8
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.FileName = "";
			openFileDialog.ShowDialog();
			fonction fonction = new fonction();
			bd bd = new bd();
			bool flag = fonction.DeleteSpace(openFileDialog.FileName) != "";
			if (flag)
			{
				string cmdText = "insert into devis_fichier (id_devis, adresse) values (@i1, @i2)";
				SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
				sqlCommand.Parameters.Add("@i1", SqlDbType.Int).Value = this.label8.Text;
				sqlCommand.Parameters.Add("@i2", SqlDbType.VarChar).Value = openFileDialog.FileName;
				bd.ouverture_bd(bd.cnn);
				sqlCommand.ExecuteNonQuery();
				bd.cnn.Close();
			}
			this.recherche_fichier();
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x001369C8 File Offset: 0x00134BC8
		private void recherche_fichier()
		{
			fonction fonction = new fonction();
			bd bd = new bd();
			string cmdText = "select adresse from devis_fichier where id_devis = @l";
			SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
			sqlCommand.Parameters.Add("@l", SqlDbType.Int).Value = this.label8.Text;
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.radPanel1.Controls.Clear();
			bool flag = dataTable.Rows.Count != 0;
			if (flag)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					PictureBox pictureBox = new PictureBox();
					pictureBox.Size = new Size(48, 30);
					pictureBox.Cursor = Cursors.Hand;
					pictureBox.Location = new Point(5 + 100 * i, 7);
					pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
					string h = Convert.ToString(dataTable.Rows[i].ItemArray[0]);
					pictureBox.Click += delegate(object s, EventArgs e)
					{
						fonction.ouvrir_fichier(h);
					};
					bool flag2 = this.n_fichier(h) == "dwg";
					if (flag2)
					{
						pictureBox.Image = this.imageList1.Images[9];
					}
					else
					{
						bool flag3 = this.n_fichier(h) == "png" | this.n_fichier(h) == "jpeg" | this.n_fichier(h) == "jpg";
						if (flag3)
						{
							pictureBox.Image = this.imageList1.Images[7];
						}
						else
						{
							bool flag4 = this.n_fichier(h) == "xlsx" | this.n_fichier(h) == "xls";
							if (flag4)
							{
								pictureBox.Image = this.imageList1.Images[4];
							}
							else
							{
								bool flag5 = this.n_fichier(h) == "pdf";
								if (flag5)
								{
									pictureBox.Image = this.imageList1.Images[5];
								}
								else
								{
									bool flag6 = this.n_fichier(h) == "txt";
									if (flag6)
									{
										pictureBox.Image = this.imageList1.Images[6];
									}
									else
									{
										bool flag7 = this.n_fichier(h) == "docx";
										if (flag7)
										{
											pictureBox.Image = this.imageList1.Images[3];
										}
										else
										{
											bool flag8 = this.n_fichier(h) == "rar" | this.n_fichier(h) == "zip";
											if (flag8)
											{
												pictureBox.Image = this.imageList1.Images[8];
											}
											else
											{
												pictureBox.Image = this.imageList1.Images[9];
											}
										}
									}
								}
							}
						}
					}
					PictureBox pictureBox2 = new PictureBox();
					pictureBox2.Size = new Size(15, 15);
					pictureBox2.Cursor = Cursors.Hand;
					pictureBox2.Location = new Point(56 + 100 * i, 7);
					pictureBox2.Image = this.pictureBox2.Image;
					pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
					pictureBox2.Click += delegate(object s, EventArgs e)
					{
						this.supprimer_file(h);
					};
					this.radPanel1.Controls.Add(pictureBox);
					this.radPanel1.Controls.Add(pictureBox2);
					Label label = new Label();
					label.AutoSize = true;
					label.BackColor = Color.Transparent;
					label.ForeColor = Color.Black;
					label.Location = new Point(5 + 100 * i, 45);
					label.Cursor = Cursors.Default;
					label.Text = this.nom_fichier(h);
					this.radPanel1.Controls.Add(label);
				}
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00136E38 File Offset: 0x00135038
		public string n_fichier(string h)
		{
			int num = 0;
			int length = h.Length;
			for (int i = 1; i < length + 1; i++)
			{
				bool flag = fonction.Mid(h, i, 1) == ".";
				if (flag)
				{
					num = i;
				}
			}
			return fonction.Mid(h, num + 1, length - num);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00136E98 File Offset: 0x00135098
		public string nom_fichier(string h)
		{
			int num = 0;
			int length = h.Length;
			for (int i = 1; i < length + 1; i++)
			{
				bool flag = fonction.Mid(h, i, 1) == "\\";
				if (flag)
				{
					num = i;
				}
			}
			return fonction.Mid(h, num + 1, length - num);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00136EF8 File Offset: 0x001350F8
		private void supprimer_file(string x)
		{
			DialogResult dialogResult = MessageBox.Show("Vous voulez supprimer ?", "ALERTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			bool flag = dialogResult == DialogResult.Yes;
			if (flag)
			{
				bd bd = new bd();
				string cmdText = "delete devis_fichier where id_devis = @a and adresse = @x";
				SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
				sqlCommand.Parameters.Add("@a", SqlDbType.Int).Value = this.label8.Text;
				sqlCommand.Parameters.Add("@x", SqlDbType.VarChar).Value = x;
				bd.ouverture_bd(bd.cnn);
				sqlCommand.ExecuteNonQuery();
				bd.cnn.Close();
				this.recherche_fichier();
			}
		}
	}
}
