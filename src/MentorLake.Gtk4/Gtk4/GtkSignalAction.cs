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

public class GtkSignalActionHandle : GtkShortcutActionHandle
{
	public static GtkSignalActionHandle New(string signal_name)
	{
		return GtkSignalActionExterns.gtk_signal_action_new(signal_name);
	}
}

public static class GtkSignalActionSignals
{
}

public static class GtkSignalActionHandleExtensions
{
	public static string GetSignalName(this GtkSignalActionHandle self)
	{
		return GtkSignalActionExterns.gtk_signal_action_get_signal_name(self);
	}

}

internal class GtkSignalActionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_signal_action_get_signal_name(GtkSignalActionHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSignalActionHandle gtk_signal_action_new(string signal_name);
}
