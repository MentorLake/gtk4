namespace MentorLake.Gtk4.Gio;

public class GSrvTargetHandle : BaseSafeHandle
{
	public static GSrvTargetHandle New(string hostname, ushort port, ushort priority, ushort weight)
	{
		return GSrvTargetExterns.g_srv_target_new(hostname, port, priority, weight);
	}

}

internal class GSrvTargetExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSrvTargetHandle g_srv_target_new(string hostname, ushort port, ushort priority, ushort weight);

}

public struct GSrvTarget
{
}
