using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkGLTextureAdaptors
{
    public static GdkGLTextureHandle GdkGlTextureRelease(this GdkGLTextureHandle self)
    {
        GdkGLTextureExterns.gdk_gl_texture_release(self);
        return self;
    }
}
