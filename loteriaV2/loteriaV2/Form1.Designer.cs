namespace loteriaV2
{
    partial class Form1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnjugar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtjugarnumero = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(144, 130);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(112, 51);
            this.lbl1.TabIndex = 0;
            // 
            // Lbl2
            // 
            this.Lbl2.Location = new System.Drawing.Point(295, 127);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(99, 51);
            this.Lbl2.TabIndex = 1;
            // 
            // Lbl3
            // 
            this.Lbl3.Location = new System.Drawing.Point(400, 127);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(78, 51);
            this.Lbl3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(463, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // btnjugar
            // 
            this.btnjugar.Location = new System.Drawing.Point(254, 211);
            this.btnjugar.Name = "btnjugar";
            this.btnjugar.Size = new System.Drawing.Size(99, 35);
            this.btnjugar.TabIndex = 4;
            this.btnjugar.Text = "Jugar";
            this.btnjugar.UseVisualStyleBackColor = true;
            this.btnjugar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 35);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Primera";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(407, 76);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 35);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Tercera";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(273, 76);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 35);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "segunda";
            // 
            // txtjugarnumero
            // 
            this.txtjugarnumero.Location = new System.Drawing.Point(564, 127);
            this.txtjugarnumero.Multiline = true;
            this.txtjugarnumero.Name = "txtjugarnumero";
            this.txtjugarnumero.Size = new System.Drawing.Size(80, 35);
            this.txtjugarnumero.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(553, 76);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(156, 35);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Ingrese el numero para jugar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtjugarnumero);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnjugar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnjugar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtjugarnumero;
        private System.Windows.Forms.TextBox textBox5;
    }
}

