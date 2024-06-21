
namespace Drogueria_proyecto
{
    partial class fr_menu_gerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_menu_gerente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_menug_salir = new System.Windows.Forms.Button();
            this.button_menug_prov = new System.Windows.Forms.Button();
            this.button_menug_inv = new System.Windows.Forms.Button();
            this.button_menug_cli = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelhorag = new System.Windows.Forms.Label();
            this.labelfechag = new System.Windows.Forms.Label();
            this.timerg = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_menug_salir);
            this.panel1.Controls.Add(this.button_menug_prov);
            this.panel1.Controls.Add(this.button_menug_inv);
            this.panel1.Controls.Add(this.button_menug_cli);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 692);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(40, 416);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reportes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_menug_salir
            // 
            this.button_menug_salir.BackColor = System.Drawing.Color.SlateGray;
            this.button_menug_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menug_salir.ForeColor = System.Drawing.Color.White;
            this.button_menug_salir.Location = new System.Drawing.Point(40, 602);
            this.button_menug_salir.Margin = new System.Windows.Forms.Padding(1);
            this.button_menug_salir.Name = "button_menug_salir";
            this.button_menug_salir.Size = new System.Drawing.Size(145, 49);
            this.button_menug_salir.TabIndex = 8;
            this.button_menug_salir.Text = "Salir";
            this.button_menug_salir.UseVisualStyleBackColor = false;
            this.button_menug_salir.Click += new System.EventHandler(this.button_menug_salir_Click);
            // 
            // button_menug_prov
            // 
            this.button_menug_prov.BackColor = System.Drawing.Color.SlateGray;
            this.button_menug_prov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menug_prov.ForeColor = System.Drawing.Color.White;
            this.button_menug_prov.Location = new System.Drawing.Point(40, 346);
            this.button_menug_prov.Margin = new System.Windows.Forms.Padding(1);
            this.button_menug_prov.Name = "button_menug_prov";
            this.button_menug_prov.Size = new System.Drawing.Size(145, 49);
            this.button_menug_prov.TabIndex = 7;
            this.button_menug_prov.Text = "Proveedores";
            this.button_menug_prov.UseVisualStyleBackColor = false;
            this.button_menug_prov.Click += new System.EventHandler(this.button_menug_prov_Click);
            // 
            // button_menug_inv
            // 
            this.button_menug_inv.BackColor = System.Drawing.Color.SlateGray;
            this.button_menug_inv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menug_inv.ForeColor = System.Drawing.Color.White;
            this.button_menug_inv.Location = new System.Drawing.Point(40, 276);
            this.button_menug_inv.Margin = new System.Windows.Forms.Padding(1);
            this.button_menug_inv.Name = "button_menug_inv";
            this.button_menug_inv.Size = new System.Drawing.Size(145, 49);
            this.button_menug_inv.TabIndex = 6;
            this.button_menug_inv.Text = "Productos";
            this.button_menug_inv.UseVisualStyleBackColor = false;
            this.button_menug_inv.Click += new System.EventHandler(this.button_menug_inv_Click);
            // 
            // button_menug_cli
            // 
            this.button_menug_cli.BackColor = System.Drawing.Color.SlateGray;
            this.button_menug_cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menug_cli.ForeColor = System.Drawing.Color.White;
            this.button_menug_cli.Location = new System.Drawing.Point(40, 207);
            this.button_menug_cli.Margin = new System.Windows.Forms.Padding(1);
            this.button_menug_cli.Name = "button_menug_cli";
            this.button_menug_cli.Size = new System.Drawing.Size(145, 49);
            this.button_menug_cli.TabIndex = 5;
            this.button_menug_cli.Text = "Clientes";
            this.button_menug_cli.UseVisualStyleBackColor = false;
            this.button_menug_cli.Click += new System.EventHandler(this.button_menug_cli_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Drogueria_proyecto.Properties.Resources.pildora1;
            this.pictureBox1.Location = new System.Drawing.Point(67, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "MedExpress";
            // 
            // labelhorag
            // 
            this.labelhorag.AutoSize = true;
            this.labelhorag.BackColor = System.Drawing.Color.Transparent;
            this.labelhorag.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhorag.ForeColor = System.Drawing.Color.White;
            this.labelhorag.Location = new System.Drawing.Point(523, 255);
            this.labelhorag.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelhorag.Name = "labelhorag";
            this.labelhorag.Size = new System.Drawing.Size(249, 91);
            this.labelhorag.TabIndex = 1;
            this.labelhorag.Text = "label1";
            this.labelhorag.Click += new System.EventHandler(this.labelhorag_Click);
            // 
            // labelfechag
            // 
            this.labelfechag.AutoSize = true;
            this.labelfechag.BackColor = System.Drawing.Color.Transparent;
            this.labelfechag.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfechag.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelfechag.Location = new System.Drawing.Point(498, 403);
            this.labelfechag.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelfechag.Name = "labelfechag";
            this.labelfechag.Size = new System.Drawing.Size(138, 52);
            this.labelfechag.TabIndex = 2;
            this.labelfechag.Text = "label1";
            this.labelfechag.Click += new System.EventHandler(this.labelfechag_Click);
            // 
            // timerg
            // 
            this.timerg.Enabled = true;
            this.timerg.Tick += new System.EventHandler(this.timerg_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(268, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "BIENVENIDO GERENTE";
            // 
            // fr_menu_gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelfechag);
            this.Controls.Add(this.labelhorag);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "fr_menu_gerente";
            this.Text = "Menú Gerente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fr_menu_gerente_FormClosed);
            this.Load += new System.EventHandler(this.fr_menu_gerente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelhorag;
        private System.Windows.Forms.Label labelfechag;
        private System.Windows.Forms.Timer timerg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_menug_prov;
        private System.Windows.Forms.Button button_menug_inv;
        private System.Windows.Forms.Button button_menug_cli;
        private System.Windows.Forms.Button button_menug_salir;
        private System.Windows.Forms.Button button1;
    }
}