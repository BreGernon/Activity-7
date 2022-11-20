namespace Activity_7
{
    // Breanna Gernon
    // CST-150
    // November 19, 2022
    // This is my own work, with the formula provided for the assignment.

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

            double topFraction = 4;
            double bottomFraction = 1;

            int numTerms;
            int.TryParse(termBox.Text, out numTerms);

            double pi = 0;

            //add or subtract from pi however many times the user provides
            for (int i = 1; i < numTerms; i++)
            {
                //check if i is even or odd, and then add or subtract fittingly
                if (i % 2 != 0)
                {
                    pi = pi + (topFraction/bottomFraction);
                }

                else
                {
                    pi = pi - (topFraction/bottomFraction);
                }

                //increase the bottom number of the fraction by two, like the formula describes
                bottomFraction += 2;
            }

            //display results in textbox
            piBox.Text = " " + pi;
        }

       
    }
}