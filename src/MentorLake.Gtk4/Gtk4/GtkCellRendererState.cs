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

[Flags]
public enum GtkCellRendererState
{
	GTK_CELL_RENDERER_SELECTED = 0,
	GTK_CELL_RENDERER_PRELIT = 1,
	GTK_CELL_RENDERER_INSENSITIVE = 2,
	GTK_CELL_RENDERER_SORTED = 4,
	GTK_CELL_RENDERER_FOCUSED = 8,
	GTK_CELL_RENDERER_EXPANDABLE = 16,
	GTK_CELL_RENDERER_EXPANDED = 32
}
