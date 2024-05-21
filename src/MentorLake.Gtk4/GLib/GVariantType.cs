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


public static class GVariantTypeHandleExtensions
{
	public static GVariantTypeHandle Copy(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_copy(type);
	}

	public static string DupString(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_dup_string(type);
	}

	public static GVariantTypeHandle Element(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_element(type);
	}

	public static bool Equal(this IntPtr type1, IntPtr type2)
	{
		return GVariantTypeExterns.g_variant_type_equal(type1, type2);
	}

	public static GVariantTypeHandle First(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_first(type);
	}

	public static GVariantTypeHandle Free(this GVariantTypeHandle type)
	{
		GVariantTypeExterns.g_variant_type_free(type);
		return type;
	}

	public static UIntPtr GetStringLength(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_get_string_length(type);
	}

	public static uint Hash(this IntPtr type)
	{
		return GVariantTypeExterns.g_variant_type_hash(type);
	}

	public static bool IsArray(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_array(type);
	}

	public static bool IsBasic(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_basic(type);
	}

	public static bool IsContainer(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_container(type);
	}

	public static bool IsDefinite(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_definite(type);
	}

	public static bool IsDictEntry(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_dict_entry(type);
	}

	public static bool IsMaybe(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_maybe(type);
	}

	public static bool IsSubtypeOf(this GVariantTypeHandle type, GVariantTypeHandle supertype)
	{
		return GVariantTypeExterns.g_variant_type_is_subtype_of(type, supertype);
	}

	public static bool IsTuple(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_tuple(type);
	}

	public static bool IsVariant(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_variant(type);
	}

	public static GVariantTypeHandle Key(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_key(type);
	}

	public static UIntPtr NItems(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_n_items(type);
	}

	public static GVariantTypeHandle Next(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_next(type);
	}

	public static string PeekString(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_peek_string(type);
	}

	public static GVariantTypeHandle Value(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_value(type);
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

	[DllImport(Libraries.GLib)]
	internal static extern GVariantTypeHandle g_variant_type_copy(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern string g_variant_type_dup_string(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantTypeHandle g_variant_type_element(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_type_equal(IntPtr type1, IntPtr type2);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantTypeHandle g_variant_type_first(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_type_free(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern UIntPtr g_variant_type_get_string_length(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_variant_type_hash(IntPtr type);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_type_is_array(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_type_is_basic(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_type_is_container(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_type_is_definite(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_type_is_dict_entry(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_type_is_maybe(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_type_is_subtype_of(GVariantTypeHandle type, GVariantTypeHandle supertype);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_type_is_tuple(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_type_is_variant(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantTypeHandle g_variant_type_key(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern UIntPtr g_variant_type_n_items(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantTypeHandle g_variant_type_next(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern string g_variant_type_peek_string(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantTypeHandle g_variant_type_value(GVariantTypeHandle type);

}

public struct GVariantType
{
}
