using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;

public static class GdkDeviceToolExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_tool_get_serial")]
	internal static extern nuint gdk_device_tool_get_serial(this GdkDeviceToolHandle tool);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_tool_get_hardware_id")]
	internal static extern nuint gdk_device_tool_get_hardware_id(this GdkDeviceToolHandle tool);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_tool_get_tool_type")]
	internal static extern GdkDeviceToolType gdk_device_tool_get_tool_type(this GdkDeviceToolHandle tool);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_tool_get_axes")]
	internal static extern GdkAxisFlags gdk_device_tool_get_axes(this GdkDeviceToolHandle tool);
}
