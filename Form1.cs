namespace CodiceFiscalatore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            var p = new Person() { Name = txtb_name.Text, Surname = txtb_surname.Text};
           
            lbl_cf.Text = p.GetCodiceFiscale();
        }
    }
}