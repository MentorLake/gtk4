namespace MentorLake.Gtk4.Gtk4;

public class GtkIconPaintableHandle : GObjectHandle, GdkPaintableHandle, GtkSymbolicPaintableHandle
{
	public static GtkIconPaintableHandle NewForFile(GFileHandle file, int size, int scale)
	{
		return GtkIconPaintableExterns.gtk_icon_paintable_new_for_file(file, size, scale);
	}

}

public static class GtkIconPaintableHandleExtensions
{
	public static GFileHandle GetFile(this GtkIconPaintableHandle self)
	{
		return GtkIconPaintableExterns.gtk_icon_paintable_get_file(self);
	}

	public static string GetIconName(this GtkIconPaintableHandle self)
	{
		return GtkIconPaintableExterns.gtk_icon_paintable_get_icon_name(self);
	}

	public static bool IsSymbolic(this GtkIconPaintableHandle self)
	{
		return GtkIconPaintableExterns.gtk_icon_paintable_is_symbolic(self);
	}

}

internal class GtkIconPaintableExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkIconPaintableHandle gtk_icon_paintable_new_for_file(GFileHandle file, int size, int scale);

	[DllImport(Libraries.Gtk4)]
	internal static extern GFileHandle gtk_icon_paintable_get_file(GtkIconPaintableHandle self);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_icon_paintable_get_icon_name(GtkIconPaintableHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_icon_paintable_is_symbolic(GtkIconPaintableHandle self);

}
