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

public class GtkSettingsHandle : GObjectHandle
{
}

public static class GtkSettingsSignals
{
}

public static class GtkSettingsHandleExtensions
{
	public static GtkSettingsHandle ResetProperty(this GtkSettingsHandle settings, string name)
	{
		GtkSettingsExterns.gtk_settings_reset_property(settings, name);
		return settings;
	}

}

internal class GtkSettingsExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_settings_reset_property(GtkSettingsHandle settings, string name);
}