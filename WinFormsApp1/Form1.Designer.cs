namespace WinFormsApp1
{
    partial class frmInventario
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
            btnTiposInventarios = new Button();
            btnAlmacenes = new Button();
            btnArticulos = new Button();
            btnSalida = new Button();
            SuspendLayout();
            // 
            // btnTiposInventarios
            // 
            btnTiposInventarios.Location = new Point(329, 82);
            btnTiposInventarios.Name = "btnTiposInventarios";
            btnTiposInventarios.Size = new Size(151, 70);
            btnTiposInventarios.TabIndex = 1;
            btnTiposInventarios.Text = "Tipo Inventario";
            btnTiposInventarios.UseVisualStyleBackColor = true;
            btnTiposInventarios.Click += btnTiposInventarios_Click;
            // 
            // btnAlmacenes
            // 
            btnAlmacenes.Location = new Point(504, 85);
            btnAlmacenes.Name = "btnAlmacenes";
            btnAlmacenes.Size = new Size(139, 67);
            btnAlmacenes.TabIndex = 2;
            btnAlmacenes.Text = "Almacenes";
            btnAlmacenes.UseVisualStyleBackColor = true;
            btnAlmacenes.Click += btnAlmacenes_Click;
            // 
            // btnArticulos
            // 
            btnArticulos.Location = new Point(156, 82);
            btnArticulos.Name = "btnArticulos";
            btnArticulos.Size = new Size(139, 67);
            btnArticulos.TabIndex = 3;
            btnArticulos.Text = "Articulos";
            btnArticulos.UseVisualStyleBackColor = true;
            btnArticulos.Click += btnArticulos_Click;
            // 
            // btnSalida
            // 
            btnSalida.Location = new Point(38, 306);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(139, 67);
            btnSalida.TabIndex = 4;
            btnSalida.Text = "Salida";
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalida_Click;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalida);
            Controls.Add(btnArticulos);
            Controls.Add(btnAlmacenes);
            Controls.Add(btnTiposInventarios);
            Name = "frmInventario";
            Text = "Inventario";
            ResumeLayout(false);
        }

        #endregion
        private Button btnTiposInventarios;
        private Button btnAlmacenes;
        private Button btnArticulos;
        private Button btnSalida;
    }
}