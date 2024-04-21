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

public class GtkTextChildAnchorHandle : GObjectHandle
{
	public static GtkTextChildAnchorHandle New()
	{
		return GtkTextChildAnchorExterns.gtk_text_child_anchor_new();
	}

	public static GtkTextChildAnchorHandle NewWithReplacement(string character)
	{
		return GtkTextChildAnchorExterns.gtk_text_child_anchor_new_with_replacement(character);
	}

}

public static class GtkTextChildAnchorHandleExtensions
{
	public static bool GetDeleted(this GtkTextChildAnchorHandle anchor)
	{
		return GtkTextChildAnchorExterns.gtk_text_child_anchor_get_deleted(anchor);
	}

	public static GtkWidgetHandle[] GetWidgets(this GtkTextChildAnchorHandle anchor, out uint out_len)
	{
		return GtkTextChildAnchorExterns.gtk_text_child_anchor_get_widgets(anchor, out out_len);
	}

}

internal class GtkTextChildAnchorExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextChildAnchorHandle gtk_text_child_anchor_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextChildAnchorHandle gtk_text_child_anchor_new_with_replacement(string character);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_child_anchor_get_deleted(GtkTextChildAnchorHandle anchor);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle[] gtk_text_child_anchor_get_widgets(GtkTextChildAnchorHandle anchor, out uint out_len);

}
