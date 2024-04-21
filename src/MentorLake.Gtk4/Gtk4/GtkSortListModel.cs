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

public class GtkSortListModelHandle : GObjectHandle, GListModelHandle, GtkSectionModelHandle
{
	public static GtkSortListModelHandle New(GListModelHandle model, GtkSorterHandle sorter)
	{
		return GtkSortListModelExterns.gtk_sort_list_model_new(model, sorter);
	}

}

public static class GtkSortListModelHandleExtensions
{
	public static bool GetIncremental(this GtkSortListModelHandle self)
	{
		return GtkSortListModelExterns.gtk_sort_list_model_get_incremental(self);
	}

	public static GListModelHandle GetModel(this GtkSortListModelHandle self)
	{
		return GtkSortListModelExterns.gtk_sort_list_model_get_model(self);
	}

	public static uint GetPending(this GtkSortListModelHandle self)
	{
		return GtkSortListModelExterns.gtk_sort_list_model_get_pending(self);
	}

	public static GtkSorterHandle GetSectionSorter(this GtkSortListModelHandle self)
	{
		return GtkSortListModelExterns.gtk_sort_list_model_get_section_sorter(self);
	}

	public static GtkSorterHandle GetSorter(this GtkSortListModelHandle self)
	{
		return GtkSortListModelExterns.gtk_sort_list_model_get_sorter(self);
	}

	public static GtkSortListModelHandle SetIncremental(this GtkSortListModelHandle self, bool incremental)
	{
		GtkSortListModelExterns.gtk_sort_list_model_set_incremental(self, incremental);
		return self;
	}

	public static GtkSortListModelHandle SetModel(this GtkSortListModelHandle self, GListModelHandle model)
	{
		GtkSortListModelExterns.gtk_sort_list_model_set_model(self, model);
		return self;
	}

	public static GtkSortListModelHandle SetSectionSorter(this GtkSortListModelHandle self, GtkSorterHandle sorter)
	{
		GtkSortListModelExterns.gtk_sort_list_model_set_section_sorter(self, sorter);
		return self;
	}

	public static GtkSortListModelHandle SetSorter(this GtkSortListModelHandle self, GtkSorterHandle sorter)
	{
		GtkSortListModelExterns.gtk_sort_list_model_set_sorter(self, sorter);
		return self;
	}

}

internal class GtkSortListModelExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSortListModelHandle gtk_sort_list_model_new(GListModelHandle model, GtkSorterHandle sorter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_sort_list_model_get_incremental(GtkSortListModelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_sort_list_model_get_model(GtkSortListModelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_sort_list_model_get_pending(GtkSortListModelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSorterHandle gtk_sort_list_model_get_section_sorter(GtkSortListModelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSorterHandle gtk_sort_list_model_get_sorter(GtkSortListModelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_sort_list_model_set_incremental(GtkSortListModelHandle self, bool incremental);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_sort_list_model_set_model(GtkSortListModelHandle self, GListModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_sort_list_model_set_section_sorter(GtkSortListModelHandle self, GtkSorterHandle sorter);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_sort_list_model_set_sorter(GtkSortListModelHandle self, GtkSorterHandle sorter);

}
