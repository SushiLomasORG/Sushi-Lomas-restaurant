namespace Sushi_Lomas_restaurant
{
    partial class Identiicarse
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_mostrar_contraseña = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.DimGray;
            this.btn_login.Location = new System.Drawing.Point(28, 295);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(338, 71);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 25.25F);
            this.txt_usuario.ForeColor = System.Drawing.Color.DimGray;
            this.txt_usuario.Location = new System.Drawing.Point(28, 58);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(338, 52);
            this.txt_usuario.TabIndex = 1;
            this.txt_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Font = new System.Drawing.Font("Segoe UI", 25.25F);
            this.txt_contraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txt_contraseña.Location = new System.Drawing.Point(28, 161);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(338, 52);
            this.txt_contraseña.TabIndex = 2;
            this.txt_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_contraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_contraseña_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(21, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // cb_mostrar_contraseña
            // 
            this.cb_mostrar_contraseña.AutoSize = true;
            this.cb_mostrar_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.cb_mostrar_contraseña.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.cb_mostrar_contraseña.ForeColor = System.Drawing.Color.DimGray;
            this.cb_mostrar_contraseña.Location = new System.Drawing.Point(28, 220);
            this.cb_mostrar_contraseña.Name = "cb_mostrar_contraseña";
            this.cb_mostrar_contraseña.Size = new System.Drawing.Size(195, 27);
            this.cb_mostrar_contraseña.TabIndex = 5;
            this.cb_mostrar_contraseña.Text = "Mostrar la contraseña";
            this.cb_mostrar_contraseña.UseVisualStyleBackColor = false;
            this.cb_mostrar_contraseña.CheckedChanged += new System.EventHandler(this.cb_mostrar_contraseña_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Olvide mi contraseña";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Identiicarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 460);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_mostrar_contraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_login);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Identiicarse";
            this.Text = "Identificarse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_mostrar_contraseña;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

