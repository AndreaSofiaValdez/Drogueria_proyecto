
namespace Drogueria_proyecto
{
    partial class Fr_Empleado_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_Empleado_Admin));
            this.dtg_administrador_empleado = new System.Windows.Forms.DataGridView();
            this.codigoempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigotipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet2 = new Drogueria_proyecto.DROGUERIADataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idEmpleado_gr = new System.Windows.Forms.TextBox();
            this.txt_usuaempl_gr = new System.Windows.Forms.TextBox();
            this.txt_nomempl_gr = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txt_tipoempl_gr = new System.Windows.Forms.TextBox();
            this.txt_pas_ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.errorP_usu_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_nombemp_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_pas_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_tipempl_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_correoempl_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txt_correoempl_gr = new System.Windows.Forms.TextBox();
            this.empleadoTableAdapter = new Drogueria_proyecto.DROGUERIADataSet2TableAdapters.EmpleadoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_administrador_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_usu_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombemp_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_pas_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_tipempl_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_correoempl_ad)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_administrador_empleado
            // 
            this.dtg_administrador_empleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_administrador_empleado.AutoGenerateColumns = false;
            this.dtg_administrador_empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_administrador_empleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoempleadoDataGridViewTextBoxColumn,
            this.nombreempleadoDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.codigotipoDataGridViewTextBoxColumn,
            this.correo});
            this.dtg_administrador_empleado.DataSource = this.empleadoBindingSource;
            this.dtg_administrador_empleado.Location = new System.Drawing.Point(223, 309);
            this.dtg_administrador_empleado.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_administrador_empleado.Name = "dtg_administrador_empleado";
            this.dtg_administrador_empleado.RowHeadersVisible = false;
            this.dtg_administrador_empleado.RowHeadersWidth = 51;
            this.dtg_administrador_empleado.Size = new System.Drawing.Size(807, 367);
            this.dtg_administrador_empleado.TabIndex = 1;
            this.dtg_administrador_empleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_administrador_empleado_CellContentClick);
            this.dtg_administrador_empleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gerente_clientes_CellDoubleClick);
            // 
            // codigoempleadoDataGridViewTextBoxColumn
            // 
            this.codigoempleadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigoempleadoDataGridViewTextBoxColumn.DataPropertyName = "codigo_empleado";
            this.codigoempleadoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoempleadoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.codigoempleadoDataGridViewTextBoxColumn.Name = "codigoempleadoDataGridViewTextBoxColumn";
            this.codigoempleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoempleadoDataGridViewTextBoxColumn.Width = 80;
            // 
            // nombreempleadoDataGridViewTextBoxColumn
            // 
            this.nombreempleadoDataGridViewTextBoxColumn.DataPropertyName = "nombre_empleado";
            this.nombreempleadoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreempleadoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nombreempleadoDataGridViewTextBoxColumn.Name = "nombreempleadoDataGridViewTextBoxColumn";
            this.nombreempleadoDataGridViewTextBoxColumn.Width = 300;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 200;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 200;
            // 
            // codigotipoDataGridViewTextBoxColumn
            // 
            this.codigotipoDataGridViewTextBoxColumn.DataPropertyName = "codigo_tipo";
            this.codigotipoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.codigotipoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.codigotipoDataGridViewTextBoxColumn.Name = "codigotipoDataGridViewTextBoxColumn";
            this.codigotipoDataGridViewTextBoxColumn.Width = 200;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "correo";
            this.correo.MinimumWidth = 6;
            this.correo.Name = "correo";
            this.correo.Width = 125;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.dROGUERIADataSet2;
            // 
            // dROGUERIADataSet2
            // 
            this.dROGUERIADataSet2.DataSetName = "DROGUERIADataSet2";
            this.dROGUERIADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(253, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(249, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(603, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo Empleado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(603, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre:";
            // 
            // txt_idEmpleado_gr
            // 
            this.txt_idEmpleado_gr.Enabled = false;
            this.txt_idEmpleado_gr.Location = new System.Drawing.Point(319, 55);
            this.txt_idEmpleado_gr.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idEmpleado_gr.Name = "txt_idEmpleado_gr";
            this.txt_idEmpleado_gr.Size = new System.Drawing.Size(132, 22);
            this.txt_idEmpleado_gr.TabIndex = 6;
            // 
            // txt_usuaempl_gr
            // 
            this.txt_usuaempl_gr.Location = new System.Drawing.Point(319, 105);
            this.txt_usuaempl_gr.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usuaempl_gr.MaxLength = 60;
            this.txt_usuaempl_gr.Name = "txt_usuaempl_gr";
            this.txt_usuaempl_gr.Size = new System.Drawing.Size(132, 22);
            this.txt_usuaempl_gr.TabIndex = 7;
            this.txt_usuaempl_gr.TextChanged += new System.EventHandler(this.txt_usuaempl_gr_TextChanged);
            // 
            // txt_nomempl_gr
            // 
            this.txt_nomempl_gr.Location = new System.Drawing.Point(727, 81);
            this.txt_nomempl_gr.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nomempl_gr.MaxLength = 60;
            this.txt_nomempl_gr.Name = "txt_nomempl_gr";
            this.txt_nomempl_gr.Size = new System.Drawing.Size(132, 22);
            this.txt_nomempl_gr.TabIndex = 8;
            this.txt_nomempl_gr.TextChanged += new System.EventHandler(this.txt_nomempl_gr_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SlateGray;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(328, 231);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 37);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SlateGray;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(489, 231);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 37);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modifcar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SlateGray;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(656, 231);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 37);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txt_tipoempl_gr
            // 
            this.txt_tipoempl_gr.Location = new System.Drawing.Point(727, 170);
            this.txt_tipoempl_gr.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tipoempl_gr.MaxLength = 1;
            this.txt_tipoempl_gr.Name = "txt_tipoempl_gr";
            this.txt_tipoempl_gr.Size = new System.Drawing.Size(132, 22);
            this.txt_tipoempl_gr.TabIndex = 9;
            this.txt_tipoempl_gr.TextChanged += new System.EventHandler(this.txt_tipoempl_gr_TextChanged);
            // 
            // txt_pas_ad
            // 
            this.txt_pas_ad.Location = new System.Drawing.Point(727, 123);
            this.txt_pas_ad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pas_ad.MaxLength = 60;
            this.txt_pas_ad.Name = "txt_pas_ad";
            this.txt_pas_ad.Size = new System.Drawing.Size(132, 22);
            this.txt_pas_ad.TabIndex = 13;
            this.txt_pas_ad.TextChanged += new System.EventHandler(this.txt_pas_ad_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(603, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(197, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 42);
            this.panel2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(287, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Empleados";
            // 
            // errorP_usu_ad
            // 
            this.errorP_usu_ad.ContainerControl = this;
            // 
            // errorP_nombemp_ad
            // 
            this.errorP_nombemp_ad.ContainerControl = this;
            // 
            // errorP_pas_ad
            // 
            this.errorP_pas_ad.ContainerControl = this;
            // 
            // errorP_tipempl_ad
            // 
            this.errorP_tipempl_ad.ContainerControl = this;
            // 
            // errorP_correoempl_ad
            // 
            this.errorP_correoempl_ad.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(249, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Correo:";
            // 
            // txt_correoempl_gr
            // 
            this.txt_correoempl_gr.Location = new System.Drawing.Point(319, 170);
            this.txt_correoempl_gr.Margin = new System.Windows.Forms.Padding(4);
            this.txt_correoempl_gr.Name = "txt_correoempl_gr";
            this.txt_correoempl_gr.Size = new System.Drawing.Size(235, 22);
            this.txt_correoempl_gr.TabIndex = 17;
            this.txt_correoempl_gr.TextChanged += new System.EventHandler(this.txt_correoempl_gr_TextChanged);
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
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
            this.panel1.Size = new System.Drawing.Size(197, 690);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Drogueria_proyecto.Properties.Resources.pildora1;
            this.pictureBox1.Location = new System.Drawing.Point(45, 70);
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
            this.btnRegresar.Location = new System.Drawing.Point(39, 441);
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
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "MedExpress";
            // 
            // Fr_Empleado_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.txt_correoempl_gr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_pas_ad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txt_tipoempl_gr);
            this.Controls.Add(this.txt_nomempl_gr);
            this.Controls.Add(this.txt_usuaempl_gr);
            this.Controls.Add(this.txt_idEmpleado_gr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtg_administrador_empleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "Fr_Empleado_Admin";
            this.Text = "Empleados_Ad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fr_Empleado_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_administrador_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_usu_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombemp_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_pas_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_tipempl_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_correoempl_ad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView dtg_administrador_empleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_idEmpleado_gr;
        private System.Windows.Forms.TextBox txt_usuaempl_gr;
        private System.Windows.Forms.TextBox txt_nomempl_gr;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txt_tipoempl_gr;
        private System.Windows.Forms.TextBox txt_pas_ad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private DROGUERIADataSet2 dROGUERIADataSet2;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private DROGUERIADataSet2TableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.ErrorProvider errorP_usu_ad;
        private System.Windows.Forms.ErrorProvider errorP_nombemp_ad;
        private System.Windows.Forms.ErrorProvider errorP_pas_ad;
        private System.Windows.Forms.ErrorProvider errorP_tipempl_ad;
        private System.Windows.Forms.ErrorProvider errorP_correoempl_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigotipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_correoempl_gr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
    }
}