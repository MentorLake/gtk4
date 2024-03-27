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

public class GtkNamedActionHandle : GtkShortcutActionHandle
{
	public static GtkNamedActionHandle New(string name)
	{
		return GtkNamedActionExterns.gtk_named_action_new(name);
	}
}

public static class GtkNamedActionSignals
{
}

public static class GtkNamedActionHandleExtensions
{
	public static string GetActionName(this GtkNamedActionHandle self)
	{
		return GtkNamedActionExterns.gtk_named_action_get_action_name(self);
	}

}

internal class GtkNamedActionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_named_action_get_action_name(GtkNamedActionHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkNamedActionHandle gtk_named_action_new(string name);
}
