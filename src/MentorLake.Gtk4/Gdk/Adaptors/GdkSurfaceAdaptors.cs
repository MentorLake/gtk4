using System.Runtime.InteropServices;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;
public static class GdkSurfaceAdaptors
{
	public static GdkDragHandle GdkDragBegin(this GdkSurfaceHandle surface, GdkDeviceHandle device, GdkContentProviderHandle content, GdkDragAction actions, double dx, double dy)
	{
		return GdkSurfaceExterns.gdk_drag_begin(surface, device, content, actions, dx, dy);
	}

	public static GdkSurfaceHandle NewPopup(this GdkSurfaceHandle parent, int autohide)
	{
		return GdkSurfaceExterns.gdk_surface_new_popup(parent, autohide);
	}

	public static GdkSurfaceHandle Destroy(this GdkSurfaceHandle surface)
	{
		GdkSurfaceExterns.gdk_surface_destroy(surface);
		return surface;
	}

	public static int IsDestroyed(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_is_destroyed(surface);
	}

	public static GdkDisplayHandle GetDisplay(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_display(surface);
	}

	public static GdkSurfaceHandle Hide(this GdkSurfaceHandle surface)
	{
		GdkSurfaceExterns.gdk_surface_hide(surface);
		return surface;
	}

	public static GdkSurfaceHandle SetInputRegion(this GdkSurfaceHandle surface, cairo_regionHandle region)
	{
		GdkSurfaceExterns.gdk_surface_set_input_region(surface, region);
		return surface;
	}

	public static int GetMapped(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_mapped(surface);
	}

	public static GdkSurfaceHandle SetCursor(this GdkSurfaceHandle surface, GdkCursorHandle cursor)
	{
		GdkSurfaceExterns.gdk_surface_set_cursor(surface, cursor);
		return surface;
	}

	public static GdkCursorHandle GetCursor(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_cursor(surface);
	}

	public static GdkSurfaceHandle SetDeviceCursor(this GdkSurfaceHandle surface, GdkDeviceHandle device, GdkCursorHandle cursor)
	{
		GdkSurfaceExterns.gdk_surface_set_device_cursor(surface, device, cursor);
		return surface;
	}

	public static GdkCursorHandle GetDeviceCursor(this GdkSurfaceHandle surface, GdkDeviceHandle device)
	{
		return GdkSurfaceExterns.gdk_surface_get_device_cursor(surface, device);
	}

	public static int GetWidth(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_width(surface);
	}

	public static int GetHeight(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_height(surface);
	}

	public static int TranslateCoordinates(this GdkSurfaceHandle from, GdkSurfaceHandle to, ref double x, ref double y)
	{
		return GdkSurfaceExterns.gdk_surface_translate_coordinates(from, to, ref x, ref y);
	}

	public static int GetScaleFactor(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_scale_factor(surface);
	}

	public static int GetDevicePosition(this GdkSurfaceHandle surface, GdkDeviceHandle device, out double x, out double y, out GdkModifierType mask)
	{
		return GdkSurfaceExterns.gdk_surface_get_device_position(surface, device, out x, out y, out mask);
	}

	public static cairo_surfaceHandle CreateSimilarSurface(this GdkSurfaceHandle surface, _cairo_content content, int width, int height)
	{
		return GdkSurfaceExterns.gdk_surface_create_similar_surface(surface, content, width, height);
	}

	public static GdkSurfaceHandle Beep(this GdkSurfaceHandle surface)
	{
		GdkSurfaceExterns.gdk_surface_beep(surface);
		return surface;
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

	public static GdkFrameClockHandle GetFrameClock(this GdkSurfaceHandle surface)
	{
		return GdkSurfaceExterns.gdk_surface_get_frame_clock(surface);
	}

	public static GdkSurfaceHandle SetOpaqueRegion(this GdkSurfaceHandle surface, cairo_regionHandle region)
	{
		GdkSurfaceExterns.gdk_surface_set_opaque_region(surface, region);
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

	public static GdkVulkanContextHandle CreateVulkanContext(this GdkSurfaceHandle surface, out GErrorHandle error)
	{
		return GdkSurfaceExterns.gdk_surface_create_vulkan_context(surface, out error);
	}
}
