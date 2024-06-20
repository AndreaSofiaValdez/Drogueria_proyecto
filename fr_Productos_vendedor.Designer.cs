
namespace Drogueria_proyecto
{
    partial class fr_Productos_vendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_Productos_vendedor));
            this.dgv_producto_v = new System.Windows.Forms.DataGridView();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcioncategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewproductoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet21 = new Drogueria_proyecto.DROGUERIADataSet21();
            this.viewproductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producto_vendedor = new Drogueria_proyecto.producto_vendedor();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet = new Drogueria_proyecto.DROGUERIADataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.productoTableAdapter = new Drogueria_proyecto.DROGUERIADataSetTableAdapters.ProductoTableAdapter();
            this.view_productoTableAdapter = new Drogueria_proyecto.producto_vendedorTableAdapters.view_productoTableAdapter();
            this.view_productoTableAdapter1 = new Drogueria_proyecto.DROGUERIADataSet21TableAdapters.view_productoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_producto_v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewproductoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewproductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_vendedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_producto_v
            // 
            this.dgv_producto_v.AllowUserToDeleteRows = false;
            this.dgv_producto_v.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_producto_v.AutoGenerateColumns = false;
            this.dgv_producto_v.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_producto_v.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expr1DataGridViewTextBoxColumn,
            this.expr2DataGridViewTextBoxColumn,
            this.expr5DataGridViewTextBoxColumn,
            this.expr4DataGridViewTextBoxColumn,
            this.expr6DataGridViewTextBoxColumn,
            this.descripcioncategoriaDataGridViewTextBoxColumn,
            this.nombreproveedorDataGridViewTextBoxColumn,
            this.precioproductoDataGridViewTextBoxColumn,
            this.expr3DataGridViewTextBoxColumn});
            this.dgv_producto_v.DataSource = this.viewproductoBindingSource1;
            this.dgv_producto_v.Location = new System.Drawing.Point(193, 86);
            this.dgv_producto_v.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_producto_v.Name = "dgv_producto_v";
            this.dgv_producto_v.ReadOnly = true;
            this.dgv_producto_v.RowHeadersVisible = false;
            this.dgv_producto_v.RowHeadersWidth = 123;
            this.dgv_producto_v.RowTemplate.Height = 46;
            this.dgv_producto_v.Size = new System.Drawing.Size(867, 489);
            this.dgv_producto_v.TabIndex = 32;
            this.dgv_producto_v.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_producto_v_CellContentClick);
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Código";
            this.expr1DataGridViewTextBoxColumn.MinimumWidth = 15;
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Width = 80;
            // 
            // expr2DataGridViewTextBoxColumn
            // 
            this.expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2";
            this.expr2DataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.expr2DataGridViewTextBoxColumn.MinimumWidth = 15;
            this.expr2DataGridViewTextBoxColumn.Name = "expr2DataGridViewTextBoxColumn";
            this.expr2DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr2DataGridViewTextBoxColumn.Width = 300;
            // 
            // expr5DataGridViewTextBoxColumn
            // 
            this.expr5DataGridViewTextBoxColumn.DataPropertyName = "Expr5";
            this.expr5DataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.expr5DataGridViewTextBoxColumn.MinimumWidth = 15;
            this.expr5DataGridViewTextBoxColumn.Name = "expr5DataGridViewTextBoxColumn";
            this.expr5DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr5DataGridViewTextBoxColumn.Width = 200;
            // 
            // expr4DataGridViewTextBoxColumn
            // 
            this.expr4DataGridViewTextBoxColumn.DataPropertyName = "Expr4";
            this.expr4DataGridViewTextBoxColumn.HeaderText = "Codigo Prov";
            this.expr4DataGridViewTextBoxColumn.MinimumWidth = 15;
            this.expr4DataGridViewTextBoxColumn.Name = "expr4DataGridViewTextBoxColumn";
            this.expr4DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr4DataGridViewTextBoxColumn.Visible = false;
            this.expr4DataGridViewTextBoxColumn.Width = 300;
            // 
            // expr6DataGridViewTextBoxColumn
            // 
            this.expr6DataGridViewTextBoxColumn.DataPropertyName = "Expr6";
            this.expr6DataGridViewTextBoxColumn.HeaderText = "Codigo Categ";
            this.expr6DataGridViewTextBoxColumn.MinimumWidth = 15;
            this.expr6DataGridViewTextBoxColumn.Name = "expr6DataGridViewTextBoxColumn";
            this.expr6DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr6DataGridViewTextBoxColumn.Visible = false;
            this.expr6DataGridViewTextBoxColumn.Width = 300;
            // 
            // descripcioncategoriaDataGridViewTextBoxColumn
            // 
            this.descripcioncategoriaDataGridViewTextBoxColumn.DataPropertyName = "descripcion_categoria";
            this.descripcioncategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.descripcioncategoriaDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.descripcioncategoriaDataGridViewTextBoxColumn.Name = "descripcioncategoriaDataGridViewTextBoxColumn";
            this.descripcioncategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcioncategoriaDataGridViewTextBoxColumn.Width = 200;
            // 
            // nombreproveedorDataGridViewTextBoxColumn
            // 
            this.nombreproveedorDataGridViewTextBoxColumn.DataPropertyName = "nombre_proveedor";
            this.nombreproveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.nombreproveedorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nombreproveedorDataGridViewTextBoxColumn.Name = "nombreproveedorDataGridViewTextBoxColumn";
            this.nombreproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreproveedorDataGridViewTextBoxColumn.Width = 200;
            // 
            // precioproductoDataGridViewTextBoxColumn
            // 
            this.precioproductoDataGridViewTextBoxColumn.DataPropertyName = "precio_producto";
            this.precioproductoDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.precioproductoDataGridViewTextBoxColumn.Name = "precioproductoDataGridViewTextBoxColumn";
            this.precioproductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // expr3DataGridViewTextBoxColumn
            // 
            this.expr3DataGridViewTextBoxColumn.DataPropertyName = "Expr3";
            this.expr3DataGridViewTextBoxColumn.HeaderText = "Existencia";
            this.expr3DataGridViewTextBoxColumn.MinimumWidth = 15;
            this.expr3DataGridViewTextBoxColumn.Name = "expr3DataGridViewTextBoxColumn";
            this.expr3DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr3DataGridViewTextBoxColumn.Width = 125;
            // 
            // viewproductoBindingSource1
            // 
            this.viewproductoBindingSource1.DataMember = "view_producto";
            this.viewproductoBindingSource1.DataSource = this.dROGUERIADataSet21;
            // 
            // dROGUERIADataSet21
            // 
            this.dROGUERIADataSet21.DataSetName = "DROGUERIADataSet21";
            this.dROGUERIADataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewproductoBindingSource
            // 
            this.viewproductoBindingSource.DataMember = "view_producto";
            this.viewproductoBindingSource.DataSource = this.producto_vendedor;
            // 
            // producto_vendedor
            // 
            this.producto_vendedor.DataSetName = "producto_vendedor";
            this.producto_vendedor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dROGUERIADataSet;
            // 
            // dROGUERIADataSet
            // 
            this.dROGUERIADataSet.DataSetName = "DROGUERIADataSet";
            this.dROGUERIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(180, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 43);
            this.panel2.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(407, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Producto";
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // view_productoTableAdapter
            // 
            this.view_productoTableAdapter.ClearBeforeFill = true;
            // 
            // view_productoTableAdapter1
            // 
            this.view_productoTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.BackgroundImage = global::Drogueria_proyecto.Properties.Resources.Fondo2;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 689);
            this.panel1.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Drogueria_proyecto.Properties.Resources.pastillas;
            this.pictureBox1.Location = new System.Drawing.Point(49, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.SlateGray;
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(32, 454);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(109, 46);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "MedExpress";
            // 
            // fr_Productos_vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.BackgroundImage = global::Drogueria_proyecto.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(1073, 690);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_producto_v);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "fr_Productos_vendedor";
            this.Text = "Productos_Vd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fr_Productos_vendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_producto_v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewproductoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewproductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto_vendedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_producto_v;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private DROGUERIADataSet dROGUERIADataSet;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DROGUERIADataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private producto_vendedor producto_vendedor;
        private System.Windows.Forms.BindingSource viewproductoBindingSource;
        private producto_vendedorTableAdapters.view_productoTableAdapter view_productoTableAdapter;
        private DROGUERIADataSet21 dROGUERIADataSet21;
        private System.Windows.Forms.BindingSource viewproductoBindingSource1;
        private DROGUERIADataSet21TableAdapters.view_productoTableAdapter view_productoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcioncategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr3DataGridViewTextBoxColumn;
    }
}