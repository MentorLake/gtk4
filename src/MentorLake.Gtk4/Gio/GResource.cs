namespace MentorLake.Gtk4.Gio;

public class GResourceHandle : BaseSafeHandle
{
	public static GResourceHandle NewFromData(GBytesHandle data, out GErrorHandle error)
	{
		return GResourceExterns.g_resource_new_from_data(data, out error);
	}

}

internal class GResourceExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GResourceHandle g_resource_new_from_data(GBytesHandle data, out GErrorHandle error);

}

public struct GResource
{
}
