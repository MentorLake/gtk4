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
public enum GUriFlags
{
	G_URI_FLAGS_NONE = 0,
	G_URI_FLAGS_PARSE_RELAXED = 1,
	G_URI_FLAGS_HAS_PASSWORD = 2,
	G_URI_FLAGS_HAS_AUTH_PARAMS = 4,
	G_URI_FLAGS_ENCODED = 8,
	G_URI_FLAGS_NON_DNS = 16,
	G_URI_FLAGS_ENCODED_QUERY = 32,
	G_URI_FLAGS_ENCODED_PATH = 64,
	G_URI_FLAGS_ENCODED_FRAGMENT = 128,
	G_URI_FLAGS_SCHEME_NORMALIZE = 256
}
