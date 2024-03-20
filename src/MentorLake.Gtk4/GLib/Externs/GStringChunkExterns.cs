using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GStringChunkExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_string_chunk_free")]
    internal static extern void g_string_chunk_free(this GStringChunkHandle chunk);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_chunk_clear")]
    internal static extern void g_string_chunk_clear(this GStringChunkHandle chunk);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_chunk_insert")]
    internal static extern string g_string_chunk_insert(this GStringChunkHandle chunk, string @string);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_chunk_insert_len")]
    internal static extern string g_string_chunk_insert_len(this GStringChunkHandle chunk, string @string, nint len);
    [DllImport(Libraries.GLib, EntryPoint = "g_string_chunk_insert_const")]
    internal static extern string g_string_chunk_insert_const(this GStringChunkHandle chunk, string @string);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GStringChunkHandle g_string_chunk_new(nuint size);
}
