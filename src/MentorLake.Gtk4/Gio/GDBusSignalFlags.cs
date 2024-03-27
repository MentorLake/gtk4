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

namespace MentorLake.Gtk4.Gio;

[Flags]
public enum GDBusSignalFlags
{
	G_DBUS_SIGNAL_FLAGS_NONE = 0,
	G_DBUS_SIGNAL_FLAGS_NO_MATCH_RULE = 1,
	G_DBUS_SIGNAL_FLAGS_MATCH_ARG0_NAMESPACE = 2,
	G_DBUS_SIGNAL_FLAGS_MATCH_ARG0_PATH = 4
}
