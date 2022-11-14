using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Belousov.Zadanie2
{
    public class NumberBook
    {
        List<User> users = new List<User>()
        {
            new User("Никита","+79885611434"),
            new User("Илья","+79001305049"),
            new User("Кристина","+79885618069")
        };
        public void List()
        {
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine(users[i].ToString());
            }
        }
        public void AddUser()
        {
            Console.WriteLine("Введите имя: ");
            string addName = Console.ReadLine();
            Console.WriteLine("Введите номер телефона: ");
            string addNumberPhone = Console.ReadLine();

            users.Add(new User(addName, addNumberPhone));
            List();
        }
        public void DeleteUser()
        {
            Console.WriteLine("Введите номер пользователя которого нужно удалить: ");
            int n = Int32.Parse(Console.ReadLine());
            users.RemoveAt(n - 1);
            List();
        }
        public void ChangeNumberPhone()
        {
            Console.WriteLine("Введите номер пользователя чей номер хотите изменить.");
            int n = Int32.Parse(Console.ReadLine());
            string changeNumberPhone = Console.ReadLine();
            users[n - 1].NumberPhone = changeNumberPhone;
            List();
        }
        public void Menu()
        {
            List();
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1)Добавить пользователя\n2)Удалить пользователя\n3)Изменить номер пользователя");
            int n = Int32.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    AddUser();
                    break;
                case 2:
                    DeleteUser();
                    break;
                case 3:
                    ChangeNumberPhone();
                    break;
            }
        }
    }
}
