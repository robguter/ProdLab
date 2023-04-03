using ProdLab.UI.Winform.Compr;
using ProdLab.UI.Winform.Inve;
using ProdLab.UI.Winform.Maes;
using ProdLab.UI.Winform.Prod;
using ProdLab.UI.Winform.Usua;
using ProdLab.UI.Winform.Ventas;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProdLab.UI.Winform
{
    public partial class FrmPpal : Form
    {
        public FrmPpal()
        {
            InitializeComponent();
            AsociaEventos();
        }
        private void AsociaEventos()
        {
            BtnSali.Click += delegate { Application.Exit(); };
            PbxLogo.Click += delegate { AbrirFormHijo(new FrmInicio()); };
            PbxCerrar.Click += delegate { ClickBtn(PbxCerrar); };
            PbxRestaura.Click += delegate { ClickBtn(PbxRestaura); };
            PbxMinimo.Click += delegate { ClickBtn(PbxMinimo); };
            PbxMaximo.Click += delegate { ClickBtn(PbxMaximo); };

            PnlBarTitle.MouseDown += delegate
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            };
            BtnMaes.MouseDown += delegate
            {
                AbrirFormHijo(new FrmMaes());
                LblTit.Text = "Panel Maestro";
            };
            BtnInve.Click += delegate
            {
                AbrirFormHijo(new FrmInve());
                LblTit.Text = "Panel de Inventario";
            };
            BtnProd.Click += delegate
            {
                AbrirFormHijo(new FrmProduccion());
                LblTit.Text = "Panel de Producción";
            };
            BtnComp.Click += delegate
            {
                AbrirFormHijo(new FrmComp());
                LblTit.Text = "Panel de Compras";
            };
            BtnVent.Click += delegate
            {
                AbrirFormHijo(new FrmVentas());
                LblTit.Text = "Panel de Ventas";
            };
            BtnUsua.Click += delegate
            {
                AbrirFormHijo(new FrmUsua());
                LblTit.Text = "Panel de Usuarios";
            };
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void AbrirFormHijo(Form frmH)
        {
            Panel pnlCont = this.PnlContenedor as Panel;
            if (pnlCont.Controls.Count > 0) pnlCont.Controls.RemoveAt(0);
            frmH.TopLevel = false;
            frmH.Dock = DockStyle.Fill;
            pnlCont.Controls.Add(frmH);
            pnlCont.Tag = frmH;
            frmH.Show();
        }
        private void FrmPpal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                PbxRestaura.Visible = true;
                PbxMaximo.Visible = false;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                PbxRestaura.Visible = false;
                PbxMaximo.Visible = true;
            }
        }
        private void FrmPpal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            AbrirFormHijo(new FrmInicio());
        }
        // Usando expresión lambda definida previamente
        private void ClickBtn(object sender) {
            PictureBox pbxAct = (PictureBox)sender;
            if (pbxAct.Name == "PbxRestaura")
            {
                this.WindowState = FormWindowState.Normal;
                PbxRestaura.Visible = false;
                PbxMaximo.Visible = true;
            }else if (pbxAct.Name == "PbxMaximo" || pbxAct.Name == "PbxMinimo")
            {
                PbxRestaura.Visible = true;
                PbxMaximo.Visible = false;
                if (this.WindowState == FormWindowState.Maximized)
                    this.WindowState = FormWindowState.Minimized;
                else
                    this.WindowState = FormWindowState.Maximized;
            }
            else if (pbxAct.Name == "PbxCerrar")
            {
                Application.Exit();
            }
        }
        private void FrmPpal_ControlRemoved(object sender, ControlEventArgs e)
        {
            LblTit.Text = "Sistema de Control de Producción REMOIVED";
            AbrirFormHijo(new FrmInicio());
        }

    }
}
