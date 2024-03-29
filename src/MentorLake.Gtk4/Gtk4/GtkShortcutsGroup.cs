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

public class GtkShortcutsGroupHandle : GtkBoxHandle
{
}

public static class GtkShortcutsGroupHandleExtensions
{
	public static GtkShortcutsGroupHandle AddShortcut(this GtkShortcutsGroupHandle self, GtkShortcutsShortcutHandle shortcut)
	{
		GtkShortcutsGroupExterns.gtk_shortcuts_group_add_shortcut(self, shortcut);
		return self;
	}

}

internal class GtkShortcutsGroupExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcuts_group_add_shortcut(GtkShortcutsGroupHandle self, GtkShortcutsShortcutHandle shortcut);
}
