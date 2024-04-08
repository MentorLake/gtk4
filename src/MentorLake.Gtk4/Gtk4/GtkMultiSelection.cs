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

public class GtkMultiSelectionHandle : GObjectHandle, GListModelHandle, GtkSectionModelHandle, GtkSelectionModelHandle
{
	public static GtkMultiSelectionHandle New(GListModelHandle model)
	{
		return GtkMultiSelectionExterns.gtk_multi_selection_new(model);
	}

}

public static class GtkMultiSelectionHandleExtensions
{
	public static GListModelHandle GetModel(this GtkMultiSelectionHandle self)
	{
		return GtkMultiSelectionExterns.gtk_multi_selection_get_model(self);
	}

	public static GtkMultiSelectionHandle SetModel(this GtkMultiSelectionHandle self, GListModelHandle model)
	{
		GtkMultiSelectionExterns.gtk_multi_selection_set_model(self, model);
		return self;
	}

}

internal class GtkMultiSelectionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMultiSelectionHandle gtk_multi_selection_new(GListModelHandle model);
	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_multi_selection_get_model(GtkMultiSelectionHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_multi_selection_set_model(GtkMultiSelectionHandle self, GListModelHandle model);
}
