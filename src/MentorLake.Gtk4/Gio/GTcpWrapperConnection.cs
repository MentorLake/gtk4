namespace MentorLake.Gtk4.Gio;

public class GTcpWrapperConnectionHandle : GTcpConnectionHandle
{
	public static GTcpWrapperConnectionHandle New(GIOStreamHandle base_io_stream, GSocketHandle socket)
	{
		return GTcpWrapperConnectionExterns.g_tcp_wrapper_connection_new(base_io_stream, socket);
	}

}

public static class GTcpWrapperConnectionHandleExtensions
{
	public static GIOStreamHandle GetBaseIoStream(this GTcpWrapperConnectionHandle conn)
	{
		return GTcpWrapperConnectionExterns.g_tcp_wrapper_connection_get_base_io_stream(conn);
	}

}

internal class GTcpWrapperConnectionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GTcpWrapperConnectionHandle g_tcp_wrapper_connection_new(GIOStreamHandle base_io_stream, GSocketHandle socket);

	[DllImport(Libraries.Gio)]
	internal static extern GIOStreamHandle g_tcp_wrapper_connection_get_base_io_stream(GTcpWrapperConnectionHandle conn);

}
