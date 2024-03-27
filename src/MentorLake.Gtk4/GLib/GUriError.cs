using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.GLib;

public enum GUriError
{
	G_URI_ERROR_FAILED,
	G_URI_ERROR_BAD_SCHEME,
	G_URI_ERROR_BAD_USER,
	G_URI_ERROR_BAD_PASSWORD,
	G_URI_ERROR_BAD_AUTH_PARAMS,
	G_URI_ERROR_BAD_HOST,
	G_URI_ERROR_BAD_PORT,
	G_URI_ERROR_BAD_PATH,
	G_URI_ERROR_BAD_QUERY,
	G_URI_ERROR_BAD_FRAGMENT
}
