namespace MentorLake.Gtk4.Gio;

public class GConverterInputStreamHandle : GFilterInputStreamHandle, GPollableInputStreamHandle
{
	public static GConverterInputStreamHandle New(GInputStreamHandle base_stream, GConverterHandle converter)
	{
		return GConverterInputStreamExterns.g_converter_input_stream_new(base_stream, converter);
	}

}

public static class GConverterInputStreamHandleExtensions
{
	public static GConverterHandle GetConverter(this GConverterInputStreamHandle converter_stream)
	{
		return GConverterInputStreamExterns.g_converter_input_stream_get_converter(converter_stream);
	}

}

internal class GConverterInputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GConverterInputStreamHandle g_converter_input_stream_new(GInputStreamHandle base_stream, GConverterHandle converter);

	[DllImport(Libraries.Gio)]
	internal static extern GConverterHandle g_converter_input_stream_get_converter(GConverterInputStreamHandle converter_stream);

}
