namespace MentorLake.Gtk4.Gdk4;

public class GdkMemoryTextureHandle : GdkTextureHandle, GdkPaintableHandle, GIconHandle, GLoadableIconHandle
{
	public static GdkMemoryTextureHandle New(int width, int height, GdkMemoryFormat format, GBytesHandle bytes, UIntPtr stride)
	{
		return GdkMemoryTextureExterns.gdk_memory_texture_new(width, height, format, bytes, stride);
	}

}

public static class GdkMemoryTextureHandleExtensions
{
}

internal class GdkMemoryTextureExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkMemoryTextureHandle gdk_memory_texture_new(int width, int height, GdkMemoryFormat format, GBytesHandle bytes, UIntPtr stride);

}
