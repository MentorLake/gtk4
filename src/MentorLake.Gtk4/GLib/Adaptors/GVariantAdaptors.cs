using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GVariantAdaptors
{
	public static GVariantHandle Unref(this GVariantHandle value)
	{
		GVariantExterns.g_variant_unref(value);
		return value;
	}

	public static GVariantHandle Ref(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_ref(value);
	}

	public static GVariantHandle RefSink(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_ref_sink(value);
	}

	public static int IsFloating(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_is_floating(value);
	}

	public static GVariantHandle TakeRef(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_take_ref(value);
	}

	public static GVariantTypeHandle GetType(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_type(value);
	}

	public static string GetTypeString(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_type_string(value);
	}

	public static int IsOfType(this GVariantHandle value, GVariantTypeHandle type)
	{
		return GVariantExterns.g_variant_is_of_type(value, type);
	}

	public static int IsContainer(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_is_container(value);
	}

	public static GVariantClass Classify(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_classify(value);
	}

	public static GVariantHandle NewVariant(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_new_variant(value);
	}

	public static int GetBoolean(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_boolean(value);
	}

	public static byte GetByte(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_byte(value);
	}

	public static short GetInt16(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_int16(value);
	}

	public static ushort GetUint16(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_uint16(value);
	}

	public static int GetInt32(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_int32(value);
	}

	public static uint GetUint32(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_uint32(value);
	}

	public static nint GetInt64(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_int64(value);
	}

	public static nuint GetUint64(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_uint64(value);
	}

	public static int GetHandle(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_handle(value);
	}

	public static double GetDouble(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_double(value);
	}

	public static GVariantHandle GetVariant(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_variant(value);
	}

	public static string GetString(this GVariantHandle value, out nuint length)
	{
		return GVariantExterns.g_variant_get_string(value, out length);
	}

	public static string DupString(this GVariantHandle value, out nuint length)
	{
		return GVariantExterns.g_variant_dup_string(value, out length);
	}

	public static string[] GetStrv(this GVariantHandle value, out nuint length)
	{
		return GVariantExterns.g_variant_get_strv(value, out length);
	}

	public static string[] DupStrv(this GVariantHandle value, out nuint length)
	{
		return GVariantExterns.g_variant_dup_strv(value, out length);
	}

	public static string[] GetObjv(this GVariantHandle value, out nuint length)
	{
		return GVariantExterns.g_variant_get_objv(value, out length);
	}

	public static string[] DupObjv(this GVariantHandle value, out nuint length)
	{
		return GVariantExterns.g_variant_dup_objv(value, out length);
	}

	public static string GetBytestring(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_bytestring(value);
	}

	public static string DupBytestring(this GVariantHandle value, out nuint length)
	{
		return GVariantExterns.g_variant_dup_bytestring(value, out length);
	}

	public static string[] GetBytestringArray(this GVariantHandle value, out nuint length)
	{
		return GVariantExterns.g_variant_get_bytestring_array(value, out length);
	}

	public static string[] DupBytestringArray(this GVariantHandle value, out nuint length)
	{
		return GVariantExterns.g_variant_dup_bytestring_array(value, out length);
	}

	public static GVariantHandle NewDictEntry(this GVariantHandle key, GVariantHandle value)
	{
		return GVariantExterns.g_variant_new_dict_entry(key, value);
	}

	public static GVariantHandle GetMaybe(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_maybe(value);
	}

	public static nuint NChildren(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_n_children(value);
	}

	public static GVariantHandle GetChild(this GVariantHandle value, nuint index_, string format_string, IntPtr @__argList)
	{
		GVariantExterns.g_variant_get_child(value, index_, format_string, @__argList);
		return value;
	}

	public static GVariantHandle GetChildValue(this GVariantHandle value, nuint index_)
	{
		return GVariantExterns.g_variant_get_child_value(value, index_);
	}

	public static int Lookup(this GVariantHandle dictionary, string key, string format_string, IntPtr @__argList)
	{
		return GVariantExterns.g_variant_lookup(dictionary, key, format_string, @__argList);
	}

	public static GVariantHandle LookupValue(this GVariantHandle dictionary, string key, GVariantTypeHandle expected_type)
	{
		return GVariantExterns.g_variant_lookup_value(dictionary, key, expected_type);
	}

	public static IntPtr[] GetFixedArray(this GVariantHandle value, out nuint n_elements, nuint element_size)
	{
		return GVariantExterns.g_variant_get_fixed_array(value, out n_elements, element_size);
	}

	public static nuint GetSize(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_size(value);
	}

	public static IntPtr GetData(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_data(value);
	}

	public static GBytesHandle GetDataAsBytes(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_data_as_bytes(value);
	}

	public static GVariantHandle Store(this GVariantHandle value, IntPtr data)
	{
		GVariantExterns.g_variant_store(value, data);
		return value;
	}

	public static string Print(this GVariantHandle value, int type_annotate)
	{
		return GVariantExterns.g_variant_print(value, type_annotate);
	}

	public static GStringHandle PrintString(this GVariantHandle value, GStringHandle @string, int type_annotate)
	{
		return GVariantExterns.g_variant_print_string(value, @string, type_annotate);
	}

	public static GVariantHandle GetNormalForm(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_normal_form(value);
	}

	public static int IsNormalForm(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_is_normal_form(value);
	}

	public static GVariantHandle Byteswap(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_byteswap(value);
	}

	public static GVariantIterHandle IterNew(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_iter_new(value);
	}

	public static GVariantHandle Get(this GVariantHandle value, string format_string, IntPtr @__argList)
	{
		GVariantExterns.g_variant_get(value, format_string, @__argList);
		return value;
	}

	public static GVariantHandle GetVa(this GVariantHandle value, string format_string, out string endptr, IntPtr @__argList)
	{
		GVariantExterns.g_variant_get_va(value, format_string, out endptr, @__argList);
		return value;
	}

	public static int CheckFormatString(this GVariantHandle value, string format_string, int copy_only)
	{
		return GVariantExterns.g_variant_check_format_string(value, format_string, copy_only);
	}

	public static GVariantDictHandle DictNew(this GVariantHandle from_asv)
	{
		return GVariantExterns.g_variant_dict_new(from_asv);
	}

	public static GVariantHandle NewByte(byte value)
	{
		return GVariantExterns.g_variant_new_byte(value);
	}

	public static GVariantHandle NewInt16(short value)
	{
		return GVariantExterns.g_variant_new_int16(value);
	}

	public static GVariantHandle NewUint16(ushort value)
	{
		return GVariantExterns.g_variant_new_uint16(value);
	}

	public static GVariantHandle NewInt32(int value)
	{
		return GVariantExterns.g_variant_new_int32(value);
	}

	public static GVariantHandle NewUint32(uint value)
	{
		return GVariantExterns.g_variant_new_uint32(value);
	}

	public static GVariantHandle NewInt64(nint value)
	{
		return GVariantExterns.g_variant_new_int64(value);
	}

	public static GVariantHandle NewUint64(nuint value)
	{
		return GVariantExterns.g_variant_new_uint64(value);
	}

	public static GVariantHandle NewHandle(int value)
	{
		return GVariantExterns.g_variant_new_handle(value);
	}

	public static GVariantHandle NewDouble(double value)
	{
		return GVariantExterns.g_variant_new_double(value);
	}

	public static GVariantHandle NewString(string @string)
	{
		return GVariantExterns.g_variant_new_string(@string);
	}

	public static GVariantHandle NewTakeString(string @string)
	{
		return GVariantExterns.g_variant_new_take_string(@string);
	}

	public static GVariantHandle NewPrintf(string format_string, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new_printf(format_string, @__arglist);
	}

	public static GVariantHandle NewObjectPath(string object_path)
	{
		return GVariantExterns.g_variant_new_object_path(object_path);
	}

	public static GVariantHandle NewSignature(string signature)
	{
		return GVariantExterns.g_variant_new_signature(signature);
	}

	public static GVariantHandle NewStrv(string strv, nint length)
	{
		return GVariantExterns.g_variant_new_strv(strv, length);
	}

	public static GVariantHandle NewObjv(string strv, nint length)
	{
		return GVariantExterns.g_variant_new_objv(strv, length);
	}

	public static GVariantHandle NewBytestring(string @string)
	{
		return GVariantExterns.g_variant_new_bytestring(@string);
	}

	public static GVariantHandle NewBytestringArray(string strv, nint length)
	{
		return GVariantExterns.g_variant_new_bytestring_array(strv, length);
	}

	public static GVariantHandle NewTuple(GVariant children, nuint n_children)
	{
		return GVariantExterns.g_variant_new_tuple(children, n_children);
	}

	public static GVariantHandle New(string format_string, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new(format_string, @__arglist);
	}

	public static GVariantHandle NewVa(string format_string, out string endptr, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new_va(format_string, out endptr, @__arglist);
	}

	public static GVariantHandle NewParsed(string format, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new_parsed(format, @__arglist);
	}

	public static GVariantHandle NewParsedVa(string format, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new_parsed_va(format, @__arglist);
	}
}
