namespace MentorLake.Gtk4.GLib;

public class GVariantHandle : BaseSafeHandle
{
	public static GVariantHandle New(string format_string, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new(format_string, @__arglist);
	}

	public static GVariantHandle NewArray(GVariantTypeHandle child_type, GVariant[] children, UIntPtr n_children)
	{
		return GVariantExterns.g_variant_new_array(child_type, children, n_children);
	}

	public static GVariantHandle NewBoolean(bool value)
	{
		return GVariantExterns.g_variant_new_boolean(value);
	}

	public static GVariantHandle NewByte(byte value)
	{
		return GVariantExterns.g_variant_new_byte(value);
	}

	public static GVariantHandle NewBytestring(string @string)
	{
		return GVariantExterns.g_variant_new_bytestring(@string);
	}

	public static GVariantHandle NewBytestringArray(string strv, UIntPtr length)
	{
		return GVariantExterns.g_variant_new_bytestring_array(strv, length);
	}

	public static GVariantHandle NewDictEntry(GVariantHandle key, GVariantHandle value)
	{
		return GVariantExterns.g_variant_new_dict_entry(key, value);
	}

	public static GVariantHandle NewDouble(double value)
	{
		return GVariantExterns.g_variant_new_double(value);
	}

	public static GVariantHandle NewFixedArray(GVariantTypeHandle element_type, IntPtr elements, UIntPtr n_elements, UIntPtr element_size)
	{
		return GVariantExterns.g_variant_new_fixed_array(element_type, elements, n_elements, element_size);
	}

	public static GVariantHandle NewFromBytes(GVariantTypeHandle type, GBytesHandle bytes, bool trusted)
	{
		return GVariantExterns.g_variant_new_from_bytes(type, bytes, trusted);
	}

	public static GVariantHandle NewFromData(GVariantTypeHandle type, IntPtr data, UIntPtr size, bool trusted, GDestroyNotify notify, IntPtr user_data)
	{
		return GVariantExterns.g_variant_new_from_data(type, data, size, trusted, notify, user_data);
	}

	public static GVariantHandle NewHandle(int value)
	{
		return GVariantExterns.g_variant_new_handle(value);
	}

	public static GVariantHandle NewInt16(short value)
	{
		return GVariantExterns.g_variant_new_int16(value);
	}

	public static GVariantHandle NewInt32(int value)
	{
		return GVariantExterns.g_variant_new_int32(value);
	}

	public static GVariantHandle NewInt64(long value)
	{
		return GVariantExterns.g_variant_new_int64(value);
	}

	public static GVariantHandle NewMaybe(GVariantTypeHandle child_type, GVariantHandle child)
	{
		return GVariantExterns.g_variant_new_maybe(child_type, child);
	}

	public static GVariantHandle NewObjectPath(string object_path)
	{
		return GVariantExterns.g_variant_new_object_path(object_path);
	}

	public static GVariantHandle NewObjv(string strv, UIntPtr length)
	{
		return GVariantExterns.g_variant_new_objv(strv, length);
	}

	public static GVariantHandle NewParsed(string format, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new_parsed(format, @__arglist);
	}

	public static GVariantHandle NewParsedVa(string format, IntPtr app)
	{
		return GVariantExterns.g_variant_new_parsed_va(format, app);
	}

	public static GVariantHandle NewPrintf(string format_string, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new_printf(format_string, @__arglist);
	}

	public static GVariantHandle NewSignature(string signature)
	{
		return GVariantExterns.g_variant_new_signature(signature);
	}

	public static GVariantHandle NewString(string @string)
	{
		return GVariantExterns.g_variant_new_string(@string);
	}

	public static GVariantHandle NewStrv(string strv, UIntPtr length)
	{
		return GVariantExterns.g_variant_new_strv(strv, length);
	}

	public static GVariantHandle NewTakeString(string @string)
	{
		return GVariantExterns.g_variant_new_take_string(@string);
	}

	public static GVariantHandle NewTuple(GVariant[] children, UIntPtr n_children)
	{
		return GVariantExterns.g_variant_new_tuple(children, n_children);
	}

	public static GVariantHandle NewUint16(ushort value)
	{
		return GVariantExterns.g_variant_new_uint16(value);
	}

	public static GVariantHandle NewUint32(uint value)
	{
		return GVariantExterns.g_variant_new_uint32(value);
	}

	public static GVariantHandle NewUint64(ulong value)
	{
		return GVariantExterns.g_variant_new_uint64(value);
	}

	public static GVariantHandle NewVa(string format_string, ref string endptr, IntPtr app)
	{
		return GVariantExterns.g_variant_new_va(format_string, ref endptr, app);
	}

	public static GVariantHandle NewVariant(GVariantHandle value)
	{
		return GVariantExterns.g_variant_new_variant(value);
	}

}


public static class GVariantHandleExtensions
{
	public static GVariantHandle Byteswap(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_byteswap(value);
	}

	public static bool CheckFormatString(this GVariantHandle value, string format_string, bool copy_only)
	{
		return GVariantExterns.g_variant_check_format_string(value, format_string, copy_only);
	}

	public static GVariantClass Classify(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_classify(value);
	}

	public static int Compare(this IntPtr one, IntPtr two)
	{
		return GVariantExterns.g_variant_compare(one, two);
	}

	public static IntPtr DupBytestring(this GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_dup_bytestring(value, out length);
	}

	public static IntPtr DupBytestringArray(this GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_dup_bytestring_array(value, out length);
	}

	public static IntPtr DupObjv(this GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_dup_objv(value, out length);
	}

	public static string DupString(this GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_dup_string(value, out length);
	}

	public static IntPtr DupStrv(this GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_dup_strv(value, out length);
	}

	public static bool Equal(this IntPtr one, IntPtr two)
	{
		return GVariantExterns.g_variant_equal(one, two);
	}

	public static GVariantHandle Get(this GVariantHandle value, string format_string, IntPtr @__arglist)
	{
		GVariantExterns.g_variant_get(value, format_string, @__arglist);
		return value;
	}

	public static bool GetBoolean(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_boolean(value);
	}

	public static byte GetByte(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_byte(value);
	}

	public static IntPtr GetBytestring(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_bytestring(value);
	}

	public static IntPtr GetBytestringArray(this GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_get_bytestring_array(value, out length);
	}

	public static GVariantHandle GetChild(this GVariantHandle value, UIntPtr index_, string format_string, IntPtr @__arglist)
	{
		GVariantExterns.g_variant_get_child(value, index_, format_string, @__arglist);
		return value;
	}

	public static GVariantHandle GetChildValue(this GVariantHandle value, UIntPtr index_)
	{
		return GVariantExterns.g_variant_get_child_value(value, index_);
	}

	public static IntPtr GetData(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_data(value);
	}

	public static GBytesHandle GetDataAsBytes(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_data_as_bytes(value);
	}

	public static double GetDouble(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_double(value);
	}

	public static IntPtr GetFixedArray(this GVariantHandle value, out UIntPtr n_elements, UIntPtr element_size)
	{
		return GVariantExterns.g_variant_get_fixed_array(value, out n_elements, element_size);
	}

	public static int GetHandle(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_handle(value);
	}

	public static short GetInt16(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_int16(value);
	}

	public static int GetInt32(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_int32(value);
	}

	public static long GetInt64(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_int64(value);
	}

	public static GVariantHandle GetMaybe(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_maybe(value);
	}

	public static GVariantHandle GetNormalForm(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_normal_form(value);
	}

	public static IntPtr GetObjv(this GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_get_objv(value, out length);
	}

	public static UIntPtr GetSize(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_size(value);
	}

	public static string GetString(this GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_get_string(value, out length);
	}

	public static IntPtr GetStrv(this GVariantHandle value, out UIntPtr length)
	{
		return GVariantExterns.g_variant_get_strv(value, out length);
	}

	public static GVariantTypeHandle GetType(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_type(value);
	}

	public static string GetTypeString(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_type_string(value);
	}

	public static ushort GetUint16(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_uint16(value);
	}

	public static uint GetUint32(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_uint32(value);
	}

	public static ulong GetUint64(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_uint64(value);
	}

	public static GVariantHandle GetVa(this GVariantHandle value, string format_string, ref string endptr, IntPtr app)
	{
		GVariantExterns.g_variant_get_va(value, format_string, ref endptr, app);
		return value;
	}

	public static GVariantHandle GetVariant(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_get_variant(value);
	}

	public static uint Hash(this IntPtr value)
	{
		return GVariantExterns.g_variant_hash(value);
	}

	public static bool IsContainer(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_is_container(value);
	}

	public static bool IsFloating(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_is_floating(value);
	}

	public static bool IsNormalForm(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_is_normal_form(value);
	}

	public static bool IsOfType(this GVariantHandle value, GVariantTypeHandle type)
	{
		return GVariantExterns.g_variant_is_of_type(value, type);
	}

	public static GVariantIterHandle IterNew(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_iter_new(value);
	}

	public static bool Lookup(this GVariantHandle dictionary, string key, string format_string, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_lookup(dictionary, key, format_string, @__arglist);
	}

	public static GVariantHandle LookupValue(this GVariantHandle dictionary, string key, GVariantTypeHandle expected_type)
	{
		return GVariantExterns.g_variant_lookup_value(dictionary, key, expected_type);
	}

	public static UIntPtr NChildren(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_n_children(value);
	}

	public static string Print(this GVariantHandle value, bool type_annotate)
	{
		return GVariantExterns.g_variant_print(value, type_annotate);
	}

	public static GStringHandle PrintString(this GVariantHandle value, GStringHandle @string, bool type_annotate)
	{
		return GVariantExterns.g_variant_print_string(value, @string, type_annotate);
	}

	public static GVariantHandle Ref(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_ref(value);
	}

	public static GVariantHandle RefSink(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_ref_sink(value);
	}

	public static GVariantHandle Store(this GVariantHandle value, IntPtr data)
	{
		GVariantExterns.g_variant_store(value, data);
		return value;
	}

	public static GVariantHandle TakeRef(this GVariantHandle value)
	{
		return GVariantExterns.g_variant_take_ref(value);
	}

	public static GVariantHandle Unref(this GVariantHandle value)
	{
		GVariantExterns.g_variant_unref(value);
		return value;
	}

}
internal class GVariantExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new(string format_string, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_array(GVariantTypeHandle child_type, GVariant[] children, UIntPtr n_children);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_boolean(bool value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_byte(byte value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_bytestring(string @string);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_bytestring_array(string strv, UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_dict_entry(GVariantHandle key, GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_double(double value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_fixed_array(GVariantTypeHandle element_type, IntPtr elements, UIntPtr n_elements, UIntPtr element_size);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_from_bytes(GVariantTypeHandle type, GBytesHandle bytes, bool trusted);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_from_data(GVariantTypeHandle type, IntPtr data, UIntPtr size, bool trusted, GDestroyNotify notify, IntPtr user_data);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_handle(int value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_int16(short value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_int32(int value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_int64(long value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_maybe(GVariantTypeHandle child_type, GVariantHandle child);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_object_path(string object_path);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_objv(string strv, UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_parsed(string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_parsed_va(string format, IntPtr app);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_printf(string format_string, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_signature(string signature);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_string(string @string);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_strv(string strv, UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_take_string(string @string);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_tuple(GVariant[] children, UIntPtr n_children);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_uint16(ushort value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_uint32(uint value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_uint64(ulong value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_va(string format_string, ref string endptr, IntPtr app);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_variant(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_byteswap(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_check_format_string(GVariantHandle value, string format_string, bool copy_only);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantClass g_variant_classify(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern int g_variant_compare(IntPtr one, IntPtr two);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_variant_dup_bytestring(GVariantHandle value, out UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_variant_dup_bytestring_array(GVariantHandle value, out UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_variant_dup_objv(GVariantHandle value, out UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern string g_variant_dup_string(GVariantHandle value, out UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_variant_dup_strv(GVariantHandle value, out UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_equal(IntPtr one, IntPtr two);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_get(GVariantHandle value, string format_string, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_get_boolean(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern byte g_variant_get_byte(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_variant_get_bytestring(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_variant_get_bytestring_array(GVariantHandle value, out UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_get_child(GVariantHandle value, UIntPtr index_, string format_string, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_get_child_value(GVariantHandle value, UIntPtr index_);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_variant_get_data(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern GBytesHandle g_variant_get_data_as_bytes(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern double g_variant_get_double(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_variant_get_fixed_array(GVariantHandle value, out UIntPtr n_elements, UIntPtr element_size);

	[DllImport(Libraries.GLib)]
	internal static extern int g_variant_get_handle(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern short g_variant_get_int16(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern int g_variant_get_int32(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern long g_variant_get_int64(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_get_maybe(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_get_normal_form(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_variant_get_objv(GVariantHandle value, out UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern UIntPtr g_variant_get_size(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern string g_variant_get_string(GVariantHandle value, out UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_variant_get_strv(GVariantHandle value, out UIntPtr length);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantTypeHandle g_variant_get_type(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern string g_variant_get_type_string(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern ushort g_variant_get_uint16(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_variant_get_uint32(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern ulong g_variant_get_uint64(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_get_va(GVariantHandle value, string format_string, ref string endptr, IntPtr app);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_get_variant(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern uint g_variant_hash(IntPtr value);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_is_container(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_is_floating(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_is_normal_form(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_is_of_type(GVariantHandle value, GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantIterHandle g_variant_iter_new(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_variant_lookup(GVariantHandle dictionary, string key, string format_string, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_lookup_value(GVariantHandle dictionary, string key, GVariantTypeHandle expected_type);

	[DllImport(Libraries.GLib)]
	internal static extern UIntPtr g_variant_n_children(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern string g_variant_print(GVariantHandle value, bool type_annotate);

	[DllImport(Libraries.GLib)]
	internal static extern GStringHandle g_variant_print_string(GVariantHandle value, GStringHandle @string, bool type_annotate);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_ref(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_ref_sink(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_store(GVariantHandle value, IntPtr data);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_take_ref(GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_unref(GVariantHandle value);

}

public struct GVariant
{
}
