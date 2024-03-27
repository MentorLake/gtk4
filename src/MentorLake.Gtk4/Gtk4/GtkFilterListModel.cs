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

public class GtkFilterListModelHandle : GObjectHandle
{
	public static GtkFilterListModelHandle New(GListModelHandle model, GtkFilterHandle filter)
	{
		return GtkFilterListModelExterns.gtk_filter_list_model_new(model, filter);
	}
}

public static class GtkFilterListModelSignals
{
}

public static class GtkFilterListModelHandleExtensions
{
	public static GtkFilterHandle GetFilter(this GtkFilterListModelHandle self)
	{
		return GtkFilterListModelExterns.gtk_filter_list_model_get_filter(self);
	}

	public static bool GetIncremental(this GtkFilterListModelHandle self)
	{
		return GtkFilterListModelExterns.gtk_filter_list_model_get_incremental(self);
	}

	public static GListModelHandle GetModel(this GtkFilterListModelHandle self)
	{
		return GtkFilterListModelExterns.gtk_filter_list_model_get_model(self);
	}

	public static uint GetPending(this GtkFilterListModelHandle self)
	{
		return GtkFilterListModelExterns.gtk_filter_list_model_get_pending(self);
	}

	public static GtkFilterListModelHandle SetFilter(this GtkFilterListModelHandle self, GtkFilterHandle filter)
	{
		GtkFilterListModelExterns.gtk_filter_list_model_set_filter(self, filter);
		return self;
	}

	public static GtkFilterListModelHandle SetIncremental(this GtkFilterListModelHandle self, bool incremental)
	{
		GtkFilterListModelExterns.gtk_filter_list_model_set_incremental(self, incremental);
		return self;
	}

	public static GtkFilterListModelHandle SetModel(this GtkFilterListModelHandle self, GListModelHandle model)
	{
		GtkFilterListModelExterns.gtk_filter_list_model_set_model(self, model);
		return self;
	}

}

internal class GtkFilterListModelExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFilterHandle gtk_filter_list_model_get_filter(GtkFilterListModelHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_filter_list_model_get_incremental(GtkFilterListModelHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_filter_list_model_get_model(GtkFilterListModelHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_filter_list_model_get_pending(GtkFilterListModelHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_filter_list_model_set_filter(GtkFilterListModelHandle self, GtkFilterHandle filter);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_filter_list_model_set_incremental(GtkFilterListModelHandle self, bool incremental);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_filter_list_model_set_model(GtkFilterListModelHandle self, GListModelHandle model);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFilterListModelHandle gtk_filter_list_model_new(GListModelHandle model, GtkFilterHandle filter);
}
