using System;

namespace Events0
{
    delegate void UI();

    class UserEventClass
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
            Console.WriteLine($"Событие вызвано для объекта\nИмя: {Name}\nФамилия: {Family}\nВозраст: {Age}");
        }
    }

    class Program
    {
        static void Main()
        {
            UserEventClass @event = new UserEventClass();
            UserInfo user = new UserInfo(Name: "IT-school", Family: "Odessa", Age: 10);

            @event.UserEvent += user.UserInfoHandler; // Добавляем обработчик события

            @event.OnUserEvent(); // Запустим событие

            Console.ReadLine();
        }
    }
}
