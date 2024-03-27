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

public class GtkDropTargetHandle : GtkEventControllerHandle
{
	public static GtkDropTargetHandle New(GType type, GdkDragAction actions)
	{
		return GtkDropTargetExterns.gtk_drop_target_new(type, actions);
	}
}

public class GtkDropTargetSignal
{
	public string Value { get; set; }
	public GtkDropTargetSignal(string value) => Value = value;
}

public static class GtkDropTargetSignals
{
	public static GtkDropTargetSignal Accept = new("accept");
	public static GtkDropTargetSignal Drop = new("drop");
	public static GtkDropTargetSignal Enter = new("enter");
	public static GtkDropTargetSignal Leave = new("leave");
	public static GtkDropTargetSignal Motion = new("motion");
}

public static class GtkDropTargetHandleExtensions
{
	public static GdkDragAction GetActions(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_actions(self);
	}

	public static GdkDropHandle GetCurrentDrop(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_current_drop(self);
	}

	public static GdkDropHandle GetDrop(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_drop(self);
	}

	public static GdkContentFormatsHandle GetFormats(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_formats(self);
	}

	public static GType[] GetGtypes(this GtkDropTargetHandle self, out int n_types)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_gtypes(self, out n_types);
	}

	public static bool GetPreload(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_preload(self);
	}

	public static GValueHandle GetValue(this GtkDropTargetHandle self)
	{
		return GtkDropTargetExterns.gtk_drop_target_get_value(self);
	}

	public static GtkDropTargetHandle Reject(this GtkDropTargetHandle self)
	{
		GtkDropTargetExterns.gtk_drop_target_reject(self);
		return self;
	}

	public static GtkDropTargetHandle SetActions(this GtkDropTargetHandle self, GdkDragAction actions)
	{
		GtkDropTargetExterns.gtk_drop_target_set_actions(self, actions);
		return self;
	}

	public static GtkDropTargetHandle SetGtypes(this GtkDropTargetHandle self, GType[] types, int n_types)
	{
		GtkDropTargetExterns.gtk_drop_target_set_gtypes(self, types, n_types);
		return self;
	}

	public static GtkDropTargetHandle SetPreload(this GtkDropTargetHandle self, bool preload)
	{
		GtkDropTargetExterns.gtk_drop_target_set_preload(self, preload);
		return self;
	}

	public static GtkDropTargetHandle Connect(this GtkDropTargetHandle instance, GtkDropTargetSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkDropTargetExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDragAction gtk_drop_target_get_actions(GtkDropTargetHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDropHandle gtk_drop_target_get_current_drop(GtkDropTargetHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDropHandle gtk_drop_target_get_drop(GtkDropTargetHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkContentFormatsHandle gtk_drop_target_get_formats(GtkDropTargetHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GType[] gtk_drop_target_get_gtypes(GtkDropTargetHandle self, out int n_types);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_drop_target_get_preload(GtkDropTargetHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GValueHandle gtk_drop_target_get_value(GtkDropTargetHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_target_reject(GtkDropTargetHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_target_set_actions(GtkDropTargetHandle self, GdkDragAction actions);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_target_set_gtypes(GtkDropTargetHandle self, GType[] types, int n_types);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_drop_target_set_preload(GtkDropTargetHandle self, bool preload);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkDropTargetHandle gtk_drop_target_new(GType type, GdkDragAction actions);
}
