namespace GMAO
{
	// Token: 0x02000030 RID: 48
	public partial class bsm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600024E RID: 590 RVA: 0x0006496C File Offset: 0x00062B6C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000649A4 File Offset: 0x00062BA4
		private void InitializeComponent()
		{
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			global::GMAO.bsm.panel3 = new global::System.Windows.Forms.Panel();
			base.SuspendLayout();
			this.panel2.Location = new global::System.Drawing.Point(-1, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(1148, 25);
			this.panel2.TabIndex = 11;
			this.panel1.Location = new global::System.Drawing.Point(-3, 26);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(1148, 10);
			this.panel1.TabIndex = 12;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			global::GMAO.bsm.panel3.Location = new global::System.Drawing.Point(7, 42);
			global::GMAO.bsm.panel3.Name = "panel3";
			global::GMAO.bsm.panel3.Size = new global::System.Drawing.Size(1128, 558);
			global::GMAO.bsm.panel3.TabIndex = 13;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(1147, 612);
			base.Controls.Add(global::GMAO.bsm.panel3);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.panel2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "bsm";
			base.ShowIcon = false;
			base.Load += new global::System.EventHandler(this.bsm_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x0400031F RID: 799
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000320 RID: 800
		public global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000321 RID: 801
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000322 RID: 802
		public static global::System.Windows.Forms.Panel panel3;
	}
}
