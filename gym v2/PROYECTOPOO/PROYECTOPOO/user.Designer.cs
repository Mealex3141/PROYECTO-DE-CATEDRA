namespace PROYECTOPOO
{
    partial class user
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
            this.btncs = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncs
            // 
            this.btncs.BackgroundImage = global::PROYECTOPOO.Properties.Resources.Botón_de_cierre_de_sesión_neón;
            this.btncs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncs.Location = new System.Drawing.Point(29, 525);
            this.btncs.Name = "btncs";
            this.btncs.Size = new System.Drawing.Size(78, 39);
            this.btncs.TabIndex = 4;
            this.btncs.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.BackgroundImage = global::PROYECTOPOO.Properties.Resources.Tarjeta_de_entrenamiento_recomendada;
            this.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Location = new System.Drawing.Point(29, 383);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(288, 95);
            this.btnC.TabIndex = 3;
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.BackgroundImage = global::PROYECTOPOO.Properties.Resources.Tarjeta_de_rutina_recomendada_de_abdomen;
            this.btnB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Location = new System.Drawing.Point(29, 264);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(288, 95);
            this.btnB.TabIndex = 2;
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            this.btnA.BackgroundImage = global::PROYECTOPOO.Properties.Resources.Tarjeta_de_rutina_recomendada_en_rojo;
            this.btnA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Location = new System.Drawing.Point(29, 149);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(288, 95);
            this.btnA.TabIndex = 1;
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTOPOO.Properties.Resources.Bienvenid__al_gimnasio;
            this.pictureBox1.Location = new System.Drawing.Point(65, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(347, 591);
            this.Controls.Add(this.btncs);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "user";
            this.Text = "user";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btncs;
    }
}