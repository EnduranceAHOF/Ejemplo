using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-LUCIANO ; database=amador_empanadas ; integrated security=True");
            conexion.Open();
            String query = "SELECT nombre FROM Comuna";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader lectura = comando.ExecuteReader();
            while(lectura.Read())
            {
                textBox1.AppendText(lectura["nombre"].ToString());
                textBox1.AppendText(Environment.NewLine);
            }
            conexion.Close();
        }
    }
}
