using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GTestLogBufferExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_test_log_buffer_free")]
    internal static extern void g_test_log_buffer_free(this GTestLogBufferHandle tbuffer);
    [DllImport(Libraries.GLib, EntryPoint = "g_test_log_buffer_push")]
    internal static extern void g_test_log_buffer_push(this GTestLogBufferHandle tbuffer, uint n_bytes, byte[] bytes);
    [DllImport(Libraries.GLib, EntryPoint = "g_test_log_buffer_pop")]
    internal static extern GTestLogMsgHandle g_test_log_buffer_pop(this GTestLogBufferHandle tbuffer);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GTestLogBufferHandle g_test_log_buffer_new();
}
