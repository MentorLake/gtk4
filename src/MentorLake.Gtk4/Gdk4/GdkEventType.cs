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

namespace MentorLake.Gtk4.Gdk4;

public enum GdkEventType
{
	GDK_DELETE,
	GDK_MOTION_NOTIFY,
	GDK_BUTTON_PRESS,
	GDK_BUTTON_RELEASE,
	GDK_KEY_PRESS,
	GDK_KEY_RELEASE,
	GDK_ENTER_NOTIFY,
	GDK_LEAVE_NOTIFY,
	GDK_FOCUS_CHANGE,
	GDK_PROXIMITY_IN,
	GDK_PROXIMITY_OUT,
	GDK_DRAG_ENTER,
	GDK_DRAG_LEAVE,
	GDK_DRAG_MOTION,
	GDK_DROP_START,
	GDK_SCROLL,
	GDK_GRAB_BROKEN,
	GDK_TOUCH_BEGIN,
	GDK_TOUCH_UPDATE,
	GDK_TOUCH_END,
	GDK_TOUCH_CANCEL,
	GDK_TOUCHPAD_SWIPE,
	GDK_TOUCHPAD_PINCH,
	GDK_PAD_BUTTON_PRESS,
	GDK_PAD_BUTTON_RELEASE,
	GDK_PAD_RING,
	GDK_PAD_STRIP,
	GDK_PAD_GROUP_MODE,
	GDK_TOUCHPAD_HOLD,
	GDK_EVENT_LAST
}
