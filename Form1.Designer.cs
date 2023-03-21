namespace PesoIdeal
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.radioBtnHomem = new System.Windows.Forms.RadioButton();
            this.radioBtnMulher = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sexo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(238, 46);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 2;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // radioBtnHomem
            // 
            this.radioBtnHomem.AutoSize = true;
            this.radioBtnHomem.Location = new System.Drawing.Point(30, 51);
            this.radioBtnHomem.Name = "radioBtnHomem";
            this.radioBtnHomem.Size = new System.Drawing.Size(76, 20);
            this.radioBtnHomem.TabIndex = 3;
            this.radioBtnHomem.TabStop = true;
            this.radioBtnHomem.Text = "Homem";
            this.radioBtnHomem.UseVisualStyleBackColor = true;
            this.radioBtnHomem.CheckedChanged += new System.EventHandler(this.radioBtnHomem_CheckedChanged);
            // 
            // radioBtnMulher
            // 
            this.radioBtnMulher.AutoSize = true;
            this.radioBtnMulher.Location = new System.Drawing.Point(126, 51);
            this.radioBtnMulher.Name = "radioBtnMulher";
            this.radioBtnMulher.Size = new System.Drawing.Size(68, 20);
            this.radioBtnMulher.TabIndex = 4;
            this.radioBtnMulher.TabStop = true;
            this.radioBtnMulher.Text = "Mulher";
            this.radioBtnMulher.UseVisualStyleBackColor = true;
            this.radioBtnMulher.CheckedChanged += new System.EventHandler(this.radioBtnMulher_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peso Ideal";
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AutoSize = true;
            this.lblPesoIdeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPesoIdeal.Location = new System.Drawing.Point(109, 118);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(107, 31);
            this.lblPesoIdeal.TabIndex = 6;
            this.lblPesoIdeal.Text = "00,0 Kg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 173);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioBtnMulher);
            this.Controls.Add(this.radioBtnHomem);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.RadioButton radioBtnHomem;
        private System.Windows.Forms.RadioButton radioBtnMulher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPesoIdeal;
    }
}

