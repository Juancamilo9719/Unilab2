namespace UniLab
{
    partial class menu
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
            this.PrestamoDeEquiposBtn = new System.Windows.Forms.Button();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.EvaluacionDeEquiposBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrestamoDeEquiposBtn
            // 
            this.PrestamoDeEquiposBtn.Location = new System.Drawing.Point(323, 114);
            this.PrestamoDeEquiposBtn.Name = "PrestamoDeEquiposBtn";
            this.PrestamoDeEquiposBtn.Size = new System.Drawing.Size(206, 23);
            this.PrestamoDeEquiposBtn.TabIndex = 3;
            this.PrestamoDeEquiposBtn.Text = "Prestamo de equipos";
            this.PrestamoDeEquiposBtn.UseVisualStyleBackColor = true;
            // 
            // LogInBtn
            // 
            this.LogInBtn.Location = new System.Drawing.Point(55, 114);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(186, 23);
            this.LogInBtn.TabIndex = 2;
            this.LogInBtn.Text = "Practicas libres de laboratorio";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // EvaluacionDeEquiposBtn
            // 
            this.EvaluacionDeEquiposBtn.Location = new System.Drawing.Point(592, 114);
            this.EvaluacionDeEquiposBtn.Name = "EvaluacionDeEquiposBtn";
            this.EvaluacionDeEquiposBtn.Size = new System.Drawing.Size(150, 23);
            this.EvaluacionDeEquiposBtn.TabIndex = 4;
            this.EvaluacionDeEquiposBtn.Text = "Evaluacion de equipos";
            this.EvaluacionDeEquiposBtn.UseVisualStyleBackColor = true;
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(323, 227);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(186, 23);
            this.SalirBtn.TabIndex = 5;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UniLab.Properties.Resources.Publicación1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.EvaluacionDeEquiposBtn);
            this.Controls.Add(this.PrestamoDeEquiposBtn);
            this.Controls.Add(this.LogInBtn);
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrestamoDeEquiposBtn;

        
        


        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Button EvaluacionDeEquiposBtn;
        private System.Windows.Forms.Button SalirBtn;
    }
}