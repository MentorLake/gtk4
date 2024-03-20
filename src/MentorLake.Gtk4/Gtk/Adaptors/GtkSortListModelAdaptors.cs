using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSortListModelAdaptors
{
	public static GtkSortListModelHandle SetSorter(this GtkSortListModelHandle self, GtkSorterHandle sorter)
	{
		GtkSortListModelExterns.gtk_sort_list_model_set_sorter(self, sorter);
		return self;
	}

	public static GtkSorterHandle GetSorter(this GtkSortListModelHandle self)
	{
		return GtkSortListModelExterns.gtk_sort_list_model_get_sorter(self);
	}

	public static GtkSortListModelHandle SetModel(this GtkSortListModelHandle self, GListModelHandle model)
	{
		GtkSortListModelExterns.gtk_sort_list_model_set_model(self, model);
		return self;
	}

	public static GListModelHandle GetModel(this GtkSortListModelHandle self)
	{
		return GtkSortListModelExterns.gtk_sort_list_model_get_model(self);
	}

	public static GtkSortListModelHandle SetIncremental(this GtkSortListModelHandle self, int incremental)
	{
		GtkSortListModelExterns.gtk_sort_list_model_set_incremental(self, incremental);
		return self;
	}

	public static int GetIncremental(this GtkSortListModelHandle self)
	{
		return GtkSortListModelExterns.gtk_sort_list_model_get_incremental(self);
	}

	public static uint GetPending(this GtkSortListModelHandle self)
	{
		return GtkSortListModelExterns.gtk_sort_list_model_get_pending(self);
	}
}
