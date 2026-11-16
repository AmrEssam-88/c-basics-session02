namespace assignment
{
    class Book
    {
        public required string Title { get; set; }
        public int Pages { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //السؤال الاول
            Console.WriteLine("Question 1");
            
            Book myBook = new Book() { Title = "C# Programming", Pages = 300 };
            object obj = myBook;
            Console.WriteLine(obj);

            //السؤال الثاني
            Console.WriteLine("Question 2");

            Book book = new Book { Title = "C# Guide", Pages = 300 };
            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());

            //السؤال التالت
            Console.WriteLine("Question 3");

            // نوع الخطأ  (compile-timeerror)
            int pages = 464;//التصحيح 
            Console.WriteLine(pages);

            /*int pages ="464";
             الخطأ هنا في علمات التنصيص عشان 
            int في
            الرقم بيجي من غير علامات تنصيص وبيكون 
            رقم صحيح الي بيجي معاه علامات تنصيص
            كدة ""
            بيكون string
            */

            //السؤال الرابع 
            Console.WriteLine("Question 4");

            try
            {
                int x = 10;
                int y = 0;
                int res = x/y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            //السؤال الخامس
            Console.WriteLine("Question 5");

            int page = 300;
            double DoublePage = page;
            Console.WriteLine(DoublePage);

            //السؤال السادس 
            Console.WriteLine("Question 6");

            double price = 49.99;
            int intPrice = (int)price;
            Console.WriteLine(intPrice);

            //السؤال السابع
            Console.WriteLine("Question 7");

            string pagesText = "464";
            int convertPage = Convert.ToInt32(pagesText);
            Console.WriteLine(convertPage);

            //السؤال الثامن
            Console.WriteLine("Question 8");

            //  Parse

            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);

            // Part 2: TryParse
            string badText = "abc";
            if (int.TryParse(badText, out int result))
            {
                Console.WriteLine($"Converted number: {result}");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            //السؤال التاسع
            Console.WriteLine("Question 9");

            int pagess = 464;
            string pagesStr = pagess.ToString();

            Console.WriteLine(pagesStr);
            Console.WriteLine(pagesStr.GetType());


            //السؤال العاشر
            Console.WriteLine("Question 10");

            int copies = 100;

            // Box
            object BoxCopies = copies;

            // Unbox
            int unboxCopies = (int)BoxCopies;

            Console.WriteLine("BOX  " + BoxCopies);
            Console.WriteLine("unbox  " + unboxCopies);

            //السؤال ال11
            Console.WriteLine("Question 11");

            int? year2 = null;
            Console.WriteLine(year2.HasValue); 
            year2 = 2023;
            Console.WriteLine(year2.Value);

            //السؤال ال12
            Console.WriteLine("Question 12");

            string? reviewer = null;
            if (reviewer == null)
            {
                Console.WriteLine("Reviewer is null");
            }

            //السؤال ال13
            Console.WriteLine("Question 13");

            Book? book2 = null;
            string? title = book2?.Title;
            Console.WriteLine(title); 

            //السؤال ال14
            Console.WriteLine("Question 14");

            string? title2 = null;
            Console.WriteLine(title2 ?? "Untitled");
            title ??= "Untitled";
            Console.WriteLine(title);

            //السؤال ال15
            Console.WriteLine("Question 15");

            string? name = "Ahmed";
            string confirmedName = name!;
            Console.WriteLine(confirmedName);





        }
    }
}
