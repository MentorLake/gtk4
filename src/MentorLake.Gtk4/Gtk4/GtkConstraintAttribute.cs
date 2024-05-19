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

public enum GtkConstraintAttribute
{
	GTK_CONSTRAINT_ATTRIBUTE_NONE,
	GTK_CONSTRAINT_ATTRIBUTE_LEFT,
	GTK_CONSTRAINT_ATTRIBUTE_RIGHT,
	GTK_CONSTRAINT_ATTRIBUTE_TOP,
	GTK_CONSTRAINT_ATTRIBUTE_BOTTOM,
	GTK_CONSTRAINT_ATTRIBUTE_START,
	GTK_CONSTRAINT_ATTRIBUTE_END,
	GTK_CONSTRAINT_ATTRIBUTE_WIDTH,
	GTK_CONSTRAINT_ATTRIBUTE_HEIGHT,
	GTK_CONSTRAINT_ATTRIBUTE_CENTER_X,
	GTK_CONSTRAINT_ATTRIBUTE_CENTER_Y,
	GTK_CONSTRAINT_ATTRIBUTE_BASELINE
}
