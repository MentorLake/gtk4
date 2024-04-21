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

public class GtkMapListModelHandle : GObjectHandle, GListModelHandle, GtkSectionModelHandle
{
	public static GtkMapListModelHandle New(GListModelHandle model, GtkMapListModelMapFunc map_func, IntPtr user_data, GDestroyNotify user_destroy)
	{
		return GtkMapListModelExterns.gtk_map_list_model_new(model, map_func, user_data, user_destroy);
	}

}

public static class GtkMapListModelHandleExtensions
{
	public static GListModelHandle GetModel(this GtkMapListModelHandle self)
	{
		return GtkMapListModelExterns.gtk_map_list_model_get_model(self);
	}

	public static bool HasMap(this GtkMapListModelHandle self)
	{
		return GtkMapListModelExterns.gtk_map_list_model_has_map(self);
	}

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

}

internal class GtkMapListModelExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMapListModelHandle gtk_map_list_model_new(GListModelHandle model, GtkMapListModelMapFunc map_func, IntPtr user_data, GDestroyNotify user_destroy);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_map_list_model_get_model(GtkMapListModelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_map_list_model_has_map(GtkMapListModelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_map_list_model_set_map_func(GtkMapListModelHandle self, GtkMapListModelMapFunc map_func, IntPtr user_data, GDestroyNotify user_destroy);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_map_list_model_set_model(GtkMapListModelHandle self, GListModelHandle model);

}
