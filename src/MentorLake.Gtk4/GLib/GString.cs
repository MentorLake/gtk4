namespace MentorLake.Gtk4.GLib;

public class GStringHandle : BaseSafeHandle
{
	public static GStringHandle New(string init)
	{
		return GStringExterns.g_string_new(init);
	}

	public static GStringHandle NewLen(string init, UIntPtr len)
	{
		return GStringExterns.g_string_new_len(init, len);
	}

	public static GStringHandle NewTake(string init)
	{
		return GStringExterns.g_string_new_take(init);
	}

	public static GStringHandle SizedNew(UIntPtr dfl_size)
	{
		return GStringExterns.g_string_sized_new(dfl_size);
	}

}

internal class GStringExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_new(string init);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_new_len(string init, UIntPtr len);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_new_take(string init);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_string_sized_new(UIntPtr dfl_size);

}

public struct GString
{
	public string str;
	public UIntPtr len;
	public UIntPtr allocated_len;
}
