using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GMAO
{
	// Token: 0x02000030 RID: 48
	public partial class bsm : Form
	{
		// Token: 0x0600024B RID: 587 RVA: 0x000647C2 File Offset: 0x000629C2
		public bsm()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000647DC File Offset: 0x000629DC
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			Pen pen = new Pen(Color.Firebrick);
			pen.Width = 1f;
			e.Graphics.DrawLine(pen, 1, 1, 1148, 1);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00064818 File Offset: 0x00062A18
		private void bsm_Load(object sender, EventArgs e)
		{
			menu_bsm menu_bsm = new menu_bsm();
			menu_bsm.TopLevel = false;
			menu_bsm.button1.BackColor = Color.White;
			menu_bsm.button1.ForeColor = Color.Firebrick;
			menu_bsm.button2.BackColor = Color.Firebrick;
			menu_bsm.button2.ForeColor = Color.White;
			this.panel2.Controls.Clear();
			this.panel2.Controls.Add(menu_bsm);
			menu_bsm.Show();
			bool flag = page_loginn.stat_user == "Administrateur";
			if (flag)
			{
				menu_bsm.button2.BackColor = Color.White;
				menu_bsm.button2.ForeColor = Color.Firebrick;
				menu_bsm.button1.BackColor = Color.Firebrick;
				menu_bsm.button1.ForeColor = Color.White;
				historique_bsm historique_bsm = new historique_bsm();
				historique_bsm.TopLevel = false;
				bsm.panel3.Controls.Clear();
				bsm.panel3.Controls.Add(historique_bsm);
				historique_bsm.Show();
			}
			else
			{
				creer_bsm creer_bsm = new creer_bsm();
				creer_bsm.TopLevel = false;
				bsm.panel3.Controls.Clear();
				bsm.panel3.Controls.Add(creer_bsm);
				creer_bsm.Show();
			}
		}
	}
}
