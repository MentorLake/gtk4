using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkGestureSingleHandle : GtkGestureHandle
{
}

public static class GtkGestureSingleHandleExtensions
{
	public static uint GetButton(this GtkGestureSingleHandle gesture)
	{
		return GtkGestureSingleExterns.gtk_gesture_single_get_button(gesture);
	}

	public static uint GetCurrentButton(this GtkGestureSingleHandle gesture)
	{
		return GtkGestureSingleExterns.gtk_gesture_single_get_current_button(gesture);
	}

	public static GdkEventSequenceHandle GetCurrentSequence(this GtkGestureSingleHandle gesture)
	{
		return GtkGestureSingleExterns.gtk_gesture_single_get_current_sequence(gesture);
	}

	public static bool GetExclusive(this GtkGestureSingleHandle gesture)
	{
		return GtkGestureSingleExterns.gtk_gesture_single_get_exclusive(gesture);
	}

	public static bool GetTouchOnly(this GtkGestureSingleHandle gesture)
	{
		return GtkGestureSingleExterns.gtk_gesture_single_get_touch_only(gesture);
	}

	public static GtkGestureSingleHandle SetButton(this GtkGestureSingleHandle gesture, uint button)
	{
		GtkGestureSingleExterns.gtk_gesture_single_set_button(gesture, button);
		return gesture;
	}

	public static GtkGestureSingleHandle SetExclusive(this GtkGestureSingleHandle gesture, bool exclusive)
	{
		GtkGestureSingleExterns.gtk_gesture_single_set_exclusive(gesture, exclusive);
		return gesture;
	}

	public static GtkGestureSingleHandle SetTouchOnly(this GtkGestureSingleHandle gesture, bool touch_only)
	{
		GtkGestureSingleExterns.gtk_gesture_single_set_touch_only(gesture, touch_only);
		return gesture;
	}

}

internal class GtkGestureSingleExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_gesture_single_get_button(GtkGestureSingleHandle gesture);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_gesture_single_get_current_button(GtkGestureSingleHandle gesture);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkEventSequenceHandle gtk_gesture_single_get_current_sequence(GtkGestureSingleHandle gesture);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_single_get_exclusive(GtkGestureSingleHandle gesture);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_single_get_touch_only(GtkGestureSingleHandle gesture);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gesture_single_set_button(GtkGestureSingleHandle gesture, uint button);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gesture_single_set_exclusive(GtkGestureSingleHandle gesture, bool exclusive);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gesture_single_set_touch_only(GtkGestureSingleHandle gesture, bool touch_only);

}
