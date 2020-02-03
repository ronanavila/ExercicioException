using ExercicioException.Entities.Exception;

namespace ExercicioException.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithDrawLimit { get; private set; }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double ammount)
        {
            Balance += ammount;
        }

        public void WithDraw(double ammount)
        {
            if (WithDrawLimit < ammount)
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            if (Balance < ammount)
                throw new DomainException("Withdraw error: Not enough balance");

            Balance -= ammount;
        }

    }

}
