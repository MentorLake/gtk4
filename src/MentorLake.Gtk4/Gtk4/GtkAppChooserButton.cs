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

public class GtkAppChooserButtonHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkAppChooserHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkAppChooserButtonHandle New(string content_type)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_new(content_type);
	}

}

public class GtkAppChooserButtonSignal
{
	public string Value { get; set; }
	public GtkAppChooserButtonSignal(string value) => Value = value;
}

public static class GtkAppChooserButtonSignals
{
	public static GtkAppChooserButtonSignal Activate = new("activate");
	public static GtkAppChooserButtonSignal Changed = new("changed");
	public static GtkAppChooserButtonSignal CustomItemActivated = new("custom-item-activated");
}

public static class GtkAppChooserButtonHandleExtensions
{
	public static GtkAppChooserButtonHandle AppendCustomItem(this GtkAppChooserButtonHandle self, string name, string label, GIconHandle icon)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_append_custom_item(self, name, label, icon);
		return self;
	}

	public static GtkAppChooserButtonHandle AppendSeparator(this GtkAppChooserButtonHandle self)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_append_separator(self);
		return self;
	}

	public static string GetHeading(this GtkAppChooserButtonHandle self)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_get_heading(self);
	}

	public static bool GetModal(this GtkAppChooserButtonHandle self)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_get_modal(self);
	}

	public static bool GetShowDefaultItem(this GtkAppChooserButtonHandle self)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_get_show_default_item(self);
	}

	public static bool GetShowDialogItem(this GtkAppChooserButtonHandle self)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_get_show_dialog_item(self);
	}

	public static GtkAppChooserButtonHandle SetActiveCustomItem(this GtkAppChooserButtonHandle self, string name)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_active_custom_item(self, name);
		return self;
	}

	public static GtkAppChooserButtonHandle SetHeading(this GtkAppChooserButtonHandle self, string heading)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_heading(self, heading);
		return self;
	}

	public static GtkAppChooserButtonHandle SetModal(this GtkAppChooserButtonHandle self, bool modal)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_modal(self, modal);
		return self;
	}

	public static GtkAppChooserButtonHandle SetShowDefaultItem(this GtkAppChooserButtonHandle self, bool setting)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_show_default_item(self, setting);
		return self;
	}

	public static GtkAppChooserButtonHandle SetShowDialogItem(this GtkAppChooserButtonHandle self, bool setting)
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_show_dialog_item(self, setting);
		return self;
	}

	public static GtkAppChooserButtonHandle Connect(this GtkAppChooserButtonHandle instance, GtkAppChooserButtonSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkAppChooserButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAppChooserButtonHandle gtk_app_chooser_button_new(string content_type);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_button_append_custom_item(GtkAppChooserButtonHandle self, string name, string label, GIconHandle icon);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_button_append_separator(GtkAppChooserButtonHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_app_chooser_button_get_heading(GtkAppChooserButtonHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_app_chooser_button_get_modal(GtkAppChooserButtonHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_app_chooser_button_get_show_default_item(GtkAppChooserButtonHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_app_chooser_button_get_show_dialog_item(GtkAppChooserButtonHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_button_set_active_custom_item(GtkAppChooserButtonHandle self, string name);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_button_set_heading(GtkAppChooserButtonHandle self, string heading);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_button_set_modal(GtkAppChooserButtonHandle self, bool modal);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_button_set_show_default_item(GtkAppChooserButtonHandle self, bool setting);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_app_chooser_button_set_show_dialog_item(GtkAppChooserButtonHandle self, bool setting);
}
