using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabAssignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment1 question 1");
            A1Q1 obj1 = new A1Q1();
            obj1.Assignment1();
            Console.ReadLine();
            Console.WriteLine("Assignment1 question2");
            A1Q2 obj2 = new A1Q2();
            obj2.Assignment2();
            Console.ReadLine();
            Console.WriteLine("Assignment1 question3");
            A1Q3 obj3 = new A1Q3();
            obj3.Assignment3();
            Console.ReadLine();
            Console.WriteLine("Assignment1 question4");
            A1Q4 obj4 = new A1Q4();
            obj4.Assignment4();
            Console.ReadLine();
            Console.WriteLine("Assignment1 question5");
            A1Q5 obj5 = new A1Q5();
            obj5.Assignment5();
            Console.ReadLine();
            Console.WriteLine("Assignment1 question6");
            A1Q6 obj6 = new A1Q6();
            obj6.Assignment6();
            Console.ReadLine();
            Console.WriteLine("Assignment1 Question7");
            A1Q7 obj7 = new A1Q7();
            obj7.Assignment7();
            Console.ReadLine();
            Console.WriteLine("Assignment1 Question8");
            A1Q8 obj8 = new A1Q8();
            obj8.Assignment8();
            Console.ReadLine();

            Console.WriteLine("Assignment1 Question9");
            A1Q9 obj9 = new A1Q9();
            obj9.Assignment9();
            Console.ReadLine();

            Console.WriteLine("Assignment1 Question10");
            A1Q10 obj10 = new A1Q10();
            obj10.Assignment10();
            Console.ReadLine();

        }

    }
    /*1.Write a C# program to calculate the total price of items in a shopping cart.
        The cart contains 5 items with different prices.
        Include a 10% discount if the total price exceeds Rs. 3000
*/
    class A1Q1
    {
        public void Assignment1()
        {
            int[] prices = new int[5];
            prices[0] = 1200;
            prices[1] = 1500;
            prices[2] = 850;
            prices[3] = 950;
            prices[4] = 600;


            double totalPrice = 0;
            foreach (double price in prices)
            {
                totalPrice += price;
            }


            if (totalPrice > 3000)
            {

                double discount = totalPrice * 0.10;
                totalPrice -= discount;
                Console.WriteLine($"A 10% discount of Rs. {discount:F2} has been applied.");
            }


            Console.WriteLine($"The final total price is: Rs. {totalPrice:F2}");
        }
    }
    /*
         2.Develop a C# application that allows the user to input a temperature in Celsius and convert it to Fahrenheit.
          If the input temperature is below 0°C, display a warning message about freezing temperatures.*/
    class A1Q2
    {
        public void Assignment2()
        {

            Console.Write("Enter the temperature in Celsius: ");
            string input = Console.ReadLine();


            if (double.TryParse(input, out double celsius))
            {

                double fahrenheit = (celsius * 9 / 5) + 32;


                Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}°F");


                if (celsius < 0)
                {
                    Console.WriteLine("Warning: The temperature is below freezing point!");
                }
            }
            else
            {

                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }
    }
    /* 3. ceate a C# program that simulates a simple ATM. 
        * It should allow users to check their balance, deposit money, and withdraw money.
         Ensure that the program checks for sufficient funds before allowing a withdrawal.*/
    class A1Q3
    {
        public void Assignment3()
        {




            decimal balance = 1000.00m;

            while (true)
            {
                Console.WriteLine("Welcome to the Simple ATM");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");

                Console.Write("Please select an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":

                        Console.WriteLine($"Your current balance is: ${balance:F2}");
                        break;

                    case "2":

                        Console.Write("Enter amount to deposit: $");
                        decimal depositAmount;
                        if (decimal.TryParse(Console.ReadLine(), out depositAmount) && depositAmount > 0)
                        {
                            balance += depositAmount;
                            Console.WriteLine($"You have deposited ${depositAmount:F2}. Your new balance is ${balance:F2}.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid deposit amount. Please enter a positive number.");
                        }
                        break;

                    case "3":

                        Console.Write("Enter amount to withdraw: $");
                        decimal withdrawAmount;
                        if (decimal.TryParse(Console.ReadLine(), out withdrawAmount) && withdrawAmount > 0)
                        {
                            if (withdrawAmount <= balance)
                            {
                                balance -= withdrawAmount;
                                Console.WriteLine($"You have withdrawn ${withdrawAmount:F2}. Your new balance is ${balance:F2}.");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds. Please enter a smaller amount.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid withdrawal amount. Please enter a positive number.");
                        }
                        break;

                    case "4":

                        Console.WriteLine("Thank you for using the Simple ATM. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }

                Console.WriteLine();
                Console.ReadLine();


            }
        }
    }
    /* 4.Write a C# program to take the marks of five subjects from a user and calculate the average. 
           Based on the average, determine and display the grade(A, B, C, D, or F).*/


    class A1Q4

    {
        public void Assignment4()
        {

            int[] marks = new int[5];
            int totalMarks = 0;
            double average;
            char grade;


            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter marks for subject {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
                totalMarks += marks[i];
            }


            average = totalMarks / 5.0;


            if (average >= 90)
                grade = 'A';
            else if (average >= 80)
                grade = 'B';
            else if (average >= 70)
                grade = 'C';
            else if (average >= 60)
                grade = 'D';
            else
                grade = 'F';


            Console.WriteLine($"\nTotal Marks: {totalMarks}");
            Console.WriteLine($"Average Marks: {average:F2}");
            Console.WriteLine($"Grade: {grade}");
        }
    }
    /*  5.Develop a C# application that asks the user to enter a password.
     The password should be validated based on the following criteria: 
    at least 8 characters long, contains at least one uppercase letter,
      one lowercase letter, and one number.
      Display appropriate messages based on the validation result.*/

    class A1Q5
    {
        public void Assignment5()
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (ValidatePassword(password))
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password is invalid. It must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, and one number.");
            }
        }

        static bool ValidatePassword(string password)
        {

            if (password.Length < 8)
                return false;


            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasNumber = false;


            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpperCase = true;
                else if (char.IsLower(c))
                    hasLowerCase = true;
                else if (char.IsDigit(c))
                    hasNumber = true;

            }


            return hasUpperCase && hasLowerCase && hasNumber;
        }
    }
    /* 6.Write a C# program to calculate the fare of a taxi ride.
      The fare is calculated based on the distance traveled.
      The first 2 kilometers are charged at a flat rate (Rs. 20), 
     and any additional kilometers are charged at a per-kilometer rate.
      Include a night surcharge if the ride occurs after 10 PM.*/
    class A1Q6
    {
        public void Assignment6()
        {

            const double baseFare = 20.0;
            const double perKilometerRate = 10.0;
            const double nightSurcharge = 1.5;


            Console.Write("Enter the distance traveled (in kilometers): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the time of the ride (in 24-hour format, e.g., 22 for 10 PM): ");
            int hour = Convert.ToInt32(Console.ReadLine());


            double fare;
            if (distance <= 2)
            {
                fare = baseFare;
            }
            else
            {
                fare = baseFare + (distance - 2) * perKilometerRate;
            }


            if (hour >= 22)
            {
                fare *= nightSurcharge;
            }


            Console.WriteLine("The total fare is: Rs. " + fare);
        }
    }
    /* 7. A school tracks the attendance of students over 5 days.
     The system should be able to record attendance, calculate the total number of days attended,
      and identify if a student has perfect attendance.*/

    class A1Q7
    {
        public void Assignment7()
        {
            TrackAttendance("John Doe", new bool[] { true, true, true, true, true });
            TrackAttendance("Jane Smith", new bool[] { true, false, true, true, false });
        }

        private void TrackAttendance(string studentName, bool[] attendance)
        {
            // Calculate total days attended
            int totalDaysAttended = attendance.Count(day => day);

            // Check if the student has perfect attendance
            bool hasPerfectAttendance = attendance.All(day => day);

            // Output the results
            Console.WriteLine($"Student: {studentName}");
            Console.WriteLine($"Total Days Attended: {totalDaysAttended}");
            Console.WriteLine($"Perfect Attendance: {hasPerfectAttendance}");
            Console.WriteLine();
        }
    }

    /* 8.An individual tracks their expenses for each month in a year.
         They want to calculate the total expenses for the year and
         identify the month with the highest and lowest expenses.*/

    class A1Q8
    {
        public void Assignment8()
        {
            decimal[] expenses = { 1200m, 3000m, 1500m, 2500m, 2000m, 1600m, 1800m, 2200m, 2400m, 2700m, 3100m, 3500m };

            decimal totalExpenses = expenses.Sum();
            decimal highestExpense = expenses.Max();
            decimal lowestExpense = expenses.Min();
            int highestMonth = Array.IndexOf(expenses, highestExpense) + 1;
            int lowestMonth = Array.IndexOf(expenses, lowestExpense) + 1;

            Console.WriteLine($"Total expenses for the year: Rs. {totalExpenses:F2}");
            Console.WriteLine($"Highest expense in month {highestMonth}: Rs. {highestExpense:F2}");
            Console.WriteLine($"Lowest expense in month {lowestMonth}: Rs. {lowestExpense:F2}");
        }
    }


    /*  9.Implement a shopping cart system where a user can 
    items, remove items, and view the total price.Assume each item has a name and a price.*/

    class A1Q9
    {
        public void Assignment9()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.AddItem("Apple", 1.5m);
            cart.AddItem("Banana", 2m);
            cart.AddItem("Milk", 3.5m);
            cart.ViewCart();

            cart.RemoveItem("Banana");
            cart.ViewCart();
        }

        private class ShoppingCart
        {
            private List<Item> Items { get; set; }

            public ShoppingCart()
            {
                Items = new List<Item>();
            }

            public void AddItem(string name, decimal price)
            {
                Items.Add(new Item { Name = name, Price = price });
            }

            public void RemoveItem(string name)
            {
                Items.RemoveAll(item => item.Name == name);
            }

            public decimal TotalPrice()
            {
                return Items.Sum(item => item.Price);
            }

            public void ViewCart()
            {
                foreach (var item in Items)
                {
                    Console.WriteLine($"Item: {item.Name}, Price: ${item.Price}");
                }
                Console.WriteLine($"Total Price: ${TotalPrice()}");
            }

            private class Item
            {
                public string Name { get; set; }
                public decimal Price { get; set; }
            }
        }
    }
    /*
        10.Create a program that calculates the monthly salary of an employee based on
      their hourly wage and the number of hours worked in a week.Consider that there are 4 weeks in a month.
    */

    class A1Q10
    {
        public void Assignment10()
        {
            SalaryCalculator calculator = new SalaryCalculator(20m, 40);
            Console.WriteLine($"Monthly Salary: ${calculator.MonthlySalary()}");
        }

        private class SalaryCalculator
        {
            private decimal HourlyWage { get; set; }
            private int HoursPerWeek { get; set; }

            public SalaryCalculator(decimal hourlyWage, int hoursPerWeek)
            {
                HourlyWage = hourlyWage;
                HoursPerWeek = hoursPerWeek;
            }

            public decimal MonthlySalary()
            {
                return HourlyWage * HoursPerWeek * 4; // 4 weeks in a month
            }
        }
    }
}