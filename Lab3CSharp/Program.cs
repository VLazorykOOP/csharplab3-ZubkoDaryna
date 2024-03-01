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
                 
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        
    }
}

    
