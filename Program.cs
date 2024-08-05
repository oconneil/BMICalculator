namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the BMI Calculator!");

            // Input height
            double height = GetValidNumber("Enter your height in centimeter: ") / 100;

            // Input weight
            double weight = GetValidNumber("Enter your weight in kilograms: ");

            // Calculate BMI
            double bmi = weight / (height * height);

            // Display the result
            Console.WriteLine($"Your BMI is {bmi:F2}");

            // Determine BMI category
            if (bmi < 18.5)
            {
                Console.WriteLine("You are underweight.");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("You have a normal weight.");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("You are overweight.");
            }
            else
            {
                Console.WriteLine("You are obese.");
            }
        }
        static double GetValidNumber(string prompt)
        {
            double number = 0;
            string input;
            bool isValidNumber = false;

            while (!isValidNumber || number == 0)
            {
                Console.Write(prompt);
                input = Console.ReadLine()!;
                isValidNumber = double.TryParse(input, out number);
                if (!isValidNumber || number == 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            return number;
        }
    }
}