namespace Sushi_Lomas_restaurant.Windows.Generales
{
    partial class Registrar_gastos_y_compras
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_gasto = new System.Windows.Forms.Button();
            this.btn_compra = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.txt_cantProducto = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quitar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.Transparent;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Location = new System.Drawing.Point(1353, 98);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(41, 40);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_registrar.FlatAppearance.BorderSize = 0;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Location = new System.Drawing.Point(436, 736);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(970, 66);
            this.btn_registrar.TabIndex = 5;
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_gasto
            // 
            this.btn_gasto.BackColor = System.Drawing.Color.Transparent;
            this.btn_gasto.FlatAppearance.BorderSize = 0;
            this.btn_gasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gasto.Location = new System.Drawing.Point(0, 173);
            this.btn_gasto.Name = "btn_gasto";
            this.btn_gasto.Size = new System.Drawing.Size(367, 66);
            this.btn_gasto.TabIndex = 6;
            this.btn_gasto.UseVisualStyleBackColor = false;
            this.btn_gasto.Click += new System.EventHandler(this.btn_gasto_Click);
            // 
            // btn_compra
            // 
            this.btn_compra.BackColor = System.Drawing.Color.Transparent;
            this.btn_compra.FlatAppearance.BorderSize = 0;
            this.btn_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_compra.Location = new System.Drawing.Point(0, 248);
            this.btn_compra.Name = "btn_compra";
            this.btn_compra.Size = new System.Drawing.Size(367, 66);
            this.btn_compra.TabIndex = 7;
            this.btn_compra.UseVisualStyleBackColor = false;
            this.btn_compra.Click += new System.EventHandler(this.btn_compra_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Concepto,
            this.cantProducto,
            this.precio,
            this.quitar});
            this.dataGridView1.Location = new System.Drawing.Point(436, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(970, 547);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(927, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 67);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(-1, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cant. producto";
            // 
            // txt_concepto
            // 
            this.txt_concepto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_concepto.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txt_concepto.Location = new System.Drawing.Point(456, 109);
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Size = new System.Drawing.Size(435, 32);
            this.txt_concepto.TabIndex = 10;
            // 
            // txt_cantProducto
            // 
            this.txt_cantProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantProducto.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txt_cantProducto.Location = new System.Drawing.Point(932, 109);
            this.txt_cantProducto.Name = "txt_cantProducto";
            this.txt_cantProducto.Size = new System.Drawing.Size(166, 32);
            this.txt_cantProducto.TabIndex = 11;
            this.txt_cantProducto.TextChanged += new System.EventHandler(this.txt_cantProducto_TextChanged);
            // 
            // txt_precio
            // 
            this.txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_precio.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txt_precio.Location = new System.Drawing.Point(1131, 106);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(166, 32);
            this.txt_precio.TabIndex = 12;
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "Concepto...";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // cantProducto
            // 
            this.cantProducto.HeaderText = "Cant. producto";
            this.cantProducto.Name = "cantProducto";
            this.cantProducto.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Cantidad ($)";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // quitar
            // 
            this.quitar.HeaderText = "Quitar";
            this.quitar.Name = "quitar";
            this.quitar.ReadOnly = true;
            // 
            // Registrar_gastos_y_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sushi_Lomas_restaurant.Properties.Resources.Registro_de_gastos_y_compras;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1480, 850);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_cantProducto);
            this.Controls.Add(this.txt_concepto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_compra);
            this.Controls.Add(this.btn_gasto);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_OK);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Registrar_gastos_y_compras";
            this.Text = "Registrar_gastos_y_compras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_gasto;
        private System.Windows.Forms.Button btn_compra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.TextBox txt_cantProducto;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewButtonColumn quitar;
    }
}