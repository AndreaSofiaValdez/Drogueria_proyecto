
namespace Drogueria_proyecto
{
    partial class Fr_gerente_proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_gerente_proveedores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_grprov_regresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_gr_telprov = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_gr_corprov = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_gr_nomprov = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_gr_desprov = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_codprov_gr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_gr_modprov = new System.Windows.Forms.Button();
            this.btn_gr_eliprov = new System.Windows.Forms.Button();
            this.btn_gr_agreprov = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet7 = new Drogueria_proyecto.DROGUERIADataSet7();
            this.proveedorTableAdapter = new Drogueria_proyecto.DROGUERIADataSet7TableAdapters.ProveedorTableAdapter();
            this.errorP_nombprov_g = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_direcprov_g = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_telprov_g = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombprov_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_direcprov_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_telprov_g)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.btn_grprov_regresar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 559);
            this.panel1.TabIndex = 2;
            // 
            // btn_grprov_regresar
            // 
            this.btn_grprov_regresar.BackColor = System.Drawing.Color.SlateGray;
            this.btn_grprov_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grprov_regresar.ForeColor = System.Drawing.Color.White;
            this.btn_grprov_regresar.Location = new System.Drawing.Point(16, 374);
            this.btn_grprov_regresar.Margin = new System.Windows.Forms.Padding(1);
            this.btn_grprov_regresar.Name = "btn_grprov_regresar";
            this.btn_grprov_regresar.Size = new System.Drawing.Size(87, 36);
            this.btn_grprov_regresar.TabIndex = 6;
            this.btn_grprov_regresar.Text = "Regresar";
            this.btn_grprov_regresar.UseVisualStyleBackColor = false;
            this.btn_grprov_regresar.Click += new System.EventHandler(this.btn_grprov_regresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Drogueria_proyecto.Properties.Resources.pastillas;
            this.pictureBox1.Location = new System.Drawing.Point(31, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "MedExpress";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(125, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 33);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(195, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Proveedores";
            // 
            // txt_gr_telprov
            // 
            this.txt_gr_telprov.Location = new System.Drawing.Point(218, 125);
            this.txt_gr_telprov.Margin = new System.Windows.Forms.Padding(1);
            this.txt_gr_telprov.MaxLength = 8;
            this.txt_gr_telprov.Name = "txt_gr_telprov";
            this.txt_gr_telprov.Size = new System.Drawing.Size(84, 20);
            this.txt_gr_telprov.TabIndex = 32;
            this.txt_gr_telprov.TextChanged += new System.EventHandler(this.txt_gr_telprov_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(149, 125);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Teléfono:";
            // 
            // txt_gr_corprov
            // 
            this.txt_gr_corprov.Location = new System.Drawing.Point(479, 89);
            this.txt_gr_corprov.Margin = new System.Windows.Forms.Padding(1);
            this.txt_gr_corprov.MaxLength = 60;
            this.txt_gr_corprov.Name = "txt_gr_corprov";
            this.txt_gr_corprov.Size = new System.Drawing.Size(84, 20);
            this.txt_gr_corprov.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(416, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Correo:";
            // 
            // txt_gr_nomprov
            // 
            this.txt_gr_nomprov.Location = new System.Drawing.Point(479, 56);
            this.txt_gr_nomprov.Margin = new System.Windows.Forms.Padding(1);
            this.txt_gr_nomprov.MaxLength = 50;
            this.txt_gr_nomprov.Name = "txt_gr_nomprov";
            this.txt_gr_nomprov.Size = new System.Drawing.Size(84, 20);
            this.txt_gr_nomprov.TabIndex = 28;
            this.txt_gr_nomprov.TextChanged += new System.EventHandler(this.txt_gr_nomprov_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(416, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nombre:";
            // 
            // txt_gr_desprov
            // 
            this.txt_gr_desprov.Location = new System.Drawing.Point(218, 89);
            this.txt_gr_desprov.Margin = new System.Windows.Forms.Padding(1);
            this.txt_gr_desprov.MaxLength = 60;
            this.txt_gr_desprov.Name = "txt_gr_desprov";
            this.txt_gr_desprov.Size = new System.Drawing.Size(84, 20);
            this.txt_gr_desprov.TabIndex = 26;
            this.txt_gr_desprov.TextChanged += new System.EventHandler(this.txt_gr_desprov_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(149, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Dirección:";
            // 
            // txt_codprov_gr
            // 
            this.txt_codprov_gr.Enabled = false;
            this.txt_codprov_gr.Location = new System.Drawing.Point(218, 56);
            this.txt_codprov_gr.Margin = new System.Windows.Forms.Padding(1);
            this.txt_codprov_gr.Name = "txt_codprov_gr";
            this.txt_codprov_gr.Size = new System.Drawing.Size(84, 20);
            this.txt_codprov_gr.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(149, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Código:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(123, 202);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 33;
            // 
            // btn_gr_modprov
            // 
            this.btn_gr_modprov.BackColor = System.Drawing.Color.SlateGray;
            this.btn_gr_modprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gr_modprov.ForeColor = System.Drawing.Color.White;
            this.btn_gr_modprov.Location = new System.Drawing.Point(345, 179);
            this.btn_gr_modprov.Margin = new System.Windows.Forms.Padding(1);
            this.btn_gr_modprov.Name = "btn_gr_modprov";
            this.btn_gr_modprov.Size = new System.Drawing.Size(73, 26);
            this.btn_gr_modprov.TabIndex = 37;
            this.btn_gr_modprov.Text = "Modificar";
            this.btn_gr_modprov.UseVisualStyleBackColor = false;
            this.btn_gr_modprov.Click += new System.EventHandler(this.btn_gr_modprov_Click);
            // 
            // btn_gr_eliprov
            // 
            this.btn_gr_eliprov.BackColor = System.Drawing.Color.SlateGray;
            this.btn_gr_eliprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gr_eliprov.ForeColor = System.Drawing.Color.White;
            this.btn_gr_eliprov.Location = new System.Drawing.Point(439, 179);
            this.btn_gr_eliprov.Margin = new System.Windows.Forms.Padding(1);
            this.btn_gr_eliprov.Name = "btn_gr_eliprov";
            this.btn_gr_eliprov.Size = new System.Drawing.Size(73, 26);
            this.btn_gr_eliprov.TabIndex = 36;
            this.btn_gr_eliprov.Text = "Eliminar";
            this.btn_gr_eliprov.UseVisualStyleBackColor = false;
            this.btn_gr_eliprov.Click += new System.EventHandler(this.btn_gr_eliprov_Click);
            // 
            // btn_gr_agreprov
            // 
            this.btn_gr_agreprov.BackColor = System.Drawing.Color.SlateGray;
            this.btn_gr_agreprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gr_agreprov.ForeColor = System.Drawing.Color.White;
            this.btn_gr_agreprov.Location = new System.Drawing.Point(246, 179);
            this.btn_gr_agreprov.Margin = new System.Windows.Forms.Padding(1);
            this.btn_gr_agreprov.Name = "btn_gr_agreprov";
            this.btn_gr_agreprov.Size = new System.Drawing.Size(73, 26);
            this.btn_gr_agreprov.TabIndex = 34;
            this.btn_gr_agreprov.Text = "Agregar";
            this.btn_gr_agreprov.UseVisualStyleBackColor = false;
            this.btn_gr_agreprov.Click += new System.EventHandler(this.btn_gr_agreprov_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoproveedorDataGridViewTextBoxColumn,
            this.nombreproveedorDataGridViewTextBoxColumn,
            this.direccionproveedorDataGridViewTextBoxColumn,
            this.correoproveedorDataGridViewTextBoxColumn,
            this.telefonoproveedorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proveedorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(132, 230);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.Size = new System.Drawing.Size(642, 321);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ce);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // codigoproveedorDataGridViewTextBoxColumn
            // 
            this.codigoproveedorDataGridViewTextBoxColumn.DataPropertyName = "codigo_proveedor";
            this.codigoproveedorDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoproveedorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.codigoproveedorDataGridViewTextBoxColumn.Name = "codigoproveedorDataGridViewTextBoxColumn";
            this.codigoproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreproveedorDataGridViewTextBoxColumn
            // 
            this.nombreproveedorDataGridViewTextBoxColumn.DataPropertyName = "nombre_proveedor";
            this.nombreproveedorDataGridViewTextBoxColumn.FillWeight = 300F;
            this.nombreproveedorDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreproveedorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nombreproveedorDataGridViewTextBoxColumn.Name = "nombreproveedorDataGridViewTextBoxColumn";
            this.nombreproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionproveedorDataGridViewTextBoxColumn
            // 
            this.direccionproveedorDataGridViewTextBoxColumn.DataPropertyName = "direccion_proveedor";
            this.direccionproveedorDataGridViewTextBoxColumn.FillWeight = 200F;
            this.direccionproveedorDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionproveedorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.direccionproveedorDataGridViewTextBoxColumn.Name = "direccionproveedorDataGridViewTextBoxColumn";
            this.direccionproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoproveedorDataGridViewTextBoxColumn
            // 
            this.correoproveedorDataGridViewTextBoxColumn.DataPropertyName = "correo_proveedor";
            this.correoproveedorDataGridViewTextBoxColumn.FillWeight = 200F;
            this.correoproveedorDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoproveedorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.correoproveedorDataGridViewTextBoxColumn.Name = "correoproveedorDataGridViewTextBoxColumn";
            this.correoproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoproveedorDataGridViewTextBoxColumn
            // 
            this.telefonoproveedorDataGridViewTextBoxColumn.DataPropertyName = "telefono_proveedor";
            this.telefonoproveedorDataGridViewTextBoxColumn.FillWeight = 150F;
            this.telefonoproveedorDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoproveedorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.telefonoproveedorDataGridViewTextBoxColumn.Name = "telefonoproveedorDataGridViewTextBoxColumn";
            this.telefonoproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.dROGUERIADataSet7;
            // 
            // dROGUERIADataSet7
            // 
            this.dROGUERIADataSet7.DataSetName = "DROGUERIADataSet7";
            this.dROGUERIADataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // errorP_nombprov_g
            // 
            this.errorP_nombprov_g.ContainerControl = this;
            // 
            // errorP_direcprov_g
            // 
            this.errorP_direcprov_g.ContainerControl = this;
            // 
            // errorP_telprov_g
            // 
            this.errorP_telprov_g.ContainerControl = this;
            // 
            // Fr_gerente_proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_gr_modprov);
            this.Controls.Add(this.btn_gr_eliprov);
            this.Controls.Add(this.btn_gr_agreprov);
            this.Controls.Add(this.txt_gr_telprov);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_gr_corprov);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_gr_nomprov);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_gr_desprov);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_codprov_gr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Fr_gerente_proveedores";
            this.Text = "Proveedores_G";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fr_gerente_proveedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombprov_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_direcprov_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_telprov_g)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_grprov_regresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_gr_telprov;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_gr_corprov;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_gr_nomprov;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_gr_desprov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_codprov_gr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_gr_modprov;
        private System.Windows.Forms.Button btn_gr_eliprov;
        private System.Windows.Forms.Button btn_gr_agreprov;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DROGUERIADataSet7 dROGUERIADataSet7;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DROGUERIADataSet7TableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorP_nombprov_g;
        private System.Windows.Forms.ErrorProvider errorP_direcprov_g;
        private System.Windows.Forms.ErrorProvider errorP_telprov_g;
    }
}