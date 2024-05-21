namespace MentorLake.Gtk4.GLib;

public class GMemChunkHandle : BaseSafeHandle
{
}


public static class GMemChunkHandleExtensions
{
	public static IntPtr Alloc(this GMemChunkHandle mem_chunk)
	{
		return GMemChunkExterns.g_mem_chunk_alloc(mem_chunk);
	}

	public static IntPtr Alloc0(this GMemChunkHandle mem_chunk)
	{
		return GMemChunkExterns.g_mem_chunk_alloc0(mem_chunk);
	}

	public static GMemChunkHandle Clean(this GMemChunkHandle mem_chunk)
	{
		GMemChunkExterns.g_mem_chunk_clean(mem_chunk);
		return mem_chunk;
	}

	public static GMemChunkHandle Destroy(this GMemChunkHandle mem_chunk)
	{
		GMemChunkExterns.g_mem_chunk_destroy(mem_chunk);
		return mem_chunk;
	}

	public static GMemChunkHandle Free(this GMemChunkHandle mem_chunk, IntPtr mem)
	{
		GMemChunkExterns.g_mem_chunk_free(mem_chunk, mem);
		return mem_chunk;
	}

	public static GMemChunkHandle Print(this GMemChunkHandle mem_chunk)
	{
		GMemChunkExterns.g_mem_chunk_print(mem_chunk);
		return mem_chunk;
	}

	public static GMemChunkHandle Reset(this GMemChunkHandle mem_chunk)
	{
		GMemChunkExterns.g_mem_chunk_reset(mem_chunk);
		return mem_chunk;
	}

}
internal class GMemChunkExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_mem_chunk_alloc(GMemChunkHandle mem_chunk);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_mem_chunk_alloc0(GMemChunkHandle mem_chunk);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mem_chunk_clean(GMemChunkHandle mem_chunk);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mem_chunk_destroy(GMemChunkHandle mem_chunk);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mem_chunk_free(GMemChunkHandle mem_chunk, IntPtr mem);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mem_chunk_print(GMemChunkHandle mem_chunk);

	[DllImport(Libraries.GLib)]
	internal static extern void g_mem_chunk_reset(GMemChunkHandle mem_chunk);

}

public struct GMemChunk
{
}
