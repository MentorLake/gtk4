namespace MentorLake.Gtk4.Gio;

public class GSrvTargetHandle : BaseSafeHandle
{
	public static GSrvTargetHandle New(string hostname, ushort port, ushort priority, ushort weight)
	{
		return GSrvTargetExterns.g_srv_target_new(hostname, port, priority, weight);
	}

}


public static class GSrvTargetHandleExtensions
{
	public static GSrvTargetHandle Copy(this GSrvTargetHandle target)
	{
		return GSrvTargetExterns.g_srv_target_copy(target);
	}

	public static GSrvTargetHandle Free(this GSrvTargetHandle target)
	{
		GSrvTargetExterns.g_srv_target_free(target);
		return target;
	}

	public static string GetHostname(this GSrvTargetHandle target)
	{
		return GSrvTargetExterns.g_srv_target_get_hostname(target);
	}

	public static ushort GetPort(this GSrvTargetHandle target)
	{
		return GSrvTargetExterns.g_srv_target_get_port(target);
	}

	public static ushort GetPriority(this GSrvTargetHandle target)
	{
		return GSrvTargetExterns.g_srv_target_get_priority(target);
	}

	public static ushort GetWeight(this GSrvTargetHandle target)
	{
		return GSrvTargetExterns.g_srv_target_get_weight(target);
	}

}
internal class GSrvTargetExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSrvTargetHandle g_srv_target_new(string hostname, ushort port, ushort priority, ushort weight);

	[DllImport(Libraries.Gio)]
	internal static extern GSrvTargetHandle g_srv_target_copy(GSrvTargetHandle target);

	[DllImport(Libraries.Gio)]
	internal static extern void g_srv_target_free(GSrvTargetHandle target);

	[DllImport(Libraries.Gio)]
	internal static extern string g_srv_target_get_hostname(GSrvTargetHandle target);

	[DllImport(Libraries.Gio)]
	internal static extern ushort g_srv_target_get_port(GSrvTargetHandle target);

	[DllImport(Libraries.Gio)]
	internal static extern ushort g_srv_target_get_priority(GSrvTargetHandle target);

	[DllImport(Libraries.Gio)]
	internal static extern ushort g_srv_target_get_weight(GSrvTargetHandle target);

}

public struct GSrvTarget
{
}
