namespace calculator
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))
                        txtResult.Text += num.Text;
                }
                else
                {
                    txtResult.Text += num.Text;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 550;
            txtResult.Width = 490;
        }

        private void numberOp(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            enterFirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtResult.Text);
            switch (op)
            {
                case "+":
                    txtResult.Text = (enterFirstValue + enterSecondValue).ToString();
                    break;

                case "-":
                    txtResult.Text = (enterFirstValue - enterSecondValue).ToString();
                    break;

                case "*":
                    txtResult.Text = (enterFirstValue * enterSecondValue).ToString();
                    break;

                case "/":
                    txtResult.Text = (enterFirstValue / enterSecondValue).ToString();
                    break;

                case "Mod":
                    txtResult.Text = (enterFirstValue % enterSecondValue).ToString();
                    break;
                case "Exp":
                    double i = Convert.ToDouble(txtResult.Text);
                    double j;
                    j = enterSecondValue;

                    txtResult.Text = Math.Exp(j * Math.Log(j * 4)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            String f, s;
            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);

            f = "";
            s = "";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 550;
            txtResult.Width = 490;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1050;
            txtResult.Width = 960;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;

            exitCal = MessageBox.Show("Confirm if you want to exit", "Scientific Calculator",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589976323";

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(txtResult.Text);
            logg = Math.Log10(logg);
            txtResult.Text = Convert.ToString(logg);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            sq = Math.Sqrt(sq);
            txtResult.Text = Convert.ToString(sq);
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double sh = Convert.ToDouble(txtResult.Text);
            sh = Math.Sinh(sh);
            txtResult.Text = Convert.ToString(sh);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double sn = Convert.ToDouble(txtResult.Text);
            sn = Math.Sin(sn);
            txtResult.Text = Convert.ToString(sn);

        }

        private void btnCosh_Click(object sender, EventArgs e)
        {

            double ch = Convert.ToDouble(txtResult.Text);
            ch = Math.Cosh(ch);
            txtResult.Text = Convert.ToString(ch);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {

            double cs = Convert.ToDouble(txtResult.Text);
            cs = Math.Cos(cs);
            txtResult.Text = Convert.ToString(cs);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {

            double th = Convert.ToDouble(txtResult.Text);
            th = Math.Tanh(th);
            txtResult.Text = Convert.ToString(th);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {

            double tn = Convert.ToDouble(txtResult.Text);
            tn = Math.Tan(tn);
            txtResult.Text = Convert.ToString(tn);
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtResult.Text));
            txtResult.Text = Convert.ToString(a);
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(txtResult.Text);
            lnx = Math.Log(lnx);
            txtResult.Text = Convert.ToString(lnx);
        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);
            txtResult.Text = Convert.ToString(a);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtResult.Text);
            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            txtResult.Text = Convert.ToString(i2);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 8);
        }
    }
}