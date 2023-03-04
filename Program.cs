using System;
using Students;
using Readers;

namespace Students
{
    class Student
    {
        string name;
        int groupId;
        private int age;

        public Student(string name, int groupId, int age)
        {
            this.name = name;
            this.groupId = groupId;
            this.age = age;
        }

        public void Print() => Console.WriteLine($"Имя: {name}\nНомер группы: {groupId}\nВозраст: {age}");
    }
}

namespace Readers
{
    class Reader
    {
        private string FIO;
        int ticket;
        string faculty;
        private string birthday;
        string number;

        public Reader(string FIO, int ticket, string faculty, string birthday, string number)
        {
            this.FIO = FIO; 
            this.ticket = ticket;
            this.faculty = faculty;
            this.birthday= birthday;
            this.number = number;
        }

        public void takeBook(int bookCount) => Console.WriteLine($"{FIO} взял {bookCount} книги.");

        public void takeBook(params string[] books)
        {
            string result = "";

            foreach(string book in books)
            {
                result += $"{book},";
            }

            Console.WriteLine($"{FIO} взял книги: {result.TrimEnd(',')}.");
        }

        public void returnBook(int bookCount)
        {
            Console.WriteLine($"{FIO} вернул {bookCount} книги.");
        }

        public void returnBook(params string[] books)
        {
            string result = "";

            foreach (string book in books)
            {
                result += $"{book},";
            }

            Console.WriteLine($"{FIO} вернул книги: {result.TrimEnd(',')}.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Student[] students = { new Student("Artem", 1, 15), 
            new Student("Tom", 2, 16), 
            new Student("Bob", 3, 17) 
        };

        Reader[] readers ={ new Reader("Петров В.В.", 113300, "Математический", "3 февраля 2000", "+79632913543"), 
            new Reader("Иванов Д.А.", 330011, "Философский", "17 ноября 20001", "+79093138444"), 
            new Reader("Кузнецов А.А.", 110033, "Математический", "3 декабря 2007", "+79653293312") 
        };


        readers[2].takeBook("Приключения", "Словарь", "Энциклопедия");
        readers[2].takeBook(3);
        readers[2].returnBook("Приключения", "Словарь", "Энциклопедия");
        readers[2].returnBook(4);

        students[1].Print();

    }
}
