using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkNoSelectionAdaptors
{
	public static GListModelHandle GetModel(this GtkNoSelectionHandle self)
	{
		return GtkNoSelectionExterns.gtk_no_selection_get_model(self);
	}

	public static GtkNoSelectionHandle SetModel(this GtkNoSelectionHandle self, GListModelHandle model)
	{
		GtkNoSelectionExterns.gtk_no_selection_set_model(self, model);
		return self;
	}
}
