namespace MentorLake.Gtk4.Gio;

public interface GPowerProfileMonitorHandle
{
}

internal class GPowerProfileMonitorHandleImpl : BaseSafeHandle, GPowerProfileMonitorHandle
{
}

public static class GPowerProfileMonitorHandleExtensions
{
	public static bool GetPowerSaverEnabled(this GPowerProfileMonitorHandle monitor)
	{
		return GPowerProfileMonitorExterns.g_power_profile_monitor_get_power_saver_enabled(monitor);
	}

}

internal class GPowerProfileMonitorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_power_profile_monitor_get_power_saver_enabled(GPowerProfileMonitorHandle monitor);

}
