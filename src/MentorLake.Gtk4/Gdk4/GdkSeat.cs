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

namespace MentorLake.Gtk4.Gdk4;

public class GdkSeatHandle : GObjectHandle
{
}

public class GdkSeatSignal
{
	public string Value { get; set; }
	public GdkSeatSignal(string value) => Value = value;
}

public static class GdkSeatSignals
{
	public static GdkSeatSignal DeviceAdded = new("device-added");
	public static GdkSeatSignal DeviceRemoved = new("device-removed");
	public static GdkSeatSignal ToolAdded = new("tool-added");
	public static GdkSeatSignal ToolRemoved = new("tool-removed");
}

public static class GdkSeatHandleExtensions
{
	public static GdkSeatCapabilities GetCapabilities(this GdkSeatHandle seat)
	{
		return GdkSeatExterns.gdk_seat_get_capabilities(seat);
	}

	public static GListHandle GetDevices(this GdkSeatHandle seat, GdkSeatCapabilities capabilities)
	{
		return GdkSeatExterns.gdk_seat_get_devices(seat, capabilities);
	}

	public static GdkDisplayHandle GetDisplay(this GdkSeatHandle seat)
	{
		return GdkSeatExterns.gdk_seat_get_display(seat);
	}

	public static GdkDeviceHandle GetKeyboard(this GdkSeatHandle seat)
	{
		return GdkSeatExterns.gdk_seat_get_keyboard(seat);
	}

	public static GdkDeviceHandle GetPointer(this GdkSeatHandle seat)
	{
		return GdkSeatExterns.gdk_seat_get_pointer(seat);
	}

	public static GListHandle GetTools(this GdkSeatHandle seat)
	{
		return GdkSeatExterns.gdk_seat_get_tools(seat);
	}

	public static GdkSeatHandle Connect(this GdkSeatHandle instance, GdkSeatSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GdkSeatExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSeatCapabilities gdk_seat_get_capabilities(GdkSeatHandle seat);
	[DllImport(Libraries.Gdk4)]
	internal static extern GListHandle gdk_seat_get_devices(GdkSeatHandle seat, GdkSeatCapabilities capabilities);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_seat_get_display(GdkSeatHandle seat);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDeviceHandle gdk_seat_get_keyboard(GdkSeatHandle seat);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDeviceHandle gdk_seat_get_pointer(GdkSeatHandle seat);
	[DllImport(Libraries.Gdk4)]
	internal static extern GListHandle gdk_seat_get_tools(GdkSeatHandle seat);
}
