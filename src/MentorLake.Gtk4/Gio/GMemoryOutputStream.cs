namespace MentorLake.Gtk4.Gio;

public class GMemoryOutputStreamHandle : GOutputStreamHandle, GPollableOutputStreamHandle, GSeekableHandle
{
	public static GMemoryOutputStreamHandle New(IntPtr data, int size, GReallocFunc realloc_function, GDestroyNotify destroy_function)
	{
		return GMemoryOutputStreamExterns.g_memory_output_stream_new(data, size, realloc_function, destroy_function);
	}

	public static GMemoryOutputStreamHandle NewResizable()
	{
		return GMemoryOutputStreamExterns.g_memory_output_stream_new_resizable();
	}

}

public static class GMemoryOutputStreamHandleExtensions
{
	public static IntPtr GetData(this GMemoryOutputStreamHandle ostream)
	{
		return GMemoryOutputStreamExterns.g_memory_output_stream_get_data(ostream);
	}

	public static int GetDataSize(this GMemoryOutputStreamHandle ostream)
	{
		return GMemoryOutputStreamExterns.g_memory_output_stream_get_data_size(ostream);
	}

	public static int GetSize(this GMemoryOutputStreamHandle ostream)
	{
		return GMemoryOutputStreamExterns.g_memory_output_stream_get_size(ostream);
	}

	public static GBytesHandle StealAsBytes(this GMemoryOutputStreamHandle ostream)
	{
		return GMemoryOutputStreamExterns.g_memory_output_stream_steal_as_bytes(ostream);
	}

	public static IntPtr StealData(this GMemoryOutputStreamHandle ostream)
	{
		return GMemoryOutputStreamExterns.g_memory_output_stream_steal_data(ostream);
	}

}

internal class GMemoryOutputStreamExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GMemoryOutputStreamHandle g_memory_output_stream_new(IntPtr data, int size, GReallocFunc realloc_function, GDestroyNotify destroy_function);

	[DllImport(Libraries.Gio)]
	internal static extern GMemoryOutputStreamHandle g_memory_output_stream_new_resizable();

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_memory_output_stream_get_data(GMemoryOutputStreamHandle ostream);

	[DllImport(Libraries.Gio)]
	internal static extern int g_memory_output_stream_get_data_size(GMemoryOutputStreamHandle ostream);

	[DllImport(Libraries.Gio)]
	internal static extern int g_memory_output_stream_get_size(GMemoryOutputStreamHandle ostream);

	[DllImport(Libraries.Gio)]
	internal static extern GBytesHandle g_memory_output_stream_steal_as_bytes(GMemoryOutputStreamHandle ostream);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_memory_output_stream_steal_data(GMemoryOutputStreamHandle ostream);

}
