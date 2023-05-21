using Module17.Properties;

namespace Module17.Accounts;

internal class RegularAccount : Account
{
    public override string TypeName => Resources.RegularAccountTypeName;

    public override double CalculateInterest()
    {
        double interest = Balance * 0.4;

        if (Balance < 1000)
            return interest - Balance * 0.2;

        if (Balance < 50000)
            return interest - Balance * 0.4;

        return interest;
    }
}
