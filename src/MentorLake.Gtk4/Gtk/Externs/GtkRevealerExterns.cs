using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkRevealerExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_revealer_get_reveal_child")]
    internal static extern int gtk_revealer_get_reveal_child(this GtkRevealerHandle revealer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_revealer_set_reveal_child")]
    internal static extern void gtk_revealer_set_reveal_child(this GtkRevealerHandle revealer, int reveal_child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_revealer_get_child_revealed")]
    internal static extern int gtk_revealer_get_child_revealed(this GtkRevealerHandle revealer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_revealer_get_transition_duration")]
    internal static extern uint gtk_revealer_get_transition_duration(this GtkRevealerHandle revealer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_revealer_set_transition_duration")]
    internal static extern void gtk_revealer_set_transition_duration(this GtkRevealerHandle revealer, uint duration);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_revealer_set_transition_type")]
    internal static extern void gtk_revealer_set_transition_type(this GtkRevealerHandle revealer, GtkRevealerTransitionType transition);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_revealer_get_transition_type")]
    internal static extern GtkRevealerTransitionType gtk_revealer_get_transition_type(this GtkRevealerHandle revealer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_revealer_set_child")]
    internal static extern void gtk_revealer_set_child(this GtkRevealerHandle revealer, GtkWidgetHandle child);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_revealer_get_child")]
    internal static extern GtkWidgetHandle gtk_revealer_get_child(this GtkRevealerHandle revealer);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkRevealerHandle gtk_revealer_new();
}
