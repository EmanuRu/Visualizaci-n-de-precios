namespace Visualización_de_precios
{
    public partial class Form1 : Form
    {
        List<String> tipo_produc;//creo una lista que va a contener los tipos de produtos que
                                 //apareceran en el combobox.
        public Form1()
        {
            tipo_produc = new List<String>();
            tipo_produc.Add("Fideos");//agrego los tipos de productos a la lista.
            tipo_produc.Add("Arroz");
            tipo_produc.Add("Gaseosas");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (String tipo in tipo_produc)
            {
                cbProductos.Items.Add(tipo);//cargo los tipos productos al combobox.

            }
        }
        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            String seleccion = (String)cbProductos.SelectedItem;//tomo el tipo de producto seleccionado.
            lvPrecio.Items.Clear();//cada vez que se selecciona un producto se limpia la lista.
            if (seleccion.Equals("Fideos"))
            {
                //creo los items que van a aparecer en la lista, siendo el item principal y dos sub items.
                ListViewItem lvi1 = new ListViewItem("Mama Luchetti");//Marca del producto.
                lvi1.SubItems.Add("Mostachol");//descripcion o informacion adicional.
                lvi1.SubItems.Add("367$");//precio.
                lvPrecio.Items.Add(lvi1);//agrego los items a la fila de la lista. 

                //apartir de aca el codidigo se repite creando items y sub items, varia solamente las
                //marcas, y cuando seleccion sea igual a fideos o gaseosas cambiara el producto. 
                ListViewItem lvi2 = new ListViewItem("KNORR");
                lvi2.SubItems.Add("Tirabuzon");
                lvi2.SubItems.Add("405$");
                lvPrecio.Items.Add(lvi2);

                ListViewItem lvi3 = new ListViewItem("Don Vicente");
                lvi3.SubItems.Add("Tallarin");
                lvi3.SubItems.Add("542$");
                lvPrecio.Items.Add(lvi3);

                ListViewItem lvi4 = new ListViewItem("KNORR");
                lvi4.SubItems.Add("Rigatti");
                lvi4.SubItems.Add("367$");
                lvPrecio.Items.Add(lvi4);
            }
            else
            {
                if (seleccion.Equals("Arroz"))
                {
                    ListViewItem lvi1 = new ListViewItem("Primor");
                    lvi1.SubItems.Add("Largo Fino");
                    lvi1.SubItems.Add("749$");
                    lvPrecio.Items.Add(lvi1);

                    ListViewItem lvi2 = new ListViewItem("Gallo");
                    lvi2.SubItems.Add("Arroz preparado mix vegetales");
                    lvi2.SubItems.Add("476$");
                    lvPrecio.Items.Add(lvi2);

                    ListViewItem lvi3 = new ListViewItem("Gallo");
                    lvi3.SubItems.Add("Arroz preparado mix de semillas");
                    lvi3.SubItems.Add("542$");
                    lvPrecio.Items.Add(lvi3);

                    ListViewItem lvi4 = new ListViewItem("Gallo");
                    lvi4.SubItems.Add("Arroz integral");
                    lvi4.SubItems.Add("309$");
                    lvPrecio.Items.Add(lvi4);
                }
                else
                {
                    if (seleccion.Equals("Gaseosas"))
                    {
                        ListViewItem lvi1 = new ListViewItem("Coca cola");
                        lvi1.SubItems.Add("sin azucar 1,5 lt");
                        lvi1.SubItems.Add("466$");
                        lvPrecio.Items.Add(lvi1);

                        ListViewItem lvi2 = new ListViewItem("pepsi");
                        lvi2.SubItems.Add("Black 1,5 lt");
                        lvi2.SubItems.Add("390$");
                        lvPrecio.Items.Add(lvi2);

                        ListViewItem lvi3 = new ListViewItem("doble cola");
                        lvi3.SubItems.Add("sabor cola 3 lt");
                        lvi3.SubItems.Add("583$");
                        lvPrecio.Items.Add(lvi3);

                        ListViewItem lvi4 = new ListViewItem("mirinda");
                        lvi4.SubItems.Add("sabor naranja 3 lt");
                        lvi4.SubItems.Add("503$");
                        lvPrecio.Items.Add(lvi4);
                    }
                }
            }
        }
    }
}