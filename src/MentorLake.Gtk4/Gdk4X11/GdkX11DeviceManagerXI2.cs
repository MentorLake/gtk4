namespace MentorLake.Gtk4.Gdk4X11;

public class GdkX11DeviceManagerXI2Handle : GObjectHandle
{
}

public static class GdkX11DeviceManagerXI2HandleExtensions
{
	public static GdkDeviceHandle GdkX11DeviceManagerLookup(this GdkX11DeviceManagerXI2Handle device_manager, int device_id)
	{
		return GdkX11DeviceManagerXI2Externs.gdk_x11_device_manager_lookup(device_manager, device_id);
	}

}

internal class GdkX11DeviceManagerXI2Externs
{
	[DllImport(Libraries.Gdk4X11)]
	internal static extern GdkDeviceHandle gdk_x11_device_manager_lookup(GdkX11DeviceManagerXI2Handle device_manager, int device_id);

}
