using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkDeviceToolAdaptors
{
    public static nuint GetSerial(this GdkDeviceToolHandle tool)
    {
        return GdkDeviceToolExterns.gdk_device_tool_get_serial(tool);
    }

    public static nuint GetHardwareId(this GdkDeviceToolHandle tool)
    {
        return GdkDeviceToolExterns.gdk_device_tool_get_hardware_id(tool);
    }

    public static GdkDeviceToolType GetToolType(this GdkDeviceToolHandle tool)
    {
        return GdkDeviceToolExterns.gdk_device_tool_get_tool_type(tool);
    }

    public static GdkAxisFlags GetAxes(this GdkDeviceToolHandle tool)
    {
        return GdkDeviceToolExterns.gdk_device_tool_get_axes(tool);
    }
}
