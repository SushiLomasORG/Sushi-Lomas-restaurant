namespace Sushi_Lomas_restaurant.Windows.Administracion
{
    partial class Administrar_precios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_precioActual = new System.Windows.Forms.TextBox();
            this.txt_nuevoPrecio = new System.Windows.Forms.TextBox();
            this.btn_Reg = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PROMOCIONES = new System.Windows.Forms.Button();
            this.SUSHIS = new System.Windows.Forms.Button();
            this.CHAROLAS = new System.Windows.Forms.Button();
            this.ENTRADAS = new System.Windows.Forms.Button();
            this.OTROS = new System.Windows.Forms.Button();
            this.BEBIDAS = new System.Windows.Forms.Button();
            this.EXTRAS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.txt_producto);
            this.panel1.Location = new System.Drawing.Point(573, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 39);
            this.panel1.TabIndex = 0;
            // 
            // txt_producto
            // 
            this.txt_producto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_producto.ForeColor = System.Drawing.Color.DimGray;
            this.txt_producto.Location = new System.Drawing.Point(4, 6);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(690, 27);
            this.txt_producto.TabIndex = 0;
            this.txt_producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_producto.TextChanged += new System.EventHandler(this.txt_filtrar_TextChanged);
            this.txt_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_producto_KeyPress);
            // 
            // txt_precioActual
            // 
            this.txt_precioActual.BackColor = System.Drawing.Color.White;
            this.txt_precioActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_precioActual.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txt_precioActual.Location = new System.Drawing.Point(580, 563);
            this.txt_precioActual.Name = "txt_precioActual";
            this.txt_precioActual.Size = new System.Drawing.Size(271, 36);
            this.txt_precioActual.TabIndex = 1;
            this.txt_precioActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nuevoPrecio
            // 
            this.txt_nuevoPrecio.BackColor = System.Drawing.Color.White;
            this.txt_nuevoPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nuevoPrecio.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txt_nuevoPrecio.Location = new System.Drawing.Point(909, 563);
            this.txt_nuevoPrecio.Name = "txt_nuevoPrecio";
            this.txt_nuevoPrecio.Size = new System.Drawing.Size(312, 36);
            this.txt_nuevoPrecio.TabIndex = 2;
            this.txt_nuevoPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nuevoPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nuevoPrecio_KeyPress);
            // 
            // btn_Reg
            // 
            this.btn_Reg.BackColor = System.Drawing.Color.Transparent;
            this.btn_Reg.FlatAppearance.BorderSize = 0;
            this.btn_Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reg.Location = new System.Drawing.Point(573, 683);
            this.btn_Reg.Name = "btn_Reg";
            this.btn_Reg.Size = new System.Drawing.Size(697, 61);
            this.btn_Reg.TabIndex = 3;
            this.btn_Reg.UseVisualStyleBackColor = false;
            this.btn_Reg.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(573, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(697, 329);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // PROMOCIONES
            // 
            this.PROMOCIONES.BackColor = System.Drawing.Color.Transparent;
            this.PROMOCIONES.FlatAppearance.BorderSize = 0;
            this.PROMOCIONES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PROMOCIONES.Location = new System.Drawing.Point(2, 172);
            this.PROMOCIONES.Name = "PROMOCIONES";
            this.PROMOCIONES.Size = new System.Drawing.Size(366, 67);
            this.PROMOCIONES.TabIndex = 5;
            this.PROMOCIONES.UseVisualStyleBackColor = false;
            this.PROMOCIONES.Click += new System.EventHandler(this.PROMOCIONES_Click);
            // 
            // SUSHIS
            // 
            this.SUSHIS.BackColor = System.Drawing.Color.Transparent;
            this.SUSHIS.FlatAppearance.BorderSize = 0;
            this.SUSHIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SUSHIS.Location = new System.Drawing.Point(2, 245);
            this.SUSHIS.Name = "SUSHIS";
            this.SUSHIS.Size = new System.Drawing.Size(366, 67);
            this.SUSHIS.TabIndex = 6;
            this.SUSHIS.UseVisualStyleBackColor = false;
            this.SUSHIS.Click += new System.EventHandler(this.SUSHIS_Click);
            // 
            // CHAROLAS
            // 
            this.CHAROLAS.BackColor = System.Drawing.Color.Transparent;
            this.CHAROLAS.FlatAppearance.BorderSize = 0;
            this.CHAROLAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHAROLAS.Location = new System.Drawing.Point(2, 318);
            this.CHAROLAS.Name = "CHAROLAS";
            this.CHAROLAS.Size = new System.Drawing.Size(366, 67);
            this.CHAROLAS.TabIndex = 7;
            this.CHAROLAS.UseVisualStyleBackColor = false;
            this.CHAROLAS.Click += new System.EventHandler(this.CHAROLAS_Click);
            // 
            // ENTRADAS
            // 
            this.ENTRADAS.BackColor = System.Drawing.Color.Transparent;
            this.ENTRADAS.FlatAppearance.BorderSize = 0;
            this.ENTRADAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ENTRADAS.Location = new System.Drawing.Point(2, 391);
            this.ENTRADAS.Name = "ENTRADAS";
            this.ENTRADAS.Size = new System.Drawing.Size(366, 67);
            this.ENTRADAS.TabIndex = 8;
            this.ENTRADAS.UseVisualStyleBackColor = false;
            this.ENTRADAS.Click += new System.EventHandler(this.ENTRADAS_Click);
            // 
            // OTROS
            // 
            this.OTROS.BackColor = System.Drawing.Color.Transparent;
            this.OTROS.FlatAppearance.BorderSize = 0;
            this.OTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OTROS.Location = new System.Drawing.Point(2, 464);
            this.OTROS.Name = "OTROS";
            this.OTROS.Size = new System.Drawing.Size(366, 67);
            this.OTROS.TabIndex = 9;
            this.OTROS.UseVisualStyleBackColor = false;
            this.OTROS.Click += new System.EventHandler(this.OTROS_Click);
            // 
            // BEBIDAS
            // 
            this.BEBIDAS.BackColor = System.Drawing.Color.Transparent;
            this.BEBIDAS.FlatAppearance.BorderSize = 0;
            this.BEBIDAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEBIDAS.Location = new System.Drawing.Point(2, 537);
            this.BEBIDAS.Name = "BEBIDAS";
            this.BEBIDAS.Size = new System.Drawing.Size(366, 67);
            this.BEBIDAS.TabIndex = 10;
            this.BEBIDAS.UseVisualStyleBackColor = false;
            this.BEBIDAS.Click += new System.EventHandler(this.BEBIDAS_Click);
            // 
            // EXTRAS
            // 
            this.EXTRAS.BackColor = System.Drawing.Color.Transparent;
            this.EXTRAS.FlatAppearance.BorderSize = 0;
            this.EXTRAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXTRAS.Location = new System.Drawing.Point(2, 610);
            this.EXTRAS.Name = "EXTRAS";
            this.EXTRAS.Size = new System.Drawing.Size(366, 67);
            this.EXTRAS.TabIndex = 11;
            this.EXTRAS.UseVisualStyleBackColor = false;
            this.EXTRAS.Click += new System.EventHandler(this.EXTRAS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(681, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Escribe el nombre del producto que quieres buscar...";
            // 
            // Administrar_precios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sushi_Lomas_restaurant.Properties.Resources.Administrar_precios;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1480, 850);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EXTRAS);
            this.Controls.Add(this.BEBIDAS);
            this.Controls.Add(this.OTROS);
            this.Controls.Add(this.ENTRADAS);
            this.Controls.Add(this.CHAROLAS);
            this.Controls.Add(this.SUSHIS);
            this.Controls.Add(this.PROMOCIONES);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Reg);
            this.Controls.Add(this.txt_nuevoPrecio);
            this.Controls.Add(this.txt_precioActual);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Administrar_precios";
            this.Text = "Administrar_precios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_precioActual;
        private System.Windows.Forms.TextBox txt_nuevoPrecio;
        private System.Windows.Forms.Button btn_Reg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PROMOCIONES;
        private System.Windows.Forms.Button SUSHIS;
        private System.Windows.Forms.Button CHAROLAS;
        private System.Windows.Forms.Button ENTRADAS;
        private System.Windows.Forms.Button OTROS;
        private System.Windows.Forms.Button BEBIDAS;
        private System.Windows.Forms.Button EXTRAS;
        private System.Windows.Forms.Label label1;
    }
}