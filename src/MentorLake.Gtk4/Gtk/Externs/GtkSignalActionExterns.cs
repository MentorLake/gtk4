using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkSignalActionExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_signal_action_get_signal_name")]
	internal static extern string gtk_signal_action_get_signal_name(this GtkSignalActionHandle self);
}
