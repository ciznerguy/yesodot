using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesodot
{
    // פרק 5: לולאות
    // כדי להריץ דוגמה מהקובץ הזה:
    // בקובץ הראשי יש להסיר את סימן ההערה מהשורה של הקובץ הזה,
    // ובפעולת ההרצה שלמטה יש להסיר את סימן ההערה מהדוגמה הרצויה.
    internal static class Chapter5
    {
        // פעולת ההרצה של הקובץ
        public static void Run()
        {
            // יש להסיר את סימן ההערה מהדוגמה שרוצים להריץ

            // פרק 5: לולאות
            // example41();
            // example42();
            // example43();
            // example44();
            // example45();
            // example46();
            // example47();
            // example48();
            // example49();
            // example50();
            // example51();
            // example52();
        }

        // ==========================================================
        // פרק 5: לולאות
        // ==========================================================

        // דוגמה 41: לולאה ראשונה, הדפסת כוכביות
        // לולאה היא קטע קוד שרץ כמה פעמים.
        // בלי לולאה, כדי להדפיס 8 כוכביות צריך לכתוב 8 שורות זהות.
        // עם לולאה כותבים את השורה פעם אחת, ואפשר להדפיס כל מספר של כוכביות.
        // ללולאה שלושה חלקים, מופרדים בנקודה פסיק:
        // for (int i = 1; i <= num; i++)
        // התחלה: המשתנה מקבל ערך התחלתי, פעם אחת בלבד.
        // תנאי: נבדק לפני כל סיבוב. כשהוא שקר, הלולאה נגמרת.
        // קידום: מתבצע בסוף כל סיבוב.
        // המשתנה של הלולאה נקרא משתנה הבקרה.
        public static void example41()
        {
            int num;

            Console.Write("How many stars? ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        // דוגמה 42: הדפסת מספרים ברצף
        // משתנה הבקרה משתנה בכל סיבוב, ואפשר להשתמש בערך שלו בתוך הלולאה.
        // הלולאה מדפיסה את המספרים מ-1 ועד המספר שהמשתמש הקליד.
        // מספר הסיבובים נקבע רק בזמן הריצה, לפי הקלט.
        public static void example42()
        {
            int num;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        // דוגמה 43: הדפסת המספרים האי זוגיים
        // שתי דרכים להדפיס רק את המספרים האי זוגיים עד מספר מסוים.
        // דרך 1: עוברים על כל המספרים, ובודקים כל אחד בעזרת תנאי.
        // דרך 2: מתחילים מ-1 ומקדמים ב-2 בכל סיבוב, כך שעוברים רק על האי זוגיים.
        // i += 2
        // הדרך השנייה עושה חצי מהסיבובים, ואין בה צורך בתנאי.
        public static void example43()
        {
            int num;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();

            for (int i = 1; i <= num; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // דוגמה 44: הדפסה בסדר יורד
        // לולאה יכולה גם לרדת.
        // מתחילים מהמספר הגדול, ממשיכים כל עוד המשתנה גדול או שווה ל-1,
        // ומקטינים את המשתנה באחד בכל סיבוב.
        // for (int i = num; i >= 1; i--)
        public static void example44()
        {
            int num;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            for (int i = num; i >= 1; i--)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        // דוגמה 45: חישוב עצרת
        // עצרת של מספר היא מכפלת כל המספרים מ-1 ועד המספר.
        // למשל, עצרת של 5 היא 1 כפול 2 כפול 3 כפול 4 כפול 5, כלומר 120.
        // משתנה שאוסף מכפלה מתחיל ב-1, כי כפל ב-0 יאפס את התוצאה.
        // בכל סיבוב מכפילים אותו במשתנה הבקרה.
        // factorial *= i
        public static void example45()
        {
            int num, factorial = 1;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(num + "! = " + factorial);
        }

        // דוגמה 46: צובר, סכום וממוצע של מחירים
        // צובר הוא משתנה שאוסף ערכים לאורך הלולאה.
        // משתנה שאוסף סכום מתחיל ב-0.
        // בכל סיבוב קולטים מחיר ומוסיפים אותו לצובר.
        // sum += price
        // אחרי הלולאה מחלקים את הסכום במספר המוצרים כדי לקבל ממוצע.
        // הסכום עשרוני, ולכן החילוק הוא חילוק עשרוני.
        public static void example46()
        {
            int numOfProducts;
            double price, sum = 0, average;

            Console.Write("How many products? ");
            numOfProducts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numOfProducts; i++)
            {
                Console.Write("Enter the price of product " + i + ": ");
                price = double.Parse(Console.ReadLine());
                sum += price;
            }

            average = sum / numOfProducts;

            Console.WriteLine("The total is " + sum);
            Console.WriteLine("The average price is " + average);
        }

        // דוגמה 47: מונה, כמה ציונים עברו
        // מונה הוא צובר שסופר כמה פעמים קרה משהו.
        // המונה מתחיל ב-0, וגדל באחד בכל פעם שהתנאי מתקיים.
        // count++
        // בסוף מחשבים איזה אחוז מהציונים עבר, בעזרת המרה לעשרוני.
        public static void example47()
        {
            int numOfGrades, grade, count = 0;
            double percent;

            Console.Write("How many grades? ");
            numOfGrades = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numOfGrades; i++)
            {
                Console.Write("Enter grade " + i + ": ");
                grade = int.Parse(Console.ReadLine());

                if (grade >= 55)
                {
                    count++;
                }
            }

            percent = (double)count / numOfGrades * 100;

            Console.WriteLine(count + " grades passed");
            Console.WriteLine("That is " + percent + " percent");
        }

        // דוגמה 48: מציאת הציון הגבוה ביותר
        // רעיון: שומרים במשתנה את הגדול ביותר שראינו עד עכשיו.
        // את הערך הראשון קולטים לפני הלולאה, והוא הגדול ביותר בינתיים.
        // בלולאה קולטים את שאר הערכים, ובכל פעם משווים לגדול ביותר.
        // אם הערך החדש גדול יותר, הוא מחליף את הגדול ביותר.
        // לכן הלולאה מתחילה מ-2: הערך הראשון כבר נקלט.
        public static void example48()
        {
            int numOfGrades, grade, max;

            Console.Write("How many grades? ");
            numOfGrades = int.Parse(Console.ReadLine());

            Console.Write("Enter grade 1: ");
            max = int.Parse(Console.ReadLine());

            for (int i = 2; i <= numOfGrades; i++)
            {
                Console.Write("Enter grade " + i + ": ");
                grade = int.Parse(Console.ReadLine());

                if (grade > max)
                {
                    max = grade;
                }
            }

            Console.WriteLine("The highest grade is " + max);
        }

        // דוגמה 49: ערך נלווה, למי יש את הציון הגבוה ביותר
        // לפעמים צריך לדעת לא רק מה הערך הגבוה, אלא גם למי הוא שייך.
        // לכן שומרים שני משתנים: הציון הגבוה, והשם שנלווה אליו.
        // בכל פעם שהציון הגבוה מתחלף, מעדכנים גם את השם.
        public static void example49()
        {
            int numOfStudents, grade, max;
            string name, maxName;

            Console.Write("How many students? ");
            numOfStudents = int.Parse(Console.ReadLine());

            Console.Write("Enter the name of student 1: ");
            maxName = Console.ReadLine();
            Console.Write("Enter the grade of student 1: ");
            max = int.Parse(Console.ReadLine());

            for (int i = 2; i <= numOfStudents; i++)
            {
                Console.Write("Enter the name of student " + i + ": ");
                name = Console.ReadLine();
                Console.Write("Enter the grade of student " + i + ": ");
                grade = int.Parse(Console.ReadLine());

                if (grade > max)
                {
                    max = grade;
                    maxName = name;
                }
            }

            Console.WriteLine(maxName + " has the highest grade: " + max);
        }

        // דוגמה 50: השני בגודלו
        // שומרים שני משתנים: הגדול ביותר, והשני בגודלו.
        // לפני הלולאה קולטים שני מספרים, ומסדרים אותם במשתנים לפי הגודל.
        // לכל מספר חדש יש שלושה מקרים:
        // אם הוא גדול מהגדול ביותר, הגדול הקודם יורד למקום השני, והחדש עולה לראשון.
        // אחרת, אם הוא גדול מהשני, הוא מחליף רק את השני.
        // אחרת, לא משנים כלום.
        public static void example50()
        {
            int numOfValues, num, first, second;

            Console.Write("How many numbers? (at least 2) ");
            numOfValues = int.Parse(Console.ReadLine());

            Console.Write("Enter number 1: ");
            first = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            num = int.Parse(Console.ReadLine());

            if (num > first)
            {
                second = first;
                first = num;
            }
            else
            {
                second = num;
            }

            for (int i = 3; i <= numOfValues; i++)
            {
                Console.Write("Enter number " + i + ": ");
                num = int.Parse(Console.ReadLine());

                if (num > first)
                {
                    second = first;
                    first = num;
                }
                else if (num > second)
                {
                    second = num;
                }
            }

            Console.WriteLine("The largest is " + first);
            Console.WriteLine("The second largest is " + second);
        }

        // דוגמה 51: חישוב חזקה בלולאה
        // חזקה היא כפל של הבסיס בעצמו כמה פעמים.
        // למשל, 2 בחזקת 5 הוא 2 כפול 2 כפול 2 כפול 2 כפול 2, כלומר 32.
        // הלולאה רצה כמספר המעריך, ובכל סיבוב מכפילה את התוצאה בבסיס.
        // התוצאה מתחילה ב-1, כמו בעצרת.
        // אפשר להשוות לתוצאה של הפעולה המוכנה מפרק 3:
        // Math.Pow(baseNum, exponent)
        public static void example51()
        {
            int baseNum, exponent, result = 1;

            Console.Write("Enter the base: ");
            baseNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the exponent: ");
            exponent = int.Parse(Console.ReadLine());

            for (int i = 1; i <= exponent; i++)
            {
                result *= baseNum;
            }

            Console.WriteLine(baseNum + " ^ " + exponent + " = " + result);
            Console.WriteLine("Math.Pow gives " + Math.Pow(baseNum, exponent));
        }

        // דוגמה 52: לולאות מקוננות, מלבן ומשולש
        // לולאה מקוננת היא לולאה בתוך לולאה.
        // הלולאה החיצונית עוברת על השורות, והפנימית מדפיסה את הכוכביות בכל שורה.
        // בסוף כל שורה יורדים שורה.
        // במלבן, בכל שורה יש אותו מספר כוכביות.
        // במשולש, בשורה מספר 1 יש כוכבית אחת, בשורה מספר 2 יש שתיים, וכן הלאה.
        // לכן התנאי של הלולאה הפנימית תלוי במשתנה של הלולאה החיצונית:
        // for (int j = 1; j <= i; j++)
        public static void example52()
        {
            int rows, cols;

            Console.Write("How many rows? ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("How many columns? ");
            cols = int.Parse(Console.ReadLine());

            Console.WriteLine("Rectangle:");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Triangle:");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
