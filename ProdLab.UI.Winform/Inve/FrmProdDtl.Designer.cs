
namespace ProdLab.UI.Winform.Prod
{
    partial class FrmProdDtl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdDtl));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PbxBack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CboStatus = new System.Windows.Forms.ComboBox();
            this.NumEmp = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtStkMin = new System.Windows.Forms.TextBox();
            this.CboIndole = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CboUnimed = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.splitContainer1.Panel1.Controls.Add(this.PbxBack);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CboStatus);
            this.splitContainer1.Panel2.Controls.Add(this.NumEmp);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.TxtStkMin);
            this.splitContainer1.Panel2.Controls.Add(this.CboIndole);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.CboUnimed);
            this.splitContainer1.Panel2.Controls.Add(this.BtnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.BtnGuardar);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.TxtDescripcion);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.TxtCodigo);
            this.splitContainer1.Panel2.Controls.Add(this.TxtStkMax);
            this.splitContainer1.Size = new System.Drawing.Size(1248, 728);
            this.splitContainer1.SplitterDistance = 36;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // PbxBack
            // 
            this.PbxBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxBack.Image = ((System.Drawing.Image)(resources.GetObject("PbxBack.Image")));
            this.PbxBack.Location = new System.Drawing.Point(1193, 17);
            this.PbxBack.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.PbxBack.Name = "PbxBack";
            this.PbxBack.Size = new System.Drawing.Size(40, 40);
            this.PbxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxBack.TabIndex = 2;
            this.PbxBack.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detalle del Producto";
            // 
            // CboStatus
            // 
            this.CboStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.CboStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.CboStatus.FormattingEnabled = true;
            this.CboStatus.Items.AddRange(new object[] {
            "A",
            "N"});
            this.CboStatus.Location = new System.Drawing.Point(264, 288);
            this.CboStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CboStatus.Name = "CboStatus";
            this.CboStatus.Size = new System.Drawing.Size(180, 28);
            this.CboStatus.TabIndex = 60;
            // 
            // NumEmp
            // 
            this.NumEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.NumEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.NumEmp.Location = new System.Drawing.Point(74, 288);
            this.NumEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumEmp.Name = "NumEmp";
            this.NumEmp.Size = new System.Drawing.Size(180, 26);
            this.NumEmp.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(804, 160);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "Stock Mínimo:";
            // 
            // TxtStkMin
            // 
            this.TxtStkMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.TxtStkMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.TxtStkMin.Location = new System.Drawing.Point(808, 191);
            this.TxtStkMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtStkMin.Multiline = true;
            this.TxtStkMin.Name = "TxtStkMin";
            this.TxtStkMin.Size = new System.Drawing.Size(344, 40);
            this.TxtStkMin.TabIndex = 58;
            // 
            // CboIndole
            // 
            this.CboIndole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.CboIndole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.CboIndole.FormattingEnabled = true;
            this.CboIndole.Location = new System.Drawing.Point(264, 191);
            this.CboIndole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CboIndole.Name = "CboIndole";
            this.CboIndole.Size = new System.Drawing.Size(180, 28);
            this.CboIndole.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 158);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Índole:";
            // 
            // CboUnimed
            // 
            this.CboUnimed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.CboUnimed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.CboUnimed.FormattingEnabled = true;
            this.CboUnimed.Items.AddRange(new object[] {
            "KGS",
            "LTS",
            "UNI"});
            this.CboUnimed.Location = new System.Drawing.Point(74, 191);
            this.CboUnimed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CboUnimed.Name = "CboUnimed";
            this.CboUnimed.Size = new System.Drawing.Size(180, 28);
            this.CboUnimed.TabIndex = 54;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AutoSize = true;
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 2;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.BtnCancelar.Location = new System.Drawing.Point(604, 420);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(117, 48);
            this.BtnCancelar.TabIndex = 53;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.AutoSize = true;
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 2;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.BtnGuardar.Location = new System.Drawing.Point(482, 420);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(112, 48);
            this.BtnGuardar.TabIndex = 52;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 257);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Estatus:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 255);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Empaque:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Stock Máximo:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.TxtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.TxtDescripcion.Location = new System.Drawing.Point(216, 89);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(936, 40);
            this.TxtDescripcion.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Unidad de Medida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Código:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.TxtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.TxtCodigo.Location = new System.Drawing.Point(74, 89);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCodigo.Multiline = true;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(128, 40);
            this.TxtCodigo.TabIndex = 44;
            // 
            // TxtStkMax
            // 
            this.TxtStkMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.TxtStkMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.TxtStkMax.Location = new System.Drawing.Point(454, 191);
            this.TxtStkMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtStkMax.Multiline = true;
            this.TxtStkMax.Name = "TxtStkMax";
            this.TxtStkMax.Size = new System.Drawing.Size(344, 40);
            this.TxtStkMax.TabIndex = 49;
            // 
            // FrmProdDtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1248, 728);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmProdDtl";
            this.Text = "FrmProdDtl";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox CboStatus;
        private System.Windows.Forms.NumericUpDown NumEmp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtStkMin;
        private System.Windows.Forms.ComboBox CboIndole;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CboUnimed;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtStkMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PbxBack;
    }
}