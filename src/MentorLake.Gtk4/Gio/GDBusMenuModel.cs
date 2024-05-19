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

public class GDBusMenuModelHandle : GMenuModelHandle
{
	public static GDBusMenuModelHandle GDbusMenuModelGet(GDBusConnectionHandle connection, string bus_name, string object_path)
	{
		return GDBusMenuModelExterns.g_dbus_menu_model_get(connection, bus_name, object_path);
	}

}

public static class GDBusMenuModelHandleExtensions
{
}

internal class GDBusMenuModelExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusMenuModelHandle g_dbus_menu_model_get(GDBusConnectionHandle connection, string bus_name, string object_path);

}
