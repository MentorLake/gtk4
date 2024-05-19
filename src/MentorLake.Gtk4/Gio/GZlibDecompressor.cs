namespace MentorLake.Gtk4.Gio;

public class GZlibDecompressorHandle : GObjectHandle, GConverterHandle
{
	public static GZlibDecompressorHandle New(GZlibCompressorFormat format)
	{
		return GZlibDecompressorExterns.g_zlib_decompressor_new(format);
	}

}

public static class GZlibDecompressorHandleExtensions
{
	public static GFileInfoHandle GetFileInfo(this GZlibDecompressorHandle decompressor)
	{
		return GZlibDecompressorExterns.g_zlib_decompressor_get_file_info(decompressor);
	}

}

internal class GZlibDecompressorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GZlibDecompressorHandle g_zlib_decompressor_new(GZlibCompressorFormat format);

	[DllImport(Libraries.Gio)]
	internal static extern GFileInfoHandle g_zlib_decompressor_get_file_info(GZlibDecompressorHandle decompressor);

}
