using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GMemChunkExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_mem_chunk_destroy")]
    [Obsolete]
    internal static extern void g_mem_chunk_destroy(this GMemChunkHandle mem_chunk);
    [DllImport(Libraries.GLib, EntryPoint = "g_mem_chunk_alloc")]
    internal static extern IntPtr g_mem_chunk_alloc(this GMemChunkHandle mem_chunk);
    [DllImport(Libraries.GLib, EntryPoint = "g_mem_chunk_alloc0")]
    internal static extern IntPtr g_mem_chunk_alloc0(this GMemChunkHandle mem_chunk);
    [DllImport(Libraries.GLib, EntryPoint = "g_mem_chunk_free")]
    [Obsolete]
    internal static extern void g_mem_chunk_free(this GMemChunkHandle mem_chunk, IntPtr mem);
    [DllImport(Libraries.GLib, EntryPoint = "g_mem_chunk_clean")]
    [Obsolete]
    internal static extern void g_mem_chunk_clean(this GMemChunkHandle mem_chunk);
    [DllImport(Libraries.GLib, EntryPoint = "g_mem_chunk_reset")]
    [Obsolete]
    internal static extern void g_mem_chunk_reset(this GMemChunkHandle mem_chunk);
    [DllImport(Libraries.GLib, EntryPoint = "g_mem_chunk_print")]
    [Obsolete]
    internal static extern void g_mem_chunk_print(this GMemChunkHandle mem_chunk);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GMemChunkHandle g_mem_chunk_new(string name, int atom_size, nuint area_size, int type);
}
