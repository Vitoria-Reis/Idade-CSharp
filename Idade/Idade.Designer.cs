namespace Idade
{
    partial class Idade
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
            this.btnCalculaIdade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCalculaIdade
            // 
            this.btnCalculaIdade.Location = new System.Drawing.Point(83, 74);
            this.btnCalculaIdade.Name = "btnCalculaIdade";
            this.btnCalculaIdade.Size = new System.Drawing.Size(171, 46);
            this.btnCalculaIdade.TabIndex = 0;
            this.btnCalculaIdade.Text = "Calcular Idade";
            this.btnCalculaIdade.UseVisualStyleBackColor = true;
            this.btnCalculaIdade.Click += new System.EventHandler(this.btnCalculaIdade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data de nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Idade:";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(158, 133);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(0, 20);
            this.lblIdade.TabIndex = 4;
            // 
            // DataNascimento
            // 
            this.DataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataNascimento.Location = new System.Drawing.Point(187, 33);
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.Size = new System.Drawing.Size(147, 26);
            this.DataNascimento.TabIndex = 5;
            // 
            // Idade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 198);
            this.Controls.Add(this.DataNascimento);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculaIdade);
            this.Name = "Idade";
            this.Text = "Idade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculaIdade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.DateTimePicker DataNascimento;
    }
}

