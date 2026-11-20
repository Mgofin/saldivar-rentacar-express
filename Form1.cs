namespace Examen_Rentar_Manuel
{
    public partial class Form1 : Form
    {
        decimal subtotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSubtotal.Text = "RD$ 0.00";
            lblDescuento.Text = "RD$ 0.00";
            lblDomicilio.Text = "RD$ 0.00";
            lblItbis.Text = "RD$ 0.00";
            lblTotal.Text = "RD$ 0.00";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal tarifa = Convert.ToDecimal(txtTarifa.Text);

            if (rbtCompleto.Checked)
            {
                tarifa += 300;
            }

            if (chkGps.Checked)
            {
                tarifa += 100;
            }

            int dias = Convert.ToInt32(nudDias.Value);

            decimal totalLinea = tarifa * dias;

            string vehiculo = txtVehiculo.Text;

            if (rbtCompleto.Checked)
            {
                vehiculo += " (Completo)";
            }

            if (chkGps.Checked)
            {
                vehiculo += " (GPS)";
            }

            string linea =
                dias.ToString() + "    " +
                vehiculo + "    " +
                tarifa.ToString("N2") + "    " +
                totalLinea.ToString("N2");

            lstAlquileres.Items.Add(linea);

            subtotal += totalLinea;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal descuento = 0;

            if (chkCorporativo.Checked)
            {
                descuento = subtotal * 0.15m;
            }

            decimal domicilio = 0;

            if (rbtDomicilio.Checked)
            {
                domicilio = 500;
            }

            decimal baseImponible =
                subtotal - descuento + domicilio;

            decimal itbis =
                baseImponible * 0.18m;

            decimal total =
                baseImponible + itbis;

            lblSubtotal.Text =
                "RD$ " + subtotal.ToString("N2");

            lblDescuento.Text =
                "RD$ " + descuento.ToString("N2");

            lblDomicilio.Text =
                "RD$ " + domicilio.ToString("N2");

            lblItbis.Text =
                "RD$ " + itbis.ToString("N2");

            lblTotal.Text =
                "RD$ " + total.ToString("N2");
        }

        private void lstAlquileres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstAlquileres_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtVehiculo.Clear();
            txtTarifa.Clear();

            nudDias.Value = 1;

            chkCorporativo.Checked = false;
            chkGps.Checked = false;

            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;

            lstAlquileres.Items.Clear();

            subtotal = 0;

            lblSubtotal.Text = "RD$ 0.00";
            lblDescuento.Text = "RD$ 0.00";
            lblDomicilio.Text = "RD$ 0.00";
            lblItbis.Text = "RD$ 0.00";
            lblTotal.Text = "RD$ 0.00";

            txtCliente.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

