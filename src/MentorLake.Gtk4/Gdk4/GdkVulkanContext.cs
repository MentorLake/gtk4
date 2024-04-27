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

public class GdkVulkanContextHandle : GdkDrawContextHandle, GInitableHandle
{
}

public static class GdkVulkanContextSignalExtensions
{
	public static GdkVulkanContextHandle Signal_ImagesUpdated(this GdkVulkanContextHandle instance, GdkVulkanContextSignalDelegates.ImagesUpdated handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "images_updated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GdkVulkanContextSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ImagesUpdated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkVulkanContextHandle>))] GdkVulkanContextHandle self, IntPtr user_data);
}


public static class GdkVulkanContextHandleExtensions
{
}

internal class GdkVulkanContextExterns
{
}
