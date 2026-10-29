using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesodot
{
    // פרק 6: לולאת כל עוד
    // כדי להריץ דוגמה מהקובץ הזה:
    // בקובץ הראשי יש להסיר את סימן ההערה מהשורה של הקובץ הזה,
    // ובפעולת ההרצה שלמטה יש להסיר את סימן ההערה מהדוגמה הרצויה.
    internal static class Chapter6
    {
        // עצם אחד להגרלת מספרים אקראיים, בשביל משחק הניחושים.
        static Random rnd = new Random();

        // פעולת ההרצה של הקובץ
        public static void Run()
        {
            // יש להסיר את סימן ההערה מהדוגמה שרוצים להריץ

            // פרק 6: לולאת כל עוד
             //example53();
           //  example54_2();
             example55();
            // example56();
            // example57();
            // example58();
            // example59();
            // example60();
            // example61();
            // example62();
            // example63();
            // example64();
            // example65();
        }

        // ==========================================================
        // פרק 6: לולאת כל עוד
        // ==========================================================

        // דוגמה 53: לולאה ראשונה, קליטה עד שמוקלד מספר שלילי
        // לולאת כל עוד מתאימה כשלא יודעים מראש כמה סיבובים יהיו.
        // while (num >= 0)
        // התנאי נבדק לפני כל סיבוב. כל עוד הוא אמת, גוף הלולאה מתבצע.
        // אין בשורת הלולאה התחלה וקידום, ולכן צריך לדאוג להם בעצמנו:
        // נותנים למשתנה ערך לפני הלולאה, ומשנים אותו בתוך הלולאה.
        // אם המשתנה לא משתנה בתוך הלולאה, התנאי נשאר אמת והלולאה לא נגמרת.
        // אם התנאי שקר כבר בהתחלה, הלולאה לא מתבצעת אפילו פעם אחת.
        public static void example53()
        {
            int num = 0, count = 0;

            while (num >= 0)
            {
                Console.Write("Enter a number (negative to stop): ");
                num = int.Parse(Console.ReadLine());

                if (num >= 0)
                {
                    count++;
                }
            }

            Console.WriteLine("You entered " + count + " numbers");
        }

        // דוגמה 54: לולאת תקינות קלט
        // קולטים מספר, וכל עוד הוא לא תקין מבקשים אותו שוב.
        // כאן מספר תקין הוא מספר תלת ספרתי, מ-100 עד 999.
        // התנאי של הלולאה הוא התנאי לקלט לא תקין:
        // num < 100 || num > 999
        // את הקלט הראשון קולטים לפני הלולאה, ואת הקלטים הנוספים בתוכה.
        public static void example54()
        {
            int num;

            Console.Write("Enter a 3 digit number: ");
            num = int.Parse(Console.ReadLine());

            while (num < 100 || num > 999)
            {
                Console.Write("Not a 3 digit number. Try again: ");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Finally! The number is " + num);
        }

        // יש לכתוב תוכנית הקולטת מספרים
        // כל עוד המספר חיובי נסכום את המספרים
        // כאשר המספר השלילי הוא ערך עצירה, לא נסכום אותו


        public static void example54_2()
        {
            int num, sum = 0;

            // קולטים את המספר הראשון לפני הלולאה, כדי שיהיה לנו ערך לבדיקה בתנאי
            Console.Write("Enter a number (negative to stop): ");
            num = int.Parse(Console.ReadLine());
            while (num >= 0)
            {
                sum += num;
                // קולטים את המספר הבא בסוף כל סיבוב, כדי שיהיה לנו ערך לבדיקה בתנאי
                Console.Write("Enter a number (negative to stop): ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The sum of the positive numbers is " + sum);
        }

        // דוגמה 55: ממוצע עד ערך עצירה
        // קולטים מספרים עד שמוקלד מינוס 1, ומחשבים את הממוצע שלהם.
        // ערך העצירה עצמו לא נכנס לחישוב.
        // לכן קולטים לפני הלולאה, ובסוף כל סיבוב קולטים שוב.
        // צובר הסכום ומונה המספרים מתחילים ב-0.
        // אם הערך הראשון כבר מינוס 1, אין מספרים, ולכן בודקים לפני החילוק.
        public static void example55()
        {
            int num, sum = 0, count = 0;
            double average;
            // קלט של המספר הראשון לפני הלולאה, כדי שיהיה לנו ערך לבדיקה בתנאי
            Console.Write("Enter a number (-1 to stop): ");
            num = int.Parse(Console.ReadLine());

            while (num != -1)
            {
                sum += num;
                count++;
                //המשך הקלטים
                Console.Write("Enter a number (-1 to stop): ");
                num = int.Parse(Console.ReadLine());
            }

            if (count > 0)
            {
                average = (double)sum / count;
                Console.WriteLine("The average of " + count + " numbers is " + average);
            }
            else
            {
                Console.WriteLine("No numbers were entered");
            }
        }

        // דוגמה 56: סכום הספרות של מספר
        // כל עוד נשארו ספרות במספר, כלומר המספר גדול מ-0:
        // לוקחים את ספרת האחדות ומוסיפים אותה לסכום.
        // num % 10
        // ואז מוחקים את ספרת האחדות.
        // num /= 10
        // מספר הסיבובים תלוי במספר הספרות, ולכן מתאימה לולאת כל עוד.
        public static void example56()
        {
            int num, sum = 0;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine("The sum of the digits is " + sum);
        }

        // דוגמה 57: המספר ההפוך, הוספת ספרה מימין
        // כדי להוסיף ספרה מימין למספר, כופלים אותו ב-10 ומוסיפים את הספרה.
        // reverse = reverse * 10 + digit
        // בכל סיבוב לוקחים את ספרת האחדות של המספר ומוסיפים אותה מימין למספר ההפוך.
        // הלולאה הורסת את המספר, כי מוחקים ממנו ספרה בכל סיבוב.
        // לכן עובדים על עותק, ושומרים את המספר המקורי להדפסה בסוף.
        public static void example57()
        {
            int num, temp, digit, reverse = 0;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            temp = num;
            while (temp > 0)
            {
                digit = temp % 10;
                reverse = reverse * 10 + digit;
                temp /= 10;
            }

            Console.WriteLine("The reverse of " + num + " is " + reverse);
        }

        // דוגמה 58: הספרה השמאלית ומספר הספרות
        // כל עוד המספר גדול מ-9, כלומר יש בו יותר מספרה אחת, מוחקים את ספרת האחדות.
        // מה שנשאר בסוף הוא הספרה השמאלית, הספרה המשמעותית ביותר.
        // במקביל סופרים כמה ספרות נמחקו, ומוסיפים אחת בשביל הספרה שנשארה.
        public static void example58()
        {
            int num, temp, count = 1;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            temp = num;
            while (temp > 9)
            {
                temp /= 10;
                count++;
            }

            Console.WriteLine("The most significant digit is " + temp);
            Console.WriteLine("The number has " + count + " digits");
        }

        // דוגמה 59: הספרה הגדולה ביותר
        // מתחילים מספרת האחדות: היא הגדולה ביותר בינתיים.
        // מוחקים אותה, וכל עוד נשארו ספרות, משווים כל ספרה לגדולה ביותר.
        // זה אותו רעיון של מציאת מקסימום מפרק 5, רק על ספרות של מספר.
        public static void example59()
        {
            int num, maxDigit, currentDigit;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            maxDigit = num % 10;
            num /= 10;

            while (num > 0)
            {
                currentDigit = num % 10;
                if (currentDigit > maxDigit)
                {
                    maxDigit = currentDigit;
                }
                num /= 10;
            }

            Console.WriteLine("The biggest digit is " + maxDigit);
        }

        // דוגמה 60: בניית מספר מספרות, הוספת ספרה משמאל
        // המשתמש מקליד ספרות: קודם האחדות, אחר כך העשרות, וכן הלאה, עד מינוס 1.
        // ספרה שנכנסת משמאל צריכה להיות במקום הנכון: אחדות, עשרות, מאות.
        // לכן כופלים אותה במשתנה שמייצג את המקום, ומוסיפים למספר.
        // newNum += digit * place
        // אחרי כל ספרה המקום גדל פי 10: מ-1 ל-10, ל-100, וכן הלאה.
        public static void example60()
        {
            int digit, newNum = 0, place = 1;

            Console.Write("Enter a digit (-1 to stop): ");
            digit = int.Parse(Console.ReadLine());

            while (digit != -1)
            {
                newNum += digit * place;
                place *= 10;

                Console.Write("Enter a digit (-1 to stop): ");
                digit = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is " + newNum);
        }

        // דוגמה 61: לולאה שרצה לפחות פעם אחת
        // בלולאה הזו התנאי נבדק בסוף, אחרי גוף הלולאה:
        // do { ... } while (number >= 0);
        // לכן גוף הלולאה מתבצע תמיד לפחות פעם אחת.
        // אין צורך לקלוט לפני הלולאה, ואין צורך לתת למשתנה ערך התחלתי מומצא.
        // שימו לב: בסוף שורת התנאי של הלולאה הזו יש נקודה פסיק.
        public static void example61()
        {
            int number, sum = 0;

            do
            {
                Console.Write("Enter a positive number, negative to exit: ");
                number = int.Parse(Console.ReadLine());

                if (number >= 0)
                {
                    sum += number;
                }
            } while (number >= 0);

            Console.WriteLine("The sum is " + sum);
        }

        // דוגמה 62: תפריט שחוזר עד שבוחרים לצאת
        // לולאה מציגה את התפריט שוב ושוב.
        // משתנה בוליאני, שנקרא דגל, קובע אם להמשיך.
        // כשהמשתמש בוחר 0, הדגל הופך לשקר והלולאה נגמרת אחרי הסיבוב הזה.
        public static void example62()
        {
            int choice, num;
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1 - Square of a number");
                Console.WriteLine("2 - Line of stars");
                Console.WriteLine("0 - Exit");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Enter a number: ");
                    num = int.Parse(Console.ReadLine());
                    Console.WriteLine(num + "^2 = " + num * num);
                }
                else if (choice == 2)
                {
                    Console.Write("Enter number of stars: ");
                    num = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= num; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                else if (choice == 0)
                {
                    keepGoing = false;
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }

            Console.WriteLine("Bye!");
        }

        // דוגמה 63: דילוג לסיבוב הבא
        // קולטים מספרים עד שנקלטים 3 מספרים זוגיים. המספר 6 לא נספר.
        // הפקודה הבאה מפסיקה את הסיבוב הנוכחי וקופצת מיד לבדיקת התנאי:
        // continue;
        // כשמוקלד 6, השורות שאחרי הפקודה לא מתבצעות בסיבוב הזה.
        public static void example63()
        {
            int num, count = 0;

            while (count < 3)
            {
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());

                if (num == 6)
                {
                    continue;
                }

                if (num % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Got 3 even numbers");
        }

        // דוגמה 64: יציאה מהלולאה באמצע
        // הלולאה נראית אינסופית, כי התנאי שלה תמיד אמת:
        // while (true)
        // אבל בתוכה יש פקודה שמפסיקה את הלולאה מיד ויוצאת ממנה:
        // break;
        // כאן שואלים בכל סיבוב אם להוסיף מספר. אם התשובה לא, יוצאים מהלולאה.
        public static void example64()
        {
            int num, sum = 0;
            char answer;

            while (true)
            {
                Console.Write("Add another number? (y/n) ");
                answer = char.Parse(Console.ReadLine());

                if (answer == 'n' || answer == 'N')
                {
                    break;
                }

                Console.Write("Enter the number: ");
                num = int.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine("The total sum is " + sum);
        }

        // דוגמה 65: משחק הניחושים
        // המחשב מגריל מספר סודי מ-0 עד 99, והמשתמש מנסה לנחש אותו.
        // אחרי כל ניחוש התוכנית אומרת אם המספר הסודי גדול או קטן יותר.
        // הלולאה ממשיכה כל עוד הניחוש שונה מהמספר הסודי.
        // הניחוש מתחיל במינוס 1, ערך שלא יכול להיות המספר הסודי,
        // כדי שהלולאה תתבצע לפחות פעם אחת.
        // מונה סופר כמה ניחושים היו.
        public static void example65()
        {
            int secret = rnd.Next(100);
            int guess = -1, numOfGuesses = 0;

            while (guess != secret)
            {
                Console.Write("Enter your guess: ");
                guess = int.Parse(Console.ReadLine());
                numOfGuesses++;

                if (guess < secret)
                {
                    Console.WriteLine("The secret number is bigger");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("The secret number is smaller");
                }
            }

            Console.WriteLine("Correct! You found " + secret + " after " + numOfGuesses + " guesses");
        }
    }
}
