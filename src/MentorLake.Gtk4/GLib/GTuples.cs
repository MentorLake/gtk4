namespace MentorLake.Gtk4.GLib;

public class GTuplesHandle : BaseSafeHandle
{
}


public static class GTuplesHandleExtensions
{
	public static GTuplesHandle Destroy(this GTuplesHandle tuples)
	{
		GTuplesExterns.g_tuples_destroy(tuples);
		return tuples;
	}

	public static IntPtr Index(this GTuplesHandle tuples, int index_, int field)
	{
		return GTuplesExterns.g_tuples_index(tuples, index_, field);
	}

}
internal class GTuplesExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_tuples_destroy(GTuplesHandle tuples);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_tuples_index(GTuplesHandle tuples, int index_, int field);

}

public struct GTuples
{
	public uint len;
}
