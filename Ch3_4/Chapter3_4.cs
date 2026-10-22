using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesodot
{
    // פרקים 3 ו-4: הספרייה המתמטית ומחלקת אקראי, משפטי תנאי
    // כדי להריץ דוגמה מהקובץ הזה:
    // בקובץ הראשי יש להסיר את סימן ההערה מהשורה של הקובץ הזה,
    // ובפעולת ההרצה שלמטה יש להסיר את סימן ההערה מהדוגמה הרצויה.
    internal static class Chapter3_4
    {
        // עצם אחד להגרלת מספרים אקראיים, משותף לכל הדוגמאות.
        // מגדירים אותו פעם אחת בלבד, מחוץ לפעולות,
        // כדי שבכל הגרלה נקבל באמת מספר אקראי.

        // שורת חובה 
        static Random rnd = new Random();

        // פעולת ההרצה של הקובץ
        public static void Run()
        {
            // יש להסיר את סימן ההערה מהדוגמה שרוצים להריץ

            // פרק 3: הספרייה המתמטית ומחלקת אקראי
           //  example21();
            // example22();
            // example23();
            // example24();
            // example25();
            // example26();
            // example27();
            // example28();
             example29();
            // example30();

            // פרק 4: משפטי תנאי
            // example31();
            // example32();
            // example33();
            // example34();
            // example35();
            // example36();
            // example37();
            // example38();
            // example39();
            // example40();
        }

        // ==========================================================
        // פרק 3: הספרייה המתמטית ומחלקת אקראי
        // ==========================================================

        // דוגמה 21: ערך מוחלט
        // הפעולה מקבלת מספר ומחזירה את הערך המוחלט שלו, כלומר את המספר בלי הסימן.
        // Math.Abs
        // אם המספר שלם התוצאה שלמה, ואם הוא עשרוני התוצאה עשרונית.
        // בחלק השני התוכנית קולטת שני מספרים ומחשבת את המרחק ביניהם.
        // המרחק תמיד חיובי, לא משנה איזה מספר גדול יותר.
        // distance = Math.Abs(num1 - num2)
        public static void example21()
        {
            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Abs(7));
            Console.WriteLine(Math.Abs(-8.3));
            Console.WriteLine();

            int num1, num2, distance;

            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            distance = Math.Abs(num1 - num2);

            Console.WriteLine("The distance between the numbers is " + distance);
        }

        // דוגמה 22: חזקה
        // הפעולה מקבלת בסיס ומעריך, ומחזירה את הבסיס בחזקת המעריך.
        // Math.Pow(base, exponent)
        // הערך המוחזר תמיד עשרוני, ולכן שומרים אותו במשתנה עשרוני.
        // כשהתוצאה היא מספר שלם, היא מודפסת בלי נקודה עשרונית.
        // בחלק השני התוכנית קולטת בסיס ומעריך ומחשבת את החזקה.
        public static void example22()
        {
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Pow(-2, 3));
            Console.WriteLine(Math.Pow(2, -1));
            Console.WriteLine();

            double baseNum, exponent, result;

            Console.Write("Enter the base: ");
            baseNum = double.Parse(Console.ReadLine());
            Console.Write("Enter the exponent: ");
            exponent = double.Parse(Console.ReadLine());

            result = Math.Pow(baseNum, exponent);

            Console.WriteLine(baseNum + " ^ " + exponent + " = " + result);
        }

        // דוגמה 23: שורש ריבועי ושורש שלישי
        // הפעולה מחזירה את השורש הריבועי של מספר חיובי, והתוצאה עשרונית.
        // Math.Sqrt
        // לשורש שאינו ריבועי משתמשים בחזקה עם מעריך שהוא שבר.
        // שורש שלישי של 8 הוא 8 בחזקת שליש:
        // Math.Pow(8, 1 / 3.0)
        // שימו לב: אם כותבים שליש כחילוק של שני מספרים שלמים, מקבלים 0,
        // וכל מספר בחזקת 0 הוא 1.
        // Math.Pow(8, 1 / 3)
        public static void example23()
        {
            Console.WriteLine(Math.Sqrt(16));
            Console.WriteLine(Math.Sqrt(15));
            Console.WriteLine(Math.Pow(8, 1 / 3.0));
            Console.WriteLine(Math.Pow(8, 1 / 3));
        }

        // דוגמה 24: עיגול
        // הפעולה הראשונה מעגלת למספר השלם הקרוב ביותר:
        // Math.Round
        // הפעולה השנייה מעגלת תמיד כלפי מטה:
        // Math.Floor
        // במספר חיובי עיגול כלפי מטה פשוט חותך את החלק העשרוני.
        // במספר שלילי כלפי מטה פירושו מספר קטן יותר, ולכן מינוס 3.4 הופך למינוס 4.
        // שתי הפעולות מחזירות ערך עשרוני.
        public static void example24()
        {
            Console.WriteLine("Round(3.6) = " + Math.Round(3.6));
            Console.WriteLine("Round(3.4) = " + Math.Round(3.4));
            Console.WriteLine("Round(-3.6) = " + Math.Round(-3.6));
            Console.WriteLine("Round(-3.4) = " + Math.Round(-3.4));
            Console.WriteLine();
            Console.WriteLine("Floor(3.6) = " + Math.Floor(3.6));
            Console.WriteLine("Floor(3.4) = " + Math.Floor(3.4));
            Console.WriteLine("Floor(-3.6) = " + Math.Floor(-3.6));
            Console.WriteLine("Floor(-3.4) = " + Math.Floor(-3.4));
        }

        // דוגמה 25: הקטן והגדול מבין מספרים
        // הפעולות מקבלות שני מספרים ומחזירות את הקטן או את הגדול מביניהם:
        // Math.Min
        // Math.Max
        // כדי למצוא את הגדול מבין שלושה מספרים מפעילים את הפעולה פעמיים:
        // max = Math.Max(Math.Max(num1, num2), num3)
        // התוכנית קולטת שלושה מספרים ומדפיסה את הקטן ואת הגדול ביניהם.
        public static void example25()
        {
            int num1, num2, num3, min, max;

            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            num3 = int.Parse(Console.ReadLine());

            min = Math.Min(Math.Min(num1, num2), num3);
            max = Math.Max(Math.Max(num1, num2), num3);

            Console.WriteLine("The minimum is " + min);
            Console.WriteLine("The maximum is " + max);
        }

        // דוגמה 26: שימוש בקבוע פאי, היקף ושטח של מעגל
        // בספרייה המתמטית מוגדר הקבוע פאי, ואין צורך לכתוב את ערכו בעצמנו:
        // Math.PI
        // היקף מעגל: פעמיים פאי כפול הרדיוס.
        // perimeter = 2 * Math.PI * radius
        // שטח מעגל: פאי כפול הרדיוס בריבוע.
        // area = Math.PI * Math.Pow(radius, 2)
        public static void example26()
        {
            double radius, perimeter, area;

            Console.Write("Enter the circle's radius: ");
            radius = double.Parse(Console.ReadLine());

            perimeter = 2 * Math.PI * radius;
            area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("The perimeter is " + perimeter);
            Console.WriteLine("The area is " + area);
        }

        // דוגמה 27: משפט פיתגורס
        // במשולש ישר זווית, היתר שווה לשורש של סכום ריבועי הניצבים.
        // c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))
        // התוכנית קולטת את אורכי שני הניצבים ומחשבת את אורך היתר.
        // למשל: ניצבים באורך 6 ו-8 נותנים יתר באורך 10.
        public static void example27()
        {
            double a, b, c;

            Console.Write("Enter the first side: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second side: ");
            b = double.Parse(Console.ReadLine());

            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine("The hypotenuse is " + c);
        }

        // דוגמה 28: עיגול מספר לפי מספר ספרות אחרי הנקודה
        // התוכנית קולטת מספר עשרוני ואת מספר הספרות הרצוי אחרי הנקודה.
        // שלב 1: מזיזים את הנקודה ימינה, על ידי כפל בעשר בחזקת מספר הספרות.
        // שלב 2: מעגלים למספר שלם.
        // שלב 3: מחזירים את הנקודה למקומה, על ידי חילוק באותו מספר.
        // למשל, עיגול 456.1234 לשתי ספרות:
        // 456.1234 * 100 = 45612.34
        // Math.Round(45612.34) = 45612
        // 45612 / 100 = 456.12
        public static void example28()
        {
            double num;
            int digits;

            Console.Write("Enter a decimal number: ");
            num = double.Parse(Console.ReadLine());
            Console.Write("How many digits after the point? ");
            digits = int.Parse(Console.ReadLine());

            num = num * Math.Pow(10, digits);
            num = Math.Round(num);
            num = num / Math.Pow(10, digits);

            Console.WriteLine("The rounded number is " + num);
        }

        // דוגמה 29: הגרלת מספרים שלמים
        // כדי להגריל מספרים משתמשים בעצם מטיפוס אקראי שהוגדר בראש המחלקה.
        // rnd
        // הגרלה בלי פרמטרים מחזירה מספר שלם חיובי כלשהו:
        // rnd.Next()
        // הגרלה עם פרמטר אחד מחזירה מספר מאפס ועד המספר, בלי המספר עצמו.
        // למשל, הפקודה הבאה מגרילה מספר בין 0 ל-4:
        // rnd.Next(5)
        // הגרלה עם שני פרמטרים מחזירה מספר מהראשון ועד השני, בלי השני.
        // למשל, הפקודה הבאה מגרילה מספר בין 10 ל-14:
        // rnd.Next(10, 15)
        // בסוף מגרילים זריקה של קובייה, מספר בין 1 ל-6:
        // rnd.Next(1, 7)
        // בכל הרצה יתקבלו מספרים אחרים.
        public static void example29()
        {
            int anyNumber, upTo4, from10To14, dice;
           // static Random rnd = new Random();

            anyNumber = rnd.Next();
            upTo4 = rnd.Next(5);
            from10To14 = rnd.Next(10, 15);
            dice = rnd.Next(1, 7);

            Console.WriteLine("Any positive number: " + anyNumber);
            Console.WriteLine("Between 0 and 4: " + upTo4);
            Console.WriteLine("Between 10 and 14: " + from10To14);
            Console.WriteLine("Dice: " + dice);
        }

        // דוגמה 30: הגרלה בטווח מיוחד
        // מספר דו ספרתי, בין 10 ל-99:
        // rnd.Next(10, 100)
        // מספר זוגי דו ספרתי: מגרילים מספר בין 5 ל-49 וכופלים ב-2.
        // rnd.Next(5, 50) * 2
        // מספר אי זוגי בין 1 ל-99: מגרילים מספר בין 0 ל-49, כופלים ב-2 ומוסיפים 1.
        // rnd.Next(50) * 2 + 1
        // מספר עשרוני בין 0 ל-1, בלי 1 עצמו:
        // rnd.NextDouble()
        // מספר עשרוני בטווח שהמשתמש בוחר: מכפילים בגודל הטווח ומוסיפים את ההתחלה.
        // rnd.NextDouble() * (max - min) + min
        public static void example30()
        {
            int twoDigit, evenTwoDigit, oddUnder100, min, max;
            double zeroToOne, inRange;

            // מגרילים מספר מ-10 עד 99.
            // המספר השני, 100, לא נכלל בהגרלה.
            twoDigit = rnd.Next(10, 100);

            // מגרילים מספר מ-5 עד 49, וכופלים ב-2.
            // מספר כפול 2 הוא תמיד זוגי.
            // הקטן ביותר: 5 כפול 2 הוא 10. הגדול ביותר: 49 כפול 2 הוא 98.
            evenTwoDigit = rnd.Next(5, 50) * 2;

            // מגרילים מספר מ-0 עד 49, כופלים ב-2 ומוסיפים 1.
            // מספר זוגי ועוד 1 הוא תמיד אי זוגי.
            // הקטן ביותר: 0 כפול 2 ועוד 1 הוא 1. הגדול ביותר: 49 כפול 2 ועוד 1 הוא 99.
            oddUnder100 = rnd.Next(50) * 2 + 1;

            // מגרילים מספר עשרוני מ-0 עד 1.
            // יכול לצאת 0, אבל אף פעם לא 1 עצמו.
            zeroToOne = rnd.NextDouble();

            Console.WriteLine("Two digit: " + twoDigit);
            Console.WriteLine("Even two digit: " + evenTwoDigit);
            Console.WriteLine("Odd under 100: " + oddUnder100);
            Console.WriteLine("Between 0 and 1: " + zeroToOne);
            Console.WriteLine();

            Console.Write("Enter the minimum: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Enter the maximum: ");
            max = int.Parse(Console.ReadLine());

            inRange = rnd.NextDouble() * (max - min) + min;

            Console.WriteLine("A random number in the range: " + inRange);
        }

        // ==========================================================
        // ==========================================================

        // דוגמה 31: משפט תנאי פשוט
        // משפט תנאי מבצע הוראות רק אם התנאי שבסוגריים מתקיים.
        // if (num > 0)
        // ההוראות שבתוך הסוגריים המסולסלים מתבצעות רק כשהתנאי אמת.
        // ההוראה שאחרי הסוגריים המסולסלים מתבצעת תמיד.
        // שימו לב: אין נקודה פסיק בסוף שורת התנאי.
        public static void example31()        // פרק 4: משפטי תנאי

        {
            int num;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("The number is positive");
            }

            Console.WriteLine("Bye");
        }

        // דוגמה 32: תנאי עם שתי אפשרויות
        // כשהתנאי אמת מתבצע החלק הראשון, וכשהוא שקר מתבצע החלק השני.
        // if ... else
        // תמיד מתבצע בדיוק אחד משני החלקים.
        // התוכנית בודקת אם מספר זוגי בעזרת שארית החלוקה ב-2.
        public static void example32()
        {
            int num;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is even");
            }
            else
            {
                Console.WriteLine(num + " is odd");
            }
        }

        // דוגמה 33: שרשרת תנאים, רמת הציון
        // כשיש כמה מקרים זרים, כלומר רק אחד מהם יכול לקרות, משתמשים בשרשרת:
        // if ... else if ... else
        // הבדיקה נעצרת בתנאי הראשון שמתקיים.
        // לכן אין צורך לבדוק שהציון קטן מ-90 בתנאי השני:
        // אם הגענו אליו, כבר ידוע שהתנאי הראשון לא התקיים.
        // החלק האחרון מתבצע רק אם אף תנאי לא התקיים.
        public static void example33()
        {
            int grade;

            Console.Write("Enter a grade: ");
            grade = int.Parse(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("Excellent");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

        // דוגמה 34: תנאי מורכב, המספר הגדול מבין שלושה
        // תנאי מורכב בנוי מכמה תנאים שמחוברים בעזרת וגם, או, ושלילה.
        // &&   ||   !
        // התוכנית שומרת את המספר הגדול במשתנה, ומדפיסה אותו פעם אחת בסוף.
        // כך נמנעים משכפול של שורת ההדפסה בכל אחד מהמקרים.
        public static void example34()
        {
            int num1, num2, num3, max;

            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                max = num1;
            }
            else if (num2 >= num3)
            {
                max = num2;
            }
            else
            {
                max = num3;
            }

            Console.WriteLine("The maximum is " + max);
        }

        // דוגמה 35: תנאי עם או, מה לומדים היום
        // ביום ראשון וביום רביעי לומדים מתמטיקה.
        // ביום שני וביום חמישי לומדים מדעי המחשב.
        // ביום שלישי לומדים אנגלית.
        // בשישי ובשבת אין לימודים.
        // כדי להשוות מחרוזות משתמשים בפעולת ההשוואה:
        // dayOfWeek.Equals("Sunday")
        // משתנה בוליאני שומר אם היום שהוקלד תקין, וההדפסה מתבצעת פעם אחת בסוף.
        public static void example35()
        {
            string dayOfWeek, subject = "";
            bool isValidDay = true;

            Console.Write("What is the day today? ");
            dayOfWeek = Console.ReadLine();

            if (dayOfWeek.Equals("Sunday") || dayOfWeek.Equals("Wednesday"))
            {
                subject = "Math";
            }
            else if (dayOfWeek.Equals("Monday") || dayOfWeek.Equals("Thursday"))
            {
                subject = "Computer Science";
            }
            else if (dayOfWeek.Equals("Tuesday"))
            {
                subject = "English";
            }
            else if (dayOfWeek.Equals("Friday") || dayOfWeek.Equals("Saturday"))
            {
                subject = "nothing, it's a free day";
            }
            else
            {
                isValidDay = false;
            }

            if (isValidDay)
            {
                Console.WriteLine("On " + dayOfWeek + " you learn " + subject);
            }
            else
            {
                Console.WriteLine(dayOfWeek + " is not a valid day");
            }
        }

        // דוגמה 36: תנאי בתוך תנאי, תשלום ועד בית
        // בבניין יש דירות של 3, 4 ו-5 חדרים.
        // דירת 3 חדרים משלמת 120 שקלים, ודירת 4 חדרים משלמת 150 שקלים.
        // דירת 5 חדרים משלמת 200 שקלים אם היא דופלקס, ו-180 שקלים אם לא.
        // השאלה אם הדירה דופלקס רלוונטית רק לדירת 5 חדרים,
        // ולכן שואלים אותה רק בתוך המקרה הזה, בתנאי פנימי.
        public static void example36()
        {
            int numOfRooms, price;
            bool isDuplex;

            Console.Write("How many rooms? ");
            numOfRooms = int.Parse(Console.ReadLine());

            if (numOfRooms == 3)
            {
                price = 120;
            }
            else if (numOfRooms == 4)
            {
                price = 150;
            }
            else
            {
                Console.Write("Is it a duplex? (true/false) ");
                isDuplex = bool.Parse(Console.ReadLine());

                if (isDuplex)
                {
                    price = 200;
                }
                else
                {
                    price = 180;
                }
            }

            Console.WriteLine("The price is " + price);
        }

        // דוגמה 37: משפט בחירה, מחשבון
        // כשבודקים שוויון של משתנה אחד מול כמה ערכים קבועים, אפשר להשתמש במשפט בחירה.
        // switch
        // כל מקרה מתחיל במילה הבאה, ואחריה ערך קבוע ונקודתיים:
        // case
        // כל מקרה חייב להסתיים בפקודת יציאה, אחרת יש שגיאת קומפילציה:
        // break;
        // החלק הבא מתבצע אם אף מקרה לא התאים:
        // default
        public static void example37()
        {
            int num1, num2, result = 0;
            char operation;
            bool isValid = true;

            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter an operation (+ - * %): ");
            operation = char.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '%':
                    result = num1 % num2;
                    break;
                default:
                    isValid = false;
                    break;
            }

            if (isValid)
            {
                Console.WriteLine("The result is " + result);
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }
        }

        // דוגמה 38: משפט בחירה עם כמה ערכים לאותו טיפול, ספרות רומיות
        // כשכמה ערכים צריכים לקבל את אותו טיפול, כותבים כמה מקרים ברצף,
        // ואת הקוד המשותף כותבים פעם אחת בלבד, אחרי המקרה האחרון.
        // כך האות הגדולה והאות הקטנה מקבלות את אותו ערך.
        public static void example38()
        {
            char romanDigit;
            int value = 0;
            bool isValid = true;

            Console.Write("Enter a roman digit (I, V, X, L, C): ");
            romanDigit = char.Parse(Console.ReadLine());

            switch (romanDigit)
            {
                case 'i':
                case 'I':
                    value = 1;
                    break;
                case 'v':
                case 'V':
                    value = 5;
                    break;
                case 'x':
                case 'X':
                    value = 10;
                    break;
                case 'l':
                case 'L':
                    value = 50;
                    break;
                case 'c':
                case 'C':
                    value = 100;
                    break;
                default:
                    isValid = false;
                    break;
            }

            if (isValid)
            {
                Console.WriteLine("The value is " + value);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        // דוגמה 39: בחירת ההנחה המשתלמת, מבצעים בחנות בגדים
        // מבצע 1: על כל 300 שקלים בקנייה מקבלים 50 שקלים הנחה.
        // מבצע 2: בקנייה של 3 פריטים ומעלה מקבלים 20 אחוז הנחה.
        // אי אפשר לקבל את שני המבצעים יחד.
        // התוכנית מחשבת את המחיר לפי כל מבצע, ובוחרת את הזול מביניהם.
        // כדי לדעת כמה פעמים 300 נכנס בסכום, משתמשים בחילוק שלמים.
        public static void example39()
        {
            int numOfItems;
            double price, afterDiscount1, afterDiscount2;

            Console.Write("Enter the total price: ");
            price = double.Parse(Console.ReadLine());
            Console.Write("How many items? ");
            numOfItems = int.Parse(Console.ReadLine());

            afterDiscount1 = price - ((int)price / 300) * 50;

            if (numOfItems >= 3)
            {
                afterDiscount2 = price * 0.8;
            }
            else
            {
                afterDiscount2 = price;
            }

            if (afterDiscount1 < afterDiscount2)
            {
                Console.WriteLine("Use discount 1. You pay " + afterDiscount1);
            }
            else
            {
                Console.WriteLine("Use discount 2. You pay " + afterDiscount2);
            }
        }

        // דוגמה 40: זכייה ברולטה
        // התוכנית קולטת את סכום ההימור, ומגרילה מספר בין 1 ל-36.
        // אם המספר מתחלק ב-10, הזכייה היא פי 4 מההימור.
        // אחרת, אם לשתי הספרות של המספר יש אותה זוגיות, הזכייה היא פי 3.
        // אחרת, אם המספר זוגי וקטן מ-20, הזכייה היא פי 2.
        // בכל מקרה אחר אין זכייה.
        // מתחילים מהפרס הגבוה, כי אם המספר עונה על כמה תנאים מקבלים רק את הפרס הגבוה.
        public static void example40()
        {
            int bet, num, ones, tens, win;

            Console.Write("Enter your bet: ");
            bet = int.Parse(Console.ReadLine());

            num = rnd.Next(1, 37);
            Console.WriteLine("The roulette number is " + num);

            ones = num % 10;
            tens = num / 10;

            if (num % 10 == 0)
            {
                win = bet * 4;
            }
            else if (ones % 2 == tens % 2)
            {
                win = bet * 3;
            }
            else if (num < 20 && num % 2 == 0)
            {
                win = bet * 2;
            }
            else
            {
                win = 0;
            }

            if (win > 0)
            {
                Console.WriteLine("You win " + win);
            }
            else
            {
                Console.WriteLine("No luck this time");
            }
        }
    }
}
