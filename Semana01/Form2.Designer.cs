namespace Semana01
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.DgProductos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.neptunoDataSet3 = new Semana01.neptunoDataSet3();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Semana01.neptunoDataSet3TableAdapters.productosTableAdapter();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadPorUnidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadesEnExistenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadesEnPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelNuevoPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suspendidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA DE PRODUCTOS - MEDIANTE App.config";
            // 
            // DgProductos
            // 
            this.DgProductos.AllowUserToAddRows = false;
            this.DgProductos.AllowUserToDeleteRows = false;
            this.DgProductos.AutoGenerateColumns = false;
            this.DgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.idProveedorDataGridViewTextBoxColumn,
            this.idCategoriaDataGridViewTextBoxColumn,
            this.cantidadPorUnidadDataGridViewTextBoxColumn,
            this.precioUnidadDataGridViewTextBoxColumn,
            this.unidadesEnExistenciaDataGridViewTextBoxColumn,
            this.unidadesEnPedidoDataGridViewTextBoxColumn,
            this.nivelNuevoPedidoDataGridViewTextBoxColumn,
            this.suspendidoDataGridViewTextBoxColumn,
            this.categoriaProductoDataGridViewTextBoxColumn});
            this.DgProductos.DataSource = this.productosBindingSource;
            this.DgProductos.Location = new System.Drawing.Point(130, 135);
            this.DgProductos.Name = "DgProductos";
            this.DgProductos.ReadOnly = true;
            this.DgProductos.Size = new System.Drawing.Size(556, 183);
            this.DgProductos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NUMERO DE PRODUCTOS";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCantidad.Location = new System.Drawing.Point(338, 337);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(51, 15);
            this.LblCantidad.TabIndex = 3;
            this.LblCantidad.Text = "              ";
            // 
            // neptunoDataSet3
            // 
            this.neptunoDataSet3.DataSetName = "neptunoDataSet3";
            this.neptunoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.neptunoDataSet3;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "idproducto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "idproducto";
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            this.idproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "nombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "nombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            this.nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProveedorDataGridViewTextBoxColumn
            // 
            this.idProveedorDataGridViewTextBoxColumn.DataPropertyName = "idProveedor";
            this.idProveedorDataGridViewTextBoxColumn.HeaderText = "idProveedor";
            this.idProveedorDataGridViewTextBoxColumn.Name = "idProveedorDataGridViewTextBoxColumn";
            this.idProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            this.idCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadPorUnidadDataGridViewTextBoxColumn
            // 
            this.cantidadPorUnidadDataGridViewTextBoxColumn.DataPropertyName = "cantidadPorUnidad";
            this.cantidadPorUnidadDataGridViewTextBoxColumn.HeaderText = "cantidadPorUnidad";
            this.cantidadPorUnidadDataGridViewTextBoxColumn.Name = "cantidadPorUnidadDataGridViewTextBoxColumn";
            this.cantidadPorUnidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioUnidadDataGridViewTextBoxColumn
            // 
            this.precioUnidadDataGridViewTextBoxColumn.DataPropertyName = "precioUnidad";
            this.precioUnidadDataGridViewTextBoxColumn.HeaderText = "precioUnidad";
            this.precioUnidadDataGridViewTextBoxColumn.Name = "precioUnidadDataGridViewTextBoxColumn";
            this.precioUnidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadesEnExistenciaDataGridViewTextBoxColumn
            // 
            this.unidadesEnExistenciaDataGridViewTextBoxColumn.DataPropertyName = "unidadesEnExistencia";
            this.unidadesEnExistenciaDataGridViewTextBoxColumn.HeaderText = "unidadesEnExistencia";
            this.unidadesEnExistenciaDataGridViewTextBoxColumn.Name = "unidadesEnExistenciaDataGridViewTextBoxColumn";
            this.unidadesEnExistenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadesEnPedidoDataGridViewTextBoxColumn
            // 
            this.unidadesEnPedidoDataGridViewTextBoxColumn.DataPropertyName = "unidadesEnPedido";
            this.unidadesEnPedidoDataGridViewTextBoxColumn.HeaderText = "unidadesEnPedido";
            this.unidadesEnPedidoDataGridViewTextBoxColumn.Name = "unidadesEnPedidoDataGridViewTextBoxColumn";
            this.unidadesEnPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nivelNuevoPedidoDataGridViewTextBoxColumn
            // 
            this.nivelNuevoPedidoDataGridViewTextBoxColumn.DataPropertyName = "nivelNuevoPedido";
            this.nivelNuevoPedidoDataGridViewTextBoxColumn.HeaderText = "nivelNuevoPedido";
            this.nivelNuevoPedidoDataGridViewTextBoxColumn.Name = "nivelNuevoPedidoDataGridViewTextBoxColumn";
            this.nivelNuevoPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suspendidoDataGridViewTextBoxColumn
            // 
            this.suspendidoDataGridViewTextBoxColumn.DataPropertyName = "suspendido";
            this.suspendidoDataGridViewTextBoxColumn.HeaderText = "suspendido";
            this.suspendidoDataGridViewTextBoxColumn.Name = "suspendidoDataGridViewTextBoxColumn";
            this.suspendidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaProductoDataGridViewTextBoxColumn
            // 
            this.categoriaProductoDataGridViewTextBoxColumn.DataPropertyName = "categoriaProducto";
            this.categoriaProductoDataGridViewTextBoxColumn.HeaderText = "categoriaProducto";
            this.categoriaProductoDataGridViewTextBoxColumn.Name = "categoriaProductoDataGridViewTextBoxColumn";
            this.categoriaProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgProductos);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neptunoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCantidad;
        private neptunoDataSet3 neptunoDataSet3;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private neptunoDataSet3TableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadPorUnidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadesEnExistenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadesEnPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelNuevoPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suspendidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaProductoDataGridViewTextBoxColumn;
    }
}