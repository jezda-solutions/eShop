namespace eShop.OrderProcessor;

public class BackgroundTaskOptions
{
    /// <summary>
    /// In minutes
    /// </summary>
    public int GracePeriodTime { get; set; }

    /// <summary>
    /// Background task will check every CheckUpdateTime seconds for submitted orders.
    /// </summary>
    public int CheckUpdateTime { get; set; }
}
