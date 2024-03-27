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

public class GtkAccessibleTextHandle  : GtkAccessibleHandle
{
}

public static class GtkAccessibleTextHandleExtensions
{
	public static GtkAccessibleTextHandle UpdateCaretPosition(this GtkAccessibleTextHandle self)
	{
		GtkAccessibleTextExterns.gtk_accessible_text_update_caret_position(self);
		return self;
	}

	public static GtkAccessibleTextHandle UpdateContents(this GtkAccessibleTextHandle self, GtkAccessibleTextContentChange change, int start, int end)
	{
		GtkAccessibleTextExterns.gtk_accessible_text_update_contents(self, change, start, end);
		return self;
	}

	public static GtkAccessibleTextHandle UpdateSelectionBound(this GtkAccessibleTextHandle self)
	{
		GtkAccessibleTextExterns.gtk_accessible_text_update_selection_bound(self);
		return self;
	}

}

internal class GtkAccessibleTextExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_text_update_caret_position(GtkAccessibleTextHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_text_update_contents(GtkAccessibleTextHandle self, GtkAccessibleTextContentChange change, int start, int end);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_text_update_selection_bound(GtkAccessibleTextHandle self);
}
