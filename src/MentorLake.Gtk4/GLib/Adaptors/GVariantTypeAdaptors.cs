using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GVariantTypeAdaptors
{
	public static GVariantTypeHandle Free(this GVariantTypeHandle type)
	{
		GVariantTypeExterns.g_variant_type_free(type);
		return type;
	}

	public static GVariantTypeHandle Copy(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_copy(type);
	}

	public static nuint GetStringLength(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_get_string_length(type);
	}

	public static string PeekString(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_peek_string(type);
	}

	public static string DupString(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_dup_string(type);
	}

	public static int IsDefinite(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_definite(type);
	}

	public static int IsContainer(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_container(type);
	}

	public static int IsBasic(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_basic(type);
	}

	public static int IsMaybe(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_maybe(type);
	}

	public static int IsArray(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_array(type);
	}

	public static int IsTuple(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_tuple(type);
	}

	public static int IsDictEntry(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_dict_entry(type);
	}

	public static int IsVariant(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_is_variant(type);
	}

	public static int IsSubtypeOf(this GVariantTypeHandle type, GVariantTypeHandle supertype)
	{
		return GVariantTypeExterns.g_variant_type_is_subtype_of(type, supertype);
	}

	public static GVariantTypeHandle Element(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_element(type);
	}

	public static GVariantTypeHandle First(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_first(type);
	}

	public static GVariantTypeHandle Next(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_next(type);
	}

	public static nuint NItems(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_n_items(type);
	}

	public static GVariantTypeHandle Key(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_key(type);
	}

	public static GVariantTypeHandle Value(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_type_value(type);
	}

	public static GVariantTypeHandle NewArray(this GVariantTypeHandle element)
	{
		return GVariantTypeExterns.g_variant_type_new_array(element);
	}

	public static GVariantTypeHandle NewMaybe(this GVariantTypeHandle element)
	{
		return GVariantTypeExterns.g_variant_type_new_maybe(element);
	}

	public static GVariantTypeHandle NewDictEntry(this GVariantTypeHandle key, GVariantTypeHandle value)
	{
		return GVariantTypeExterns.g_variant_type_new_dict_entry(key, value);
	}

	public static GVariantHandle GVariantNewFixedArray(this GVariantTypeHandle element_type, IntPtr elements, nuint n_elements, nuint element_size)
	{
		return GVariantTypeExterns.g_variant_new_fixed_array(element_type, elements, n_elements, element_size);
	}

	public static GVariantHandle GVariantNewMaybe(this GVariantTypeHandle child_type, GVariantHandle child)
	{
		return GVariantTypeExterns.g_variant_new_maybe(child_type, child);
	}

	public static GVariantHandle GVariantNewArray(this GVariantTypeHandle child_type, GVariant children, nuint n_children)
	{
		return GVariantTypeExterns.g_variant_new_array(child_type, children, n_children);
	}

	public static GVariantHandle GVariantNewFromBytes(this GVariantTypeHandle type, GBytesHandle bytes, int trusted)
	{
		return GVariantTypeExterns.g_variant_new_from_bytes(type, bytes, trusted);
	}

	public static GVariantHandle GVariantNewFromData(this GVariantTypeHandle type, IntPtr data, nuint size, int trusted, GDestroyNotify notify, IntPtr user_data)
	{
		return GVariantTypeExterns.g_variant_new_from_data(type, data, size, trusted, notify, user_data);
	}

	public static GVariantBuilderHandle GVariantBuilderNew(this GVariantTypeHandle type)
	{
		return GVariantTypeExterns.g_variant_builder_new(type);
	}

	public static GVariantHandle GVariantParse(this GVariantTypeHandle type, string text, string limit, out string endptr, out GErrorHandle error)
	{
		return GVariantTypeExterns.g_variant_parse(type, text, limit, out endptr, out error);
	}
}
