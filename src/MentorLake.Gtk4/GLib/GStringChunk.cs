namespace MentorLake.Gtk4.GLib;

public class GStringChunkHandle : BaseSafeHandle
{
}


public static class GStringChunkHandleExtensions
{
	public static GStringChunkHandle Clear(this GStringChunkHandle chunk)
	{
		GStringChunkExterns.g_string_chunk_clear(chunk);
		return chunk;
	}

	public static GStringChunkHandle Free(this GStringChunkHandle chunk)
	{
		GStringChunkExterns.g_string_chunk_free(chunk);
		return chunk;
	}

	public static string Insert(this GStringChunkHandle chunk, string @string)
	{
		return GStringChunkExterns.g_string_chunk_insert(chunk, @string);
	}

	public static string InsertConst(this GStringChunkHandle chunk, string @string)
	{
		return GStringChunkExterns.g_string_chunk_insert_const(chunk, @string);
	}

	public static string InsertLen(this GStringChunkHandle chunk, string @string, UIntPtr len)
	{
		return GStringChunkExterns.g_string_chunk_insert_len(chunk, @string, len);
	}

}
internal class GStringChunkExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_string_chunk_clear(GStringChunkHandle chunk);

	[DllImport(Libraries.GLib)]
	internal static extern void g_string_chunk_free(GStringChunkHandle chunk);

	[DllImport(Libraries.GLib)]
	internal static extern string g_string_chunk_insert(GStringChunkHandle chunk, string @string);

	[DllImport(Libraries.GLib)]
	internal static extern string g_string_chunk_insert_const(GStringChunkHandle chunk, string @string);

	[DllImport(Libraries.GLib)]
	internal static extern string g_string_chunk_insert_len(GStringChunkHandle chunk, string @string, UIntPtr len);

}

public struct GStringChunk
{
}
