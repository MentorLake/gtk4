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
public enum GSpawnFlags
{
	G_SPAWN_DEFAULT = 0,
	G_SPAWN_LEAVE_DESCRIPTORS_OPEN = 1,
	G_SPAWN_DO_NOT_REAP_CHILD = 2,
	G_SPAWN_SEARCH_PATH = 4,
	G_SPAWN_STDOUT_TO_DEV_NULL = 8,
	G_SPAWN_STDERR_TO_DEV_NULL = 16,
	G_SPAWN_CHILD_INHERITS_STDIN = 32,
	G_SPAWN_FILE_AND_ARGV_ZERO = 64,
	G_SPAWN_SEARCH_PATH_FROM_ENVP = 128,
	G_SPAWN_CLOEXEC_PIPES = 256,
	G_SPAWN_CHILD_INHERITS_STDOUT = 512,
	G_SPAWN_CHILD_INHERITS_STDERR = 1024,
	G_SPAWN_STDIN_FROM_DEV_NULL = 2048
}
