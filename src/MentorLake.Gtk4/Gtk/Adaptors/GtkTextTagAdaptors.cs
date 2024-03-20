using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTextTagAdaptors
{
	public static int GetPriority(this GtkTextTagHandle tag)
	{
		return GtkTextTagExterns.gtk_text_tag_get_priority(tag);
	}

	public static GtkTextTagHandle SetPriority(this GtkTextTagHandle tag, int priority)
	{
		GtkTextTagExterns.gtk_text_tag_set_priority(tag, priority);
		return tag;
	}

	public static GtkTextTagHandle Changed(this GtkTextTagHandle tag, int size_changed)
	{
		GtkTextTagExterns.gtk_text_tag_changed(tag, size_changed);
		return tag;
	}
}
