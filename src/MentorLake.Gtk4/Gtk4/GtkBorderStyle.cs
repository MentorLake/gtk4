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

public enum GtkBorderStyle
{
	GTK_BORDER_STYLE_NONE,
	GTK_BORDER_STYLE_HIDDEN,
	GTK_BORDER_STYLE_SOLID,
	GTK_BORDER_STYLE_INSET,
	GTK_BORDER_STYLE_OUTSET,
	GTK_BORDER_STYLE_DOTTED,
	GTK_BORDER_STYLE_DASHED,
	GTK_BORDER_STYLE_DOUBLE,
	GTK_BORDER_STYLE_GROOVE,
	GTK_BORDER_STYLE_RIDGE
}
