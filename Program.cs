namespace CAOverLoadingOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money m1 = new Money(10);
            Money m2 = new Money(20);
            Console.WriteLine($"Amount1: {m1.Amount} | Amount2: {m2.Amount}");

            var m3 = m1 + m2;
            Console.WriteLine($"Sum M3= {m3.Amount}");

            var m4 = m1 - m2;
            Console.WriteLine($"Sum M4= {m4.Amount}");

            Console.WriteLine(m3 > m4);

            Console.WriteLine($"++M4 = {(++m4).Amount}");
        }
    }

    public class Money
    {
        private decimal amount;

        public decimal Amount => this.amount;

        public Money(decimal value)
        {
            this.amount = value;
        }

        public static Money operator +(Money money1, Money money2)
        {
            var money3 = money1.amount + money2.amount;
            return new Money(money3);
        }

        public static Money operator -(Money money1, Money money2)
        {
            var result = money1.amount - money2.amount;
            return new Money(result);
        }

        public static Money operator ++(Money money)
        {
            var result = money.amount;
            return new Money(++result);
        }
        public static Money operator --(Money money)
        {
            var result = money.amount;
            return new Money(--result);
        }

        public static bool operator <(Money money1, Money money2)
        {
            
            return money1.amount < money2.amount;
        }

        public static bool operator >(Money money1, Money money2)
        {

            return money1.amount > money2.amount;
        }

        public static bool operator <=(Money money1, Money money2)
        {

            return money1.amount <= money2.amount;
        }

        public static bool operator >=(Money money1, Money money2)
        {

            return money1.amount >= money2.amount;
        }

        public static bool operator ==(Money money1, Money money2)
        {

            return money1.amount == money2.amount;
        }
        
        
        
        public static bool operator !=(Money money1, Money money2)
        {

            return money1.amount != money2.amount;
        }

    }
}