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

namespace MentorLake.Gtk4.GdkPixbuf;

public enum GdkPixbufError
{
	GDK_PIXBUF_ERROR_CORRUPT_IMAGE,
	GDK_PIXBUF_ERROR_INSUFFICIENT_MEMORY,
	GDK_PIXBUF_ERROR_BAD_OPTION,
	GDK_PIXBUF_ERROR_UNKNOWN_TYPE,
	GDK_PIXBUF_ERROR_UNSUPPORTED_OPERATION,
	GDK_PIXBUF_ERROR_FAILED,
	GDK_PIXBUF_ERROR_INCOMPLETE_ANIMATION
}
