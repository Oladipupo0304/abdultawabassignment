Console.WriteLine("Chapter Five");
Console.WriteLine("answer to number 1.");
int firstNumber = 10; 
int secondNumber = 5; 

if (firstNumber > secondNumber)
{
    int temp = firstNumber;
    firstNumber = secondNumber;
    secondNumber = temp;
}

Console.WriteLine("answer to number 2.");
  
Console.WriteLine("answer to number 3.");
   {
        Console.WriteLine("Enter three integers:");
        
        int num1 = int.Parse(Console.ReadLine()!);
        int num2 = int.Parse(Console.ReadLine()!);
        int num3 = int.Parse(Console.ReadLine()!);

        if (num1 >= num2)
        {
            if (num1 >= num3)
            {
                Console.WriteLine("The biggest number is: " + num1);  
            }
            else
            {
                Console.WriteLine("The biggest number is: " + num3);
            }
        }
        else
        {
            if (num2 >= num3)
            {
                Console.WriteLine("The biggest number is: " + num2);
            }
            else
            {
                Console.WriteLine("The biggest number is: " + num3);
            }
        }
    }

Console.WriteLine("answer to number 4..");
{
        Console.WriteLine("Enter three real numbers:");
        
        double num1 = double.Parse(Console.ReadLine()!);
        double num2 = double.Parse(Console.ReadLine()!);
        double num3 = double.Parse(Console.ReadLine()!);

        if (num1 >= num2)
        {
            if (num1 >= num3)
            {
               
                if (num2 >= num3)
                {
                    Console.WriteLine("Sorted in descending order: " + num1 + ", " + num2 + ", " + num3);
                }
                else
                {
                    Console.WriteLine("Sorted in descending order: " + num1 + ", " + num3 + ", " + num2);
                }
            }
            else
            {
               
                Console.WriteLine("Sorted in descending order: " + num3 + ", " + num1 + ", " + num2);
            }
        }
        else
        {
            if (num2 >= num3)
            {
              
                if (num1 >= num3)
                {
                    Console.WriteLine("Sorted in descending order: " + num2 + ", " + num1 + ", " + num3);
                }
                else
                {
                    Console.WriteLine("Sorted in descending order: " + num2 + ", " + num3 + ", " + num1);
                }
            }
            else
            {
                // num3 is the largest
                Console.WriteLine("Sorted in descending order: " + num3 + ", " + num2 + ", " + num1);
            }
        }
    }
Console.WriteLine("answer to number 5.");
  {
        Console.Write("Enter a digit (0-9): ");
        int digit = int.Parse(Console.ReadLine()!);

        string digitInWords = "";

        switch (digit)
        {
            case 0:
                digitInWords = "Zero";
                break;
            case 1:
                digitInWords = "One";
                break;
            case 2:
                digitInWords = "Two";
                break;
            case 3:
                digitInWords = "Three";
                break;
            case 4:
                digitInWords = "Four";
                break;
            case 5:
                digitInWords = "Five";
                break;
            case 6:
                digitInWords = "Six";
                break;
            case 7:
                digitInWords = "Seven";
                break;
            case 8:
                digitInWords = "Eight";
                break;
            case 9:
                digitInWords = "Nine";
                break;
            default:
                Console.WriteLine("Invalid input. Please enter a digit between 0 and 9.");
                return;
        }

        Console.WriteLine($"The digit {digit} in English is: {digitInWords}");
    }

Console.WriteLine("answer to number 6.");


Console.WriteLine("answer to number 7.");

   
    {
        Console.WriteLine("Enter five numbers:");


       int[] numbers = new int[5];

   
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine()!);
        }

  
      int greatestNumber = numbers.Max();

        Console.WriteLine($"The greatest number among the five is: {greatestNumber}");
    }


Console.WriteLine("answer to number 8.");
  {
        Console.WriteLine("Please enter a variable (int, double, or string):");
        string userInput = Console.ReadLine()!;

        switch (Type.GetTypeCode(userInput.GetType()))
        {
            case TypeCode.Int32:
                int intValue = Convert.ToInt32(userInput);
                intValue++;
                Console.WriteLine("Result: " + intValue);
                break;
            case TypeCode.Double:
                double doubleValue = Convert.ToDouble(userInput);
                doubleValue++;
                Console.WriteLine("Result: " + doubleValue);
                break;
            case TypeCode.String:
                string stringValue = userInput + "*";
                Console.WriteLine("Result: " + stringValue);
                break;
            default:
                Console.WriteLine("Unsupported variable type.");
                break;
        }
    }

Console.WriteLine("answer to number 9.");

Console.WriteLine("answer to number 10.");
  {
        Console.Write("Enter a score (1-9): ");
        int score = int.Parse(Console.ReadLine()!);

        int bonus;

        if (score >= 1 && score <= 3)
        {
            bonus = score * 10;
        }
        else if (score >= 4 && score <= 6)
        {
            bonus = score * 100;
        }
        else if (score >= 7 && score <= 9)
        {
            bonus = score * 1000;
        }
        else
        {
            Console.WriteLine("Error: Invalid score! Please enter a score between 1 and 9.");
            return;
        }

        Console.WriteLine($"Score with bonus: {bonus}");
    }


Console.WriteLine("answer to number 11.");

// {
//     static string[] units = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
//     static string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
//     static string[] tens = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

//     static string NumberToWords(int num)
//     {
//         if (num == 0)
//             return units[0];

//         string words = "";
        
//         if (num / 100 > 0)
//         {
//             words += units[num / 100] + " Hundred";
//             num %= 100;
//             if (num > 0)
//                 words += " and ";
//         }

//         if (num >= 10 && num <= 19)
//         {
//             words += teens[num - 10];
//         }
//         else if (num >= 20)
//         {
//             words += tens[num / 10 - 2];
//             if (num % 10 > 0)
//                 words += " " + units[num % 10];
//         }
//         else if (num > 0)
//         {
//             words += units[num];
//         }

//         return words;
//     }

//     static void Main(string[] args)
//     {
//         Console.Write("Enter a number (0-999): ");
//         int number = int.Parse(Console.ReadLine()!);

//         if (number < 0 || number > 999)
//         {
//             Console.WriteLine("Error: Number out of range.");
//         }
//         else
//         {
//             string words = NumberToWords(number);
//             Console.WriteLine($"{number} --> \"{words}\"");
//         }
//     }
// }