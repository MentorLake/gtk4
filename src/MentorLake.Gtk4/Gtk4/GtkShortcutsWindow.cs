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

public class GtkShortcutsWindowHandle : GtkWindowHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkNativeHandle, GtkRootHandle, GtkShortcutManagerHandle
{
}

public class GtkShortcutsWindowSignal
{
	public string Value { get; set; }
	public GtkShortcutsWindowSignal(string value) => Value = value;
}

public static class GtkShortcutsWindowSignals
{
	public static GtkShortcutsWindowSignal Close = new("close");
	public static GtkShortcutsWindowSignal Search = new("search");
}

public static class GtkShortcutsWindowHandleExtensions
{
	public static GtkShortcutsWindowHandle AddSection(this GtkShortcutsWindowHandle self, GtkShortcutsSectionHandle section)
	{
		GtkShortcutsWindowExterns.gtk_shortcuts_window_add_section(self, section);
		return self;
	}

	public static GtkShortcutsWindowHandle Connect(this GtkShortcutsWindowHandle instance, GtkShortcutsWindowSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkShortcutsWindowExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_shortcuts_window_add_section(GtkShortcutsWindowHandle self, GtkShortcutsSectionHandle section);
}
