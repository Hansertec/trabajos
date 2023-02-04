namespace calculadoras
{
    partial class Calculadoras
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
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnsigno = new System.Windows.Forms.Button();
            this.btncero = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btntres = new System.Windows.Forms.Button();
            this.btndos = new System.Windows.Forms.Button();
            this.btnuno = new System.Windows.Forms.Button();
            this.btnseis = new System.Windows.Forms.Button();
            this.btncinco = new System.Windows.Forms.Button();
            this.btncuatro = new System.Windows.Forms.Button();
            this.btnnueve = new System.Windows.Forms.Button();
            this.btnocho = new System.Windows.Forms.Button();
            this.btnsiete = new System.Windows.Forms.Button();
            this.btnlimpiar1 = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnborrartodo = new System.Windows.Forms.Button();
            this.btnelvar = new System.Windows.Forms.Button();
            this.btnraiz = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtresultado
            // 
            this.txtresultado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(12, 12);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(249, 29);
            this.txtresultado.TabIndex = 0;
            this.txtresultado.Text = "0";
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnsigno
            // 
            this.btnsigno.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnsigno.Location = new System.Drawing.Point(10, 261);
            this.btnsigno.Name = "btnsigno";
            this.btnsigno.Size = new System.Drawing.Size(45, 45);
            this.btnsigno.TabIndex = 1;
            this.btnsigno.Text = "-/+";
            this.btnsigno.UseVisualStyleBackColor = true;
            this.btnsigno.Click += new System.EventHandler(this.btnsigno_Click);
            // 
            // btncero
            // 
            this.btncero.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btncero.Location = new System.Drawing.Point(61, 261);
            this.btncero.Name = "btncero";
            this.btncero.Size = new System.Drawing.Size(45, 45);
            this.btncero.TabIndex = 2;
            this.btncero.Text = "0";
            this.btncero.UseVisualStyleBackColor = true;
            this.btncero.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnpunto
            // 
            this.btnpunto.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnpunto.Location = new System.Drawing.Point(112, 261);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(45, 45);
            this.btnpunto.TabIndex = 3;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_Click);
            // 
            // btntres
            // 
            this.btntres.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btntres.Location = new System.Drawing.Point(112, 210);
            this.btntres.Name = "btntres";
            this.btntres.Size = new System.Drawing.Size(45, 45);
            this.btntres.TabIndex = 6;
            this.btntres.Text = "3";
            this.btntres.UseVisualStyleBackColor = true;
            this.btntres.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btndos
            // 
            this.btndos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btndos.Location = new System.Drawing.Point(61, 210);
            this.btndos.Name = "btndos";
            this.btndos.Size = new System.Drawing.Size(45, 45);
            this.btndos.TabIndex = 5;
            this.btndos.Text = "2";
            this.btndos.UseVisualStyleBackColor = true;
            this.btndos.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnuno
            // 
            this.btnuno.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnuno.Location = new System.Drawing.Point(10, 210);
            this.btnuno.Name = "btnuno";
            this.btnuno.Size = new System.Drawing.Size(45, 45);
            this.btnuno.TabIndex = 4;
            this.btnuno.Text = "1";
            this.btnuno.UseVisualStyleBackColor = true;
            this.btnuno.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnseis
            // 
            this.btnseis.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnseis.Location = new System.Drawing.Point(112, 159);
            this.btnseis.Name = "btnseis";
            this.btnseis.Size = new System.Drawing.Size(45, 45);
            this.btnseis.TabIndex = 9;
            this.btnseis.Text = "6";
            this.btnseis.UseVisualStyleBackColor = true;
            this.btnseis.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btncinco
            // 
            this.btncinco.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btncinco.Location = new System.Drawing.Point(61, 159);
            this.btncinco.Name = "btncinco";
            this.btncinco.Size = new System.Drawing.Size(45, 45);
            this.btncinco.TabIndex = 8;
            this.btncinco.Text = "5";
            this.btncinco.UseVisualStyleBackColor = true;
            this.btncinco.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btncuatro
            // 
            this.btncuatro.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btncuatro.Location = new System.Drawing.Point(10, 159);
            this.btncuatro.Name = "btncuatro";
            this.btncuatro.Size = new System.Drawing.Size(45, 45);
            this.btncuatro.TabIndex = 7;
            this.btncuatro.Text = "4";
            this.btncuatro.UseVisualStyleBackColor = true;
            this.btncuatro.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnnueve
            // 
            this.btnnueve.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnnueve.Location = new System.Drawing.Point(112, 108);
            this.btnnueve.Name = "btnnueve";
            this.btnnueve.Size = new System.Drawing.Size(45, 45);
            this.btnnueve.TabIndex = 12;
            this.btnnueve.Text = "9";
            this.btnnueve.UseVisualStyleBackColor = true;
            this.btnnueve.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnocho
            // 
            this.btnocho.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnocho.Location = new System.Drawing.Point(61, 108);
            this.btnocho.Name = "btnocho";
            this.btnocho.Size = new System.Drawing.Size(45, 45);
            this.btnocho.TabIndex = 11;
            this.btnocho.Text = "8";
            this.btnocho.UseVisualStyleBackColor = true;
            this.btnocho.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnsiete
            // 
            this.btnsiete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnsiete.Location = new System.Drawing.Point(10, 108);
            this.btnsiete.Name = "btnsiete";
            this.btnsiete.Size = new System.Drawing.Size(45, 45);
            this.btnsiete.TabIndex = 10;
            this.btnsiete.Text = "7";
            this.btnsiete.UseVisualStyleBackColor = true;
            this.btnsiete.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnlimpiar1
            // 
            this.btnlimpiar1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnlimpiar1.Location = new System.Drawing.Point(112, 57);
            this.btnlimpiar1.Name = "btnlimpiar1";
            this.btnlimpiar1.Size = new System.Drawing.Size(45, 45);
            this.btnlimpiar1.TabIndex = 15;
            this.btnlimpiar1.Text = "←";
            this.btnlimpiar1.UseVisualStyleBackColor = true;
            this.btnlimpiar1.Click += new System.EventHandler(this.btnlimpiar1_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnborrar.Location = new System.Drawing.Point(61, 57);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(45, 45);
            this.btnborrar.TabIndex = 14;
            this.btnborrar.Text = "CE";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnborrartodo
            // 
            this.btnborrartodo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnborrartodo.Location = new System.Drawing.Point(10, 57);
            this.btnborrartodo.Name = "btnborrartodo";
            this.btnborrartodo.Size = new System.Drawing.Size(45, 45);
            this.btnborrartodo.TabIndex = 13;
            this.btnborrartodo.Text = "C";
            this.btnborrartodo.UseVisualStyleBackColor = true;
            this.btnborrartodo.Click += new System.EventHandler(this.btnborrartodo_Click);
            // 
            // btnelvar
            // 
            this.btnelvar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnelvar.Location = new System.Drawing.Point(223, 57);
            this.btnelvar.Name = "btnelvar";
            this.btnelvar.Size = new System.Drawing.Size(47, 45);
            this.btnelvar.TabIndex = 17;
            this.btnelvar.Tag = "²";
            this.btnelvar.Text = "X²";
            this.btnelvar.UseVisualStyleBackColor = true;
            this.btnelvar.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnraiz
            // 
            this.btnraiz.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnraiz.Location = new System.Drawing.Point(172, 57);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(47, 45);
            this.btnraiz.TabIndex = 16;
            this.btnraiz.Tag = "ⱱ";
            this.btnraiz.Text = "ⱱ";
            this.btnraiz.UseVisualStyleBackColor = true;
            this.btnraiz.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnmultiplicar.Location = new System.Drawing.Point(223, 108);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(45, 45);
            this.btnmultiplicar.TabIndex = 19;
            this.btnmultiplicar.Tag = "*";
            this.btnmultiplicar.Text = "*";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.clickOperador);
            // 
            // btndividir
            // 
            this.btndividir.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btndividir.Location = new System.Drawing.Point(172, 108);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(45, 45);
            this.btndividir.TabIndex = 18;
            this.btndividir.Tag = "/";
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnresta
            // 
            this.btnresta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnresta.Location = new System.Drawing.Point(223, 159);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(45, 45);
            this.btnresta.TabIndex = 21;
            this.btnresta.Tag = "-";
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnsuma
            // 
            this.btnsuma.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnsuma.Location = new System.Drawing.Point(172, 159);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(45, 45);
            this.btnsuma.TabIndex = 20;
            this.btnsuma.Tag = "+";
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.clickOperador);
            // 
            // btnresultado
            // 
            this.btnresultado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnresultado.Location = new System.Drawing.Point(172, 210);
            this.btnresultado.Name = "btnresultado";
            this.btnresultado.Size = new System.Drawing.Size(96, 45);
            this.btnresultado.TabIndex = 24;
            this.btnresultado.Tag = "=";
            this.btnresultado.Text = "=";
            this.btnresultado.UseVisualStyleBackColor = true;
            this.btnresultado.Click += new System.EventHandler(this.btnresultado_Click);
            // 
            // Calculadoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 327);
            this.Controls.Add(this.btnresultado);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnelvar);
            this.Controls.Add(this.btnraiz);
            this.Controls.Add(this.btnlimpiar1);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnborrartodo);
            this.Controls.Add(this.btnnueve);
            this.Controls.Add(this.btnocho);
            this.Controls.Add(this.btnsiete);
            this.Controls.Add(this.btnseis);
            this.Controls.Add(this.btncinco);
            this.Controls.Add(this.btncuatro);
            this.Controls.Add(this.btntres);
            this.Controls.Add(this.btndos);
            this.Controls.Add(this.btnuno);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btncero);
            this.Controls.Add(this.btnsigno);
            this.Controls.Add(this.txtresultado);
            this.Name = "Calculadoras";
            this.Text = "Calculadoras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnsigno;
        private System.Windows.Forms.Button btncero;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.Button btntres;
        private System.Windows.Forms.Button btndos;
        private System.Windows.Forms.Button btnuno;
        private System.Windows.Forms.Button btnseis;
        private System.Windows.Forms.Button btncinco;
        private System.Windows.Forms.Button btncuatro;
        private System.Windows.Forms.Button btnnueve;
        private System.Windows.Forms.Button btnocho;
        private System.Windows.Forms.Button btnsiete;
        private System.Windows.Forms.Button btnlimpiar1;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnborrartodo;
        private System.Windows.Forms.Button btnelvar;
        private System.Windows.Forms.Button btnraiz;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresultado;
    }
}

