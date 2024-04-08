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

public class GtkShortcutsSectionHandle : GtkBoxHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
}

public class GtkShortcutsSectionSignal
{
	public string Value { get; set; }
	public GtkShortcutsSectionSignal(string value) => Value = value;
}

public static class GtkShortcutsSectionSignals
{
	public static GtkShortcutsSectionSignal ChangeCurrentPage = new("change-current-page");
}

public static class GtkShortcutsSectionHandleExtensions
{
	public static GtkShortcutsSectionHandle AddGroup(this GtkShortcutsSectionHandle self, GtkShortcutsGroupHandle group)
	{
		GtkShortcutsSectionExterns.gtk_shortcuts_section_add_group(self, group);
		return self;
	}

	public static GtkShortcutsSectionHandle Connect(this GtkShortcutsSectionHandle instance, GtkShortcutsSectionSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkShortcutsSectionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcuts_section_add_group(GtkShortcutsSectionHandle self, GtkShortcutsGroupHandle group);
}
