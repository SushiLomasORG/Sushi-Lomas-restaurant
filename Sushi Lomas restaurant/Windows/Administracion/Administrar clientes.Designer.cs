namespace Sushi_Lomas_restaurant.Windows.Administracion
{
    partial class Administrar_clientes
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
            this.txt_filtrar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_guardarCambios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_filtrar
            // 
            this.txt_filtrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_filtrar.Location = new System.Drawing.Point(679, 140);
            this.txt_filtrar.Name = "txt_filtrar";
            this.txt_filtrar.Size = new System.Drawing.Size(493, 27);
            this.txt_filtrar.TabIndex = 0;
            this.txt_filtrar.TextChanged += new System.EventHandler(this.txt_filtrar_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(456, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(938, 465);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // btn_guardarCambios
            // 
            this.btn_guardarCambios.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardarCambios.FlatAppearance.BorderSize = 0;
            this.btn_guardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardarCambios.Location = new System.Drawing.Point(456, 686);
            this.btn_guardarCambios.Name = "btn_guardarCambios";
            this.btn_guardarCambios.Size = new System.Drawing.Size(938, 78);
            this.btn_guardarCambios.TabIndex = 2;
            this.btn_guardarCambios.UseVisualStyleBackColor = false;
            this.btn_guardarCambios.Click += new System.EventHandler(this.btn_guardarCambios_Click);
            // 
            // Administrar_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sushi_Lomas_restaurant.Properties.Resources.Administrar_clientes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1480, 850);
            this.Controls.Add(this.btn_guardarCambios);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_filtrar);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Administrar_clientes";
            this.Text = "b";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_filtrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_guardarCambios;
    }
}