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

public class GtkNeverTriggerHandle : GtkShortcutTriggerHandle
{
}

public static class GtkNeverTriggerSignals
{
}

public static class GtkNeverTriggerHandleExtensions
{
	public static GtkShortcutTriggerHandle Get()
	{
		return GtkNeverTriggerExterns.gtk_never_trigger_get();
	}

}

internal class GtkNeverTriggerExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkShortcutTriggerHandle gtk_never_trigger_get();
}
