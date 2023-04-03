using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ProdLab.LogicadeNegocio;
using ProdLab.EntidadesdeNegocio;

namespace ProdLab.UI.Winform.Prod
{
    public partial class FrmProductoLst : Form
    {
        bool bAll = false;


        public FrmProductoLst()
        {
            InitializeComponent();
            AsociaEventos();
            CargaDatos();
        }

        private void AsociaEventos()
        {
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
                CompVar.BaddNew = true;
                var form = Application.OpenForms.OfType<FrmPpal>().FirstOrDefault();
                form.AbrirFormHijo(new FrmProductoDtl());
                this.Close();
            };
            //Edit Client
            BtnEdit.Click += delegate
            {
                CompVar.BaddNew = false;
                var form = Application.OpenForms.OfType<FrmPpal>().FirstOrDefault();
                form.AbrirFormHijo(new FrmProductoDtl());
                this.Close();
            };
            //Edit Client
            BtnDelete.Click += delegate
            {
                CompVar.BaddNew = false;
                string sCod = CompVar.sCodigo;
                if (!sCod.Equals(""))
                {
                    ElimProd(sCod);
                    MessageBox.Show("Satisfactorio");
                }
            };
            //Grilla
            DgvProd.SelectionChanged += delegate
            {
                Int32 selCellCount = DgvProd.GetCellCount(DataGridViewElementStates.Selected);
                if (selCellCount > 0)
                {
                    int iFila = DgvProd.SelectedCells[0].RowIndex;
                    CompVar.sCodigo = DgvProd.Rows[iFila].Cells[0].Value.ToString();
                    CompVar.sDescri = DgvProd.Rows[iFila].Cells[1].Value.ToString();
                    CompVar.sUnimed = DgvProd.Rows[iFila].Cells[2].Value.ToString();
                    CompVar.sIndole = DgvProd.Rows[iFila].Cells[3].Value.ToString();
                    CompVar.sStkmax = DgvProd.Rows[iFila].Cells[4].Value.ToString();
                    CompVar.sStkmin = DgvProd.Rows[iFila].Cells[5].Value.ToString();
                    CompVar.sEmpaqu = DgvProd.Rows[iFila].Cells[6].Value.ToString();
                    CompVar.sStatus = DgvProd.Rows[iFila].Cells[7].Value.ToString();
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

        private void ElimProd(string stCod)
        {
            //ProductoBL oProd = new ProductoBL();
            int i = ProductoBL.Eliminar(stCod);
            DgvProd.DataSource = ProductoBL.ObtenerTodos();
        }

        private void CargaDatos()
        {
            DgvProd.DataSource = ProductoBL.ObtenerTodos();
            List<Indoles> sLista = IndolesBL.ObtenerTodos();
            //CboIndole.Items.Clear();
            CompVar.sListaInd = new List<string>();
            foreach (Indoles obj in sLista)
            {
                //CboIndole.Items.Add(obj.indole);
                CompVar.sListaInd.Add(obj.indole);
            }
        }

        private void BuscarCod()
        {
            string sTxt = TxtBuscar.Text;
            if (sTxt != "" && !sTxt.Equals(""))
            {
                if (bAll == false)
                {
                    string sVlr = TxtBuscar.Text;
                    var oTodos = ProductoBL.ObtenerById(sVlr);
                    DgvProd.DataSource = oTodos;
                    bAll = true;
                }
            }
            else
            {
                if (bAll == true)
                {
                    DgvProd.DataSource = ProductoBL.ObtenerTodos();
                    bAll = false;
                }
            }
        }
    }
}
