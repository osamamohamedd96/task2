#nullable enable
using System.Text;

namespace task02

{
    class BoOk
    {
        public string? Title { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q5_pdf1
            int pages = 300;
            double doublePages = pages;
            Console.WriteLine(doublePages);
            #endregion
            #region Q6_pdf1
            double price = 49.99;
            int priceInt = (int)price;
            Console.WriteLine(priceInt);
            #endregion
            #region Q7_pdf1
            string pagesText = "464";
            int PagesInt = Convert.ToInt32(pagesText);
            Console.WriteLine(PagesInt);
            #endregion
            #region Q8_pdf1
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);
            //////////////////////////////////////
            string badText = "abc";
            if (int.TryParse(badText, out int number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            #endregion
            #region Q9_pdf1
            int pAges = 464;
            string pAgesString = pAges.ToString();
            Console.WriteLine(pAgesString);
            Console.WriteLine(pAgesString.GetType());
            #endregion
            #region Q10_pdf1
            int copies = 100;

            object boxedCopies = copies;

            int unboxedCopies = (int)boxedCopies;

            Console.WriteLine(boxedCopies);
            Console.WriteLine(unboxedCopies);

            #endregion
            #region Q11_pdf1
            int? yEar = null;

            Console.WriteLine(yEar.HasValue);

            yEar = 2023;

            Console.WriteLine(yEar.Value);
            #endregion
            #region Q12_pdf1
            string? reviewer = null;
            Console.WriteLine(reviewer == null);

            #endregion
            #region Q13_pdf1

            BoOk? book = null;

            string? title = book?.Title;

            Console.WriteLine(title);

            #endregion
            #region Q14_pdf1

            string? newTitle = null;

            Console.WriteLine(newTitle ?? "Untitled");

            newTitle ??= "Untitled";

            Console.WriteLine(newTitle);

            #endregion
            #region Q15_pdf1

            string? name = "Ahmed";

            string confirmedName = name!;

            Console.WriteLine(confirmedName);

            #endregion
            //////////////////////////////////////////////////////////////////////////////
            #region Q1_Pdf2
            string titLe = "clean code";

            string upperTitle = titLe.ToUpper();

            Console.WriteLine(titLe);
            Console.WriteLine(upperTitle);
            #endregion
            #region Q2_Pdf2
            string refTitle1 = "Clean Code";
            string refTitle2 = "Clean Code";
            Console.WriteLine(object.ReferenceEquals(refTitle1, refTitle2));
            #endregion
            #region Q3_Pdf2

            StringBuilder sb = new StringBuilder();

            sb.Append("Book List");
            sb.Append(" - Updated");

            Console.WriteLine(sb);

            #endregion
            #region Q4_Pdf2

            sb.Replace("Book List", "Library");

            Console.WriteLine(sb);

            #endregion
            #region Q5_Pdf2

            string formatTitle1 = "Clean Code";
            int pages2 = 464;

            string sentence1 = "Book: " + formatTitle1 + ", Pages: " + pages2;

            Console.WriteLine(sentence1);

            #endregion
            #region Q6_Pdf2

            string sentence2 = $"Book: {formatTitle1}, Pages: {pages2}";
            Console.WriteLine(sentence2);

            #endregion
            #region Q7_Pdf2

            string sentence3 = string.Format("Book: {0}, Pages: {1}", formatTitle1, pages2);

            Console.WriteLine(sentence3);

            #endregion
            #region Q8_Pdf2

            if (pages2 > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }

            #endregion
            #region Q9_Pdf2

            bool isAvailable2 = true;

            if (pages2 > 300 && isAvailable2 == true)
            {
                Console.WriteLine("You can borrow this book");
            }

            #endregion
            #region Q10_Pdf2

            string switchTitle = "Refactoring";

            switch (switchTitle)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;

                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }

            #endregion
            #region Q11_Pdf2

            string sizeLabel = pages2 > 300 ? "Long Book" : "Short Book";

            Console.WriteLine(sizeLabel);

            #endregion
            string[] books = { "Clean Code", "Refactoring", "The Pragmatic Programmer" };
            #region Q12_pdf2
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + books[i]);
            }

            #endregion
            #region Q13_pdf2
            int j = 0;
            while (j < books.Length)
            {
                Console.WriteLine(books[j]);
                j++;
            }

            #endregion
            #region Q14_pdf2
            int count = 0;
            do
            {
                Console.WriteLine("Checking Books");
                count++;
            }
            while (count < books.Length);
            #endregion
            #region Q15_pdf2
            foreach (string currentBook in books)
            {
                Console.WriteLine(currentBook);
            }
            #endregion
            #region Q16_pdf2
            foreach (string currentBook in books)
            {
                if (currentBook == "Refactoring")
                {
                    break;
                }

                Console.WriteLine(currentBook);
            }

            #endregion
            #region Q17_pdf2
            foreach (string currentBook in books)
            {
                if (currentBook == "The Pragmatic Programmer")
                {
                    continue;
                }

                Console.WriteLine(currentBook);
            }
            #endregion
            #region Q18_pdf2


            #endregion
        }
    }
}
