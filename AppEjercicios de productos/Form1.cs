using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEjercicios_de_productos
{
    public partial class Form1 : Form
    {
        private List<clases.productos> Lista=new List<clases.productos>();
        public Form1()
        {
           
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clases.productos productos = new clases.productos();
            productos.Producto = this.txtProducto.Text;
            productos.Precio = this.txtPrecio.Text;
            productos.Peso = this.comboBoxPeso.Text;
            productos.cantidad = this.comboBoxCantidad.Text;

            Lista.Add(productos);


            ListViewItem item = new ListViewItem(productos.Producto);
            listViewProduct.Items.Add(item);
            item.SubItems.Add(productos.Precio);
            item.SubItems.Add(productos.Peso);
            item.SubItems.Add(productos.cantidad);




        }
    }
}
