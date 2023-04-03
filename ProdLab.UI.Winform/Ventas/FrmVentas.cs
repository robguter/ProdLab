using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdLab.UI.Winform.Ventas
{
    public partial class FrmVentas : Form
    {
        bool bEntraO = false;
        bool bEntraE = false;
        bool bEntraF = false;
        bool bEntraD = false;
        bool bEntraP = false;
        bool bEntraA = false;

        public FrmVentas()
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
            PbxOrde.MouseEnter += delegate
            {
                if (bEntraO == false)
                {
                    PnlOrdeChild.Visible = true;
                    bEntraO = true;
                }
            };
            PbxEntre.MouseEnter += delegate
            {
                if (bEntraE == false)
                {
                    PnlEntreChild.Visible = true;
                    bEntraE = true;
                }
            };
            PbxFact.MouseEnter += delegate
            {
                if (bEntraF == false)
                {
                    PnlFactChild.Visible = true;
                    bEntraF = true;
                }
            };
            PbxDevo.MouseEnter += delegate
            {
                if (bEntraD == false)
                {
                    PnlDevoChild.Visible = true;
                    bEntraD = true;
                }
            };
            PbxProv.MouseEnter += delegate
            {
                if (bEntraP == false)
                {
                    PnlProvChild.Visible = true;
                    bEntraP = true;
                }
            };
            PbxAran.MouseEnter += delegate
            {
                if (bEntraA == false)
                {
                    PnlAranChild.Visible = true;
                    bEntraA = true;
                }
            };
            this.MouseEnter += delegate
            {
                if (bEntraO == true)
                {
                    PnlOrdeChild.Visible = false;
                    bEntraO = false;
                }
                else if (bEntraE == true)
                {
                    PnlEntreChild.Visible = false;
                    bEntraE = false;
                }
                else if (bEntraF == true)
                {
                    PnlFactChild.Visible = false;
                    bEntraF = false;
                }
                else if (bEntraD == true)
                {
                    PnlDevoChild.Visible = false;
                    bEntraD = false;
                }
                else if (bEntraP == true)
                {
                    PnlProvChild.Visible = false;
                    bEntraP = false;
                }
                else if (bEntraA == true)
                {
                    PnlAranChild.Visible = false;
                    bEntraA = false;
                }
            };
        }
    }
}
