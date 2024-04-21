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

public class GdkGLContextHandle : GdkDrawContextHandle
{
	public static void GdkGlContextClearCurrent()
	{
		GdkGLContextExterns.gdk_gl_context_clear_current();
	}

	public static GdkGLContextHandle GdkGlContextGetCurrent()
	{
		return GdkGLContextExterns.gdk_gl_context_get_current();
	}

}

public static class GdkGLContextHandleExtensions
{
	public static GdkGLAPI GdkGlContextGetAllowedApis(this GdkGLContextHandle self)
	{
		return GdkGLContextExterns.gdk_gl_context_get_allowed_apis(self);
	}

	public static GdkGLAPI GdkGlContextGetApi(this GdkGLContextHandle self)
	{
		return GdkGLContextExterns.gdk_gl_context_get_api(self);
	}

	public static bool GdkGlContextGetDebugEnabled(this GdkGLContextHandle context)
	{
		return GdkGLContextExterns.gdk_gl_context_get_debug_enabled(context);
	}

	public static GdkDisplayHandle GdkGlContextGetDisplay(this GdkGLContextHandle context)
	{
		return GdkGLContextExterns.gdk_gl_context_get_display(context);
	}

	public static bool GdkGlContextGetForwardCompatible(this GdkGLContextHandle context)
	{
		return GdkGLContextExterns.gdk_gl_context_get_forward_compatible(context);
	}

	public static GdkGLContextHandle GdkGlContextGetRequiredVersion(this GdkGLContextHandle context, out int major, out int minor)
	{
		GdkGLContextExterns.gdk_gl_context_get_required_version(context, out major, out minor);
		return context;
	}

	public static GdkGLContextHandle GdkGlContextGetSharedContext(this GdkGLContextHandle context)
	{
		return GdkGLContextExterns.gdk_gl_context_get_shared_context(context);
	}

	public static GdkSurfaceHandle GdkGlContextGetSurface(this GdkGLContextHandle context)
	{
		return GdkGLContextExterns.gdk_gl_context_get_surface(context);
	}

	public static bool GdkGlContextGetUseEs(this GdkGLContextHandle context)
	{
		return GdkGLContextExterns.gdk_gl_context_get_use_es(context);
	}

	public static GdkGLContextHandle GdkGlContextGetVersion(this GdkGLContextHandle context, out int major, out int minor)
	{
		GdkGLContextExterns.gdk_gl_context_get_version(context, out major, out minor);
		return context;
	}

	public static bool GdkGlContextIsLegacy(this GdkGLContextHandle context)
	{
		return GdkGLContextExterns.gdk_gl_context_is_legacy(context);
	}

	public static bool GdkGlContextIsShared(this GdkGLContextHandle self, GdkGLContextHandle other)
	{
		return GdkGLContextExterns.gdk_gl_context_is_shared(self, other);
	}

	public static GdkGLContextHandle GdkGlContextMakeCurrent(this GdkGLContextHandle context)
	{
		GdkGLContextExterns.gdk_gl_context_make_current(context);
		return context;
	}

	public static bool GdkGlContextRealize(this GdkGLContextHandle context, out GErrorHandle error)
	{
		return GdkGLContextExterns.gdk_gl_context_realize(context, out error);
	}

	public static GdkGLContextHandle GdkGlContextSetAllowedApis(this GdkGLContextHandle self, GdkGLAPI apis)
	{
		GdkGLContextExterns.gdk_gl_context_set_allowed_apis(self, apis);
		return self;
	}

	public static GdkGLContextHandle GdkGlContextSetDebugEnabled(this GdkGLContextHandle context, bool enabled)
	{
		GdkGLContextExterns.gdk_gl_context_set_debug_enabled(context, enabled);
		return context;
	}

	public static GdkGLContextHandle GdkGlContextSetForwardCompatible(this GdkGLContextHandle context, bool compatible)
	{
		GdkGLContextExterns.gdk_gl_context_set_forward_compatible(context, compatible);
		return context;
	}

	public static GdkGLContextHandle GdkGlContextSetRequiredVersion(this GdkGLContextHandle context, int major, int minor)
	{
		GdkGLContextExterns.gdk_gl_context_set_required_version(context, major, minor);
		return context;
	}

	public static GdkGLContextHandle GdkGlContextSetUseEs(this GdkGLContextHandle context, int use_es)
	{
		GdkGLContextExterns.gdk_gl_context_set_use_es(context, use_es);
		return context;
	}

}

internal class GdkGLContextExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkGLAPI gdk_gl_context_get_allowed_apis(GdkGLContextHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkGLAPI gdk_gl_context_get_api(GdkGLContextHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_gl_context_get_debug_enabled(GdkGLContextHandle context);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_gl_context_get_display(GdkGLContextHandle context);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_gl_context_get_forward_compatible(GdkGLContextHandle context);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_context_get_required_version(GdkGLContextHandle context, out int major, out int minor);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkGLContextHandle gdk_gl_context_get_shared_context(GdkGLContextHandle context);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSurfaceHandle gdk_gl_context_get_surface(GdkGLContextHandle context);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_gl_context_get_use_es(GdkGLContextHandle context);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_context_get_version(GdkGLContextHandle context, out int major, out int minor);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_gl_context_is_legacy(GdkGLContextHandle context);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_gl_context_is_shared(GdkGLContextHandle self, GdkGLContextHandle other);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_context_make_current(GdkGLContextHandle context);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_gl_context_realize(GdkGLContextHandle context, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_context_set_allowed_apis(GdkGLContextHandle self, GdkGLAPI apis);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_context_set_debug_enabled(GdkGLContextHandle context, bool enabled);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_context_set_forward_compatible(GdkGLContextHandle context, bool compatible);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_context_set_required_version(GdkGLContextHandle context, int major, int minor);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_context_set_use_es(GdkGLContextHandle context, int use_es);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_context_clear_current();

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkGLContextHandle gdk_gl_context_get_current();

}
