using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkLockButtonExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_lock_button_get_permission")]
    internal static extern GPermissionHandle gtk_lock_button_get_permission(this GtkLockButtonHandle button);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_lock_button_set_permission")]
    internal static extern void gtk_lock_button_set_permission(this GtkLockButtonHandle button, GPermissionHandle permission);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkLockButtonHandle gtk_lock_button_new(GPermissionHandle permission);
}
