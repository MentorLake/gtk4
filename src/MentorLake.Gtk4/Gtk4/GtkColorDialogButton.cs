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

public class GtkColorDialogButtonHandle : GtkWidgetHandle
{
	public static GtkColorDialogButtonHandle New(GtkColorDialogHandle dialog)
	{
		return GtkColorDialogButtonExterns.gtk_color_dialog_button_new(dialog);
	}

}

public class GtkColorDialogButtonSignal
{
	public string Value { get; set; }
	public GtkColorDialogButtonSignal(string value) => Value = value;
}

public static class GtkColorDialogButtonSignals
{
	public static GtkColorDialogButtonSignal Activate = new("activate");
}

public static class GtkColorDialogButtonHandleExtensions
{
	public static GtkColorDialogHandle GetDialog(this GtkColorDialogButtonHandle self)
	{
		return GtkColorDialogButtonExterns.gtk_color_dialog_button_get_dialog(self);
	}

	public static GdkRGBAHandle GetRgba(this GtkColorDialogButtonHandle self)
	{
		return GtkColorDialogButtonExterns.gtk_color_dialog_button_get_rgba(self);
	}

	public static GtkColorDialogButtonHandle SetDialog(this GtkColorDialogButtonHandle self, GtkColorDialogHandle dialog)
	{
		GtkColorDialogButtonExterns.gtk_color_dialog_button_set_dialog(self, dialog);
		return self;
	}

	public static GtkColorDialogButtonHandle SetRgba(this GtkColorDialogButtonHandle self, GdkRGBAHandle color)
	{
		GtkColorDialogButtonExterns.gtk_color_dialog_button_set_rgba(self, color);
		return self;
	}

	public static GtkColorDialogButtonHandle Connect(this GtkColorDialogButtonHandle instance, GtkColorDialogButtonSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkColorDialogButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkColorDialogButtonHandle gtk_color_dialog_button_new(GtkColorDialogHandle dialog);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkColorDialogHandle gtk_color_dialog_button_get_dialog(GtkColorDialogButtonHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkRGBAHandle gtk_color_dialog_button_get_rgba(GtkColorDialogButtonHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_color_dialog_button_set_dialog(GtkColorDialogButtonHandle self, GtkColorDialogHandle dialog);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_color_dialog_button_set_rgba(GtkColorDialogButtonHandle self, GdkRGBAHandle color);
}
