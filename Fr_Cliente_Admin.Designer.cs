
namespace Drogueria_proyecto
{
    partial class Fr_Cliente_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_Cliente_Admin));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dtg_administrador_empleado = new System.Windows.Forms.DataGridView();
            this.codigoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet1 = new Drogueria_proyecto.DROGUERIADataSet1();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txt_idcliente_gr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_gr_telclien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_gr_dirclien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_gr_correoclien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombclien_gr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dROGUERIADataSet = new Drogueria_proyecto.DROGUERIADataSet();
            this.dROGUERIADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Drogueria_proyecto.DROGUERIADataSet1TableAdapters.ClienteTableAdapter();
            this.errorP_nombrecl_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_nombcli_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_dircl_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_telcl_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPro_correoCli_ad = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_administrador_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombrecl_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombcli_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_dircl_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_telcl_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro_correoCli_ad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.SlateGray;
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(27, 344);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(82, 37);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dtg_administrador_empleado
            // 
            this.dtg_administrador_empleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_administrador_empleado.AutoGenerateColumns = false;
            this.dtg_administrador_empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_administrador_empleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoclienteDataGridViewTextBoxColumn,
            this.nombreclienteDataGridViewTextBoxColumn,
            this.direccionclienteDataGridViewTextBoxColumn,
            this.correoclienteDataGridViewTextBoxColumn,
            this.telefonoclienteDataGridViewTextBoxColumn});
            this.dtg_administrador_empleado.DataSource = this.clienteBindingSource;
            this.dtg_administrador_empleado.Location = new System.Drawing.Point(159, 228);
            this.dtg_administrador_empleado.Name = "dtg_administrador_empleado";
            this.dtg_administrador_empleado.RowHeadersVisible = false;
            this.dtg_administrador_empleado.RowHeadersWidth = 51;
            this.dtg_administrador_empleado.Size = new System.Drawing.Size(602, 321);
            this.dtg_administrador_empleado.TabIndex = 3;
            this.dtg_administrador_empleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gerente_clientes_CellDoubleClick);
            // 
            // codigoclienteDataGridViewTextBoxColumn
            // 
            this.codigoclienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigoclienteDataGridViewTextBoxColumn.DataPropertyName = "codigo_cliente";
            this.codigoclienteDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoclienteDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.codigoclienteDataGridViewTextBoxColumn.Name = "codigoclienteDataGridViewTextBoxColumn";
            this.codigoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoclienteDataGridViewTextBoxColumn.Width = 65;
            // 
            // nombreclienteDataGridViewTextBoxColumn
            // 
            this.nombreclienteDataGridViewTextBoxColumn.DataPropertyName = "nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreclienteDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nombreclienteDataGridViewTextBoxColumn.Name = "nombreclienteDataGridViewTextBoxColumn";
            this.nombreclienteDataGridViewTextBoxColumn.Width = 300;
            // 
            // direccionclienteDataGridViewTextBoxColumn
            // 
            this.direccionclienteDataGridViewTextBoxColumn.DataPropertyName = "direccion_cliente";
            this.direccionclienteDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionclienteDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.direccionclienteDataGridViewTextBoxColumn.Name = "direccionclienteDataGridViewTextBoxColumn";
            this.direccionclienteDataGridViewTextBoxColumn.Width = 200;
            // 
            // correoclienteDataGridViewTextBoxColumn
            // 
            this.correoclienteDataGridViewTextBoxColumn.DataPropertyName = "correo_cliente";
            this.correoclienteDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoclienteDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.correoclienteDataGridViewTextBoxColumn.Name = "correoclienteDataGridViewTextBoxColumn";
            this.correoclienteDataGridViewTextBoxColumn.Width = 200;
            // 
            // telefonoclienteDataGridViewTextBoxColumn
            // 
            this.telefonoclienteDataGridViewTextBoxColumn.DataPropertyName = "telefono_cliente";
            this.telefonoclienteDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoclienteDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.telefonoclienteDataGridViewTextBoxColumn.Name = "telefonoclienteDataGridViewTextBoxColumn";
            this.telefonoclienteDataGridViewTextBoxColumn.Width = 300;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dROGUERIADataSet1;
            // 
            // dROGUERIADataSet1
            // 
            this.dROGUERIADataSet1.DataSetName = "DROGUERIADataSet1";
            this.dROGUERIADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SlateGray;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(514, 175);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 30);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SlateGray;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(390, 175);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 30);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modifcar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SlateGray;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(268, 175);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 30);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txt_idcliente_gr
            // 
            this.txt_idcliente_gr.Enabled = false;
            this.txt_idcliente_gr.Location = new System.Drawing.Point(277, 46);
            this.txt_idcliente_gr.Margin = new System.Windows.Forms.Padding(1);
            this.txt_idcliente_gr.Name = "txt_idcliente_gr";
            this.txt_idcliente_gr.Size = new System.Drawing.Size(84, 20);
            this.txt_idcliente_gr.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(212, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Código:";
            // 
            // txt_gr_telclien
            // 
            this.txt_gr_telclien.Location = new System.Drawing.Point(515, 104);
            this.txt_gr_telclien.Margin = new System.Windows.Forms.Padding(1);
            this.txt_gr_telclien.MaxLength = 8;
            this.txt_gr_telclien.Name = "txt_gr_telclien";
            this.txt_gr_telclien.Size = new System.Drawing.Size(84, 20);
            this.txt_gr_telclien.TabIndex = 25;
            this.txt_gr_telclien.TextChanged += new System.EventHandler(this.txt_gr_telclien_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(447, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Teléfono:";
            // 
            // txt_gr_dirclien
            // 
            this.txt_gr_dirclien.Location = new System.Drawing.Point(515, 51);
            this.txt_gr_dirclien.Margin = new System.Windows.Forms.Padding(1);
            this.txt_gr_dirclien.MaxLength = 60;
            this.txt_gr_dirclien.Name = "txt_gr_dirclien";
            this.txt_gr_dirclien.Size = new System.Drawing.Size(84, 20);
            this.txt_gr_dirclien.TabIndex = 23;
            this.txt_gr_dirclien.TextChanged += new System.EventHandler(this.txt_gr_dirclien_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(447, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Dirección:";
            // 
            // txt_gr_correoclien
            // 
            this.txt_gr_correoclien.Location = new System.Drawing.Point(277, 132);
            this.txt_gr_correoclien.Margin = new System.Windows.Forms.Padding(1);
            this.txt_gr_correoclien.MaxLength = 60;
            this.txt_gr_correoclien.Name = "txt_gr_correoclien";
            this.txt_gr_correoclien.Size = new System.Drawing.Size(84, 20);
            this.txt_gr_correoclien.TabIndex = 21;
            this.txt_gr_correoclien.TextChanged += new System.EventHandler(this.txt_gr_correoclien_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(212, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Correo:";
            // 
            // txt_nombclien_gr
            // 
            this.txt_nombclien_gr.Location = new System.Drawing.Point(277, 86);
            this.txt_nombclien_gr.Margin = new System.Windows.Forms.Padding(1);
            this.txt_nombclien_gr.MaxLength = 80;
            this.txt_nombclien_gr.Name = "txt_nombclien_gr";
            this.txt_nombclien_gr.Size = new System.Drawing.Size(84, 20);
            this.txt_nombclien_gr.TabIndex = 19;
            this.txt_nombclien_gr.TextChanged += new System.EventHandler(this.txt_nombclien_gr_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(212, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 561);
            this.panel1.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Drogueria_proyecto.Properties.Resources.pastillas;
            this.pictureBox1.Location = new System.Drawing.Point(41, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "MedExpress";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(141, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 31);
            this.panel2.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(233, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clientes";
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
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // errorP_nombrecl_ad
            // 
            this.errorP_nombrecl_ad.ContainerControl = this;
            // 
            // errorP_nombcli_ad
            // 
            this.errorP_nombcli_ad.ContainerControl = this;
            // 
            // errorP_dircl_ad
            // 
            this.errorP_dircl_ad.ContainerControl = this;
            // 
            // errorP_telcl_ad
            // 
            this.errorP_telcl_ad.ContainerControl = this;
            // 
            // errorPro_correoCli_ad
            // 
            this.errorPro_correoCli_ad.ContainerControl = this;
            // 
            // Fr_Cliente_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_idcliente_gr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_gr_telclien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_gr_dirclien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_gr_correoclien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombclien_gr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtg_administrador_empleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Fr_Cliente_Admin";
            this.Text = "Clientes_Ad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fr_Cliente_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_administrador_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombrecl_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombcli_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_dircl_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_telcl_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro_correoCli_ad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dtg_administrador_empleado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txt_idcliente_gr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_gr_telclien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_gr_dirclien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_gr_correoclien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombclien_gr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private DROGUERIADataSet dROGUERIADataSet;
        private System.Windows.Forms.BindingSource dROGUERIADataSetBindingSource;
        private DROGUERIADataSet1 dROGUERIADataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DROGUERIADataSet1TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.ErrorProvider errorP_nombrecl_ad;
        private System.Windows.Forms.ErrorProvider errorP_nombcli_ad;
        private System.Windows.Forms.ErrorProvider errorP_dircl_ad;
        private System.Windows.Forms.ErrorProvider errorP_telcl_ad;
        private System.Windows.Forms.ErrorProvider errorPro_correoCli_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoclienteDataGridViewTextBoxColumn;
    }
}