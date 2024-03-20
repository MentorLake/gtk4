using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GChecksumExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_checksum_reset")]
    internal static extern void g_checksum_reset(this GChecksumHandle checksum);
    [DllImport(Libraries.GLib, EntryPoint = "g_checksum_copy")]
    internal static extern GChecksumHandle g_checksum_copy(this GChecksumHandle checksum);
    [DllImport(Libraries.GLib, EntryPoint = "g_checksum_free")]
    internal static extern void g_checksum_free(this GChecksumHandle checksum);
    [DllImport(Libraries.GLib, EntryPoint = "g_checksum_update")]
    internal static extern void g_checksum_update(this GChecksumHandle checksum, string data, nint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_checksum_get_string")]
    internal static extern string g_checksum_get_string(this GChecksumHandle checksum);
    [DllImport(Libraries.GLib, EntryPoint = "g_checksum_get_digest")]
    internal static extern void g_checksum_get_digest(this GChecksumHandle checksum, byte[] buffer, ref nuint digest_len);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GChecksumHandle g_checksum_new(GChecksumType checksum_type);
}
