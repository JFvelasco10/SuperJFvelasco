using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace SuperJFvelasco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private bool GuardarProducto()
        {

            MySqlConnection conex = new MySqlConnection();
            conex.ConnectionString = "Server=127.0.0.1;" + "Database= bd_superjfvelasco;" + "User= root;" + "Pwd=;" + "SslMode= none;";

            conex.Open();
            string Slq = @"INSERT INTO tbproducto (NomProducto,ValProducto) VALUES (@NomProducto,@ValProducto)";

            MySqlCommand CMD = new MySqlCommand(Slq, conex);
            CMD.Parameters.AddWithValue("@NomProducto", textBox1.Text);
            CMD.Parameters.AddWithValue("@ValProducto", textBox2.Text);

            int NumeroFilas = CMD.ExecuteNonQuery();
            if (NumeroFilas > 0)
            {
                return true;
            }
            return false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
        private void LimpiarFormulario()
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GuardarProducto())
            {
                MessageBox.Show("Producto se registro con exito!!!", "Guardando Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
        }
    }
}