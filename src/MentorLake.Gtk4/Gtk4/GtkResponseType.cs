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

public enum GtkResponseType
{
	GTK_RESPONSE_NONE,
	GTK_RESPONSE_REJECT,
	GTK_RESPONSE_ACCEPT,
	GTK_RESPONSE_DELETE_EVENT,
	GTK_RESPONSE_OK,
	GTK_RESPONSE_CANCEL,
	GTK_RESPONSE_CLOSE,
	GTK_RESPONSE_YES,
	GTK_RESPONSE_NO,
	GTK_RESPONSE_APPLY,
	GTK_RESPONSE_HELP
}
