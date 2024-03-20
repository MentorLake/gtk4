using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;

public static class GdkGLContextExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_get_display")]
	internal static extern GdkDisplayHandle gdk_gl_context_get_display(this GdkGLContextHandle context);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_get_surface")]
	internal static extern GdkSurfaceHandle gdk_gl_context_get_surface(this GdkGLContextHandle context);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_get_shared_context")]
	internal static extern GdkGLContextHandle gdk_gl_context_get_shared_context(this GdkGLContextHandle context);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_get_version")]
	internal static extern void gdk_gl_context_get_version(this GdkGLContextHandle context, out int major, out int minor);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_is_legacy")]
	internal static extern int gdk_gl_context_is_legacy(this GdkGLContextHandle context);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_is_shared")]
	internal static extern int gdk_gl_context_is_shared(this GdkGLContextHandle self, GdkGLContextHandle other);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_set_required_version")]
	internal static extern void gdk_gl_context_set_required_version(this GdkGLContextHandle context, int major, int minor);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_get_required_version")]
	internal static extern void gdk_gl_context_get_required_version(this GdkGLContextHandle context, out int major, out int minor);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_set_debug_enabled")]
	internal static extern void gdk_gl_context_set_debug_enabled(this GdkGLContextHandle context, int enabled);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_get_debug_enabled")]
	internal static extern int gdk_gl_context_get_debug_enabled(this GdkGLContextHandle context);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_set_forward_compatible")]
	internal static extern void gdk_gl_context_set_forward_compatible(this GdkGLContextHandle context, int compatible);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_get_forward_compatible")]
	internal static extern int gdk_gl_context_get_forward_compatible(this GdkGLContextHandle context);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_set_allowed_apis")]
	internal static extern void gdk_gl_context_set_allowed_apis(this GdkGLContextHandle self, GdkGLAPI apis);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_get_allowed_apis")]
	internal static extern GdkGLAPI gdk_gl_context_get_allowed_apis(this GdkGLContextHandle self);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_get_api")]
	internal static extern GdkGLAPI gdk_gl_context_get_api(this GdkGLContextHandle self);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_set_use_es")]
	[Obsolete]
		internal static extern void gdk_gl_context_set_use_es(this GdkGLContextHandle context, int use_es);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_get_use_es")]
	internal static extern int gdk_gl_context_get_use_es(this GdkGLContextHandle context);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_realize")]
	internal static extern int gdk_gl_context_realize(this GdkGLContextHandle context, out GErrorHandle error);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_context_make_current")]
	internal static extern void gdk_gl_context_make_current(this GdkGLContextHandle context);
}
