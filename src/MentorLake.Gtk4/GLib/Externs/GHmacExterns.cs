using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GHmacExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_hmac_copy")]
    internal static extern GHmacHandle g_hmac_copy(this GHmacHandle hmac);
    [DllImport(Libraries.GLib, EntryPoint = "g_hmac_ref")]
    internal static extern GHmacHandle g_hmac_ref(this GHmacHandle hmac);
    [DllImport(Libraries.GLib, EntryPoint = "g_hmac_unref")]
    internal static extern void g_hmac_unref(this GHmacHandle hmac);
    [DllImport(Libraries.GLib, EntryPoint = "g_hmac_update")]
    internal static extern void g_hmac_update(this GHmacHandle hmac, string data, nint length);
    [DllImport(Libraries.GLib, EntryPoint = "g_hmac_get_string")]
    internal static extern string g_hmac_get_string(this GHmacHandle hmac);
    [DllImport(Libraries.GLib, EntryPoint = "g_hmac_get_digest")]
    internal static extern void g_hmac_get_digest(this GHmacHandle hmac, byte[] buffer, ref nuint digest_len);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GHmacHandle g_hmac_new(GChecksumType digest_type, string key, nuint key_len);
}
