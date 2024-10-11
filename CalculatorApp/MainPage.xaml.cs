using CalculatorLib;

namespace CalculatorApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalculate(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                var number1 = Convert.ToDouble(Input1.Text);
                var number2 = Convert.ToDouble(Input2.Text);
                char operation = ((Button)sender).Text.TrimEnd().TrimStart()[0];

                try
                {
                    ResultLabel.Text = $"{number1} {operation} {number2} = {Calculator.Calculate(number1, number2, operation).ToString("F2")}";

                }

                catch(DivideByZeroException ex)
                {
                    ResultLabel.Text = ex.Message;
                }
                catch (InvalidOperationException ex)
                {
                    ResultLabel.Text = ex.Message;
                }
                catch (Exception ex)
                {
                    ResultLabel.Text = ex.Message;
                }

            }
        }

        private void CalculateAll_Clicked(object sender, EventArgs e)
        {
            double sum;
            double difference;
            double product;
            double quotient;
            double remainder;
            Calculator.Calculate(Convert.ToDouble(Input1.Text), Convert.ToDouble(Input2.Text), out sum, out difference, out product, out quotient, out remainder);
            ResultLabel.Text = $"Sum: {sum}\nDifference: {difference}\nProduct: {product}\nQuotient: {quotient:F2}\nRemainder: {remainder}";
        }
    }

}
