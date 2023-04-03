using ProdLab.EntidadesdeNegocio;
using ProdLab.LogicadeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdLab.UI.Winform.Inve
{
    public partial class FrmInve : Form
    {
        bool bEntraM = false;
        bool bEntraV = false;
        bool bEntraD = false;

        public FrmInve()
        {
            InitializeComponent();
            AsociarEventos();
            CargaDatos();
        }

        private void CargaDatos()
        {
            List<Indoles> sLista = IndolesBL.ObtenerTodos();
            //CboIndole.Items.Clear();
            CompVar.sListaInd = new List<string>();
            foreach (Indoles obj in sLista)
            {
                //CboIndole.Items.Add(obj.indole);
                CompVar.sListaInd.Add(obj.indole);
            }
        }

        private void AsociarEventos()
        {
            //ico Mantenimiento de Materiales
            icoMantMate.Click += delegate
            {
                var form = Application.OpenForms.OfType<FrmPpal>().FirstOrDefault();
                form.AbrirFormHijo(new FrmProductoDtl());
                this.Close();
            };
            icoSqlMate.Click += delegate
            {
                var form = Application.OpenForms.OfType<FrmPpal>().FirstOrDefault();
                form.AbrirFormHijo(new FrmProductoLst());
                this.Close();
            };
            icoRepMate.Click += delegate
            {
                /**var form = Application.OpenForms.OfType<FrmPpal>().FirstOrDefault();
                form.AbrirFormHijo(new FrmProductoLst());
                this.Close();*/
            };
            //Close
            PbxBack.Click += delegate
            {
                var form = Application.OpenForms.OfType<FrmPpal>().FirstOrDefault();
                form.AbrirFormHijo(new FrmInicio());
                this.Close();
            };
            PbxMate.MouseEnter += delegate
            {
                if (bEntraM == false)
                {
                    PnlMateChild.Visible = true;
                    bEntraM = true;
                }
            };
            PbxMovi.MouseEnter += delegate
            {
                if (bEntraV == false)
                {
                    PnlMoviChild.Visible = true;
                    bEntraV = true;
                }
            };
            PbxDepo.MouseEnter += delegate
            {
                if (bEntraD == false)
                {
                    PnlDepoChild.Visible = true;
                    bEntraD = true;
                }
            };
            this.MouseEnter += delegate
            {
                if (bEntraM == true)
                {
                    PnlMateChild.Visible = false;
                    bEntraM = false;
                }
                else if (bEntraV == true)
                {
                    PnlMoviChild.Visible = false;
                    bEntraV = false;
                }else if (bEntraD == true)
                {
                    PnlDepoChild.Visible = false;
                    bEntraD = false;
                }
            };
        }
    }
}
