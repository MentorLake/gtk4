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

public enum GtkEditableProperties
{
	GTK_EDITABLE_PROP_TEXT,
	GTK_EDITABLE_PROP_CURSOR_POSITION,
	GTK_EDITABLE_PROP_SELECTION_BOUND,
	GTK_EDITABLE_PROP_EDITABLE,
	GTK_EDITABLE_PROP_WIDTH_CHARS,
	GTK_EDITABLE_PROP_MAX_WIDTH_CHARS,
	GTK_EDITABLE_PROP_XALIGN,
	GTK_EDITABLE_PROP_ENABLE_UNDO,
	GTK_EDITABLE_NUM_PROPERTIES
}
