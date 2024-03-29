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

public class GtkMultiSorterHandle : GtkSorterHandle
{
	public static GtkMultiSorterHandle New()
	{
		return GtkMultiSorterExterns.gtk_multi_sorter_new();
	}

}

public static class GtkMultiSorterHandleExtensions
{
	public static GtkMultiSorterHandle Append(this GtkMultiSorterHandle self, GtkSorterHandle sorter)
	{
		GtkMultiSorterExterns.gtk_multi_sorter_append(self, sorter);
		return self;
	}

	public static GtkMultiSorterHandle Remove(this GtkMultiSorterHandle self, uint position)
	{
		GtkMultiSorterExterns.gtk_multi_sorter_remove(self, position);
		return self;
	}

}

internal class GtkMultiSorterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMultiSorterHandle gtk_multi_sorter_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_multi_sorter_append(GtkMultiSorterHandle self, GtkSorterHandle sorter);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_multi_sorter_remove(GtkMultiSorterHandle self, uint position);
}
