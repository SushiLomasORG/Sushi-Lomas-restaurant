namespace Sushi_Lomas_restaurant.Windows.Generales
{
    partial class Registrar_clientes
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_telefono1 = new System.Windows.Forms.TextBox();
            this.txt_telefono2 = new System.Windows.Forms.TextBox();
            this.txt_domicilio1 = new System.Windows.Forms.TextBox();
            this.txt_domicilio2 = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.lbl_msgTelefono1 = new System.Windows.Forms.Label();
            this.lbl_msgTelefono2 = new System.Windows.Forms.Label();
            this.lbl_msgDireccion2 = new System.Windows.Forms.Label();
            this.lbl_msgDireccion1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txt_nombre.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nombre.Location = new System.Drawing.Point(779, 121);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(509, 32);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_telefono1
            // 
            this.txt_telefono1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefono1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txt_telefono1.ForeColor = System.Drawing.Color.DimGray;
            this.txt_telefono1.Location = new System.Drawing.Point(779, 256);
            this.txt_telefono1.Name = "txt_telefono1";
            this.txt_telefono1.Size = new System.Drawing.Size(509, 32);
            this.txt_telefono1.TabIndex = 3;
            this.txt_telefono1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_telefono1.TextChanged += new System.EventHandler(this.txt_telefono1_TextChanged);
            this.txt_telefono1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono1_KeyPress);
            // 
            // txt_telefono2
            // 
            this.txt_telefono2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefono2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txt_telefono2.ForeColor = System.Drawing.Color.DimGray;
            this.txt_telefono2.Location = new System.Drawing.Point(779, 319);
            this.txt_telefono2.Name = "txt_telefono2";
            this.txt_telefono2.Size = new System.Drawing.Size(509, 32);
            this.txt_telefono2.TabIndex = 4;
            this.txt_telefono2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_telefono2.TextChanged += new System.EventHandler(this.txt_telefono2_TextChanged);
            this.txt_telefono2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono2_KeyPress);
            // 
            // txt_domicilio1
            // 
            this.txt_domicilio1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_domicilio1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txt_domicilio1.ForeColor = System.Drawing.Color.DimGray;
            this.txt_domicilio1.Location = new System.Drawing.Point(779, 450);
            this.txt_domicilio1.Multiline = true;
            this.txt_domicilio1.Name = "txt_domicilio1";
            this.txt_domicilio1.Size = new System.Drawing.Size(509, 91);
            this.txt_domicilio1.TabIndex = 5;
            this.txt_domicilio1.TextChanged += new System.EventHandler(this.txt_domicilio1_TextChanged);
            // 
            // txt_domicilio2
            // 
            this.txt_domicilio2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_domicilio2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txt_domicilio2.ForeColor = System.Drawing.Color.DimGray;
            this.txt_domicilio2.Location = new System.Drawing.Point(779, 566);
            this.txt_domicilio2.Multiline = true;
            this.txt_domicilio2.Name = "txt_domicilio2";
            this.txt_domicilio2.Size = new System.Drawing.Size(509, 91);
            this.txt_domicilio2.TabIndex = 6;
            this.txt_domicilio2.TextChanged += new System.EventHandler(this.txt_domicilio2_TextChanged);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_registrar.FlatAppearance.BorderSize = 0;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Location = new System.Drawing.Point(773, 707);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(521, 70);
            this.btn_registrar.TabIndex = 7;
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // lbl_msgTelefono1
            // 
            this.lbl_msgTelefono1.AutoSize = true;
            this.lbl_msgTelefono1.BackColor = System.Drawing.Color.White;
            this.lbl_msgTelefono1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_msgTelefono1.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_msgTelefono1.Location = new System.Drawing.Point(1305, 262);
            this.lbl_msgTelefono1.Name = "lbl_msgTelefono1";
            this.lbl_msgTelefono1.Size = new System.Drawing.Size(0, 21);
            this.lbl_msgTelefono1.TabIndex = 8;
            // 
            // lbl_msgTelefono2
            // 
            this.lbl_msgTelefono2.AutoSize = true;
            this.lbl_msgTelefono2.BackColor = System.Drawing.Color.White;
            this.lbl_msgTelefono2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_msgTelefono2.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_msgTelefono2.Location = new System.Drawing.Point(1305, 323);
            this.lbl_msgTelefono2.Name = "lbl_msgTelefono2";
            this.lbl_msgTelefono2.Size = new System.Drawing.Size(0, 21);
            this.lbl_msgTelefono2.TabIndex = 9;
            // 
            // lbl_msgDireccion2
            // 
            this.lbl_msgDireccion2.AutoSize = true;
            this.lbl_msgDireccion2.BackColor = System.Drawing.Color.White;
            this.lbl_msgDireccion2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_msgDireccion2.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_msgDireccion2.Location = new System.Drawing.Point(1305, 600);
            this.lbl_msgDireccion2.Name = "lbl_msgDireccion2";
            this.lbl_msgDireccion2.Size = new System.Drawing.Size(0, 21);
            this.lbl_msgDireccion2.TabIndex = 11;
            // 
            // lbl_msgDireccion1
            // 
            this.lbl_msgDireccion1.AutoSize = true;
            this.lbl_msgDireccion1.BackColor = System.Drawing.Color.White;
            this.lbl_msgDireccion1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_msgDireccion1.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_msgDireccion1.Location = new System.Drawing.Point(1305, 486);
            this.lbl_msgDireccion1.Name = "lbl_msgDireccion1";
            this.lbl_msgDireccion1.Size = new System.Drawing.Size(0, 21);
            this.lbl_msgDireccion1.TabIndex = 10;
            // 
            // Registrar_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sushi_Lomas_restaurant.Properties.Resources.Registrar_cliente;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1480, 850);
            this.Controls.Add(this.lbl_msgDireccion2);
            this.Controls.Add(this.lbl_msgDireccion1);
            this.Controls.Add(this.lbl_msgTelefono2);
            this.Controls.Add(this.lbl_msgTelefono1);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_domicilio2);
            this.Controls.Add(this.txt_domicilio1);
            this.Controls.Add(this.txt_telefono2);
            this.Controls.Add(this.txt_telefono1);
            this.Controls.Add(this.txt_nombre);
            this.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Registrar_clientes";
            this.Text = "Registrar_clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_telefono1;
        private System.Windows.Forms.TextBox txt_telefono2;
        private System.Windows.Forms.TextBox txt_domicilio1;
        private System.Windows.Forms.TextBox txt_domicilio2;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Label lbl_msgTelefono1;
        private System.Windows.Forms.Label lbl_msgTelefono2;
        private System.Windows.Forms.Label lbl_msgDireccion2;
        private System.Windows.Forms.Label lbl_msgDireccion1;
    }
}