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

namespace MentorLake.Gtk4.Gtk4;

[Flags]
public enum GtkEventControllerScrollFlags
{
	GTK_EVENT_CONTROLLER_SCROLL_NONE = 0,
	GTK_EVENT_CONTROLLER_SCROLL_VERTICAL = 1,
	GTK_EVENT_CONTROLLER_SCROLL_HORIZONTAL = 2,
	GTK_EVENT_CONTROLLER_SCROLL_DISCRETE = 4,
	GTK_EVENT_CONTROLLER_SCROLL_KINETIC = 8,
	GTK_EVENT_CONTROLLER_SCROLL_BOTH_AXES = 16
}
