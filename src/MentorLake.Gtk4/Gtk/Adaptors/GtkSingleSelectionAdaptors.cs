using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSingleSelectionAdaptors
{
	public static GListModelHandle GetModel(this GtkSingleSelectionHandle self)
	{
		return GtkSingleSelectionExterns.gtk_single_selection_get_model(self);
	}

	public static GtkSingleSelectionHandle SetModel(this GtkSingleSelectionHandle self, GListModelHandle model)
	{
		GtkSingleSelectionExterns.gtk_single_selection_set_model(self, model);
		return self;
	}

	public static uint GetSelected(this GtkSingleSelectionHandle self)
	{
		return GtkSingleSelectionExterns.gtk_single_selection_get_selected(self);
	}

	public static GtkSingleSelectionHandle SetSelected(this GtkSingleSelectionHandle self, uint position)
	{
		GtkSingleSelectionExterns.gtk_single_selection_set_selected(self, position);
		return self;
	}

	public static IntPtr GetSelectedItem(this GtkSingleSelectionHandle self)
	{
		return GtkSingleSelectionExterns.gtk_single_selection_get_selected_item(self);
	}

	public static int GetAutoselect(this GtkSingleSelectionHandle self)
	{
		return GtkSingleSelectionExterns.gtk_single_selection_get_autoselect(self);
	}

	public static GtkSingleSelectionHandle SetAutoselect(this GtkSingleSelectionHandle self, int autoselect)
	{
		GtkSingleSelectionExterns.gtk_single_selection_set_autoselect(self, autoselect);
		return self;
	}

	public static int GetCanUnselect(this GtkSingleSelectionHandle self)
	{
		return GtkSingleSelectionExterns.gtk_single_selection_get_can_unselect(self);
	}

	public static GtkSingleSelectionHandle SetCanUnselect(this GtkSingleSelectionHandle self, int can_unselect)
	{
		GtkSingleSelectionExterns.gtk_single_selection_set_can_unselect(self, can_unselect);
		return self;
	}
}
