using System;

namespace Yesodot
{
    // פרק 9: מערך חד ממדי
    // כדי להריץ דוגמה מהקובץ הזה:
    // בקובץ הראשי יש להסיר את סימן ההערה מהשורה של הקובץ הזה,
    // ובפעולת ההרצה שלמטה יש להסיר את סימן ההערה מהדוגמה הרצויה.
    // ליד כל דוגמה כתובות גם פעולות העזר שהיא משתמשת בהן.
    internal static class Chapter9
    {
        // פעולת ההרצה של הקובץ
        public static void Run()
        {
            // יש להסיר את סימן ההערה מהדוגמה שרוצים להריץ

            // פרק 9: מערך חד ממדי
            // example101();
            // example102();
            // example103();
            // example104();
            // example105();
            // example106();
            // example107();
            // example108();
            // example109();
            // example110();
            // example111();
            // example112();
            // example113();
            // example114();
            // example115();
            // example116();
            // example117();
            // example118();
            // example119();
            // example120();
            // example121();
        }

        // ==========================================================
        // פרק 9: מערך חד ממדי
        // ==========================================================

        // דוגמה 101: למה צריך מערך
        // התוכנית קולטת מספרים ומדפיסה כמה מהם גדולים מהממוצע.
        // בלי מערך היינו צריכים משתנה נפרד לכל מספר, ותנאי נפרד לכל משתנה.
        // עם מערך יש שם אחד לכל המספרים, ועוברים עליהם בלולאה.
        // כדי לעבור ל-20 מספרים או ל-100 מספרים משנים רק את הקבוע.
        public static void example101()
        {
            const int SIZE = 5;
            int[] numbers = new int[SIZE];
            int sum = 0;

            Console.WriteLine("Please insert " + SIZE + " numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sum = sum + numbers[i];
            }

            double average = sum / (double)SIZE;

            int countAboveAverage = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > average)
                {
                    countAboveAverage++;
                }
            }

            Console.WriteLine(countAboveAverage + " values are above the average " + average);
        }

        // דוגמה 102: הגדרת מערך ואתחול
        // מערך הוא אוסף של משתנים מאותו טיפוס, עם שם אחד.
        // בהגדרה כותבים את הטיפוס, סוגריים מרובעים, ואת מספר האיברים:
        // int[] numbers = new int[5];
        // במערך של מספרים, כל האיברים מקבלים בהתחלה את הערך 0.
        // אפשר גם לתת ערכים כבר בהגדרה, בתוך סוגריים מסולסלים.
        public static void example102()
        {
            int[] numbers = new int[5];
            Console.Write("numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            // אתחול עם ערכים בזמן ההגדרה
            int[] grades = { 85, 92, 70 };
            char[] letters = { 'm', 'A', 'k' };
            string[] names = { "Dana", "Moshe", "Haim" };

            Console.WriteLine("grades: " + grades[0] + " " + grades[1] + " " + grades[2]);
            Console.WriteLine("letters: " + letters[0] + " " + letters[1] + " " + letters[2]);
            Console.WriteLine("names: " + names[0] + " " + names[1] + " " + names[2]);
        }

        // דוגמה 103: גישה לאיברי המערך
        // לכל איבר יש מספר מקום, שנקרא אינדקס.
        // האיבר הראשון במקום 0, והאחרון במקום שקטן באחד ממספר האיברים.
        // עם איבר במערך עושים כל מה שעושים עם משתנה רגיל: השמה, חישוב, הגדלה ב-1.
        // מספר האיברים במערך נמצא במאפיין הבא:
        // Length
        public static void example103()
        {
            int[] numbers = new int[3];

            numbers[0] = 25;
            numbers[0]++;
            numbers[1] = numbers[0] * 2;
            numbers[2] = numbers[0] + numbers[1];

            Console.WriteLine("numbers[0] = " + numbers[0]);
            Console.WriteLine("numbers[1] = " + numbers[1]);
            Console.WriteLine("numbers[2] = " + numbers[2]);
            Console.WriteLine("The array has " + numbers.Length + " elements");
            Console.WriteLine("The last element is " + numbers[numbers.Length - 1]);
        }

        // דוגמה 104: מעבר על מערך בלולאה
        // הלולאה עוברת על כל האינדקסים, מ-0 ועד מספר האיברים פחות 1.
        // כך קולטים ערכים לכל האיברים, וכך גם מדפיסים אותם.
        // להדפסה מהסוף להתחלה, הלולאה מתחילה באינדקס האחרון ויורדת עד 0.
        public static void example104()
        {
            int[] numbers = new int[4];

            Console.WriteLine("Enter " + numbers.Length + " numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("From start to end: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            Console.Write("From end to start: ");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        // דוגמה 105: חריגה מגבולות המערך
        // במערך של 4 איברים האינדקסים הם 0, 1, 2, 3.
        // פנייה לאינדקס 4 או לאינדקס שלילי היא חריגה מגבולות המערך.
        // המהדר לא מזהה את הטעות, כי ערך האינדקס ידוע רק בזמן הריצה.
        // בזמן הריצה התוכנית נעצרת עם שגיאה.
        // שימו לב: הטעות הנפוצה היא תנאי הלולאה עם קטן או שווה במקום קטן.
        public static void example105()
        {
            int[] arr = new int[4];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 10;
                Console.WriteLine("arr[" + i + "] = " + arr[i]);
            }

            Console.WriteLine("Now trying to put a value in arr[4]...");
            // השורה הבאה עוצרת את התוכנית עם שגיאה
            arr[4] = 40;
            Console.WriteLine("This line is never printed");
        }

        // דוגמה 106: העתקת מערך
        // השמה של מערך למערך לא מעתיקה את הערכים.
        // אחרי ההשמה שני השמות מצביעים על אותו מערך, ושינוי באחד נראה גם בשני.
        // כדי לקבל עותק נפרד, יוצרים מערך חדש ומעתיקים בלולאה איבר אחרי איבר.
        public static void example106()
        {
            int[] arr1 = { 1, 2, 3 };

            // השמה: שני השמות מצביעים על אותו מערך
            int[] arr2 = arr1;
            arr2[0] = 100;
            Console.Write("arr1 after changing arr2: ");
            PrintArray(arr1);

            // העתקה: מערך חדש עם אותם ערכים
            int[] arr3 = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }
            arr3[1] = 200;
            Console.Write("arr1 after changing arr3: ");
            PrintArray(arr1);
            Console.Write("arr3: ");
            PrintArray(arr3);
        }

        // פעולת עזר: מדפיסה את כל איברי המערך בשורה אחת
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        // דוגמה 107: מערך כפרמטר לפעולה
        // כשמעבירים לפעולה משתנה רגיל, היא מקבלת עותק, והמשתנה המקורי לא משתנה.
        // כשמעבירים לפעולה מערך, היא מקבלת את אותו מערך.
        // לכן שינוי של איברי המערך בתוך הפעולה נשאר גם אחרי שהיא מסתיימת.
        public static void example107()
        {
            int x = 5;
            ChangeNumber(x);
            Console.WriteLine("x after ChangeNumber: " + x);

            int[] arr = { 1, 2, 3, 4 };
            DoubleValues(arr);
            Console.Write("arr after DoubleValues: ");
            PrintArray(arr);
        }

        // פעולת עזר: משנה עותק של המספר, ולכן אין שינוי במקור
        public static void ChangeNumber(int num)
        {
            num = num * 2;
        }

        // פעולת עזר: מכפילה פי 2 כל איבר במערך המקורי
        public static void DoubleValues(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * 2;
            }
        }

        // דוגמה 108: פעולה שמחזירה מערך
        // הפעולה הראשונה יוצרת מערך בגודל שקיבלה, קולטת אליו ערכים ומחזירה אותו.
        // הפעולה השנייה יוצרת מערך חדש בגודל אחר ומעתיקה אליו את הערכים.
        // מערך חדש שנוצר בתוך פעולה חייבים להחזיר, אחרת הוא הולך לאיבוד.
        // לכן כותבים את ההשמה הבאה:
        // numbers = ResizeArr(numbers, newSize);
        public static void example108()
        {
            Console.Write("How many elements? ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = CreateAndReadArr(size);
            PrintArray(numbers);

            Console.Write("What is the new elements amount? ");
            int newSize = int.Parse(Console.ReadLine());
            numbers = ResizeArr(numbers, newSize);
            PrintArray(numbers);
        }

        // פעולת עזר: יוצרת מערך, קולטת אליו ערכים ומחזירה אותו
        public static int[] CreateAndReadArr(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter element " + i + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        // פעולת עזר: מחזירה מערך חדש בגודל המבוקש עם הערכים של המערך הישן
        // אם המערך החדש גדול יותר, האיברים הנוספים נשארים 0
        public static int[] ResizeArr(int[] arr, int size)
        {
            int[] tmp = new int[size];
            for (int i = 0; i < size; i++)
            {
                if (i < arr.Length)
                {
                    tmp[i] = arr[i];
                }
            }
            return tmp;
        }

        // דוגמה 109: הדפסת היסטוגרמה
        // לכל איבר במערך מדפיסים שורה עם מספר כוכביות כמו הערך שלו.
        // יש כאן לולאה בתוך לולאה: החיצונית עוברת על האיברים, והפנימית מדפיסה כוכביות.
        public static void example109()
        {
            int[] arr = { 3, 7, 1, 5 };
            PrintHistogram(arr);
        }

        // פעולת עזר: מדפיסה שורת כוכביות לכל איבר
        public static void PrintHistogram(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ": ");
                for (int j = 0; j < arr[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // דוגמה 110: הערך הגדול ביותר והאינדקס שלו
        // מתחילים מהאיבר הראשון כמקסימום, ובודקים את כל השאר.
        // לפעמים צריך לדעת איפה נמצא המקסימום, ולכן שומרים את האינדקס.
        // מהאינדקס תמיד אפשר לקבל גם את הערך עצמו.
        public static void example110()
        {
            int[] arr = { 12, 45, 7, 45, 30 };
            Console.WriteLine("Max value: " + MaxValue(arr));
            int index = IndexOfMax(arr);
            Console.WriteLine("Index of max: " + index + " (value " + arr[index] + ")");
        }

        // פעולת עזר: מחזירה את הערך הגדול ביותר במערך
        public static int MaxValue(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        // פעולת עזר: מחזירה את האינדקס של הערך הגדול ביותר
        // אם המקסימום מופיע כמה פעמים, מוחזר המקום הראשון שלו
        public static int IndexOfMax(int[] arr)
        {
            int maxIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        // דוגמה 111: היפוך סדר האיברים
        // הפעולה יוצרת מערך חדש באותו גודל ומחזירה אותו.
        // האיבר במקום 0 עובר למקום האחרון, האיבר במקום 1 למקום שלפני האחרון, וכן הלאה.
        // סכום האינדקסים של שני תאים סימטריים שווה תמיד לאורך המערך פחות 1.
        public static void example111()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] reversed = Reverse(arr);
            Console.Write("Original: ");
            PrintArray(arr);
            Console.Write("Reversed: ");
            PrintArray(reversed);
        }

        // פעולת עזר: מחזירה מערך חדש בסדר הפוך
        public static int[] Reverse(int[] arr)
        {
            int[] res = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                res[arr.Length - 1 - i] = arr[i];
            }
            return res;
        }

        // דוגמה 112: האם המערך הוא פלינדרום
        // מערך פלינדרום נקרא אותו דבר משמאל לימין ומימין לשמאל.
        // משתמשים בשני אינדקסים: אחד מתחיל בהתחלה ואחד בסוף, ושניהם מתקרבים למרכז.
        // ברגע שנמצאו שני איברים שונים, המערך אינו פלינדרום.
        public static void example112()
        {
            int[] arr1 = { 1, 2, 3, 2, 1 };
            int[] arr2 = { 1, 2, 3, 4 };
            Console.WriteLine("1 2 3 2 1 is palindrome: " + IsPalindrome(arr1));
            Console.WriteLine("1 2 3 4 is palindrome: " + IsPalindrome(arr2));
        }

        // פעולת עזר: מחזירה אמת אם המערך הוא פלינדרום
        public static bool IsPalindrome(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                if (arr[left] != arr[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        // דוגמה 113: סיבוב מערך שמאלה
        // הערך הראשון עובר לסוף, וכל שאר האיברים זזים מקום אחד שמאלה.
        // שומרים קודם את האיבר הראשון במשתנה עזר, אחרת הוא יימחק.
        // אחר כך מעתיקים כל איבר, מהשני ועד האחרון, מקום אחד אחורה.
        // בסוף שמים את הערך השמור במקום האחרון.
        public static void example113()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.Write("Before: ");
            PrintArray(arr);
            RotateLeft(arr);
            Console.Write("After:  ");
            PrintArray(arr);
        }

        // פעולת עזר: מסובבת את המערך מקום אחד שמאלה
        public static void RotateLeft(int[] arr)
        {
            int first = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[arr.Length - 1] = first;
        }

        // דוגמה 114: הדפסת התווים השונים במערך וספירתם
        // רוצים להדפיס כל תו פעם אחת בלבד, ולספור כמה תווים שונים יש.
        // תו מודפס רק אם הוא לא הופיע באף מקום לפניו במערך.
        // לכל משימה יש פעולת עזר משלה.
        public static void example114()
        {
            char[] letters = { 'a', '0', '?', 'T', 'T', '0', '$', 'a', 'T', 'x' };

            Console.WriteLine("The letters are:");
            for (int i = 0; i < letters.Length; i++)
            {
                Console.Write(letters[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("The different letters are:");
            int count = CountAndShowUnique(letters);
            Console.WriteLine("There are " + count + " unique letters");
        }

        // פעולת עזר: מחזירה אמת אם התו שבמקום הנתון כבר הופיע לפניו
        public static bool HadAppearBefore(char[] arr, int index)
        {
            for (int i = 0; i < index; i++)
            {
                if (arr[i] == arr[index])
                {
                    return true;
                }
            }
            return false;
        }

        // פעולת עזר: מדפיסה כל תו פעם אחת ומחזירה את מספר התווים השונים
        public static int CountAndShowUnique(char[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (HadAppearBefore(arr, i) == false)
                {
                    Console.Write(arr[i] + " ");
                    count++;
                }
            }
            Console.WriteLine();
            return count;
        }

        // דוגמה 115: מיזוג שני מערכים ממוינים
        // מערך ממוין הוא מערך שאיבריו מסודרים מהקטן לגדול.
        // יוצרים מערך חדש בגודל של שני המערכים יחד.
        // בכל שלב משווים את האיבר הנוכחי בכל מערך, ומעתיקים את הקטן מביניהם.
        // כשאחד המערכים נגמר, מעתיקים את מה שנשאר במערך השני.
        public static void example115()
        {
            int[] arr1 = { 1, 4, 7, 9 };
            int[] arr2 = { 2, 3, 8, 10, 12 };
            int[] merged = MergeArrays(arr1, arr2);
            Console.Write("Merged: ");
            PrintArray(merged);
        }

        // פעולת עזר: ממזגת שני מערכים ממוינים למערך ממוין אחד
        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] res = new int[arr1.Length + arr2.Length];
            int i = 0;
            int j = 0;
            int m = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] <= arr2[j])
                {
                    res[m] = arr1[i];
                    i++;
                }
                else
                {
                    res[m] = arr2[j];
                    j++;
                }
                m++;
            }

            // העתקת מה שנשאר במערך הראשון
            while (i < arr1.Length)
            {
                res[m] = arr1[i];
                i++;
                m++;
            }

            // העתקת מה שנשאר במערך השני
            while (j < arr2.Length)
            {
                res[m] = arr2[j];
                j++;
                m++;
            }

            return res;
        }

        // דוגמה 116: מערך מונים, בחירת המורה של המדינה
        // יש 4 מועמדים, ולכל אחד יש תא משלו במערך המונים.
        // האינדקס של התא הוא מספר המועמד, והערך שבתא הוא מספר הקולות שלו.
        // כל בחירה מגדילה ב-1 את התא של המועמד שנבחר. מינוס 1 מסיים את ההצבעה.
        // בסוף מחפשים את האינדקס עם הערך הגדול ביותר, וזה הזוכה.
        public static void example116()
        {
            string[] names = { "gogo", "momo", "yoyo", "koko" };
            int[] votes = new int[names.Length];

            ReadVotes(votes, names);

            Console.WriteLine("Each teacher and number of votes:");
            for (int i = 0; i < votes.Length; i++)
            {
                Console.WriteLine(names[i] + " --> " + votes[i] + " votes");
            }

            int winner = IndexOfMax(votes);
            Console.WriteLine("The chosen teacher is: " + names[winner]);
        }

        // פעולת עזר: קולטת בחירות עד מינוס 1 ומעדכנת את מערך המונים
        public static void ReadVotes(int[] votes, string[] names)
        {
            Console.Write("Choose 0 for gogo, 1 for momo, 2 for yoyo, 3 for koko, -1 to exit: ");
            int choice = int.Parse(Console.ReadLine());
            while (choice != -1)
            {
                if (choice >= 0 && choice < votes.Length)
                {
                    votes[choice]++;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
                Console.Write("Choose 0 for gogo, 1 for momo, 2 for yoyo, 3 for koko, -1 to exit: ");
                choice = int.Parse(Console.ReadLine());
            }
        }

        // דוגמה 117: מערך צוברים, תפוקת חלב ברפת
        // לכל פרה יש תא במערך, ובו מצטברת כמות החלב שלה בכל הימים.
        // מספרי הפרות מתחילים ב-1, והאינדקסים מתחילים ב-0.
        // לכן החלב של פרה מספר 1 נצבר בתא 0, והחלב של פרה מספר 2 בתא 1.
        // פרה שתפוקתה פחות ממחצית הממוצע של כל הפרות נשלחת לווטרינר.
        // בדוגמה יש רק יומיים כדי שיהיה קל להריץ. בחודש אמיתי משנים ל-30.
        public static void example117()
        {
            Console.Write("Num Cows: ");
            int numCows = int.Parse(Console.ReadLine());
            int days = 2;

            double[] milk = BuildMilkArray(numCows, days);
            double average = ArrayAverage(milk);
            Console.WriteLine("Average per cow: " + average);

            Console.WriteLine("Cows to send to the vet:");
            for (int i = 0; i < milk.Length; i++)
            {
                if (milk[i] < average / 2)
                {
                    Console.WriteLine("Cow #" + (i + 1) + " with " + milk[i]);
                }
            }
        }

        // פעולת עזר: קולטת את נתוני החליבה וצוברת אותם במערך
        public static double[] BuildMilkArray(int numCows, int days)
        {
            double[] arr = new double[numCows];
            for (int day = 1; day <= days; day++)
            {
                for (int cow = 1; cow <= numCows; cow++)
                {
                    Console.Write("day #" + day + " cow #" + cow + ": ");
                    arr[cow - 1] = arr[cow - 1] + double.Parse(Console.ReadLine());
                }
            }
            return arr;
        }

        // פעולת עזר: מחזירה את הממוצע של איברי המערך
        public static double ArrayAverage(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum / arr.Length;
        }

        // דוגמה 118: חיפוש סדרתי
        // עוברים על האיברים אחד אחרי השני, עד שמוצאים את המספר או עד סוף המערך.
        // החיפוש עובד גם במערך שאינו ממוין, אבל במערך גדול הוא לוקח זמן רב.
        public static void example118()
        {
            int[] arr = { 15, 3, 42, 8, 23 };
            Console.Write("Enter a number to search: ");
            int number = int.Parse(Console.ReadLine());

            if (Search(arr, number))
            {
                Console.WriteLine(number + " was found");
            }
            else
            {
                Console.WriteLine(number + " was not found");
            }
        }

        // פעולת עזר: מחזירה אמת אם המספר נמצא במערך
        public static bool Search(int[] arr, int number)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    return true;
                }
            }
            return false;
        }

        // דוגמה 119: מיון בועות
        // משווים כל שני איברים שכנים, ואם הם לא בסדר הנכון מחליפים ביניהם.
        // אחרי סיבוב שלם, הערך הגדול ביותר מגיע לסוף המערך, כמו בועה שעולה למעלה.
        // בכל סיבוב הבא אפשר לעצור מקום אחד קודם, כי הסוף כבר מסודר.
        public static void example119()
        {
            int[] arr = { 5, 1, 4, 2, 8 };
            Console.Write("Before: ");
            PrintArray(arr);
            BubbleSort(arr);
            Console.Write("After:  ");
            PrintArray(arr);
        }

        // פעולת עזר: מחליפה בין שני איברים במערך
        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        // פעולת עזר: ממיינת את המערך מהקטן לגדול במיון בועות
        public static void BubbleSort(int[] arr)
        {
            for (int round = 0; round < arr.Length - 1; round++)
            {
                for (int i = 0; i < arr.Length - 1 - round; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                    }
                }
            }
        }

        // דוגמה 120: מיון בחירה
        // בכל סיבוב מחפשים את הערך הקטן ביותר בחלק שעוד לא מוין.
        // מחליפים אותו עם האיבר הראשון של החלק הזה.
        // כך החלק הממוין בתחילת המערך גדל באיבר אחד בכל סיבוב.
        public static void example120()
        {
            int[] arr = { 29, 10, 14, 37, 13 };
            Console.Write("Before: ");
            PrintArray(arr);
            SelectionSort(arr);
            Console.Write("After:  ");
            PrintArray(arr);
        }

        // פעולת עזר: ממיינת את המערך מהקטן לגדול במיון בחירה
        public static void SelectionSort(int[] arr)
        {
            for (int start = 0; start < arr.Length - 1; start++)
            {
                int minIndex = start;
                for (int i = start + 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[minIndex])
                    {
                        minIndex = i;
                    }
                }
                Swap(arr, start, minIndex);
            }
        }

        // דוגמה 121: חיפוש בינארי
        // החיפוש עובד רק על מערך ממוין.
        // בודקים את האיבר האמצעי. אם הוא המספר, סיימנו.
        // אם המספר קטן ממנו, ממשיכים לחפש רק בחצי השמאלי, ואם גדול ממנו, רק בחצי הימני.
        // בכל צעד החלק שבו מחפשים קטן בחצי, ולכן החיפוש מהיר מאוד.
        // הפעולה מחזירה את האינדקס של המספר, או מינוס 1 אם הוא לא נמצא.
        public static void example121()
        {
            int[] arr = { 3, 8, 15, 23, 42, 57, 61, 78, 90 };
            Console.Write("Enter a number to search: ");
            int number = int.Parse(Console.ReadLine());

            int index = BinarySearch(arr, number);
            if (index != -1)
            {
                Console.WriteLine(number + " was found at index " + index);
            }
            else
            {
                Console.WriteLine(number + " was not found");
            }
        }

        // פעולת עזר: חיפוש בינארי במערך ממוין
        public static int BinarySearch(int[] arr, int number)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                Console.WriteLine("Checking index " + middle + " (value " + arr[middle] + ")");
                if (arr[middle] == number)
                {
                    return middle;
                }
                if (number < arr[middle])
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
            }
            return -1;
        }
    }
}
