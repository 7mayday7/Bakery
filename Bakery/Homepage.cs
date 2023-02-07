namespace Bakery
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            catering_service newfrm = new catering_service();
            newfrm.Show();
        }
    }
}