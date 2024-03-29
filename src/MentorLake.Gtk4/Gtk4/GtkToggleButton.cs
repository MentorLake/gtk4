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

public class GtkToggleButtonHandle : GtkButtonHandle
{
	public static GtkToggleButtonHandle New()
	{
		return GtkToggleButtonExterns.gtk_toggle_button_new();
	}

	public static GtkToggleButtonHandle NewWithLabel(string label)
	{
		return GtkToggleButtonExterns.gtk_toggle_button_new_with_label(label);
	}

	public static GtkToggleButtonHandle NewWithMnemonic(string label)
	{
		return GtkToggleButtonExterns.gtk_toggle_button_new_with_mnemonic(label);
	}

}

public class GtkToggleButtonSignal
{
	public string Value { get; set; }
	public GtkToggleButtonSignal(string value) => Value = value;
}

public static class GtkToggleButtonSignals
{
	public static GtkToggleButtonSignal Toggled = new("toggled");
}

public static class GtkToggleButtonHandleExtensions
{
	public static bool GetActive(this GtkToggleButtonHandle toggle_button)
	{
		return GtkToggleButtonExterns.gtk_toggle_button_get_active(toggle_button);
	}

	public static GtkToggleButtonHandle SetActive(this GtkToggleButtonHandle toggle_button, bool is_active)
	{
		GtkToggleButtonExterns.gtk_toggle_button_set_active(toggle_button, is_active);
		return toggle_button;
	}

	public static GtkToggleButtonHandle SetGroup(this GtkToggleButtonHandle toggle_button, GtkToggleButtonHandle group)
	{
		GtkToggleButtonExterns.gtk_toggle_button_set_group(toggle_button, group);
		return toggle_button;
	}

	public static GtkToggleButtonHandle Toggled(this GtkToggleButtonHandle toggle_button)
	{
		GtkToggleButtonExterns.gtk_toggle_button_toggled(toggle_button);
		return toggle_button;
	}

	public static GtkToggleButtonHandle Connect(this GtkToggleButtonHandle instance, GtkToggleButtonSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkToggleButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkToggleButtonHandle gtk_toggle_button_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkToggleButtonHandle gtk_toggle_button_new_with_label(string label);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkToggleButtonHandle gtk_toggle_button_new_with_mnemonic(string label);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_toggle_button_get_active(GtkToggleButtonHandle toggle_button);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_toggle_button_set_active(GtkToggleButtonHandle toggle_button, bool is_active);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_toggle_button_set_group(GtkToggleButtonHandle toggle_button, GtkToggleButtonHandle group);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_toggle_button_toggled(GtkToggleButtonHandle toggle_button);
}
