namespace Activity_7
{
    public partial class approximatePI : Form
    {
        public approximatePI()
        {
            InitializeComponent();
        }

        private void termBox_TextChanged(object sender, EventArgs e)
        {
            int numTerms;
            
            if(int.TryParse(termBox.Text, out numTerms) && numTerms > 0)
            {
                piLabel.Text = "Approximate the value of PI after " + numTerms + " terms:";
                calcButton.Enabled = true;
            }

            else
            {
                MessageBox.Show("Term box must hold a positive integer.");
            }
        }

        private void calcButton_Click(object sender, EventArgs e)
        {

            double numerator = 4;
            double denominator = 1;

            int numTerms;
            int.TryParse(termBox.Text, out numTerms);

            double pi = 0;

            for (int i = 1; i < numTerms; i++)
            {
                if (i % 2 != 0)
                {
                    pi += numerator/denominator;
                }

                else
                {
                    pi -= numerator/denominator;
                }

                denominator += 2;
            }

            //display results in textbox
            piBox.Text = " " + pi;
        }

       
    }
}