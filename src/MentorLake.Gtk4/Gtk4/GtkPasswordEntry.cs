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

public class GtkPasswordEntryHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkEditableHandle
{
	public static GtkPasswordEntryHandle New()
	{
		return GtkPasswordEntryExterns.gtk_password_entry_new();
	}

}

public class GtkPasswordEntrySignal
{
	public string Value { get; set; }
	public GtkPasswordEntrySignal(string value) => Value = value;
}

public static class GtkPasswordEntrySignals
{
	public static GtkPasswordEntrySignal Activate = new("activate");
}

public static class GtkPasswordEntryHandleExtensions
{
	public static GMenuModelHandle GetExtraMenu(this GtkPasswordEntryHandle entry)
	{
		return GtkPasswordEntryExterns.gtk_password_entry_get_extra_menu(entry);
	}

	public static bool GetShowPeekIcon(this GtkPasswordEntryHandle entry)
	{
		return GtkPasswordEntryExterns.gtk_password_entry_get_show_peek_icon(entry);
	}

	public static GtkPasswordEntryHandle SetExtraMenu(this GtkPasswordEntryHandle entry, GMenuModelHandle model)
	{
		GtkPasswordEntryExterns.gtk_password_entry_set_extra_menu(entry, model);
		return entry;
	}

	public static GtkPasswordEntryHandle SetShowPeekIcon(this GtkPasswordEntryHandle entry, bool show_peek_icon)
	{
		GtkPasswordEntryExterns.gtk_password_entry_set_show_peek_icon(entry, show_peek_icon);
		return entry;
	}

	public static GtkPasswordEntryHandle Connect(this GtkPasswordEntryHandle instance, GtkPasswordEntrySignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkPasswordEntryExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPasswordEntryHandle gtk_password_entry_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern GMenuModelHandle gtk_password_entry_get_extra_menu(GtkPasswordEntryHandle entry);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_password_entry_get_show_peek_icon(GtkPasswordEntryHandle entry);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_password_entry_set_extra_menu(GtkPasswordEntryHandle entry, GMenuModelHandle model);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_password_entry_set_show_peek_icon(GtkPasswordEntryHandle entry, bool show_peek_icon);
}
