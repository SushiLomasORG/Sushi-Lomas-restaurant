namespace Sushi_Lomas_restaurant.Windows.Pedidos
{
    partial class Lista_de_pedidos
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
            this.POR_ENTREGAR = new System.Windows.Forms.Button();
            this.ENTREGADO = new System.Windows.Forms.Button();
            this.TODO = new System.Windows.Forms.Button();
            this.TERMINAR_PEDIDO = new System.Windows.Forms.Button();
            this.REIMPRIMIR = new System.Windows.Forms.Button();
            this.txt_filtrar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // POR_ENTREGAR
            // 
            this.POR_ENTREGAR.BackColor = System.Drawing.Color.Transparent;
            this.POR_ENTREGAR.FlatAppearance.BorderSize = 0;
            this.POR_ENTREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.POR_ENTREGAR.Location = new System.Drawing.Point(13, 186);
            this.POR_ENTREGAR.Name = "POR_ENTREGAR";
            this.POR_ENTREGAR.Size = new System.Drawing.Size(353, 67);
            this.POR_ENTREGAR.TabIndex = 0;
            this.POR_ENTREGAR.UseVisualStyleBackColor = false;
            this.POR_ENTREGAR.Click += new System.EventHandler(this.POR_ENTREGAR_Click);
            // 
            // ENTREGADO
            // 
            this.ENTREGADO.BackColor = System.Drawing.Color.Transparent;
            this.ENTREGADO.FlatAppearance.BorderSize = 0;
            this.ENTREGADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ENTREGADO.Location = new System.Drawing.Point(13, 259);
            this.ENTREGADO.Name = "ENTREGADO";
            this.ENTREGADO.Size = new System.Drawing.Size(353, 67);
            this.ENTREGADO.TabIndex = 1;
            this.ENTREGADO.UseVisualStyleBackColor = false;
            this.ENTREGADO.Click += new System.EventHandler(this.ENTREGADO_Click);
            // 
            // TODO
            // 
            this.TODO.BackColor = System.Drawing.Color.Transparent;
            this.TODO.FlatAppearance.BorderSize = 0;
            this.TODO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TODO.Location = new System.Drawing.Point(13, 332);
            this.TODO.Name = "TODO";
            this.TODO.Size = new System.Drawing.Size(353, 67);
            this.TODO.TabIndex = 2;
            this.TODO.UseVisualStyleBackColor = false;
            this.TODO.Click += new System.EventHandler(this.TODO_Click);
            // 
            // TERMINAR_PEDIDO
            // 
            this.TERMINAR_PEDIDO.BackColor = System.Drawing.Color.Transparent;
            this.TERMINAR_PEDIDO.FlatAppearance.BorderSize = 0;
            this.TERMINAR_PEDIDO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TERMINAR_PEDIDO.Location = new System.Drawing.Point(13, 588);
            this.TERMINAR_PEDIDO.Name = "TERMINAR_PEDIDO";
            this.TERMINAR_PEDIDO.Size = new System.Drawing.Size(353, 67);
            this.TERMINAR_PEDIDO.TabIndex = 3;
            this.TERMINAR_PEDIDO.UseVisualStyleBackColor = false;
            this.TERMINAR_PEDIDO.Click += new System.EventHandler(this.TERMINAR_PEDIDO_Click);
            // 
            // REIMPRIMIR
            // 
            this.REIMPRIMIR.BackColor = System.Drawing.Color.Transparent;
            this.REIMPRIMIR.FlatAppearance.BorderSize = 0;
            this.REIMPRIMIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.REIMPRIMIR.Location = new System.Drawing.Point(396, 692);
            this.REIMPRIMIR.Name = "REIMPRIMIR";
            this.REIMPRIMIR.Size = new System.Drawing.Size(1055, 67);
            this.REIMPRIMIR.TabIndex = 4;
            this.REIMPRIMIR.UseVisualStyleBackColor = false;
            this.REIMPRIMIR.Click += new System.EventHandler(this.REIMPRIMIR_Click);
            // 
            // txt_filtrar
            // 
            this.txt_filtrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_filtrar.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txt_filtrar.Location = new System.Drawing.Point(673, 129);
            this.txt_filtrar.Name = "txt_filtrar";
            this.txt_filtrar.Size = new System.Drawing.Size(502, 36);
            this.txt_filtrar.TabIndex = 5;
            this.txt_filtrar.TextChanged += new System.EventHandler(this.txt_filtrar_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(388, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1070, 469);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Lista_de_pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sushi_Lomas_restaurant.Properties.Resources.Lista_de_pedidos;
            this.ClientSize = new System.Drawing.Size(1480, 850);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_filtrar);
            this.Controls.Add(this.REIMPRIMIR);
            this.Controls.Add(this.TERMINAR_PEDIDO);
            this.Controls.Add(this.TODO);
            this.Controls.Add(this.ENTREGADO);
            this.Controls.Add(this.POR_ENTREGAR);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Lista_de_pedidos";
            this.Text = "Lista_de_pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button POR_ENTREGAR;
        private System.Windows.Forms.Button ENTREGADO;
        private System.Windows.Forms.Button TODO;
        private System.Windows.Forms.Button TERMINAR_PEDIDO;
        private System.Windows.Forms.Button REIMPRIMIR;
        private System.Windows.Forms.TextBox txt_filtrar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}