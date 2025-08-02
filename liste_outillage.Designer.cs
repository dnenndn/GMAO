namespace GMAO
{
	// Token: 0x02000090 RID: 144
	public partial class liste_outillage : global::System.Windows.Forms.Form
	{
		// Token: 0x060006C8 RID: 1736 RVA: 0x001255B4 File Offset: 0x001237B4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x001255EC File Offset: 0x001237EC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::GMAO.liste_outillage));
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn = new global::Telerik.WinControls.UI.GridViewImageColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn2 = new global::Telerik.WinControls.UI.GridViewImageColumn();
			global::Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn3 = new global::Telerik.WinControls.UI.GridViewImageColumn();
			global::Telerik.WinControls.Data.SortDescriptor sortDescriptor = new global::Telerik.WinControls.Data.SortDescriptor();
			global::Telerik.WinControls.UI.TableViewDefinition viewDefinition = new global::Telerik.WinControls.UI.TableViewDefinition();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.fab_radTextBox1 = new global::Telerik.WinControls.UI.RadTextBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.remarque_radTextBox1 = new global::Telerik.WinControls.UI.RadTextBox();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.design_radTextBox1 = new global::Telerik.WinControls.UI.RadTextBox();
			this.radGridView1 = new global::Telerik.WinControls.UI.RadGridView();
			this.prix_radTextBox5 = new global::Telerik.WinControls.UI.RadTextBox();
			this.nserie_radTextBox2 = new global::Telerik.WinControls.UI.RadTextBox();
			this.nmodel_radTextBox3 = new global::Telerik.WinControls.UI.RadTextBox();
			this.codeoutil_radTextBox1 = new global::Telerik.WinControls.UI.RadTextBox();
			this.crystalTheme1 = new global::Telerik.WinControls.Themes.CrystalTheme();
			this.fluentTheme1 = new global::Telerik.WinControls.Themes.FluentTheme();
			this.sec_radDropDownList1 = new global::Telerik.WinControls.UI.RadDropDownList();
			this.type_radDropDownList1 = new global::Telerik.WinControls.UI.RadDropDownList();
			this.etat_radDropDownList1 = new global::Telerik.WinControls.UI.RadDropDownList();
			this.radCheckedDropDownList1 = new global::Telerik.WinControls.UI.RadCheckedDropDownList();
			this.achat_radDateTimePicker1 = new global::Telerik.WinControls.UI.RadDateTimePicker();
			this.fingarantie_radDateTimePicker2 = new global::Telerik.WinControls.UI.RadDateTimePicker();
			this.miservice_radDateTimePicker3 = new global::Telerik.WinControls.UI.RadDateTimePicker();
			this.button1 = new global::Telerik.WinControls.UI.RadButton();
			this.button2 = new global::Telerik.WinControls.UI.RadButton();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.fab_radTextBox1.BeginInit();
			this.remarque_radTextBox1.BeginInit();
			this.design_radTextBox1.BeginInit();
			this.radGridView1.BeginInit();
			this.radGridView1.MasterTemplate.BeginInit();
			this.prix_radTextBox5.BeginInit();
			this.nserie_radTextBox2.BeginInit();
			this.nmodel_radTextBox3.BeginInit();
			this.codeoutil_radTextBox1.BeginInit();
			this.sec_radDropDownList1.BeginInit();
			this.type_radDropDownList1.BeginInit();
			this.etat_radDropDownList1.BeginInit();
			this.radCheckedDropDownList1.BeginInit();
			this.achat_radDateTimePicker1.BeginInit();
			this.fingarantie_radDateTimePicker2.BeginInit();
			this.miservice_radDateTimePicker3.BeginInit();
			this.button1.BeginInit();
			this.button2.BeginInit();
			base.SuspendLayout();
			this.pictureBox2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(124, 53);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(45, 34);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 70;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new global::System.EventHandler(this.pictureBox2_Click);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(19, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(99, 82);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 69;
			this.pictureBox1.TabStop = false;
			this.fab_radTextBox1.Location = new global::System.Drawing.Point(112, 235);
			this.fab_radTextBox1.Name = "fab_radTextBox1";
			this.fab_radTextBox1.Size = new global::System.Drawing.Size(164, 24);
			this.fab_radTextBox1.TabIndex = 67;
			this.fab_radTextBox1.ThemeName = "Crystal";
			this.label14.AutoSize = true;
			this.label14.Location = new global::System.Drawing.Point(28, 385);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(56, 13);
			this.label14.TabIndex = 66;
			this.label14.Text = "Remarque";
			this.remarque_radTextBox1.Location = new global::System.Drawing.Point(113, 378);
			this.remarque_radTextBox1.Name = "remarque_radTextBox1";
			this.remarque_radTextBox1.Size = new global::System.Drawing.Size(163, 24);
			this.remarque_radTextBox1.TabIndex = 44;
			this.remarque_radTextBox1.ThemeName = "Crystal";
			this.label13.AutoSize = true;
			this.label13.Location = new global::System.Drawing.Point(26, 469);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(55, 13);
			this.label13.TabIndex = 65;
			this.label13.Text = "Utilisation ";
			this.label12.AutoSize = true;
			this.label12.Location = new global::System.Drawing.Point(27, 441);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(71, 13);
			this.label12.TabIndex = 64;
			this.label12.Text = "Etat de l’outil ";
			this.label11.AutoSize = true;
			this.label11.Location = new global::System.Drawing.Point(27, 411);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(34, 13);
			this.label11.TabIndex = 63;
			this.label11.Text = "Type ";
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(27, 352);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(63, 26);
			this.label10.TabIndex = 62;
			this.label10.Text = "Prix d’achat\r\n      TTC";
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(28, 322);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(81, 13);
			this.label9.TabIndex = 61;
			this.label9.Text = "Mise en service";
			this.label8.AutoSize = true;
			this.label8.Location = new global::System.Drawing.Point(28, 296);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(77, 13);
			this.label8.TabIndex = 60;
			this.label8.Text = "Fin de garantie";
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(27, 270);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(69, 13);
			this.label7.TabIndex = 59;
			this.label7.Text = "Date d’achat";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(28, 242);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(57, 13);
			this.label6.TabIndex = 58;
			this.label6.Text = "Fabriquant";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(27, 216);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(57, 13);
			this.label5.TabIndex = 57;
			this.label5.Text = "N° Modèle";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(27, 190);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(46, 13);
			this.label4.TabIndex = 56;
			this.label4.Text = "N° Série";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(27, 164);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(44, 13);
			this.label3.TabIndex = 55;
			this.label3.Text = "Secteur";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(26, 138);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(63, 13);
			this.label2.TabIndex = 54;
			this.label2.Text = "Désignation";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(28, 112);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(54, 13);
			this.label1.TabIndex = 53;
			this.label1.Text = "Code outil";
			this.design_radTextBox1.Location = new global::System.Drawing.Point(113, 131);
			this.design_radTextBox1.Name = "design_radTextBox1";
			this.design_radTextBox1.Size = new global::System.Drawing.Size(163, 24);
			this.design_radTextBox1.TabIndex = 42;
			this.design_radTextBox1.ThemeName = "Crystal";
			this.radGridView1.BackColor = global::System.Drawing.SystemColors.Control;
			this.radGridView1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.radGridView1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f);
			this.radGridView1.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.radGridView1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radGridView1.Location = new global::System.Drawing.Point(296, 38);
			this.radGridView1.MasterTemplate.AllowAddNewRow = false;
			this.radGridView1.MasterTemplate.AllowColumnReorder = false;
			this.radGridView1.MasterTemplate.AllowSearchRow = true;
			gridViewTextBoxColumn.EnableExpressionEditor = false;
			gridViewTextBoxColumn.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			gridViewTextBoxColumn.IsVisible = false;
			gridViewTextBoxColumn.Name = "column1";
			gridViewImageColumn.EnableExpressionEditor = false;
			gridViewImageColumn.HeaderText = "";
			gridViewImageColumn.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewImageColumn.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			gridViewImageColumn.Name = "column18";
			gridViewImageColumn.Width = 150;
			gridViewTextBoxColumn2.EnableExpressionEditor = false;
			gridViewTextBoxColumn2.HeaderText = "Code outil";
			gridViewTextBoxColumn2.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn2.Name = "column2";
			gridViewTextBoxColumn2.Width = 100;
			gridViewTextBoxColumn3.EnableExpressionEditor = false;
			gridViewTextBoxColumn3.HeaderText = "Désignation";
			gridViewTextBoxColumn3.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn3.Name = "column3";
			gridViewTextBoxColumn3.Width = 100;
			gridViewTextBoxColumn4.EnableExpressionEditor = false;
			gridViewTextBoxColumn4.HeaderText = "Secteur";
			gridViewTextBoxColumn4.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn4.Name = "column4";
			gridViewTextBoxColumn4.Width = 100;
			gridViewTextBoxColumn5.EnableExpressionEditor = false;
			gridViewTextBoxColumn5.HeaderText = "N° Série";
			gridViewTextBoxColumn5.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn5.Name = "column5";
			gridViewTextBoxColumn5.Width = 100;
			gridViewTextBoxColumn6.EnableExpressionEditor = false;
			gridViewTextBoxColumn6.HeaderText = "N° Modèle";
			gridViewTextBoxColumn6.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn6.Name = "column6";
			gridViewTextBoxColumn6.Width = 100;
			gridViewTextBoxColumn7.EnableExpressionEditor = false;
			gridViewTextBoxColumn7.HeaderText = "Fabriquant";
			gridViewTextBoxColumn7.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn7.Name = "column7";
			gridViewTextBoxColumn7.Width = 100;
			gridViewTextBoxColumn8.EnableExpressionEditor = false;
			gridViewTextBoxColumn8.HeaderText = "Date d'achat";
			gridViewTextBoxColumn8.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn8.Name = "column8";
			gridViewTextBoxColumn8.Width = 100;
			gridViewTextBoxColumn9.EnableExpressionEditor = false;
			gridViewTextBoxColumn9.HeaderText = "Fin de garantie";
			gridViewTextBoxColumn9.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn9.Name = "column9";
			gridViewTextBoxColumn9.Width = 100;
			gridViewTextBoxColumn10.EnableExpressionEditor = false;
			gridViewTextBoxColumn10.HeaderText = "Mise en service";
			gridViewTextBoxColumn10.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn10.Name = "column10";
			gridViewTextBoxColumn10.Width = 100;
			gridViewTextBoxColumn11.EnableExpressionEditor = false;
			gridViewTextBoxColumn11.HeaderText = "Prix d'achat";
			gridViewTextBoxColumn11.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn11.Name = "column11";
			gridViewTextBoxColumn11.Width = 100;
			gridViewTextBoxColumn12.EnableExpressionEditor = false;
			gridViewTextBoxColumn12.HeaderText = "Remarque";
			gridViewTextBoxColumn12.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn12.Name = "column12";
			gridViewTextBoxColumn12.Width = 100;
			gridViewTextBoxColumn13.EnableExpressionEditor = false;
			gridViewTextBoxColumn13.HeaderText = "Type";
			gridViewTextBoxColumn13.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn13.Name = "column13";
			gridViewTextBoxColumn13.Width = 100;
			gridViewTextBoxColumn14.EnableExpressionEditor = false;
			gridViewTextBoxColumn14.HeaderText = "Etat de l'outil";
			gridViewTextBoxColumn14.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn14.Name = "column14";
			gridViewTextBoxColumn14.SortOrder = 0;
			gridViewTextBoxColumn14.Width = 100;
			gridViewTextBoxColumn15.EnableExpressionEditor = false;
			gridViewTextBoxColumn15.HeaderText = "Utilisation";
			gridViewTextBoxColumn15.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn15.Name = "column15";
			gridViewTextBoxColumn15.Width = 100;
			gridViewImageColumn2.EnableExpressionEditor = true;
			gridViewImageColumn2.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			gridViewImageColumn2.Name = "column16";
			gridViewImageColumn2.Width = 100;
			gridViewImageColumn3.EnableExpressionEditor = false;
			gridViewImageColumn3.ImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			gridViewImageColumn3.Name = "column17";
			gridViewImageColumn3.Width = 100;
			this.radGridView1.MasterTemplate.Columns.AddRange(new global::Telerik.WinControls.UI.GridViewDataColumn[]
			{
				gridViewTextBoxColumn,
				gridViewImageColumn,
				gridViewTextBoxColumn2,
				gridViewTextBoxColumn3,
				gridViewTextBoxColumn4,
				gridViewTextBoxColumn5,
				gridViewTextBoxColumn6,
				gridViewTextBoxColumn7,
				gridViewTextBoxColumn8,
				gridViewTextBoxColumn9,
				gridViewTextBoxColumn10,
				gridViewTextBoxColumn11,
				gridViewTextBoxColumn12,
				gridViewTextBoxColumn13,
				gridViewTextBoxColumn14,
				gridViewTextBoxColumn15,
				gridViewImageColumn2,
				gridViewImageColumn3
			});
			this.radGridView1.MasterTemplate.EnableFiltering = true;
			this.radGridView1.MasterTemplate.EnablePaging = true;
			this.radGridView1.MasterTemplate.ShowFilteringRow = false;
			this.radGridView1.MasterTemplate.ShowHeaderCellButtons = true;
			sortDescriptor.PropertyName = "column14";
			this.radGridView1.MasterTemplate.SortDescriptors.AddRange(new global::Telerik.WinControls.Data.SortDescriptor[]
			{
				sortDescriptor
			});
			this.radGridView1.MasterTemplate.ViewDefinition = viewDefinition;
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.ReadOnly = true;
			this.radGridView1.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.radGridView1.ShowGroupPanel = false;
			this.radGridView1.ShowHeaderCellButtons = true;
			this.radGridView1.Size = new global::System.Drawing.Size(813, 516);
			this.radGridView1.TabIndex = 52;
			this.radGridView1.ThemeName = "Fluent";
			this.prix_radTextBox5.Location = new global::System.Drawing.Point(113, 352);
			this.prix_radTextBox5.Name = "prix_radTextBox5";
			this.prix_radTextBox5.Size = new global::System.Drawing.Size(163, 24);
			this.prix_radTextBox5.TabIndex = 43;
			this.prix_radTextBox5.ThemeName = "Crystal";
			this.nserie_radTextBox2.Location = new global::System.Drawing.Point(112, 183);
			this.nserie_radTextBox2.Name = "nserie_radTextBox2";
			this.nserie_radTextBox2.Size = new global::System.Drawing.Size(164, 24);
			this.nserie_radTextBox2.TabIndex = 40;
			this.nserie_radTextBox2.ThemeName = "Crystal";
			this.nmodel_radTextBox3.Location = new global::System.Drawing.Point(113, 209);
			this.nmodel_radTextBox3.Name = "nmodel_radTextBox3";
			this.nmodel_radTextBox3.Size = new global::System.Drawing.Size(163, 24);
			this.nmodel_radTextBox3.TabIndex = 41;
			this.nmodel_radTextBox3.ThemeName = "Crystal";
			this.codeoutil_radTextBox1.Location = new global::System.Drawing.Point(112, 105);
			this.codeoutil_radTextBox1.Name = "codeoutil_radTextBox1";
			this.codeoutil_radTextBox1.Size = new global::System.Drawing.Size(164, 24);
			this.codeoutil_radTextBox1.TabIndex = 38;
			this.codeoutil_radTextBox1.ThemeName = "Crystal";
			this.sec_radDropDownList1.DropDownAnimationEasing = 2;
			this.sec_radDropDownList1.DropDownStyle = 2;
			this.sec_radDropDownList1.Location = new global::System.Drawing.Point(113, 157);
			this.sec_radDropDownList1.Name = "sec_radDropDownList1";
			this.sec_radDropDownList1.Size = new global::System.Drawing.Size(164, 24);
			this.sec_radDropDownList1.TabIndex = 162;
			this.sec_radDropDownList1.ThemeName = "Crystal";
			((global::Telerik.WinControls.UI.RadDropDownListElement)this.sec_radDropDownList1.GetChildAt(0)).DropDownStyle = 2;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.sec_radDropDownList1.GetChildAt(0).GetChildAt(0)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.sec_radDropDownList1.GetChildAt(0).GetChildAt(0)).SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.sec_radDropDownList1.GetChildAt(0).GetChildAt(1)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.sec_radDropDownList1.GetChildAt(0).GetChildAt(1)).AutoSize = false;
			((global::Telerik.WinControls.UI.RadDropDownListEditableAreaElement)this.sec_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0)).BorderBoxStyle = 0;
			((global::Telerik.WinControls.UI.RadDropDownListEditableAreaElement)this.sec_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0)).BorderColor = global::System.Drawing.SystemColors.ControlDarkDark;
			((global::Telerik.WinControls.UI.RadDropDownListEditableAreaElement)this.sec_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.UI.RadDropDownTextBoxElement)this.sec_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0)).Visibility = 1;
			((global::Telerik.WinControls.UI.RadTextBoxItem)this.sec_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.sec_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.sec_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0)).BackColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.sec_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0)).BackColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.sec_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.sec_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor3 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.sec_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor4 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.sec_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.sec_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.type_radDropDownList1.DropDownAnimationEasing = 2;
			this.type_radDropDownList1.DropDownStyle = 2;
			this.type_radDropDownList1.Location = new global::System.Drawing.Point(113, 408);
			this.type_radDropDownList1.Name = "type_radDropDownList1";
			this.type_radDropDownList1.Size = new global::System.Drawing.Size(164, 24);
			this.type_radDropDownList1.TabIndex = 163;
			this.type_radDropDownList1.ThemeName = "Crystal";
			((global::Telerik.WinControls.UI.RadDropDownListElement)this.type_radDropDownList1.GetChildAt(0)).DropDownStyle = 2;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.type_radDropDownList1.GetChildAt(0).GetChildAt(0)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.type_radDropDownList1.GetChildAt(0).GetChildAt(0)).SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.type_radDropDownList1.GetChildAt(0).GetChildAt(1)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.type_radDropDownList1.GetChildAt(0).GetChildAt(1)).AutoSize = false;
			((global::Telerik.WinControls.UI.RadDropDownListEditableAreaElement)this.type_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0)).BorderBoxStyle = 0;
			((global::Telerik.WinControls.UI.RadDropDownListEditableAreaElement)this.type_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0)).BorderColor = global::System.Drawing.SystemColors.ControlDarkDark;
			((global::Telerik.WinControls.UI.RadDropDownListEditableAreaElement)this.type_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.UI.RadDropDownTextBoxElement)this.type_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0)).Visibility = 1;
			((global::Telerik.WinControls.UI.RadTextBoxItem)this.type_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.type_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.type_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0)).BackColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.type_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0)).BackColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.type_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.type_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor3 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.type_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor4 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.type_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.type_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.etat_radDropDownList1.DropDownAnimationEasing = 2;
			this.etat_radDropDownList1.DropDownStyle = 2;
			this.etat_radDropDownList1.Location = new global::System.Drawing.Point(113, 435);
			this.etat_radDropDownList1.Name = "etat_radDropDownList1";
			this.etat_radDropDownList1.Size = new global::System.Drawing.Size(164, 24);
			this.etat_radDropDownList1.TabIndex = 163;
			this.etat_radDropDownList1.ThemeName = "Crystal";
			((global::Telerik.WinControls.UI.RadDropDownListElement)this.etat_radDropDownList1.GetChildAt(0)).DropDownStyle = 2;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.etat_radDropDownList1.GetChildAt(0).GetChildAt(0)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.etat_radDropDownList1.GetChildAt(0).GetChildAt(0)).SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.etat_radDropDownList1.GetChildAt(0).GetChildAt(1)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.etat_radDropDownList1.GetChildAt(0).GetChildAt(1)).AutoSize = false;
			((global::Telerik.WinControls.UI.RadDropDownListEditableAreaElement)this.etat_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0)).BorderBoxStyle = 0;
			((global::Telerik.WinControls.UI.RadDropDownListEditableAreaElement)this.etat_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0)).BorderColor = global::System.Drawing.SystemColors.ControlDarkDark;
			((global::Telerik.WinControls.UI.RadDropDownListEditableAreaElement)this.etat_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.UI.RadDropDownTextBoxElement)this.etat_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0)).Visibility = 1;
			((global::Telerik.WinControls.UI.RadTextBoxItem)this.etat_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.etat_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.etat_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0)).BackColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.etat_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0)).BackColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.etat_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.etat_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor3 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.etat_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor4 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.etat_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.etat_radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.radCheckedDropDownList1.Location = new global::System.Drawing.Point(113, 462);
			this.radCheckedDropDownList1.Name = "radCheckedDropDownList1";
			this.radCheckedDropDownList1.Size = new global::System.Drawing.Size(164, 24);
			this.radCheckedDropDownList1.TabIndex = 164;
			this.radCheckedDropDownList1.ThemeName = "Crystal";
			((global::Telerik.WinControls.UI.RadCheckedDropDownListElement)this.radCheckedDropDownList1.GetChildAt(0)).DropDownStyle = 2;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.radCheckedDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0)).BackColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.radCheckedDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0)).BackColor3 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.radCheckedDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0)).BackColor4 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.radCheckedDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0)).BackColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radCheckedDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radCheckedDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor3 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radCheckedDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor4 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radCheckedDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radCheckedDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.achat_radDateTimePicker1.CalendarSize = new global::System.Drawing.Size(290, 320);
			this.achat_radDateTimePicker1.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.achat_radDateTimePicker1.ForeColor = global::System.Drawing.Color.DimGray;
			this.achat_radDateTimePicker1.Format = global::System.Windows.Forms.DateTimePickerFormat.Short;
			this.achat_radDateTimePicker1.Location = new global::System.Drawing.Point(113, 262);
			this.achat_radDateTimePicker1.Name = "achat_radDateTimePicker1";
			this.achat_radDateTimePicker1.Size = new global::System.Drawing.Size(163, 27);
			this.achat_radDateTimePicker1.TabIndex = 165;
			this.achat_radDateTimePicker1.TabStop = false;
			this.achat_radDateTimePicker1.Text = "10/02/2021";
			this.achat_radDateTimePicker1.ThemeName = "Crystal";
			this.achat_radDateTimePicker1.Value = new global::System.DateTime(2021, 2, 10, 16, 51, 18, 838);
			((global::Telerik.WinControls.UI.RadDateTimePickerElement)this.achat_radDateTimePicker1.GetChildAt(0)).CalendarSize = new global::System.Drawing.Size(290, 320);
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.achat_radDateTimePicker1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0)).BackColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.achat_radDateTimePicker1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0)).BackColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.achat_radDateTimePicker1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0)).SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.None;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.achat_radDateTimePicker1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1)).ForeColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.achat_radDateTimePicker1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1)).ForeColor3 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.achat_radDateTimePicker1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1)).ForeColor4 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.achat_radDateTimePicker1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1)).ForeColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.achat_radDateTimePicker1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1)).SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.fingarantie_radDateTimePicker2.CalendarSize = new global::System.Drawing.Size(290, 320);
			this.fingarantie_radDateTimePicker2.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.fingarantie_radDateTimePicker2.ForeColor = global::System.Drawing.Color.DimGray;
			this.fingarantie_radDateTimePicker2.Format = global::System.Windows.Forms.DateTimePickerFormat.Short;
			this.fingarantie_radDateTimePicker2.Location = new global::System.Drawing.Point(113, 293);
			this.fingarantie_radDateTimePicker2.Name = "fingarantie_radDateTimePicker2";
			this.fingarantie_radDateTimePicker2.Size = new global::System.Drawing.Size(163, 27);
			this.fingarantie_radDateTimePicker2.TabIndex = 166;
			this.fingarantie_radDateTimePicker2.TabStop = false;
			this.fingarantie_radDateTimePicker2.Text = "10/02/2021";
			this.fingarantie_radDateTimePicker2.ThemeName = "Crystal";
			this.fingarantie_radDateTimePicker2.Value = new global::System.DateTime(2021, 2, 10, 16, 51, 18, 838);
			((global::Telerik.WinControls.UI.RadDateTimePickerElement)this.fingarantie_radDateTimePicker2.GetChildAt(0)).CalendarSize = new global::System.Drawing.Size(290, 320);
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.fingarantie_radDateTimePicker2.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0)).BackColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.fingarantie_radDateTimePicker2.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0)).BackColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.fingarantie_radDateTimePicker2.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0)).SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.None;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.fingarantie_radDateTimePicker2.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1)).ForeColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.fingarantie_radDateTimePicker2.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1)).ForeColor3 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.fingarantie_radDateTimePicker2.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1)).ForeColor4 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.fingarantie_radDateTimePicker2.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1)).ForeColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.fingarantie_radDateTimePicker2.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1)).SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.miservice_radDateTimePicker3.CalendarSize = new global::System.Drawing.Size(290, 320);
			this.miservice_radDateTimePicker3.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.miservice_radDateTimePicker3.ForeColor = global::System.Drawing.Color.DimGray;
			this.miservice_radDateTimePicker3.Format = global::System.Windows.Forms.DateTimePickerFormat.Short;
			this.miservice_radDateTimePicker3.Location = new global::System.Drawing.Point(113, 322);
			this.miservice_radDateTimePicker3.Name = "miservice_radDateTimePicker3";
			this.miservice_radDateTimePicker3.Size = new global::System.Drawing.Size(163, 27);
			this.miservice_radDateTimePicker3.TabIndex = 167;
			this.miservice_radDateTimePicker3.TabStop = false;
			this.miservice_radDateTimePicker3.Text = "10/02/2021";
			this.miservice_radDateTimePicker3.ThemeName = "Crystal";
			this.miservice_radDateTimePicker3.Value = new global::System.DateTime(2021, 2, 10, 16, 51, 18, 838);
			((global::Telerik.WinControls.UI.RadDateTimePickerElement)this.miservice_radDateTimePicker3.GetChildAt(0)).CalendarSize = new global::System.Drawing.Size(290, 320);
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.miservice_radDateTimePicker3.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0)).BackColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.miservice_radDateTimePicker3.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0)).BackColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.miservice_radDateTimePicker3.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0)).SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.None;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.miservice_radDateTimePicker3.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1)).ForeColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.miservice_radDateTimePicker3.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1)).ForeColor3 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.miservice_radDateTimePicker3.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1)).ForeColor4 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.miservice_radDateTimePicker3.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1)).ForeColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.miservice_radDateTimePicker3.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1)).SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new global::System.Drawing.Font("Calibri", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.Firebrick;
			this.button1.Location = new global::System.Drawing.Point(179, 492);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(97, 24);
			this.button1.TabIndex = 231;
			this.button1.Text = "Ajouter";
			this.button1.ThemeName = "Crystal";
			this.button1.Click += new global::System.EventHandler(this.button1_Click_1);
			this.button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button2.Font = new global::System.Drawing.Font("Calibri", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.Color.Firebrick;
			this.button2.Location = new global::System.Drawing.Point(180, 522);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(97, 24);
			this.button2.TabIndex = 232;
			this.button2.Text = "Annuler";
			this.button2.ThemeName = "Crystal";
			this.button2.Click += new global::System.EventHandler(this.button2_Click_1);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(1128, 558);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.miservice_radDateTimePicker3);
			base.Controls.Add(this.fingarantie_radDateTimePicker2);
			base.Controls.Add(this.achat_radDateTimePicker1);
			base.Controls.Add(this.radCheckedDropDownList1);
			base.Controls.Add(this.etat_radDropDownList1);
			base.Controls.Add(this.type_radDropDownList1);
			base.Controls.Add(this.sec_radDropDownList1);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.fab_radTextBox1);
			base.Controls.Add(this.label14);
			base.Controls.Add(this.remarque_radTextBox1);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.design_radTextBox1);
			base.Controls.Add(this.radGridView1);
			base.Controls.Add(this.prix_radTextBox5);
			base.Controls.Add(this.nserie_radTextBox2);
			base.Controls.Add(this.nmodel_radTextBox3);
			base.Controls.Add(this.codeoutil_radTextBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "liste_outillage";
			base.ShowIcon = false;
			base.Load += new global::System.EventHandler(this.liste_outillage_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.fab_radTextBox1.EndInit();
			this.remarque_radTextBox1.EndInit();
			this.design_radTextBox1.EndInit();
			this.radGridView1.MasterTemplate.EndInit();
			this.radGridView1.EndInit();
			this.prix_radTextBox5.EndInit();
			this.nserie_radTextBox2.EndInit();
			this.nmodel_radTextBox3.EndInit();
			this.codeoutil_radTextBox1.EndInit();
			this.sec_radDropDownList1.EndInit();
			this.type_radDropDownList1.EndInit();
			this.etat_radDropDownList1.EndInit();
			this.radCheckedDropDownList1.EndInit();
			this.achat_radDateTimePicker1.EndInit();
			this.fingarantie_radDateTimePicker2.EndInit();
			this.miservice_radDateTimePicker3.EndInit();
			this.button1.EndInit();
			this.button2.EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000901 RID: 2305
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000902 RID: 2306
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000903 RID: 2307
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000904 RID: 2308
		private global::Telerik.WinControls.UI.RadTextBox fab_radTextBox1;

		// Token: 0x04000905 RID: 2309
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000906 RID: 2310
		private global::Telerik.WinControls.UI.RadTextBox remarque_radTextBox1;

		// Token: 0x04000907 RID: 2311
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000908 RID: 2312
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000909 RID: 2313
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400090A RID: 2314
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400090B RID: 2315
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400090C RID: 2316
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400090D RID: 2317
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400090E RID: 2318
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400090F RID: 2319
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000910 RID: 2320
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000911 RID: 2321
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000912 RID: 2322
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000913 RID: 2323
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000914 RID: 2324
		private global::Telerik.WinControls.UI.RadTextBox design_radTextBox1;

		// Token: 0x04000915 RID: 2325
		private global::Telerik.WinControls.UI.RadGridView radGridView1;

		// Token: 0x04000916 RID: 2326
		private global::Telerik.WinControls.UI.RadTextBox prix_radTextBox5;

		// Token: 0x04000917 RID: 2327
		private global::Telerik.WinControls.UI.RadTextBox nserie_radTextBox2;

		// Token: 0x04000918 RID: 2328
		private global::Telerik.WinControls.UI.RadTextBox nmodel_radTextBox3;

		// Token: 0x04000919 RID: 2329
		private global::Telerik.WinControls.UI.RadTextBox codeoutil_radTextBox1;

		// Token: 0x0400091A RID: 2330
		private global::Telerik.WinControls.Themes.CrystalTheme crystalTheme1;

		// Token: 0x0400091B RID: 2331
		private global::Telerik.WinControls.Themes.FluentTheme fluentTheme1;

		// Token: 0x0400091C RID: 2332
		private global::Telerik.WinControls.UI.RadDropDownList sec_radDropDownList1;

		// Token: 0x0400091D RID: 2333
		private global::Telerik.WinControls.UI.RadDropDownList type_radDropDownList1;

		// Token: 0x0400091E RID: 2334
		private global::Telerik.WinControls.UI.RadDropDownList etat_radDropDownList1;

		// Token: 0x0400091F RID: 2335
		private global::Telerik.WinControls.UI.RadCheckedDropDownList radCheckedDropDownList1;

		// Token: 0x04000920 RID: 2336
		private global::Telerik.WinControls.UI.RadDateTimePicker achat_radDateTimePicker1;

		// Token: 0x04000921 RID: 2337
		private global::Telerik.WinControls.UI.RadDateTimePicker fingarantie_radDateTimePicker2;

		// Token: 0x04000922 RID: 2338
		private global::Telerik.WinControls.UI.RadDateTimePicker miservice_radDateTimePicker3;

		// Token: 0x04000923 RID: 2339
		private global::Telerik.WinControls.UI.RadButton button1;

		// Token: 0x04000924 RID: 2340
		private global::Telerik.WinControls.UI.RadButton button2;
	}
}
