namespace MentorLake.Gtk4.Gio;

public interface GConverterHandle
{
}

internal class GConverterHandleImpl : BaseSafeHandle, GConverterHandle
{
}

public static class GConverterHandleExtensions
{
	public static GConverterResult Convert(this GConverterHandle converter, IntPtr inbuf, UIntPtr inbuf_size, IntPtr outbuf, UIntPtr outbuf_size, GConverterFlags flags, out UIntPtr bytes_read, out UIntPtr bytes_written, out GErrorHandle error)
	{
		return GConverterExterns.g_converter_convert(converter, inbuf, inbuf_size, outbuf, outbuf_size, flags, out bytes_read, out bytes_written, out error);
	}

	public static GConverterHandle Reset(this GConverterHandle converter)
	{
		GConverterExterns.g_converter_reset(converter);
		return converter;
	}

}

internal class GConverterExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GConverterResult g_converter_convert(GConverterHandle converter, IntPtr inbuf, UIntPtr inbuf_size, IntPtr outbuf, UIntPtr outbuf_size, GConverterFlags flags, out UIntPtr bytes_read, out UIntPtr bytes_written, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_converter_reset(GConverterHandle converter);

}
