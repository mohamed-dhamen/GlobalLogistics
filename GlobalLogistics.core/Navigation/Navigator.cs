using GlobalLogistics.core.interfaces;

public class Navigator
{
    private IRouteStrategy _strategy;

    // Force a strategy at start (No more NullReferenceException!)
    public Navigator(IRouteStrategy initialStrategy)
    {
        if (initialStrategy == null) throw new ArgumentNullException(nameof(initialStrategy));
        _strategy = initialStrategy;
    }

    public void SetStrategy(IRouteStrategy strategy)
    {
        if (strategy == null) throw new ArgumentNullException(nameof(strategy));
        _strategy = strategy;
    }

    public double CalculateTime(double distance)
    {
        if (distance <= 0) throw new ArgumentException("Distance must be greater than 0.");
        return _strategy.CalculateTime(distance);
    }
}