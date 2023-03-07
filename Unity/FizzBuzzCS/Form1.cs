namespace FizzBuzzCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFizzBuzz_Click(object sender, EventArgs e)
        {
            int fizz = 3;
            int buzz = 5;
            int fizzBuzz = 15;

            for (int number = 1; number < 100; number++)
            {
                if (number == fizzBuzz)
                {
                    MessageBox.Show("FizzBuzz");
                    fizzBuzz = fizzBuzz + 15;
                    buzz = buzz + 5;
                    fizz = fizz + 3;
                    continue;
                }
                else if (number == buzz)
                {
                    MessageBox.Show("Buzz");
                    buzz = buzz + 5;
                    continue;
                }
                else if (number == fizz)
                {
                    MessageBox.Show("Fizz");
                    fizz = fizz + 3;
                    continue;
                }
                else MessageBox.Show(number.ToString()); 
            }
        }
    }
}