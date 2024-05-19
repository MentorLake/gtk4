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
public enum GDBusProxyFlags
{
	G_DBUS_PROXY_FLAGS_NONE = 0,
	G_DBUS_PROXY_FLAGS_DO_NOT_LOAD_PROPERTIES = 1,
	G_DBUS_PROXY_FLAGS_DO_NOT_CONNECT_SIGNALS = 2,
	G_DBUS_PROXY_FLAGS_DO_NOT_AUTO_START = 4,
	G_DBUS_PROXY_FLAGS_GET_INVALIDATED_PROPERTIES = 8,
	G_DBUS_PROXY_FLAGS_DO_NOT_AUTO_START_AT_CONSTRUCTION = 16,
	G_DBUS_PROXY_FLAGS_NO_MATCH_RULE = 32
}
