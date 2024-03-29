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

namespace MentorLake.Gtk4.Gtk4;

public class GtkGLAreaHandle : GtkWidgetHandle
{
	public static GtkGLAreaHandle GtkGlAreaNew()
	{
		return GtkGLAreaExterns.gtk_gl_area_new();
	}

}

public class GtkGLAreaSignal
{
	public string Value { get; set; }
	public GtkGLAreaSignal(string value) => Value = value;
}

public static class GtkGLAreaSignals
{
	public static GtkGLAreaSignal CreateContext = new("create-context");
	public static GtkGLAreaSignal Render = new("render");
	public static GtkGLAreaSignal Resize = new("resize");
}

public static class GtkGLAreaHandleExtensions
{
	public static GtkGLAreaHandle GtkGlAreaAttachBuffers(this GtkGLAreaHandle area)
	{
		GtkGLAreaExterns.gtk_gl_area_attach_buffers(area);
		return area;
	}

	public static GdkGLAPI GtkGlAreaGetAllowedApis(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_allowed_apis(area);
	}

	public static GdkGLAPI GtkGlAreaGetApi(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_api(area);
	}

	public static bool GtkGlAreaGetAutoRender(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_auto_render(area);
	}

	public static GdkGLContextHandle GtkGlAreaGetContext(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_context(area);
	}

	public static GErrorHandle GtkGlAreaGetError(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_error(area);
	}

	public static bool GtkGlAreaGetHasDepthBuffer(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_has_depth_buffer(area);
	}

	public static bool GtkGlAreaGetHasStencilBuffer(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_has_stencil_buffer(area);
	}

	public static GtkGLAreaHandle GtkGlAreaGetRequiredVersion(this GtkGLAreaHandle area, out int major, out int minor)
	{
		GtkGLAreaExterns.gtk_gl_area_get_required_version(area, out major, out minor);
		return area;
	}

	public static bool GtkGlAreaGetUseEs(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_use_es(area);
	}

	public static GtkGLAreaHandle GtkGlAreaMakeCurrent(this GtkGLAreaHandle area)
	{
		GtkGLAreaExterns.gtk_gl_area_make_current(area);
		return area;
	}

	public static GtkGLAreaHandle GtkGlAreaQueueRender(this GtkGLAreaHandle area)
	{
		GtkGLAreaExterns.gtk_gl_area_queue_render(area);
		return area;
	}

	public static GtkGLAreaHandle GtkGlAreaSetAllowedApis(this GtkGLAreaHandle area, GdkGLAPI apis)
	{
		GtkGLAreaExterns.gtk_gl_area_set_allowed_apis(area, apis);
		return area;
	}

	public static GtkGLAreaHandle GtkGlAreaSetAutoRender(this GtkGLAreaHandle area, bool auto_render)
	{
		GtkGLAreaExterns.gtk_gl_area_set_auto_render(area, auto_render);
		return area;
	}

	public static GtkGLAreaHandle GtkGlAreaSetError(this GtkGLAreaHandle area, GErrorHandle error)
	{
		GtkGLAreaExterns.gtk_gl_area_set_error(area, error);
		return area;
	}

	public static GtkGLAreaHandle GtkGlAreaSetHasDepthBuffer(this GtkGLAreaHandle area, bool has_depth_buffer)
	{
		GtkGLAreaExterns.gtk_gl_area_set_has_depth_buffer(area, has_depth_buffer);
		return area;
	}

	public static GtkGLAreaHandle GtkGlAreaSetHasStencilBuffer(this GtkGLAreaHandle area, bool has_stencil_buffer)
	{
		GtkGLAreaExterns.gtk_gl_area_set_has_stencil_buffer(area, has_stencil_buffer);
		return area;
	}

	public static GtkGLAreaHandle GtkGlAreaSetRequiredVersion(this GtkGLAreaHandle area, int major, int minor)
	{
		GtkGLAreaExterns.gtk_gl_area_set_required_version(area, major, minor);
		return area;
	}

	public static GtkGLAreaHandle GtkGlAreaSetUseEs(this GtkGLAreaHandle area, bool use_es)
	{
		GtkGLAreaExterns.gtk_gl_area_set_use_es(area, use_es);
		return area;
	}

	public static GtkGLAreaHandle Connect(this GtkGLAreaHandle instance, GtkGLAreaSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkGLAreaExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGLAreaHandle gtk_gl_area_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gl_area_attach_buffers(GtkGLAreaHandle area);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkGLAPI gtk_gl_area_get_allowed_apis(GtkGLAreaHandle area);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkGLAPI gtk_gl_area_get_api(GtkGLAreaHandle area);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gl_area_get_auto_render(GtkGLAreaHandle area);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkGLContextHandle gtk_gl_area_get_context(GtkGLAreaHandle area);
	[DllImport(Libraries.Gtk4)]
	internal static extern GErrorHandle gtk_gl_area_get_error(GtkGLAreaHandle area);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gl_area_get_has_depth_buffer(GtkGLAreaHandle area);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gl_area_get_has_stencil_buffer(GtkGLAreaHandle area);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gl_area_get_required_version(GtkGLAreaHandle area, out int major, out int minor);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gl_area_get_use_es(GtkGLAreaHandle area);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gl_area_make_current(GtkGLAreaHandle area);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gl_area_queue_render(GtkGLAreaHandle area);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gl_area_set_allowed_apis(GtkGLAreaHandle area, GdkGLAPI apis);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gl_area_set_auto_render(GtkGLAreaHandle area, bool auto_render);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gl_area_set_error(GtkGLAreaHandle area, GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gl_area_set_has_depth_buffer(GtkGLAreaHandle area, bool has_depth_buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gl_area_set_has_stencil_buffer(GtkGLAreaHandle area, bool has_stencil_buffer);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gl_area_set_required_version(GtkGLAreaHandle area, int major, int minor);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gl_area_set_use_es(GtkGLAreaHandle area, bool use_es);
}
