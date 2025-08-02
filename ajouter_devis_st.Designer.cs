namespace GMAO
{
	// Token: 0x0200000E RID: 14
	public partial class ajouter_devis_st : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00025EC8 File Offset: 0x000240C8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00025F00 File Offset: 0x00024100
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new global::Telerik.WinControls.UI.GridViewTextBoxColumn();
			global::Telerik.WinControls.UI.TableViewDefinition viewDefinition = new global::Telerik.WinControls.UI.TableViewDefinition();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::GMAO.ajouter_devis_st));
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.radPanel1 = new global::Telerik.WinControls.UI.RadPanel();
			this.radDropDownList1 = new global::Telerik.WinControls.UI.RadDropDownList();
			this.label4 = new global::System.Windows.Forms.Label();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.radGridView1 = new global::Telerik.WinControls.UI.RadGridView();
			this.label1 = new global::System.Windows.Forms.Label();
			this.radDropDownList6 = new global::Telerik.WinControls.UI.RadDropDownList();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.imageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.fluentTheme1 = new global::Telerik.WinControls.Themes.FluentTheme();
			this.crystalTheme1 = new global::Telerik.WinControls.Themes.CrystalTheme();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.radPanel1.BeginInit();
			this.radDropDownList1.BeginInit();
			this.radGridView1.BeginInit();
			this.radGridView1.MasterTemplate.BeginInit();
			this.radDropDownList6.BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.Firebrick;
			this.label6.Location = new global::System.Drawing.Point(103, 143);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(49, 19);
			this.label6.TabIndex = 220;
			this.label6.Text = "label6";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.Black;
			this.label5.Location = new global::System.Drawing.Point(18, 143);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(91, 19);
			this.label5.TabIndex = 219;
			this.label5.Text = "Prix Tot HT : ";
			this.label13.AutoSize = true;
			this.label13.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label13.ForeColor = global::System.Drawing.Color.Black;
			this.label13.Location = new global::System.Drawing.Point(740, 31);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(82, 19);
			this.label13.TabIndex = 215;
			this.label13.Text = "Documents";
			this.radPanel1.AutoScroll = true;
			this.radPanel1.Location = new global::System.Drawing.Point(744, 53);
			this.radPanel1.Name = "radPanel1";
			this.radPanel1.Size = new global::System.Drawing.Size(330, 109);
			this.radPanel1.TabIndex = 216;
			this.radPanel1.ThemeName = "ControlDefault";
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radPanel1.GetChildAt(0).GetChildAt(1)).GradientStyle = 0;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radPanel1.GetChildAt(0).GetChildAt(1)).ForeColor = global::System.Drawing.Color.Firebrick;
			this.radDropDownList1.DropDownAnimationEasing = 2;
			this.radDropDownList1.DropDownStyle = 2;
			this.radDropDownList1.Location = new global::System.Drawing.Point(507, 82);
			this.radDropDownList1.Name = "radDropDownList1";
			this.radDropDownList1.Size = new global::System.Drawing.Size(221, 24);
			this.radDropDownList1.TabIndex = 214;
			this.radDropDownList1.ThemeName = "Crystal";
			((global::Telerik.WinControls.UI.RadDropDownListElement)this.radDropDownList1.GetChildAt(0)).DropDownStyle = 2;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radDropDownList1.GetChildAt(0).GetChildAt(0)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radDropDownList1.GetChildAt(0).GetChildAt(0)).SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.radDropDownList1.GetChildAt(0).GetChildAt(1)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.UI.RadDropDownListEditableAreaElement)this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0)).BorderBoxStyle = 0;
			((global::Telerik.WinControls.UI.RadDropDownListEditableAreaElement)this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0)).BorderColor = global::System.Drawing.SystemColors.ControlDarkDark;
			((global::Telerik.WinControls.UI.RadDropDownListEditableAreaElement)this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.UI.RadDropDownTextBoxElement)this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0)).Visibility = 1;
			((global::Telerik.WinControls.UI.RadTextBoxItem)this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0)).BackColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0)).BackColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor3 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor4 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radDropDownList1.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.Black;
			this.label4.Location = new global::System.Drawing.Point(503, 60);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(182, 19);
			this.label4.TabIndex = 213;
			this.label4.Text = "Livraison par Sous_traitant";
			this.guna2Button1.BorderRadius = 8;
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.FillColor = global::System.Drawing.Color.Firebrick;
			this.guna2Button1.Font = new global::System.Drawing.Font("Calibri", 9.75f, global::System.Drawing.FontStyle.Bold);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Location = new global::System.Drawing.Point(1090, 138);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new global::System.Drawing.Size(104, 24);
			this.guna2Button1.TabIndex = 212;
			this.guna2Button1.Text = "Enregistrer";
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.radGridView1.AutoScroll = true;
			this.radGridView1.BackColor = global::System.Drawing.Color.White;
			this.radGridView1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.radGridView1.Font = new global::System.Drawing.Font("Calibri", 11.25f);
			this.radGridView1.ForeColor = global::System.Drawing.Color.Black;
			this.radGridView1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
			this.radGridView1.Location = new global::System.Drawing.Point(18, 168);
			this.radGridView1.MasterTemplate.AllowAddNewRow = false;
			this.radGridView1.MasterTemplate.AllowCellContextMenu = false;
			this.radGridView1.MasterTemplate.AllowColumnHeaderContextMenu = false;
			this.radGridView1.MasterTemplate.AllowColumnReorder = false;
			this.radGridView1.MasterTemplate.AllowDeleteRow = false;
			this.radGridView1.MasterTemplate.AllowDragToGroup = false;
			this.radGridView1.MasterTemplate.AllowRowHeaderContextMenu = false;
			gridViewTextBoxColumn.HeaderText = "column10";
			gridViewTextBoxColumn.IsVisible = false;
			gridViewTextBoxColumn.Name = "id";
			gridViewTextBoxColumn2.EnableExpressionEditor = false;
			gridViewTextBoxColumn2.HeaderText = "ID article";
			gridViewTextBoxColumn2.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn2.IsVisible = false;
			gridViewTextBoxColumn2.Name = "column5";
			gridViewTextBoxColumn2.ReadOnly = true;
			gridViewTextBoxColumn2.Width = 100;
			gridViewTextBoxColumn3.HeaderText = "Réf interne";
			gridViewTextBoxColumn3.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn3.Name = "column9";
			gridViewTextBoxColumn3.ReadOnly = true;
			gridViewTextBoxColumn3.Width = 150;
			gridViewTextBoxColumn4.HeaderText = "Code Article";
			gridViewTextBoxColumn4.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn4.Name = "column1";
			gridViewTextBoxColumn4.ReadOnly = true;
			gridViewTextBoxColumn4.Width = 150;
			gridViewTextBoxColumn5.EnableExpressionEditor = false;
			gridViewTextBoxColumn5.HeaderText = "Désignation";
			gridViewTextBoxColumn5.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn5.Name = "column3";
			gridViewTextBoxColumn5.ReadOnly = true;
			gridViewTextBoxColumn5.Width = 200;
			gridViewTextBoxColumn6.HeaderText = "Quantité";
			gridViewTextBoxColumn6.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn6.Name = "column2";
			gridViewTextBoxColumn6.ReadOnly = true;
			gridViewTextBoxColumn6.Width = 120;
			gridViewTextBoxColumn7.HeaderText = "Activité";
			gridViewTextBoxColumn7.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn7.Name = "column4";
			gridViewTextBoxColumn7.ReadOnly = true;
			gridViewTextBoxColumn7.Width = 200;
			gridViewTextBoxColumn8.HeaderText = "Prix U HT";
			gridViewTextBoxColumn8.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn8.Name = "column6";
			gridViewTextBoxColumn8.Width = 120;
			gridViewTextBoxColumn9.HeaderText = "Remise";
			gridViewTextBoxColumn9.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			gridViewTextBoxColumn9.Name = "column7";
			gridViewTextBoxColumn9.Width = 120;
			gridViewTextBoxColumn10.HeaderText = "Prix Tot HT";
			gridViewTextBoxColumn10.Name = "column8";
			gridViewTextBoxColumn10.ReadOnly = true;
			gridViewTextBoxColumn10.Width = 120;
			this.radGridView1.MasterTemplate.Columns.AddRange(new global::Telerik.WinControls.UI.GridViewDataColumn[]
			{
				gridViewTextBoxColumn,
				gridViewTextBoxColumn2,
				gridViewTextBoxColumn3,
				gridViewTextBoxColumn4,
				gridViewTextBoxColumn5,
				gridViewTextBoxColumn6,
				gridViewTextBoxColumn7,
				gridViewTextBoxColumn8,
				gridViewTextBoxColumn9,
				gridViewTextBoxColumn10
			});
			this.radGridView1.MasterTemplate.EnableAlternatingRowColor = true;
			this.radGridView1.MasterTemplate.EnableFiltering = true;
			this.radGridView1.MasterTemplate.EnableSorting = false;
			this.radGridView1.MasterTemplate.ShowFilteringRow = false;
			this.radGridView1.MasterTemplate.ViewDefinition = viewDefinition;
			this.radGridView1.Name = "radGridView1";
			this.radGridView1.Padding = new global::System.Windows.Forms.Padding(1);
			this.radGridView1.PrintStyle.CellFont = new global::System.Drawing.Font("Calibri", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radGridView1.PrintStyle.ChildViewPrintMode = 0;
			this.radGridView1.PrintStyle.GroupRowBackColor = global::System.Drawing.Color.Gray;
			this.radGridView1.PrintStyle.HeaderCellBackColor = global::System.Drawing.Color.Red;
			this.radGridView1.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.radGridView1.ShowGroupPanel = false;
			this.radGridView1.Size = new global::System.Drawing.Size(1231, 406);
			this.radGridView1.TabIndex = 211;
			this.radGridView1.ThemeName = "Fluent";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Black;
			this.label1.Location = new global::System.Drawing.Point(18, 60);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(164, 19);
			this.label1.TabIndex = 210;
			this.label1.Text = "Choisir un Sous_traitant";
			this.radDropDownList6.DropDownAnimationEasing = 2;
			this.radDropDownList6.DropDownStyle = 2;
			this.radDropDownList6.Location = new global::System.Drawing.Point(22, 82);
			this.radDropDownList6.Name = "radDropDownList6";
			this.radDropDownList6.Size = new global::System.Drawing.Size(455, 24);
			this.radDropDownList6.TabIndex = 209;
			this.radDropDownList6.ThemeName = "Crystal";
			((global::Telerik.WinControls.UI.RadDropDownListElement)this.radDropDownList6.GetChildAt(0)).DropDownStyle = 2;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radDropDownList6.GetChildAt(0).GetChildAt(0)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radDropDownList6.GetChildAt(0).GetChildAt(0)).SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.radDropDownList6.GetChildAt(0).GetChildAt(1)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.UI.RadDropDownListEditableAreaElement)this.radDropDownList6.GetChildAt(0).GetChildAt(2).GetChildAt(0)).BorderBoxStyle = 0;
			((global::Telerik.WinControls.UI.RadDropDownListEditableAreaElement)this.radDropDownList6.GetChildAt(0).GetChildAt(2).GetChildAt(0)).BorderColor = global::System.Drawing.SystemColors.ControlDarkDark;
			((global::Telerik.WinControls.UI.RadDropDownListEditableAreaElement)this.radDropDownList6.GetChildAt(0).GetChildAt(2).GetChildAt(0)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.UI.RadDropDownTextBoxElement)this.radDropDownList6.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0)).Visibility = 1;
			((global::Telerik.WinControls.UI.RadTextBoxItem)this.radDropDownList6.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radDropDownList6.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2)).BackColor = global::System.Drawing.Color.White;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.radDropDownList6.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0)).BackColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.FillPrimitive)this.radDropDownList6.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(0)).BackColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radDropDownList6.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor2 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radDropDownList6.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor3 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radDropDownList6.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor4 = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radDropDownList6.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).ForeColor = global::System.Drawing.Color.Firebrick;
			((global::Telerik.WinControls.Primitives.BorderPrimitive)this.radDropDownList6.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(1)).SmoothingMode = global::System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Black;
			this.label3.Location = new global::System.Drawing.Point(214, 31);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(49, 19);
			this.label3.TabIndex = 208;
			this.label3.Text = "label3";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Black;
			this.label2.Location = new global::System.Drawing.Point(18, 31);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(199, 19);
			this.label2.TabIndex = 207;
			this.label2.Text = "ID Demande Sous Traitance : ";
			this.imageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
			this.imageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "icons8-supprimer-pour-toujours-100 (4).png");
			this.imageList1.Images.SetKeyName(1, "icons8-approuver-et-mettre-à-jour-96 (4).png");
			this.imageList1.Images.SetKeyName(2, "imgonline-com-ua-Transparent-background-mY80EJnxkjzbk (1).ico");
			this.imageList1.Images.SetKeyName(3, "icons8-word-96.png");
			this.imageList1.Images.SetKeyName(4, "icons8-ms-excel-104.png");
			this.imageList1.Images.SetKeyName(5, "icons8-pdf-40.png");
			this.imageList1.Images.SetKeyName(6, "icons8-txt-80.png");
			this.imageList1.Images.SetKeyName(7, "icons8-image-96.png");
			this.imageList1.Images.SetKeyName(8, "icons8-winrar-240.png");
			this.imageList1.Images.SetKeyName(9, "icons8-fichier-128.png");
			this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(507, 122);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(10, 13);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 218;
			this.pictureBox2.TabStop = false;
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(818, 28);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(27, 22);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 217;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(1261, 603);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.radPanel1);
			base.Controls.Add(this.radDropDownList1);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.guna2Button1);
			base.Controls.Add(this.radGridView1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.radDropDownList6);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Name = "ajouter_devis_st";
			base.ShowIcon = false;
			base.Load += new global::System.EventHandler(this.ajouter_devis_st_Load);
			this.radPanel1.EndInit();
			this.radDropDownList1.EndInit();
			this.radGridView1.MasterTemplate.EndInit();
			this.radGridView1.EndInit();
			this.radDropDownList6.EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000126 RID: 294
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000127 RID: 295
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000128 RID: 296
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000129 RID: 297
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x0400012A RID: 298
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400012B RID: 299
		private global::System.Windows.Forms.Label label13;

		// Token: 0x0400012C RID: 300
		private global::Telerik.WinControls.UI.RadPanel radPanel1;

		// Token: 0x0400012D RID: 301
		private global::Telerik.WinControls.UI.RadDropDownList radDropDownList1;

		// Token: 0x0400012E RID: 302
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400012F RID: 303
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x04000130 RID: 304
		private global::Telerik.WinControls.UI.RadGridView radGridView1;

		// Token: 0x04000131 RID: 305
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000132 RID: 306
		private global::Telerik.WinControls.UI.RadDropDownList radDropDownList6;

		// Token: 0x04000133 RID: 307
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000134 RID: 308
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000135 RID: 309
		private global::System.Windows.Forms.ImageList imageList1;

		// Token: 0x04000136 RID: 310
		private global::Telerik.WinControls.Themes.FluentTheme fluentTheme1;

		// Token: 0x04000137 RID: 311
		private global::Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
	}
}
