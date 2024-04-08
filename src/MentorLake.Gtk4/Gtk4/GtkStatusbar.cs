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

public class GtkStatusbarHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkStatusbarHandle New()
	{
		return GtkStatusbarExterns.gtk_statusbar_new();
	}

}

public class GtkStatusbarSignal
{
	public string Value { get; set; }
	public GtkStatusbarSignal(string value) => Value = value;
}

public static class GtkStatusbarSignals
{
	public static GtkStatusbarSignal TextPopped = new("text-popped");
	public static GtkStatusbarSignal TextPushed = new("text-pushed");
}

public static class GtkStatusbarHandleExtensions
{
	public static uint GetContextId(this GtkStatusbarHandle statusbar, string context_description)
	{
		return GtkStatusbarExterns.gtk_statusbar_get_context_id(statusbar, context_description);
	}

	public static GtkStatusbarHandle Pop(this GtkStatusbarHandle statusbar, uint context_id)
	{
		GtkStatusbarExterns.gtk_statusbar_pop(statusbar, context_id);
		return statusbar;
	}

	public static uint Push(this GtkStatusbarHandle statusbar, uint context_id, string text)
	{
		return GtkStatusbarExterns.gtk_statusbar_push(statusbar, context_id, text);
	}

	public static GtkStatusbarHandle Remove(this GtkStatusbarHandle statusbar, uint context_id, uint message_id)
	{
		GtkStatusbarExterns.gtk_statusbar_remove(statusbar, context_id, message_id);
		return statusbar;
	}

	public static GtkStatusbarHandle RemoveAll(this GtkStatusbarHandle statusbar, uint context_id)
	{
		GtkStatusbarExterns.gtk_statusbar_remove_all(statusbar, context_id);
		return statusbar;
	}

	public static GtkStatusbarHandle Connect(this GtkStatusbarHandle instance, GtkStatusbarSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkStatusbarExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStatusbarHandle gtk_statusbar_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_statusbar_get_context_id(GtkStatusbarHandle statusbar, string context_description);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_statusbar_pop(GtkStatusbarHandle statusbar, uint context_id);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_statusbar_push(GtkStatusbarHandle statusbar, uint context_id, string text);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_statusbar_remove(GtkStatusbarHandle statusbar, uint context_id, uint message_id);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_statusbar_remove_all(GtkStatusbarHandle statusbar, uint context_id);
}
