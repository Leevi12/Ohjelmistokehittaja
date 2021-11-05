using System;

namespace Oliotehtava
{
    class Program
    {
        static void Main(string[] args)
        {
            Kirjasto firstbook = new Kirjasto("Metallica", 440, "Joel McIver", 3);
            Kirjasto secondbook = new Kirjasto("Arnold Schwarzenegger Total Recall", 423, "Arnold Schwarzenegger & Peter Petre", 3);
            Kirjasto thirdbook = new Kirjasto("Arsène Lupin, Mestarivarkaan kootut kertomukset", 554, "Maurice LeBlanc", 3);

            firstbook.ShowQuantityOfBooks();
            firstbook.LoanBook(1);
            firstbook.ShowQuantityOfBooks();
            firstbook.EndLoan(1);
            firstbook.ShowQuantityOfBooks();
            secondbook.LoanBook(7);
            thirdbook.EndLoan(2);

        }
    }
}
