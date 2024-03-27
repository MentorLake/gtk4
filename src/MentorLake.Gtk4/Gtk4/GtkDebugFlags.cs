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
public enum GtkDebugFlags
{
	GTK_DEBUG_TEXT = 0,
	GTK_DEBUG_TREE = 1,
	GTK_DEBUG_KEYBINDINGS = 2,
	GTK_DEBUG_MODULES = 4,
	GTK_DEBUG_GEOMETRY = 8,
	GTK_DEBUG_ICONTHEME = 16,
	GTK_DEBUG_PRINTING = 32,
	GTK_DEBUG_BUILDER = 64,
	GTK_DEBUG_SIZE_REQUEST = 128,
	GTK_DEBUG_NO_CSS_CACHE = 256,
	GTK_DEBUG_INTERACTIVE = 512,
	GTK_DEBUG_ACTIONS = 1024,
	GTK_DEBUG_LAYOUT = 2048,
	GTK_DEBUG_SNAPSHOT = 4096,
	GTK_DEBUG_CONSTRAINTS = 8192,
	GTK_DEBUG_BUILDER_OBJECTS = 16384,
	GTK_DEBUG_A11Y = 32768,
	GTK_DEBUG_ICONFALLBACK = 65536,
	GTK_DEBUG_INVERT_TEXT_DIR = 131072
}