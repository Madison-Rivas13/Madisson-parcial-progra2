namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double montoPrestamo = Convert.ToDouble(txtMontoPrestamo.Text);
            double tasaInteresAnual = Convert.ToDouble(txtTasaInteres.Text) / 100;
            int mesesPlazo = Convert.ToInt32(txtPlazoMeses.Text);

            
            double tasaInteresMensual = tasaInteresAnual / 12;

            double cuotaMensual = (montoPrestamo * tasaInteresMensual) / (1 - Math.Pow(1 + tasaInteresMensual, -mesesPlazo));

            lblCuotaMensual.Text = $"Cuota Mensual: {cuotaMensual.ToString("C")}";

           
            double totalPagado = cuotaMensual * mesesPlazo;
            lblTotalPagado.Text = $"Total Pagado: {totalPagado.ToString("C")}";

            
            double totalIntereses = totalPagado - montoPrestamo;
            lblTotalIntereses.Text = $"Total Intereses Pagados: {totalIntereses.ToString("C")}";
        }
    }
}
       