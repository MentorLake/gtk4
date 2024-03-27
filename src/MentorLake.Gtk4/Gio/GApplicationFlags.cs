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
public enum GApplicationFlags
{
	G_APPLICATION_FLAGS_NONE = 0,
	G_APPLICATION_DEFAULT_FLAGS = 1,
	G_APPLICATION_IS_SERVICE = 2,
	G_APPLICATION_IS_LAUNCHER = 4,
	G_APPLICATION_HANDLES_OPEN = 8,
	G_APPLICATION_HANDLES_COMMAND_LINE = 16,
	G_APPLICATION_SEND_ENVIRONMENT = 32,
	G_APPLICATION_NON_UNIQUE = 64,
	G_APPLICATION_CAN_OVERRIDE_APP_ID = 128,
	G_APPLICATION_ALLOW_REPLACEMENT = 256,
	G_APPLICATION_REPLACE = 512
}
