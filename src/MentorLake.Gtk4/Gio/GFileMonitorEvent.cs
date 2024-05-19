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

public enum GFileMonitorEvent
{
	G_FILE_MONITOR_EVENT_CHANGED,
	G_FILE_MONITOR_EVENT_CHANGES_DONE_HINT,
	G_FILE_MONITOR_EVENT_DELETED,
	G_FILE_MONITOR_EVENT_CREATED,
	G_FILE_MONITOR_EVENT_ATTRIBUTE_CHANGED,
	G_FILE_MONITOR_EVENT_PRE_UNMOUNT,
	G_FILE_MONITOR_EVENT_UNMOUNTED,
	G_FILE_MONITOR_EVENT_MOVED,
	G_FILE_MONITOR_EVENT_RENAMED,
	G_FILE_MONITOR_EVENT_MOVED_IN,
	G_FILE_MONITOR_EVENT_MOVED_OUT
}
