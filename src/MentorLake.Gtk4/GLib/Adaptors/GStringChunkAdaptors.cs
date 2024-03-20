using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GStringChunkAdaptors
{
	public static GStringChunkHandle Free(this GStringChunkHandle chunk)
	{
		GStringChunkExterns.g_string_chunk_free(chunk);
		return chunk;
	}

	public static GStringChunkHandle Clear(this GStringChunkHandle chunk)
	{
		GStringChunkExterns.g_string_chunk_clear(chunk);
		return chunk;
	}

	public static string Insert(this GStringChunkHandle chunk, string @string)
	{
		return GStringChunkExterns.g_string_chunk_insert(chunk, @string);
	}

	public static string InsertLen(this GStringChunkHandle chunk, string @string, nint len)
	{
		return GStringChunkExterns.g_string_chunk_insert_len(chunk, @string, len);
	}

	public static string InsertConst(this GStringChunkHandle chunk, string @string)
	{
		return GStringChunkExterns.g_string_chunk_insert_const(chunk, @string);
	}
}
