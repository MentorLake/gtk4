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

namespace MentorLake.Gtk4.Gtk4;

public enum GtkRecentManagerError
{
	GTK_RECENT_MANAGER_ERROR_NOT_FOUND,
	GTK_RECENT_MANAGER_ERROR_INVALID_URI,
	GTK_RECENT_MANAGER_ERROR_INVALID_ENCODING,
	GTK_RECENT_MANAGER_ERROR_NOT_REGISTERED,
	GTK_RECENT_MANAGER_ERROR_READ,
	GTK_RECENT_MANAGER_ERROR_WRITE,
	GTK_RECENT_MANAGER_ERROR_UNKNOWN
}
