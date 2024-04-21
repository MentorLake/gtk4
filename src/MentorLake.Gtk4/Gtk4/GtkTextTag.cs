using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkTextTagHandle : GObjectHandle
{
	public static GtkTextTagHandle New(string name)
	{
		return GtkTextTagExterns.gtk_text_tag_new(name);
	}

}

public static class GtkTextTagHandleExtensions
{
	public static GtkTextTagHandle Changed(this GtkTextTagHandle tag, bool size_changed)
	{
		GtkTextTagExterns.gtk_text_tag_changed(tag, size_changed);
		return tag;
	}

	public static int GetPriority(this GtkTextTagHandle tag)
	{
		return GtkTextTagExterns.gtk_text_tag_get_priority(tag);
	}

	public static GtkTextTagHandle SetPriority(this GtkTextTagHandle tag, int priority)
	{
		GtkTextTagExterns.gtk_text_tag_set_priority(tag, priority);
		return tag;
	}

}

internal class GtkTextTagExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextTagHandle gtk_text_tag_new(string name);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_tag_changed(GtkTextTagHandle tag, bool size_changed);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_tag_get_priority(GtkTextTagHandle tag);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_tag_set_priority(GtkTextTagHandle tag, int priority);

}
