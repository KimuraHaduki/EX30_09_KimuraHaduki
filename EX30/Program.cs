using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(DateTime.Now, "デジタル太郎", 0.5f, 160f, 50f,65,30,25);
            Console.WriteLine("Hello World!");

            if(person.CheckBirthDay(DateTime.Now) == true)
            {
                Console.WriteLine(person.name + "、" + person.age + "歳、今日誕生日です。あと"+person.lifeSpan+"年生きます");
            }
            else
            {
                Console.WriteLine(person.name + "、" + person.age + "歳、今日誕生日ではありません。あと" + person.lifeSpan + "年生きます");
            }
        }
    }
}
