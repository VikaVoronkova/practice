namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1.Employee emp1 = new Task1.Employee("Вадим", "Вадимыч", 48, 60000.5);
            
            Console.WriteLine("Имя: " + emp1.Name);
            Console.WriteLine("Фамилия: " + emp1.Surname);
            Console.WriteLine("Возраст: " + emp1.Age);
            Console.WriteLine("ЗП: " + emp1.Salary);
            Console.WriteLine("ID: " + emp1.ID);

            emp1.CelebrateBirthday();
            Console.WriteLine("Возраст: " + emp1.Age);

            emp1.Promote(30);
            Console.WriteLine("ЗП: " + emp1.Salary);

            Console.WriteLine(emp1.GetPerspective());
        }
    }
}
