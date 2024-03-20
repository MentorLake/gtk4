using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkMultiSelectionAdaptors
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
