namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string total;
        int num1;
        int num2;
        string op;
        int result;
        int memory = 0;

        private void n1_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "1";
        }

        private void n2_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "2";
        }

        private void n3_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "3";
        }

        private void n4_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "4";
        }

        private void n5_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "5";
        }

        private void n6_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "6";
        }

        private void n7_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "7";
        }

        private void n8_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "8";
        }

        private void n9_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "9";
        }

        private void n0_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text + "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            op = "+";
            num1 = int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            op = "-";
            num1 = int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            op = "*";
            num1 = int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void divi_Click(object sender, EventArgs e)
        {
            op = "/";
            num1 = int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtdisplay.Text);

            if (op.Equals("+"))
                result = num1 + num2;

            if (op.Equals("-"))
                result = num1 - num2;

            if (op.Equals("*"))
                result = num1 * num2;

            if (op.Equals("/"))
                result = num1 / num2;

            txtdisplay.Text = result.ToString();
        }

        private void MS_Click(object sender, EventArgs e)
        {
            memory = int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void MC_Click(object sender, EventArgs e)
        {
            memory = 0;
            txtdisplay.Clear();
        }

        private void MPlus_Click(object sender, EventArgs e)
        {
            memory += int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void MR_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = memory.ToString();
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
                txtdisplay.Text = txtdisplay.Text.Substring(0, txtdisplay.Text.Length - 1);
        }
    }
}
