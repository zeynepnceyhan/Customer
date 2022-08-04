namespace ConsoleApp5
{
    class Program
    { public class musteri
        {
            public string Name;
            public string Surname;
            public int Money;
            public string gender;
            private int age;

            public musteri()
            {
                Console.WriteLine("The constructor method of the client class worked!");
            }

            public void ShowCustomersInfo()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Surname: " + Surname);
                Console.WriteLine("Salary: " + Money);
                Console.WriteLine("Gender: " + gender);
                Console.WriteLine("Age: " + age);
            }

            private void NameSurname(string customerName, string customerSurname)
            {
                Console.WriteLine("The customer's name and surname: " + customerName + customerSurname);
            }
        }

        static void Main(string[] args)
        {
            musteri musteri1 = new musteri();

            musteri1.Name = "Zeynep";
            musteri1.Surname = "Ceyhan";
            musteri1.gender = "Kadın";
            musteri1.Money = 5000;
            musteri1.ShowCustomersInfo();

        }

    }
}