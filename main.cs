public class Container
{
    private double waterAmount;
    private Container connectedTo = null;

    public double GetAmount()
    {
        if (connectedTo == null) return 0.0;

        return connectedTo.waterAmount;
    }

    public void AddWater(double amt)
    {
        if (connectedTo == null)
        {
            waterAmount += amt;
        }
        else
        {
            double total = GetAmount() * 2 + amt;
            double forSingle = total / 2.0;
            waterAmount = forSingle;
            connectedTo.waterAmount = forSingle;
        }
    }

    public void ConnectTo(Container c)
    {
        if (connectedTo == c) return;

        double total = waterAmount + c.waterAmount;
        double forSingle = total / 2.0;

        waterAmount = forSingle;
        c.waterAmount = forSingle;

        connectedTo = c;
        c.connectedTo = this;
    }

    public void DisconnectFrom(Container c)
    {
       
    }
}