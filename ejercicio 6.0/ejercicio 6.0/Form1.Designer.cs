namespace ejercicio_6._0
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
            this.lblejercicio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lbloperacion1 = new System.Windows.Forms.Label();
            this.btncopiar = new System.Windows.Forms.Button();
            this.txtpantalla = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnigual = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.panelnumerico = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnporcent = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblejercicio
            // 
            this.lblejercicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblejercicio.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblejercicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblejercicio.Location = new System.Drawing.Point(0, 0);
            this.lblejercicio.Name = "lblejercicio";
            this.lblejercicio.Size = new System.Drawing.Size(154, 719);
            this.lblejercicio.TabIndex = 0;
            this.lblejercicio.Text = "ejercicio6";
            this.lblejercicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ejercicio_6._0.Properties.Resources.celular;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lblnum1);
            this.panel1.Controls.Add(this.lbloperacion1);
            this.panel1.Controls.Add(this.btncopiar);
            this.panel1.Controls.Add(this.txtpantalla);
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.panelnumerico);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(154, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 719);
            this.panel1.TabIndex = 1;
            // 
            // lblnum1
            // 
            this.lblnum1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnum1.Location = new System.Drawing.Point(91, 200);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(275, 28);
            this.lblnum1.TabIndex = 6;
            this.lblnum1.Text = "0";
            this.lblnum1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblnum1.Visible = false;
            // 
            // lbloperacion1
            // 
            this.lbloperacion1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloperacion1.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbloperacion1.Location = new System.Drawing.Point(260, 228);
            this.lbloperacion1.Name = "lbloperacion1";
            this.lbloperacion1.Size = new System.Drawing.Size(106, 27);
            this.lbloperacion1.TabIndex = 5;
            this.lbloperacion1.Text = "0";
            this.lbloperacion1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbloperacion1.Visible = false;
            // 
            // btncopiar
            // 
            this.btncopiar.BackgroundImage = global::ejercicio_6._0.Properties.Resources.bonton4;
            this.btncopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncopiar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btncopiar.FlatAppearance.BorderSize = 0;
            this.btncopiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncopiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btncopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncopiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btncopiar.Location = new System.Drawing.Point(91, 270);
            this.btncopiar.Name = "btncopiar";
            this.btncopiar.Size = new System.Drawing.Size(47, 41);
            this.btncopiar.TabIndex = 4;
            this.btncopiar.UseVisualStyleBackColor = true;
            this.btncopiar.Click += new System.EventHandler(this.btncopiar_Click);
            // 
            // txtpantalla
            // 
            this.txtpantalla.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtpantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpantalla.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpantalla.ForeColor = System.Drawing.SystemColors.Window;
            this.txtpantalla.Location = new System.Drawing.Point(147, 258);
            this.txtpantalla.Name = "txtpantalla";
            this.txtpantalla.ReadOnly = true;
            this.txtpantalla.Size = new System.Drawing.Size(219, 63);
            this.txtpantalla.TabIndex = 3;
            this.txtpantalla.Text = "0";
            this.txtpantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnigual);
            this.flowLayoutPanel3.Controls.Add(this.btndiv);
            this.flowLayoutPanel3.Controls.Add(this.btnmult);
            this.flowLayoutPanel3.Controls.Add(this.btnresta);
            this.flowLayoutPanel3.Controls.Add(this.btnsuma);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(304, 327);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(62, 312);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // btnigual
            // 
            this.btnigual.BackgroundImage = global::ejercicio_6._0.Properties.Resources.botonuno;
            this.btnigual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnigual.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnigual.FlatAppearance.BorderSize = 0;
            this.btnigual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnigual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnigual.ForeColor = System.Drawing.SystemColors.Control;
            this.btnigual.Location = new System.Drawing.Point(3, 3);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(55, 55);
            this.btnigual.TabIndex = 5;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btndiv
            // 
            this.btndiv.BackgroundImage = global::ejercicio_6._0.Properties.Resources.botonuno;
            this.btndiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndiv.Cursor = System.Windows.Forms.Cursors.Default;
            this.btndiv.FlatAppearance.BorderSize = 0;
            this.btndiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btndiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btndiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiv.ForeColor = System.Drawing.SystemColors.Control;
            this.btndiv.Location = new System.Drawing.Point(3, 64);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(55, 55);
            this.btndiv.TabIndex = 1;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmult
            // 
            this.btnmult.BackgroundImage = global::ejercicio_6._0.Properties.Resources.botonuno;
            this.btnmult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmult.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnmult.FlatAppearance.BorderSize = 0;
            this.btnmult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnmult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnmult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmult.ForeColor = System.Drawing.SystemColors.Control;
            this.btnmult.Location = new System.Drawing.Point(3, 125);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(55, 55);
            this.btnmult.TabIndex = 2;
            this.btnmult.Text = "X";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btnresta
            // 
            this.btnresta.BackgroundImage = global::ejercicio_6._0.Properties.Resources.botonuno;
            this.btnresta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnresta.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnresta.FlatAppearance.BorderSize = 0;
            this.btnresta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnresta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnresta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnresta.Location = new System.Drawing.Point(3, 186);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(55, 55);
            this.btnresta.TabIndex = 3;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.BackgroundImage = global::ejercicio_6._0.Properties.Resources.botonuno;
            this.btnsuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsuma.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnsuma.FlatAppearance.BorderSize = 0;
            this.btnsuma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsuma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuma.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsuma.Location = new System.Drawing.Point(3, 247);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(55, 55);
            this.btnsuma.TabIndex = 4;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // panelnumerico
            // 
            this.panelnumerico.Location = new System.Drawing.Point(88, 399);
            this.panelnumerico.Name = "panelnumerico";
            this.panelnumerico.Size = new System.Drawing.Size(210, 240);
            this.panelnumerico.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnborrar);
            this.flowLayoutPanel1.Controls.Add(this.btnporcent);
            this.flowLayoutPanel1.Controls.Add(this.btnsalir);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(91, 327);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(207, 66);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnborrar
            // 
            this.btnborrar.BackgroundImage = global::ejercicio_6._0.Properties.Resources.boton2;
            this.btnborrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnborrar.FlatAppearance.BorderSize = 0;
            this.btnborrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnborrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnborrar.Location = new System.Drawing.Point(3, 3);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(55, 55);
            this.btnborrar.TabIndex = 0;
            this.btnborrar.Text = "CE";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnporcent
            // 
            this.btnporcent.BackgroundImage = global::ejercicio_6._0.Properties.Resources.boton2;
            this.btnporcent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnporcent.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnporcent.FlatAppearance.BorderSize = 0;
            this.btnporcent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnporcent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnporcent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnporcent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnporcent.Location = new System.Drawing.Point(64, 3);
            this.btnporcent.Name = "btnporcent";
            this.btnporcent.Size = new System.Drawing.Size(55, 55);
            this.btnporcent.TabIndex = 1;
            this.btnporcent.Text = "%";
            this.btnporcent.UseVisualStyleBackColor = true;
            this.btnporcent.Click += new System.EventHandler(this.btnporcent_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = global::ejercicio_6._0.Properties.Resources.boton2;
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsalir.Location = new System.Drawing.Point(125, 3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(49, 55);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "OFF";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(680, 719);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblejercicio);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblejercicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel panelnumerico;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnporcent;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lbloperacion1;
        private System.Windows.Forms.Button btncopiar;
        private System.Windows.Forms.TextBox txtpantalla;
    }
}

