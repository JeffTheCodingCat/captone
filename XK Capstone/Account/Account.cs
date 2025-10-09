using System.Runtime.CompilerServices;

class Account
{
    float balance;
    string owner;
    public Account(float newBal, string newOwner)
    {
        balance = newBal;
        owner = newOwner;
    }
    public void show()
    {
        Console.WriteLine($"The owner of this account is {owner} and the balance is {balance}");
    }
    public void depoisit(float amount)
    {
        balance += amount;
    }
    public float getBalance()
    {
        return balance;
    }
    public bool withdraw(float amount)
    {
        if (amount < balance) { balance -= amount; return true; }
        return false;
    }
    public bool transfer(Account other, float amount)
    {
        if (amount < other.balance)
        {
            balance += amount;
            other.balance -= amount;
            return true;
        }
        return false;
    }
}