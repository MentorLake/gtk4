namespace MentorLake.Gtk4.Gtk4;

public class GtkTextMarkHandle : GObjectHandle
{
	public static GtkTextMarkHandle New(string name, bool left_gravity)
	{
		return GtkTextMarkExterns.gtk_text_mark_new(name, left_gravity);
	}

}

public static class GtkTextMarkHandleExtensions
{
	public static GtkTextBufferHandle GetBuffer(this GtkTextMarkHandle mark)
	{
		return GtkTextMarkExterns.gtk_text_mark_get_buffer(mark);
	}

	public static bool GetDeleted(this GtkTextMarkHandle mark)
	{
		return GtkTextMarkExterns.gtk_text_mark_get_deleted(mark);
	}

	public static bool GetLeftGravity(this GtkTextMarkHandle mark)
	{
		return GtkTextMarkExterns.gtk_text_mark_get_left_gravity(mark);
	}

	public static string GetName(this GtkTextMarkHandle mark)
	{
		return GtkTextMarkExterns.gtk_text_mark_get_name(mark);
	}

	public static bool GetVisible(this GtkTextMarkHandle mark)
	{
		return GtkTextMarkExterns.gtk_text_mark_get_visible(mark);
	}

	public static GtkTextMarkHandle SetVisible(this GtkTextMarkHandle mark, bool setting)
	{
		GtkTextMarkExterns.gtk_text_mark_set_visible(mark, setting);
		return mark;
	}

}

internal class GtkTextMarkExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextMarkHandle gtk_text_mark_new(string name, bool left_gravity);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextBufferHandle gtk_text_mark_get_buffer(GtkTextMarkHandle mark);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_mark_get_deleted(GtkTextMarkHandle mark);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_mark_get_left_gravity(GtkTextMarkHandle mark);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_text_mark_get_name(GtkTextMarkHandle mark);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_mark_get_visible(GtkTextMarkHandle mark);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_mark_set_visible(GtkTextMarkHandle mark, bool setting);

}
