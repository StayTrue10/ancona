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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            conexion.obtenerConexion();
            MessageBox.Show("exito");
        }

        private void nombre_Click(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            user add = new user
            {
                nombre = NameBox.Text,
                ticket = TicketBox.Text
            };
            int resultado = funciones.agregar(add);
            if (resultado > 0)
            {
                MessageBox.Show("registrado");
            }
            else
            {
                MessageBox.Show("no regsitrado");
            }
        }
    }
}
