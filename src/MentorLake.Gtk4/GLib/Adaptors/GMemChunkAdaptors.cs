using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GMemChunkAdaptors
{
	public static GMemChunkHandle Destroy(this GMemChunkHandle mem_chunk)
	{
		GMemChunkExterns.g_mem_chunk_destroy(mem_chunk);
		return mem_chunk;
	}

	public static IntPtr Alloc(this GMemChunkHandle mem_chunk)
	{
		return GMemChunkExterns.g_mem_chunk_alloc(mem_chunk);
	}

	public static IntPtr Alloc0(this GMemChunkHandle mem_chunk)
	{
		return GMemChunkExterns.g_mem_chunk_alloc0(mem_chunk);
	}

	public static GMemChunkHandle Free(this GMemChunkHandle mem_chunk, IntPtr mem)
	{
		GMemChunkExterns.g_mem_chunk_free(mem_chunk, mem);
		return mem_chunk;
	}

	public static GMemChunkHandle Clean(this GMemChunkHandle mem_chunk)
	{
		GMemChunkExterns.g_mem_chunk_clean(mem_chunk);
		return mem_chunk;
	}

	public static GMemChunkHandle Reset(this GMemChunkHandle mem_chunk)
	{
		GMemChunkExterns.g_mem_chunk_reset(mem_chunk);
		return mem_chunk;
	}

	public static GMemChunkHandle Print(this GMemChunkHandle mem_chunk)
	{
		GMemChunkExterns.g_mem_chunk_print(mem_chunk);
		return mem_chunk;
	}
}
