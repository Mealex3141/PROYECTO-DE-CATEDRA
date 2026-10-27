namespace PROYECTOPOO
{
    partial class lOGIN
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
            this.Imglogo = new System.Windows.Forms.PictureBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontrasenia = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblcontrasenia = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Imglogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Imglogo
            // 
            this.Imglogo.Image = global::PROYECTOPOO.Properties.Resources.Logo_de_gimnasio_sin_límites;
            this.Imglogo.Location = new System.Drawing.Point(12, 12);
            this.Imglogo.Name = "Imglogo";
            this.Imglogo.Size = new System.Drawing.Size(310, 141);
            this.Imglogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imglogo.TabIndex = 0;
            this.Imglogo.TabStop = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(73, 215);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(182, 22);
            this.txtusuario.TabIndex = 1;
            // 
            // txtcontrasenia
            // 
            this.txtcontrasenia.Location = new System.Drawing.Point(73, 276);
            this.txtcontrasenia.Name = "txtcontrasenia";
            this.txtcontrasenia.Size = new System.Drawing.Size(182, 22);
            this.txtcontrasenia.TabIndex = 2;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbluser.Location = new System.Drawing.Point(70, 196);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(71, 16);
            this.lbluser.TabIndex = 3;
            this.lbluser.Text = "USUARIO:";
            // 
            // lblcontrasenia
            // 
            this.lblcontrasenia.AutoSize = true;
            this.lblcontrasenia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcontrasenia.Location = new System.Drawing.Point(70, 257);
            this.lblcontrasenia.Name = "lblcontrasenia";
            this.lblcontrasenia.Size = new System.Drawing.Size(104, 16);
            this.lblcontrasenia.TabIndex = 4;
            this.lblcontrasenia.Text = "CONTRASEÑA:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(73, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "INICIAR SECION";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblcontrasenia);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.txtcontrasenia);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.Imglogo);
            this.Name = "lOGIN";
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.Imglogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Imglogo;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontrasenia;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblcontrasenia;
        private System.Windows.Forms.Button button1;
    }
}

