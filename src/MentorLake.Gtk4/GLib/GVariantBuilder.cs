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

namespace MentorLake.Gtk4.GLib;

public class GVariantBuilderHandle : BaseSafeHandle
{
	public static GVariantBuilderHandle New(GVariantTypeHandle type)
	{
		return GVariantBuilderExterns.g_variant_builder_new(type);
	}

}

internal class GVariantBuilderExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GVariantBuilderHandle g_variant_builder_new(GVariantTypeHandle type);
}

public struct GVariantBuilder
{
}
