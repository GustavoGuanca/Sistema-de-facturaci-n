using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Sistema.Negocio;

namespace Sistema.Presentacion
{

    public partial class FrmLoginTarjeta : Form
    {

        private int x = 0; // Posición horizontal de la imagen
        private int y = 0; // Posición vertical de la imagen
        private int dx = 5; // Desplazamiento horizontal
        private int dy = 5; // Desplazamiento vertical
        public FrmLoginTarjeta()
        {
            InitializeComponent();
            txtRfid.TextChanged += txtRfid_TextChanged;
            txtRfid.Size = new Size(0, 0); // Establece el tamaño del TextBox a 0
        }

        private void FrmLoginTarjeta_Load(object sender, EventArgs e)
        {
            // Inicia el Timer cuando se carga el formulario
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Actualiza la posición de la imagen
            x += dx;
            y += dy;

            // Verifica los límites de la ventana
            if (x + pbxImagen.Width > ClientSize.Width || x < 0)
                dx *= -1; // Invierte el desplazamiento horizontal

            if (y + pbxImagen.Height > ClientSize.Height || y < 0)
                dy *= -1; // Invierte el desplazamiento vertical

            // Actualiza la ubicación de la imagen
            pbxImagen.Location = new Point(x, y);
        }

        private void txtRfid_TextChanged(object sender, EventArgs e)
        {
            string Clave = txtRfid.Text.Trim();
            if (!string.IsNullOrEmpty(Clave))
            {
                try
                {
                    DataTable Tabla = new DataTable();
                    Tabla = NUsuario.LoginRfid(Clave);
                    if (Tabla.Rows.Count <= 0)
                    {
                        MessageBox.Show("El RFID no está asociado a ningún usuario.", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Convert.ToBoolean(Tabla.Rows[0][4]) == false)
                        {
                            MessageBox.Show("Este usuario no está activo.", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            FrmPrincipal Frm = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
                            if (Frm == null)
                            {
                                Frm = new FrmPrincipal();
                                Frm.IdUsuario = Convert.ToInt32(Tabla.Rows[0][0]);
                                Frm.IdRol = Convert.ToInt32(Tabla.Rows[0][1]);
                                Frm.Rol = Convert.ToString(Tabla.Rows[0][2]);
                                Frm.Nombre = Convert.ToString(Tabla.Rows[0][3]);
                                Frm.Estado = Convert.ToBoolean(Tabla.Rows[0][4]);
                                Frm.Show();
                            }
                            else
                            {
                                Frm.BringToFront();
                            }
                            this.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
