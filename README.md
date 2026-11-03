# יסודות מדעי המחשב בשפת C#

דוגמאות קוד, חוברות מלוות ומבדקים לשיעורי חזרה לקראת בגרות ביסודות מדעי המחשב.

## 📚 פרקים

| מבדק | חוברת מלווה | קוד | תיקייה | דוגמאות | נושאים | פרקים |
|---|---|---|---|---|---|---|
| [📝 מבדק](https://ciznerguy.github.io/yesodot/Ch1_2/quiz.html) | [📘 חוברת](https://ciznerguy.github.io/yesodot/Ch1_2/Summary_Ch1_Ch2.html) | [💻 קוד](Ch1_2/Chapter1_2.cs) | [📁 Ch1_2](Ch1_2) | מ-1 עד 20 | הוראות הדפסה ומשתנים, אופרטורים וביטויים לוגיים | 1–2 |
| [📝 מבדק](https://ciznerguy.github.io/yesodot/Ch3_4/quiz.html) | [📘 חוברת](https://ciznerguy.github.io/yesodot/Ch3_4/Summary_Ch3_4.html) | [💻 קוד](Ch3_4/Chapter3_4.cs) | [📁 Ch3_4](Ch3_4) | מ-21 עד 40 | הספרייה המתמטית ומחלקת אקראי, משפטי תנאי | 3–4 |
| [📝 מבדק](https://ciznerguy.github.io/yesodot/Ch5/quiz.html) | [📘 חוברת](https://ciznerguy.github.io/yesodot/Ch5/Summary_Ch5.html) | [💻 קוד](Ch5/Chapter5.cs) | [📁 Ch5](Ch5) | מ-41 עד 52 | לולאות | 5 |
| [📝 מבדק](https://ciznerguy.github.io/yesodot/Ch6/quiz.html) | [📘 חוברת](https://ciznerguy.github.io/yesodot/Ch6/Summary_Ch6.html) | [💻 קוד](Ch6/Chapter6.cs) | [📁 Ch6](Ch6) | מ-53 עד 65 | לולאת While | 6 |
| [📝 מבדק](https://ciznerguy.github.io/yesodot/Ch7/quiz.html) | [📘 חוברת](https://ciznerguy.github.io/yesodot/Ch7/Summary_Ch7.html) | [💻 קוד](Ch7/Chapter7.cs) | [📁 Ch7](Ch7) | מ-66 עד 79 | פעולות | 7 |

- **חוברת מלווה:** הסבר, דוגמת הרצה ונקודות חשובות לכל דוגמה בקוד. אפשר גם להדפיס אותה מהדפדפן.
- **מבדק:** בסוף מקבלים ציון ורשימה של הנושאים שכדאי לחזור עליהם.

## ✏️ דפי עבודה

| דף עבודה | חומר | מה יש בו |
|---|---|---|
| [דף עבודה 1](https://ciznerguy.github.io/yesodot/Worksheets/Worksheet_1.html) | פרקים 1–6 | <div dir="rtl" align="right">6 שאלות מהקלה לקשה ושאלת בונוס: משפטי תנאי, לולאת for ולולאת while, בלי לולאות מקוננות</div> |
| [דף עבודה 2](https://ciznerguy.github.io/yesodot/Worksheets/Worksheet_2.html) | פרק 7 | <div dir="rtl" align="right">5 שאלות מהקלה לקשה ושאלת בונוס על פעולות בלי ערך מוחזר (void), עם פרמטרים ובלי פרמטרים. כל השאלות בתוכנית אחת ובקישור אחד</div> |

## 📎 נספחים

| נספח | מה יש בו |
|---|---|
| [🚀 מדריך התחלה](https://ciznerguy.github.io/yesodot/Appendices/Getting_Started.html) | <div dir="rtl" align="right">איך פותחים חשבון ב-OnlineGDB, איך משתפים קוד עם המורה, ואיך משתמשים ב-Gemini של משרד החינוך כמורה פרטי</div> |
| [🧩 סוגי פעולות](https://ciznerguy.github.io/yesodot/Appendices/Methods_Guide.html) | <div dir="rtl" align="right">מדריך מקוצר לארבעת סוגי הפעולות: איך מזהים כל סוג לפי הניסוח בשאלה, דוגמה קצרה להרצה לכל סוג, וטבלת סיכום</div> |

## מבנה הפרויקט

כל הקוד נמצא בפרויקט אחד, `Yesodot`. לכל פרק יש תיקייה משלו, ובה קובץ הקוד, החוברת והמבדק.

| קובץ | תפקיד |
|---|---|
| `Program.cs` | הקובץ הראשי. בו בוחרים איזה פרק להריץ |
| `Ch1_2/Chapter1_2.cs` | הדוגמאות של פרקים 1 ו-2 |
| `Ch3_4/Chapter3_4.cs` | הדוגמאות של פרקים 3 ו-4 |
| `Ch5/Chapter5.cs` | הדוגמאות של פרק 5 |
| `Ch6/Chapter6.cs` | הדוגמאות של פרק 6 |
| `Ch7/Chapter7.cs` | הדוגמאות של פרק 7 |

## איך מריצים דוגמה

1. פותחים ב-Visual Studio את הקובץ `Yesodot.slnx`.
2. בקובץ `Program.cs` מוחקים את שני הלוכסנים בתחילת השורה של הפרק הרצוי, למשל `// Chapter5.Run();`
3. פותחים את קובץ הפרק. בפעולה `Run` שבראשו מוחקים את שני הלוכסנים בשורה של הדוגמה, למשל `// example45();`
4. מריצים.
