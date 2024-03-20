using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;
public static class GdkGLContextAdaptors
{
    public static GdkDisplayHandle GdkGlContextGetDisplay(this GdkGLContextHandle context)
    {
        return GdkGLContextExterns.gdk_gl_context_get_display(context);
    }

    public static GdkSurfaceHandle GdkGlContextGetSurface(this GdkGLContextHandle context)
    {
        return GdkGLContextExterns.gdk_gl_context_get_surface(context);
    }

    public static GdkGLContextHandle GdkGlContextGetSharedContext(this GdkGLContextHandle context)
    {
        return GdkGLContextExterns.gdk_gl_context_get_shared_context(context);
    }

    public static GdkGLContextHandle GdkGlContextGetVersion(this GdkGLContextHandle context, out int major, out int minor)
    {
        GdkGLContextExterns.gdk_gl_context_get_version(context, out major, out minor);
        return context;
    }

    public static int GdkGlContextIsLegacy(this GdkGLContextHandle context)
    {
        return GdkGLContextExterns.gdk_gl_context_is_legacy(context);
    }

    public static int GdkGlContextIsShared(this GdkGLContextHandle self, GdkGLContextHandle other)
    {
        return GdkGLContextExterns.gdk_gl_context_is_shared(self, other);
    }

    public static GdkGLContextHandle GdkGlContextSetRequiredVersion(this GdkGLContextHandle context, int major, int minor)
    {
        GdkGLContextExterns.gdk_gl_context_set_required_version(context, major, minor);
        return context;
    }

    public static GdkGLContextHandle GdkGlContextGetRequiredVersion(this GdkGLContextHandle context, out int major, out int minor)
    {
        GdkGLContextExterns.gdk_gl_context_get_required_version(context, out major, out minor);
        return context;
    }

    public static GdkGLContextHandle GdkGlContextSetDebugEnabled(this GdkGLContextHandle context, int enabled)
    {
        GdkGLContextExterns.gdk_gl_context_set_debug_enabled(context, enabled);
        return context;
    }

    public static int GdkGlContextGetDebugEnabled(this GdkGLContextHandle context)
    {
        return GdkGLContextExterns.gdk_gl_context_get_debug_enabled(context);
    }

    public static GdkGLContextHandle GdkGlContextSetForwardCompatible(this GdkGLContextHandle context, int compatible)
    {
        GdkGLContextExterns.gdk_gl_context_set_forward_compatible(context, compatible);
        return context;
    }

    public static int GdkGlContextGetForwardCompatible(this GdkGLContextHandle context)
    {
        return GdkGLContextExterns.gdk_gl_context_get_forward_compatible(context);
    }

    public static GdkGLContextHandle GdkGlContextSetAllowedApis(this GdkGLContextHandle self, GdkGLAPI apis)
    {
        GdkGLContextExterns.gdk_gl_context_set_allowed_apis(self, apis);
        return self;
    }

    public static GdkGLAPI GdkGlContextGetAllowedApis(this GdkGLContextHandle self)
    {
        return GdkGLContextExterns.gdk_gl_context_get_allowed_apis(self);
    }

    public static GdkGLAPI GdkGlContextGetApi(this GdkGLContextHandle self)
    {
        return GdkGLContextExterns.gdk_gl_context_get_api(self);
    }

    public static GdkGLContextHandle GdkGlContextSetUseEs(this GdkGLContextHandle context, int use_es)
    {
        GdkGLContextExterns.gdk_gl_context_set_use_es(context, use_es);
        return context;
    }

    public static int GdkGlContextGetUseEs(this GdkGLContextHandle context)
    {
        return GdkGLContextExterns.gdk_gl_context_get_use_es(context);
    }

    public static int GdkGlContextRealize(this GdkGLContextHandle context, out GErrorHandle error)
    {
        return GdkGLContextExterns.gdk_gl_context_realize(context, out error);
    }

    public static GdkGLContextHandle GdkGlContextMakeCurrent(this GdkGLContextHandle context)
    {
        GdkGLContextExterns.gdk_gl_context_make_current(context);
        return context;
    }
}
