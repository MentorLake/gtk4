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

public enum GOptionArg
{
	G_OPTION_ARG_NONE,
	G_OPTION_ARG_STRING,
	G_OPTION_ARG_INT,
	G_OPTION_ARG_CALLBACK,
	G_OPTION_ARG_FILENAME,
	G_OPTION_ARG_STRING_ARRAY,
	G_OPTION_ARG_FILENAME_ARRAY,
	G_OPTION_ARG_DOUBLE,
	G_OPTION_ARG_INT64
}
