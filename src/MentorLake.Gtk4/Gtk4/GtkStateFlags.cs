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
public enum GtkStateFlags
{
	GTK_STATE_FLAG_NORMAL = 0,
	GTK_STATE_FLAG_ACTIVE = 1,
	GTK_STATE_FLAG_PRELIGHT = 2,
	GTK_STATE_FLAG_SELECTED = 4,
	GTK_STATE_FLAG_INSENSITIVE = 8,
	GTK_STATE_FLAG_INCONSISTENT = 16,
	GTK_STATE_FLAG_FOCUSED = 32,
	GTK_STATE_FLAG_BACKDROP = 64,
	GTK_STATE_FLAG_DIR_LTR = 128,
	GTK_STATE_FLAG_DIR_RTL = 256,
	GTK_STATE_FLAG_LINK = 512,
	GTK_STATE_FLAG_VISITED = 1024,
	GTK_STATE_FLAG_CHECKED = 2048,
	GTK_STATE_FLAG_DROP_ACTIVE = 4096,
	GTK_STATE_FLAG_FOCUS_VISIBLE = 8192,
	GTK_STATE_FLAG_FOCUS_WITHIN = 16384
}
