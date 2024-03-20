using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkGLAreaAdaptors
{
	public static GtkGLAreaHandle GtkGlAreaSetUseEs(this GtkGLAreaHandle area, int use_es)
	{
		GtkGLAreaExterns.gtk_gl_area_set_use_es(area, use_es);
		return area;
	}

	public static int GtkGlAreaGetUseEs(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_use_es(area);
	}

	public static GtkGLAreaHandle GtkGlAreaSetRequiredVersion(this GtkGLAreaHandle area, int major, int minor)
	{
		GtkGLAreaExterns.gtk_gl_area_set_required_version(area, major, minor);
		return area;
	}

	public static GtkGLAreaHandle GtkGlAreaGetRequiredVersion(this GtkGLAreaHandle area, out int major, out int minor)
	{
		GtkGLAreaExterns.gtk_gl_area_get_required_version(area, out major, out minor);
		return area;
	}

	public static int GtkGlAreaGetHasDepthBuffer(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_has_depth_buffer(area);
	}

	public static GtkGLAreaHandle GtkGlAreaSetHasDepthBuffer(this GtkGLAreaHandle area, int has_depth_buffer)
	{
		GtkGLAreaExterns.gtk_gl_area_set_has_depth_buffer(area, has_depth_buffer);
		return area;
	}

	public static int GtkGlAreaGetHasStencilBuffer(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_has_stencil_buffer(area);
	}

	public static GtkGLAreaHandle GtkGlAreaSetHasStencilBuffer(this GtkGLAreaHandle area, int has_stencil_buffer)
	{
		GtkGLAreaExterns.gtk_gl_area_set_has_stencil_buffer(area, has_stencil_buffer);
		return area;
	}

	public static int GtkGlAreaGetAutoRender(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_auto_render(area);
	}

	public static GtkGLAreaHandle GtkGlAreaSetAutoRender(this GtkGLAreaHandle area, int auto_render)
	{
		GtkGLAreaExterns.gtk_gl_area_set_auto_render(area, auto_render);
		return area;
	}

	public static GtkGLAreaHandle GtkGlAreaQueueRender(this GtkGLAreaHandle area)
	{
		GtkGLAreaExterns.gtk_gl_area_queue_render(area);
		return area;
	}

	public static GdkGLContextHandle GtkGlAreaGetContext(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_context(area);
	}

	public static GtkGLAreaHandle GtkGlAreaMakeCurrent(this GtkGLAreaHandle area)
	{
		GtkGLAreaExterns.gtk_gl_area_make_current(area);
		return area;
	}

	public static GtkGLAreaHandle GtkGlAreaAttachBuffers(this GtkGLAreaHandle area)
	{
		GtkGLAreaExterns.gtk_gl_area_attach_buffers(area);
		return area;
	}

	public static GtkGLAreaHandle GtkGlAreaSetError(this GtkGLAreaHandle area, GErrorHandle error)
	{
		GtkGLAreaExterns.gtk_gl_area_set_error(area, error);
		return area;
	}

	public static GErrorHandle GtkGlAreaGetError(this GtkGLAreaHandle area)
	{
		return GtkGLAreaExterns.gtk_gl_area_get_error(area);
	}
}
