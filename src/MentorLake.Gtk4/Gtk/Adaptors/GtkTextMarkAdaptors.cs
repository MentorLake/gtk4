using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTextMarkAdaptors
{
	public static GtkTextMarkHandle SetVisible(this GtkTextMarkHandle mark, int setting)
	{
		GtkTextMarkExterns.gtk_text_mark_set_visible(mark, setting);
		return mark;
	}

	public static int GetVisible(this GtkTextMarkHandle mark)
	{
		return GtkTextMarkExterns.gtk_text_mark_get_visible(mark);
	}

	public static string GetName(this GtkTextMarkHandle mark)
	{
		return GtkTextMarkExterns.gtk_text_mark_get_name(mark);
	}

	public static int GetDeleted(this GtkTextMarkHandle mark)
	{
		return GtkTextMarkExterns.gtk_text_mark_get_deleted(mark);
	}

	public static GtkTextBufferHandle GetBuffer(this GtkTextMarkHandle mark)
	{
		return GtkTextMarkExterns.gtk_text_mark_get_buffer(mark);
	}

	public static int GetLeftGravity(this GtkTextMarkHandle mark)
	{
		return GtkTextMarkExterns.gtk_text_mark_get_left_gravity(mark);
	}
}
