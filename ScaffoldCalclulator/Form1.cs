namespace ScaffoldCalclulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double num1 = Double.Parse(textBox1.Text)*73;
            double num2 = Double.Parse(textBox2.Text)*109;
            double num3 = Double.Parse(textBox3.Text)*157;
            double num4 = Double.Parse(textBox4.Text)*207;
            double num5 = Double.Parse(textBox5.Text)*257;
            double num6 = Double.Parse(textBox6.Text)*307;
            double num7 = Double.Parse(textBox7.Text)*5;
            double num8 = Double.Parse(textBox8.Text);

            double result = ((num1 + num2 + num3 + num4 + num5 + num6 + num7) * num8)/100;
            textBox9.Text = result.ToString() + "[m2]";
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
            if(textBox1.Text =="")
            {
                textBox1.Text = "0";
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(textBox3.Text =="")
            {
                textBox3.Text = "0";
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }   
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {if (textBox5.Text == "")
            {
                textBox5.Text = "0";
            }   
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {if (textBox6.Text == "")
            {
                textBox6.Text = "0";
            }   
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox6.Text = textBox1.Text.Remove(textBox6.Text.Length - 1);
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {if (textBox7.Text == "")
            {
                textBox7.Text = "0";
            }   
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox7.Text.Remove(textBox7.Text.Length - 1);
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "0";
            }
            double parsedValue;

            if (!double.TryParse(textBox8.Text, out parsedValue))
            {
                textBox8.Text = "";
            }
        }
    }
}