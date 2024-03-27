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
public enum GSettingsBindFlags
{
	G_SETTINGS_BIND_DEFAULT = 0,
	G_SETTINGS_BIND_GET = 1,
	G_SETTINGS_BIND_SET = 2,
	G_SETTINGS_BIND_NO_SENSITIVITY = 4,
	G_SETTINGS_BIND_GET_NO_CHANGES = 8,
	G_SETTINGS_BIND_INVERT_BOOLEAN = 16
}
