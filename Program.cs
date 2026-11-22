using System;

class Program
{
    static void Main()
    {
        // question 1
        double[] prices = { 25.5, 40.0, 33.75 };
        Console.WriteLine(prices[1]);

        // question 2
        int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
        Console.WriteLine(shelfCopies[1, 0]);

        // question 3
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        PrintWelcomeMessage();

        // question 4
        static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book title: {title}");
        }
        PrintBookTitle("Clean Code");

        // question 5
        static void AddBonusPages(int pages)
        {
            pages = pages + 50;
        }
        int pages = 400;
        AddBonusPages(pages);
        Console.WriteLine(pages);
        // i expect 400 because int is passed by value not by refrence

        // question 6
        static void ApplyDiscount(double[] prices)
        {
            prices[0] = prices[0] - 5;
        }
        double[] prices2 = { 25.5, 40.0 };
        ApplyDiscount(prices2);
        Console.WriteLine(prices2[0]);
        // i expect 20.5 because an array is a reference type, so the original changes

        // question 7
        static void AddBonusPagesByRef(ref int pages)
        {
            pages = pages + 50;
        }
        int pages2 = 400;
        AddBonusPagesByRef(ref pages2);
        Console.WriteLine(pages2);
        // 450 here, because ref changes the original variable not a copy

        // question 8
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        double[] prices3 = { 25.5, 40.0, 33.75 };
        ReplaceArray(ref prices3);
        Console.WriteLine(prices3.Length);

        // question 9
        bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0;
                return false;
            }
        }
        double foundPrice;
        if (TryGetPrice("Clean Code", out foundPrice))
        {
            Console.WriteLine(foundPrice);
        }

        // question 10
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Title: {title}, Pages: {pages}");
        }
        PrintBookInfo("Clean Code");
        PrintBookInfo("Clean Code", 450);

        // question 11
        PrintBookInfo(pages: 200, title: "Clean Code");

        // question 12
        static void PrintAllTitles(params string[] titles)
        {
            foreach (string t in titles)
            {
                Console.WriteLine(t);
            }
        }
        PrintAllTitles("Book01", "Book02", "Book03");
    }
}