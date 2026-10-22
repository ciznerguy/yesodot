using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesodot
{
    // פרקים 1 ו-2: הוראות הדפסה ומשתנים, אופרטורים וביטויים לוגיים
    // כדי להריץ דוגמה מהקובץ הזה:
    // בקובץ הראשי יש להסיר את סימן ההערה מהשורה של הקובץ הזה,
    // ובפעולת ההרצה שלמטה יש להסיר את סימן ההערה מהדוגמה הרצויה.
    internal static class Chapter1_2
    {
        // פעולת ההרצה של הקובץ
        public static void Run()
        {
            // יש להסיר את סימן ההערה מהדוגמה שרוצים להריץ

            // פרק 1: הוראות הדפסה ומשתנים
            // example1();
            //example2();
            // example3();
            //example4();
            // example5();
             //example6();
           // example7();
           // example8();
             example9();

            // פרק 2: אופרטורים וביטויים לוגיים
            // example10();
            // example11();
            // example12();
            // example13();
            // example14();
            // example15();
            // example16();
            // example17();
            // example18();
            // example19();
            // example20();
        }

        // ==========================================================
        // פרק 1: הוראות הדפסה ומשתנים
        // ==========================================================

        // דוגמה 1: סוגי משתנים והגדרתם
        // משתנה הוא מקום בזיכרון שבו שומרים נתון.
        // בהגדרה כותבים קודם את הטיפוס ואחריו את שם המשתנה.
        // אפשר להגדיר כמה משתנים מאותו טיפוס בשורה אחת, מופרדים בפסיק.
        // אפשר לתת למשתנה ערך כבר בהגדרה שלו.
        // כללים לשמות משתנים:
        // מותר להשתמש באותיות, ספרות וקו תחתון בלבד.
        // אסור רווחים, ואסור להתחיל בספרה.
        // יש הבדל בין אותיות גדולות לקטנות.
        // נהוג לתת שם משמעותי, וכל מילה חדשה בשם מתחילה באות גדולה.
        public static void example1()
        {
            // מספר שלם, חיובי או שלילי, בלי נקודה עשרונית.
            // תופס 4 בתים בזיכרון.
            // int
            // 32, 0, -7
            int numOfStudents = 325;

            // מספר עשרוני (ממשי), יכול להכיל גם שבר.
            // תופס 8 בתים בזיכרון.
            // double
            // 87.5, -2.25, 3.0
            double average = 87.5;

            // תו אחד בלבד: אות, ספרה או סימן.
            // נכתב בין גרשיים בודדים.
            // תופס 2 בתים בזיכרון.
            // char
            // 'A', '7', '!'
            char grade = 'א';

            // ערך לוגי: אמת או שקר בלבד.
            // תופס בית אחד בזיכרון.
            // bool
            // true, false
            bool isPassed = true;

            // מחרוזת: רצף של תווים (טקסט) בכל אורך.
            // נכתבת בין גרשיים כפולים.
            // string
            // "Hello", "Grade 11", ""
            string className = "Grade 11 ++++";

            // הגדרת כמה משתנים מאותו טיפוס בשורה אחת, חלקם עם ערך התחלתי
            int x = 5, y = 10;
            double sum;
            sum = x + y+3.5;

            Console.WriteLine("int: " + numOfStudents);
            Console.WriteLine("double: " + average);
            Console.WriteLine("char: " + grade);
            Console.WriteLine("bool: " + isPassed);
            Console.WriteLine("string: " + className);
            Console.WriteLine("sum = " + sum);
        }

        // דוגמה 2: ההבדל בין 
        //Write WriteLine
 
        public static void example2()
        {
            Console.WriteLine("Hello World!\n");
            Console.Write("Hi!");
            Console.WriteLine();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hi!");
        }

        // דוגמה 3: קליטת מחרוזת מהמשתמש והדפסתה
        // פקודת הקלט קולטת טקסט מהמשתמש, והוא נשמר במשתנה מטיפוס מחרוזת:
        // Console.ReadLine
        // סימן החיבור מחבר (משרשר) את הטקסט הקבוע לערך של המשתנה.
        public static void example3()
        {
            string name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
        }

        // דוגמה 4: קליטת נתונים מטיפוסים שונים
        // כל קלט מתקבל כמחרוזת.
        // כדי להפוך אותו למספר, תו או ערך בוליאני משתמשים בפעולת ההמרה:
        // int.Parse, double.Parse, char.Parse, bool.Parse
        // בסוף מחשבים את הגיל מתוך שנת הלידה והשנה הנוכחית.
        public static void example4()
        {
            int yearOfBirth, currentYear, age;
            double gradesAverage;
            char bestGrade;
            bool likeProgramming;

            Console.Write("Enter your birth year: ");
            yearOfBirth = int.Parse(Console.ReadLine());
            Console.Write("What is the year now? ");
            currentYear = int.Parse(Console.ReadLine());
            Console.Write("Enter your grades average: ");
            gradesAverage = double.Parse(Console.ReadLine());
            Console.Write("Enter your best grade (one letter): ");
            bestGrade = char.Parse(Console.ReadLine());
            Console.Write("Do you like programming? (true/false) ");
            likeProgramming = bool.Parse(Console.ReadLine());

            age = currentYear - yearOfBirth;
            Console.WriteLine("You are " + age + " years old");
            Console.WriteLine("Your average is " + gradesAverage + " and your best grade is " + bestGrade);
            Console.WriteLine("Do you like programming? " + likeProgramming);
        }

        // דוגמה 5: אתחול והשמה
        // אפשר לתת ערך למשתנה כבר בהגדרה שלו, או אחר כך במשפט השמה.
        // בהשמה מחשבים קודם את הביטוי שבצד ימין, ורק אז שמים את התוצאה במשתנה שמשמאל.
        // שימוש במשתנה שלא קיבל ערך גורם לשגיאת קומפילציה.
        public static void example5()
        {
            int x, y, z = 9;
            x = 5;
            y = x * 3;
            Console.WriteLine("x = " + x + ", y = " + y + ", z = " + z);
            x = x + 1;//x++;
            Console.WriteLine("x after x = x + 1 is " + x);
        }

        // דוגמה 6: השמה בין טיפוסים שונים
        // מעבר ממספר עשרוני לשלם מחייב המרה מפורשת, והחלק העשרוני נחתך:
        // n1 = (int)d;
        // מעבר ממספר שלם לעשרוני לא מאבד מידע, ולכן לא צריך המרה:
        // d = n1;
        // מחרוזת הופכת למספר בעזרת פעולת ההמרה:
        // d = double.Parse(s);
        // מספר הופך למחרוזת על ידי שרשור עם מחרוזת ריקה:
        // s = n1 + "";
        public static void example6()
        {
            int n1 = 3;
            double d = 97.8;
            string s = "45.658";

            n1 = (int)d;
            Console.WriteLine("n1 = " + n1);
            d = n1;
            Console.WriteLine("d = " + d);
            d = double.Parse(s);
            Console.WriteLine("d = " + d);
            s = n1 + " guy";
            Console.WriteLine("s = " + s);
        }

        // דוגמה 7: חישוב שטח והיקף של מלבן
        // התוכנית קולטת מהמשתמש את אורך המלבן ואת רוחבו.
        // את תוצאות החישוב שומרים במשתנים, ורק אחר כך מדפיסים אותן.
        // שטח מלבן: אורך כפול רוחב.
        // area = length * width
        // היקף מלבן: פעמיים סכום האורך והרוחב.
        // perimeter = 2 * (length + width)
        public static void example7()
        {
            double length, width, area, hekef;

            Console.Write("Enter the rectangle's length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Enter the rectangle's width: ");
            width = double.Parse(Console.ReadLine());

            area = length * width;
            hekef = 2 * (length + width);

            Console.WriteLine("The area is " + area);
            Console.WriteLine("The perimeter is " + hekef);
        }

        // דוגמה 8: הדפסת תווים מיוחדים
        // ירידת שורה:
        // \n
        // רווח של טאב:
        // \t
        // הדפסת גרשיים:
        // \"
        // הדפסת לוכסן הפוך:
        // \\
        public static void example8()
        {
            Console.WriteLine("Hello World!\nNew Line");
            Console.WriteLine("Hello\tWorld!");
            Console.WriteLine("\"Hello World!\"");
            Console.WriteLine("\\Hello World!");
        }

        // דוגמה 9: קלט, חישוב ופלט, ממוצע של שני ציונים
        // קלט: התוכנית קולטת שם של תלמיד ושני ציונים.
        // חישוב: הממוצע הוא סכום שני הציונים חלקי 2, והוא נשמר במשתנה.
        // פלט: התוכנית מדפיסה את שם התלמיד ואת הממוצע שלו.
        // שימו לב: הציונים הם מספרים שלמים, וגם 2 הוא מספר שלם.
        // לכן זו חלוקת שלמים, והחלק העשרוני של התוצאה נחתך,
        // עוד לפני שהתוצאה נכנסת למשתנה העשרוני.
        // למשל: 85 ו-90 נותנים 87 ולא 87.5.
        // כדי לקבל ממוצע מדויק מחלקים במספר עשרוני:
        // average = (grade1 + grade2) / 2.0;
        public static void example9()
        {
            string name;
            int grade1, grade2;
            double average;

            Console.Write("Enter the student's name: ");
            name = Console.ReadLine();
            Console.Write("Enter the first grade: ");
            grade1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second grade: ");
            grade2 = int.Parse(Console.ReadLine());

            average = (grade1 + grade2) / 2.0;

            Console.WriteLine("The average of " + name + " is " + average);
        }

        // ==========================================================
        // פרק 2: אופרטורים וביטויים לוגיים
        // ==========================================================

        // דוגמה 10: פעולות חשבון
        // חיבור, חיסור, כפל, חילוק ושארית.
        // כששני המספרים שלמים, החילוק מחזיר רק את החלק השלם של התוצאה.
        // כשלפחות אחד המספרים עשרוני, התוצאה עשרונית.
        // פעולת השארית מחזירה את מה שנשאר אחרי החלוקה:
        // %
        // אסור לחלק באפס.
        public static void example10()
        {
            int x = 13, y = 5;
            double z = 13.5;

            Console.WriteLine("13 + 5 = " + (x + y));
            Console.WriteLine("13 - 5 = " + (x - y));
            Console.WriteLine("13 * 5 = " + (x * y));
            Console.WriteLine("13 / 5 = " + (x / y));
            Console.WriteLine("13.5 / 5 = " + (z / y));
            Console.WriteLine("13 % 5 = " + (x % y));
            Console.WriteLine("13.5 % 5 = " + (z % y));
        }

        // דוגמה 11: חישוב מנה ושארית
        // כשמחלקים מספר שלם במספר שלם מקבלים שני חלקים:
        // המנה: כמה פעמים המחלק נכנס במספר. מחשבים אותה בעזרת חילוק:
        // quotient = num / divisor
        // השארית: מה שנשאר אחרי החלוקה. מחשבים אותה בעזרת פעולת השארית:
        // remainder = num % divisor
        // השארית תמיד קטנה מהמחלק.
        // אפשר לבדוק את החישוב: המנה כפול המחלק ועוד השארית שווה למספר המקורי.
        // quotient * divisor + remainder == num
        // דוגמאות להמחשה:
        // 17 / 5 = 3       17 % 5 = 2       3 * 5 + 2 = 17
        // 20 / 4 = 5       20 % 4 = 0       5 * 4 + 0 = 20
        // 7 / 10 = 0       7 % 10 = 7       0 * 10 + 7 = 7
        // 100 / 7 = 14     100 % 7 = 2      14 * 7 + 2 = 100
        // בסוף הדוגמה המשתמש מקליד מספר ומחלק, והתוכנית מחשבת בעצמה.
        public static void example11()
        {
            Console.WriteLine("17 / 5 = " + (17 / 5) + ",  17 % 5 = " + (17 % 5));
            Console.WriteLine("20 / 4 = " + (20 / 4) + ",  20 % 4 = " + (20 % 4));
            Console.WriteLine("7 / 10 = " + (7 / 10) + ",  7 % 10 = " + (7 % 10));
            Console.WriteLine("100 / 7 = " + (100 / 7) + ",  100 % 7 = " + (100 % 7));
            Console.WriteLine();

            int num, divisor, quotient, remainder;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Enter a divisor: ");
            divisor = int.Parse(Console.ReadLine());

            quotient = num / divisor;
            remainder = num % divisor;

            Console.WriteLine(num + " / " + divisor + " = " + quotient);
            Console.WriteLine(num + " % " + divisor + " = " + remainder);
            Console.WriteLine("Check: " + quotient + " * " + divisor + " + " + remainder + " = " + (quotient * divisor + remainder));
        }

        // דוגמה 12: בדיקה אם מספר זוגי בעזרת שארית
        // שארית החלוקה ב-2 היא תמיד 0 או 1.
        // אם השארית היא 0 המספר זוגי, ואם היא 1 המספר אי זוגי.
        // את תוצאת הבדיקה שומרים במשתנה בוליאני:
        // bool isEven = num % 2 == 0;
        public static void example12()
        {
            int num, remainder;
            bool isEven;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            remainder = num % 2;
            isEven = num % 2 == 0;

            Console.WriteLine("The remainder is " + remainder);
            Console.WriteLine("Is the number even? " + isEven);
        }

        // דוגמה 13: פירוק מספר תלת ספרתי לספרות
        // שארית החלוקה ב-10 נותנת את ספרת האחדות.
        // חילוק ב-10 מוחק את ספרת האחדות.
        // ספרת האחדות:
        // units = num % 10
        // ספרת העשרות:
        // tens = num / 10 % 10
        // ספרת המאות:
        // hundreds = num / 100
        // בסוף מחשבים גם את סכום הספרות.
        public static void example13()
        {
            int num, units, tens, hundreds, sumOfDigits;

            Console.Write("Enter a 3 digit number: ");
            num = int.Parse(Console.ReadLine());

            units = num % 10;
            tens = num / 10 % 10;
            hundreds = num / 100;
            sumOfDigits = units + tens + hundreds;

            Console.WriteLine("Hundreds: " + hundreds);
            Console.WriteLine("Tens: " + tens);
            Console.WriteLine("Units: " + units);
            Console.WriteLine("Sum of digits: " + sumOfDigits);
        }

        // דוגמה 14: מספר שמייצג שעה
        // המשתמש מקליד שעה כמספר אחד, למשל 1245.
        // השעות הן המספר חלקי 100:
        // hours = theTime / 100
        // הדקות הן השארית מחלוקה ב-100:
        // minutes = theTime % 100
        public static void example14()
        {
            int theTime, hours, minutes;

            Console.Write("Enter the time: ");
            theTime = int.Parse(Console.ReadLine());

            hours = theTime / 100;
            minutes = theTime % 100;

            Console.WriteLine("The time is " + hours + ":" + minutes);
        }

        // דוגמה 15: סדר פעולות החשבון
        // קודם מחשבים את מה שבסוגריים.
        // אחר כך כפל, חילוק ושארית.
        // בסוף חיבור וחיסור.
        // פעולות באותה רמה מחושבות משמאל לימין.
        // לפני ההרצה, נסו לחשב בעצמכם מה יודפס בכל שורה.
        public static void example15()
        {
            Console.WriteLine(2 + 3 * 4);
            Console.WriteLine((2 + 3) * 4);
            Console.WriteLine(10 - 4 - 3);
            Console.WriteLine(20 / 4 * 5);
            Console.WriteLine(17 % 5 * 2);
            Console.WriteLine(1 + (4 + 5) * (3 / 2) % 5);
        }

        // דוגמה 16: שרשור מול חיבור
        // כשמחברים מחרוזת עם מספר, סימן החיבור משרשר ולא מחשב.
        // ההדפסה מתבצעת משמאל לימין, ולכן המספר הראשון מתחבר למחרוזת,
        // ואחריו גם המספר השני מתחבר למחרוזת.
        // כדי לקבל את סכום המספרים צריך לשים אותם בסוגריים,
        // או לחשב את הסכום קודם ולשמור אותו במשתנה.
        public static void example16()
        {
            int n1, n2, sum;

            Console.Write("Enter the first number: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            n2 = int.Parse(Console.ReadLine());

            sum = n1 + n2;

            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The sum is " + (n1 + n2));
            Console.WriteLine("The sum is " + n1 + n2);
        }

        // דוגמה 17: הגדלה והקטנה באחד
        // שלוש הדרכים הבאות מגדילות משתנה באחד:
        // x = x + 1;    x++;    ++x;
        // כשהאופרטור אחרי המשתנה, קודם משתמשים בערך הישן ורק אחר כך מגדילים.
        // y = x++;
        // כשהאופרטור לפני המשתנה, קודם מגדילים ורק אחר כך משתמשים בערך החדש.
        // y = ++x;
        // אותם כללים נכונים גם להקטנה באחד.
        public static void example17()
        {
            int x, y;

            x = 4;
            y = x++;
            Console.WriteLine("x = " + x + ", y = " + y);

            x = 4;
            y = ++x;
            Console.WriteLine("x = " + x + ", y = " + y);

            x = 4;
            y = x--;
            Console.WriteLine("x = " + x + ", y = " + y);

            x = 4;
            y = --x;
            Console.WriteLine("x = " + x + ", y = " + y);
        }

        // דוגמה 18: אופרטורים מקוצרים
        // אפשר לכתוב פעולה על משתנה בצורה מקוצרת.
        // שתי השורות הבאות זהות:
        // x = x + 5;
        // x += 5;
        // הכתיבה המקוצרת עובדת עם כל פעולות החשבון.
        // שימו לב: הביטוי שמימין מחושב קודם, כאילו הוא בסוגריים.
        // x *= y + 1;
        // x = x * (y + 1);
        public static void example18()
        {
            int x = 10, y = 2;

            x += 5;
            Console.WriteLine(x);
            x -= 3;
            Console.WriteLine(x);
            x *= 2;
            Console.WriteLine(x);
            x /= 4;
            Console.WriteLine(x);
            x %= 4;
            Console.WriteLine(x);

            x = 3;
            x *= y + 1;
            Console.WriteLine(x);
        }

        // דוגמה 19: המרות בין טיפוסים
        // בביטוי עם מספר שלם ומספר עשרוני, השלם מומר אוטומטית לעשרוני.
        // ההמרה זמנית, רק לצורך החישוב, והמשתנה עצמו לא משתנה.
        // החישוב נעשה לפי סדר הפעולות, ולכן חילוק בין שני שלמים נשאר חילוק שלמים.
        // כדי לעבור מעשרוני לשלם צריך המרה מפורשת, והחלק העשרוני נחתך.
        // להמרה המפורשת יש קדימות גבוהה, ולכן היא מתבצעת לפני החילוק:
        // (double)n1 / n2
        public static void example19()
        {
            int n1 = 5, n2 = 8, n;
            double d1 = 7, d0;

            d0 = d1 + n1 / n2;
            Console.WriteLine(d0);

            d0 = d1 + (double)n1 / n2;
            Console.WriteLine(d0);

            d0 = n1 / n2;
            Console.WriteLine(d0);

            n = (int)(9 / 2.0 + 5);
            Console.WriteLine(n);
        }

        // דוגמה 20: אופרטורי השוואה ואופרטורים לוגיים
        // אופרטור השוואה מחזיר אמת או שקר:
        // <   <=   >   >=   ==   !=
        // וגם: התוצאה אמת רק אם שני התנאים אמת.
        // &&
        // או: התוצאה אמת אם לפחות אחד התנאים אמת.
        // ||
        // שלילה: הופכת אמת לשקר ושקר לאמת.
        // !
        // אם התוצאה ברורה כבר אחרי התנאי הראשון, התנאי השני לא נבדק.
        public static void example20()
        {
            int num;
            bool isPositive, isTwoDigit, isOutOfRange, isOdd;

            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            isPositive = num > 0;
            isTwoDigit = num >= 10 && num <= 99;
            isOutOfRange = num < 0 || num > 100;
            isOdd = !(num % 2 == 0);

            Console.WriteLine("Positive: " + isPositive);
            Console.WriteLine("Two digit: " + isTwoDigit);
            Console.WriteLine("Out of range 0-100: " + isOutOfRange);
            Console.WriteLine("Odd: " + isOdd);
        }
    }
}
