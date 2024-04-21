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

public class GtkSingleSelectionHandle : GObjectHandle, GListModelHandle, GtkSectionModelHandle, GtkSelectionModelHandle
{
	public static GtkSingleSelectionHandle New(GListModelHandle model)
	{
		return GtkSingleSelectionExterns.gtk_single_selection_new(model);
	}

}

public static class GtkSingleSelectionHandleExtensions
{
	public static bool GetAutoselect(this GtkSingleSelectionHandle self)
	{
		return GtkSingleSelectionExterns.gtk_single_selection_get_autoselect(self);
	}

	public static bool GetCanUnselect(this GtkSingleSelectionHandle self)
	{
		return GtkSingleSelectionExterns.gtk_single_selection_get_can_unselect(self);
	}

	public static GListModelHandle GetModel(this GtkSingleSelectionHandle self)
	{
		return GtkSingleSelectionExterns.gtk_single_selection_get_model(self);
	}

	public static uint GetSelected(this GtkSingleSelectionHandle self)
	{
		return GtkSingleSelectionExterns.gtk_single_selection_get_selected(self);
	}

	public static GObjectHandle GetSelectedItem(this GtkSingleSelectionHandle self)
	{
		return GtkSingleSelectionExterns.gtk_single_selection_get_selected_item(self);
	}

	public static GtkSingleSelectionHandle SetAutoselect(this GtkSingleSelectionHandle self, bool autoselect)
	{
		GtkSingleSelectionExterns.gtk_single_selection_set_autoselect(self, autoselect);
		return self;
	}

	public static GtkSingleSelectionHandle SetCanUnselect(this GtkSingleSelectionHandle self, bool can_unselect)
	{
		GtkSingleSelectionExterns.gtk_single_selection_set_can_unselect(self, can_unselect);
		return self;
	}

	public static GtkSingleSelectionHandle SetModel(this GtkSingleSelectionHandle self, GListModelHandle model)
	{
		GtkSingleSelectionExterns.gtk_single_selection_set_model(self, model);
		return self;
	}

	public static GtkSingleSelectionHandle SetSelected(this GtkSingleSelectionHandle self, uint position)
	{
		GtkSingleSelectionExterns.gtk_single_selection_set_selected(self, position);
		return self;
	}

}

internal class GtkSingleSelectionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSingleSelectionHandle gtk_single_selection_new(GListModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_single_selection_get_autoselect(GtkSingleSelectionHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_single_selection_get_can_unselect(GtkSingleSelectionHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_single_selection_get_model(GtkSingleSelectionHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_single_selection_get_selected(GtkSingleSelectionHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GObjectHandle gtk_single_selection_get_selected_item(GtkSingleSelectionHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_single_selection_set_autoselect(GtkSingleSelectionHandle self, bool autoselect);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_single_selection_set_can_unselect(GtkSingleSelectionHandle self, bool can_unselect);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_single_selection_set_model(GtkSingleSelectionHandle self, GListModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_single_selection_set_selected(GtkSingleSelectionHandle self, uint position);

}
