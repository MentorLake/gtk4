using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GIOChannelExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_init")]
    internal static extern void g_io_channel_init(this GIOChannelHandle channel);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_ref")]
    internal static extern GIOChannelHandle g_io_channel_ref(this GIOChannelHandle channel);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_unref")]
    internal static extern void g_io_channel_unref(this GIOChannelHandle channel);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_read")]
    [Obsolete]
    internal static extern GIOError g_io_channel_read(this GIOChannelHandle channel, string buf, nuint count, out nuint bytes_read);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_write")]
    [Obsolete]
    internal static extern GIOError g_io_channel_write(this GIOChannelHandle channel, string buf, nuint count, out nuint bytes_written);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_seek")]
    [Obsolete]
    internal static extern GIOError g_io_channel_seek(this GIOChannelHandle channel, nint offset, GSeekType type);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_close")]
    [Obsolete]
    internal static extern void g_io_channel_close(this GIOChannelHandle channel);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_shutdown")]
    internal static extern GIOStatus g_io_channel_shutdown(this GIOChannelHandle channel, int flush, out GErrorHandle err);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_add_watch_full")]
    internal static extern uint g_io_add_watch_full(this GIOChannelHandle channel, int priority, GIOCondition condition, GIOFunc func, IntPtr user_data, GDestroyNotify notify);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_create_watch")]
    internal static extern GSourceHandle g_io_create_watch(this GIOChannelHandle channel, GIOCondition condition);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_add_watch")]
    internal static extern uint g_io_add_watch(this GIOChannelHandle channel, GIOCondition condition, GIOFunc func, IntPtr user_data);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_set_buffer_size")]
    internal static extern void g_io_channel_set_buffer_size(this GIOChannelHandle channel, nuint size);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_get_buffer_size")]
    internal static extern nuint g_io_channel_get_buffer_size(this GIOChannelHandle channel);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_get_buffer_condition")]
    internal static extern GIOCondition g_io_channel_get_buffer_condition(this GIOChannelHandle channel);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_set_flags")]
    internal static extern GIOStatus g_io_channel_set_flags(this GIOChannelHandle channel, GIOFlags flags, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_get_flags")]
    internal static extern GIOFlags g_io_channel_get_flags(this GIOChannelHandle channel);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_set_line_term")]
    internal static extern void g_io_channel_set_line_term(this GIOChannelHandle channel, string line_term, int length);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_get_line_term")]
    internal static extern string g_io_channel_get_line_term(this GIOChannelHandle channel, out int length);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_set_buffered")]
    internal static extern void g_io_channel_set_buffered(this GIOChannelHandle channel, int buffered);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_get_buffered")]
    internal static extern int g_io_channel_get_buffered(this GIOChannelHandle channel);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_set_encoding")]
    internal static extern GIOStatus g_io_channel_set_encoding(this GIOChannelHandle channel, string encoding, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_get_encoding")]
    internal static extern string g_io_channel_get_encoding(this GIOChannelHandle channel);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_set_close_on_unref")]
    internal static extern void g_io_channel_set_close_on_unref(this GIOChannelHandle channel, int do_close);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_get_close_on_unref")]
    internal static extern int g_io_channel_get_close_on_unref(this GIOChannelHandle channel);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_flush")]
    internal static extern GIOStatus g_io_channel_flush(this GIOChannelHandle channel, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_read_line")]
    internal static extern GIOStatus g_io_channel_read_line(this GIOChannelHandle channel, out string str_return, out nuint length, out nuint terminator_pos, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_read_line_string")]
    internal static extern GIOStatus g_io_channel_read_line_string(this GIOChannelHandle channel, GStringHandle buffer, out nuint terminator_pos, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_read_to_end")]
    internal static extern GIOStatus g_io_channel_read_to_end(this GIOChannelHandle channel, string[] str_return, out nuint length, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_read_chars")]
    internal static extern GIOStatus g_io_channel_read_chars(this GIOChannelHandle channel, string buf, nuint count, out nuint bytes_read, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_read_unichar")]
    internal static extern GIOStatus g_io_channel_read_unichar(this GIOChannelHandle channel, out char thechar, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_write_chars")]
    internal static extern GIOStatus g_io_channel_write_chars(this GIOChannelHandle channel, string buf, nint count, out nuint bytes_written, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_write_unichar")]
    internal static extern GIOStatus g_io_channel_write_unichar(this GIOChannelHandle channel, uint thechar, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_seek_position")]
    internal static extern GIOStatus g_io_channel_seek_position(this GIOChannelHandle channel, nint offset, GSeekType type, out GErrorHandle error);
    [DllImport(Libraries.GLib, EntryPoint = "g_io_channel_unix_get_fd")]
    internal static extern int g_io_channel_unix_get_fd(this GIOChannelHandle channel);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GIOChannelHandle g_io_channel_new_file(string filename, string mode, out GErrorHandle error);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GIOChannelHandle g_io_channel_unix_new(int fd);
}
