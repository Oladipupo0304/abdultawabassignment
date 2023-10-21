Console.WriteLine("===Chapter Four===");
Console.WriteLine("answer to number 1");
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine()!);

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine()!);

        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine()!);

        int sumOfNumbers = num1 + num2 + num3;

        Console.WriteLine($"The sum of the three numbers is: {sumOfNumbers}");
    }



Console.WriteLine("answer to number 2");
{
        
        Console.Write("Enter the radius of the circle: ");
        double r = double.Parse(Console.ReadLine());

      
        double circumference = 2 * Math.PI * r;

    
        double area = Math.PI * r * r;

        // Print the results
        Console.WriteLine($"The circumference of the circle is: {circumference:F2}");
        Console.WriteLine($"The area of the circle is: {area:F2}");
    }

Console.WriteLine("answer to number 3");

Console.WriteLine("answer to number 4");

Console.WriteLine("answer to number 5");
   {
        Console.Write("Enter the first Number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the second Number: ");
        int end = int.Parse(Console.ReadLine()!);

        int count = 0;

        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                count++;
                Console.WriteLine(i);
            }
        }

        Console.WriteLine($"Between {start} and {end}, there are {count} numbers with a remainder of 0 when divided by 5.");
    }

Console.WriteLine("answer to number 6");
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        double maxNumber = Math.Max(num1, num2);

        Console.WriteLine($"The greater number is: {maxNumber}");
    }
}

Console.WriteLine("answer to number 7");
   
    {
        int sum = 0;
        int numbersRead = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Enter integer #{i}: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                sum += number;
                numbersRead++;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                ++i;
            }
        }

        Console.WriteLine($"Sum of the {numbersRead} valid numbers: {sum}");
    }


Console.WriteLine("answer to number 8");
 {
        double greatest = double.MinValue;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Enter number #{i}: ");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                if (number > greatest)
                {
                    greatest = number;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                i--; // Decrement i to re-enter the same number.
            }
        }

        Console.WriteLine($"The greatest number is: {greatest}");
    }

Console.WriteLine("answer to number 9");

    {
        Console.Write("Enter the number of integers (n): ");
        int n = int.Parse(Console.ReadLine()!);

        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine()!);
            sum += number;
        }

        Console.WriteLine("The sum of the entered numbers is: " + sum);
    }


Console.WriteLine("answer to number 10");
   {
        Console.Write("Enter an integer number n: ");
        int n;

        if (int.TryParse(Console.ReadLine(), out n))
        {
            if (n >= 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Please enter a positive integer.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

Console.WriteLine("answer to number 11");
    {
        int n = 100;
        long[] fibonacci = new long[n];

        fibonacci[0] = 0;
        fibonacci[1] = 1;

        for (int i = 2; i < n; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        Console.WriteLine("The first 100 numbers in the Fibonacci sequence are:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(fibonacci[i]);
            if (i < n - 1)
                Console.Write(", ");
        }
    }

Console.WriteLine("answer to number 12");


Console.WriteLine("answer to number 13");


