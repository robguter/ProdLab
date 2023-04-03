using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdLab.UI.Winform.Prod
{
    public partial class FrmProduccion : Form
    {
        bool bEntraP = false;
        bool bEntraE = false;
        bool bEntraA = false;

        public FrmProduccion()
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
            PbxProd.MouseEnter += delegate
            {
                if (bEntraP == false)
                {
                    PnlProdChild.Visible = true;
                    bEntraP = true;
                }
            };
            PbxEmpa.MouseEnter += delegate
            {
                if (bEntraE == false)
                {
                    PnlEmpaChild.Visible = true;
                    bEntraE = true;
                }
            };
            PbxEmba.MouseEnter += delegate
            {
                if (bEntraA == false)
                {
                    PnlEmbaChild.Visible = true;
                    bEntraA = true;
                }
            };
            this.MouseEnter += delegate
            {
                if (bEntraP == true)
                {
                    PnlProdChild.Visible = false;
                    bEntraP = false;
                }
                else if (bEntraE == true)
                {
                    PnlEmpaChild.Visible = false;
                    bEntraE = false;
                }
                else if (bEntraA == true)
                {
                    PnlEmbaChild.Visible = false;
                    bEntraA = false;
                }
            };
        }
    }
}
