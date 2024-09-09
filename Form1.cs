namespace CSharp_TimSNT
{
    public partial class Form1 : Form
    {
        public bool ktraSNT(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;

        }

        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapso_TextChanged(object sender, EventArgs e)
        {
            if (txtNhapso.Text != string.Empty)
            {
                string kq = string.Empty;

                if (ktraSNT(int.Parse(txtNhapso.Text)))
                {
                    txtKTSo.Text = "La SNT";
                }
                else
                {
                    txtKTSo.Text = "Khong phai SNT";
                }

                for (int i = 2; i < int.Parse(txtNhapso.Text); i++)
                {
                    if (ktraSNT(i))
                    {
                        kq += " " + i;
                    }
                    txtNhoN.Text = kq;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
