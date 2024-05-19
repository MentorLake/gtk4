namespace MentorLake.Gtk4.Gdk4;

public class GdkGLTextureBuilderHandle : GObjectHandle
{
	public static GdkGLTextureBuilderHandle GdkGlTextureBuilderNew()
	{
		return GdkGLTextureBuilderExterns.gdk_gl_texture_builder_new();
	}

}

public static class GdkGLTextureBuilderHandleExtensions
{
	public static GdkTextureHandle GdkGlTextureBuilderBuild(this GdkGLTextureBuilderHandle self, GDestroyNotify destroy, IntPtr data)
	{
		return GdkGLTextureBuilderExterns.gdk_gl_texture_builder_build(self, destroy, data);
	}

	public static GdkGLContextHandle GdkGlTextureBuilderGetContext(this GdkGLTextureBuilderHandle self)
	{
		return GdkGLTextureBuilderExterns.gdk_gl_texture_builder_get_context(self);
	}

	public static GdkMemoryFormat GdkGlTextureBuilderGetFormat(this GdkGLTextureBuilderHandle self)
	{
		return GdkGLTextureBuilderExterns.gdk_gl_texture_builder_get_format(self);
	}

	public static bool GdkGlTextureBuilderGetHasMipmap(this GdkGLTextureBuilderHandle self)
	{
		return GdkGLTextureBuilderExterns.gdk_gl_texture_builder_get_has_mipmap(self);
	}

	public static int GdkGlTextureBuilderGetHeight(this GdkGLTextureBuilderHandle self)
	{
		return GdkGLTextureBuilderExterns.gdk_gl_texture_builder_get_height(self);
	}

	public static uint GdkGlTextureBuilderGetId(this GdkGLTextureBuilderHandle self)
	{
		return GdkGLTextureBuilderExterns.gdk_gl_texture_builder_get_id(self);
	}

	public static IntPtr GdkGlTextureBuilderGetSync(this GdkGLTextureBuilderHandle self)
	{
		return GdkGLTextureBuilderExterns.gdk_gl_texture_builder_get_sync(self);
	}

	public static cairo_region_tHandle GdkGlTextureBuilderGetUpdateRegion(this GdkGLTextureBuilderHandle self)
	{
		return GdkGLTextureBuilderExterns.gdk_gl_texture_builder_get_update_region(self);
	}

	public static GdkTextureHandle GdkGlTextureBuilderGetUpdateTexture(this GdkGLTextureBuilderHandle self)
	{
		return GdkGLTextureBuilderExterns.gdk_gl_texture_builder_get_update_texture(self);
	}

	public static int GdkGlTextureBuilderGetWidth(this GdkGLTextureBuilderHandle self)
	{
		return GdkGLTextureBuilderExterns.gdk_gl_texture_builder_get_width(self);
	}

	public static GdkGLTextureBuilderHandle GdkGlTextureBuilderSetContext(this GdkGLTextureBuilderHandle self, GdkGLContextHandle context)
	{
		GdkGLTextureBuilderExterns.gdk_gl_texture_builder_set_context(self, context);
		return self;
	}

	public static GdkGLTextureBuilderHandle GdkGlTextureBuilderSetFormat(this GdkGLTextureBuilderHandle self, GdkMemoryFormat format)
	{
		GdkGLTextureBuilderExterns.gdk_gl_texture_builder_set_format(self, format);
		return self;
	}

	public static GdkGLTextureBuilderHandle GdkGlTextureBuilderSetHasMipmap(this GdkGLTextureBuilderHandle self, bool has_mipmap)
	{
		GdkGLTextureBuilderExterns.gdk_gl_texture_builder_set_has_mipmap(self, has_mipmap);
		return self;
	}

	public static GdkGLTextureBuilderHandle GdkGlTextureBuilderSetHeight(this GdkGLTextureBuilderHandle self, int height)
	{
		GdkGLTextureBuilderExterns.gdk_gl_texture_builder_set_height(self, height);
		return self;
	}

	public static GdkGLTextureBuilderHandle GdkGlTextureBuilderSetId(this GdkGLTextureBuilderHandle self, uint id)
	{
		GdkGLTextureBuilderExterns.gdk_gl_texture_builder_set_id(self, id);
		return self;
	}

	public static GdkGLTextureBuilderHandle GdkGlTextureBuilderSetSync(this GdkGLTextureBuilderHandle self, IntPtr sync)
	{
		GdkGLTextureBuilderExterns.gdk_gl_texture_builder_set_sync(self, sync);
		return self;
	}

	public static GdkGLTextureBuilderHandle GdkGlTextureBuilderSetUpdateRegion(this GdkGLTextureBuilderHandle self, cairo_region_tHandle region)
	{
		GdkGLTextureBuilderExterns.gdk_gl_texture_builder_set_update_region(self, region);
		return self;
	}

	public static GdkGLTextureBuilderHandle GdkGlTextureBuilderSetUpdateTexture(this GdkGLTextureBuilderHandle self, GdkTextureHandle texture)
	{
		GdkGLTextureBuilderExterns.gdk_gl_texture_builder_set_update_texture(self, texture);
		return self;
	}

	public static GdkGLTextureBuilderHandle GdkGlTextureBuilderSetWidth(this GdkGLTextureBuilderHandle self, int width)
	{
		GdkGLTextureBuilderExterns.gdk_gl_texture_builder_set_width(self, width);
		return self;
	}

}

internal class GdkGLTextureBuilderExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkGLTextureBuilderHandle gdk_gl_texture_builder_new();

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkTextureHandle gdk_gl_texture_builder_build(GdkGLTextureBuilderHandle self, GDestroyNotify destroy, IntPtr data);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkGLContextHandle gdk_gl_texture_builder_get_context(GdkGLTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkMemoryFormat gdk_gl_texture_builder_get_format(GdkGLTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_gl_texture_builder_get_has_mipmap(GdkGLTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_gl_texture_builder_get_height(GdkGLTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_gl_texture_builder_get_id(GdkGLTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern IntPtr gdk_gl_texture_builder_get_sync(GdkGLTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern cairo_region_tHandle gdk_gl_texture_builder_get_update_region(GdkGLTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkTextureHandle gdk_gl_texture_builder_get_update_texture(GdkGLTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_gl_texture_builder_get_width(GdkGLTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_texture_builder_set_context(GdkGLTextureBuilderHandle self, GdkGLContextHandle context);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_texture_builder_set_format(GdkGLTextureBuilderHandle self, GdkMemoryFormat format);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_texture_builder_set_has_mipmap(GdkGLTextureBuilderHandle self, bool has_mipmap);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_texture_builder_set_height(GdkGLTextureBuilderHandle self, int height);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_texture_builder_set_id(GdkGLTextureBuilderHandle self, uint id);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_texture_builder_set_sync(GdkGLTextureBuilderHandle self, IntPtr sync);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_texture_builder_set_update_region(GdkGLTextureBuilderHandle self, cairo_region_tHandle region);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_texture_builder_set_update_texture(GdkGLTextureBuilderHandle self, GdkTextureHandle texture);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_gl_texture_builder_set_width(GdkGLTextureBuilderHandle self, int width);

}
