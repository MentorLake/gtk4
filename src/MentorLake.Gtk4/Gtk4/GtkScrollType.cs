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

public enum GtkScrollType
{
	GTK_SCROLL_NONE,
	GTK_SCROLL_JUMP,
	GTK_SCROLL_STEP_BACKWARD,
	GTK_SCROLL_STEP_FORWARD,
	GTK_SCROLL_PAGE_BACKWARD,
	GTK_SCROLL_PAGE_FORWARD,
	GTK_SCROLL_STEP_UP,
	GTK_SCROLL_STEP_DOWN,
	GTK_SCROLL_PAGE_UP,
	GTK_SCROLL_PAGE_DOWN,
	GTK_SCROLL_STEP_LEFT,
	GTK_SCROLL_STEP_RIGHT,
	GTK_SCROLL_PAGE_LEFT,
	GTK_SCROLL_PAGE_RIGHT,
	GTK_SCROLL_START,
	GTK_SCROLL_END
}
