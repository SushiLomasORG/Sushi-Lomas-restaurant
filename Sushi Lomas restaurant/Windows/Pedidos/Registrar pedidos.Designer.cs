namespace Sushi_Lomas_restaurant.Windows.Pedidos
{
    partial class Registrar_pedidos
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
            this.dataGridView_comanda = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_direccion = new System.Windows.Forms.ComboBox();
            this.PROMOCIONES = new System.Windows.Forms.Button();
            this.SUSHI = new System.Windows.Forms.Button();
            this.CHAROLAS = new System.Windows.Forms.Button();
            this.ENTRADAS = new System.Windows.Forms.Button();
            this.OTROS = new System.Windows.Forms.Button();
            this.BEBIDAS = new System.Windows.Forms.Button();
            this.EXTRAS = new System.Windows.Forms.Button();
            this.TODOS = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.btn_agregarProducto = new System.Windows.Forms.Button();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.txt_productoSeleccionado = new System.Windows.Forms.TextBox();
            this.dataGridView_producto = new System.Windows.Forms.DataGridView();
            this.txt_filtrarProducto = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_feria = new System.Windows.Forms.TextBox();
            this.txt_conCuantoPaga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_quitarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_comanda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_producto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_comanda
            // 
            this.dataGridView_comanda.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_comanda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_comanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_comanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.articulo,
            this.cantidad,
            this.precio,
            this.detalle});
            this.dataGridView_comanda.Location = new System.Drawing.Point(953, 59);
            this.dataGridView_comanda.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView_comanda.Name = "dataGridView_comanda";
            this.dataGridView_comanda.Size = new System.Drawing.Size(497, 621);
            this.dataGridView_comanda.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 50;
            // 
            // articulo
            // 
            this.articulo.HeaderText = "Articulo";
            this.articulo.Name = "articulo";
            this.articulo.ReadOnly = true;
            this.articulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.articulo.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cantidad.Width = 80;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precio.Width = 60;
            // 
            // detalle
            // 
            this.detalle.HeaderText = "Detalles";
            this.detalle.Name = "detalle";
            this.detalle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.detalle.Width = 237;
            // 
            // cmb_direccion
            // 
            this.cmb_direccion.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_direccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_direccion.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.cmb_direccion.FormattingEnabled = true;
            this.cmb_direccion.Location = new System.Drawing.Point(395, 585);
            this.cmb_direccion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_direccion.Name = "cmb_direccion";
            this.cmb_direccion.Size = new System.Drawing.Size(522, 53);
            this.cmb_direccion.TabIndex = 1;
            this.cmb_direccion.SelectedIndexChanged += new System.EventHandler(this.cmb_direccion_SelectedIndexChanged);
            // 
            // PROMOCIONES
            // 
            this.PROMOCIONES.BackColor = System.Drawing.Color.Transparent;
            this.PROMOCIONES.FlatAppearance.BorderSize = 0;
            this.PROMOCIONES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PROMOCIONES.ForeColor = System.Drawing.Color.Snow;
            this.PROMOCIONES.Location = new System.Drawing.Point(-4, 71);
            this.PROMOCIONES.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PROMOCIONES.Name = "PROMOCIONES";
            this.PROMOCIONES.Size = new System.Drawing.Size(372, 67);
            this.PROMOCIONES.TabIndex = 4;
            this.PROMOCIONES.UseVisualStyleBackColor = false;
            this.PROMOCIONES.Click += new System.EventHandler(this.PROMOCIONES_Click);
            // 
            // SUSHI
            // 
            this.SUSHI.BackColor = System.Drawing.Color.Transparent;
            this.SUSHI.FlatAppearance.BorderSize = 0;
            this.SUSHI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SUSHI.ForeColor = System.Drawing.Color.Snow;
            this.SUSHI.Location = new System.Drawing.Point(-4, 143);
            this.SUSHI.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SUSHI.Name = "SUSHI";
            this.SUSHI.Size = new System.Drawing.Size(372, 67);
            this.SUSHI.TabIndex = 5;
            this.SUSHI.UseVisualStyleBackColor = false;
            this.SUSHI.Click += new System.EventHandler(this.SUSHI_Click);
            // 
            // CHAROLAS
            // 
            this.CHAROLAS.BackColor = System.Drawing.Color.Transparent;
            this.CHAROLAS.FlatAppearance.BorderSize = 0;
            this.CHAROLAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHAROLAS.ForeColor = System.Drawing.Color.Snow;
            this.CHAROLAS.Location = new System.Drawing.Point(-4, 216);
            this.CHAROLAS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CHAROLAS.Name = "CHAROLAS";
            this.CHAROLAS.Size = new System.Drawing.Size(372, 67);
            this.CHAROLAS.TabIndex = 6;
            this.CHAROLAS.UseVisualStyleBackColor = false;
            this.CHAROLAS.Click += new System.EventHandler(this.CHAROLAS_Click);
            // 
            // ENTRADAS
            // 
            this.ENTRADAS.BackColor = System.Drawing.Color.Transparent;
            this.ENTRADAS.FlatAppearance.BorderSize = 0;
            this.ENTRADAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ENTRADAS.ForeColor = System.Drawing.Color.Snow;
            this.ENTRADAS.Location = new System.Drawing.Point(-4, 288);
            this.ENTRADAS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ENTRADAS.Name = "ENTRADAS";
            this.ENTRADAS.Size = new System.Drawing.Size(372, 67);
            this.ENTRADAS.TabIndex = 7;
            this.ENTRADAS.UseVisualStyleBackColor = false;
            this.ENTRADAS.Click += new System.EventHandler(this.ENTRADAS_Click);
            // 
            // OTROS
            // 
            this.OTROS.BackColor = System.Drawing.Color.Transparent;
            this.OTROS.FlatAppearance.BorderSize = 0;
            this.OTROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OTROS.ForeColor = System.Drawing.Color.Snow;
            this.OTROS.Location = new System.Drawing.Point(-4, 363);
            this.OTROS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OTROS.Name = "OTROS";
            this.OTROS.Size = new System.Drawing.Size(372, 67);
            this.OTROS.TabIndex = 8;
            this.OTROS.UseVisualStyleBackColor = false;
            this.OTROS.Click += new System.EventHandler(this.OTROS_Click);
            // 
            // BEBIDAS
            // 
            this.BEBIDAS.BackColor = System.Drawing.Color.Transparent;
            this.BEBIDAS.FlatAppearance.BorderSize = 0;
            this.BEBIDAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BEBIDAS.ForeColor = System.Drawing.Color.Snow;
            this.BEBIDAS.Location = new System.Drawing.Point(-4, 435);
            this.BEBIDAS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BEBIDAS.Name = "BEBIDAS";
            this.BEBIDAS.Size = new System.Drawing.Size(372, 67);
            this.BEBIDAS.TabIndex = 9;
            this.BEBIDAS.UseVisualStyleBackColor = false;
            this.BEBIDAS.Click += new System.EventHandler(this.BEBIDAS_Click);
            // 
            // EXTRAS
            // 
            this.EXTRAS.BackColor = System.Drawing.Color.Transparent;
            this.EXTRAS.FlatAppearance.BorderSize = 0;
            this.EXTRAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXTRAS.ForeColor = System.Drawing.Color.Snow;
            this.EXTRAS.Location = new System.Drawing.Point(-4, 507);
            this.EXTRAS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EXTRAS.Name = "EXTRAS";
            this.EXTRAS.Size = new System.Drawing.Size(372, 67);
            this.EXTRAS.TabIndex = 10;
            this.EXTRAS.UseVisualStyleBackColor = false;
            this.EXTRAS.Click += new System.EventHandler(this.EXTRAS_Click);
            // 
            // TODOS
            // 
            this.TODOS.BackColor = System.Drawing.Color.Transparent;
            this.TODOS.FlatAppearance.BorderSize = 0;
            this.TODOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TODOS.ForeColor = System.Drawing.Color.Snow;
            this.TODOS.Location = new System.Drawing.Point(-4, 581);
            this.TODOS.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TODOS.Name = "TODOS";
            this.TODOS.Size = new System.Drawing.Size(372, 67);
            this.TODOS.TabIndex = 11;
            this.TODOS.UseVisualStyleBackColor = false;
            this.TODOS.Click += new System.EventHandler(this.TODOS_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.ForeColor = System.Drawing.Color.Snow;
            this.btn_cancelar.Location = new System.Drawing.Point(-4, 779);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(372, 72);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_direccion
            // 
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_direccion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_direccion.ForeColor = System.Drawing.Color.DimGray;
            this.txt_direccion.Location = new System.Drawing.Point(406, 655);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(502, 76);
            this.txt_direccion.TabIndex = 13;
            this.txt_direccion.TextChanged += new System.EventHandler(this.txt_direccion_TextChanged);
            this.txt_direccion.Enter += new System.EventHandler(this.txt_direccion_Enter);
            // 
            // btn_agregarProducto
            // 
            this.btn_agregarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregarProducto.FlatAppearance.BorderSize = 0;
            this.btn_agregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarProducto.ForeColor = System.Drawing.Color.Snow;
            this.btn_agregarProducto.Location = new System.Drawing.Point(406, 447);
            this.btn_agregarProducto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_agregarProducto.Name = "btn_agregarProducto";
            this.btn_agregarProducto.Size = new System.Drawing.Size(502, 51);
            this.btn_agregarProducto.TabIndex = 14;
            this.btn_agregarProducto.UseVisualStyleBackColor = false;
            this.btn_agregarProducto.Click += new System.EventHandler(this.btn_agregarProducto_Click);
            // 
            // txt_detalle
            // 
            this.txt_detalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_detalle.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txt_detalle.ForeColor = System.Drawing.Color.DimGray;
            this.txt_detalle.Location = new System.Drawing.Point(406, 356);
            this.txt_detalle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_detalle.Multiline = true;
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(502, 65);
            this.txt_detalle.TabIndex = 15;
            this.txt_detalle.Enter += new System.EventHandler(this.txt_detalle_Enter);
            this.txt_detalle.Leave += new System.EventHandler(this.txt_detalle_Leave);
            // 
            // txt_productoSeleccionado
            // 
            this.txt_productoSeleccionado.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_productoSeleccionado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_productoSeleccionado.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txt_productoSeleccionado.ForeColor = System.Drawing.Color.DimGray;
            this.txt_productoSeleccionado.Location = new System.Drawing.Point(395, 267);
            this.txt_productoSeleccionado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_productoSeleccionado.Name = "txt_productoSeleccionado";
            this.txt_productoSeleccionado.Size = new System.Drawing.Size(522, 27);
            this.txt_productoSeleccionado.TabIndex = 16;
            this.txt_productoSeleccionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView_producto
            // 
            this.dataGridView_producto.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_producto.Location = new System.Drawing.Point(395, 101);
            this.dataGridView_producto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView_producto.Name = "dataGridView_producto";
            this.dataGridView_producto.Size = new System.Drawing.Size(522, 152);
            this.dataGridView_producto.TabIndex = 17;
            this.dataGridView_producto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_producto_CellClick);
            // 
            // txt_filtrarProducto
            // 
            this.txt_filtrarProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_filtrarProducto.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txt_filtrarProducto.ForeColor = System.Drawing.Color.DimGray;
            this.txt_filtrarProducto.Location = new System.Drawing.Point(406, 59);
            this.txt_filtrarProducto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_filtrarProducto.Name = "txt_filtrarProducto";
            this.txt_filtrarProducto.Size = new System.Drawing.Size(502, 27);
            this.txt_filtrarProducto.TabIndex = 18;
            this.txt_filtrarProducto.TextChanged += new System.EventHandler(this.txt_filtrarProducto_TextChanged);
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.Transparent;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Location = new System.Drawing.Point(1414, 787);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(50, 40);
            this.btn_OK.TabIndex = 19;
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.txt_feria);
            this.panel1.Controls.Add(this.txt_conCuantoPaga);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_total);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(395, 767);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 85);
            this.panel1.TabIndex = 20;
            // 
            // txt_feria
            // 
            this.txt_feria.BackColor = System.Drawing.Color.White;
            this.txt_feria.ForeColor = System.Drawing.Color.DimGray;
            this.txt_feria.Location = new System.Drawing.Point(615, 31);
            this.txt_feria.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_feria.Name = "txt_feria";
            this.txt_feria.Size = new System.Drawing.Size(149, 34);
            this.txt_feria.TabIndex = 5;
            this.txt_feria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_conCuantoPaga
            // 
            this.txt_conCuantoPaga.BackColor = System.Drawing.Color.White;
            this.txt_conCuantoPaga.ForeColor = System.Drawing.Color.DimGray;
            this.txt_conCuantoPaga.Location = new System.Drawing.Point(435, 31);
            this.txt_conCuantoPaga.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_conCuantoPaga.Name = "txt_conCuantoPaga";
            this.txt_conCuantoPaga.Size = new System.Drawing.Size(149, 34);
            this.txt_conCuantoPaga.TabIndex = 4;
            this.txt_conCuantoPaga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_conCuantoPaga.TextChanged += new System.EventHandler(this.txt_conCuantoPaga_TextChanged);
            this.txt_conCuantoPaga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_conCuantoPaga_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(622, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Feria del cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(431, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "¿Con cuanto paga?";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_total.ForeColor = System.Drawing.Color.Snow;
            this.lbl_total.Location = new System.Drawing.Point(171, 21);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(120, 41);
            this.lbl_total.TabIndex = 1;
            this.lbl_total.Text = "$10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL MX:";
            // 
            // btn_quitarProducto
            // 
            this.btn_quitarProducto.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_quitarProducto.FlatAppearance.BorderSize = 0;
            this.btn_quitarProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitarProducto.ForeColor = System.Drawing.Color.Snow;
            this.btn_quitarProducto.Location = new System.Drawing.Point(953, 683);
            this.btn_quitarProducto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_quitarProducto.Name = "btn_quitarProducto";
            this.btn_quitarProducto.Size = new System.Drawing.Size(497, 47);
            this.btn_quitarProducto.TabIndex = 21;
            this.btn_quitarProducto.Text = "Quitar producto de la lista";
            this.btn_quitarProducto.UseVisualStyleBackColor = false;
            this.btn_quitarProducto.Click += new System.EventHandler(this.btn_quitarProducto_Click);
            // 
            // Registrar_pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sushi_Lomas_restaurant.Properties.Resources.Registrar_pedidos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1480, 851);
            this.Controls.Add(this.btn_quitarProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txt_filtrarProducto);
            this.Controls.Add(this.dataGridView_producto);
            this.Controls.Add(this.txt_productoSeleccionado);
            this.Controls.Add(this.txt_detalle);
            this.Controls.Add(this.btn_agregarProducto);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.TODOS);
            this.Controls.Add(this.EXTRAS);
            this.Controls.Add(this.BEBIDAS);
            this.Controls.Add(this.OTROS);
            this.Controls.Add(this.ENTRADAS);
            this.Controls.Add(this.CHAROLAS);
            this.Controls.Add(this.SUSHI);
            this.Controls.Add(this.PROMOCIONES);
            this.Controls.Add(this.cmb_direccion);
            this.Controls.Add(this.dataGridView_comanda);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Registrar_pedidos";
            this.Text = "Registrar_pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_comanda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_producto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_comanda;
        private System.Windows.Forms.ComboBox cmb_direccion;
        private System.Windows.Forms.Button PROMOCIONES;
        private System.Windows.Forms.Button SUSHI;
        private System.Windows.Forms.Button CHAROLAS;
        private System.Windows.Forms.Button ENTRADAS;
        private System.Windows.Forms.Button OTROS;
        private System.Windows.Forms.Button BEBIDAS;
        private System.Windows.Forms.Button EXTRAS;
        private System.Windows.Forms.Button TODOS;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Button btn_agregarProducto;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.TextBox txt_productoSeleccionado;
        private System.Windows.Forms.DataGridView dataGridView_producto;
        private System.Windows.Forms.TextBox txt_filtrarProducto;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_feria;
        private System.Windows.Forms.TextBox txt_conCuantoPaga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_quitarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
    }
}