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

public enum GdkDeviceToolType
{
	GDK_DEVICE_TOOL_TYPE_UNKNOWN,
	GDK_DEVICE_TOOL_TYPE_PEN,
	GDK_DEVICE_TOOL_TYPE_ERASER,
	GDK_DEVICE_TOOL_TYPE_BRUSH,
	GDK_DEVICE_TOOL_TYPE_PENCIL,
	GDK_DEVICE_TOOL_TYPE_AIRBRUSH,
	GDK_DEVICE_TOOL_TYPE_MOUSE,
	GDK_DEVICE_TOOL_TYPE_LENS
}
