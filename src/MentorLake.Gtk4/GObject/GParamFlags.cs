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

namespace MentorLake.Gtk4.GObject;

[Flags]
public enum GParamFlags
{
	G_PARAM_READABLE = 0,
	G_PARAM_WRITABLE = 1,
	G_PARAM_READWRITE = 2,
	G_PARAM_CONSTRUCT = 4,
	G_PARAM_CONSTRUCT_ONLY = 8,
	G_PARAM_LAX_VALIDATION = 16,
	G_PARAM_STATIC_NAME = 32,
	G_PARAM_PRIVATE = 64,
	G_PARAM_STATIC_NICK = 128,
	G_PARAM_STATIC_BLURB = 256,
	G_PARAM_EXPLICIT_NOTIFY = 512,
	G_PARAM_DEPRECATED = 1024
}
