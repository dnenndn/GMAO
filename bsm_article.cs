using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using GMAO.Properties;
using Guna.UI2.WinForms;
using Telerik.WinControls;
using Telerik.WinControls.Localization;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace GMAO
{
	// Token: 0x02000031 RID: 49
	public partial class bsm_article : Form
	{
		// Token: 0x06000250 RID: 592 RVA: 0x00064B80 File Offset: 0x00062D80
		public bsm_article()
		{
			this.InitializeComponent();
			LocalizationProvider<RadGridLocalizationProvider>.CurrentProvider = new test_rad();
			this.radGridView1.ViewCellFormatting += new CellFormattingEventHandler(fonction.select_change);
			this.radGridView1.ViewRowFormatting += new RowFormattingEventHandler(fonction.select_changee);
			this.radMenuItem1.Click += this.click_ajouter;
			this.radGridView1.CellClick += new GridViewCellEventHandler(this.action_tableau);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00064C1C File Offset: 0x00062E1C
		private void select_article()
		{
			this.radTreeView1.Nodes.Clear();
			bd bd = new bd();
			string cmdText = "select id, designation ,stock_neuf from article where deleted =@d and stock_neuf <> @d order by designation";
			SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
			sqlCommand.Parameters.Add("@d", SqlDbType.Int).Value = 0;
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count != 0;
			if (flag)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					RadTreeNode radTreeNode = new RadTreeNode();
					radTreeNode.Text = dataTable.Rows[i].ItemArray[1].ToString() + "- qt: " + dataTable.Rows[i].ItemArray[2].ToString();
					radTreeNode.Tag = dataTable.Rows[i].ItemArray[0].ToString();
					radTreeNode.ToolTipText = dataTable.Rows[i].ItemArray[1].ToString();
					this.radTreeView1.Nodes.Add(radTreeNode);
				}
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00064D70 File Offset: 0x00062F70
		private void select_article_usee()
		{
			this.radTreeView1.Nodes.Clear();
			bd bd = new bd();
			string cmdText = "select id, designation ,stock_use from article where deleted =@d and stock_use <> @d order by designation";
			SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
			sqlCommand.Parameters.Add("@d", SqlDbType.Int).Value = 0;
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count != 0;
			if (flag)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					RadTreeNode radTreeNode = new RadTreeNode();
					radTreeNode.Text = dataTable.Rows[i].ItemArray[1].ToString() + "- qt: " + dataTable.Rows[i].ItemArray[2].ToString();
					radTreeNode.Tag = dataTable.Rows[i].ItemArray[0].ToString();
					radTreeNode.ToolTipText = dataTable.Rows[i].ItemArray[1].ToString();
					this.radTreeView1.Nodes.Add(radTreeNode);
				}
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00064EC4 File Offset: 0x000630C4
		private void select_article_rebute()
		{
			this.radTreeView1.Nodes.Clear();
			bd bd = new bd();
			string cmdText = "select id, designation ,stock_rebute from article where deleted =@d and stock_rebute <> @d order by designation";
			SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
			sqlCommand.Parameters.Add("@d", SqlDbType.Int).Value = 0;
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count != 0;
			if (flag)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					RadTreeNode radTreeNode = new RadTreeNode();
					radTreeNode.Text = dataTable.Rows[i].ItemArray[1].ToString() + "- qt: " + dataTable.Rows[i].ItemArray[2].ToString();
					radTreeNode.Tag = dataTable.Rows[i].ItemArray[0].ToString();
					radTreeNode.ToolTipText = dataTable.Rows[i].ItemArray[1].ToString();
					this.radTreeView1.Nodes.Add(radTreeNode);
				}
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00065018 File Offset: 0x00063218
		private void bsm_article_Load(object sender, EventArgs e)
		{
			bd bd = new bd();
			string cmdText = "select type_stock from bsm where id = @i";
			SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
			sqlCommand.Parameters.Add("@i", SqlDbType.Int).Value = historique_bsm.id_bsm;
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count != 0;
			if (flag)
			{
				this.type_stock = dataTable.Rows[0].ItemArray[0].ToString();
				bool flag2 = dataTable.Rows[0].ItemArray[0].ToString() == "Neuf";
				if (flag2)
				{
					this.select_article();
				}
				bool flag3 = dataTable.Rows[0].ItemArray[0].ToString() == "Usé";
				if (flag3)
				{
					this.select_article_usee();
				}
				bool flag4 = dataTable.Rows[0].ItemArray[0].ToString() == "Rebuté";
				if (flag4)
				{
					this.select_article_usee();
				}
			}
			this.select_article_bsm();
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00065148 File Offset: 0x00063348
		private void guna2TextBox1_TextChanged(object sender, EventArgs e)
		{
			this.radTreeView1.Filter = this.guna2TextBox1.Text;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00065164 File Offset: 0x00063364
		private void click_ajouter(object sender, EventArgs e)
		{
			bool flag = this.radTreeView1.SelectedNode != null;
			if (flag)
			{
				RadTreeNode selectedNode = this.radTreeView1.SelectedNode;
				bool flag2 = this.search_tableau(Convert.ToString(selectedNode.Tag)) == 0;
				if (flag2)
				{
					bd bd = new bd();
					string cmdText = "select parametre_unite_article.designation from tableau_article_unite inner join parametre_unite_article on tableau_article_unite.id_unite = parametre_unite_article.id where id_article = @i";
					SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
					sqlCommand.Parameters.Add("@i", SqlDbType.Int).Value = selectedNode.Tag;
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
					DataTable dataTable = new DataTable();
					sqlDataAdapter.Fill(dataTable);
					string cmdText2 = "";
					bool flag3 = this.type_stock == "Neuf";
					if (flag3)
					{
						cmdText2 = "select stock_neuf from article where id = @i1";
					}
					bool flag4 = this.type_stock == "Usé";
					if (flag4)
					{
						cmdText2 = "select stock_use from article where id = @i1";
					}
					bool flag5 = this.type_stock == "Rebuté";
					if (flag5)
					{
						cmdText2 = "select stock_rebute from article where id = @i1";
					}
					SqlCommand sqlCommand2 = new SqlCommand(cmdText2, bd.cnn);
					sqlCommand2.Parameters.Add("@i1", SqlDbType.Int).Value = selectedNode.Tag;
					SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);
					DataTable dataTable2 = new DataTable();
					sqlDataAdapter2.Fill(dataTable2);
					this.radGridView1.Rows.Add(new object[]
					{
						Convert.ToString(selectedNode.Tag),
						selectedNode.ToolTipText,
						0,
						Convert.ToString(dataTable2.Rows[0].ItemArray[0])
					});
					this.radGridView1.Rows[this.radGridView1.Rows.Count - 1].Cells[4].Value = Resources.icons8_supprimer_pour_toujours_100__4_;
					this.radGridView1.Templates.Clear();
				}
				else
				{
					MessageBox.Show("Erreur : L'article est déja ajouté", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00065370 File Offset: 0x00063570
		private int search_tableau(string s)
		{
			int result = 0;
			bool flag = this.radGridView1.Rows.Count != 0;
			if (flag)
			{
				for (int i = 0; i < this.radGridView1.Rows.Count; i++)
				{
					bool flag2 = Convert.ToString(this.radGridView1.Rows[i].Cells[0].Value) == s;
					if (flag2)
					{
						result = 1;
					}
				}
			}
			return result;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000653F8 File Offset: 0x000635F8
		private void action_tableau(object sender, GridViewCellEventArgs e)
		{
			bool flag = this.radGridView1.Rows.Count != 0;
			if (flag)
			{
				bool flag2 = e.RowIndex != -1;
				if (flag2)
				{
					bool flag3 = e.RowIndex >= 0 && e.ColumnIndex == 4;
					if (flag3)
					{
						string text = this.radGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
						DialogResult dialogResult = MessageBox.Show("Vous voulez supprimer ?", "ALERTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						bool flag4 = dialogResult == DialogResult.Yes;
						if (flag4)
						{
							this.radGridView1.Rows.RemoveAt(e.RowIndex);
						}
					}
				}
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000654B8 File Offset: 0x000636B8
		private void select_article_bsm()
		{
			bd bd = new bd();
			string cmdText = "";
			this.radGridView1.Rows.Clear();
			bool flag = this.type_stock == "Neuf";
			if (flag)
			{
				cmdText = "select id_article, article.designation, quantite,article.stock_neuf  from bsm_article inner join article on bsm_article.id_article = article.id where id_bsm = @i";
			}
			bool flag2 = this.type_stock == "Usé";
			if (flag2)
			{
				cmdText = "select id_article, article.designation, quantite,article.stock_use  from bsm_article inner join article on bsm_article.id_article = article.id where id_bsm = @i";
			}
			bool flag3 = this.type_stock == "Rebuté";
			if (flag3)
			{
				cmdText = "select id_article, article.designation, quantite,article.stock_rebute  from bsm_article inner join article on bsm_article.id_article = article.id where id_bsm = @i";
			}
			SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
			sqlCommand.Parameters.Add("@i", SqlDbType.Int).Value = historique_bsm.id_bsm;
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			bool flag4 = dataTable.Rows.Count != 0;
			if (flag4)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					this.radGridView1.Rows.Add(new object[]
					{
						Convert.ToString(dataTable.Rows[i].ItemArray[0]),
						Convert.ToString(dataTable.Rows[i].ItemArray[1]),
						Convert.ToString(dataTable.Rows[i].ItemArray[2]),
						Convert.ToDouble(dataTable.Rows[i].ItemArray[3]) + Convert.ToDouble(dataTable.Rows[i].ItemArray[2])
					});
					this.radGridView1.Rows[this.radGridView1.Rows.Count - 1].Cells[4].Value = Resources.icons8_supprimer_pour_toujours_100__4_;
				}
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000656A4 File Offset: 0x000638A4
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			bd bd = new bd();
			fonction fonction = new fonction();
			bool flag = this.radGridView1.Rows.Count != 0;
			if (flag)
			{
				int num = 1;
				for (int i = 0; i < this.radGridView1.Rows.Count; i++)
				{
					bool flag2 = fonction.is_reel(this.radGridView1.Rows[i].Cells[2].Value.ToString());
					if (flag2)
					{
						bool flag3 = Convert.ToDouble(this.radGridView1.Rows[i].Cells[2].Value.ToString()) <= 0.0;
						if (flag3)
						{
							num = 0;
						}
					}
					else
					{
						num = 0;
					}
				}
				bool flag4 = num == 1;
				if (flag4)
				{
					int num2 = 1;
					for (int j = 0; j < this.radGridView1.Rows.Count; j++)
					{
						bool flag5 = Convert.ToDouble(this.radGridView1.Rows[j].Cells[2].Value.ToString()) > Convert.ToDouble(this.radGridView1.Rows[j].Cells[3].Value.ToString());
						if (flag5)
						{
							num2 = 0;
						}
					}
					bool flag6 = num2 == 1;
					if (flag6)
					{
						bool flag7 = this.type_stock == "Neuf";
						if (flag7)
						{
							string cmdText = "select id_article, quantite from bsm_article where id_bsm = @i";
							SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
							sqlCommand.Parameters.Add("@i", SqlDbType.Int).Value = historique_bsm.id_bsm;
							SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
							DataTable dataTable = new DataTable();
							sqlDataAdapter.Fill(dataTable);
							bool flag8 = dataTable.Rows.Count != 0;
							if (flag8)
							{
								for (int k = 0; k < dataTable.Rows.Count; k++)
								{
									string cmdText2 = "update article set stock_neuf = stock_neuf + @v where id = @i";
									SqlCommand sqlCommand2 = new SqlCommand(cmdText2, bd.cnn);
									sqlCommand2.Parameters.Add("@i", SqlDbType.Int).Value = dataTable.Rows[k].ItemArray[0];
									sqlCommand2.Parameters.Add("@v", SqlDbType.Real).Value = dataTable.Rows[k].ItemArray[1];
									bd.ouverture_bd(bd.cnn);
									sqlCommand2.ExecuteNonQuery();
									bd.cnn.Close();
								}
							}
						}
						bool flag9 = this.type_stock == "Usé";
						if (flag9)
						{
							string cmdText3 = "select id_article, quantite from bsm_article where id_bsm = @i";
							SqlCommand sqlCommand3 = new SqlCommand(cmdText3, bd.cnn);
							sqlCommand3.Parameters.Add("@i", SqlDbType.Int).Value = historique_bsm.id_bsm;
							SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand3);
							DataTable dataTable2 = new DataTable();
							sqlDataAdapter2.Fill(dataTable2);
							bool flag10 = dataTable2.Rows.Count != 0;
							if (flag10)
							{
								for (int l = 0; l < dataTable2.Rows.Count; l++)
								{
									string cmdText4 = "update article set stock_usé = stock_usé + @v where id = @i";
									SqlCommand sqlCommand4 = new SqlCommand(cmdText4, bd.cnn);
									sqlCommand4.Parameters.Add("@i", SqlDbType.Int).Value = dataTable2.Rows[l].ItemArray[0];
									sqlCommand4.Parameters.Add("@v", SqlDbType.Real).Value = dataTable2.Rows[l].ItemArray[1];
									bd.ouverture_bd(bd.cnn);
									sqlCommand4.ExecuteNonQuery();
									bd.cnn.Close();
								}
							}
						}
						bool flag11 = this.type_stock == "Rebuté";
						if (flag11)
						{
							string cmdText5 = "select id_article, quantite from bsm_article where id_bsm = @i";
							SqlCommand sqlCommand5 = new SqlCommand(cmdText5, bd.cnn);
							sqlCommand5.Parameters.Add("@i", SqlDbType.Int).Value = historique_bsm.id_bsm;
							SqlDataAdapter sqlDataAdapter3 = new SqlDataAdapter(sqlCommand5);
							DataTable dataTable3 = new DataTable();
							sqlDataAdapter3.Fill(dataTable3);
							bool flag12 = dataTable3.Rows.Count != 0;
							if (flag12)
							{
								for (int m = 0; m < dataTable3.Rows.Count; m++)
								{
									string cmdText6 = "update article set stock_rebute = stock_rebute + @v where id = @i";
									SqlCommand sqlCommand6 = new SqlCommand(cmdText6, bd.cnn);
									sqlCommand6.Parameters.Add("@i", SqlDbType.Int).Value = dataTable3.Rows[m].ItemArray[0];
									sqlCommand6.Parameters.Add("@v", SqlDbType.Real).Value = dataTable3.Rows[m].ItemArray[1];
									bd.ouverture_bd(bd.cnn);
									sqlCommand6.ExecuteNonQuery();
									bd.cnn.Close();
								}
							}
						}
						string cmdText7 = "delete bsm_article where id_bsm = @i";
						SqlCommand sqlCommand7 = new SqlCommand(cmdText7, bd.cnn);
						sqlCommand7.Parameters.Add("@i", SqlDbType.Int).Value = historique_bsm.id_bsm;
						bd.ouverture_bd(bd.cnn);
						sqlCommand7.ExecuteNonQuery();
						bd.cnn.Close();
						for (int n = 0; n < this.radGridView1.Rows.Count; n++)
						{
							string cmdText8 = "select prix_ht from article where id = @i";
							SqlCommand sqlCommand8 = new SqlCommand(cmdText8, bd.cnn);
							sqlCommand8.Parameters.Add("@i", SqlDbType.Int).Value = this.radGridView1.Rows[n].Cells[0].Value.ToString();
							SqlDataAdapter sqlDataAdapter4 = new SqlDataAdapter(sqlCommand8);
							DataTable dataTable4 = new DataTable();
							sqlDataAdapter4.Fill(dataTable4);
							string cmdText9 = "insert into bsm_article (id_bsm, id_article, quantite, prix_ht) values (@v1, @v2, @v3, @v4)";
							SqlCommand sqlCommand9 = new SqlCommand(cmdText9, bd.cnn);
							sqlCommand9.Parameters.Add("@v1", SqlDbType.Int).Value = historique_bsm.id_bsm;
							sqlCommand9.Parameters.Add("@v2", SqlDbType.Int).Value = this.radGridView1.Rows[n].Cells[0].Value;
							sqlCommand9.Parameters.Add("@v3", SqlDbType.Real).Value = this.radGridView1.Rows[n].Cells[2].Value;
							sqlCommand9.Parameters.Add("@v4", SqlDbType.Real).Value = Convert.ToString(dataTable4.Rows[0].ItemArray[0]);
							string cmdText10 = "";
							bool flag13 = this.type_stock == "Neuf";
							if (flag13)
							{
								cmdText10 = "update article set stock_neuf = stock_neuf - @v where id = @i";
							}
							bool flag14 = this.type_stock == "Usé";
							if (flag14)
							{
								cmdText10 = "update article set stock_use = stock_use - @v where id = @i";
							}
							bool flag15 = this.type_stock == "Rebuté";
							if (flag15)
							{
								cmdText10 = "update article set stock_rebute = stock_rebute - @v where id = @i";
							}
							SqlCommand sqlCommand10 = new SqlCommand(cmdText10, bd.cnn);
							sqlCommand10.Parameters.Add("@i", SqlDbType.Int).Value = this.radGridView1.Rows[n].Cells[0].Value.ToString();
							sqlCommand10.Parameters.Add("@v", SqlDbType.Real).Value = this.radGridView1.Rows[n].Cells[2].Value.ToString();
							bd.ouverture_bd(bd.cnn);
							sqlCommand9.ExecuteNonQuery();
							sqlCommand10.ExecuteNonQuery();
							bd.cnn.Close();
						}
						this.bsm_article_Load(sender, e);
						historique_bsm.remplissage_tableau(2);
						MessageBox.Show("Modification avec succés");
					}
					else
					{
						MessageBox.Show("Erreur : La quantité choisit doit être inférieure ou égale à la quantité en stock", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				else
				{
					MessageBox.Show("Erreur : La quantité doit être un réel strictement positive", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				MessageBox.Show("Erreur : Il faut choisir au moin un article dans le BSM", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x04000323 RID: 803
		private string type_stock = "";
	}
}
