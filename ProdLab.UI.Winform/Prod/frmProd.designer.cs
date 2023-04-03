
namespace ProdLab.UI.Winform
{
    partial class frmProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.spcnProd = new System.Windows.Forms.SplitContainer();
            this.PbxBack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbCnProd = new System.Windows.Forms.TabControl();
            this.TbPgList = new System.Windows.Forms.TabPage();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.DgvProd = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TbPgDetail = new System.Windows.Forms.TabPage();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtStkMax = new System.Windows.Forms.TextBox();
            this.CboUnimed = new System.Windows.Forms.ComboBox();
            this.CboIndole = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtStkMin = new System.Windows.Forms.TextBox();
            this.NumEmp = new System.Windows.Forms.NumericUpDown();
            this.CboStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.spcnProd)).BeginInit();
            this.spcnProd.Panel1.SuspendLayout();
            this.spcnProd.Panel2.SuspendLayout();
            this.spcnProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBack)).BeginInit();
            this.TbCnProd.SuspendLayout();
            this.TbPgList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProd)).BeginInit();
            this.TbPgDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // spcnProd
            // 
            this.spcnProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.spcnProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcnProd.Location = new System.Drawing.Point(0, 0);
            this.spcnProd.Name = "spcnProd";
            this.spcnProd.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcnProd.Panel1
            // 
            this.spcnProd.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.spcnProd.Panel1.Controls.Add(this.PbxBack);
            this.spcnProd.Panel1.Controls.Add(this.label1);
            this.spcnProd.Panel1MinSize = 20;
            // 
            // spcnProd.Panel2
            // 
            this.spcnProd.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.spcnProd.Panel2.Controls.Add(this.TbCnProd);
            this.spcnProd.Size = new System.Drawing.Size(1307, 828);
            this.spcnProd.SplitterDistance = 89;
            this.spcnProd.TabIndex = 1;
            // 
            // PbxBack
            // 
            this.PbxBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxBack.Image = ((System.Drawing.Image)(resources.GetObject("PbxBack.Image")));
            this.PbxBack.Location = new System.Drawing.Point(1266, 13);
            this.PbxBack.Name = "PbxBack";
            this.PbxBack.Size = new System.Drawing.Size(30, 32);
            this.PbxBack.TabIndex = 1;
            this.PbxBack.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // TbCnProd
            // 
            this.TbCnProd.Controls.Add(this.TbPgList);
            this.TbCnProd.Controls.Add(this.TbPgDetail);
            this.TbCnProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbCnProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbCnProd.Location = new System.Drawing.Point(0, 0);
            this.TbCnProd.Multiline = true;
            this.TbCnProd.Name = "TbCnProd";
            this.TbCnProd.SelectedIndex = 0;
            this.TbCnProd.Size = new System.Drawing.Size(1307, 735);
            this.TbCnProd.TabIndex = 0;
            // 
            // TbPgList
            // 
            this.TbPgList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TbPgList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbPgList.Controls.Add(this.BtnDelete);
            this.TbPgList.Controls.Add(this.DgvProd);
            this.TbPgList.Controls.Add(this.BtnBuscar);
            this.TbPgList.Controls.Add(this.BtnEdit);
            this.TbPgList.Controls.Add(this.TxtBuscar);
            this.TbPgList.Controls.Add(this.BtnAdd);
            this.TbPgList.Controls.Add(this.label2);
            this.TbPgList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPgList.Location = new System.Drawing.Point(4, 25);
            this.TbPgList.Name = "TbPgList";
            this.TbPgList.Padding = new System.Windows.Forms.Padding(3);
            this.TbPgList.Size = new System.Drawing.Size(1299, 706);
            this.TbPgList.TabIndex = 0;
            this.TbPgList.Text = "Listado de Productos";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.AutoSize = true;
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.BtnDelete.FlatAppearance.BorderSize = 2;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Location = new System.Drawing.Point(1194, 146);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(97, 34);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // DgvProd
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            this.DgvProd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DgvProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvProd.ColumnHeadersHeight = 30;
            this.DgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvProd.Location = new System.Drawing.Point(3, 69);
            this.DgvProd.Name = "DgvProd";
            this.DgvProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProd.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Blue;
            this.DgvProd.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvProd.Size = new System.Drawing.Size(1185, 632);
            this.DgvProd.TabIndex = 3;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoSize = true;
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.BtnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 2;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(802, 32);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(80, 34);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.AutoSize = true;
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.BtnEdit.FlatAppearance.BorderSize = 2;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Location = new System.Drawing.Point(1194, 107);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(97, 34);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = false;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TxtBuscar.Location = new System.Drawing.Point(11, 36);
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(785, 27);
            this.TxtBuscar.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.AutoSize = true;
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.BtnAdd.FlatAppearance.BorderSize = 2;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(1194, 68);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(97, 34);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar Producto:";
            // 
            // TbPgDetail
            // 
            this.TbPgDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TbPgDetail.Controls.Add(this.CboStatus);
            this.TbPgDetail.Controls.Add(this.NumEmp);
            this.TbPgDetail.Controls.Add(this.label11);
            this.TbPgDetail.Controls.Add(this.TxtStkMin);
            this.TbPgDetail.Controls.Add(this.CboIndole);
            this.TbPgDetail.Controls.Add(this.label10);
            this.TbPgDetail.Controls.Add(this.CboUnimed);
            this.TbPgDetail.Controls.Add(this.BtnCancelar);
            this.TbPgDetail.Controls.Add(this.BtnGuardar);
            this.TbPgDetail.Controls.Add(this.label8);
            this.TbPgDetail.Controls.Add(this.label7);
            this.TbPgDetail.Controls.Add(this.label6);
            this.TbPgDetail.Controls.Add(this.TxtDescripcion);
            this.TbPgDetail.Controls.Add(this.label5);
            this.TbPgDetail.Controls.Add(this.label4);
            this.TbPgDetail.Controls.Add(this.label3);
            this.TbPgDetail.Controls.Add(this.TxtCodigo);
            this.TbPgDetail.Controls.Add(this.TxtStkMax);
            this.TbPgDetail.Location = new System.Drawing.Point(4, 25);
            this.TbPgDetail.Name = "TbPgDetail";
            this.TbPgDetail.Padding = new System.Windows.Forms.Padding(3);
            this.TbPgDetail.Size = new System.Drawing.Size(1299, 706);
            this.TbPgDetail.TabIndex = 1;
            this.TbPgDetail.Text = "Detalle de Productos";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AutoSize = true;
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 2;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BtnCancelar.Location = new System.Drawing.Point(299, 425);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(78, 31);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.AutoSize = true;
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 2;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BtnGuardar.Location = new System.Drawing.Point(218, 425);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 31);
            this.BtnGuardar.TabIndex = 16;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Estatus:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Empaque:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Stock Máximo:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TxtDescripcion.Location = new System.Drawing.Point(106, 44);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(625, 27);
            this.TxtDescripcion.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unidad de Medida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TxtCodigo.Location = new System.Drawing.Point(11, 44);
            this.TxtCodigo.Multiline = true;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(86, 27);
            this.TxtCodigo.TabIndex = 3;
            // 
            // TxtStkMax
            // 
            this.TxtStkMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TxtStkMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtStkMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TxtStkMax.Location = new System.Drawing.Point(265, 110);
            this.TxtStkMax.Multiline = true;
            this.TxtStkMax.Name = "TxtStkMax";
            this.TxtStkMax.Size = new System.Drawing.Size(230, 27);
            this.TxtStkMax.TabIndex = 9;
            // 
            // CboUnimed
            // 
            this.CboUnimed.FormattingEnabled = true;
            this.CboUnimed.Items.AddRange(new object[] {
            "KGS",
            "LTS",
            "UNI"});
            this.CboUnimed.Location = new System.Drawing.Point(11, 110);
            this.CboUnimed.Name = "CboUnimed";
            this.CboUnimed.Size = new System.Drawing.Size(121, 24);
            this.CboUnimed.TabIndex = 18;
            // 
            // CboIndole
            // 
            this.CboIndole.FormattingEnabled = true;
            this.CboIndole.Location = new System.Drawing.Point(138, 110);
            this.CboIndole.Name = "CboIndole";
            this.CboIndole.Size = new System.Drawing.Size(121, 24);
            this.CboIndole.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(135, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Índole:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(498, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Stock Mínimo:";
            // 
            // TxtStkMin
            // 
            this.TxtStkMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TxtStkMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtStkMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TxtStkMin.Location = new System.Drawing.Point(501, 110);
            this.TxtStkMin.Multiline = true;
            this.TxtStkMin.Name = "TxtStkMin";
            this.TxtStkMin.Size = new System.Drawing.Size(230, 27);
            this.TxtStkMin.TabIndex = 22;
            // 
            // NumEmp
            // 
            this.NumEmp.Location = new System.Drawing.Point(11, 173);
            this.NumEmp.Name = "NumEmp";
            this.NumEmp.Size = new System.Drawing.Size(120, 23);
            this.NumEmp.TabIndex = 23;
            // 
            // CboStatus
            // 
            this.CboStatus.FormattingEnabled = true;
            this.CboStatus.Items.AddRange(new object[] {
            "A",
            "N"});
            this.CboStatus.Location = new System.Drawing.Point(138, 173);
            this.CboStatus.Name = "CboStatus";
            this.CboStatus.Size = new System.Drawing.Size(121, 24);
            this.CboStatus.TabIndex = 24;
            // 
            // frmProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1307, 828);
            this.Controls.Add(this.spcnProd);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProd";
            this.Text = "frmProd";
            this.spcnProd.Panel1.ResumeLayout(false);
            this.spcnProd.Panel1.PerformLayout();
            this.spcnProd.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcnProd)).EndInit();
            this.spcnProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxBack)).EndInit();
            this.TbCnProd.ResumeLayout(false);
            this.TbPgList.ResumeLayout(false);
            this.TbPgList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProd)).EndInit();
            this.TbPgDetail.ResumeLayout(false);
            this.TbPgDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcnProd;
        private System.Windows.Forms.PictureBox PbxBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl TbCnProd;
        private System.Windows.Forms.TabPage TbPgList;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView DgvProd;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage TbPgDetail;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtStkMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtStkMin;
        private System.Windows.Forms.ComboBox CboIndole;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CboUnimed;
        private System.Windows.Forms.ComboBox CboStatus;
        private System.Windows.Forms.NumericUpDown NumEmp;
    }
}