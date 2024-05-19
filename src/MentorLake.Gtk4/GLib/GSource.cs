namespace MentorLake.Gtk4.GLib;

public class GSourceHandle : BaseSafeHandle
{
	public static GSourceHandle New(GSourceFuncsHandle source_funcs, uint struct_size)
	{
		return GSourceExterns.g_source_new(source_funcs, struct_size);
	}

}

internal class GSourceExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GSourceHandle g_source_new(GSourceFuncsHandle source_funcs, uint struct_size);

}

public struct GSource
{
}
