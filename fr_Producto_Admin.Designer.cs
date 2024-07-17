
namespace Drogueria_proyecto
{
    partial class fr_Producto_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_Producto_Admin));
            this.txt_codinv_ad = new System.Windows.Forms.TextBox();
            this.txt_exisinv_ad = new System.Windows.Forms.TextBox();
            this.txt_desinv_ad = new System.Windows.Forms.TextBox();
            this.txt_provinv_ad = new System.Windows.Forms.TextBox();
            this.txt_Nom_ad = new System.Windows.Forms.TextBox();
            this.txt_catinv_ad = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarad = new System.Windows.Forms.Button();
            this.dgv_prod_ad = new System.Windows.Forms.DataGridView();
            this.codigoproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet20 = new Drogueria_proyecto.DROGUERIADataSet20();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet4 = new Drogueria_proyecto.DROGUERIADataSet4();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dROGUERIADataSet = new Drogueria_proyecto.DROGUERIADataSet();
            this.dROGUERIADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Drogueria_proyecto.DROGUERIADataSet4TableAdapters.ProductoTableAdapter();
            this.errorP_nombpro_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_despro_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_catpro_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_existpro_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.productoTableAdapter1 = new Drogueria_proyecto.DROGUERIADataSet20TableAdapters.ProductoTableAdapter();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombpro_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_despro_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_catpro_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_existpro_ad)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_codinv_ad
            // 
            this.txt_codinv_ad.Enabled = false;
            this.txt_codinv_ad.Location = new System.Drawing.Point(100, 26);
            this.txt_codinv_ad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_codinv_ad.Name = "txt_codinv_ad";
            this.txt_codinv_ad.Size = new System.Drawing.Size(76, 20);
            this.txt_codinv_ad.TabIndex = 15;
            this.txt_codinv_ad.TextChanged += new System.EventHandler(this.txt_codinv_ad_TextChanged);
            // 
            // txt_exisinv_ad
            // 
            this.txt_exisinv_ad.Location = new System.Drawing.Point(313, 87);
            this.txt_exisinv_ad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_exisinv_ad.Name = "txt_exisinv_ad";
            this.txt_exisinv_ad.Size = new System.Drawing.Size(91, 20);
            this.txt_exisinv_ad.TabIndex = 16;
            this.txt_exisinv_ad.TextChanged += new System.EventHandler(this.txt_exisinv_ad_TextChanged);
            // 
            // txt_desinv_ad
            // 
            this.txt_desinv_ad.Location = new System.Drawing.Point(100, 87);
            this.txt_desinv_ad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_desinv_ad.MaxLength = 60;
            this.txt_desinv_ad.Name = "txt_desinv_ad";
            this.txt_desinv_ad.Size = new System.Drawing.Size(118, 20);
            this.txt_desinv_ad.TabIndex = 17;
            this.txt_desinv_ad.TextChanged += new System.EventHandler(this.txt_desinv_ad_TextChanged);
            // 
            // txt_provinv_ad
            // 
            this.txt_provinv_ad.Enabled = false;
            this.txt_provinv_ad.Location = new System.Drawing.Point(313, 23);
            this.txt_provinv_ad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_provinv_ad.Name = "txt_provinv_ad";
            this.txt_provinv_ad.Size = new System.Drawing.Size(147, 20);
            this.txt_provinv_ad.TabIndex = 18;
            // 
            // txt_Nom_ad
            // 
            this.txt_Nom_ad.Location = new System.Drawing.Point(100, 58);
            this.txt_Nom_ad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nom_ad.MaxLength = 80;
            this.txt_Nom_ad.Name = "txt_Nom_ad";
            this.txt_Nom_ad.Size = new System.Drawing.Size(118, 20);
            this.txt_Nom_ad.TabIndex = 19;
            this.txt_Nom_ad.TextChanged += new System.EventHandler(this.txt_Nom_ad_TextChanged);
            // 
            // txt_catinv_ad
            // 
            this.txt_catinv_ad.Location = new System.Drawing.Point(313, 55);
            this.txt_catinv_ad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_catinv_ad.MaxLength = 1;
            this.txt_catinv_ad.Name = "txt_catinv_ad";
            this.txt_catinv_ad.Size = new System.Drawing.Size(91, 20);
            this.txt_catinv_ad.TabIndex = 20;
            this.txt_catinv_ad.TextChanged += new System.EventHandler(this.txt_catinv_ad_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(27, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Descripción:";
            // 
            // btnBuscarad
            // 
            this.btnBuscarad.BackColor = System.Drawing.Color.SlateGray;
            this.btnBuscarad.ForeColor = System.Drawing.Color.White;
            this.btnBuscarad.Location = new System.Drawing.Point(444, 10);
            this.btnBuscarad.Name = "btnBuscarad";
            this.btnBuscarad.Size = new System.Drawing.Size(91, 45);
            this.btnBuscarad.TabIndex = 28;
            this.btnBuscarad.Text = "Buscar";
            this.btnBuscarad.UseVisualStyleBackColor = false;
            this.btnBuscarad.Click += new System.EventHandler(this.btnBuscarad_Click);
            // 
            // dgv_prod_ad
            // 
            this.dgv_prod_ad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_prod_ad.AutoGenerateColumns = false;
            this.dgv_prod_ad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prod_ad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoproductoDataGridViewTextBoxColumn,
            this.nombreproductoDataGridViewTextBoxColumn,
            this.descripcionproductoDataGridViewTextBoxColumn,
            this.categoriaproductoDataGridViewTextBoxColumn,
            this.proveedorproductoDataGridViewTextBoxColumn,
            this.existenciaproductoDataGridViewTextBoxColumn,
            this.precioproductoDataGridViewTextBoxColumn});
            this.dgv_prod_ad.DataSource = this.productoBindingSource1;
            this.dgv_prod_ad.Location = new System.Drawing.Point(147, 275);
            this.dgv_prod_ad.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_prod_ad.Name = "dgv_prod_ad";
            this.dgv_prod_ad.RowHeadersVisible = false;
            this.dgv_prod_ad.RowHeadersWidth = 123;
            this.dgv_prod_ad.RowTemplate.Height = 46;
            this.dgv_prod_ad.Size = new System.Drawing.Size(1034, 248);
            this.dgv_prod_ad.TabIndex = 29;
            this.dgv_prod_ad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_prod_ad_CellContentClick);
            this.dgv_prod_ad.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_administrador_producto_CellDoubleClick);
            // 
            // codigoproductoDataGridViewTextBoxColumn
            // 
            this.codigoproductoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigoproductoDataGridViewTextBoxColumn.DataPropertyName = "codigo_producto";
            this.codigoproductoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.codigoproductoDataGridViewTextBoxColumn.Name = "codigoproductoDataGridViewTextBoxColumn";
            this.codigoproductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoproductoDataGridViewTextBoxColumn.Width = 65;
            // 
            // nombreproductoDataGridViewTextBoxColumn
            // 
            this.nombreproductoDataGridViewTextBoxColumn.DataPropertyName = "nombre_producto";
            this.nombreproductoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nombreproductoDataGridViewTextBoxColumn.Name = "nombreproductoDataGridViewTextBoxColumn";
            this.nombreproductoDataGridViewTextBoxColumn.Width = 300;
            // 
            // descripcionproductoDataGridViewTextBoxColumn
            // 
            this.descripcionproductoDataGridViewTextBoxColumn.DataPropertyName = "descripcion_producto";
            this.descripcionproductoDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.descripcionproductoDataGridViewTextBoxColumn.Name = "descripcionproductoDataGridViewTextBoxColumn";
            this.descripcionproductoDataGridViewTextBoxColumn.Width = 300;
            // 
            // categoriaproductoDataGridViewTextBoxColumn
            // 
            this.categoriaproductoDataGridViewTextBoxColumn.DataPropertyName = "categoria_producto";
            this.categoriaproductoDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.categoriaproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.categoriaproductoDataGridViewTextBoxColumn.Name = "categoriaproductoDataGridViewTextBoxColumn";
            this.categoriaproductoDataGridViewTextBoxColumn.Width = 300;
            // 
            // proveedorproductoDataGridViewTextBoxColumn
            // 
            this.proveedorproductoDataGridViewTextBoxColumn.DataPropertyName = "proveedor_producto";
            this.proveedorproductoDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.proveedorproductoDataGridViewTextBoxColumn.Name = "proveedorproductoDataGridViewTextBoxColumn";
            this.proveedorproductoDataGridViewTextBoxColumn.Width = 300;
            // 
            // existenciaproductoDataGridViewTextBoxColumn
            // 
            this.existenciaproductoDataGridViewTextBoxColumn.DataPropertyName = "existencia_producto";
            this.existenciaproductoDataGridViewTextBoxColumn.HeaderText = "Existencia";
            this.existenciaproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.existenciaproductoDataGridViewTextBoxColumn.Name = "existenciaproductoDataGridViewTextBoxColumn";
            this.existenciaproductoDataGridViewTextBoxColumn.Width = 300;
            // 
            // precioproductoDataGridViewTextBoxColumn
            // 
            this.precioproductoDataGridViewTextBoxColumn.DataPropertyName = "precio_producto";
            this.precioproductoDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioproductoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.precioproductoDataGridViewTextBoxColumn.Name = "precioproductoDataGridViewTextBoxColumn";
            this.precioproductoDataGridViewTextBoxColumn.Width = 300;
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataMember = "Producto";
            this.productoBindingSource1.DataSource = this.dROGUERIADataSet20;
            // 
            // dROGUERIADataSet20
            // 
            this.dROGUERIADataSet20.DataSetName = "DROGUERIADataSet20";
            this.dROGUERIADataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dROGUERIADataSet4;
            // 
            // dROGUERIADataSet4
            // 
            this.dROGUERIADataSet4.DataSetName = "DROGUERIADataSet4";
            this.dROGUERIADataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(134, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 35);
            this.panel2.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(309, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Producto";
            // 
            // dROGUERIADataSet
            // 
            this.dROGUERIADataSet.DataSetName = "DROGUERIADataSet";
            this.dROGUERIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dROGUERIADataSetBindingSource
            // 
            this.dROGUERIADataSetBindingSource.DataSource = this.dROGUERIADataSet;
            this.dROGUERIADataSetBindingSource.Position = 0;
            // 
            // dROGUERIADataSetBindingSource1
            // 
            this.dROGUERIADataSetBindingSource1.DataSource = this.dROGUERIADataSet;
            this.dROGUERIADataSetBindingSource1.Position = 0;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // errorP_nombpro_ad
            // 
            this.errorP_nombpro_ad.ContainerControl = this;
            // 
            // errorP_despro_ad
            // 
            this.errorP_despro_ad.ContainerControl = this;
            // 
            // errorP_catpro_ad
            // 
            this.errorP_catpro_ad.ContainerControl = this;
            // 
            // errorP_existpro_ad
            // 
            this.errorP_existpro_ad.ContainerControl = this;
            // 
            // productoTableAdapter1
            // 
            this.productoTableAdapter1.ClearBeforeFill = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SlateGray;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(313, 10);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 45);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SlateGray;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(186, 10);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(91, 45);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modifcar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SlateGray;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(55, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 45);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.btnAgregar);
            this.panel4.Controls.Add(this.btnModificar);
            this.panel4.Controls.Add(this.btnEliminar);
            this.panel4.Controls.Add(this.btnBuscarad);
            this.panel4.Location = new System.Drawing.Point(166, 193);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(980, 67);
            this.panel4.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(33, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Código:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(27, 91);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Descripción:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(230, 57);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 18);
            this.label13.TabIndex = 25;
            this.label13.Text = "Categoría:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(230, 22);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 18);
            this.label14.TabIndex = 26;
            this.label14.Text = "Proveedor:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(230, 87);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 18);
            this.label15.TabIndex = 27;
            this.label15.Text = "Existencia:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Location = new System.Drawing.Point(441, 57);
            this.label16.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 18);
            this.label16.TabIndex = 32;
            this.label16.Text = "Precio:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(498, 57);
            this.textBox8.Margin = new System.Windows.Forms.Padding(1);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(116, 20);
            this.textBox8.TabIndex = 33;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txt_codinv_ad);
            this.panel5.Controls.Add(this.textBox8);
            this.panel5.Controls.Add(this.txt_exisinv_ad);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.txt_desinv_ad);
            this.panel5.Controls.Add(this.txt_provinv_ad);
            this.panel5.Controls.Add(this.txt_Nom_ad);
            this.panel5.Controls.Add(this.txt_catinv_ad);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(166, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(980, 138);
            this.panel5.TabIndex = 36;
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
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 577);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Drogueria_proyecto.Properties.Resources.pildora1;
            this.pictureBox1.Location = new System.Drawing.Point(25, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.SlateGray;
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(12, 351);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(111, 50);
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
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "MedExpress";
            // 
            // fr_Producto_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1191, 574);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_prod_ad);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 599);
            this.Name = "fr_Producto_Admin";
            this.Text = "Producto_Ad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fr_Producto_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombpro_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_despro_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_catpro_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_existpro_ad)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txt_codinv_ad;
        private System.Windows.Forms.TextBox txt_exisinv_ad;
        private System.Windows.Forms.TextBox txt_desinv_ad;
        private System.Windows.Forms.TextBox txt_Nom_ad;
        private System.Windows.Forms.TextBox txt_catinv_ad;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarad;
        private System.Windows.Forms.DataGridView dgv_prod_ad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_provinv_ad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource dROGUERIADataSetBindingSource1;
        private DROGUERIADataSet dROGUERIADataSet;
        private System.Windows.Forms.BindingSource dROGUERIADataSetBindingSource;
        private DROGUERIADataSet4 dROGUERIADataSet4;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DROGUERIADataSet4TableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.ErrorProvider errorP_nombpro_ad;
        private System.Windows.Forms.ErrorProvider errorP_despro_ad;
        private System.Windows.Forms.ErrorProvider errorP_catpro_ad;
        private System.Windows.Forms.ErrorProvider errorP_existpro_ad;
        private DROGUERIADataSet20 dROGUERIADataSet20;
        private System.Windows.Forms.BindingSource productoBindingSource1;
        private DROGUERIADataSet20TableAdapters.ProductoTableAdapter productoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}