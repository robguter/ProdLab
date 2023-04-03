using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdLab.UI.Winform.Usua
{
    public partial class FrmUsua : Form
    {
        bool bEntra = false;

        public FrmUsua()
        {
            InitializeComponent();
            AsociarEventos();
        }

        private void AsociarEventos()
        {
            //Close
            PbxBack.Click += delegate
            {
                var form = Application.OpenForms.OfType<FrmPpal>().FirstOrDefault();
                form.AbrirFormHijo(new FrmInicio());
                this.Close();
            };
            PbxUsua.MouseEnter += delegate
            {
                if (bEntra == false) { 
                    PnlUsuaChild.Visible = true;
                    bEntra = true;
                }
            };
            this.MouseEnter += delegate
            {
                if (bEntra == true)
                {
                    PnlUsuaChild.Visible = false;
                    bEntra = false;
                }
            };
        }
    }
}
