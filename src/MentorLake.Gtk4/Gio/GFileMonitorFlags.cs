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

namespace MentorLake.Gtk4.Gio;

[Flags]
public enum GFileMonitorFlags
{
	G_FILE_MONITOR_NONE = 0,
	G_FILE_MONITOR_WATCH_MOUNTS = 1,
	G_FILE_MONITOR_SEND_MOVED = 2,
	G_FILE_MONITOR_WATCH_HARD_LINKS = 4,
	G_FILE_MONITOR_WATCH_MOVES = 8
}
