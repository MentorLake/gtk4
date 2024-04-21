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

public class GdkSurfaceHandle : GObjectHandle
{
	public static GdkSurfaceHandle NewPopup(GdkSurfaceHandle parent, bool autohide)
	{
		return GdkSurfaceExterns.gdk_surface_new_popup(parent, autohide);
	}

	public static GdkSurfaceHandle NewToplevel(GdkDisplayHandle display)
	{
		return GdkSurfaceExterns.gdk_surface_new_toplevel(display);
	}

}

public class GdkSurfaceSignal
{
	public string Value { get; set; }
	public GdkSurfaceSignal(string value) => Value = value;
}

public static class GdkSurfaceSignals
{
	public static GdkSurfaceSignal EnterMonitor = new("BindingTransform.MethodDeclaration");
	public static GdkSurfaceSignal Event = new("BindingTransform.MethodDeclaration");
	public static GdkSurfaceSignal Layout = new("BindingTransform.MethodDeclaration");
	public static GdkSurfaceSignal LeaveMonitor = new("BindingTransform.MethodDeclaration");
	public static GdkSurfaceSignal Render = new("BindingTransform.MethodDeclaration");
}

public static class GdkSurfaceHandleExtensions
{
	public static GdkSurfaceHandle Beep(this GdkSurfaceHandle surface)
	{
		GdkSurfaceExterns.gdk_surface_beep(surface);
		return surface;
	}

	public static GdkCairoContextHandle CreateCairoContext(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_create_cairo_context(surface);
	}

	public static GdkGLContextHandle CreateGlContext(this GdkSurfaceHandle surface, out GErrorHandle error)
	{
		return GdkSurfaceExterns.gdk_surface_create_gl_context(surface, out error);
	}

	public static cairo_surface_tHandle CreateSimilarSurface(this GdkSurfaceHandle surface, cairo_content_t content, int width, int height)
	{
		return GdkSurfaceExterns.gdk_surface_create_similar_surface(surface, content, width, height);
	}

	public static GdkVulkanContextHandle CreateVulkanContext(this GdkSurfaceHandle surface, out GErrorHandle error)
	{
		return GdkSurfaceExterns.gdk_surface_create_vulkan_context(surface, out error);
	}

	public static GdkSurfaceHandle Destroy(this GdkSurfaceHandle surface)
	{
		GdkSurfaceExterns.gdk_surface_destroy(surface);
		return surface;
	}

	public static GdkCursorHandle GetCursor(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_cursor(surface);
	}

	public static GdkCursorHandle GetDeviceCursor(this GdkSurfaceHandle surface, GdkDeviceHandle device)
	{
		return GdkSurfaceExterns.gdk_surface_get_device_cursor(surface, device);
	}

	public static bool GetDevicePosition(this GdkSurfaceHandle surface, GdkDeviceHandle device, out double x, out double y, out GdkModifierType mask)
	{
		return GdkSurfaceExterns.gdk_surface_get_device_position(surface, device, out x, out y, out mask);
	}

	public static GdkDisplayHandle GetDisplay(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_display(surface);
	}

	public static GdkFrameClockHandle GetFrameClock(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_frame_clock(surface);
	}

	public static int GetHeight(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_height(surface);
	}

	public static bool GetMapped(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_mapped(surface);
	}

	public static double GetScale(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_scale(surface);
	}

	public static int GetScaleFactor(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_scale_factor(surface);
	}

	public static int GetWidth(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_width(surface);
	}

	public static GdkSurfaceHandle Hide(this GdkSurfaceHandle surface)
	{
		GdkSurfaceExterns.gdk_surface_hide(surface);
		return surface;
	}

	public static bool IsDestroyed(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_is_destroyed(surface);
	}

	public static GdkSurfaceHandle QueueRender(this GdkSurfaceHandle surface)
	{
		GdkSurfaceExterns.gdk_surface_queue_render(surface);
		return surface;
	}

	public static GdkSurfaceHandle RequestLayout(this GdkSurfaceHandle surface)
	{
		GdkSurfaceExterns.gdk_surface_request_layout(surface);
		return surface;
	}

	public static GdkSurfaceHandle SetCursor(this GdkSurfaceHandle surface, GdkCursorHandle cursor)
	{
		GdkSurfaceExterns.gdk_surface_set_cursor(surface, cursor);
		return surface;
	}

	public static GdkSurfaceHandle SetDeviceCursor(this GdkSurfaceHandle surface, GdkDeviceHandle device, GdkCursorHandle cursor)
	{
		GdkSurfaceExterns.gdk_surface_set_device_cursor(surface, device, cursor);
		return surface;
	}

	public static GdkSurfaceHandle SetInputRegion(this GdkSurfaceHandle surface, cairo_region_tHandle region)
	{
		GdkSurfaceExterns.gdk_surface_set_input_region(surface, region);
		return surface;
	}

	public static GdkSurfaceHandle SetOpaqueRegion(this GdkSurfaceHandle surface, cairo_region_tHandle region)
	{
		GdkSurfaceExterns.gdk_surface_set_opaque_region(surface, region);
		return surface;
	}

	public static bool TranslateCoordinates(this GdkSurfaceHandle from, GdkSurfaceHandle to, ref double x, ref double y)
	{
		return GdkSurfaceExterns.gdk_surface_translate_coordinates(from, to, ref x, ref y);
	}

	public static GdkSurfaceHandle Signal_EnterMonitor(this GdkSurfaceHandle instance, GdkSurfaceDelegates.EnterMonitor handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "enter_monitor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GdkSurfaceHandle Signal_Event(this GdkSurfaceHandle instance, GdkSurfaceDelegates.Event handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GdkSurfaceHandle Signal_Layout(this GdkSurfaceHandle instance, GdkSurfaceDelegates.Layout handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "layout", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GdkSurfaceHandle Signal_LeaveMonitor(this GdkSurfaceHandle instance, GdkSurfaceDelegates.LeaveMonitor handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "leave_monitor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GdkSurfaceHandle Signal_Render(this GdkSurfaceHandle instance, GdkSurfaceDelegates.Render handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "render", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GdkSurfaceDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void EnterMonitor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSurfaceHandle>))] GdkSurfaceHandle self, GdkMonitorHandle monitor, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool Event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSurfaceHandle>))] GdkSurfaceHandle self, GdkEventHandle @event, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSurfaceHandle>))] GdkSurfaceHandle self, int width, int height, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void LeaveMonitor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSurfaceHandle>))] GdkSurfaceHandle self, GdkMonitorHandle monitor, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool Render([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkSurfaceHandle>))] GdkSurfaceHandle self, cairo_region_tHandle region, IntPtr user_data);
}

internal class GdkSurfaceExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSurfaceHandle gdk_surface_new_popup(GdkSurfaceHandle parent, bool autohide);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSurfaceHandle gdk_surface_new_toplevel(GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_beep(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkCairoContextHandle gdk_surface_create_cairo_context(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkGLContextHandle gdk_surface_create_gl_context(GdkSurfaceHandle surface, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern cairo_surface_tHandle gdk_surface_create_similar_surface(GdkSurfaceHandle surface, cairo_content_t content, int width, int height);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkVulkanContextHandle gdk_surface_create_vulkan_context(GdkSurfaceHandle surface, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_destroy(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkCursorHandle gdk_surface_get_cursor(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkCursorHandle gdk_surface_get_device_cursor(GdkSurfaceHandle surface, GdkDeviceHandle device);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_surface_get_device_position(GdkSurfaceHandle surface, GdkDeviceHandle device, out double x, out double y, out GdkModifierType mask);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_surface_get_display(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkFrameClockHandle gdk_surface_get_frame_clock(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_surface_get_height(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_surface_get_mapped(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern double gdk_surface_get_scale(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_surface_get_scale_factor(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_surface_get_width(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_hide(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_surface_is_destroyed(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_queue_render(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_request_layout(GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_set_cursor(GdkSurfaceHandle surface, GdkCursorHandle cursor);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_set_device_cursor(GdkSurfaceHandle surface, GdkDeviceHandle device, GdkCursorHandle cursor);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_set_input_region(GdkSurfaceHandle surface, cairo_region_tHandle region);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_surface_set_opaque_region(GdkSurfaceHandle surface, cairo_region_tHandle region);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_surface_translate_coordinates(GdkSurfaceHandle from, GdkSurfaceHandle to, ref double x, ref double y);

}
