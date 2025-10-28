namespace Sushi_Lomas_restaurant.Windows.Pedidos
{
    partial class Ingresar_telefono
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
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Telefono.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txt_Telefono.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Telefono.Location = new System.Drawing.Point(66, 157);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(382, 32);
            this.txt_Telefono.TabIndex = 0;
            this.txt_Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Telefono.TextChanged += new System.EventHandler(this.txt_Telefono_TextChanged);
            this.txt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefono_KeyPress);
            // 
            // txt_cliente
            // 
            this.txt_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cliente.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txt_cliente.ForeColor = System.Drawing.Color.Gray;
            this.txt_cliente.Location = new System.Drawing.Point(66, 220);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(382, 32);
            this.txt_cliente.TabIndex = 0;
            this.txt_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cliente_KeyPress);
            // 
            // btn_continuar
            // 
            this.btn_continuar.BackColor = System.Drawing.Color.Transparent;
            this.btn_continuar.FlatAppearance.BorderSize = 0;
            this.btn_continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continuar.Location = new System.Drawing.Point(52, 339);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(407, 62);
            this.btn_continuar.TabIndex = 0;
            this.btn_continuar.UseVisualStyleBackColor = false;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // Ingresar_telefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sushi_Lomas_restaurant.Properties.Resources.Ingresar_teléfono;
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.Controls.Add(this.btn_continuar);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.txt_Telefono);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Ingresar_telefono";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Ingresar_telefono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Button btn_continuar;
    }
}