using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPadControllerExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_pad_controller_set_action_entries")]
    internal static extern void gtk_pad_controller_set_action_entries(this GtkPadControllerHandle controller, GtkPadActionEntryHandle entries, int n_entries);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_pad_controller_set_action")]
    internal static extern void gtk_pad_controller_set_action(this GtkPadControllerHandle controller, GtkPadActionType type, int index, int mode, string label, string action_name);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPadControllerHandle gtk_pad_controller_new(GActionGroupHandle group, GdkDeviceHandle pad);
}
