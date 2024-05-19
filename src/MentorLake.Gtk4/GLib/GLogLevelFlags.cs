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

namespace MentorLake.Gtk4.GLib;

[Flags]
public enum GLogLevelFlags
{
	G_LOG_FLAG_RECURSION = 0,
	G_LOG_FLAG_FATAL = 1,
	G_LOG_LEVEL_ERROR = 2,
	G_LOG_LEVEL_CRITICAL = 4,
	G_LOG_LEVEL_WARNING = 8,
	G_LOG_LEVEL_MESSAGE = 16,
	G_LOG_LEVEL_INFO = 32,
	G_LOG_LEVEL_DEBUG = 64,
	G_LOG_LEVEL_MASK = 128
}
