namespace MentorLake.Gtk4.Gio;

public interface GIconHandle
{
}

internal class GIconHandleImpl : BaseSafeHandle, GIconHandle
{
}

public static class GIconHandleExtensions
{
	public static bool Equal(this GIconHandle icon1, GIconHandle icon2)
	{
		return GIconExterns.g_icon_equal(icon1, icon2);
	}

	public static uint Hash(this IntPtr icon)
	{
		return GIconExterns.g_icon_hash(icon);
	}

	public static GVariantHandle Serialize(this GIconHandle icon)
	{
		return GIconExterns.g_icon_serialize(icon);
	}

	public static string ToString(this GIconHandle icon)
	{
		return GIconExterns.g_icon_to_string(icon);
	}

}

internal class GIconExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_icon_equal(GIconHandle icon1, GIconHandle icon2);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_icon_hash(IntPtr icon);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_icon_serialize(GIconHandle icon);

	[DllImport(Libraries.Gio)]
	internal static extern string g_icon_to_string(GIconHandle icon);

}
