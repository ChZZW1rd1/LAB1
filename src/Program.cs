using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            person MyPerson1 = new person();
            MyPerson1.NameSurname = ("Бжежгевич Бегброн");
            MyPerson1.Gender = (0);
            MyPerson1.Age = (27);
            MyPerson1.Print();
            //person MyPerson3 = new person();
            // MyPerson3.Input();
            //MyPerson3.Print();

            person MyPerson2 = new person("Вжегач Алексей Павлович", 0, 31);

            MyPerson2.Print();
            Organization Yandex = new Organization("Yandex", 1997, MyPerson2);
            Yandex.Print();

            Worker worker1 = new Worker("Григоренко Иван Рашевич", 0, 25);
            worker1.Print();

            HR.Employ(worker1, Yandex, 150000, "Программист");
            worker1.Print();
            HR.Dismiss(worker1);
            worker1.Print();
        }
    }
}
