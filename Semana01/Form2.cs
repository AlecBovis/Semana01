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
using System.Configuration;

namespace Semana01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Alec"].ConnectionString);

        private void Form2_Load(object sender, EventArgs e)
        {
            ListaProductos();
        }

        public void ListaProductos()
        {
            using (SqlDataAdapter df = new SqlDataAdapter("Usp_ListaProductos_Neptuno", cn))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataSet Da = new DataSet())
                {
                    df.Fill(Da, "Productos");
                    DgProductos.DataSource = Da.Tables["Productos"];
                    LblCantidad.Text = Da.Tables["Productos"].Rows.Count.ToString();
                }
            }
        }
    }
}
