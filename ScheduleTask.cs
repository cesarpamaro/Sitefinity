using Telerik.Sitefinity.Scheduling;
using Telerik.Sitefinity.Abstractions;

public class NightlySyncTask : ScheduledTask
{
    public override void ExecuteTask()
    {
        Log.Write("Nightly sync executed", ConfigurationPolicy.Trace);
    }
}
