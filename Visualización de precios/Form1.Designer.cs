namespace Visualización_de_precios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbProductos = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            lvPrecio = new ListView();
            Marca = new ColumnHeader();
            Descripcion = new ColumnHeader();
            Precio = new ColumnHeader();
            SuspendLayout();
            // 
            // cbProductos
            // 
            cbProductos.FormattingEnabled = true;
            cbProductos.Location = new Point(16, 52);
            cbProductos.Name = "cbProductos";
            cbProductos.Size = new Size(121, 23);
            cbProductos.TabIndex = 1;
            cbProductos.SelectedIndexChanged += cbProductos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 25);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 2;
            label1.Text = "Selecciona el tipo de producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 25);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "Lista de precios";
            // 
            // lvPrecio
            // 
            lvPrecio.Columns.AddRange(new ColumnHeader[] { Marca, Descripcion, Precio });
            lvPrecio.Location = new Point(206, 52);
            lvPrecio.Name = "lvPrecio";
            lvPrecio.Size = new Size(394, 198);
            lvPrecio.TabIndex = 5;
            lvPrecio.UseCompatibleStateImageBehavior = false;
            lvPrecio.View = View.Details;
            // 
            // Marca
            // 
            Marca.Text = "Marca";
            Marca.Width = 100;
            // 
            // Descripcion
            // 
            Descripcion.Text = "Descripcion";
            Descripcion.Width = 200;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 277);
            Controls.Add(lvPrecio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbProductos);
            Name = "Form1";
            Text = "Productos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbProductos;
        private Label label1;
        private Label label2;
        private ListView lvPrecio;
        private ColumnHeader Marca;
        private ColumnHeader Descripcion;
        private ColumnHeader Precio;
    }
}