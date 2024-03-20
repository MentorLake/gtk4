using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFilterListModelAdaptors
{
	public static GtkFilterListModelHandle SetFilter(this GtkFilterListModelHandle self, GtkFilterHandle filter)
	{
		GtkFilterListModelExterns.gtk_filter_list_model_set_filter(self, filter);
		return self;
	}

	public static GtkFilterHandle GetFilter(this GtkFilterListModelHandle self)
	{
		return GtkFilterListModelExterns.gtk_filter_list_model_get_filter(self);
	}

	public static GtkFilterListModelHandle SetModel(this GtkFilterListModelHandle self, GListModelHandle model)
	{
		GtkFilterListModelExterns.gtk_filter_list_model_set_model(self, model);
		return self;
	}

	public static GListModelHandle GetModel(this GtkFilterListModelHandle self)
	{
		return GtkFilterListModelExterns.gtk_filter_list_model_get_model(self);
	}

	public static GtkFilterListModelHandle SetIncremental(this GtkFilterListModelHandle self, int incremental)
	{
		GtkFilterListModelExterns.gtk_filter_list_model_set_incremental(self, incremental);
		return self;
	}

	public static int GetIncremental(this GtkFilterListModelHandle self)
	{
		return GtkFilterListModelExterns.gtk_filter_list_model_get_incremental(self);
	}

	public static uint GetPending(this GtkFilterListModelHandle self)
	{
		return GtkFilterListModelExterns.gtk_filter_list_model_get_pending(self);
	}
}
