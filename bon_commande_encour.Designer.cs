namespace GMAO
{
	// Token: 0x0200002C RID: 44
	public partial class bon_commande_encour : global::System.Windows.Forms.Form
	{
		// Token: 0x06000235 RID: 565 RVA: 0x0005F834 File Offset: 0x0005DA34
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0005F86C File Offset: 0x0005DA6C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::GMAO.bon_commande_encour));
			this.radRichTextEditor1 = new global::Telerik.WinControls.UI.RadRichTextEditor();
			this.fluentTheme1 = new global::Telerik.WinControls.Themes.FluentTheme();
			this.richTextEditorRibbonBar1 = new global::Telerik.WinControls.UI.RichTextEditorRibbonBar();
			this.radRichTextEditor1.BeginInit();
			this.richTextEditorRibbonBar1.BeginInit();
			base.SuspendLayout();
			this.radRichTextEditor1.AutoScroll = true;
			this.radRichTextEditor1.BorderColor = global::System.Drawing.Color.FromArgb(156, 189, 232);
			this.radRichTextEditor1.LayoutMode = new global::Telerik.WinForms.Documents.Model.DocumentLayoutMode?(0);
			this.radRichTextEditor1.Location = new global::System.Drawing.Point(12, 180);
			this.radRichTextEditor1.Name = "radRichTextEditor1";
			this.radRichTextEditor1.SelectionFill = global::System.Drawing.Color.FromArgb(128, 78, 158, 255);
			this.radRichTextEditor1.SelectionStroke = global::System.Drawing.Color.FromArgb(179, 236, 248);
			this.radRichTextEditor1.Size = new global::System.Drawing.Size(821, 465);
			this.radRichTextEditor1.TabIndex = 0;
			this.radRichTextEditor1.ThemeName = "Fluent";
			this.richTextEditorRibbonBar1.ApplicationMenuStyle = 1;
			this.richTextEditorRibbonBar1.AssociatedRichTextEditor = this.radRichTextEditor1;
			this.richTextEditorRibbonBar1.BuiltInStylesVersion = 2;
			this.richTextEditorRibbonBar1.EnableKeyMap = false;
			this.richTextEditorRibbonBar1.ExitButton.Text = "Exit";
			this.richTextEditorRibbonBar1.LocalizationSettings.LayoutModeText = "Simplified Layout";
			this.richTextEditorRibbonBar1.Location = new global::System.Drawing.Point(0, 0);
			this.richTextEditorRibbonBar1.Name = "richTextEditorRibbonBar1";
			this.richTextEditorRibbonBar1.OptionsButton.Text = "Options";
			this.richTextEditorRibbonBar1.ShowLayoutModeButton = true;
			this.richTextEditorRibbonBar1.SimplifiedHeight = 100;
			this.richTextEditorRibbonBar1.Size = new global::System.Drawing.Size(852, 169);
			this.richTextEditorRibbonBar1.StartButtonImage = (global::System.Drawing.Image)componentResourceManager.GetObject("richTextEditorRibbonBar1.StartButtonImage");
			this.richTextEditorRibbonBar1.TabIndex = 1;
			this.richTextEditorRibbonBar1.TabStop = false;
			this.richTextEditorRibbonBar1.ThemeName = "Fluent";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(852, 647);
			base.Controls.Add(this.richTextEditorRibbonBar1);
			base.Controls.Add(this.radRichTextEditor1);
			base.Name = "bon_commande_encour";
			base.ShowIcon = false;
			base.Load += new global::System.EventHandler(this.bon_commande_encour_Load);
			this.radRichTextEditor1.EndInit();
			this.richTextEditorRibbonBar1.EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400030F RID: 783
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000310 RID: 784
		private global::Telerik.WinControls.UI.RadRichTextEditor radRichTextEditor1;

		// Token: 0x04000311 RID: 785
		private global::Telerik.WinControls.UI.RichTextEditorRibbonBar richTextEditorRibbonBar1;

		// Token: 0x04000312 RID: 786
		private global::Telerik.WinControls.Themes.FluentTheme fluentTheme1;
	}
}
