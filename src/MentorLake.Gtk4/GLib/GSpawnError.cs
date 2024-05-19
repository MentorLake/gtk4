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

public enum GSpawnError
{
	G_SPAWN_ERROR_FORK,
	G_SPAWN_ERROR_READ,
	G_SPAWN_ERROR_CHDIR,
	G_SPAWN_ERROR_ACCES,
	G_SPAWN_ERROR_PERM,
	G_SPAWN_ERROR_TOO_BIG,
	G_SPAWN_ERROR_2BIG,
	G_SPAWN_ERROR_NOEXEC,
	G_SPAWN_ERROR_NAMETOOLONG,
	G_SPAWN_ERROR_NOENT,
	G_SPAWN_ERROR_NOMEM,
	G_SPAWN_ERROR_NOTDIR,
	G_SPAWN_ERROR_LOOP,
	G_SPAWN_ERROR_TXTBUSY,
	G_SPAWN_ERROR_IO,
	G_SPAWN_ERROR_NFILE,
	G_SPAWN_ERROR_MFILE,
	G_SPAWN_ERROR_INVAL,
	G_SPAWN_ERROR_ISDIR,
	G_SPAWN_ERROR_LIBBAD,
	G_SPAWN_ERROR_FAILED
}
