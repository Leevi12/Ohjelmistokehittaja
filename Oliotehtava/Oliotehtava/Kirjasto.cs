using System;
using System.Collections.Generic;
using System.Text;

namespace Oliotehtava
{
    class Kirjasto
    {
        string bookname;
        int pagescount;
        string author;
        int quantity;

        public Kirjasto(string bname, int pages, string atr, int quan)
        {
            bookname = bname;
            pagescount = pages;
            author = atr;
            quantity = quan;
        }
        public void ShowQuantityOfBooks()
        {
            Console.WriteLine(quantity);
        }

        public void LoanBook(int loaned)
        {
            if (loaned > quantity || quantity == 0)
            {
                Console.WriteLine("Sorry we currently don't have enough copies of this book");
            }
            else
            {
                quantity -= loaned;
            }
        }
        public void EndLoan(int loaned)
        {
            if (quantity < 3)
            {
                quantity += loaned;
            }
            else
            {
                Console.WriteLine("Don't try to give us extra books");
            }
        }
    }
}
