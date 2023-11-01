using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CS_Lesson_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1();
            //Task_2();
            Task_3();

            

        }

        public static void Task_3()
        {
            Character c1 = new Character();
            c1._Init_("Jane Austen");
            Character c2 = new Character();
            c2._Init_("Harper Lee");
            Character c3 = new Character();
            c3._Init_("George Orwell");
            Character c4 = new Character();
            c4._Init_("J.K. Rowling");

            Console.WriteLine(c1.ToString());
            c1.Perform_action("run", 10);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            c2.Perform_action("walk", 5);
            Console.WriteLine(c2.ToString());

        }

        public static void Task_2()
        {
            Account a1 = new Account(10112, "Jane Austen", 123.123);
            Account a2 = new Account(10113, "Harper Lee", 123.123);
            Account a3 = new Account(10114, "George Orwell", 123.123);
            Account a4 = new Account(10115, "J.K. Rowling", 123.123);
            Account a5 = new Account(10116, "J.D. Salinger", 123.123);

            a1.PrintAccountInfo();
            a1.Deposit(12.23);
            a1.PrintAccountInfo();
            a1.Withdraw(12.23);
            a1.PrintAccountInfo();
            a2.PrintAccountInfo();
            a3.PrintAccountInfo();
            a4.PrintAccountInfo();
            a5.PrintAccountInfo();
        }

        public static void Task_1()
        {
            Library library = new Library();
            string file_path = "C:\\Users\\Ж - 4\\Якимов\\zxcqwe\\CS_Lesson_12\\CS_Lesson_12\\books.xml";
            XDocument xdoc = XDocument.Load(file_path);
            XElement library_ = xdoc.Element("Library");


            if (library != null)
            {

                foreach (XElement element in library_.Elements("book"))
                {

                    string title = element.Element("title")?.Value;
                    string author = element.Element("author")?.Value;
                    string year = element.Element("year")?.Value;
                    string genre = element.Element("genre")?.Value;

                    Book book = new Book(title, author, year, genre);
                    library.Add(book);

                }

            }


            do
            {
                int choice = 0;
                int choice_1 = 0;
                do
                {
                    Console.WriteLine("Меню для работы с приложением \"Библиотека\":");
                    Console.WriteLine("1. Добавление книги.");
                    Console.WriteLine("2. Удаление книги.");
                    Console.WriteLine("3. Поиск книги.");
                    Console.WriteLine("4. Вывод списка книг.");
                    Console.WriteLine("5. Выход.");
                    choice = Convert.ToInt32(Console.ReadLine());
                } while (choice != 1 && choice != 2 &&
                        choice != 3 && choice != 4 && choice != 5);

                if (choice == 1) // добавление книги
                {
                    Console.Write("Введите название книги: ");
                    string title = Console.ReadLine();
                    Console.Write("Введите автора книги: ");
                    string author = Console.ReadLine();
                    Console.Write("Введите год издания книги: ");
                    string year = Console.ReadLine();
                    Console.Write("Введите жанр книги: ");
                    string genre = Console.ReadLine();
                    library.Add(new Book(title, author, year, genre));
                }
                else if (choice == 2)   // удаление книги
                {
                    Console.Write("Введите автора книги: ");
                    string author = Console.ReadLine();
                    Console.Write("Введите название книги: ");
                    string title = Console.ReadLine();
                    Console.Write("Введите год издания книги: ");
                    string year = Console.ReadLine();
                    Console.Write("Введите жанр книги: ");
                    string genre = Console.ReadLine();

                    library.Remove(new Book(title, author, year, genre));
                }
                else if (choice == 3)   // поиск книги
                {
                    do
                    {
                        Console.WriteLine("Меню для поиска книги:");
                        Console.WriteLine("1. Поиск книги по названию.");
                        Console.WriteLine("2. Поиск книги по автору.");
                        Console.WriteLine("3. Выход в главное меню.");
                        choice_1 = Convert.ToInt32(Console.ReadLine());
                    } while (choice != 1 && choice != 2 && choice != 3);
                    if (choice_1 == 1)
                    {
                        Console.Write("Введите название книги: ");
                        string title = Console.ReadLine();
                        List<Book> books_ = library.SearchByAuthor(title);
                        if (books_.Count() == 0)
                        {
                            Console.WriteLine("Книга не найдена.");
                        }
                        else
                        {
                            foreach (var b in books_)
                            {
                                Console.WriteLine(b.ToString());
                            }
                        }
                    }
                    else if (choice_1 == 2)
                    {
                        Console.Write("Введите автора книги: ");
                        string author = Console.ReadLine();

                        List<Book> books_ = library.SearchByAuthor(author);
                        if (books_.Count() == 0)
                        {
                            Console.WriteLine("Книга не найдена.");
                        }
                        else
                        {
                            foreach (var b in books_)
                            {
                                Console.WriteLine(b.ToString());
                            }
                        }

                    }


                }
                else if (choice == 4)   // вывод списка книг
                {
                    library.DisplayAllBooks();
                }
                else                    // выход из программы
                {
                    break;
                }
            } while (true);
        }
    }
}
