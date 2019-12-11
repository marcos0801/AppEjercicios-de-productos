namespace AppEjercicios_de_productos
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCantidad = new System.Windows.Forms.ComboBox();
            this.comboBoxPeso = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listViewProduct = new System.Windows.Forms.ListView();
            this.columnPRODUCTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPRECIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPESO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCANTIDAD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "EJERCICIO DE PRODUCTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRECIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "PESO ";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(38, 117);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(192, 22);
            this.txtProducto.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(703, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "CANTIDAD";
            // 
            // comboBoxCantidad
            // 
            this.comboBoxCantidad.FormattingEnabled = true;
            this.comboBoxCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxCantidad.Location = new System.Drawing.Point(677, 116);
            this.comboBoxCantidad.Name = "comboBoxCantidad";
            this.comboBoxCantidad.Size = new System.Drawing.Size(135, 24);
            this.comboBoxCantidad.TabIndex = 7;
            // 
            // comboBoxPeso
            // 
            this.comboBoxPeso.FormattingEnabled = true;
            this.comboBoxPeso.Items.AddRange(new object[] {
            "1/2KG",
            "1KG",
            "2KG",
            "3KG",
            "4KG",
            "5KG",
            "6KG",
            "7KG",
            "8KG",
            "9KG"});
            this.comboBoxPeso.Location = new System.Drawing.Point(462, 117);
            this.comboBoxPeso.Name = "comboBoxPeso";
            this.comboBoxPeso.Size = new System.Drawing.Size(176, 24);
            this.comboBoxPeso.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(255, 116);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(185, 22);
            this.txtPrecio.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(63, 145);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 50);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "AGREGAR LISTA";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listViewProduct
            // 
            this.listViewProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPRODUCTO,
            this.columnPRECIO,
            this.columnPESO,
            this.columnCANTIDAD});
            this.listViewProduct.HideSelection = false;
            this.listViewProduct.Location = new System.Drawing.Point(7, 211);
            this.listViewProduct.Name = "listViewProduct";
            this.listViewProduct.Size = new System.Drawing.Size(876, 188);
            this.listViewProduct.TabIndex = 11;
            this.listViewProduct.UseCompatibleStateImageBehavior = false;
            this.listViewProduct.View = System.Windows.Forms.View.Details;
            // 
            // columnPRODUCTO
            // 
            this.columnPRODUCTO.Text = "PRODUCTO";
            // 
            // columnPRECIO
            // 
            this.columnPRECIO.Text = "PRECIO";
            // 
            // columnPESO
            // 
            this.columnPESO.Text = "PESO";
            // 
            // columnCANTIDAD
            // 
            this.columnCANTIDAD.Text = "CANTIDAD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.listViewProduct);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.comboBoxPeso);
            this.Controls.Add(this.comboBoxCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCantidad;
        private System.Windows.Forms.ComboBox comboBoxPeso;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView listViewProduct;
        private System.Windows.Forms.ColumnHeader columnPRODUCTO;
        private System.Windows.Forms.ColumnHeader columnPRECIO;
        private System.Windows.Forms.ColumnHeader columnPESO;
        private System.Windows.Forms.ColumnHeader columnCANTIDAD;
    }
}

