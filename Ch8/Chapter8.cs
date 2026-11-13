using System;

namespace Yesodot
{
    // פרק 8: מחרוזות
    // כדי להריץ דוגמה מהקובץ הזה:
    // בקובץ הראשי יש להסיר את סימן ההערה מהשורה של הקובץ הזה,
    // ובפעולת ההרצה שלמטה יש להסיר את סימן ההערה מהדוגמה הרצויה.
    // ליד כל דוגמה כתובות גם פעולות העזר שהיא משתמשת בהן.
    internal static class Chapter8
    {
        // פעולת ההרצה של הקובץ
        public static void Run()
        {
            // יש להסיר את סימן ההערה מהדוגמה שרוצים להריץ

            // פרק 8: מחרוזות
            // example85();
            // example86();
            // example87();
            // example88();
            // example89();
            // example90();
            // example91();
            // example92();
            // example93();
            // example94();
            // example95();
            // example96();
            // example97();
            // example98();
            // example99();
            // example100();
        }

        // ==========================================================
        // פרק 8: מחרוזות
        // ==========================================================

        // דוגמה 85: מהי מחרוזת, והשמה בין מחרוזות
        // מחרוזת היא רצף של תווים, למשל מילה או משפט. כותבים אותה בין גרשיים.
        // גם רווח וסימן פיסוק הם תווים במחרוזת.
        // מחרוזת ריקה היא מחרוזת בלי תווים בכלל.
        // את המחרוזת מדפיסים בין שני קווים, כדי לראות בדיוק איפה היא מתחילה ונגמרת.
        // אי אפשר לשנות מחרוזת קיימת. השמה חדשה יוצרת מחרוזת חדשה.
        public static void example85()
        {
            string s1 = "Hello World!";
            string s2 = "H";
            string s3 = "";

            Console.WriteLine("s1 = |" + s1 + "|");
            Console.WriteLine("s2 = |" + s2 + "|");
            Console.WriteLine("s3 = |" + s3 + "|");

            // השמה בין מחרוזות
            string a = "lion";
            string b = "dog";
            a = b;
            Console.WriteLine("a = " + a + ", b = " + b);

            a = "cat";
            Console.WriteLine("a = " + a + ", b = " + b);
        }

        // דוגמה 86: קליטת מחרוזת
        // הפעולה הבאה מחזירה תמיד מחרוזת, את מה שהמשתמש הקליד:
        // Console.ReadLine()
        // כדי לקבל מספר, הופכים את המחרוזת למספר בעזרת הפעולה הבאה:
        // int.Parse
        public static void example86()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("You entered |" + name + "|");

            Console.Write("Enter an integer number: ");
            string text = Console.ReadLine();
            int num = int.Parse(text);
            Console.WriteLine("The text |" + text + "| as a number, plus 1: " + (num + 1));
        }

        // דוגמה 87: אורך מחרוזת ופנייה לתו
        // האורך הוא מספר התווים במחרוזת. כותבים אותו בלי סוגריים, כי הוא לא פעולה:
        // s.Length
        // פונים לתו לפי המיקום שלו בסוגריים מרובעים. המיקום הראשון הוא 0:
        // s[0]
        // לכן התו האחרון נמצא במיקום של האורך פחות 1.
        // פנייה למיקום שמחוץ למחרוזת גורמת לשגיאה בזמן ריצה.
        public static void example87()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.WriteLine("Length: " + word.Length);
            Console.WriteLine("First letter: " + word[0]);
            Console.WriteLine("Last letter: " + word[word.Length - 1]);

            // מעבר על כל התווים בלולאה, מהמיקום 0 עד האורך
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(i + ": " + word[i]);
            }
        }

        // דוגמה 88: מעבר על מחרוזת, ספירת מילים
        // סופרים את הרווחים במשפט. בין כל שתי מילים יש רווח אחד,
        // ולכן מספר המילים גדול באחד ממספר הרווחים.
        // תו בודד כותבים בין גרש לגרש, למשל רווח.
        public static void example88()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            Console.WriteLine("Words: " + CountWords(sentence));
        }

        // הפעולה מקבלת משפט שבין כל שתי מילים בו יש רווח אחד.
        // הפעולה מחזירה את מספר המילים במשפט.
        static int CountWords(string str)
        {
            if (str == "")
            {
                return 0;
            }

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
            }

            return count + 1;
        }

        // דוגמה 89: מחרוזת פלינדרום
        // פלינדרום נקרא אותו דבר משני הכיוונים.
        // משווים את התו הראשון לאחרון, את השני ללפני האחרון, וכן הלאה.
        // שני משתנים זזים זה לקראת זה, עד שהם נפגשים.
        public static void example89()
        {
            Console.WriteLine("level: " + IsPalindrome("level"));
            Console.WriteLine("hannah: " + IsPalindrome("hannah"));
            Console.WriteLine("levdl: " + IsPalindrome("levdl"));
        }

        // הפעולה מקבלת מחרוזת.
        // הפעולה מחזירה אמת אם המחרוזת פלינדרום, ושקר אחרת.
        static bool IsPalindrome(string str)
        {
            int begin = 0;
            int end = str.Length - 1;

            while (begin < end)
            {
                if (str[begin] != str[end])
                {
                    return false;
                }
                begin++;
                end--;
            }

            return true;
        }

        // דוגמה 90: שרשור מחרוזות
        // הסימן פלוס מחבר שתי מחרוזות למחרוזת חדשה אחת.
        // כשמחברים מחרוזת ומספר, המספר הופך לחלק מהמחרוזת.
        // השרשור מתבצע משמאל לימין, ולכן כדי לחבר מספרים צריך סוגריים.
        // הסימן הבא מוסיף לסוף המחרוזת שבמשתנה, בדיוק כמו השמה של המחרוזת והתוספת:
        // s += t
        public static void example90()
        {
            Console.Write("Enter first word: ");
            string w1 = Console.ReadLine();
            Console.Write("Enter second word: ");
            string w2 = Console.ReadLine();

            Console.WriteLine(w1 + w2);
            Console.WriteLine(w1 + " " + w2);

            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            // בלי סוגריים: קודם מחברים את הגיל למחרוזת, ואחר כך את 1
            Console.WriteLine("Next year you will be " + age + 1);
            // עם סוגריים: קודם מחשבים את הסכום
            Console.WriteLine("Next year you will be " + (age + 1));

            string str = "It's a bea";
            str += "utiful day";
            Console.WriteLine(str);
        }

        // דוגמה 91: השוואת מחרוזות לשוויון
        // בודקים אם שתי מחרוזות זהות בעזרת הסימן הבא, או בעזרת הפעולה שאחריו:
        // ==
        // Equals
        // ההשוואה מבחינה בין אות גדולה לאות קטנה.
        // לבדיקה שהמחרוזות שונות משתמשים בסימן הבא:
        // !=
        public static void example91()
        {
            string s1 = "hello";
            string s2 = "hello";
            string s3 = "Hello";

            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1 == s3);
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.Equals(s3));
            Console.WriteLine(s1 != s3);

            Console.Write("Enter the password: ");
            string password = Console.ReadLine();
            if (password == "abc123")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }

        // דוגמה 92: איזו מחרוזת קודמת במילון
        // הפעולה הבאה משווה בין שתי מחרוזות לפי סדר המילון:
        // s1.CompareTo(s2)
        // היא מחזירה מספר שלילי אם הראשונה קודמת במילון, חיובי אם היא באה אחרי, ואפס אם הן זהות.
        public static void example92()
        {
            Console.Write("Enter first word: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter second word: ");
            string s2 = Console.ReadLine();

            int res = s1.CompareTo(s2);
            Console.WriteLine("CompareTo returns " + res);

            if (res < 0)
            {
                Console.WriteLine(s1 + " comes before " + s2);
            }
            else if (res > 0)
            {
                Console.WriteLine(s2 + " comes before " + s1);
            }
            else
            {
                Console.WriteLine("The words are the same");
            }
        }

        // דוגמה 93: חיפוש במחרוזת
        // הפעולה הבאה מחזירה את המיקום הראשון של תו או של מחרוזת:
        // IndexOf
        // אם הם לא נמצאים, היא מחזירה מינוס 1.
        // אפשר לשלוח לה גם מיקום, וממנו יתחיל החיפוש.
        // הפעולה הבאה מחזירה את המיקום האחרון:
        // LastIndexOf
        public static void example93()
        {
            string s = "abcdabcd";

            Console.WriteLine(s.IndexOf('b'));
            Console.WriteLine(s.IndexOf('z'));
            Console.WriteLine(s.IndexOf("cd"));
            Console.WriteLine(s.IndexOf("cde"));
            Console.WriteLine(s.IndexOf("cd", 3));
            Console.WriteLine(s.LastIndexOf('a'));
            Console.WriteLine(s.LastIndexOf("cd"));
        }

        // דוגמה 94: תת מחרוזת
        // הפעולה הבאה מחזירה את החלק של המחרוזת מהמיקום שקיבלה ועד הסוף:
        // Substring(5)
        // עם שני ערכים: מיקום ההתחלה, ומספר התווים:
        // Substring(5, 3)
        // מיקום או אורך שחורגים מהמחרוזת גורמים לשגיאה בזמן ריצה.
        public static void example94()
        {
            string s = "good morning";

            Console.WriteLine(s.Substring(5));
            Console.WriteLine(s.Substring(5, 3));
            Console.WriteLine(s.Substring(0, 4));

            // שם פרטי ושם משפחה: מפצלים לפי הרווח
            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();
            int space = fullName.IndexOf(' ');
            Console.WriteLine("First name: " + fullName.Substring(0, space));
            Console.WriteLine("Last name: " + fullName.Substring(space + 1));
        }

        // דוגמה 95: החלפה במחרוזת
        // הפעולה הבאה מחליפה כל מופע של תו בתו אחר, או של מחרוזת במחרוזת אחרת:
        // Replace
        // המחרוזת המקורית לא משתנה. הפעולה מחזירה מחרוזת חדשה.
        public static void example95()
        {
            string s = "good morning";

            Console.WriteLine(s.Replace('o', 'O'));
            Console.WriteLine(s.Replace("morning", "night"));
            Console.WriteLine(s);

            // כדי לשמור את השינוי, מציבים את התוצאה במשתנה
            s = s.Replace("good", "nice");
            Console.WriteLine(s);
        }

        // דוגמה 96: הוספה ומחיקה
        // הפעולה הבאה מוסיפה מחרוזת החל ממיקום מסוים:
        // Insert(pos, text)
        // הפעולה הבאה מוחקת מספר תווים החל ממיקום מסוים:
        // Remove(pos, count)
        // שתיהן מחזירות מחרוזת חדשה, ולא משנות את המקורית.
        public static void example96()
        {
            string str = "C# is nice";

            int pos = str.IndexOf("nice");
            Console.WriteLine(str.Insert(pos, "very "));

            string longer = "C# is very nice";
            pos = longer.IndexOf("very");
            Console.WriteLine(longer.Remove(pos, 5));
            Console.WriteLine(longer);
        }

        // דוגמה 97: אותיות גדולות וקטנות
        // הפעולה הבאה מחזירה מחרוזת שבה כל האותיות קטנות:
        // ToLower
        // הפעולה הבאה מחזירה מחרוזת שבה כל האותיות גדולות:
        // ToUpper
        // שימוש נפוץ: השוואה שלא מבחינה בין אות גדולה לקטנה.
        public static void example97()
        {
            string s = "abc!12ABC#";
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());

            Console.Write("Do you want to continue? ");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("Continuing");
            }
            else
            {
                Console.WriteLine("Stopping");
            }
        }

        // דוגמה 98: שאלת סיכום, התווים המשותפים לשתי מחרוזות
        // עוברים על התווים של המחרוזת הראשונה.
        // תו שנמצא גם במחרוזת השנייה, ועוד לא נמצא בתוצאה, מוסיפים לתוצאה.
        public static void example98()
        {
            Console.WriteLine(Intersection("happiness", "inspiration"));
            Console.WriteLine(Intersection("friendship", "wonderful"));
        }

        // הפעולה מקבלת שתי מחרוזות.
        // הפעולה מחזירה מחרוזת עם התווים שמופיעים בשתיהן, כל תו פעם אחת.
        static string Intersection(string str1, string str2)
        {
            string result = "";

            for (int i = 0; i < str1.Length; i++)
            {
                char ch = str1[i];
                if (str2.IndexOf(ch) != -1 && result.IndexOf(ch) == -1)
                {
                    result += ch;
                }
            }

            return result;
        }

        // דוגמה 99: שאלת סיכום, הרצף הארוך ביותר
        // מחפשים את הרצף הארוך ביותר של תווים זהים, זה אחרי זה.
        // משווים כל תו לתו שלפניו. אם הם שווים, הרצף ממשיך. אחרת מתחיל רצף חדש.
        // זה אותו רעיון של מציאת מקסימום מפרק 5.
        public static void example99()
        {
            Console.WriteLine(LongestRun("LLOOOVVVVE"));
            Console.WriteLine(LongestRun("inspiration"));
            Console.WriteLine(LongestRun(""));
        }

        // הפעולה מקבלת מחרוזת.
        // הפעולה מחזירה את האורך של הרצף הארוך ביותר של תווים זהים.
        static int LongestRun(string input)
        {
            if (input == "")
            {
                return 0;
            }

            int max = 1;
            int current = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    current++;
                    if (current > max)
                    {
                        max = current;
                    }
                }
                else
                {
                    current = 1;
                }
            }

            return max;
        }

        // דוגמה 100: שאלת סיכום, מיון מילים במשפט
        // מפרקים את המשפט למילים לפי הרווחים.
        // כל מילה מכניסים למקום הנכון במשפט חדש, שנשאר ממוין לפי סדר המילון.
        // פעולה אחת מכניסה מילה אחת למקומה, ופעולה שנייה עוברת על כל המילים.
        public static void example100()
        {
            Console.WriteLine(SortWords("elegantly dances forward a big gracefully cat"));
        }

        // הפעולה מקבלת משפט ממוין ומילה.
        // הפעולה מחזירה משפט ממוין חדש, שהמילה נמצאת בו במקומה.
        static string InsertInPlace(string sorted, string word)
        {
            if (sorted.Length == 0)
            {
                return word;
            }

            string start = "";
            int spacePos = sorted.IndexOf(' ');

            while (spacePos >= 0)
            {
                // אם המילה קודמת במילון למילה הראשונה במשפט, היא נכנסת לפניה
                if (word.CompareTo(sorted.Substring(0, spacePos)) < 0)
                {
                    return start + word + " " + sorted;
                }

                // אחרת מעבירים את המילה הראשונה לסוף ההתחלה, וממשיכים
                start += sorted.Substring(0, spacePos + 1);
                sorted = sorted.Substring(spacePos + 1);
                spacePos = sorted.IndexOf(' ');
            }

            // נשארה מילה אחרונה: המילה נכנסת לפניה או אחריה
            if (word.CompareTo(sorted) < 0)
            {
                return start + word + " " + sorted;
            }
            return start + sorted + " " + word;
        }

        // הפעולה מקבלת משפט שבין כל שתי מילים בו יש רווח אחד.
        // הפעולה מחזירה משפט חדש שבו המילים ממוינות לפי סדר המילון.
        static string SortWords(string input)
        {
            string sorted = "";

            if (input.Length == 0)
            {
                return sorted;
            }

            int spacePos = input.IndexOf(' ');
            while (spacePos != -1)
            {
                string word = input.Substring(0, spacePos);
                sorted = InsertInPlace(sorted, word);
                input = input.Substring(spacePos + 1);
                spacePos = input.IndexOf(' ');
            }

            // המילה האחרונה, שאין אחריה רווח
            sorted = InsertInPlace(sorted, input);
            return sorted;
        }
    }
}
