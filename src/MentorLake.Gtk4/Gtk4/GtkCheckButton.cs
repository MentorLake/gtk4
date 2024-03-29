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

public class GtkCheckButtonHandle : GtkWidgetHandle
{
	public static GtkCheckButtonHandle New()
	{
		return GtkCheckButtonExterns.gtk_check_button_new();
	}

	public static GtkCheckButtonHandle NewWithLabel(string label)
	{
		return GtkCheckButtonExterns.gtk_check_button_new_with_label(label);
	}

	public static GtkCheckButtonHandle NewWithMnemonic(string label)
	{
		return GtkCheckButtonExterns.gtk_check_button_new_with_mnemonic(label);
	}

}

public class GtkCheckButtonSignal
{
	public string Value { get; set; }
	public GtkCheckButtonSignal(string value) => Value = value;
}

public static class GtkCheckButtonSignals
{
	public static GtkCheckButtonSignal Activate = new("activate");
	public static GtkCheckButtonSignal Toggled = new("toggled");
}

public static class GtkCheckButtonHandleExtensions
{
	public static bool GetActive(this GtkCheckButtonHandle self)
	{
		return GtkCheckButtonExterns.gtk_check_button_get_active(self);
	}

	public static GtkWidgetHandle GetChild(this GtkCheckButtonHandle button)
	{
		return GtkCheckButtonExterns.gtk_check_button_get_child(button);
	}

	public static bool GetInconsistent(this GtkCheckButtonHandle check_button)
	{
		return GtkCheckButtonExterns.gtk_check_button_get_inconsistent(check_button);
	}

	public static string GetLabel(this GtkCheckButtonHandle self)
	{
		return GtkCheckButtonExterns.gtk_check_button_get_label(self);
	}

	public static bool GetUseUnderline(this GtkCheckButtonHandle self)
	{
		return GtkCheckButtonExterns.gtk_check_button_get_use_underline(self);
	}

	public static GtkCheckButtonHandle SetActive(this GtkCheckButtonHandle self, bool setting)
	{
		GtkCheckButtonExterns.gtk_check_button_set_active(self, setting);
		return self;
	}

	public static GtkCheckButtonHandle SetChild(this GtkCheckButtonHandle button, GtkWidgetHandle child)
	{
		GtkCheckButtonExterns.gtk_check_button_set_child(button, child);
		return button;
	}

	public static GtkCheckButtonHandle SetGroup(this GtkCheckButtonHandle self, GtkCheckButtonHandle group)
	{
		GtkCheckButtonExterns.gtk_check_button_set_group(self, group);
		return self;
	}

	public static GtkCheckButtonHandle SetInconsistent(this GtkCheckButtonHandle check_button, bool inconsistent)
	{
		GtkCheckButtonExterns.gtk_check_button_set_inconsistent(check_button, inconsistent);
		return check_button;
	}

	public static GtkCheckButtonHandle SetLabel(this GtkCheckButtonHandle self, string label)
	{
		GtkCheckButtonExterns.gtk_check_button_set_label(self, label);
		return self;
	}

	public static GtkCheckButtonHandle SetUseUnderline(this GtkCheckButtonHandle self, bool setting)
	{
		GtkCheckButtonExterns.gtk_check_button_set_use_underline(self, setting);
		return self;
	}

	public static GtkCheckButtonHandle Connect(this GtkCheckButtonHandle instance, GtkCheckButtonSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkCheckButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCheckButtonHandle gtk_check_button_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCheckButtonHandle gtk_check_button_new_with_label(string label);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCheckButtonHandle gtk_check_button_new_with_mnemonic(string label);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_check_button_get_active(GtkCheckButtonHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_check_button_get_child(GtkCheckButtonHandle button);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_check_button_get_inconsistent(GtkCheckButtonHandle check_button);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_check_button_get_label(GtkCheckButtonHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_check_button_get_use_underline(GtkCheckButtonHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_check_button_set_active(GtkCheckButtonHandle self, bool setting);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_check_button_set_child(GtkCheckButtonHandle button, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_check_button_set_group(GtkCheckButtonHandle self, GtkCheckButtonHandle group);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_check_button_set_inconsistent(GtkCheckButtonHandle check_button, bool inconsistent);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_check_button_set_label(GtkCheckButtonHandle self, string label);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_check_button_set_use_underline(GtkCheckButtonHandle self, bool setting);
}
