using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;
public static class GdkContentFormatsAdaptors
{
	public static GdkContentFormatsHandle UnionDeserializeGtypes(this GdkContentFormatsHandle formats)
	{
		return GdkContentFormatsExterns.gdk_content_formats_union_deserialize_gtypes(formats);
	}

	public static GdkContentFormatsHandle UnionDeserializeMimeTypes(this GdkContentFormatsHandle formats)
	{
		return GdkContentFormatsExterns.gdk_content_formats_union_deserialize_mime_types(formats);
	}

	public static GdkContentFormatsHandle Ref(this GdkContentFormatsHandle formats)
	{
		return GdkContentFormatsExterns.gdk_content_formats_ref(formats);
	}

	public static GdkContentFormatsHandle Unref(this GdkContentFormatsHandle formats)
	{
		GdkContentFormatsExterns.gdk_content_formats_unref(formats);
		return formats;
	}

	public static GdkContentFormatsHandle Print(this GdkContentFormatsHandle formats, GStringHandle @string)
	{
		GdkContentFormatsExterns.gdk_content_formats_print(formats, @string);
		return formats;
	}

	public static string ToString(this GdkContentFormatsHandle formats)
	{
		return GdkContentFormatsExterns.gdk_content_formats_to_string(formats);
	}

	public static GTypeHandle GetGtypes(this GdkContentFormatsHandle formats, out nuint n_gtypes)
	{
		return GdkContentFormatsExterns.gdk_content_formats_get_gtypes(formats, out n_gtypes);
	}

	public static string GetMimeTypes(this GdkContentFormatsHandle formats, out nuint n_mime_types)
	{
		return GdkContentFormatsExterns.gdk_content_formats_get_mime_types(formats, out n_mime_types);
	}

	public static GdkContentFormatsHandle Union(this GdkContentFormatsHandle first, GdkContentFormatsHandle second)
	{
		return GdkContentFormatsExterns.gdk_content_formats_union(first, second);
	}

	public static int Match(this GdkContentFormatsHandle first, GdkContentFormatsHandle second)
	{
		return GdkContentFormatsExterns.gdk_content_formats_match(first, second);
	}

	public static GType MatchGtype(this GdkContentFormatsHandle first, GdkContentFormatsHandle second)
	{
		return GdkContentFormatsExterns.gdk_content_formats_match_gtype(first, second);
	}

	public static string MatchMimeType(this GdkContentFormatsHandle first, GdkContentFormatsHandle second)
	{
		return GdkContentFormatsExterns.gdk_content_formats_match_mime_type(first, second);
	}

	public static int ContainGtype(this GdkContentFormatsHandle formats, GType type)
	{
		return GdkContentFormatsExterns.gdk_content_formats_contain_gtype(formats, type);
	}

	public static int ContainMimeType(this GdkContentFormatsHandle formats, string mime_type)
	{
		return GdkContentFormatsExterns.gdk_content_formats_contain_mime_type(formats, mime_type);
	}

	public static GdkContentFormatsHandle UnionSerializeGtypes(this GdkContentFormatsHandle formats)
	{
		return GdkContentFormatsExterns.gdk_content_formats_union_serialize_gtypes(formats);
	}

	public static GdkContentFormatsHandle UnionSerializeMimeTypes(this GdkContentFormatsHandle formats)
	{
		return GdkContentFormatsExterns.gdk_content_formats_union_serialize_mime_types(formats);
	}

	public static GdkContentFormatsHandle NewForGtype(GType type)
	{
		return GdkContentFormatsExterns.gdk_content_formats_new_for_gtype(type);
	}
}
