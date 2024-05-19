namespace MentorLake.Gtk4.Gio;

public class GSimpleIOStreamHandle : GIOStreamHandle
{
	public static GSimpleIOStreamHandle GSimpleIoStreamNew(GInputStreamHandle input_stream, GOutputStreamHandle output_stream)
	{
		return GSimpleIOStreamExterns.g_simple_io_stream_new(input_stream, output_stream);
	}

}

public static class GSimpleIOStreamHandleExtensions
{
}

internal class GSimpleIOStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSimpleIOStreamHandle g_simple_io_stream_new(GInputStreamHandle input_stream, GOutputStreamHandle output_stream);

}
