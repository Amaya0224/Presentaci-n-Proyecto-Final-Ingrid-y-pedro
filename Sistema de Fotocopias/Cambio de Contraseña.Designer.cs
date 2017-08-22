namespace Sistema_de_Fotocopias
{
    partial class Cambio_de_Contraseña
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcontraseñavieja = new System.Windows.Forms.TextBox();
            this.txtcontraseñanueva = new System.Windows.Forms.TextBox();
            this.txtrepetircontraseña = new System.Windows.Forms.TextBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Repetir Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nueva Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Contraseña Actual:";
            // 
            // txtcontraseñavieja
            // 
            this.txtcontraseñavieja.Location = new System.Drawing.Point(203, 79);
            this.txtcontraseñavieja.Name = "txtcontraseñavieja";
            this.txtcontraseñavieja.PasswordChar = '*';
            this.txtcontraseñavieja.Size = new System.Drawing.Size(171, 20);
            this.txtcontraseñavieja.TabIndex = 28;
            // 
            // txtcontraseñanueva
            // 
            this.txtcontraseñanueva.Location = new System.Drawing.Point(203, 117);
            this.txtcontraseñanueva.Name = "txtcontraseñanueva";
            this.txtcontraseñanueva.PasswordChar = '*';
            this.txtcontraseñanueva.Size = new System.Drawing.Size(171, 20);
            this.txtcontraseñanueva.TabIndex = 29;
            // 
            // txtrepetircontraseña
            // 
            this.txtrepetircontraseña.Location = new System.Drawing.Point(203, 155);
            this.txtrepetircontraseña.Name = "txtrepetircontraseña";
            this.txtrepetircontraseña.PasswordChar = '*';
            this.txtrepetircontraseña.Size = new System.Drawing.Size(171, 20);
            this.txtrepetircontraseña.TabIndex = 30;
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.LightBlue;
            this.btnactualizar.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Location = new System.Drawing.Point(166, 201);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(110, 33);
            this.btnactualizar.TabIndex = 35;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Cambiar Contraseña Generica";
            // 
            // Cambio_de_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(454, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.txtrepetircontraseña);
            this.Controls.Add(this.txtcontraseñanueva);
            this.Controls.Add(this.txtcontraseñavieja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cambio_de_Contraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio_de_Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcontraseñavieja;
        private System.Windows.Forms.TextBox txtcontraseñanueva;
        private System.Windows.Forms.TextBox txtrepetircontraseña;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label label1;
    }
}