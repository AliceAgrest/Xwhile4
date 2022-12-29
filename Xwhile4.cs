using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
        //q1
        //הפעולה מחזירה את מספר הפעמים שהספרה מופיעה במספר
        public static int NumberInNumber(int num, int inNum)
        {
            int count = 0;
            int oneNum = 0;

            while (num > 0)
            {
                oneNum = num % 10;
                if (oneNum == inNum)
                    count++;
                num /= 10;
            }

            return count;
        }

        //q2
        //הפעולה תחזיר מספר אקראי בתחום הערכים אותם קיבלה
        public static int RndNum(int num1, int num2)
        {
            int rnd1;
            Random rnd = new Random();
            rnd1 = rnd.Next(num1, num2);

            return rnd1;
        }

        //q3
        //פעולה מקבלת מספר שלם ומחזירה את מספר ספרותיו הזוגיות
        public static int EvenNumbers(int num)
        {
            int evenCount = 0;
            int digitNumber;

            for (int i = 0; i < num; i++)
            {
                digitNumber = num % 10;

                if (digitNumber % 2 == 0)
                    evenCount++;

                num /= 10;
            }
            return evenCount;
        }

        // q4
        //הפעולה תחזיר מספר המחלק המשותף הקטן ביותר שלהם
        //אם אין הפעולה תחזיר -1
        public static int DividesNum(int num1, int num2)
        {
            int i = 2;
            int min = Math.Min(num1, num2);

            while (((num1 % i > 0) || (num2 % i > 0)) && (i <= min))
            {
                i++;
            }
            if ((num1 % i != 0) && (num2 % i != 0))
                i = -1;

            return i;
        }

        //q5
        //הפעולה מחזירה נכון אם זה אות 
        //ואם זה תו מחזירה לא נכון
        public static string AbcChecker(char a)
        {
            string v = "True";
            string v1 = "False";
            if ((a >= 'a' && a <= 'z') || (a >= 'A' && a <= 'Z'))
                return v;
            else
                return v1;
        }

        //q6
        //חישוב של נוסחה הדומה לנוסחת פיבונאצ'י
        public static int StoppedCal(int x, int i)
        {
            int count;
            count = i * x;
            return count;
        }
    
    class Program
    {
        //q1
        //הפעולה מחזירה את מספר הפעמים שהספרה מופיעה במספר
        public static int NumberInNumber(int num, int inNum)
        {
            int count = 0;
            int oneNum = 0;

            while (num > 0)
            {
                oneNum = num % 10;
                if (oneNum == inNum)
                    count++;
                num /= 10;
            }

            return count;
        }

        //q2
        //הפעולה תחזיר מספר אקראי בתחום הערכים אותם קיבלה
        public static int RndNum(int num1, int num2)
        {
            int rnd1;
            Random rnd = new Random();
            rnd1 = rnd.Next(num1, num2);

            return rnd1;
        }

        //q3
        //פעולה מקבלת מספר שלם ומחזירה את מספר ספרותיו הזוגיות
        public static int EvenNumbers(int num)
        {
            int evenCount = 0;
            int digitNumber;

            for (int i = 0; i < num; i++)
            {
                digitNumber = num % 10;

                if (digitNumber % 2 == 0)
                    evenCount++;

                num /= 10;
            }
            return evenCount;
        }

        // q4
        //הפעולה תחזיר מספר המחלק המשותף הקטן ביותר שלהם
        //אם אין הפעולה תחזיר -1
        public static int DividesNum(int num1, int num2)
        {
            int i = 2;
            int min = Math.Min(num1, num2);

            while (((num1 % i > 0) || (num2 % i > 0)) && (i <= min))
            {
                i++;
            }
            if ((num1 % i != 0) && (num2 % i != 0))
                i = -1;

            return i;
        }

        //q5
        //הפעולה מחזירה נכון אם זה אות 
        //ואם זה תו מחזירה לא נכון
        public static string AbcChecker(char a)
        {
            string v = "True";
            string v1 = "False";
            if ((a >= 'a' && a <= 'z') || (a >= 'A' && a <= 'Z'))
                return v;
            else
                return v1;
        }

        //q6
        //
        public static int StoppedCal(int x, int i)
        {
            int count;
            count = i * x;
            return count;
            //x = count;
            /*for (int i = 1; i <= num; i++)
            {
                count = i * x;
                return count;
                x = count;
            }*/
            //return;
        }

        static void Main(string[] args)
        {
            //q1
            /*int digit;

            digit = NumberInNumber(1024 , 0);
            Console.WriteLine(digit);

            digit = NumberInNumber(33546, 3);
            Console.WriteLine(digit);

            digit = NumberInNumber(1457 , 0);
            Console.WriteLine(digit);

            digit = NumberInNumber(10000 , 1);
            Console.WriteLine(digit);
            
            //q3
            int num1, num = 1;

            Console.WriteLine("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());

            int show1 = EvenNumbers(num1);

            while (num > 0)
            {
                Console.WriteLine("Enter a number: ");
                num = int.Parse(Console.ReadLine());

                int show = EvenNumbers(num);

                if (num > num1)
                    num1 = num;
            }
            Console.WriteLine(num1);
            
            //q4
            int num1, num2;

            Console.WriteLine("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            num2 = int.Parse(Console.ReadLine());

            int show = DividesNum(num1, num2);
            Console.WriteLine(show);
            
            //q5
            */

            //q6
            int num, x = 1, count = 0;

            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                count = StoppedCal(i, x);
                Console.WriteLine($"{i}! is {count}");
                x = count;
            }
                
                
                
            //הפעולה מקבלת מספר ציונים
        //פולטת את הממוצע של הציונים
        public static double avgGrade(int num) {
            double avg = 0;
            for (int i = 1; i <= num; i++) {
                Console.WriteLine("Enter a grade: ");
                int grade = int.Parse(Console.ReadLine());
                avg += grade;
            }
            avg /= num;
            return avg;
        }
        static void Main(string[] args)
        {
            double maxAvgGrade = 0, avg , minAvgGrade = 100;
            int num, studentCount = 0;
            char y_n;
            bool continue1 = true;

            while (continue1 != false) {
                Console.WriteLine("Enter a number of grades: ");
                num = int.Parse(Console.ReadLine());
                avg = avgGrade(num);

                studentCount++;

                if (avg > maxAvgGrade)
                    maxAvgGrade = avg;

                if (avg < minAvgGrade)
                    minAvgGrade = avg;

                Console.WriteLine("Do you want to continue?");
                y_n = char.Parse(Console.ReadLine());

                if (y_n == 'n')
                    continue1 = false;
            }
            Console.WriteLine($"The max average is:{Math.Round(maxAvgGrade, 2)}\n" +
                $"The min average is:{Math.Round(minAvgGrade, 2)}\n" +
                $"The count of students is:{studentCount}");


            Console.ReadLine();
        }
    }
}
