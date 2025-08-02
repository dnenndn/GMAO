using System;
using System.Collections.Generic;
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
using Telerik.WinControls.UI.Localization;

namespace GMAO
{
	// Token: 0x0200000E RID: 14
	public partial class ajouter_devis_st : Form
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x00024BAC File Offset: 0x00022DAC
		public ajouter_devis_st()
		{
			this.InitializeComponent();
			LocalizationProvider<RadGridLocalizationProvider>.CurrentProvider = new test_rad();
			this.radGridView1.ViewCellFormatting += new CellFormattingEventHandler(fonction.select_change);
			this.radGridView1.ViewRowFormatting += new RowFormattingEventHandler(fonction.select_changee);
			this.radGridView1.CellValueChanged += new GridViewCellEventHandler(this.RadGridView1_CellValueChanged);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00024C30 File Offset: 0x00022E30
		private void RadGridView1_CellValueChanged(object sender, GridViewCellEventArgs e)
		{
			bool flag = this.radGridView1.Rows.Count != 0;
			if (flag)
			{
				double num = 0.0;
				fonction fonction = new fonction();
				for (int i = 0; i < this.radGridView1.Rows.Count; i++)
				{
					bool flag2 = fonction.is_reel(Convert.ToString(this.radGridView1.Rows[i].Cells[5].Value)) & fonction.is_reel(Convert.ToString(this.radGridView1.Rows[i].Cells[7].Value)) & fonction.is_reel(Convert.ToString(this.radGridView1.Rows[i].Cells[8].Value));
					if (flag2)
					{
						double num2 = Convert.ToDouble(this.radGridView1.Rows[i].Cells[5].Value) * Convert.ToDouble(this.radGridView1.Rows[i].Cells[7].Value);
						num2 -= num2 * Convert.ToDouble(this.radGridView1.Rows[i].Cells[8].Value) / 100.0;
						num += num2;
						this.radGridView1.Rows[i].Cells[9].Value = num2.ToString("0.000");
					}
				}
				this.label6.Text = num.ToString("0.000");
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00024DF8 File Offset: 0x00022FF8
		private void ajouter_devis_st_Load(object sender, EventArgs e)
		{
			this.label6.Text = "";
			this.pictureBox2.Hide();
			this.label3.Text = creer_devis_st.id_ds;
			this.radDropDownList1.Items.Clear();
			this.radDropDownList1.Items.Add("Oui");
			this.radDropDownList1.Items.Add("Non");
			this.radDropDownList1.Text = "Oui";
			this.select_sous_traitant();
			this.select_article();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00024E90 File Offset: 0x00023090
		private void select_sous_traitant()
		{
			bd bd = new bd();
			this.radDropDownList6.Items.Clear();
			string cmdText = "select fournisseur.nom, id from fournisseur where type = @t and id not in (select id_fournisseur from ds_devis_fournisseur inner join ds_devis on ds_devis_fournisseur.id_devis = ds_devis.id where ds_devis.id_ds = @o )";
			SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
			sqlCommand.Parameters.Add("@t", SqlDbType.VarChar).Value = "Sous_Traitant";
			sqlCommand.Parameters.Add("@o", SqlDbType.Int).Value = this.label3.Text;
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count != 0;
			if (flag)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					this.radDropDownList6.Items.Add(dataTable.Rows[i].ItemArray[0].ToString());
					this.radDropDownList6.Items[this.radDropDownList6.Items.Count - 1].Tag = dataTable.Rows[i].ItemArray[1].ToString();
				}
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00024FCC File Offset: 0x000231CC
		private void select_article()
		{
			this.radGridView1.Rows.Clear();
			bd bd = new bd();
			string cmdText = "select article.id,ref_interne, article.code_article, article.designation, activite.designation, magasin_sous_traitance.id from magasin_sous_traitance inner join article on magasin_sous_traitance.id_article = article.id inner join activite on magasin_sous_traitance.activite_actuel = activite.id inner join demande_sous_traitance on magasin_sous_traitance.demande_actuel = demande_sous_traitance.id where demande_sous_traitance.id = @i";
			SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
			sqlCommand.Parameters.Add("@i", SqlDbType.Int).Value = this.label3.Text;
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			string cmdText2 = "select article.id,article.code_article, article.designation,quantite,  activite.designation, ds_nv_article.id from ds_nv_article inner join article on ds_nv_article.id_article = article.id inner join activite on ds_nv_article.id_activite = activite.id inner join demande_sous_traitance on ds_nv_article.id_demande = demande_sous_traitance.id where demande_sous_traitance.id = @i";
			SqlCommand sqlCommand2 = new SqlCommand(cmdText2, bd.cnn);
			sqlCommand2.Parameters.Add("@i", SqlDbType.Int).Value = this.label3.Text;
			SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);
			DataTable dataTable2 = new DataTable();
			sqlDataAdapter2.Fill(dataTable2);
			bool flag = dataTable.Rows.Count != 0;
			if (flag)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					this.radGridView1.Rows.Add(new object[]
					{
						dataTable.Rows[i].ItemArray[5].ToString(),
						dataTable.Rows[i].ItemArray[0].ToString(),
						dataTable.Rows[i].ItemArray[1].ToString(),
						dataTable.Rows[i].ItemArray[2].ToString(),
						dataTable.Rows[i].ItemArray[3].ToString(),
						"1",
						dataTable.Rows[i].ItemArray[4].ToString()
					});
				}
			}
			bool flag2 = dataTable2.Rows.Count != 0;
			if (flag2)
			{
				for (int j = 0; j < dataTable2.Rows.Count; j++)
				{
					this.radGridView1.Rows.Add(new object[]
					{
						dataTable2.Rows[j].ItemArray[5].ToString(),
						dataTable2.Rows[j].ItemArray[0].ToString(),
						"-",
						dataTable2.Rows[j].ItemArray[1].ToString(),
						dataTable2.Rows[j].ItemArray[2].ToString(),
						dataTable2.Rows[j].ItemArray[3].ToString(),
						dataTable2.Rows[j].ItemArray[4].ToString()
					});
				}
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000252B4 File Offset: 0x000234B4
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.FileName = "";
			openFileDialog.ShowDialog();
			fonction fonction = new fonction();
			bool flag = fonction.DeleteSpace(openFileDialog.FileName) != "";
			if (flag)
			{
				this.liste_adresse.Add(openFileDialog.FileName);
			}
			this.recherche_fichier();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00025318 File Offset: 0x00023518
		private void recherche_fichier()
		{
			fonction fonction = new fonction();
			this.radPanel1.Controls.Clear();
			bool flag = this.liste_adresse.Count != 0;
			if (flag)
			{
				for (int i = 0; i < this.liste_adresse.Count; i++)
				{
					PictureBox pictureBox = new PictureBox();
					pictureBox.Size = new Size(48, 30);
					pictureBox.Cursor = Cursors.Hand;
					pictureBox.Location = new Point(5 + 100 * i, 7);
					pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
					string h = Convert.ToString(this.liste_adresse[i]);
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

		// Token: 0x060000CE RID: 206 RVA: 0x000256F8 File Offset: 0x000238F8
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

		// Token: 0x060000CF RID: 207 RVA: 0x00025758 File Offset: 0x00023958
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

		// Token: 0x060000D0 RID: 208 RVA: 0x000257B8 File Offset: 0x000239B8
		private void supprimer_file(string x)
		{
			DialogResult dialogResult = MessageBox.Show("Vous voulez supprimer ?", "ALERTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			bool flag = dialogResult == DialogResult.Yes;
			if (flag)
			{
				this.liste_adresse.Remove(x);
				this.recherche_fichier();
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000257F8 File Offset: 0x000239F8
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			bool flag = this.radDropDownList6.Text != "";
			if (flag)
			{
				bool flag2 = this.format_prix() == 1;
				if (flag2)
				{
					bool flag3 = this.format_remise() == 1;
					if (flag3)
					{
						bd bd = new bd();
						string cmdText = "insert into ds_devis (date_devis, heure_devis, createur, id_ds, statut, livr) values (@i1, @i2, @i3, @i4, @i5, @i6)SELECT CAST(scope_identity() AS int)";
						SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
						sqlCommand.Parameters.Add("@i1", SqlDbType.Date).Value = DateTime.Today;
						sqlCommand.Parameters.Add("@i2", SqlDbType.VarChar).Value = fonction.Mid(DateTime.Now.ToString(), 12, 5);
						sqlCommand.Parameters.Add("@i3", SqlDbType.Int).Value = page_loginn.id_user;
						sqlCommand.Parameters.Add("@i4", SqlDbType.Int).Value = this.label3.Text;
						sqlCommand.Parameters.Add("@i5", SqlDbType.Int).Value = 0;
						sqlCommand.Parameters.Add("@i6", SqlDbType.VarChar).Value = this.radDropDownList1.Text;
						bd.ouverture_bd(bd.cnn);
						int num = (int)sqlCommand.ExecuteScalar();
						bd.cnn.Close();
						string cmdText2 = "insert into ds_devis_fournisseur (id_devis, id_fournisseur) values (@i1, @i2)";
						SqlCommand sqlCommand2 = new SqlCommand(cmdText2, bd.cnn);
						sqlCommand2.Parameters.Add("@i1", SqlDbType.Int).Value = num;
						sqlCommand2.Parameters.Add("@i2", SqlDbType.Int).Value = this.radDropDownList6.SelectedItem.Tag.ToString();
						bd.ouverture_bd(bd.cnn);
						sqlCommand2.ExecuteNonQuery();
						bd.cnn.Close();
						for (int i = 0; i < this.radGridView1.Rows.Count; i++)
						{
							string value = "ex";
							bool flag4 = this.radGridView1.Rows[i].Cells[2].Value.ToString() == "-";
							if (flag4)
							{
								value = "nv";
							}
							string cmdText3 = "select id from activite where designation = @i";
							SqlCommand sqlCommand3 = new SqlCommand(cmdText3, bd.cnn);
							sqlCommand3.Parameters.Add("@i", SqlDbType.VarChar).Value = this.radGridView1.Rows[i].Cells[6].Value.ToString();
							SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand3);
							DataTable dataTable = new DataTable();
							sqlDataAdapter.Fill(dataTable);
							string cmdText4 = "insert into ds_devis_article (id_devis, id_t, qt,id_activite, prix_ht, remise, source) values (@i1, @i2, @i3, @i4, @i5, @i6, @i7)";
							SqlCommand sqlCommand4 = new SqlCommand(cmdText4, bd.cnn);
							sqlCommand4.Parameters.Add("@i1", SqlDbType.Int).Value = num;
							sqlCommand4.Parameters.Add("@i2", SqlDbType.Int).Value = this.radGridView1.Rows[i].Cells[0].Value.ToString();
							sqlCommand4.Parameters.Add("@i3", SqlDbType.Real).Value = this.radGridView1.Rows[i].Cells[5].Value.ToString();
							sqlCommand4.Parameters.Add("@i4", SqlDbType.Int).Value = dataTable.Rows[0].ItemArray[0];
							sqlCommand4.Parameters.Add("@i5", SqlDbType.Real).Value = this.radGridView1.Rows[i].Cells[7].Value.ToString();
							sqlCommand4.Parameters.Add("@i6", SqlDbType.Real).Value = this.radGridView1.Rows[i].Cells[8].Value.ToString();
							sqlCommand4.Parameters.Add("@i7", SqlDbType.VarChar).Value = value;
							bd.ouverture_bd(bd.cnn);
							sqlCommand4.ExecuteNonQuery();
							bd.cnn.Close();
						}
						this.save_fichier(num);
						MessageBox.Show("Succés");
						this.select_sous_traitant();
						this.liste_adresse.Clear();
						this.recherche_fichier();
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
				MessageBox.Show("Erreur : Erreur: Il faut choisir un sous traitant", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00025CDC File Offset: 0x00023EDC
		private void save_fichier(int id)
		{
			bd bd = new bd();
			bool flag = this.liste_adresse.Count != 0;
			if (flag)
			{
				for (int i = 0; i < this.liste_adresse.Count; i++)
				{
					string cmdText = "insert into ds_devis_fichier (id_devis, adresse) values (@i1, @i2)";
					SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
					sqlCommand.Parameters.Add("@i1", SqlDbType.Int).Value = id;
					sqlCommand.Parameters.Add("@i2", SqlDbType.VarChar).Value = this.liste_adresse[i];
					bd.ouverture_bd(bd.cnn);
					sqlCommand.ExecuteNonQuery();
					bd.cnn.Close();
				}
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00025DA0 File Offset: 0x00023FA0
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
					bool flag2 = !fonction.is_reel(Convert.ToString(this.radGridView1.Rows[i].Cells[7].Value));
					if (flag2)
					{
						result = 0;
					}
				}
			}
			return result;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00025E34 File Offset: 0x00024034
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
					bool flag2 = !fonction.is_reel(Convert.ToString(this.radGridView1.Rows[i].Cells[8].Value));
					if (flag2)
					{
						result = 0;
					}
				}
			}
			return result;
		}

		// Token: 0x04000125 RID: 293
		private List<string> liste_adresse = new List<string>();
	}
}
