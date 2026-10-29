using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesodot
{
    // פרק 7: פעולות
    // כדי להריץ דוגמה מהקובץ הזה:
    // בקובץ הראשי יש להסיר את סימן ההערה מהשורה של הקובץ הזה,
    // ובפעולת ההרצה שלמטה יש להסיר את סימן ההערה מהדוגמה הרצויה.
    // בפרק הזה, ליד כל דוגמה כתובות גם פעולות העזר שהיא משתמשת בהן.
    internal static class Chapter7
    {
        // עצם אחד להגרלת מספרים אקראיים, משותף לכל הדוגמאות בקובץ.
        static Random rnd = new Random();

        // פעולת ההרצה של הקובץ
        public static void Run()
        {
            // יש להסיר את סימן ההערה מהדוגמה שרוצים להריץ

            // פרק 7: פעולות
             example66();
            // example67();
            // example68();
            // example69();
            // example70();
            // example71();
            // example72();
            // example73();
            // example74();
            // example75();
            // example76();
            // example77();
            // example78();
            // example79();
        }

        // ==========================================================
        // פרק 7: פעולות
        // ==========================================================

        // דוגמה 66: למה צריך פעולות, ציור ריבועים
        // פעולה היא אוסף הוראות שקיבל שם. כותבים אותה פעם אחת, וקוראים לה כמה פעמים שרוצים.
        // בלי פעולות, כדי לצייר שני ריבועים בגדלים שונים היינו כותבים את אותן לולאות פעמיים.
        // כאן כתבנו פעולה שמדפיסה שורת כוכביות, ופעולה שמציירת ריבוע בעזרתה.
        // כשקוראים לפעולה, התוכנית קופצת אליה, מבצעת את ההוראות שלה, וחוזרת לשורה שאחרי הקריאה.
        public static void example66()
        {
            Console.WriteLine("A square of size 3:");
            DrawSquare(3);

            Console.WriteLine("A square of size 5:");
            DrawSquare(5);
        }

        // הפעולה מקבלת מספר, ומדפיסה שורה עם מספר כזה של כוכביות.
        static void PrintLine(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // הפעולה מקבלת גודל, ומציירת ריבוע של כוכביות בגודל הזה.
        // היא משתמשת בפעולה הקודמת כדי להדפיס כל שורה.
        static void DrawSquare(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                PrintLine(size);
            }
        }

        // דוגמה 67: פעולות מוכנות ממחלקות אחרות
        // כבר השתמשנו בהרבה פעולות שמישהו אחר כתב, למשל:
        // Console.WriteLine, int.Parse, Math.Sqrt, Math.Max
        // אנחנו לא יודעים איך הן כתובות מבפנים, ולא צריכים לדעת.
        // מספיק לדעת מה הפעולה מקבלת ומה היא מחזירה. לכן קוראים לה קופסה שחורה.
        // כדי לקרוא לפעולה ממחלקה אחרת, כותבים את שם המחלקה, נקודה, ושם הפעולה.
        public static void example67()
        {
            double root = Math.Sqrt(81);
            int bigger = Math.Max(17, 42);
            int number = int.Parse("123");

            Console.WriteLine("Square root of 81: " + root);
            Console.WriteLine("The bigger of 17 and 42: " + bigger);
            Console.WriteLine("The text 123 as a number, plus 1: " + (number + 1));
        }

        // דוגמה 68: טווח ההכרה של משתנים
        // משתנה שהוגדר בתוך פעולה מוכר רק בתוך הפעולה הזו.
        // אם בשתי פעולות יש משתנה עם אותו שם, אלה שני משתנים שונים לגמרי.
        // כאן גם בדוגמה וגם בפעולת העזר יש משתנה בשם הבא:
        // num
        // השינוי בפעולת העזר לא משפיע על המשתנה של הדוגמה.
        // גם משתנה הבקרה של לולאה מוכר רק בתוך הלולאה.
        public static void example68()
        {
            int num = 7;
            Console.WriteLine("In the example, num = " + num);

            ShowOtherNum();

            Console.WriteLine("Back in the example, num = " + num);
        }

        // הפעולה מגדירה משתנה משלה, ומדפיסה אותו.
        static void ShowOtherNum()
        {
            int num = 99;
            Console.WriteLine("In the other method, num = " + num);
        }

        // דוגמה 69: פעולה שמקבלת פרמטר
        // פרמטר הוא ערך שהפעולה מקבלת כשקוראים לה. הוא כתוב בסוגריים בכותרת הפעולה.
        // static void PrintStars(int count)
        // בקריאה לפעולה שולחים ערך, והוא נכנס לפרמטר.
        // אפשר לשלוח מספר, משתנה או ביטוי. הפעולה מקבלת רק את הערך.
        public static void example69()
        {
            int num = 4;

            PrintStars(3);
            PrintStars(num);
            PrintStars(num * 2);
        }

        // הפעולה מקבלת מספר, ומדפיסה שורה עם מספר כזה של כוכביות.
        static void PrintStars(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // דוגמה 70: פעולה שמקבלת יותר מפרמטר אחד
        // הפרמטרים מופרדים בפסיק, ולכל אחד יש טיפוס משלו.
        // בקריאה לפעולה שולחים ערכים באותו מספר, באותו סדר ומאותו טיפוס.
        // הערך הראשון נכנס לפרמטר הראשון, והשני לשני.
        public static void example70()
        {
            int grade1, grade2;

            Console.Write("Enter the first grade: ");
            grade1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second grade: ");
            grade2 = int.Parse(Console.ReadLine());

            PrintAverage(grade1, grade2);
            PrintAverage(80, 95);
        }

        // הפעולה מקבלת שני מספרים שלמים, ומדפיסה את הממוצע שלהם.
        static void PrintAverage(int n1, int n2)
        {
            double average = (n1 + n2) / 2.0;
            Console.WriteLine("The average of " + n1 + " and " + n2 + " is " + average);
        }

        // דוגמה 71: הזמנת מוצרים
        // בהזמנה טלפונית מוסיפים למחיר המוצר את עלות המשלוח.
        // משלוח רגיל עולה 5 שקלים, ומשלוח אקספרס עולה 10 שקלים.
        // חבר מועדון מקבל הנחה של 2 שקלים.
        // הפעולה מקבלת שלושה פרמטרים מטיפוסים שונים: מספר, מחרוזת וערך בוליאני.
        // הדוגמה מגרילה מחיר לשלוש הזמנות, וקולטת לכל אחת את סוג המשלוח ואם הלקוח חבר מועדון.
        public static void example71()
        {
            double price;
            string shippingMethod;
            bool isMember;

            for (int i = 1; i <= 3; i++)
            {
                price = rnd.Next(1000, 10001) / 100.0;

                Console.WriteLine("Purchase #" + i + ", price: " + price);
                Console.Write("Enter shipping method (Standard/Express): ");
                shippingMethod = Console.ReadLine();
                Console.Write("Is the customer a club member? (true/false): ");
                isMember = bool.Parse(Console.ReadLine());

                CalculateShippingCost(price, shippingMethod, isMember);
                Console.WriteLine();
            }
        }

        // הפעולה מקבלת את מחיר המוצר, את סוג המשלוח, ואם הלקוח חבר מועדון.
        // הפעולה מדפיסה את העלות הכוללת של הקנייה.
        static void CalculateShippingCost(double totalCost, string shippingMethod, bool isMember)
        {
            double shippingCost = 0;

            if (shippingMethod.Equals("Express"))
            {
                shippingCost = 10;
            }
            else if (shippingMethod.Equals("Standard"))
            {
                shippingCost = 5;
            }

            totalCost += shippingCost;

            if (isMember)
            {
                totalCost -= 2;
            }

            Console.WriteLine("The total cost is " + totalCost);
        }

        // דוגמה 72: פעולה שמחזירה ערך
        // פעולה יכולה לחשב ערך ולהחזיר אותו למי שקרא לה.
        // בכותרת, במקום המילה הראשונה כותבים את הטיפוס של הערך המוחזר:
        // static int Max(int n1, int n2, int n3)
        // הפקודה הבאה מחזירה את הערך ומסיימת את הפעולה מיד:
        // return
        // את הערך המוחזר אפשר לשמור במשתנה, להדפיס, או להשתמש בו בתוך ביטוי.
        public static void example72()
        {
            int a, b, c, max;

            Console.Write("Enter three numbers, each in its own line: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            max = Max(a, b, c);
            Console.WriteLine("The maximum is " + max);
            Console.WriteLine("The maximum plus 10 is " + (Max(a, b, c) + 10));
            Console.WriteLine("The maximum of 4, 9, 2 is " + Max(4, 9, 2));
        }

        // הפעולה מקבלת שלושה מספרים שלמים, ומחזירה את הגדול מביניהם.
        static int Max(int n1, int n2, int n3)
        {
            int max;

            if (n1 >= n2 && n1 >= n3)
            {
                max = n1;
            }
            else if (n2 >= n3)
            {
                max = n2;
            }
            else
            {
                max = n3;
            }

            return max;
        }

        // דוגמה 73: האם המספר פלינדרום
        // פלינדרום הוא מספר שנקרא אותו דבר משני הכיוונים, למשל 91819.
        // הפעולה הראשונה מחזירה את המספר ההפוך, כמו בפרק 6.
        // הפעולה השנייה משתמשת בה: מספר הוא פלינדרום אם הוא שווה להפוך שלו.
        // בחלק השני, הדוגמה מגרילה מספרים בני 4 או 5 ספרות עד שיוצא פלינדרום.
        public static void example73()
        {
            int num, count = 1;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (IsPalindrome(num))
            {
                Console.WriteLine(num + " is a palindrome");
            }
            else
            {
                Console.WriteLine(num + " is not a palindrome");
            }

            num = rnd.Next(1000, 100000);
            while (!IsPalindrome(num))
            {
                num = rnd.Next(1000, 100000);
                count++;
            }

            Console.WriteLine("Random palindrome: " + num + ", found after " + count + " tries");
        }

        // הפעולה מקבלת מספר טבעי, ומחזירה את המספר ההפוך לו.
        static int Reverse(int num)
        {
            int reverse = 0;

            while (num > 0)
            {
                reverse = reverse * 10 + num % 10;
                num /= 10;
            }

            return reverse;
        }

        // הפעולה מקבלת מספר טבעי.
        // הפעולה מחזירה אמת אם המספר הוא פלינדרום, ושקר אחרת.
        static bool IsPalindrome(int num)
        {
            return num == Reverse(num);
        }

        // דוגמה 74: תיאור מזג האוויר
        // יום שהטמפרטורה בו בין 20 ל-30 מעלות הוא יום חמים.
        // מעל 30 הוא יום חם, ומתחת ל-20 הוא יום קר.
        // הפעולה מקבלת את הטמפרטורה, ואם ירד גשם, ומחזירה מחרוזת שמתארת את היום.
        // נהוג שתהיה בפעולה פקודת החזרה אחת בלבד, בסוף.
        public static void example74()
        {
            double temp;
            bool rain;

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Day " + i + " temperature: ");
                temp = double.Parse(Console.ReadLine());
                Console.Write("Did it rain? (true/false): ");
                rain = bool.Parse(Console.ReadLine());

                Console.WriteLine(DescribeWeather(temp, rain));
            }
        }

        // הפעולה מקבלת טמפרטורה, ומשתנה בוליאני שמציין אם ירד גשם.
        // הפעולה מחזירה מחרוזת שמתארת את מזג האוויר.
        static string DescribeWeather(double temperature, bool isRaining)
        {
            string str = "It's ";

            if (temperature > 30)
            {
                str += "hot";
            }
            else if (temperature >= 20)
            {
                str += "warm";
            }
            else
            {
                str += "cool";
            }

            if (isRaining)
            {
                str += " and rainy";
            }
            else
            {
                str += " and sunny";
            }

            return str;
        }

        // דוגמה 75: כמה פעמים ספרה מופיעה במספר
        // הפעולה מקבלת מספר וספרה, ומחזירה כמה פעמים הספרה מופיעה במספר.
        // למשל, במספר 2422526 הספרה 2 מופיעה 4 פעמים.
        // בתוך הפעולה עוברים על הספרות בעזרת לולאת כל עוד, כמו בפרק 6.
        // שימו לב: עבור המספר 0 הלולאה לא מתבצעת אפילו פעם אחת,
        // ולכן הספרה 0 במספר 0 לא נספרת.
        public static void example75()
        {
            int num, digit;

            Console.WriteLine("2 appears in 2422526 " + CountDigit(2422526, 2) + " times");

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Enter a digit: ");
            digit = int.Parse(Console.ReadLine());

            Console.WriteLine(digit + " appears in " + num + " " + CountDigit(num, digit) + " times");
        }

        // הפעולה מקבלת מספר שלם וספרה.
        // הפעולה מחזירה את מספר המופעים של הספרה במספר.
        static int CountDigit(int number, int digit)
        {
            int count = 0;

            while (number > 0)
            {
                if (number % 10 == digit)
                {
                    count++;
                }
                number /= 10;
            }

            return count;
        }

        // דוגמה 76: העמסת פעולות
        // אפשר לכתוב כמה פעולות עם אותו שם, בתנאי שהפרמטרים שלהן שונים:
        // במספר הפרמטרים, או בטיפוס שלהם.
        // לפי הערכים ששולחים בקריאה, המחשב יודע לאיזו פעולה לקרוא.
        // אי אפשר לכתוב שתי פעולות עם אותו שם ואותם טיפוסי פרמטרים, גם אם שמות הפרמטרים שונים.
        public static void example76()
        {
            Console.WriteLine(Min(1, 2));
            Console.WriteLine(Min(4, 3, 2));
            Console.WriteLine(Min(1.3, 2.7));
        }

        // הפעולה מקבלת שני מספרים שלמים, ומחזירה את הקטן מביניהם.
        static int Min(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            return y;
        }

        // הפעולה מקבלת שלושה מספרים שלמים, ומחזירה את הקטן מביניהם.
        static int Min(int x, int y, int z)
        {
            return Min(Min(x, y), z);
        }

        // הפעולה מקבלת שני מספרים עשרוניים, ומחזירה את הקטן מביניהם.
        static double Min(double x, double y)
        {
            if (x < y)
            {
                return x;
            }
            return y;
        }

        // דוגמה 77: מרחק בין שתי נקודות, תכנון מלמעלה למטה
        // מתחילים מהפעולה הגדולה, ומפרקים אותה לפעולות עזר קטנות.
        // המרחק הוא שורש של סכום ריבועי ההפרשים.
        // לחזקה כותבים פעולת עזר משלנו, ולשורש משתמשים בפעולה המוכנה.
        // Math.Sqrt
        // למשל, המרחק בין הנקודות 0,0 ו-4,4 הוא שורש של 32.
        public static void example77()
        {
            int x1, y1, x2, y2;

            Console.WriteLine("Enter 2 points: x1, y1, x2, y2, each in its own line");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The distance is " + Distance(x1, y1, x2, y2));
        }

        // הפעולה מקבלת בסיס ומעריך שלם וחיובי, ומחזירה את הבסיס בחזקת המעריך.
        static double Power(double baseNum, int exponent)
        {
            double result = 1;

            for (int i = 1; i <= exponent; i++)
            {
                result *= baseNum;
            }

            return result;
        }

        // הפעולה מקבלת ארבעה מספרים: שתי הקואורדינטות של כל אחת משתי נקודות.
        // הפעולה מחזירה את המרחק בין הנקודות.
        static double Distance(int x1, int y1, int x2, int y2)
        {
            double sum = Power(x2 - x1, 2) + Power(y2 - y1, 2);
            return Math.Sqrt(sum);
        }

        // דוגמה 78: תקינות תאריך, תכנון מלמעלה למטה
        // תאריך תקין: השנה חיובית, החודש בין 1 ל-12, והיום בין 1 למספר הימים בחודש.
        // בפברואר יש 29 ימים בשנה מעוברת, ו-28 בשנה רגילה.
        // שנה מעוברת מתחלקת ב-4 ולא ב-100, או מתחלקת ב-400.
        // במקום לכתוב הכול בפעולה אחת ארוכה, כל בדיקה היא פעולה קטנה עם שם ברור.
        // כך כל פעולה קלה לבדיקה, ואפשר להשתמש בה גם לצרכים אחרים.
        // הפעולות מקבלות את הנתונים כפרמטרים ולא קולטות אותם, ולכן אפשר לשלוח להן נתונים מכל מקור.
        public static void example78()
        {
            PrintDate(29, 2, 2024);
            PrintDate(29, 2, 2023);
            PrintDate(31, 4, 2025);
            PrintDate(15, 13, 2025);
            PrintDate(30, 6, 2025);
        }

        // הפעולה מקבלת תאריך, ומדפיסה אותו יחד עם תוצאת הבדיקה.
        static void PrintDate(int day, int month, int year)
        {
            Console.Write("The date " + day + "/" + month + "/" + year + " is ");

            if (IsValidDate(day, month, year))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("not valid");
            }
        }

        // הפעולה מקבלת ערך תחתון, ערך עליון ומספר.
        // הפעולה מחזירה אמת אם המספר נמצא בטווח, ושקר אחרת.
        static bool IsInRange(int min, int max, int n)
        {
            return n >= min && n <= max;
        }

        // הפעולה מקבלת שנה, ומחזירה אמת אם היא שנה מעוברת.
        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        // הפעולה מקבלת חודש ושנה, ומחזירה את מספר הימים בחודש.
        static int DaysInMonth(int month, int year)
        {
            int days;

            if (month == 2)
            {
                if (IsLeapYear(year))
                {
                    days = 29;
                }
                else
                {
                    days = 28;
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                days = 30;
            }
            else
            {
                days = 31;
            }

            return days;
        }

        // הפעולה מקבלת יום, חודש ושנה.
        // הפעולה מחזירה אמת אם הם מהווים תאריך תקין, ושקר אחרת.
        static bool IsValidDate(int day, int month, int year)
        {
            if (year < 1)
            {
                return false;
            }
            if (!IsInRange(1, 12, month))
            {
                return false;
            }
            return IsInRange(1, DaysInMonth(month, year), day);
        }

        // דוגמה 79: שאלת סיכום, עידוד קניית ספרים
        // בחנות ספרים יש שני מבצעים:
        // מבצע 2: קונים שני ספרים, ומשלמים חצי מחיר על הזול מביניהם.
        // מבצע 3: קונים שלושה ספרים, והזול מביניהם בחינם.
        // פעולה אחת מחשבת כל מבצע, ופעולה שלישית בוחרת ביניהן לפי מספר המבצע.
        // אם מספר המבצע אינו 2 או 3, הפעולה מחזירה מינוס 1, כסימן לבחירה לא תקינה.
        public static void example79()
        {
            int deal;
            double total;

            Console.Write("Choose a deal (2 or 3): ");
            deal = int.Parse(Console.ReadLine());

            total = PayForDeal(deal);

            if (total == -1)
            {
                Console.WriteLine("No such deal");
            }
            else
            {
                Console.WriteLine("You pay " + total);
            }
        }

        // הפעולה מקבלת מחירים של שלושה ספרים.
        // הפעולה מחזירה את סכום שני המחירים הגבוהים, כי הזול בחינם.
        static double ThreeBooksPrice(double book1, double book2, double book3)
        {
            double min = Math.Min(Math.Min(book1, book2), book3);
            return book1 + book2 + book3 - min;
        }

        // הפעולה מקבלת מחירים של שני ספרים.
        // הפעולה מחזירה את הסכום לתשלום, כשעל הזול משלמים חצי מחיר.
        static double TwoBooksPrice(double book1, double book2)
        {
            double min = Math.Min(book1, book2);
            return book1 + book2 - min / 2;
        }

        // הפעולה מקבלת את מספר המבצע, וקולטת את המחירים של הספרים במבצע.
        // הפעולה מחזירה את הסכום לתשלום, או מינוס 1 אם אין מבצע כזה.
        static double PayForDeal(int deal)
        {
            double total = -1;

            if (deal == 2)
            {
                Console.Write("Enter two prices, each in its own line: ");
                double p1 = double.Parse(Console.ReadLine());
                double p2 = double.Parse(Console.ReadLine());
                total = TwoBooksPrice(p1, p2);
            }
            else if (deal == 3)
            {
                Console.Write("Enter three prices, each in its own line: ");
                double p1 = double.Parse(Console.ReadLine());
                double p2 = double.Parse(Console.ReadLine());
                double p3 = double.Parse(Console.ReadLine());
                total = ThreeBooksPrice(p1, p2, p3);
            }

            return total;
        }
    }
}
