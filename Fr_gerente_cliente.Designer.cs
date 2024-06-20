
namespace Drogueria_proyecto
{
    partial class Fr_gerente_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_gerente_cliente));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_gerente_clientes = new System.Windows.Forms.DataGridView();
            this.codigoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet5 = new Drogueria_proyecto.DROGUERIADataSet5();
            this.txt_nombclien_gr = new System.Windows.Forms.TextBox();
            this.txt_gr_correoclien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_gr_telclien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_gr_dirclien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_gr_agreclien = new System.Windows.Forms.Button();
            this.btn_gr_eliclien = new System.Windows.Forms.Button();
            this.btn_gr_modclien = new System.Windows.Forms.Button();
            this.txt_idcliente_gr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clienteTableAdapter = new Drogueria_proyecto.DROGUERIADataSet5TableAdapters.ClienteTableAdapter();
            this.errorP_dirc_cl_g = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_tel_cl_g = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_nombcl_gr = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPro_correocli_g = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_grcli_regresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gerente_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_dirc_cl_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_tel_cl_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombcl_gr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro_correocli_g)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(163, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 38);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(284, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(197, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // dgv_gerente_clientes
            // 
            this.dgv_gerente_clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_gerente_clientes.AutoGenerateColumns = false;
            this.dgv_gerente_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_gerente_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gerente_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoclienteDataGridViewTextBoxColumn,
            this.nombreclienteDataGridViewTextBoxColumn,
            this.direccionclienteDataGridViewTextBoxColumn,
            this.correoclienteDataGridViewTextBoxColumn,
            this.telefonoclienteDataGridViewTextBoxColumn});
            this.dgv_gerente_clientes.DataSource = this.clienteBindingSource;
            this.dgv_gerente_clientes.Location = new System.Drawing.Point(200, 245);
            this.dgv_gerente_clientes.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_gerente_clientes.Name = "dgv_gerente_clientes";
            this.dgv_gerente_clientes.ReadOnly = true;
            this.dgv_gerente_clientes.RowHeadersVisible = false;
            this.dgv_gerente_clientes.RowHeadersWidth = 123;
            this.dgv_gerente_clientes.RowTemplate.Height = 46;
            this.dgv_gerente_clientes.Size = new System.Drawing.Size(832, 433);
            this.dgv_gerente_clientes.TabIndex = 3;
            this.dgv_gerente_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gerente_clientes_CellContentClick);
            this.dgv_gerente_clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gerente_clientes_CellDoubleClick);
            // 
            // codigoclienteDataGridViewTextBoxColumn
            // 
            this.codigoclienteDataGridViewTextBoxColumn.DataPropertyName = "codigo_cliente";
            this.codigoclienteDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoclienteDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.codigoclienteDataGridViewTextBoxColumn.Name = "codigoclienteDataGridViewTextBoxColumn";
            this.codigoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreclienteDataGridViewTextBoxColumn
            // 
            this.nombreclienteDataGridViewTextBoxColumn.DataPropertyName = "nombre_cliente";
            this.nombreclienteDataGridViewTextBoxColumn.FillWeight = 300F;
            this.nombreclienteDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreclienteDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nombreclienteDataGridViewTextBoxColumn.Name = "nombreclienteDataGridViewTextBoxColumn";
            this.nombreclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionclienteDataGridViewTextBoxColumn
            // 
            this.direccionclienteDataGridViewTextBoxColumn.DataPropertyName = "direccion_cliente";
            this.direccionclienteDataGridViewTextBoxColumn.FillWeight = 200F;
            this.direccionclienteDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionclienteDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.direccionclienteDataGridViewTextBoxColumn.Name = "direccionclienteDataGridViewTextBoxColumn";
            this.direccionclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoclienteDataGridViewTextBoxColumn
            // 
            this.correoclienteDataGridViewTextBoxColumn.DataPropertyName = "correo_cliente";
            this.correoclienteDataGridViewTextBoxColumn.FillWeight = 200F;
            this.correoclienteDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoclienteDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.correoclienteDataGridViewTextBoxColumn.Name = "correoclienteDataGridViewTextBoxColumn";
            this.correoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoclienteDataGridViewTextBoxColumn
            // 
            this.telefonoclienteDataGridViewTextBoxColumn.DataPropertyName = "telefono_cliente";
            this.telefonoclienteDataGridViewTextBoxColumn.FillWeight = 200F;
            this.telefonoclienteDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoclienteDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.telefonoclienteDataGridViewTextBoxColumn.Name = "telefonoclienteDataGridViewTextBoxColumn";
            this.telefonoclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dROGUERIADataSet5;
            // 
            // dROGUERIADataSet5
            // 
            this.dROGUERIADataSet5.DataSetName = "DROGUERIADataSet5";
            this.dROGUERIADataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_nombclien_gr
            // 
            this.txt_nombclien_gr.Location = new System.Drawing.Point(275, 101);
            this.txt_nombclien_gr.Margin = new System.Windows.Forms.Padding(1);
            this.txt_nombclien_gr.MaxLength = 80;
            this.txt_nombclien_gr.Name = "txt_nombclien_gr";
            this.txt_nombclien_gr.Size = new System.Drawing.Size(111, 22);
            this.txt_nombclien_gr.TabIndex = 4;
            this.txt_nombclien_gr.TextChanged += new System.EventHandler(this.txt_nombclien_gr_TextChanged);
            // 
            // txt_gr_correoclien
            // 
            this.txt_gr_correoclien.Location = new System.Drawing.Point(275, 142);
            this.txt_gr_correoclien.Margin = new System.Windows.Forms.Padding(1);
            this.txt_gr_correoclien.MaxLength = 60;
            this.txt_gr_correoclien.Name = "txt_gr_correoclien";
            this.txt_gr_correoclien.Size = new System.Drawing.Size(111, 22);
            this.txt_gr_correoclien.TabIndex = 6;
            this.txt_gr_correoclien.TextChanged += new System.EventHandler(this.txt_gr_correoclien_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(197, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo:";
            // 
            // txt_gr_telclien
            // 
            this.txt_gr_telclien.Location = new System.Drawing.Point(568, 126);
            this.txt_gr_telclien.Margin = new System.Windows.Forms.Padding(1);
            this.txt_gr_telclien.MaxLength = 8;
            this.txt_gr_telclien.Name = "txt_gr_telclien";
            this.txt_gr_telclien.Size = new System.Drawing.Size(111, 22);
            this.txt_gr_telclien.TabIndex = 10;
            this.txt_gr_telclien.TextChanged += new System.EventHandler(this.txt_gr_telclien_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(491, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teléfono:";
            // 
            // txt_gr_dirclien
            // 
            this.txt_gr_dirclien.Location = new System.Drawing.Point(568, 85);
            this.txt_gr_dirclien.Margin = new System.Windows.Forms.Padding(1);
            this.txt_gr_dirclien.MaxLength = 60;
            this.txt_gr_dirclien.Name = "txt_gr_dirclien";
            this.txt_gr_dirclien.Size = new System.Drawing.Size(111, 22);
            this.txt_gr_dirclien.TabIndex = 8;
            this.txt_gr_dirclien.TextChanged += new System.EventHandler(this.txt_gr_dirclien_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(491, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Dirección:";
            // 
            // btn_gr_agreclien
            // 
            this.btn_gr_agreclien.BackColor = System.Drawing.Color.SlateGray;
            this.btn_gr_agreclien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gr_agreclien.ForeColor = System.Drawing.Color.White;
            this.btn_gr_agreclien.Location = new System.Drawing.Point(289, 182);
            this.btn_gr_agreclien.Margin = new System.Windows.Forms.Padding(1);
            this.btn_gr_agreclien.Name = "btn_gr_agreclien";
            this.btn_gr_agreclien.Size = new System.Drawing.Size(97, 32);
            this.btn_gr_agreclien.TabIndex = 7;
            this.btn_gr_agreclien.Text = "Agregar";
            this.btn_gr_agreclien.UseVisualStyleBackColor = false;
            this.btn_gr_agreclien.Click += new System.EventHandler(this.btn_gr_agreclien_Click_1);
            // 
            // btn_gr_eliclien
            // 
            this.btn_gr_eliclien.BackColor = System.Drawing.Color.SlateGray;
            this.btn_gr_eliclien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gr_eliclien.ForeColor = System.Drawing.Color.White;
            this.btn_gr_eliclien.Location = new System.Drawing.Point(547, 182);
            this.btn_gr_eliclien.Margin = new System.Windows.Forms.Padding(1);
            this.btn_gr_eliclien.Name = "btn_gr_eliclien";
            this.btn_gr_eliclien.Size = new System.Drawing.Size(97, 32);
            this.btn_gr_eliclien.TabIndex = 12;
            this.btn_gr_eliclien.Text = "Eliminar";
            this.btn_gr_eliclien.UseVisualStyleBackColor = false;
            this.btn_gr_eliclien.Click += new System.EventHandler(this.btn_gr_eliclien_Click);
            // 
            // btn_gr_modclien
            // 
            this.btn_gr_modclien.BackColor = System.Drawing.Color.SlateGray;
            this.btn_gr_modclien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gr_modclien.ForeColor = System.Drawing.Color.White;
            this.btn_gr_modclien.Location = new System.Drawing.Point(421, 182);
            this.btn_gr_modclien.Margin = new System.Windows.Forms.Padding(1);
            this.btn_gr_modclien.Name = "btn_gr_modclien";
            this.btn_gr_modclien.Size = new System.Drawing.Size(97, 32);
            this.btn_gr_modclien.TabIndex = 13;
            this.btn_gr_modclien.Text = "Modificar";
            this.btn_gr_modclien.UseVisualStyleBackColor = false;
            this.btn_gr_modclien.Click += new System.EventHandler(this.btn_gr_modclien_Click);
            // 
            // txt_idcliente_gr
            // 
            this.txt_idcliente_gr.Enabled = false;
            this.txt_idcliente_gr.Location = new System.Drawing.Point(275, 65);
            this.txt_idcliente_gr.Margin = new System.Windows.Forms.Padding(1);
            this.txt_idcliente_gr.Name = "txt_idcliente_gr";
            this.txt_idcliente_gr.Size = new System.Drawing.Size(111, 22);
            this.txt_idcliente_gr.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(197, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Código:";
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // errorP_dirc_cl_g
            // 
            this.errorP_dirc_cl_g.ContainerControl = this;
            // 
            // errorP_tel_cl_g
            // 
            this.errorP_tel_cl_g.ContainerControl = this;
            // 
            // errorP_nombcl_gr
            // 
            this.errorP_nombcl_gr.ContainerControl = this;
            // 
            // errorPro_correocli_g
            // 
            this.errorPro_correocli_g.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.BackgroundImage = global::Drogueria_proyecto.Properties.Resources.Fondo2;
            this.panel1.Controls.Add(this.button_grcli_regresar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 692);
            this.panel1.TabIndex = 0;
            // 
            // button_grcli_regresar
            // 
            this.button_grcli_regresar.BackColor = System.Drawing.Color.SlateGray;
            this.button_grcli_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_grcli_regresar.ForeColor = System.Drawing.Color.White;
            this.button_grcli_regresar.Location = new System.Drawing.Point(23, 473);
            this.button_grcli_regresar.Margin = new System.Windows.Forms.Padding(1);
            this.button_grcli_regresar.Name = "button_grcli_regresar";
            this.button_grcli_regresar.Size = new System.Drawing.Size(107, 44);
            this.button_grcli_regresar.TabIndex = 6;
            this.button_grcli_regresar.Text = "Regresar";
            this.button_grcli_regresar.UseVisualStyleBackColor = false;
            this.button_grcli_regresar.Click += new System.EventHandler(this.button_grcli_regresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Drogueria_proyecto.Properties.Resources.pastillas;
            this.pictureBox1.Location = new System.Drawing.Point(41, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 73);
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
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "MedExpress";
            // 
            // Fr_gerente_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.BackgroundImage = global::Drogueria_proyecto.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.txt_idcliente_gr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_gr_modclien);
            this.Controls.Add(this.btn_gr_eliclien);
            this.Controls.Add(this.btn_gr_agreclien);
            this.Controls.Add(this.txt_gr_telclien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_gr_dirclien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_gr_correoclien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nombclien_gr);
            this.Controls.Add(this.dgv_gerente_clientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "Fr_gerente_cliente";
            this.Text = "Clientes_G";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fr_gerente_cliente_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gerente_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_dirc_cl_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_tel_cl_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombcl_gr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro_correocli_g)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_grcli_regresar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_gerente_clientes;
        private System.Windows.Forms.TextBox txt_nombclien_gr;
        private System.Windows.Forms.TextBox txt_gr_correoclien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_gr_telclien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_gr_dirclien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_gr_agreclien;
        private System.Windows.Forms.Button btn_gr_eliclien;
        private System.Windows.Forms.Button btn_gr_modclien;
        private System.Windows.Forms.TextBox txt_idcliente_gr;
        private System.Windows.Forms.Label label7;
        private DROGUERIADataSet5 dROGUERIADataSet5;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DROGUERIADataSet5TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorP_dirc_cl_g;
        private System.Windows.Forms.ErrorProvider errorP_tel_cl_g;
        private System.Windows.Forms.ErrorProvider errorP_nombcl_gr;
        private System.Windows.Forms.ErrorProvider errorPro_correocli_g;
    }
}