
namespace Drogueria_proyecto.SecurityPassword
{
    partial class CambiarPassword
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
            this.btnCambiarPass = new System.Windows.Forms.Button();
            this.txbNPass = new System.Windows.Forms.TextBox();
            this.txbActual = new System.Windows.Forms.TextBox();
            this.lbActual = new System.Windows.Forms.Label();
            this.lbNPass = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbConfirmarPass = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCambiarPass
            // 
            this.btnCambiarPass.BackColor = System.Drawing.Color.SlateGray;
            this.btnCambiarPass.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCambiarPass.Location = new System.Drawing.Point(53, 466);
            this.btnCambiarPass.Name = "btnCambiarPass";
            this.btnCambiarPass.Size = new System.Drawing.Size(96, 42);
            this.btnCambiarPass.TabIndex = 0;
            this.btnCambiarPass.Text = "Cambiar";
            this.btnCambiarPass.UseVisualStyleBackColor = false;
            this.btnCambiarPass.Click += new System.EventHandler(this.btnCambiarPass_Click);
            // 
            // txbNPass
            // 
            this.txbNPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNPass.Location = new System.Drawing.Point(52, 304);
            this.txbNPass.Name = "txbNPass";
            this.txbNPass.Size = new System.Drawing.Size(225, 26);
            this.txbNPass.TabIndex = 1;
            // 
            // txbActual
            // 
            this.txbActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbActual.Location = new System.Drawing.Point(50, 193);
            this.txbActual.Name = "txbActual";
            this.txbActual.Size = new System.Drawing.Size(227, 26);
            this.txbActual.TabIndex = 2;
            // 
            // lbActual
            // 
            this.lbActual.AutoSize = true;
            this.lbActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbActual.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbActual.Location = new System.Drawing.Point(47, 149);
            this.lbActual.Name = "lbActual";
            this.lbActual.Size = new System.Drawing.Size(207, 29);
            this.lbActual.TabIndex = 3;
            this.lbActual.Text = "Contraseña Actual";
            // 
            // lbNPass
            // 
            this.lbNPass.AutoSize = true;
            this.lbNPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNPass.Location = new System.Drawing.Point(47, 249);
            this.lbNPass.Name = "lbNPass";
            this.lbNPass.Size = new System.Drawing.Size(211, 29);
            this.lbNPass.TabIndex = 4;
            this.lbNPass.Text = "Nueva Contraseña";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbUsuario.Location = new System.Drawing.Point(47, 52);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(96, 29);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Text = "Usuario";
            // 
            // txbUsuario
            // 
            this.txbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUsuario.Location = new System.Drawing.Point(50, 98);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(227, 26);
            this.txbUsuario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(47, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nueva Contraseña";
            // 
            // txbConfirmarPass
            // 
            this.txbConfirmarPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbConfirmarPass.Location = new System.Drawing.Point(52, 405);
            this.txbConfirmarPass.Name = "txbConfirmarPass";
            this.txbConfirmarPass.Size = new System.Drawing.Size(225, 26);
            this.txbConfirmarPass.TabIndex = 7;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCerrar.Location = new System.Drawing.Point(407, 33);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(49, 39);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // CambiarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(46)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(478, 544);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbConfirmarPass);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.lbNPass);
            this.Controls.Add(this.lbActual);
            this.Controls.Add(this.txbActual);
            this.Controls.Add(this.txbNPass);
            this.Controls.Add(this.btnCambiarPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambiarPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarPassword";
            this.Load += new System.EventHandler(this.CambiarPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCambiarPass;
        private System.Windows.Forms.TextBox txbNPass;
        private System.Windows.Forms.TextBox txbActual;
        private System.Windows.Forms.Label lbActual;
        private System.Windows.Forms.Label lbNPass;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbConfirmarPass;
        private System.Windows.Forms.Button btnCerrar;
    }
}