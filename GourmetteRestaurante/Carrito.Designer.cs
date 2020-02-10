namespace GourmetteRestaurante
{
    partial class Carrito
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrito));
            platos_lista_carrito = new System.Windows.Forms.ListView();
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cerrar_carrito = new System.Windows.Forms.Button();
            this.boton_eliminar = new System.Windows.Forms.Button();
            this.boton_pagar = new System.Windows.Forms.Button();
            this.pagar1 = new GourmetteRestaurante.pagar();
            this.label1 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.tt_carrito = new System.Windows.Forms.ToolTip(this.components);
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // platos_lista_carrito
            // 
            platos_lista_carrito.BackColor = System.Drawing.SystemColors.Menu;
            platos_lista_carrito.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nom,
            this.cant,
            this.pre,
            this.tipo});
            platos_lista_carrito.HideSelection = false;
            platos_lista_carrito.Location = new System.Drawing.Point(194, 22);
            platos_lista_carrito.Name = "platos_lista_carrito";
            platos_lista_carrito.Size = new System.Drawing.Size(661, 604);
            platos_lista_carrito.TabIndex = 0;
            platos_lista_carrito.UseCompatibleStateImageBehavior = false;
            platos_lista_carrito.View = System.Windows.Forms.View.Details;
            // 
            // nom
            // 
            this.nom.Text = "Nombre del plato";
            this.nom.Width = 176;
            // 
            // cant
            // 
            this.cant.Text = "Cantidad";
            this.cant.Width = 99;
            // 
            // pre
            // 
            this.pre.Text = "Precio";
            this.pre.Width = 92;
            // 
            // tipo
            // 
            this.tipo.Text = "Tipo de plato";
            this.tipo.Width = 196;
            // 
            // cerrar_carrito
            // 
            this.cerrar_carrito.BackColor = System.Drawing.Color.Silver;
            this.cerrar_carrito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cerrar_carrito.BackgroundImage")));
            this.cerrar_carrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cerrar_carrito.FlatAppearance.BorderSize = 0;
            this.cerrar_carrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar_carrito.Location = new System.Drawing.Point(21, 22);
            this.cerrar_carrito.Name = "cerrar_carrito";
            this.cerrar_carrito.Size = new System.Drawing.Size(140, 90);
            this.cerrar_carrito.TabIndex = 3;
            this.cerrar_carrito.UseVisualStyleBackColor = false;
            this.cerrar_carrito.Click += new System.EventHandler(this.cerrar_carrito_Click);
            // 
            // boton_eliminar
            // 
            this.boton_eliminar.BackColor = System.Drawing.Color.LightGray;
            this.boton_eliminar.FlatAppearance.BorderSize = 0;
            this.boton_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_eliminar.Location = new System.Drawing.Point(932, 85);
            this.boton_eliminar.Name = "boton_eliminar";
            this.boton_eliminar.Size = new System.Drawing.Size(153, 115);
            this.boton_eliminar.TabIndex = 4;
            this.boton_eliminar.Text = "Eliminar plato";
            this.boton_eliminar.UseVisualStyleBackColor = false;
            this.boton_eliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // boton_pagar
            // 
            this.boton_pagar.BackColor = System.Drawing.Color.LightGray;
            this.boton_pagar.FlatAppearance.BorderSize = 0;
            this.boton_pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_pagar.Location = new System.Drawing.Point(932, 447);
            this.boton_pagar.Name = "boton_pagar";
            this.boton_pagar.Size = new System.Drawing.Size(153, 115);
            this.boton_pagar.TabIndex = 5;
            this.boton_pagar.Text = "Pagar";
            this.boton_pagar.UseVisualStyleBackColor = false;
            this.boton_pagar.Click += new System.EventHandler(this.button2_Click);
            // 
            // pagar1
            // 
            this.pagar1.Location = new System.Drawing.Point(194, 22);
            this.pagar1.Name = "pagar1";
            this.pagar1.Size = new System.Drawing.Size(661, 604);
            this.pagar1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(929, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(929, 384);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(92, 38);
            this.total.TabIndex = 8;
            this.total.Text = "Total";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.Location = new System.Drawing.Point(28, 236);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(65, 20);
            this.error.TabIndex = 9;
            this.error.Text = "label2";
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.error);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_pagar);
            this.Controls.Add(this.boton_eliminar);
            this.Controls.Add(this.cerrar_carrito);
            this.Controls.Add(platos_lista_carrito);
            this.Controls.Add(this.pagar1);
            this.Name = "Carrito";
            this.Size = new System.Drawing.Size(1134, 657);
            this.Load += new System.EventHandler(this.Carrito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader cant;
        private System.Windows.Forms.ColumnHeader pre;
        private System.Windows.Forms.ColumnHeader tipo;
        private System.Windows.Forms.Button cerrar_carrito;
        private System.Windows.Forms.Button boton_eliminar;
        private System.Windows.Forms.Button boton_pagar;
        private pagar pagar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.ToolTip tt_carrito;
        public static System.Windows.Forms.ListView platos_lista_carrito;
        private System.Windows.Forms.Label error;
    }
}
