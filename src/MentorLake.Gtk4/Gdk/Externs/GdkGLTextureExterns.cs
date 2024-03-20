using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;

public static class GdkGLTextureExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_gl_texture_release")]
	internal static extern void gdk_gl_texture_release(this GdkGLTextureHandle self);
}
