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

public class GtkFileChooserWidgetHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkFileChooserHandle
{
	public static GtkFileChooserWidgetHandle New(GtkFileChooserAction action)
	{
		return GtkFileChooserWidgetExterns.gtk_file_chooser_widget_new(action);
	}

}

public class GtkFileChooserWidgetSignal
{
	public string Value { get; set; }
	public GtkFileChooserWidgetSignal(string value) => Value = value;
}

public static class GtkFileChooserWidgetSignals
{
	public static GtkFileChooserWidgetSignal DesktopFolder = new("desktop-folder");
	public static GtkFileChooserWidgetSignal DownFolder = new("down-folder");
	public static GtkFileChooserWidgetSignal HomeFolder = new("home-folder");
	public static GtkFileChooserWidgetSignal LocationPopup = new("location-popup");
	public static GtkFileChooserWidgetSignal LocationPopupOnPaste = new("location-popup-on-paste");
	public static GtkFileChooserWidgetSignal LocationTogglePopup = new("location-toggle-popup");
	public static GtkFileChooserWidgetSignal PlacesShortcut = new("places-shortcut");
	public static GtkFileChooserWidgetSignal QuickBookmark = new("quick-bookmark");
	public static GtkFileChooserWidgetSignal RecentShortcut = new("recent-shortcut");
	public static GtkFileChooserWidgetSignal SearchShortcut = new("search-shortcut");
	public static GtkFileChooserWidgetSignal ShowHidden = new("show-hidden");
	public static GtkFileChooserWidgetSignal UpFolder = new("up-folder");
}

public static class GtkFileChooserWidgetHandleExtensions
{
	public static GtkFileChooserWidgetHandle Connect(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkFileChooserWidgetExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFileChooserWidgetHandle gtk_file_chooser_widget_new(GtkFileChooserAction action);
}
