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

public enum GIOChannelError
{
	G_IO_CHANNEL_ERROR_FBIG,
	G_IO_CHANNEL_ERROR_INVAL,
	G_IO_CHANNEL_ERROR_IO,
	G_IO_CHANNEL_ERROR_ISDIR,
	G_IO_CHANNEL_ERROR_NOSPC,
	G_IO_CHANNEL_ERROR_NXIO,
	G_IO_CHANNEL_ERROR_OVERFLOW,
	G_IO_CHANNEL_ERROR_PIPE,
	G_IO_CHANNEL_ERROR_FAILED
}
