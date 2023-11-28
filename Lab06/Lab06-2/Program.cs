
class Customer
{
    public string Name { get; set; }
    public double Balance { get; private set; }

    public Customer(string name, double balance = 100)
    {
        Name = name;
        Balance = balance;
    }

    public override string ToString()
    {
        return string.Format("Клиент: {0} имеет баланс: {1}", Name, Balance);
    }

    public void RecordPayment(double amountPaid)
    {
        if (amountPaid > 0)
            Balance += amountPaid;
    }

    public void RecordCall(double cost)
    {
        Balance -= cost;
    }
}

class RateCalc
{
    public double CityRate = 5;
    public double MobileRate = 1;
    
    public double CalcCost(string rateType, double duration)
    {
        switch (rateType)
        {
            case "CityRate":
                return duration * CityRate;
            case "After10City":
                return (duration <= 10 ? duration * CityRate : (10 * CityRate) + (duration - 10) * (CityRate / 2));
            case "First5City":
                return (duration <= 5 ? duration * CityRate / 2 : (5 * CityRate / 2) + (duration - 5) * CityRate * 2);
            case "MobileRate":
                return duration * MobileRate;
            case "After10Mobile":
                return(duration <= 10 ? duration * MobileRate : (10 * MobileRate) + (duration - 10) * (MobileRate / 2));
            case "First5Mobile":
                return (duration <= 5 ? duration * MobileRate / 2 : (5 * MobileRate / 2) + (duration - 5) * MobileRate*2);
            default:
                return 0;
        }
    }
}

class Customer1
{
    static void Main(string[] args)
    {   
        RateCalc rateCalc = new();

        Customer Ivan = new Customer("Иван Петров", 500);
        Customer Elena = new Customer("Елена Иванова");

        Ivan.RecordCall(rateCalc.CalcCost("MobileRate", 15));
        Elena.RecordCall(rateCalc.CalcCost("After10City", 25));

        Console.WriteLine(Ivan);
        Console.WriteLine(Elena);
    }
}
