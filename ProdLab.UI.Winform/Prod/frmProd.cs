using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProdLab.LogicadeNegocio;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.UI.Winform
{
    public partial class frmProd : Form
    {
        string sCodigo = "";
        string sDescri = "";
        string sUnimed = "";
        string sIndole = "";
        string sStkmax = "";
        string sStkmin = "";
        string sEmpaqu = "";
        string sStatus = "";
        bool BaddNew = false;
        bool bAll = false;

        public frmProd()
        {
            InitializeComponent();
            CargaDatos();
            AssociateAndRaiseViewEvents();
            TbCnProd.TabPages.Remove(TbPgDetail);
        }

        private void CargaDatos()
        {
            DgvProd.DataSource = ProductoBL.ObtenerTodos();
            List<Indoles> sLista = IndolesBL.ObtenerTodos();
            CboIndole.Items.Clear();
            foreach (Indoles obj in sLista)
            {
                CboIndole.Items.Add(obj.indole);
            }
        }
        private void AssociateAndRaiseViewEvents()
        {
            //Combos
            CboUnimed.SelectedIndexChanged += delegate
            {
                int iIndex = CboUnimed.SelectedIndex;
                sUnimed = CboUnimed.Items[iIndex].ToString();
            };
            CboIndole.SelectedIndexChanged += delegate
            {
                int iIndex = CboIndole.SelectedIndex;
                sIndole = CboIndole.Items[iIndex].ToString();
            };
            CboStatus.SelectedIndexChanged += delegate
            {
                int iIndex = CboStatus.SelectedIndex;
                sStatus = CboStatus.Items[iIndex].ToString();
            };
            //Cancelar
            BtnCancelar.Click += delegate
            {
                TbCnProd.TabPages.Remove(TbPgDetail);
                TbCnProd.TabPages.Add(TbPgList);
                CargaDatos();
            };
            //Guardar Client
            BtnGuardar.Click += delegate
            {
                Producto oProd = new Producto();
                double fStkMax = Convert.ToDouble(TxtStkMax.Text);
                double fStkMin = Convert.ToDouble(TxtStkMin.Text);
                oProd.Codigo = this.TxtCodigo.Text;
                oProd.Descripcion = this.TxtDescripcion.Text;
                oProd.Unimed = sUnimed;
                oProd.Indole = sIndole;
                oProd.StkMax = (float)fStkMax;
                oProd.StkMin = (float)fStkMin;
                oProd.EmpaqueUnd = (float)NumEmp.Value;
                oProd.Status = sStatus;
                if (BaddNew == true)
                {
                    int iRslt = ProductoBL.Guardar(oProd);
                }
                else
                {
                    int iRslt = ProductoBL.Editar(oProd);
                }
                TbCnProd.TabPages.Remove(TbPgDetail);
                TbCnProd.TabPages.Add(TbPgList);
                CargaDatos();
                MessageBox.Show("Satisfactorio");
            };
            //Find Client
            BtnBuscar.Click += delegate {
                BuscarCod();
            };
            TxtBuscar.TextChanged += (s, e) =>
            {
                BuscarCod();
            };
            //Add Client
            BtnAdd.Click += delegate
            {
                BaddNew = true;
                TbCnProd.TabPages.Remove(TbPgList);
                TbCnProd.TabPages.Add(TbPgDetail);
                TbPgDetail.Text = "Add new Client";
            };
            //Edit Client
            BtnEdit.Click += delegate
            {
                BaddNew = false;
                TbCnProd.TabPages.Remove(TbPgList);
                TbCnProd.TabPages.Add(TbPgDetail);
                TbPgDetail.Text = "Edit Client";
            };
            //Grilla
            DgvProd.SelectionChanged += delegate
            {
                Int32 selCellCount = DgvProd.GetCellCount(DataGridViewElementStates.Selected);
                if (selCellCount > 0)
                {
                    int iFila = DgvProd.SelectedCells[0].RowIndex;
                    sCodigo = DgvProd.Rows[iFila].Cells[0].Value.ToString();
                    sDescri = DgvProd.Rows[iFila].Cells[1].Value.ToString();
                    sUnimed = DgvProd.Rows[iFila].Cells[2].Value.ToString();
                    sIndole = DgvProd.Rows[iFila].Cells[3].Value.ToString();
                    sStkmax = DgvProd.Rows[iFila].Cells[4].Value.ToString();
                    sStkmin = DgvProd.Rows[iFila].Cells[5].Value.ToString();
                    sEmpaqu = DgvProd.Rows[iFila].Cells[6].Value.ToString();
                    sStatus = DgvProd.Rows[iFila].Cells[7].Value.ToString();
                    this.TxtCodigo.Text = sCodigo;
                    this.TxtDescripcion.Text = sDescri;
                    this.CboUnimed.Text = sUnimed;
                    this.CboIndole.Text = sIndole;
                    this.TxtStkMax.Text = sStkmax;
                    this.TxtStkMin.Text = sStkmin;
                    this.NumEmp.Text = sEmpaqu;
                    this.CboStatus.Text = sStatus;
                }
            };
            //Close
            PbxBack.Click += delegate
            {
                var form = Application.OpenForms.OfType<FrmPpal>().FirstOrDefault();
                form.AbrirFormHijo(new FrmInicio());
                this.Close();
            };
        }

        private void BuscarCod()
        {
            string sTxt = TxtBuscar.Text;
            if (sTxt != "" && !sTxt.Equals(""))
            {
                if (bAll == true)
                {
                    string sVlr = TxtBuscar.Text;
                    var oTodos = ProductoBL.ObtenerById(sVlr);
                    DgvProd.DataSource = oTodos;
                    bAll = false;
                }
            }
            else
            {
                if (bAll==false) {
                    DgvProd.DataSource = ProductoBL.ObtenerTodos();
                    bAll = true;
                }
            }
        }
    }
}
