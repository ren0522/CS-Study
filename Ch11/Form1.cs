namespace Ch11
{
    public partial class btnForm3 : Form
    {
        public btnForm3()
        {
            InitializeComponent();
        }

        private void lbuid_Click(object sender, EventArgs e)
        {
            string uid = txtid.Text;
            lbuid.Text = "��� : "+uid;
        }

        private void btnfruit_Click(object sender, EventArgs e)
        {
            CheckBox[] chbfruits = { chbfruit1, chbfruit2, chbfruit3, chbfruit4, chbfruit5 };

            List<string> fruits = new List<string>();

            foreach (CheckBox chb in chbfruits)
            {
                if (chb.Checked)
                {
                    fruits.Add(chb.Text);
                }
            }

            lbResultFruit.Text = "������ ���� : " + String.Join(", ",fruits);
        }

        private void btnGender_Click(object sender, EventArgs e)
        {
            if (rdMale.Checked)
            {
                lbResultGender.Text = "��� : ����";
            }
            else
            {
                lbResultGender.Text = "��� : ����";
            }
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            if (rdYear1.Checked)
            {
                lbResultYear.Text = "��� : 1�г�";
            }
            else if(rdYear2.Checked)
            {
                lbResultYear.Text = "��� : 2�г�";

            }
            else if (rdYear3.Checked)
            {
                lbResultYear.Text = "��� : 3�г�";

            }
            else if (rdYear4.Checked)
            {
                lbResultYear.Text = "��� : 4�г�";

            }
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}