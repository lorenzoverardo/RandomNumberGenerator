using System;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made with love by github.com/lorenzoverardo", "About");
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            generatedNumberTextBox.Text = String.Empty;

            try
            {
                Convert.ToInt32(lowerBoundTextBox.Text);
                Convert.ToInt32(upperBoundTextBox.Text);
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("The maximum value must be an integer in the [-2.147.483.648, 2.147.483.646] range!", "Error");
                lowerBoundTextBox.Clear();
                upperBoundTextBox.Clear();
                return;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please insert two valid numbers!", "Error");
                lowerBoundTextBox.Clear();
                upperBoundTextBox.Clear();
                return;
            }

            Int32.TryParse((lowerBoundTextBox.Text), out int lowerBound);
            Int32.TryParse((upperBoundTextBox.Text), out int upperBound);

            if (lowerBound > upperBound)
            {
                MessageBox.Show("Lower bound can't be higher than upper bound!", "Error");
                return;
            }
            else
            {
                Random random = new Random();
                int generatedNumber = 0;

                try
                {
                    generatedNumber = random.Next(lowerBound, upperBound + 1);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    MessageBox.Show("The maximum value must be an integer in the [-2.147.483.648, 2.147.483.646] range!", "Error");
                    lowerBoundTextBox.Clear();
                    upperBoundTextBox.Clear();
                    return;
                }

                generatedNumberTextBox.Text = Convert.ToString(generatedNumber);
            }
        }

        // https://stackoverflow.com/questions/2800896/how-to-make-a-textbox-non-selectable-using-c-sharp
        private void generatedNumberTextBox_Enter(object sender, EventArgs e)
        {
            ActiveControl = lowerBoundLabel;
        }

        private void copyPictureBox_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(generatedNumberTextBox.Text))
                Clipboard.SetText(generatedNumberTextBox.Text);
        }
    }
}
