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

namespace MentorLake.Gtk4.Gio;

public enum GDBusMessageHeaderField
{
	G_DBUS_MESSAGE_HEADER_FIELD_INVALID,
	G_DBUS_MESSAGE_HEADER_FIELD_PATH,
	G_DBUS_MESSAGE_HEADER_FIELD_INTERFACE,
	G_DBUS_MESSAGE_HEADER_FIELD_MEMBER,
	G_DBUS_MESSAGE_HEADER_FIELD_ERROR_NAME,
	G_DBUS_MESSAGE_HEADER_FIELD_REPLY_SERIAL,
	G_DBUS_MESSAGE_HEADER_FIELD_DESTINATION,
	G_DBUS_MESSAGE_HEADER_FIELD_SENDER,
	G_DBUS_MESSAGE_HEADER_FIELD_SIGNATURE,
	G_DBUS_MESSAGE_HEADER_FIELD_NUM_UNIX_FDS
}
