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
	public static GdkSeatSignal DeviceAdded = new("BindingTransform.MethodDeclaration");
	public static GdkSeatSignal DeviceRemoved = new("BindingTransform.MethodDeclaration");
	public static GdkSeatSignal ToolAdded = new("BindingTransform.MethodDeclaration");
	public static GdkSeatSignal ToolRemoved = new("BindingTransform.MethodDeclaration");
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

	public static GdkSeatHandle Signal_DeviceAdded(this GdkSeatHandle instance, GdkSeatDelegates.DeviceAdded handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "device_added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GdkSeatHandle Signal_DeviceRemoved(this GdkSeatHandle instance, GdkSeatDelegates.DeviceRemoved handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "device_removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GdkSeatHandle Signal_ToolAdded(this GdkSeatHandle instance, GdkSeatDelegates.ToolAdded handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "tool_added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GdkSeatHandle Signal_ToolRemoved(this GdkSeatHandle instance, GdkSeatDelegates.ToolRemoved handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "tool_removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GdkSeatDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DeviceAdded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSeatHandle>))] GdkSeatHandle self, GdkDeviceHandle device, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DeviceRemoved([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSeatHandle>))] GdkSeatHandle self, GdkDeviceHandle device, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ToolAdded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSeatHandle>))] GdkSeatHandle self, GdkDeviceToolHandle tool, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ToolRemoved([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSeatHandle>))] GdkSeatHandle self, GdkDeviceToolHandle tool, IntPtr user_data);
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
