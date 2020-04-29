namespace UniLab
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogInBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UserNameTxtB = new System.Windows.Forms.TextBox();
            this.PasswordTxtB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LogInBtn
            // 
            this.LogInBtn.Location = new System.Drawing.Point(312, 185);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(239, 23);
            this.LogInBtn.TabIndex = 0;
            this.LogInBtn.Text = "Iniciar sesion";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Registrarse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserNameTxtB
            // 
            this.UserNameTxtB.Location = new System.Drawing.Point(312, 121);
            this.UserNameTxtB.Name = "UserNameTxtB";
            this.UserNameTxtB.Size = new System.Drawing.Size(239, 20);
            this.UserNameTxtB.TabIndex = 2;
            // 
            // PasswordTxtB
            // 
            this.PasswordTxtB.Location = new System.Drawing.Point(312, 147);
            this.PasswordTxtB.Name = "PasswordTxtB";
            this.PasswordTxtB.Size = new System.Drawing.Size(239, 20);
            this.PasswordTxtB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::UniLab.Properties.Resources.Publicación1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(899, 416);
            this.Controls.Add(this.PasswordTxtB);
            this.Controls.Add(this.UserNameTxtB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LogInBtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox UserNameTxtB;
        private System.Windows.Forms.TextBox PasswordTxtB;
    }
}

