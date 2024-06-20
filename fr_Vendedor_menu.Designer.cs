
namespace Drogueria_proyecto
{
    partial class fr_Vendedor_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_Vendedor_menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProductos_v = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_salir_v = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHora_v = new System.Windows.Forms.Label();
            this.lblFecha_v = new System.Windows.Forms.Label();
            this.timerV = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panel1.BackgroundImage = global::Drogueria_proyecto.Properties.Resources.fondo1;
            this.panel1.Controls.Add(this.btnProductos_v);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_salir_v);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 690);
            this.panel1.TabIndex = 12;
            // 
            // btnProductos_v
            // 
            this.btnProductos_v.BackColor = System.Drawing.Color.SlateGray;
            this.btnProductos_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos_v.ForeColor = System.Drawing.Color.White;
            this.btnProductos_v.Location = new System.Drawing.Point(27, 279);
            this.btnProductos_v.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductos_v.Name = "btnProductos_v";
            this.btnProductos_v.Size = new System.Drawing.Size(140, 47);
            this.btnProductos_v.TabIndex = 11;
            this.btnProductos_v.Text = "Productos";
            this.btnProductos_v.UseVisualStyleBackColor = false;
            this.btnProductos_v.Click += new System.EventHandler(this.btnProductos_v_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Drogueria_proyecto.Properties.Resources.pastillas;
            this.pictureBox1.Location = new System.Drawing.Point(56, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_salir_v
            // 
            this.btn_salir_v.BackColor = System.Drawing.Color.SlateGray;
            this.btn_salir_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir_v.ForeColor = System.Drawing.Color.White;
            this.btn_salir_v.Location = new System.Drawing.Point(27, 374);
            this.btn_salir_v.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir_v.Name = "btn_salir_v";
            this.btn_salir_v.Size = new System.Drawing.Size(140, 47);
            this.btn_salir_v.TabIndex = 10;
            this.btn_salir_v.Text = "Salir";
            this.btn_salir_v.UseVisualStyleBackColor = false;
            this.btn_salir_v.Click += new System.EventHandler(this.btn_salir_v_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "MedExpress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(205, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "BIENVENIDO VENDEDOR";
            // 
            // lblHora_v
            // 
            this.lblHora_v.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora_v.AutoSize = true;
            this.lblHora_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora_v.ForeColor = System.Drawing.Color.White;
            this.lblHora_v.Location = new System.Drawing.Point(381, 217);
            this.lblHora_v.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHora_v.Name = "lblHora_v";
            this.lblHora_v.Size = new System.Drawing.Size(249, 91);
            this.lblHora_v.TabIndex = 14;
            this.lblHora_v.Text = "label3";
            // 
            // lblFecha_v
            // 
            this.lblFecha_v.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha_v.AutoSize = true;
            this.lblFecha_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_v.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFecha_v.Location = new System.Drawing.Point(311, 375);
            this.lblFecha_v.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFecha_v.Name = "lblFecha_v";
            this.lblFecha_v.Size = new System.Drawing.Size(138, 52);
            this.lblFecha_v.TabIndex = 15;
            this.lblFecha_v.Text = "label4";
            // 
            // timerV
            // 
            this.timerV.Enabled = true;
            this.timerV.Tick += new System.EventHandler(this.timerV_Tick);
            // 
            // fr_Vendedor_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.BackgroundImage = global::Drogueria_proyecto.Properties.Resources.Fondo2;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.lblFecha_v);
            this.Controls.Add(this.lblHora_v);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "fr_Vendedor_menu";
            this.Text = "Menú Vendedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fr_Vendedor_menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_salir_v;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProductos_v;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHora_v;
        private System.Windows.Forms.Label lblFecha_v;
        private System.Windows.Forms.Timer timerV;
    }
}