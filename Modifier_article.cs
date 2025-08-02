using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace GMAO
{
	// Token: 0x02000098 RID: 152
	public partial class Modifier_article : Form
	{
		// Token: 0x060006F3 RID: 1779 RVA: 0x0012ECFC File Offset: 0x0012CEFC
		public Modifier_article()
		{
			this.InitializeComponent();
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0012ED14 File Offset: 0x0012CF14
		private void Modifier_article_Load(object sender, EventArgs e)
		{
			this.label1.Text = liste_article_simple.id_article;
			string cmdText = "select reference, designation, marque, prix_ht, stock_neuf, stock_use, stock_rebute from article where id = @i";
			bd bd = new bd();
			SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
			sqlCommand.Parameters.Add("@i", SqlDbType.Int).Value = liste_article_simple.id_article;
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count != 0;
			if (flag)
			{
				this.TextBox1.Text = Convert.ToString(dataTable.Rows[0].ItemArray[0]);
				this.TextBox2.Text = Convert.ToString(dataTable.Rows[0].ItemArray[1]);
				this.TextBox3.Text = Convert.ToString(dataTable.Rows[0].ItemArray[2]);
				this.TextBox4.Text = Convert.ToString(dataTable.Rows[0].ItemArray[3]);
				this.TextBox5.Text = Convert.ToString(dataTable.Rows[0].ItemArray[4]);
				this.TextBox6.Text = Convert.ToString(dataTable.Rows[0].ItemArray[5]);
				this.TextBox7.Text = Convert.ToString(dataTable.Rows[0].ItemArray[6]);
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0012EE9C File Offset: 0x0012D09C
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			fonction fonction = new fonction();
			bool flag = fonction.DeleteSpace(this.TextBox1.Text) != "" & fonction.DeleteSpace(this.TextBox2.Text) != "" & fonction.DeleteSpace(this.TextBox4.Text) != "" & fonction.DeleteSpace(this.TextBox5.Text) != "" & fonction.DeleteSpace(this.TextBox6.Text) != "" & fonction.DeleteSpace(this.TextBox7.Text) != "";
			if (flag)
			{
				bool flag2 = fonction.is_reel(this.TextBox4.Text) & fonction.is_reel(this.TextBox5.Text) & fonction.is_reel(this.TextBox6.Text) & fonction.is_reel(this.TextBox7.Text);
				if (flag2)
				{
					bd bd = new bd();
					string cmdText = "update article set reference = @v1, designation = @v2, marque = @v3, prix_ht = @v4, stock_neuf = @v5, stock_use = @v6, stock_rebute = @v7 where id = @i";
					SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
					sqlCommand.Parameters.Add("@i", SqlDbType.Int).Value = this.label1.Text;
					sqlCommand.Parameters.Add("@v1", SqlDbType.VarChar).Value = this.TextBox1.Text;
					sqlCommand.Parameters.Add("@v2", SqlDbType.VarChar).Value = this.TextBox2.Text;
					sqlCommand.Parameters.Add("@v3", SqlDbType.VarChar).Value = this.TextBox3.Text;
					sqlCommand.Parameters.Add("@v4", SqlDbType.Real).Value = this.TextBox4.Text;
					sqlCommand.Parameters.Add("@v5", SqlDbType.Real).Value = this.TextBox5.Text;
					sqlCommand.Parameters.Add("@v6", SqlDbType.Real).Value = this.TextBox6.Text;
					sqlCommand.Parameters.Add("@v7", SqlDbType.Real).Value = this.TextBox7.Text;
					bd.ouverture_bd(bd.cnn);
					sqlCommand.ExecuteNonQuery();
					bd.cnn.Close();
					MessageBox.Show("Modification avec succés");
					base.Close();
				}
				else
				{
					MessageBox.Show("Erreur : Prix_Ht et quantité en stock sont des réels strictement positives", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				MessageBox.Show("Erreur : Un champs obligatoire est vide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
	}
}
