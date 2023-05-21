using Module17.Properties;

namespace Module17.Accounts;

public class SalaryAccount : Account
{
    public override string TypeName => Resources.SalaryAccountTypeName;

    public override double CalculateInterest() => Balance * 0.5;
}
