using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gio;
public static class GApplicationExterns
{
    [DllImport(Libraries.Gio, EntryPoint = "g_application_get_application_id")]
    internal static extern string g_application_get_application_id(this GApplicationHandle application);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_set_application_id")]
    internal static extern void g_application_set_application_id(this GApplicationHandle application, string application_id);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_get_dbus_connection")]
    internal static extern GDBusConnectionHandle g_application_get_dbus_connection(this GApplicationHandle application);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_get_dbus_object_path")]
    internal static extern string g_application_get_dbus_object_path(this GApplicationHandle application);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_get_inactivity_timeout")]
    internal static extern uint g_application_get_inactivity_timeout(this GApplicationHandle application);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_set_inactivity_timeout")]
    internal static extern void g_application_set_inactivity_timeout(this GApplicationHandle application, uint inactivity_timeout);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_get_flags")]
    internal static extern GApplicationFlags g_application_get_flags(this GApplicationHandle application);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_set_flags")]
    internal static extern void g_application_set_flags(this GApplicationHandle application, GApplicationFlags flags);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_get_resource_base_path")]
    internal static extern string g_application_get_resource_base_path(this GApplicationHandle application);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_set_resource_base_path")]
    internal static extern void g_application_set_resource_base_path(this GApplicationHandle application, string resource_path);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_set_action_group")]
    [Obsolete]
    internal static extern void g_application_set_action_group(this GApplicationHandle application, GActionGroupHandle action_group);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_add_main_option_entries")]
    internal static extern void g_application_add_main_option_entries(this GApplicationHandle application, GOptionEntryHandle entries);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_add_main_option")]
    internal static extern void g_application_add_main_option(this GApplicationHandle application, string long_name, char short_name, GOptionFlags flags, GOptionArg arg, string description, string arg_description);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_add_option_group")]
    internal static extern void g_application_add_option_group(this GApplicationHandle application, GOptionGroupHandle group);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_set_option_context_parameter_string")]
    internal static extern void g_application_set_option_context_parameter_string(this GApplicationHandle application, string parameter_string);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_set_option_context_summary")]
    internal static extern void g_application_set_option_context_summary(this GApplicationHandle application, string summary);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_set_option_context_description")]
    internal static extern void g_application_set_option_context_description(this GApplicationHandle application, string description);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_get_is_registered")]
    internal static extern int g_application_get_is_registered(this GApplicationHandle application);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_get_is_remote")]
    internal static extern int g_application_get_is_remote(this GApplicationHandle application);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_register")]
    internal static extern int g_application_register(this GApplicationHandle application, GCancellableHandle cancellable, out GErrorHandle error);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_hold")]
    internal static extern void g_application_hold(this GApplicationHandle application);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_release")]
    internal static extern void g_application_release(this GApplicationHandle application);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_activate")]
    internal static extern void g_application_activate(this GApplicationHandle application);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_open")]
    internal static extern void g_application_open(this GApplicationHandle application, out GFileHandle files, int n_files, string hint);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_run")]
    internal static extern int g_application_run(this GApplicationHandle application, int argc, string[] argv);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_quit")]
    internal static extern void g_application_quit(this GApplicationHandle application);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_set_default")]
    internal static extern void g_application_set_default(this GApplicationHandle application);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_mark_busy")]
    internal static extern void g_application_mark_busy(this GApplicationHandle application);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_unmark_busy")]
    internal static extern void g_application_unmark_busy(this GApplicationHandle application);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_get_is_busy")]
    internal static extern int g_application_get_is_busy(this GApplicationHandle application);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_send_notification")]
    internal static extern void g_application_send_notification(this GApplicationHandle application, string id, GNotificationHandle notification);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_withdraw_notification")]
    internal static extern void g_application_withdraw_notification(this GApplicationHandle application, string id);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_bind_busy_property")]
    internal static extern void g_application_bind_busy_property(this GApplicationHandle application, IntPtr @object, string property);
    [DllImport(Libraries.Gio, EntryPoint = "g_application_unbind_busy_property")]
    internal static extern void g_application_unbind_busy_property(this GApplicationHandle application, IntPtr @object, string property);
    [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GApplicationHandle g_application_new(string application_id, GApplicationFlags flags);
}
