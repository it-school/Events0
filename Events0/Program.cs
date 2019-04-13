using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events0
{
    delegate void UI();

    class MyEvent
    {
        // Объявляем событие
        public event UI UserEvent;

        // Используем метод для запуска события
        public void OnUserEvent()
        {
            UserEvent();
        }
    }

    class UserInfo
    {
        string uiName, uiFamily;
        int uiAge;

        public UserInfo(string Name, string Family, int Age)
        {
            this.Name = Name;
            this.Family = Family;
            this.Age = Age;
        }

        public string Name { set { uiName = value; } get { return uiName; } }
        public string Family { set { uiFamily = value; } get { return uiFamily; } }
        public int Age { set { uiAge = value; } get { return uiAge; } }

        // Обработчик события
        public void UserInfoHandler()
        {
            Console.WriteLine("Событие вызвано!\n");
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nВозраст: {2}", Name, Family, Age);
        }
    }

    class Program
    {
        static void Main()
        {
            MyEvent evt = new MyEvent();
            UserInfo user1 = new UserInfo(Name: "IT-school", Family: "Odessa", Age: 10);

            evt.UserEvent += user1.UserInfoHandler; // Добавляем обработчик события

            evt.OnUserEvent(); // Запустим событие

            Console.ReadLine();
        }
    }
}
