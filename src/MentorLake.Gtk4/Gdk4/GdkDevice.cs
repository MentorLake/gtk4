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

public class GdkDeviceHandle : GObjectHandle
{
}

public class GdkDeviceSignal
{
	public string Value { get; set; }
	public GdkDeviceSignal(string value) => Value = value;
}

public static class GdkDeviceSignals
{
	public static GdkDeviceSignal Changed = new("changed");
	public static GdkDeviceSignal ToolChanged = new("tool-changed");
}

public static class GdkDeviceHandleExtensions
{
	public static bool GetCapsLockState(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_caps_lock_state(device);
	}

	public static GdkDeviceToolHandle GetDeviceTool(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_device_tool(device);
	}

	public static PangoDirection GetDirection(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_direction(device);
	}

	public static GdkDisplayHandle GetDisplay(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_display(device);
	}

	public static bool GetHasCursor(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_has_cursor(device);
	}

	public static GdkModifierType GetModifierState(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_modifier_state(device);
	}

	public static string GetName(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_name(device);
	}

	public static bool GetNumLockState(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_num_lock_state(device);
	}

	public static uint GetNumTouches(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_num_touches(device);
	}

	public static string GetProductId(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_product_id(device);
	}

	public static bool GetScrollLockState(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_scroll_lock_state(device);
	}

	public static GdkSeatHandle GetSeat(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_seat(device);
	}

	public static GdkInputSource GetSource(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_source(device);
	}

	public static GdkSurfaceHandle GetSurfaceAtPosition(this GdkDeviceHandle device, out double win_x, out double win_y)
	{
		return GdkDeviceExterns.gdk_device_get_surface_at_position(device, out win_x, out win_y);
	}

	public static uint GetTimestamp(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_timestamp(device);
	}

	public static string GetVendorId(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_get_vendor_id(device);
	}

	public static bool HasBidiLayouts(this GdkDeviceHandle device)
	{
		return GdkDeviceExterns.gdk_device_has_bidi_layouts(device);
	}

	public static GdkDeviceHandle Connect(this GdkDeviceHandle instance, GdkDeviceSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GdkDeviceExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_device_get_caps_lock_state(GdkDeviceHandle device);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDeviceToolHandle gdk_device_get_device_tool(GdkDeviceHandle device);
	[DllImport(Libraries.Gdk4)]
	internal static extern PangoDirection gdk_device_get_direction(GdkDeviceHandle device);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_device_get_display(GdkDeviceHandle device);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_device_get_has_cursor(GdkDeviceHandle device);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkModifierType gdk_device_get_modifier_state(GdkDeviceHandle device);
	[DllImport(Libraries.Gdk4)]
	internal static extern string gdk_device_get_name(GdkDeviceHandle device);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_device_get_num_lock_state(GdkDeviceHandle device);
	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_device_get_num_touches(GdkDeviceHandle device);
	[DllImport(Libraries.Gdk4)]
	internal static extern string gdk_device_get_product_id(GdkDeviceHandle device);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_device_get_scroll_lock_state(GdkDeviceHandle device);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSeatHandle gdk_device_get_seat(GdkDeviceHandle device);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkInputSource gdk_device_get_source(GdkDeviceHandle device);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSurfaceHandle gdk_device_get_surface_at_position(GdkDeviceHandle device, out double win_x, out double win_y);
	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_device_get_timestamp(GdkDeviceHandle device);
	[DllImport(Libraries.Gdk4)]
	internal static extern string gdk_device_get_vendor_id(GdkDeviceHandle device);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_device_has_bidi_layouts(GdkDeviceHandle device);
}
