﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Semana01
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=LAB1507-20\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");

        public void ListaClientes()
        {
            using (SqlDataAdapter Df = new SqlDataAdapter("Select * from Clientes", cn))
            {
                using (DataSet Da = new DataSet())
                {
                    Df.Fill(Da, "Clientes");
                    dgClientes.DataSource = Da.Tables["Clientes"];
                    lblTotal.Text = Da.Tables["Clientes"].Rows.Count.ToString();
                }
            }
        }

        private void frmClientes_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'neptunoDataSet2.clientes' Puede moverla o quitarla según sea necesario.
            ListaClientes();
        }
    }

}


