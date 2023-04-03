using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdLab.UI.Winform.Maes
{
    public partial class FrmMaes : Form
    {
        bool bEntra = false;
        bool bEntraP = false;
        public FrmMaes()
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
            PbxFormu.MouseEnter += delegate
            {
                if (bEntra == false) { 
                    PnlFrmChild.Visible = true;
                    bEntra = true;
                }
            };
            PbxEmpa.MouseEnter += delegate
            {
                if (bEntraP == false)
                {
                    PnlEmpaChild.Visible = true;
                    bEntraP = true;
                }
            };
            this.MouseEnter += delegate
            {
                if (bEntra == true)
                {
                    PnlFrmChild.Visible = false;
                    bEntra = false;
                }else if (bEntraP == true)
                {
                    PnlEmpaChild.Visible = false;
                    bEntraP = false;
                }
            };
        }
    }
}
