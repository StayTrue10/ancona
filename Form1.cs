using Registro.mysql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Form1 : Form
    {
        conexion combo = new conexion();
        public Form1()
        {
            InitializeComponent();
            combo.seleccionar(cb);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tbHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (NameBox.Text.Length == 0 || TicketBox.Text.Length == 0)
            {
                MessageBox.Show("Faltan campos por rellenar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {          
                    user add = new user
                {
                    nombre = NameBox.Text,
                    ticket = TicketBox.Text
                };
                int resultado = funciones.agregar(add);
                if (resultado > 0)
                {
                    MessageBox.Show("Registrado con exito!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            NameBox.Text = "";
            TicketBox.Text = "";
        }






    }
}
