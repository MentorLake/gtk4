namespace MentorLake.Gtk4.Gtk4;

public class GtkFileFilterHandle : GtkFilterHandle, GtkBuildableHandle
{
	public static GtkFileFilterHandle New()
	{
		return GtkFileFilterExterns.gtk_file_filter_new();
	}

	public static GtkFileFilterHandle NewFromGvariant(GVariantHandle variant)
	{
		return GtkFileFilterExterns.gtk_file_filter_new_from_gvariant(variant);
	}

}

public static class GtkFileFilterHandleExtensions
{
	public static GtkFileFilterHandle AddMimeType(this GtkFileFilterHandle filter, string mime_type)
	{
		GtkFileFilterExterns.gtk_file_filter_add_mime_type(filter, mime_type);
		return filter;
	}

	public static GtkFileFilterHandle AddPattern(this GtkFileFilterHandle filter, string pattern)
	{
		GtkFileFilterExterns.gtk_file_filter_add_pattern(filter, pattern);
		return filter;
	}

	public static GtkFileFilterHandle AddPixbufFormats(this GtkFileFilterHandle filter)
	{
		GtkFileFilterExterns.gtk_file_filter_add_pixbuf_formats(filter);
		return filter;
	}

	public static GtkFileFilterHandle AddSuffix(this GtkFileFilterHandle filter, string suffix)
	{
		GtkFileFilterExterns.gtk_file_filter_add_suffix(filter, suffix);
		return filter;
	}

	public static IntPtr GetAttributes(this GtkFileFilterHandle filter)
	{
		return GtkFileFilterExterns.gtk_file_filter_get_attributes(filter);
	}

	public static string GetName(this GtkFileFilterHandle filter)
	{
		return GtkFileFilterExterns.gtk_file_filter_get_name(filter);
	}

	public static GtkFileFilterHandle SetName(this GtkFileFilterHandle filter, string name)
	{
		GtkFileFilterExterns.gtk_file_filter_set_name(filter, name);
		return filter;
	}

	public static GVariantHandle ToGvariant(this GtkFileFilterHandle filter)
	{
		return GtkFileFilterExterns.gtk_file_filter_to_gvariant(filter);
	}

}

internal class GtkFileFilterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFileFilterHandle gtk_file_filter_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFileFilterHandle gtk_file_filter_new_from_gvariant(GVariantHandle variant);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_filter_add_mime_type(GtkFileFilterHandle filter, string mime_type);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_filter_add_pattern(GtkFileFilterHandle filter, string pattern);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_filter_add_pixbuf_formats(GtkFileFilterHandle filter);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_filter_add_suffix(GtkFileFilterHandle filter, string suffix);

	[DllImport(Libraries.Gtk4)]
	internal static extern IntPtr gtk_file_filter_get_attributes(GtkFileFilterHandle filter);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_filter_get_name(GtkFileFilterHandle filter);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_filter_set_name(GtkFileFilterHandle filter, string name);

	[DllImport(Libraries.Gtk4)]
	internal static extern GVariantHandle gtk_file_filter_to_gvariant(GtkFileFilterHandle filter);

}
