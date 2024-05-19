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

[Flags]
public enum GDBusConnectionFlags
{
	G_DBUS_CONNECTION_FLAGS_NONE = 0,
	G_DBUS_CONNECTION_FLAGS_AUTHENTICATION_CLIENT = 1,
	G_DBUS_CONNECTION_FLAGS_AUTHENTICATION_SERVER = 2,
	G_DBUS_CONNECTION_FLAGS_AUTHENTICATION_ALLOW_ANONYMOUS = 4,
	G_DBUS_CONNECTION_FLAGS_MESSAGE_BUS_CONNECTION = 8,
	G_DBUS_CONNECTION_FLAGS_DELAY_MESSAGE_PROCESSING = 16,
	G_DBUS_CONNECTION_FLAGS_AUTHENTICATION_REQUIRE_SAME_USER = 32,
	G_DBUS_CONNECTION_FLAGS_CROSS_NAMESPACE = 64
}
