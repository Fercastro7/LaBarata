using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace La_Barata
{
    public partial class Ventas : Form
    {
        double total = 0;

        public Ventas()
        {
            InitializeComponent();
        }
        public static class AutoCompleClass
        {
            public static object ConfigurationManager { get; private set; }

            //metodo para cargar los datos de la bd
            public static DataTable Datos()
            {
                DataTable dt = new DataTable();

               // SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ToString());//cadena conexion

               // string consulta = "SELECT * FROM PRODUCTO_INVENTARIO"; //consulta a la tabla producto_inventario
               // SqlCommand comando = new SqlCommand(consulta, conexion);

               // SqlDataAdapter adap = new SqlDataAdapter(comando);

               // adap.Fill(dt);
                return dt;
            }

            //metodo para cargar la coleccion de datos para el autocomplete
            public static AutoCompleteStringCollection Autocomplete()
            {
                DataTable dt = Datos();

                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                //recorrer y cargar los items para el autocompletado
                foreach (DataRow row in dt.Rows)
                {
                    coleccion.Add(Convert.ToString(row["producto"]));
                }

                return coleccion;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        { }

        public void numberKeyPress(KeyPressEventArgs e)
        {
            //condicion que solo permite ingresar numeros
            //if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
           // if (char.IsLetter(e.KeyChar)) { e.Handled = true; }

        }

        //public void numberDecimal(TextBox textBox, KeyPressEventArgs e)
            //codicion que permite ingresar datos numericos
            //if (char.IsDigit(e.KeyChar)){}


private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //cargar los datos para el autocomplete del textbox
            textBox1.AutoCompleteCustomSource = AutoCompleClass.Autocomplete();
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total = total + Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(total);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
