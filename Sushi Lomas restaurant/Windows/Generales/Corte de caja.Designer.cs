namespace Sushi_Lomas_restaurant.Windows.Generales
{
    partial class Corte_de_caja
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
            this.txt_ventas = new System.Windows.Forms.TextBox();
            this.txt_gastos = new System.Windows.Forms.TextBox();
            this.txt_compras = new System.Windows.Forms.TextBox();
            this.txt_ganancias = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ventas
            // 
            this.txt_ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ventas.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txt_ventas.ForeColor = System.Drawing.Color.DimGray;
            this.txt_ventas.Location = new System.Drawing.Point(463, 100);
            this.txt_ventas.Name = "txt_ventas";
            this.txt_ventas.Size = new System.Drawing.Size(174, 32);
            this.txt_ventas.TabIndex = 0;
            this.txt_ventas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_gastos
            // 
            this.txt_gastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_gastos.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txt_gastos.ForeColor = System.Drawing.Color.DimGray;
            this.txt_gastos.Location = new System.Drawing.Point(694, 100);
            this.txt_gastos.Name = "txt_gastos";
            this.txt_gastos.Size = new System.Drawing.Size(174, 32);
            this.txt_gastos.TabIndex = 1;
            this.txt_gastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_compras
            // 
            this.txt_compras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_compras.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txt_compras.ForeColor = System.Drawing.Color.DimGray;
            this.txt_compras.Location = new System.Drawing.Point(926, 100);
            this.txt_compras.Name = "txt_compras";
            this.txt_compras.Size = new System.Drawing.Size(174, 32);
            this.txt_compras.TabIndex = 2;
            this.txt_compras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ganancias
            // 
            this.txt_ganancias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ganancias.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txt_ganancias.ForeColor = System.Drawing.Color.DimGray;
            this.txt_ganancias.Location = new System.Drawing.Point(1211, 100);
            this.txt_ganancias.Name = "txt_ganancias";
            this.txt_ganancias.Size = new System.Drawing.Size(174, 32);
            this.txt_ganancias.TabIndex = 3;
            this.txt_ganancias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_registrar.FlatAppearance.BorderSize = 0;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Location = new System.Drawing.Point(455, 717);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(937, 75);
            this.btn_registrar.TabIndex = 4;
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(455, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(938, 539);
            this.dataGridView1.TabIndex = 5;
            // 
            // Corte_de_caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sushi_Lomas_restaurant.Properties.Resources.Corte_de_caja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1480, 850);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_ganancias);
            this.Controls.Add(this.txt_compras);
            this.Controls.Add(this.txt_gastos);
            this.Controls.Add(this.txt_ventas);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Corte_de_caja";
            this.Text = "Corte_de_caja";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ventas;
        private System.Windows.Forms.TextBox txt_gastos;
        private System.Windows.Forms.TextBox txt_compras;
        private System.Windows.Forms.TextBox txt_ganancias;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}