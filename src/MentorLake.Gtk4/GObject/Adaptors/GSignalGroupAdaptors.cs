using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GSignalGroupAdaptors
{
	public static GSignalGroupHandle SetTarget(this GSignalGroupHandle self, IntPtr target)
	{
		GSignalGroupExterns.g_signal_group_set_target(self, target);
		return self;
	}

	public static IntPtr DupTarget(this GSignalGroupHandle self)
	{
		return GSignalGroupExterns.g_signal_group_dup_target(self);
	}

	public static GSignalGroupHandle Block(this GSignalGroupHandle self)
	{
		GSignalGroupExterns.g_signal_group_block(self);
		return self;
	}

	public static GSignalGroupHandle Unblock(this GSignalGroupHandle self)
	{
		GSignalGroupExterns.g_signal_group_unblock(self);
		return self;
	}

	public static GSignalGroupHandle ConnectObject(this GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr @object, GConnectFlags flags)
	{
		GSignalGroupExterns.g_signal_group_connect_object(self, detailed_signal, c_handler, @object, flags);
		return self;
	}

	public static GSignalGroupHandle ConnectData(this GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr data, GClosureNotify notify, GConnectFlags flags)
	{
		GSignalGroupExterns.g_signal_group_connect_data(self, detailed_signal, c_handler, data, notify, flags);
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

	public static GSignalGroupHandle ConnectSwapped(this GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr data)
	{
		GSignalGroupExterns.g_signal_group_connect_swapped(self, detailed_signal, c_handler, data);
		return self;
	}
}
