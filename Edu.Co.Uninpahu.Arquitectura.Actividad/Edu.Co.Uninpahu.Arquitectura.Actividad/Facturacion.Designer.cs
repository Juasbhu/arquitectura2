namespace Edu.Co.Uninpahu.Arquitectura.Actividad
{
    partial class Facturacion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.facturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GBContenido = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TBTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LNombreVendedor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBProducto = new System.Windows.Forms.ComboBox();
            this.CBCliente = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.GBContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // facturarToolStripMenuItem
            // 
            this.facturarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
            this.facturarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.facturarToolStripMenuItem.Text = "Facturar";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // GBContenido
            // 
            this.GBContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBContenido.Controls.Add(this.button2);
            this.GBContenido.Controls.Add(this.DgvProductos);
            this.GBContenido.Controls.Add(this.BtnLimpiar);
            this.GBContenido.Controls.Add(this.button1);
            this.GBContenido.Controls.Add(this.TBTotal);
            this.GBContenido.Controls.Add(this.label3);
            this.GBContenido.Controls.Add(this.LNombreVendedor);
            this.GBContenido.Controls.Add(this.label4);
            this.GBContenido.Controls.Add(this.label2);
            this.GBContenido.Controls.Add(this.label1);
            this.GBContenido.Controls.Add(this.CBProducto);
            this.GBContenido.Controls.Add(this.CBCliente);
            this.GBContenido.Location = new System.Drawing.Point(13, 28);
            this.GBContenido.Name = "GBContenido";
            this.GBContenido.Size = new System.Drawing.Size(616, 453);
            this.GBContenido.TabIndex = 2;
            this.GBContenido.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(351, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 27);
            this.button2.TabIndex = 14;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // DgvProductos
            // 
            this.DgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Location = new System.Drawing.Point(75, 185);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.Size = new System.Drawing.Size(478, 150);
            this.DgvProductos.TabIndex = 13;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnLimpiar.Location = new System.Drawing.Point(251, 409);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(94, 27);
            this.BtnLimpiar.TabIndex = 12;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(151, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBTotal
            // 
            this.TBTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TBTotal.Location = new System.Drawing.Point(290, 359);
            this.TBTotal.Name = "TBTotal";
            this.TBTotal.Size = new System.Drawing.Size(263, 20);
            this.TBTotal.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor Total";
            // 
            // LNombreVendedor
            // 
            this.LNombreVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LNombreVendedor.AutoSize = true;
            this.LNombreVendedor.Location = new System.Drawing.Point(287, 52);
            this.LNombreVendedor.Name = "LNombreVendedor";
            this.LNombreVendedor.Size = new System.Drawing.Size(53, 13);
            this.LNombreVendedor.TabIndex = 7;
            this.LNombreVendedor.Text = "Vendedor";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vendedor";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Cliente";
            // 
            // CBProducto
            // 
            this.CBProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CBProducto.FormattingEnabled = true;
            this.CBProducto.Location = new System.Drawing.Point(290, 137);
            this.CBProducto.Name = "CBProducto";
            this.CBProducto.Size = new System.Drawing.Size(263, 21);
            this.CBProducto.TabIndex = 1;
            this.CBProducto.SelectedIndexChanged += new System.EventHandler(this.CBProducto_SelectedIndexChanged);
            // 
            // CBCliente
            // 
            this.CBCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CBCliente.FormattingEnabled = true;
            this.CBCliente.Location = new System.Drawing.Point(290, 96);
            this.CBCliente.Name = "CBCliente";
            this.CBCliente.Size = new System.Drawing.Size(263, 21);
            this.CBCliente.TabIndex = 0;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 493);
            this.Controls.Add(this.GBContenido);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GBContenido.ResumeLayout(false);
            this.GBContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem facturarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox GBContenido;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LNombreVendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBProducto;
        private System.Windows.Forms.ComboBox CBCliente;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.Button button2;
    }
}