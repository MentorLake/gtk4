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

public class GtkTreeListRowSorterHandle : GtkSorterHandle
{
	public static GtkTreeListRowSorterHandle New(GtkSorterHandle sorter)
	{
		return GtkTreeListRowSorterExterns.gtk_tree_list_row_sorter_new(sorter);
	}
}

public static class GtkTreeListRowSorterSignals
{
}

public static class GtkTreeListRowSorterHandleExtensions
{
	public static GtkSorterHandle GetSorter(this GtkTreeListRowSorterHandle self)
	{
		return GtkTreeListRowSorterExterns.gtk_tree_list_row_sorter_get_sorter(self);
	}

	public static GtkTreeListRowSorterHandle SetSorter(this GtkTreeListRowSorterHandle self, GtkSorterHandle sorter)
	{
		GtkTreeListRowSorterExterns.gtk_tree_list_row_sorter_set_sorter(self, sorter);
		return self;
	}

}

internal class GtkTreeListRowSorterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSorterHandle gtk_tree_list_row_sorter_get_sorter(GtkTreeListRowSorterHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_list_row_sorter_set_sorter(GtkTreeListRowSorterHandle self, GtkSorterHandle sorter);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeListRowSorterHandle gtk_tree_list_row_sorter_new(GtkSorterHandle sorter);
}
