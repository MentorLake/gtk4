namespace MentorLake.Gtk4.Gdk4;

public class GdkContentFormatsHandle : BaseSafeHandle
{
	public static GdkContentFormatsHandle New(string[] mime_types, uint n_mime_types)
	{
		return GdkContentFormatsExterns.gdk_content_formats_new(mime_types, n_mime_types);
	}

	public static GdkContentFormatsHandle NewForGtype(GType type)
	{
		return GdkContentFormatsExterns.gdk_content_formats_new_for_gtype(type);
	}

}

internal class GdkContentFormatsExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_content_formats_new(string[] mime_types, uint n_mime_types);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_content_formats_new_for_gtype(GType type);

}

public struct GdkContentFormats
{
}
