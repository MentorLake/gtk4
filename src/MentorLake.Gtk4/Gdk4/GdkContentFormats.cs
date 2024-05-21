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


public static class GdkContentFormatsHandleExtensions
{
	public static bool ContainGtype(this GdkContentFormatsHandle formats, GType type)
	{
		return GdkContentFormatsExterns.gdk_content_formats_contain_gtype(formats, type);
	}

	public static bool ContainMimeType(this GdkContentFormatsHandle formats, string mime_type)
	{
		return GdkContentFormatsExterns.gdk_content_formats_contain_mime_type(formats, mime_type);
	}

	public static IntPtr GetGtypes(this GdkContentFormatsHandle formats, out UIntPtr n_gtypes)
	{
		return GdkContentFormatsExterns.gdk_content_formats_get_gtypes(formats, out n_gtypes);
	}

	public static IntPtr GetMimeTypes(this GdkContentFormatsHandle formats, out UIntPtr n_mime_types)
	{
		return GdkContentFormatsExterns.gdk_content_formats_get_mime_types(formats, out n_mime_types);
	}

	public static bool Match(this GdkContentFormatsHandle first, GdkContentFormatsHandle second)
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

	public static GdkContentFormatsHandle Print(this GdkContentFormatsHandle formats, GStringHandle @string)
	{
		GdkContentFormatsExterns.gdk_content_formats_print(formats, @string);
		return formats;
	}

	public static GdkContentFormatsHandle Ref(this GdkContentFormatsHandle formats)
	{
		return GdkContentFormatsExterns.gdk_content_formats_ref(formats);
	}

	public static string ToString(this GdkContentFormatsHandle formats)
	{
		return GdkContentFormatsExterns.gdk_content_formats_to_string(formats);
	}

	public static GdkContentFormatsHandle Union(this GdkContentFormatsHandle first, GdkContentFormatsHandle second)
	{
		return GdkContentFormatsExterns.gdk_content_formats_union(first, second);
	}

	public static GdkContentFormatsHandle UnionDeserializeGtypes(this GdkContentFormatsHandle formats)
	{
		return GdkContentFormatsExterns.gdk_content_formats_union_deserialize_gtypes(formats);
	}

	public static GdkContentFormatsHandle UnionDeserializeMimeTypes(this GdkContentFormatsHandle formats)
	{
		return GdkContentFormatsExterns.gdk_content_formats_union_deserialize_mime_types(formats);
	}

	public static GdkContentFormatsHandle UnionSerializeGtypes(this GdkContentFormatsHandle formats)
	{
		return GdkContentFormatsExterns.gdk_content_formats_union_serialize_gtypes(formats);
	}

	public static GdkContentFormatsHandle UnionSerializeMimeTypes(this GdkContentFormatsHandle formats)
	{
		return GdkContentFormatsExterns.gdk_content_formats_union_serialize_mime_types(formats);
	}

	public static GdkContentFormatsHandle Unref(this GdkContentFormatsHandle formats)
	{
		GdkContentFormatsExterns.gdk_content_formats_unref(formats);
		return formats;
	}

}
internal class GdkContentFormatsExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_content_formats_new(string[] mime_types, uint n_mime_types);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_content_formats_new_for_gtype(GType type);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_content_formats_contain_gtype(GdkContentFormatsHandle formats, GType type);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_content_formats_contain_mime_type(GdkContentFormatsHandle formats, string mime_type);

	[DllImport(Libraries.Gdk4)]
	internal static extern IntPtr gdk_content_formats_get_gtypes(GdkContentFormatsHandle formats, out UIntPtr n_gtypes);

	[DllImport(Libraries.Gdk4)]
	internal static extern IntPtr gdk_content_formats_get_mime_types(GdkContentFormatsHandle formats, out UIntPtr n_mime_types);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_content_formats_match(GdkContentFormatsHandle first, GdkContentFormatsHandle second);

	[DllImport(Libraries.Gdk4)]
	internal static extern GType gdk_content_formats_match_gtype(GdkContentFormatsHandle first, GdkContentFormatsHandle second);

	[DllImport(Libraries.Gdk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_content_formats_match_mime_type(GdkContentFormatsHandle first, GdkContentFormatsHandle second);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_formats_print(GdkContentFormatsHandle formats, GStringHandle @string);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_content_formats_ref(GdkContentFormatsHandle formats);

	[DllImport(Libraries.Gdk4)]
	internal static extern string gdk_content_formats_to_string(GdkContentFormatsHandle formats);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_content_formats_union(GdkContentFormatsHandle first, GdkContentFormatsHandle second);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_content_formats_union_deserialize_gtypes(GdkContentFormatsHandle formats);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_content_formats_union_deserialize_mime_types(GdkContentFormatsHandle formats);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_content_formats_union_serialize_gtypes(GdkContentFormatsHandle formats);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_content_formats_union_serialize_mime_types(GdkContentFormatsHandle formats);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_formats_unref(GdkContentFormatsHandle formats);

}

public struct GdkContentFormats
{
}
