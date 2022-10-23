using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Library
    {
        public static Dictionary<Reader,Book> dictionary = new Dictionary<Reader,Book>();
        public static List<Reader> readers = new List<Reader>();
        public static List<Book> books = new List<Book>();
        public static Library Initial()
        {
            var res=new Library();
            var book= new Book();
            book.author = "Опеткин А.С.";
            book.genre = Genre.Triller;
            book.kode = "001";
            book.name = "Программирование 1";
            book.condition = Condition.OffHand;
            books.Add(book);

            book = new Book();
            book.author = "Сергунов А.Р.";
            book.genre = Genre.Roman;
            book.kode = "002";
            book.name = "ООП";
            book.condition = Condition.OnHand;
            books.Add(book);
            return res;
        }

        public void GetBook(int kod, Reader reader)
        {
            Book pBook=null;
            foreach (Book book in books)
            {
                if (int.Parse(book.kode) == kod)
                {
                    pBook = book;
                }
            }
            if(pBook != null)
            {
                if (pBook.condition.Equals(Condition.OffHand))
                {
                    pBook.condition = Condition.OnHand;
                    dictionary.Add(reader, pBook);
                    Console.WriteLine("Выдача книги зафиксирована");
                }
                else
                {
                    Console.WriteLine("Книга на руках!!");
                }
            }
            else
            {
                Console.WriteLine("Книги нет!!");
            }
        }

        public void ListBooks()
        {
            if (books.Count != 0)
            {
                foreach (Book book in books)
                {
                    Console.WriteLine(book.kode+"\n"+book.name+ "\n" + book.author+ "\n" + book.genre+ "\n" + book.condition);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Список книг пуст");
            }
        }
    }
}
