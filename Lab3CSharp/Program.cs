using System;
/* Масив монета(Money) який моделює гаманець та масив товарів. 
Визначити кожного з товарів можна купити за кошти які знаходяться в гаманці. 
Створити клас Money*/
public class Money
{
    private int nominal;
    private int num;

    public Money(int nominal, int num)
    {
        this.nominal = nominal;
        this.num = num;
    }

    public void Print()
    {
        Console.WriteLine($"Nominal: {nominal}, Number: {num}");
    }

    public bool CanBuy(int price)
    {
        return price <= nominal * num;
    }

    public int CalculateItems(int price)
    {
        return (nominal * num) / price;
    }

    public int Nominal
    {
        get { return nominal; } 
        set { nominal = value; }
    }

    public int Num
    {
        get { return num; }
        set { num = value; }
    }

    public int TotalAmount
    {
        get { return nominal * num; }
    }
}
//Організація, страхова компанія, нафтогазова компанія, завод.
    public class Company
    {
        public string Name { get; set; }
        public int Employees { get; set; }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {Name}, Employees: {Employees}");
        }
    }
    public class InsuranceCompany : Company
    {
        public int Policies { get; set; }
        public override void Show()
        {
            Console.WriteLine($"Name: {Name}, Employees: {Employees}, Policies: {Policies}");
        }
    }

    public class OilGasCompany : Company
    {
        public int Wells { get; set; }

        public override void Show()
        {
            Console.WriteLine($"Name: {Name}, Employees: {Employees}, Wells: {Wells}");
        }
    }

    public class Factory : Company
    {
        public int ProductionLines { get; set; }

        public override void Show()
        {
            Console.WriteLine($"Name: {Name}, Employees: {Employees}, ProductionLines: {ProductionLines}");
        }
    }
class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("1. Task 1");
            Console.WriteLine("2. Task 2");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter nominal: ");
                    int nominal = int.Parse(Console.ReadLine());
                    Console.Write("Enter number: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.Write("Enter the price: ");
                    int price = int.Parse(Console.ReadLine());

                    Money money = new Money(nominal, num);
                    money.Print();
                    Console.WriteLine($"Can buy: {money.CanBuy(price)}");
                    Console.WriteLine($"Calculate items: {money.CalculateItems(price)}"); break;
                case "2":
                    Console.WriteLine("Task 2");
                    List<Company> companies = new List<Company>
        {
            new InsuranceCompany { Name = "InsuranceCo1", Employees = 100, Policies = 500 },
            new OilGasCompany { Name = "OilGasCo1", Employees = 200, Wells = 50 },
            new Factory { Name = "Factory1", Employees = 300, ProductionLines = 10 },
            new InsuranceCompany { Name = "InsuranceCo2", Employees = 150, Policies = 300 },
            new OilGasCompany { Name = "OilGasCo2", Employees = 250, Wells = 40 },
            new Factory { Name = "Factory2", Employees = 350, ProductionLines = 15 }
        };

                    Console.WriteLine("Unsorted:");
                    foreach (var company in companies)
                    {
                        company.Show();
                    }

                    Console.WriteLine("Sorted by Employees:");
                    companies = companies.OrderBy(c => c.Employees).ToList();
                    foreach (var company in companies)
                    {
                        company.Show();
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        
    }
}

    
