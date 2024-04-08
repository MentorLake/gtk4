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

public class GtkDialogHandle : GtkWindowHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkNativeHandle, GtkRootHandle, GtkShortcutManagerHandle
{
	public static GtkDialogHandle New()
	{
		return GtkDialogExterns.gtk_dialog_new();
	}

	public static GtkDialogHandle NewWithButtons(string title, GtkWindowHandle parent, GtkDialogFlags flags, string first_button_text, IntPtr @__arglist)
	{
		return GtkDialogExterns.gtk_dialog_new_with_buttons(title, parent, flags, first_button_text, @__arglist);
	}

}

public class GtkDialogSignal
{
	public string Value { get; set; }
	public GtkDialogSignal(string value) => Value = value;
}

public static class GtkDialogSignals
{
	public static GtkDialogSignal Close = new("close");
	public static GtkDialogSignal Response = new("response");
}

public static class GtkDialogHandleExtensions
{
	public static GtkDialogHandle AddActionWidget(this GtkDialogHandle dialog, GtkWidgetHandle child, int response_id)
	{
		GtkDialogExterns.gtk_dialog_add_action_widget(dialog, child, response_id);
		return dialog;
	}

	public static GtkWidgetHandle AddButton(this GtkDialogHandle dialog, string button_text, int response_id)
	{
		return GtkDialogExterns.gtk_dialog_add_button(dialog, button_text, response_id);
	}

	public static GtkDialogHandle AddButtons(this GtkDialogHandle dialog, string first_button_text, IntPtr @__arglist)
	{
		GtkDialogExterns.gtk_dialog_add_buttons(dialog, first_button_text, @__arglist);
		return dialog;
	}

	public static GtkWidgetHandle GetContentArea(this GtkDialogHandle dialog)
	{
		return GtkDialogExterns.gtk_dialog_get_content_area(dialog);
	}

	public static GtkWidgetHandle GetHeaderBar(this GtkDialogHandle dialog)
	{
		return GtkDialogExterns.gtk_dialog_get_header_bar(dialog);
	}

	public static int GetResponseForWidget(this GtkDialogHandle dialog, GtkWidgetHandle widget)
	{
		return GtkDialogExterns.gtk_dialog_get_response_for_widget(dialog, widget);
	}

	public static GtkWidgetHandle GetWidgetForResponse(this GtkDialogHandle dialog, int response_id)
	{
		return GtkDialogExterns.gtk_dialog_get_widget_for_response(dialog, response_id);
	}

	public static GtkDialogHandle Response(this GtkDialogHandle dialog, int response_id)
	{
		GtkDialogExterns.gtk_dialog_response(dialog, response_id);
		return dialog;
	}

	public static GtkDialogHandle SetDefaultResponse(this GtkDialogHandle dialog, int response_id)
	{
		GtkDialogExterns.gtk_dialog_set_default_response(dialog, response_id);
		return dialog;
	}

	public static GtkDialogHandle SetResponseSensitive(this GtkDialogHandle dialog, int response_id, bool setting)
	{
		GtkDialogExterns.gtk_dialog_set_response_sensitive(dialog, response_id, setting);
		return dialog;
	}

	public static GtkDialogHandle Connect(this GtkDialogHandle instance, GtkDialogSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkDialogExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkDialogHandle gtk_dialog_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkDialogHandle gtk_dialog_new_with_buttons(string title, GtkWindowHandle parent, GtkDialogFlags flags, string first_button_text, IntPtr @__arglist);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_dialog_add_action_widget(GtkDialogHandle dialog, GtkWidgetHandle child, int response_id);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_dialog_add_button(GtkDialogHandle dialog, string button_text, int response_id);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_dialog_add_buttons(GtkDialogHandle dialog, string first_button_text, IntPtr @__arglist);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_dialog_get_content_area(GtkDialogHandle dialog);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_dialog_get_header_bar(GtkDialogHandle dialog);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_dialog_get_response_for_widget(GtkDialogHandle dialog, GtkWidgetHandle widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_dialog_get_widget_for_response(GtkDialogHandle dialog, int response_id);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_dialog_response(GtkDialogHandle dialog, int response_id);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_dialog_set_default_response(GtkDialogHandle dialog, int response_id);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_dialog_set_response_sensitive(GtkDialogHandle dialog, int response_id, bool setting);
}
