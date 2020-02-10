namespace GourmetteRestaurante
{
    partial class Detalles_platos
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalles_platos));
            this.foto_plato = new System.Windows.Forms.PictureBox();
            this.lista_alergenos = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.precio_plato = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.plus_button = new System.Windows.Forms.Button();
            this.cantidad = new System.Windows.Forms.Label();
            this.less_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foto_plato)).BeginInit();
            this.SuspendLayout();
            // 
            // foto_plato
            // 
            this.foto_plato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.foto_plato.Location = new System.Drawing.Point(23, 83);
            this.foto_plato.Name = "foto_plato";
            this.foto_plato.Size = new System.Drawing.Size(374, 262);
            this.foto_plato.TabIndex = 0;
            this.foto_plato.TabStop = false;
            // 
            // lista_alergenos
            // 
            this.lista_alergenos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista_alergenos.FormattingEnabled = true;
            this.lista_alergenos.Location = new System.Drawing.Point(490, 119);
            this.lista_alergenos.Name = "lista_alergenos";
            this.lista_alergenos.Size = new System.Drawing.Size(167, 187);
            this.lista_alergenos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(490, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alérgenos";
            // 
            // precio_plato
            // 
            this.precio_plato.AutoSize = true;
            this.precio_plato.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_plato.Location = new System.Drawing.Point(541, 365);
            this.precio_plato.Name = "precio_plato";
            this.precio_plato.Size = new System.Drawing.Size(268, 90);
            this.precio_plato.TabIndex = 3;
            this.precio_plato.Text = "asdasd";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(23, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 65);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plus_button
            // 
            this.plus_button.BackColor = System.Drawing.Color.Silver;
            this.plus_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plus_button.BackgroundImage")));
            this.plus_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plus_button.FlatAppearance.BorderSize = 0;
            this.plus_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus_button.Location = new System.Drawing.Point(443, 351);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(52, 104);
            this.plus_button.TabIndex = 5;
            this.plus_button.UseVisualStyleBackColor = false;
            this.plus_button.Click += new System.EventHandler(this.plus_button_Click);
            // 
            // cantidad
            // 
            this.cantidad.AutoSize = true;
            this.cantidad.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(357, 387);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(165, 46);
            this.cantidad.TabIndex = 7;
            this.cantidad.Text = "Cantidad";
            // 
            // less_button
            // 
            this.less_button.BackColor = System.Drawing.Color.Silver;
            this.less_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("less_button.BackgroundImage")));
            this.less_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.less_button.FlatAppearance.BorderSize = 0;
            this.less_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.less_button.Location = new System.Drawing.Point(262, 351);
            this.less_button.Name = "less_button";
            this.less_button.Size = new System.Drawing.Size(52, 104);
            this.less_button.TabIndex = 8;
            this.less_button.UseVisualStyleBackColor = false;
            this.less_button.Click += new System.EventHandler(this.less_button_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("PMingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(39, 351);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(183, 103);
            this.add_button.TabIndex = 9;
            this.add_button.Text = "Añadir";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // Detalles_platos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.less_button);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.plus_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.precio_plato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista_alergenos);
            this.Controls.Add(this.foto_plato);
            this.Name = "Detalles_platos";
            this.Size = new System.Drawing.Size(816, 501);
            this.Load += new System.EventHandler(this.Detalles_platos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto_plato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox foto_plato;
        private System.Windows.Forms.CheckedListBox lista_alergenos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label precio_plato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.Button less_button;
        private System.Windows.Forms.Button add_button;
    }
}
