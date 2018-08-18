namespace FizzBuzz2
{
    public class FizzBuzzer
    {
        public string FizzBuzz(int input)
        {
            if (IsMultipleOf3(input) && IsMultipleOf5(input))
            {
                return "FizzBuzz";
            }

            if (IsMultipleOf3(input))
            {
                return "Fizz";
            }

            if (IsMultipleOf5(input))
            {
                return "Buzz";
            }

            return input.ToString();
        }

        private bool IsMultipleOf3(int number)
        {
            return number % 3 == 0;
        }

        private bool IsMultipleOf5(int number)
        {
            return number % 5 == 0;
        }
    }
}