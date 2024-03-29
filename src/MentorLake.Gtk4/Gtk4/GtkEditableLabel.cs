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

public class GtkEditableLabelHandle : GtkWidgetHandle
{
	public static GtkEditableLabelHandle New(string str)
	{
		return GtkEditableLabelExterns.gtk_editable_label_new(str);
	}

}

public static class GtkEditableLabelHandleExtensions
{
	public static bool GetEditing(this GtkEditableLabelHandle self)
	{
		return GtkEditableLabelExterns.gtk_editable_label_get_editing(self);
	}

	public static GtkEditableLabelHandle StartEditing(this GtkEditableLabelHandle self)
	{
		GtkEditableLabelExterns.gtk_editable_label_start_editing(self);
		return self;
	}

	public static GtkEditableLabelHandle StopEditing(this GtkEditableLabelHandle self, bool commit)
	{
		GtkEditableLabelExterns.gtk_editable_label_stop_editing(self, commit);
		return self;
	}

}

internal class GtkEditableLabelExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEditableLabelHandle gtk_editable_label_new(string str);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_editable_label_get_editing(GtkEditableLabelHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_editable_label_start_editing(GtkEditableLabelHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_editable_label_stop_editing(GtkEditableLabelHandle self, bool commit);
}
