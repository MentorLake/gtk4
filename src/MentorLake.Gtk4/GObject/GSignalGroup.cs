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

namespace MentorLake.Gtk4.GObject;

public class GSignalGroupHandle : GObjectHandle
{
	public static GSignalGroupHandle New(GType target_type)
	{
		return GSignalGroupExterns.g_signal_group_new(target_type);
	}
}

public class GSignalGroupSignal
{
	public string Value { get; set; }
	public GSignalGroupSignal(string value) => Value = value;
}

public static class GSignalGroupSignals
{
	public static GSignalGroupSignal Bind = new("bind");
	public static GSignalGroupSignal Unbind = new("unbind");
}

public static class GSignalGroupHandleExtensions
{
	public static GSignalGroupHandle Block(this GSignalGroupHandle self)
	{
		GSignalGroupExterns.g_signal_group_block(self);
		return self;
	}

	public static GSignalGroupHandle Connect(this GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr data)
	{
		GSignalGroupExterns.g_signal_group_connect(self, detailed_signal, c_handler, data);
		return self;
	}

	public static GSignalGroupHandle ConnectAfter(this GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr data)
	{
		GSignalGroupExterns.g_signal_group_connect_after(self, detailed_signal, c_handler, data);
		return self;
	}

	public static GSignalGroupHandle ConnectClosure(this GSignalGroupHandle self, string detailed_signal, GClosureHandle closure, bool after)
	{
		GSignalGroupExterns.g_signal_group_connect_closure(self, detailed_signal, closure, after);
		return self;
	}

	public static GSignalGroupHandle ConnectData(this GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr data, GClosureNotify notify, GConnectFlags flags)
	{
		GSignalGroupExterns.g_signal_group_connect_data(self, detailed_signal, c_handler, data, notify, flags);
		return self;
	}

	public static GSignalGroupHandle ConnectObject(this GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr @object, GConnectFlags flags)
	{
		GSignalGroupExterns.g_signal_group_connect_object(self, detailed_signal, c_handler, @object, flags);
		return self;
	}

	public static GSignalGroupHandle ConnectSwapped(this GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr data)
	{
		GSignalGroupExterns.g_signal_group_connect_swapped(self, detailed_signal, c_handler, data);
		return self;
	}

	public static GObjectHandle DupTarget(this GSignalGroupHandle self)
	{
		return GSignalGroupExterns.g_signal_group_dup_target(self);
	}

	public static GSignalGroupHandle SetTarget(this GSignalGroupHandle self, GObjectHandle target)
	{
		GSignalGroupExterns.g_signal_group_set_target(self, target);
		return self;
	}

	public static GSignalGroupHandle Unblock(this GSignalGroupHandle self)
	{
		GSignalGroupExterns.g_signal_group_unblock(self);
		return self;
	}

	public static GSignalGroupHandle Connect(this GSignalGroupHandle instance, GSignalGroupSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GSignalGroupExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_block(GSignalGroupHandle self);
	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect(GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr data);
	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect_after(GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr data);
	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect_closure(GSignalGroupHandle self, string detailed_signal, GClosureHandle closure, bool after);
	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect_data(GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr data, GClosureNotify notify, GConnectFlags flags);
	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect_object(GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr @object, GConnectFlags flags);
	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_connect_swapped(GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr data);
	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_signal_group_dup_target(GSignalGroupHandle self);
	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_set_target(GSignalGroupHandle self, GObjectHandle target);
	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_group_unblock(GSignalGroupHandle self);
	[DllImport(Libraries.GObject)]
	internal static extern GSignalGroupHandle g_signal_group_new(GType target_type);
}
