﻿
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dtg_administrador_empleado = new System.Windows.Forms.DataGridView();
            this.codigoempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreempleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigotipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.empleadoTableAdapter = new Drogueria_proyecto.DROGUERIADataSet2TableAdapters.EmpleadoTableAdapter();
            this.errorP_usu_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_nombemp_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_pas_ad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP_tipempl_ad = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_administrador_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_usu_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombemp_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_pas_ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_tipempl_ad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.SlateGray;
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(29, 358);
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
            this.codigoempleadoDataGridViewTextBoxColumn,
            this.nombreempleadoDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.codigotipoDataGridViewTextBoxColumn});
            this.dtg_administrador_empleado.DataSource = this.empleadoBindingSource;
            this.dtg_administrador_empleado.Location = new System.Drawing.Point(167, 251);
            this.dtg_administrador_empleado.Name = "dtg_administrador_empleado";
            this.dtg_administrador_empleado.RowHeadersVisible = false;
            this.dtg_administrador_empleado.RowHeadersWidth = 51;
            this.dtg_administrador_empleado.Size = new System.Drawing.Size(605, 298);
            this.dtg_administrador_empleado.TabIndex = 1;
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
            this.codigoempleadoDataGridViewTextBoxColumn.Width = 65;
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
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(190, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(190, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(452, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo Empleado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(452, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre:";
            // 
            // txt_idEmpleado_gr
            // 
            this.txt_idEmpleado_gr.Enabled = false;
            this.txt_idEmpleado_gr.Location = new System.Drawing.Point(242, 69);
            this.txt_idEmpleado_gr.Name = "txt_idEmpleado_gr";
            this.txt_idEmpleado_gr.Size = new System.Drawing.Size(100, 20);
            this.txt_idEmpleado_gr.TabIndex = 6;
            // 
            // txt_usuaempl_gr
            // 
            this.txt_usuaempl_gr.Location = new System.Drawing.Point(242, 129);
            this.txt_usuaempl_gr.MaxLength = 60;
            this.txt_usuaempl_gr.Name = "txt_usuaempl_gr";
            this.txt_usuaempl_gr.Size = new System.Drawing.Size(100, 20);
            this.txt_usuaempl_gr.TabIndex = 7;
            this.txt_usuaempl_gr.TextChanged += new System.EventHandler(this.txt_usuaempl_gr_TextChanged);
            // 
            // txt_nomempl_gr
            // 
            this.txt_nomempl_gr.Location = new System.Drawing.Point(545, 66);
            this.txt_nomempl_gr.MaxLength = 60;
            this.txt_nomempl_gr.Name = "txt_nomempl_gr";
            this.txt_nomempl_gr.Size = new System.Drawing.Size(100, 20);
            this.txt_nomempl_gr.TabIndex = 8;
            this.txt_nomempl_gr.TextChanged += new System.EventHandler(this.txt_nomempl_gr_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.SlateGray;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(246, 188);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 30);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SlateGray;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(367, 188);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 30);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modifcar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SlateGray;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(492, 188);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 30);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txt_tipoempl_gr
            // 
            this.txt_tipoempl_gr.Location = new System.Drawing.Point(545, 138);
            this.txt_tipoempl_gr.MaxLength = 1;
            this.txt_tipoempl_gr.Name = "txt_tipoempl_gr";
            this.txt_tipoempl_gr.Size = new System.Drawing.Size(100, 20);
            this.txt_tipoempl_gr.TabIndex = 9;
            this.txt_tipoempl_gr.TextChanged += new System.EventHandler(this.txt_tipoempl_gr_TextChanged);
            // 
            // txt_pas_ad
            // 
            this.txt_pas_ad.Location = new System.Drawing.Point(545, 100);
            this.txt_pas_ad.MaxLength = 60;
            this.txt_pas_ad.Name = "txt_pas_ad";
            this.txt_pas_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_pas_ad.TabIndex = 13;
            this.txt_pas_ad.TextChanged += new System.EventHandler(this.txt_pas_ad_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(452, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 561);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Drogueria_proyecto.Properties.Resources.WhatsApp_Image_2022_02_13_at_3_10_47_PM;
            this.pictureBox1.Location = new System.Drawing.Point(34, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 60);
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
            this.label1.Location = new System.Drawing.Point(19, 20);
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
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(148, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 34);
            this.panel2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(215, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Empleados";
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
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
            // Fr_Empleado_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Fr_Empleado_Admin";
            this.Text = "Empleados_Ad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fr_Empleado_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_administrador_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_usu_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_nombemp_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_pas_ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_tipempl_ad)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreempleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigotipoDataGridViewTextBoxColumn;
    }
}