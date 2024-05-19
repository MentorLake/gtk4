namespace MentorLake.Gtk4.Gdk4;

public class GdkGLTextureHandle : GdkTextureHandle, GdkPaintableHandle, GIconHandle, GLoadableIconHandle
{
	public static GdkGLTextureHandle GdkGlTextureNew(GdkGLContextHandle context, uint id, int width, int height, GDestroyNotify destroy, IntPtr data)
	{
		return GdkGLTextureExterns.gdk_gl_texture_new(context, id, width, height, destroy, data);
	}

}

public static class GdkGLTextureHandleExtensions
{
	public static GdkGLTextureHandle GdkGlTextureRelease(this GdkGLTextureHandle self)
	{
		GdkGLTextureExterns.gdk_gl_texture_release(self);
		return self;
	}

}

internal class GdkGLTextureExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkGLTextureHandle gdk_gl_texture_new(GdkGLContextHandle context, uint id, int width, int height, GDestroyNotify destroy, IntPtr data);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_texture_release(GdkGLTextureHandle self);

}
