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
public enum GSubprocessFlags
{
	G_SUBPROCESS_FLAGS_NONE = 0,
	G_SUBPROCESS_FLAGS_STDIN_PIPE = 1,
	G_SUBPROCESS_FLAGS_STDIN_INHERIT = 2,
	G_SUBPROCESS_FLAGS_STDOUT_PIPE = 4,
	G_SUBPROCESS_FLAGS_STDOUT_SILENCE = 8,
	G_SUBPROCESS_FLAGS_STDERR_PIPE = 16,
	G_SUBPROCESS_FLAGS_STDERR_SILENCE = 32,
	G_SUBPROCESS_FLAGS_STDERR_MERGE = 64,
	G_SUBPROCESS_FLAGS_INHERIT_FDS = 128,
	G_SUBPROCESS_FLAGS_SEARCH_PATH_FROM_ENVP = 256
}
