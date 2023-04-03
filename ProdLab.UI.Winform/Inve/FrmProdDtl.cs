using ProdLab.EntidadesdeNegocio;
using ProdLab.LogicadeNegocio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProdLab.UI.Winform.Prod
{
    public partial class FrmProdDtl : Form
    {
        public FrmProdDtl()
        {
            InitializeComponent();
            AsociaEventos();
            if (CompVar.BaddNew != true)
                CargaCps();
            CrgInd();
        }

        private void CrgInd()
        {
            CboIndole.Items.Clear();
            foreach (string lista in CompVar.sListaInd)
            {
                CboIndole.Items.Add(lista);
            }
        }

        private void AsociaEventos()
        {
            //Combos
            CboUnimed.SelectedIndexChanged += delegate
            {
                int iIndex = CboUnimed.SelectedIndex;
                CompVar.sUnimed = CboUnimed.Items[iIndex].ToString();
            };
            CboIndole.SelectedIndexChanged += delegate
            {
                int iIndex = CboIndole.SelectedIndex;
                CompVar.sIndole = CboIndole.Items[iIndex].ToString();
            };
            CboStatus.SelectedIndexChanged += delegate
            {
                int iIndex = CboStatus.SelectedIndex;
                CompVar.sStatus = CboStatus.Items[iIndex].ToString();
            };
            //Cancelar
            BtnCancelar.Click += delegate
            {
                var form = Application.OpenForms.OfType<FrmPpal>().FirstOrDefault();
                form.AbrirFormHijo(new FrmProdLst());
                this.Close();
            };
            //Guardar Client
            BtnGuardar.Click += delegate
            {
                Producto oProd = new Producto();
                double fStkMax = Convert.ToDouble(TxtStkMax.Text);
                double fStkMin = Convert.ToDouble(TxtStkMin.Text);
                oProd.Codigo = this.TxtCodigo.Text;
                oProd.Descripcion = this.TxtDescripcion.Text;
                oProd.Unimed = CompVar.sUnimed;
                oProd.Indole = CompVar.sIndole;
                oProd.StkMax = (float)fStkMax;
                oProd.StkMin = (float)fStkMin;
                oProd.EmpaqueUnd = (float)NumEmp.Value;
                oProd.Status = CompVar.sStatus;
                if (CompVar.BaddNew == true)
                {
                    int iRslt = ProductoBL.Guardar(oProd);
                }
                else
                {
                    int iRslt = ProductoBL.Editar(oProd);
                }
                var form = Application.OpenForms.OfType<FrmPpal>().FirstOrDefault();
                form.AbrirFormHijo(new FrmProdLst());
                this.Close();
                MessageBox.Show("Satisfactorio");
            };
        }

        private void CargaCps()
        {
            TxtCodigo.Text = CompVar.sCodigo;
            TxtDescripcion.Text = CompVar.sDescri;
            CboUnimed.Text = CompVar.sUnimed;
            CboIndole.Text = CompVar.sIndole;
            TxtStkMax.Text = CompVar.sStkmax;
            TxtStkMin.Text = CompVar.sStkmin;
            NumEmp.Text = CompVar.sEmpaqu;
            CboStatus.Text = CompVar.sStatus;
        }
    }
}
