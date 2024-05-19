using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gdk4;

public class GdkDeviceToolHandle : GObjectHandle
{
}

public static class GdkDeviceToolHandleExtensions
{
	public static GdkAxisFlags GetAxes(this GdkDeviceToolHandle tool)
	{
		return GdkDeviceToolExterns.gdk_device_tool_get_axes(tool);
	}

	public static ulong GetHardwareId(this GdkDeviceToolHandle tool)
	{
		return GdkDeviceToolExterns.gdk_device_tool_get_hardware_id(tool);
	}

	public static ulong GetSerial(this GdkDeviceToolHandle tool)
	{
		return GdkDeviceToolExterns.gdk_device_tool_get_serial(tool);
	}

	public static GdkDeviceToolType GetToolType(this GdkDeviceToolHandle tool)
	{
		return GdkDeviceToolExterns.gdk_device_tool_get_tool_type(tool);
	}

}

internal class GdkDeviceToolExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkAxisFlags gdk_device_tool_get_axes(GdkDeviceToolHandle tool);

	[DllImport(Libraries.Gdk4)]
	internal static extern ulong gdk_device_tool_get_hardware_id(GdkDeviceToolHandle tool);

	[DllImport(Libraries.Gdk4)]
	internal static extern ulong gdk_device_tool_get_serial(GdkDeviceToolHandle tool);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDeviceToolType gdk_device_tool_get_tool_type(GdkDeviceToolHandle tool);

}
