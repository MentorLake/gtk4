using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GMappedFileExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_mapped_file_get_length")]
    internal static extern nuint g_mapped_file_get_length(this GMappedFileHandle file);
    [DllImport(Libraries.GLib, EntryPoint = "g_mapped_file_get_contents")]
    internal static extern string g_mapped_file_get_contents(this GMappedFileHandle file);
    [DllImport(Libraries.GLib, EntryPoint = "g_mapped_file_get_bytes")]
    internal static extern GBytesHandle g_mapped_file_get_bytes(this GMappedFileHandle file);
    [DllImport(Libraries.GLib, EntryPoint = "g_mapped_file_ref")]
    internal static extern GMappedFileHandle g_mapped_file_ref(this GMappedFileHandle file);
    [DllImport(Libraries.GLib, EntryPoint = "g_mapped_file_unref")]
    internal static extern void g_mapped_file_unref(this GMappedFileHandle file);
    [DllImport(Libraries.GLib, EntryPoint = "g_mapped_file_free")]
    [Obsolete]
    internal static extern void g_mapped_file_free(this GMappedFileHandle file);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GMappedFileHandle g_mapped_file_new(string filename, int writable, out GErrorHandle error);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GMappedFileHandle g_mapped_file_new_from_fd(int fd, int writable, out GErrorHandle error);
}
