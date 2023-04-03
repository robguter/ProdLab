
namespace ProdLab.UI.Winform
{
    partial class FrmPpal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPpal));
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.PnlMenuVertical = new System.Windows.Forms.Panel();
            this.BtnSali = new FontAwesome.Sharp.IconButton();
            this.BtnUsua = new FontAwesome.Sharp.IconButton();
            this.BtnVent = new FontAwesome.Sharp.IconButton();
            this.BtnComp = new FontAwesome.Sharp.IconButton();
            this.BtnProd = new FontAwesome.Sharp.IconButton();
            this.BtnInve = new FontAwesome.Sharp.IconButton();
            this.BtnMaes = new FontAwesome.Sharp.IconButton();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.PnlBarTitle = new System.Windows.Forms.Panel();
            this.LblTit = new System.Windows.Forms.Label();
            this.PbxMinimo = new System.Windows.Forms.PictureBox();
            this.PbxCerrar = new System.Windows.Forms.PictureBox();
            this.PbxMaximo = new System.Windows.Forms.PictureBox();
            this.PbxRestaura = new System.Windows.Forms.PictureBox();
            this.PnlMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            this.PnlBarTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxRestaura)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(205, 54);
            this.PnlContenedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(1050, 714);
            this.PnlContenedor.TabIndex = 5;
            // 
            // PnlMenuVertical
            // 
            this.PnlMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(5)))), ((int)(((byte)(0)))));
            this.PnlMenuVertical.Controls.Add(this.BtnSali);
            this.PnlMenuVertical.Controls.Add(this.BtnUsua);
            this.PnlMenuVertical.Controls.Add(this.BtnVent);
            this.PnlMenuVertical.Controls.Add(this.BtnComp);
            this.PnlMenuVertical.Controls.Add(this.BtnProd);
            this.PnlMenuVertical.Controls.Add(this.BtnInve);
            this.PnlMenuVertical.Controls.Add(this.BtnMaes);
            this.PnlMenuVertical.Controls.Add(this.PbxLogo);
            this.PnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenuVertical.ForeColor = System.Drawing.Color.White;
            this.PnlMenuVertical.Location = new System.Drawing.Point(0, 54);
            this.PnlMenuVertical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnlMenuVertical.Name = "PnlMenuVertical";
            this.PnlMenuVertical.Size = new System.Drawing.Size(205, 714);
            this.PnlMenuVertical.TabIndex = 4;
            // 
            // BtnSali
            // 
            this.BtnSali.AutoSize = true;
            this.BtnSali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(130)))), ((int)(((byte)(50)))));
            this.BtnSali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSali.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(207)))));
            this.BtnSali.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.BtnSali.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(112)))), ((int)(((byte)(37)))));
            this.BtnSali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSali.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSali.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.BtnSali.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.BtnSali.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.BtnSali.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSali.IconSize = 38;
            this.BtnSali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSali.Location = new System.Drawing.Point(3, 520);
            this.BtnSali.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSali.Name = "BtnSali";
            this.BtnSali.Size = new System.Drawing.Size(190, 46);
            this.BtnSali.TabIndex = 28;
            this.BtnSali.Text = "&Salir";
            this.BtnSali.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSali.UseVisualStyleBackColor = false;
            // 
            // BtnUsua
            // 
            this.BtnUsua.AutoSize = true;
            this.BtnUsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(130)))), ((int)(((byte)(50)))));
            this.BtnUsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(207)))));
            this.BtnUsua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.BtnUsua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(112)))), ((int)(((byte)(37)))));
            this.BtnUsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.BtnUsua.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.BtnUsua.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.BtnUsua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUsua.IconSize = 38;
            this.BtnUsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsua.Location = new System.Drawing.Point(3, 460);
            this.BtnUsua.Margin = new System.Windows.Forms.Padding(0);
            this.BtnUsua.Name = "BtnUsua";
            this.BtnUsua.Size = new System.Drawing.Size(190, 46);
            this.BtnUsua.TabIndex = 27;
            this.BtnUsua.Text = "&Usuarios";
            this.BtnUsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUsua.UseVisualStyleBackColor = false;
            // 
            // BtnVent
            // 
            this.BtnVent.AutoSize = true;
            this.BtnVent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(130)))), ((int)(((byte)(50)))));
            this.BtnVent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(207)))));
            this.BtnVent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.BtnVent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(112)))), ((int)(((byte)(37)))));
            this.BtnVent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.BtnVent.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.BtnVent.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.BtnVent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVent.IconSize = 38;
            this.BtnVent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVent.Location = new System.Drawing.Point(3, 400);
            this.BtnVent.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVent.Name = "BtnVent";
            this.BtnVent.Size = new System.Drawing.Size(190, 46);
            this.BtnVent.TabIndex = 26;
            this.BtnVent.Text = "&Ventas";
            this.BtnVent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVent.UseVisualStyleBackColor = false;
            // 
            // BtnComp
            // 
            this.BtnComp.AutoSize = true;
            this.BtnComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(130)))), ((int)(((byte)(50)))));
            this.BtnComp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnComp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnComp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(207)))));
            this.BtnComp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.BtnComp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(112)))), ((int)(((byte)(37)))));
            this.BtnComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.BtnComp.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.BtnComp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.BtnComp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnComp.IconSize = 38;
            this.BtnComp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnComp.Location = new System.Drawing.Point(3, 340);
            this.BtnComp.Margin = new System.Windows.Forms.Padding(0);
            this.BtnComp.Name = "BtnComp";
            this.BtnComp.Size = new System.Drawing.Size(190, 46);
            this.BtnComp.TabIndex = 25;
            this.BtnComp.Text = "&Compras";
            this.BtnComp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnComp.UseVisualStyleBackColor = false;
            // 
            // BtnProd
            // 
            this.BtnProd.AutoSize = true;
            this.BtnProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(130)))), ((int)(((byte)(50)))));
            this.BtnProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(207)))));
            this.BtnProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.BtnProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(112)))), ((int)(((byte)(37)))));
            this.BtnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.BtnProd.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.BtnProd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.BtnProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProd.IconSize = 38;
            this.BtnProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProd.Location = new System.Drawing.Point(3, 280);
            this.BtnProd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnProd.Name = "BtnProd";
            this.BtnProd.Size = new System.Drawing.Size(190, 46);
            this.BtnProd.TabIndex = 24;
            this.BtnProd.Text = "&Producción";
            this.BtnProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProd.UseVisualStyleBackColor = false;
            // 
            // BtnInve
            // 
            this.BtnInve.AutoSize = true;
            this.BtnInve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(130)))), ((int)(((byte)(50)))));
            this.BtnInve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnInve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(207)))));
            this.BtnInve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.BtnInve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(112)))), ((int)(((byte)(37)))));
            this.BtnInve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.BtnInve.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.BtnInve.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.BtnInve.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInve.IconSize = 38;
            this.BtnInve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInve.Location = new System.Drawing.Point(3, 220);
            this.BtnInve.Margin = new System.Windows.Forms.Padding(0);
            this.BtnInve.Name = "BtnInve";
            this.BtnInve.Size = new System.Drawing.Size(190, 46);
            this.BtnInve.TabIndex = 23;
            this.BtnInve.Text = "&Inventario";
            this.BtnInve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInve.UseVisualStyleBackColor = false;
            // 
            // BtnMaes
            // 
            this.BtnMaes.AutoSize = true;
            this.BtnMaes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(130)))), ((int)(((byte)(50)))));
            this.BtnMaes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMaes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(207)))));
            this.BtnMaes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.BtnMaes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(112)))), ((int)(((byte)(37)))));
            this.BtnMaes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMaes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.BtnMaes.IconChar = FontAwesome.Sharp.IconChar.Flask;
            this.BtnMaes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.BtnMaes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMaes.IconSize = 38;
            this.BtnMaes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMaes.Location = new System.Drawing.Point(3, 160);
            this.BtnMaes.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMaes.Name = "BtnMaes";
            this.BtnMaes.Size = new System.Drawing.Size(190, 46);
            this.BtnMaes.TabIndex = 22;
            this.BtnMaes.Text = "&Maestro Detalle";
            this.BtnMaes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMaes.UseVisualStyleBackColor = false;
            // 
            // PbxLogo
            // 
            this.PbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbxLogo.Image")));
            this.PbxLogo.Location = new System.Drawing.Point(4, 3);
            this.PbxLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(120, 90);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogo.TabIndex = 0;
            this.PbxLogo.TabStop = false;
            // 
            // PnlBarTitle
            // 
            this.PnlBarTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(130)))), ((int)(((byte)(50)))));
            this.PnlBarTitle.Controls.Add(this.LblTit);
            this.PnlBarTitle.Controls.Add(this.PbxMinimo);
            this.PnlBarTitle.Controls.Add(this.PbxCerrar);
            this.PnlBarTitle.Controls.Add(this.PbxMaximo);
            this.PnlBarTitle.Controls.Add(this.PbxRestaura);
            this.PnlBarTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlBarTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnlBarTitle.Name = "PnlBarTitle";
            this.PnlBarTitle.Size = new System.Drawing.Size(1255, 54);
            this.PnlBarTitle.TabIndex = 3;
            // 
            // LblTit
            // 
            this.LblTit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblTit.AutoSize = true;
            this.LblTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(250)))));
            this.LblTit.Location = new System.Drawing.Point(440, 6);
            this.LblTit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTit.Name = "LblTit";
            this.LblTit.Size = new System.Drawing.Size(375, 29);
            this.LblTit.TabIndex = 4;
            this.LblTit.Text = "Sistema Control de Producción";
            this.LblTit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbxMinimo
            // 
            this.PbxMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxMinimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxMinimo.Image = ((System.Drawing.Image)(resources.GetObject("PbxMinimo.Image")));
            this.PbxMinimo.Location = new System.Drawing.Point(1135, 5);
            this.PbxMinimo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PbxMinimo.Name = "PbxMinimo";
            this.PbxMinimo.Size = new System.Drawing.Size(38, 43);
            this.PbxMinimo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxMinimo.TabIndex = 2;
            this.PbxMinimo.TabStop = false;
            // 
            // PbxCerrar
            // 
            this.PbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("PbxCerrar.Image")));
            this.PbxCerrar.Location = new System.Drawing.Point(1216, 5);
            this.PbxCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PbxCerrar.Name = "PbxCerrar";
            this.PbxCerrar.Size = new System.Drawing.Size(38, 43);
            this.PbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxCerrar.TabIndex = 0;
            this.PbxCerrar.TabStop = false;
            // 
            // PbxMaximo
            // 
            this.PbxMaximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxMaximo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxMaximo.Image = ((System.Drawing.Image)(resources.GetObject("PbxMaximo.Image")));
            this.PbxMaximo.Location = new System.Drawing.Point(1175, 5);
            this.PbxMaximo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PbxMaximo.Name = "PbxMaximo";
            this.PbxMaximo.Size = new System.Drawing.Size(38, 43);
            this.PbxMaximo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxMaximo.TabIndex = 1;
            this.PbxMaximo.TabStop = false;
            // 
            // PbxRestaura
            // 
            this.PbxRestaura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxRestaura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxRestaura.Image = ((System.Drawing.Image)(resources.GetObject("PbxRestaura.Image")));
            this.PbxRestaura.Location = new System.Drawing.Point(1175, 5);
            this.PbxRestaura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PbxRestaura.Name = "PbxRestaura";
            this.PbxRestaura.Size = new System.Drawing.Size(38, 43);
            this.PbxRestaura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxRestaura.TabIndex = 3;
            this.PbxRestaura.TabStop = false;
            this.PbxRestaura.Visible = false;
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1255, 768);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.PnlMenuVertical);
            this.Controls.Add(this.PnlBarTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Producción de Laboratoro";
            this.Load += new System.EventHandler(this.FrmPpal_Load);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.FrmPpal_ControlRemoved);
            this.Resize += new System.EventHandler(this.FrmPpal_Resize);
            this.PnlMenuVertical.ResumeLayout(false);
            this.PnlMenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            this.PnlBarTitle.ResumeLayout(false);
            this.PnlBarTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxRestaura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.Panel PnlMenuVertical;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.Panel PnlBarTitle;
        private System.Windows.Forms.Label LblTit;
        private System.Windows.Forms.PictureBox PbxMinimo;
        private System.Windows.Forms.PictureBox PbxCerrar;
        private System.Windows.Forms.PictureBox PbxRestaura;
        private System.Windows.Forms.PictureBox PbxMaximo;
        private FontAwesome.Sharp.IconButton BtnProd;
        private FontAwesome.Sharp.IconButton BtnInve;
        private FontAwesome.Sharp.IconButton BtnMaes;
        private FontAwesome.Sharp.IconButton BtnSali;
        private FontAwesome.Sharp.IconButton BtnUsua;
        private FontAwesome.Sharp.IconButton BtnVent;
        private FontAwesome.Sharp.IconButton BtnComp;
    }
}

