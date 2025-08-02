using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Localization;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Export;
using Telerik.WinControls.UI.Localization;

namespace GMAO
{
	// Token: 0x02000034 RID: 52
	public partial class budget_investissement : Form
	{
		// Token: 0x0600026A RID: 618 RVA: 0x00068B00 File Offset: 0x00066D00
		public budget_investissement()
		{
			this.InitializeComponent();
			LocalizationProvider<RadGridLocalizationProvider>.CurrentProvider = new test_rad();
			this.radGridView1.ViewCellFormatting += new CellFormattingEventHandler(fonction.select_change);
			this.radGridView1.ViewRowFormatting += new RowFormattingEventHandler(fonction.select_changee);
			this.radGridView1.FilterChanged += new GridViewCollectionChangedEventHandler(this.RadGridView1_FilterChanged);
			this.radDateTimePicker1.ValueChanged += delegate(object s, EventArgs f)
			{
				this.remplissage_tableau(0);
			};
			this.radDateTimePicker2.ValueChanged += delegate(object s, EventArgs f)
			{
				this.remplissage_tableau(0);
			};
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00068BA6 File Offset: 0x00066DA6
		private void RadGridView1_FilterChanged(object sender, GridViewCollectionChangedEventArgs e)
		{
			this.change_somme();
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00068BB0 File Offset: 0x00066DB0
		private void budget_investissement_Load(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			DateTime value = new DateTime(now.Year, now.Month, 1);
			this.radDateTimePicker1.Value = value;
			this.radDateTimePicker2.Value = value.AddMonths(1).AddDays(-1.0);
			this.remplissage_tableau(0);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00068C14 File Offset: 0x00066E14
		private void remplissage_tableau(int o)
		{
			this.radGridView1.Rows.Clear();
			this.radGridView1.AllowDragToGroup = false;
			this.radGridView1.AllowAddNewRow = false;
			this.radGridView1.MasterView.TableSearchRow.SuspendSearch();
			string cmdText = "select  distinct(livraison_article.id), livraison_article.id_livraison, bon_livraison.bl_fournisseur, bon_livraison.date_reel, article.code_article, article.designation,fournisseur.nom,  livraison_article.qt, livraison_article.prix_ht, livraison_article.remise, (livraison_article.qt * livraison_article.prix_ht) - ((livraison_article.qt * livraison_article.prix_ht) * ((livraison_article.remise) / 100)) from livraison_article inner join bon_livraison on livraison_article.id_livraison = bon_livraison.id inner join article on livraison_article.id_article = article.id inner join reception on bon_livraison.id_reception = reception.id inner join reception_article on reception.id = reception_article.id_reception inner join commande on reception_article.id_commande = commande.id inner join fournisseur on commande.id_fournisseur = fournisseur.id where bon_livraison.date_reel between @d1 and @d2 and livraison_article.investissement = @d order by bon_livraison.date_reel ";
			bd bd = new bd();
			SqlCommand sqlCommand = new SqlCommand(cmdText, bd.cnn);
			sqlCommand.Parameters.Add("@d", SqlDbType.Int).Value = 1;
			sqlCommand.Parameters.Add("@d1", SqlDbType.Date).Value = this.radDateTimePicker1.Value;
			sqlCommand.Parameters.Add("@d2", SqlDbType.Date).Value = this.radDateTimePicker2.Value;
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count != 0;
			if (flag)
			{
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					this.radGridView1.Rows.Add(new object[]
					{
						dataTable.Rows[i].ItemArray[1].ToString(),
						Convert.ToString(dataTable.Rows[i].ItemArray[2].ToString()),
						fonction.Mid(dataTable.Rows[i].ItemArray[3].ToString(), 1, 10),
						dataTable.Rows[i].ItemArray[4].ToString(),
						dataTable.Rows[i].ItemArray[5].ToString(),
						dataTable.Rows[i].ItemArray[6].ToString(),
						Convert.ToDouble(dataTable.Rows[i].ItemArray[7]),
						Convert.ToDouble(dataTable.Rows[i].ItemArray[8]).ToString("0.000"),
						Convert.ToDouble(dataTable.Rows[i].ItemArray[9]),
						Convert.ToDouble(dataTable.Rows[i].ItemArray[10]).ToString("0.000")
					});
				}
			}
			bool flag2 = this.radGridView1.Rows.Count != 0;
			if (flag2)
			{
				bool flag3 = o == 0;
				if (flag3)
				{
					this.radGridView1.MasterTemplate.MoveToFirstPage();
					this.radGridView1.Rows[0].IsCurrent = true;
				}
			}
			this.radGridView1.MasterView.TableSearchRow.ShowCloseButton = false;
			this.radGridView1.Templates.Clear();
			this.radGridView1.MasterView.TableSearchRow.ResumeSearch();
			this.change_somme();
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00068F48 File Offset: 0x00067148
		private void radButton8_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = "";
			saveFileDialog.ShowDialog();
			bool flag = false;
			bool flag2 = saveFileDialog.FileName != "";
			if (flag2)
			{
				this.RunExportToexcel(saveFileDialog.FileName, ref flag);
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00068F98 File Offset: 0x00067198
		private void RunExportToexcel(string fileName, ref bool openExportFile)
		{
			new ExportToExcelML(this.radGridView1)
			{
				SummariesExportOption = 0,
				ChildViewExportMode = 3,
				PagingExportOption = 1,
				HiddenRowOption = 0,
				HiddenColumnOption = 0,
				ExportHierarchy = true
			}.RunExport(fileName);
			RadMessageBox.SetThemeName(this.radGridView1.ThemeName);
			MessageBox.Show("Enregistrement avec succés");
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00069008 File Offset: 0x00067208
		private void change_somme()
		{
			double num = 0.0;
			int num2 = 0;
			GridDataView gridDataView = this.radGridView1.MasterTemplate.DataView as GridDataView;
			foreach (GridViewRowInfo gridViewRowInfo in gridDataView.Indexer.Items)
			{
				num += Convert.ToDouble(gridViewRowInfo.Cells[9].Value);
				num2++;
			}
			this.label2.Text = num.ToString("0.000") + " Dinars";
		}
	}
}
