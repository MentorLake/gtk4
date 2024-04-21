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

public class GSettingsSchemaSourceHandle : BaseSafeHandle
{
	public static GSettingsSchemaSourceHandle NewFromDirectory(string directory, GSettingsSchemaSourceHandle parent, bool trusted, out GErrorHandle error)
	{
		return GSettingsSchemaSourceExterns.g_settings_schema_source_new_from_directory(directory, parent, trusted, out error);
	}

}

internal class GSettingsSchemaSourceExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSettingsSchemaSourceHandle g_settings_schema_source_new_from_directory(string directory, GSettingsSchemaSourceHandle parent, bool trusted, out GErrorHandle error);

}

public struct GSettingsSchemaSource
{
}
