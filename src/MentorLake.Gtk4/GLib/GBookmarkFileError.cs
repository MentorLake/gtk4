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

public enum GBookmarkFileError
{
	G_BOOKMARK_FILE_ERROR_INVALID_URI,
	G_BOOKMARK_FILE_ERROR_INVALID_VALUE,
	G_BOOKMARK_FILE_ERROR_APP_NOT_REGISTERED,
	G_BOOKMARK_FILE_ERROR_URI_NOT_FOUND,
	G_BOOKMARK_FILE_ERROR_READ,
	G_BOOKMARK_FILE_ERROR_UNKNOWN_ENCODING,
	G_BOOKMARK_FILE_ERROR_WRITE,
	G_BOOKMARK_FILE_ERROR_FILE_NOT_FOUND
}
