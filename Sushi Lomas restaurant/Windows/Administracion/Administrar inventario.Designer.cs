namespace Sushi_Lomas_restaurant.Windows.Administracion
{
    partial class Administrar_inventario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_bajoStock = new System.Windows.Forms.Button();
            this.btn_sinStock = new System.Windows.Forms.Button();
            this.btn_todos = new System.Windows.Forms.Button();
            this.btn_imprimirTicket = new System.Windows.Forms.Button();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.btn_alimentar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(575, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 329);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_bajoStock
            // 
            this.btn_bajoStock.BackColor = System.Drawing.Color.Transparent;
            this.btn_bajoStock.FlatAppearance.BorderSize = 0;
            this.btn_bajoStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bajoStock.Location = new System.Drawing.Point(577, 86);
            this.btn_bajoStock.Name = "btn_bajoStock";
            this.btn_bajoStock.Size = new System.Drawing.Size(232, 50);
            this.btn_bajoStock.TabIndex = 1;
            this.btn_bajoStock.UseVisualStyleBackColor = false;
            this.btn_bajoStock.Click += new System.EventHandler(this.btn_bajoStock_Click);
            // 
            // btn_sinStock
            // 
            this.btn_sinStock.BackColor = System.Drawing.Color.Transparent;
            this.btn_sinStock.FlatAppearance.BorderSize = 0;
            this.btn_sinStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sinStock.Location = new System.Drawing.Point(819, 86);
            this.btn_sinStock.Name = "btn_sinStock";
            this.btn_sinStock.Size = new System.Drawing.Size(189, 50);
            this.btn_sinStock.TabIndex = 2;
            this.btn_sinStock.UseVisualStyleBackColor = false;
            this.btn_sinStock.Click += new System.EventHandler(this.btn_sinStock_Click);
            // 
            // btn_todos
            // 
            this.btn_todos.BackColor = System.Drawing.Color.Transparent;
            this.btn_todos.FlatAppearance.BorderSize = 0;
            this.btn_todos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_todos.Location = new System.Drawing.Point(1185, 86);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(88, 50);
            this.btn_todos.TabIndex = 3;
            this.btn_todos.UseVisualStyleBackColor = false;
            this.btn_todos.Click += new System.EventHandler(this.btn_todos_Click);
            // 
            // btn_imprimirTicket
            // 
            this.btn_imprimirTicket.BackColor = System.Drawing.Color.Transparent;
            this.btn_imprimirTicket.FlatAppearance.BorderSize = 0;
            this.btn_imprimirTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimirTicket.Location = new System.Drawing.Point(576, 481);
            this.btn_imprimirTicket.Name = "btn_imprimirTicket";
            this.btn_imprimirTicket.Size = new System.Drawing.Size(699, 62);
            this.btn_imprimirTicket.TabIndex = 4;
            this.btn_imprimirTicket.UseVisualStyleBackColor = false;
            this.btn_imprimirTicket.Click += new System.EventHandler(this.btn_imprimirTicket_Click);
            // 
            // txt_producto
            // 
            this.txt_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_producto.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txt_producto.Location = new System.Drawing.Point(582, 612);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(421, 36);
            this.txt_producto.TabIndex = 5;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantidad.Location = new System.Drawing.Point(1045, 616);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(209, 27);
            this.txt_cantidad.TabIndex = 6;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // btn_alimentar
            // 
            this.btn_alimentar.BackColor = System.Drawing.Color.Transparent;
            this.btn_alimentar.FlatAppearance.BorderSize = 0;
            this.btn_alimentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alimentar.Location = new System.Drawing.Point(575, 743);
            this.btn_alimentar.Name = "btn_alimentar";
            this.btn_alimentar.Size = new System.Drawing.Size(699, 62);
            this.btn_alimentar.TabIndex = 7;
            this.btn_alimentar.UseVisualStyleBackColor = false;
            this.btn_alimentar.Click += new System.EventHandler(this.btn_alimentar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(637, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "de bebidas";
            // 
            // Administrar_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sushi_Lomas_restaurant.Properties.Resources.Administrar_inventario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1480, 850);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_alimentar);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.btn_imprimirTicket);
            this.Controls.Add(this.btn_todos);
            this.Controls.Add(this.btn_sinStock);
            this.Controls.Add(this.btn_bajoStock);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Administrar_inventario";
            this.Text = "Administrar_inventario";
            this.Shown += new System.EventHandler(this.Administrar_inventario_Shown);
            this.Click += new System.EventHandler(this.Administrar_inventario_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_bajoStock;
        private System.Windows.Forms.Button btn_sinStock;
        private System.Windows.Forms.Button btn_todos;
        private System.Windows.Forms.Button btn_imprimirTicket;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Button btn_alimentar;
        private System.Windows.Forms.Label label1;
    }
}