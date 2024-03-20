using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkMapListModelAdaptors
{
	public static GtkMapListModelHandle SetMapFunc(this GtkMapListModelHandle self, GtkMapListModelMapFunc map_func, IntPtr user_data, GDestroyNotify user_destroy)
	{
		GtkMapListModelExterns.gtk_map_list_model_set_map_func(self, map_func, user_data, user_destroy);
		return self;
	}

	public static GtkMapListModelHandle SetModel(this GtkMapListModelHandle self, GListModelHandle model)
	{
		GtkMapListModelExterns.gtk_map_list_model_set_model(self, model);
		return self;
	}

	public static GListModelHandle GetModel(this GtkMapListModelHandle self)
	{
		return GtkMapListModelExterns.gtk_map_list_model_get_model(self);
	}

	public static int HasMap(this GtkMapListModelHandle self)
	{
		return GtkMapListModelExterns.gtk_map_list_model_has_map(self);
	}
}
