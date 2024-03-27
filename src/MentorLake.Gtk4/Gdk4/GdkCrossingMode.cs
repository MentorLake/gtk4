using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gdk4;

public enum GdkCrossingMode
{
	GDK_CROSSING_NORMAL,
	GDK_CROSSING_GRAB,
	GDK_CROSSING_UNGRAB,
	GDK_CROSSING_GTK_GRAB,
	GDK_CROSSING_GTK_UNGRAB,
	GDK_CROSSING_STATE_CHANGED,
	GDK_CROSSING_TOUCH_BEGIN,
	GDK_CROSSING_TOUCH_END,
	GDK_CROSSING_DEVICE_SWITCH
}
