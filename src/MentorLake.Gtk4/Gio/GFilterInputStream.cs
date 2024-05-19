namespace MentorLake.Gtk4.Gio;

public class GFilterInputStreamHandle : GInputStreamHandle
{
}

public static class GFilterInputStreamHandleExtensions
{
	public static GInputStreamHandle GetBaseStream(this GFilterInputStreamHandle stream)
	{
		return GFilterInputStreamExterns.g_filter_input_stream_get_base_stream(stream);
	}

	public static bool GetCloseBaseStream(this GFilterInputStreamHandle stream)
	{
		return GFilterInputStreamExterns.g_filter_input_stream_get_close_base_stream(stream);
	}

	public static GFilterInputStreamHandle SetCloseBaseStream(this GFilterInputStreamHandle stream, bool close_base)
	{
		GFilterInputStreamExterns.g_filter_input_stream_set_close_base_stream(stream, close_base);
		return stream;
	}

}

internal class GFilterInputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GInputStreamHandle g_filter_input_stream_get_base_stream(GFilterInputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_filter_input_stream_get_close_base_stream(GFilterInputStreamHandle stream);

	[DllImport(Libraries.Gio)]
	internal static extern void g_filter_input_stream_set_close_base_stream(GFilterInputStreamHandle stream, bool close_base);

}
