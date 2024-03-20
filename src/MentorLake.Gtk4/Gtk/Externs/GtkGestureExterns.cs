using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkGestureExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_get_device")]
    internal static extern GdkDeviceHandle gtk_gesture_get_device(this GtkGestureHandle gesture);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_set_state")]
    internal static extern int gtk_gesture_set_state(this GtkGestureHandle gesture, GtkEventSequenceState state);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_get_sequence_state")]
    internal static extern GtkEventSequenceState gtk_gesture_get_sequence_state(this GtkGestureHandle gesture, GdkEventSequenceHandle sequence);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_set_sequence_state")]
    internal static extern int gtk_gesture_set_sequence_state(this GtkGestureHandle gesture, GdkEventSequenceHandle sequence, GtkEventSequenceState state);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_get_sequences")]
    internal static extern GListHandle gtk_gesture_get_sequences(this GtkGestureHandle gesture);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_get_last_updated_sequence")]
    internal static extern GdkEventSequenceHandle gtk_gesture_get_last_updated_sequence(this GtkGestureHandle gesture);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_handles_sequence")]
    internal static extern int gtk_gesture_handles_sequence(this GtkGestureHandle gesture, GdkEventSequenceHandle sequence);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_get_last_event")]
    internal static extern GdkEventHandle gtk_gesture_get_last_event(this GtkGestureHandle gesture, GdkEventSequenceHandle sequence);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_get_point")]
    internal static extern int gtk_gesture_get_point(this GtkGestureHandle gesture, GdkEventSequenceHandle sequence, out double x, out double y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_get_bounding_box")]
    internal static extern int gtk_gesture_get_bounding_box(this GtkGestureHandle gesture, GdkRectangleHandle rect);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_get_bounding_box_center")]
    internal static extern int gtk_gesture_get_bounding_box_center(this GtkGestureHandle gesture, out double x, out double y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_is_active")]
    internal static extern int gtk_gesture_is_active(this GtkGestureHandle gesture);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_is_recognized")]
    internal static extern int gtk_gesture_is_recognized(this GtkGestureHandle gesture);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_group")]
    internal static extern void gtk_gesture_group(this GtkGestureHandle group_gesture, GtkGestureHandle gesture);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_ungroup")]
    internal static extern void gtk_gesture_ungroup(this GtkGestureHandle gesture);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_get_group")]
    internal static extern GListHandle gtk_gesture_get_group(this GtkGestureHandle gesture);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_gesture_is_grouped_with")]
    internal static extern int gtk_gesture_is_grouped_with(this GtkGestureHandle gesture, GtkGestureHandle other);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkGestureHandle gtk_gesture_click_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkGestureHandle gtk_gesture_drag_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkGestureHandle gtk_gesture_long_press_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkGestureHandle gtk_gesture_pan_new(GtkOrientation orientation);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkGestureHandle gtk_gesture_rotate_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkGestureHandle gtk_gesture_stylus_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkGestureHandle gtk_gesture_swipe_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkGestureHandle gtk_gesture_zoom_new();
}
