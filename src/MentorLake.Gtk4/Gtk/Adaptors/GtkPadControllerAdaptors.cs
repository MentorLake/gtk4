using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPadControllerAdaptors
{
	public static GtkPadControllerHandle SetActionEntries(this GtkPadControllerHandle controller, GtkPadActionEntryHandle entries, int n_entries)
	{
		GtkPadControllerExterns.gtk_pad_controller_set_action_entries(controller, entries, n_entries);
		return controller;
	}

	public static GtkPadControllerHandle SetAction(this GtkPadControllerHandle controller, GtkPadActionType type, int index, int mode, string label, string action_name)
	{
		GtkPadControllerExterns.gtk_pad_controller_set_action(controller, type, index, mode, label, action_name);
		return controller;
	}
}
