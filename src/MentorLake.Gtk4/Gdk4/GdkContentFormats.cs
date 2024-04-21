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

namespace MentorLake.Gtk4.Gdk4;

public class GdkContentFormatsHandle : BaseSafeHandle
{
	public static GdkContentFormatsHandle New(string[] mime_types, uint n_mime_types)
	{
		return GdkContentFormatsExterns.gdk_content_formats_new(mime_types, n_mime_types);
	}

	public static GdkContentFormatsHandle NewForGtype(GType type)
	{
		return GdkContentFormatsExterns.gdk_content_formats_new_for_gtype(type);
	}

}

internal class GdkContentFormatsExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_content_formats_new(string[] mime_types, uint n_mime_types);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_content_formats_new_for_gtype(GType type);

}

public struct GdkContentFormats
{
}
