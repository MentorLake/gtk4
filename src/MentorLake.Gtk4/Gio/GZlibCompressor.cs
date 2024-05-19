namespace MentorLake.Gtk4.Gio;

public class GZlibCompressorHandle : GObjectHandle, GConverterHandle
{
	public static GZlibCompressorHandle New(GZlibCompressorFormat format, int level)
	{
		return GZlibCompressorExterns.g_zlib_compressor_new(format, level);
	}

}

public static class GZlibCompressorHandleExtensions
{
	public static GFileInfoHandle GetFileInfo(this GZlibCompressorHandle compressor)
	{
		return GZlibCompressorExterns.g_zlib_compressor_get_file_info(compressor);
	}

	public static GZlibCompressorHandle SetFileInfo(this GZlibCompressorHandle compressor, GFileInfoHandle file_info)
	{
		GZlibCompressorExterns.g_zlib_compressor_set_file_info(compressor, file_info);
		return compressor;
	}

}

internal class GZlibCompressorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GZlibCompressorHandle g_zlib_compressor_new(GZlibCompressorFormat format, int level);

	[DllImport(Libraries.Gio)]
	internal static extern GFileInfoHandle g_zlib_compressor_get_file_info(GZlibCompressorHandle compressor);

	[DllImport(Libraries.Gio)]
	internal static extern void g_zlib_compressor_set_file_info(GZlibCompressorHandle compressor, GFileInfoHandle file_info);

}
