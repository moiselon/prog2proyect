namespace WindowsFormsApp1
{
    partial class principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.btnalmacen = new System.Windows.Forms.Button();
            this.btnventas = new System.Windows.Forms.Button();
            this.btncompras = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcargo = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.btnproducto = new System.Windows.Forms.Button();
            this.lblfecha = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnalmacen
            // 
            this.btnalmacen.Location = new System.Drawing.Point(152, 205);
            this.btnalmacen.Name = "btnalmacen";
            this.btnalmacen.Size = new System.Drawing.Size(153, 83);
            this.btnalmacen.TabIndex = 0;
            this.btnalmacen.Text = "Software";
            this.btnalmacen.UseVisualStyleBackColor = true;
            this.btnalmacen.Click += new System.EventHandler(this.btnalmacen_Click);
            // 
            // btnventas
            // 
            this.btnventas.Location = new System.Drawing.Point(152, 325);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(153, 88);
            this.btnventas.TabIndex = 1;
            this.btnventas.Text = "Multimedia";
            this.btnventas.UseVisualStyleBackColor = true;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            // 
            // btncompras
            // 
            this.btncompras.Location = new System.Drawing.Point(355, 205);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(156, 88);
            this.btncompras.TabIndex = 2;
            this.btncompras.Text = "base de datos";
            this.btncompras.UseVisualStyleBackColor = true;
            this.btncompras.Click += new System.EventHandler(this.btncompras_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(43, 98);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(87, 24);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Usuario:";
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargo.Location = new System.Drawing.Point(39, 144);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(91, 24);
            this.lblcargo.TabIndex = 4;
            this.lblcargo.Text = "Carrera: ";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(426, 98);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(48, 24);
            this.lblhora.TabIndex = 5;
            this.lblhora.Text = "hora";
            // 
            // btnproducto
            // 
            this.btnproducto.Location = new System.Drawing.Point(355, 325);
            this.btnproducto.Name = "btnproducto";
            this.btnproducto.Size = new System.Drawing.Size(163, 88);
            this.btnproducto.TabIndex = 7;
            this.btnproducto.Text = "Redes";
            this.btnproducto.UseVisualStyleBackColor = true;
            this.btnproducto.Click += new System.EventHandler(this.btnproducto_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(426, 144);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(56, 24);
            this.lblfecha.TabIndex = 6;
            this.lblfecha.Text = "fecha";
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnproducto);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.lblcargo);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.btncompras);
            this.Controls.Add(this.btnventas);
            this.Controls.Add(this.btnalmacen);
            this.Name = "principal";
            this.Text = "principal";
            this.Load += new System.EventHandler(this.principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnalmacen;
        private System.Windows.Forms.Button btnventas;
        private System.Windows.Forms.Button btncompras;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Button btnproducto;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}