using System;

namespace Create_Struct
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public Person(string _firstName, string _lastName, int _age)
        {
            firstName = _firstName;
            lastName = _lastName;
            age = _age;
        }
        public override string ToString()
        {
            return "Имя: " + firstName + " Фамилия: " + lastName + " Возраст: " + age;
        }
        static void Main()
        {
            Person p = new Person("Tony", "Allen", 32);
            Console.WriteLine(p);
        }
    }
}
