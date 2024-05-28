
namespace Drogueria_proyecto
{
    partial class buscarproveedorad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarproveedorad));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dROGUERIADataSet8 = new Drogueria_proyecto.DROGUERIADataSet8();
            this.proveedorTableAdapter = new Drogueria_proyecto.DROGUERIADataSet8TableAdapters.ProveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoproveedorDataGridViewTextBoxColumn,
            this.nombreproveedorDataGridViewTextBoxColumn,
            this.direccionproveedorDataGridViewTextBoxColumn,
            this.correoproveedorDataGridViewTextBoxColumn,
            this.telefonoproveedorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proveedorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.Size = new System.Drawing.Size(765, 533);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // codigoproveedorDataGridViewTextBoxColumn
            // 
            this.codigoproveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigoproveedorDataGridViewTextBoxColumn.DataPropertyName = "codigo_proveedor";
            this.codigoproveedorDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoproveedorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.codigoproveedorDataGridViewTextBoxColumn.Name = "codigoproveedorDataGridViewTextBoxColumn";
            this.codigoproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoproveedorDataGridViewTextBoxColumn.Width = 65;
            // 
            // nombreproveedorDataGridViewTextBoxColumn
            // 
            this.nombreproveedorDataGridViewTextBoxColumn.DataPropertyName = "nombre_proveedor";
            this.nombreproveedorDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreproveedorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nombreproveedorDataGridViewTextBoxColumn.Name = "nombreproveedorDataGridViewTextBoxColumn";
            this.nombreproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreproveedorDataGridViewTextBoxColumn.Width = 200;
            // 
            // direccionproveedorDataGridViewTextBoxColumn
            // 
            this.direccionproveedorDataGridViewTextBoxColumn.DataPropertyName = "direccion_proveedor";
            this.direccionproveedorDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionproveedorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.direccionproveedorDataGridViewTextBoxColumn.Name = "direccionproveedorDataGridViewTextBoxColumn";
            this.direccionproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionproveedorDataGridViewTextBoxColumn.Width = 200;
            // 
            // correoproveedorDataGridViewTextBoxColumn
            // 
            this.correoproveedorDataGridViewTextBoxColumn.DataPropertyName = "correo_proveedor";
            this.correoproveedorDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoproveedorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.correoproveedorDataGridViewTextBoxColumn.Name = "correoproveedorDataGridViewTextBoxColumn";
            this.correoproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.correoproveedorDataGridViewTextBoxColumn.Width = 200;
            // 
            // telefonoproveedorDataGridViewTextBoxColumn
            // 
            this.telefonoproveedorDataGridViewTextBoxColumn.DataPropertyName = "telefono_proveedor";
            this.telefonoproveedorDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoproveedorDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.telefonoproveedorDataGridViewTextBoxColumn.Name = "telefonoproveedorDataGridViewTextBoxColumn";
            this.telefonoproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoproveedorDataGridViewTextBoxColumn.Width = 200;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.dROGUERIADataSet8;
            // 
            // dROGUERIADataSet8
            // 
            this.dROGUERIADataSet8.DataSetName = "DROGUERIADataSet8";
            this.dROGUERIADataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // buscarproveedorad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "buscarproveedorad";
            this.Text = "buscarproveedorAd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.buscarproveedorad_Load);
            this.DoubleClick += new System.EventHandler(this.buscarproveedorad_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dROGUERIADataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DROGUERIADataSet8 dROGUERIADataSet8;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DROGUERIADataSet8TableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoproveedorDataGridViewTextBoxColumn;
    }
}