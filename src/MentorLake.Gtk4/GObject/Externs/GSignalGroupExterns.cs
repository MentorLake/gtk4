using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GSignalGroupExterns
{
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_group_set_target")]
    internal static extern void g_signal_group_set_target(this GSignalGroupHandle self, IntPtr target);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_group_dup_target")]
    internal static extern IntPtr g_signal_group_dup_target(this GSignalGroupHandle self);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_group_block")]
    internal static extern void g_signal_group_block(this GSignalGroupHandle self);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_group_unblock")]
    internal static extern void g_signal_group_unblock(this GSignalGroupHandle self);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_group_connect_object")]
    internal static extern void g_signal_group_connect_object(this GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr @object, GConnectFlags flags);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_group_connect_data")]
    internal static extern void g_signal_group_connect_data(this GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr data, GClosureNotify notify, GConnectFlags flags);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_group_connect")]
    internal static extern void g_signal_group_connect(this GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr data);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_group_connect_after")]
    internal static extern void g_signal_group_connect_after(this GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr data);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_group_connect_swapped")]
    internal static extern void g_signal_group_connect_swapped(this GSignalGroupHandle self, string detailed_signal, GCallback c_handler, IntPtr data);
    [DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GSignalGroupHandle g_signal_group_new(GType target_type);
}
