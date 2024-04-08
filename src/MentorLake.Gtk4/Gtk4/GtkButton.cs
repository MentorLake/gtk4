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

public class GtkButtonHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkActionableHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkButtonHandle New()
	{
		return GtkButtonExterns.gtk_button_new();
	}

	public static GtkButtonHandle NewFromIconName(string icon_name)
	{
		return GtkButtonExterns.gtk_button_new_from_icon_name(icon_name);
	}

	public static GtkButtonHandle NewWithLabel(string label)
	{
		return GtkButtonExterns.gtk_button_new_with_label(label);
	}

	public static GtkButtonHandle NewWithMnemonic(string label)
	{
		return GtkButtonExterns.gtk_button_new_with_mnemonic(label);
	}

}

public class GtkButtonSignal
{
	public string Value { get; set; }
	public GtkButtonSignal(string value) => Value = value;
}

public static class GtkButtonSignals
{
	public static GtkButtonSignal Activate = new("activate");
	public static GtkButtonSignal Clicked = new("clicked");
}

public static class GtkButtonHandleExtensions
{
	public static bool GetCanShrink(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_can_shrink(button);
	}

	public static GtkWidgetHandle GetChild(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_child(button);
	}

	public static bool GetHasFrame(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_has_frame(button);
	}

	public static string GetIconName(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_icon_name(button);
	}

	public static string GetLabel(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_label(button);
	}

	public static bool GetUseUnderline(this GtkButtonHandle button)
	{
		return GtkButtonExterns.gtk_button_get_use_underline(button);
	}

	public static GtkButtonHandle SetCanShrink(this GtkButtonHandle button, bool can_shrink)
	{
		GtkButtonExterns.gtk_button_set_can_shrink(button, can_shrink);
		return button;
	}

	public static GtkButtonHandle SetChild(this GtkButtonHandle button, GtkWidgetHandle child)
	{
		GtkButtonExterns.gtk_button_set_child(button, child);
		return button;
	}

	public static GtkButtonHandle SetHasFrame(this GtkButtonHandle button, bool has_frame)
	{
		GtkButtonExterns.gtk_button_set_has_frame(button, has_frame);
		return button;
	}

	public static GtkButtonHandle SetIconName(this GtkButtonHandle button, string icon_name)
	{
		GtkButtonExterns.gtk_button_set_icon_name(button, icon_name);
		return button;
	}

	public static GtkButtonHandle SetLabel(this GtkButtonHandle button, string label)
	{
		GtkButtonExterns.gtk_button_set_label(button, label);
		return button;
	}

	public static GtkButtonHandle SetUseUnderline(this GtkButtonHandle button, bool use_underline)
	{
		GtkButtonExterns.gtk_button_set_use_underline(button, use_underline);
		return button;
	}

	public static GtkButtonHandle Connect(this GtkButtonHandle instance, GtkButtonSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkButtonHandle gtk_button_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkButtonHandle gtk_button_new_from_icon_name(string icon_name);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkButtonHandle gtk_button_new_with_label(string label);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkButtonHandle gtk_button_new_with_mnemonic(string label);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_button_get_can_shrink(GtkButtonHandle button);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_button_get_child(GtkButtonHandle button);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_button_get_has_frame(GtkButtonHandle button);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_button_get_icon_name(GtkButtonHandle button);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_button_get_label(GtkButtonHandle button);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_button_get_use_underline(GtkButtonHandle button);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_button_set_can_shrink(GtkButtonHandle button, bool can_shrink);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_button_set_child(GtkButtonHandle button, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_button_set_has_frame(GtkButtonHandle button, bool has_frame);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_button_set_icon_name(GtkButtonHandle button, string icon_name);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_button_set_label(GtkButtonHandle button, string label);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_button_set_use_underline(GtkButtonHandle button, bool use_underline);
}
