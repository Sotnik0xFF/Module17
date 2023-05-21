namespace Module17.Accounts;

public abstract class Account
{
    public double Balance { get; set; }
    public abstract string TypeName { get; }
    public abstract double CalculateInterest();
}
