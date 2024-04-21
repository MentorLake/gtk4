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

public class GVariantTypeHandle : BaseSafeHandle
{
	public static GVariantTypeHandle New(string type_string)
	{
		return GVariantTypeExterns.g_variant_type_new(type_string);
	}

	public static GVariantTypeHandle NewArray(GVariantTypeHandle element)
	{
		return GVariantTypeExterns.g_variant_type_new_array(element);
	}

	public static GVariantTypeHandle NewDictEntry(GVariantTypeHandle key, GVariantTypeHandle value)
	{
		return GVariantTypeExterns.g_variant_type_new_dict_entry(key, value);
	}

	public static GVariantTypeHandle NewMaybe(GVariantTypeHandle element)
	{
		return GVariantTypeExterns.g_variant_type_new_maybe(element);
	}

	public static GVariantTypeHandle NewTuple(GVariantType[] items, int length)
	{
		return GVariantTypeExterns.g_variant_type_new_tuple(items, length);
	}

}

internal class GVariantTypeExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GVariantTypeHandle g_variant_type_new(string type_string);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantTypeHandle g_variant_type_new_array(GVariantTypeHandle element);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantTypeHandle g_variant_type_new_dict_entry(GVariantTypeHandle key, GVariantTypeHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantTypeHandle g_variant_type_new_maybe(GVariantTypeHandle element);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantTypeHandle g_variant_type_new_tuple(GVariantType[] items, int length);

}

public struct GVariantType
{
}
