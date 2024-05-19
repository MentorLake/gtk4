namespace MentorLake.Gtk4.Gio;

public class GConverterOutputStreamHandle : GFilterOutputStreamHandle, GPollableOutputStreamHandle
{
	public static GConverterOutputStreamHandle New(GOutputStreamHandle base_stream, GConverterHandle converter)
	{
		return GConverterOutputStreamExterns.g_converter_output_stream_new(base_stream, converter);
	}

}

public static class GConverterOutputStreamHandleExtensions
{
	public static GConverterHandle GetConverter(this GConverterOutputStreamHandle converter_stream)
	{
		return GConverterOutputStreamExterns.g_converter_output_stream_get_converter(converter_stream);
	}

}

internal class GConverterOutputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GConverterOutputStreamHandle g_converter_output_stream_new(GOutputStreamHandle base_stream, GConverterHandle converter);

	[DllImport(Libraries.Gio)]
	internal static extern GConverterHandle g_converter_output_stream_get_converter(GConverterOutputStreamHandle converter_stream);

}
