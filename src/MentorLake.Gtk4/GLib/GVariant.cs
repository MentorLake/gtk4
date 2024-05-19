using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.GLib;

public class GVariantHandle : BaseSafeHandle
{
	public static GVariantHandle New(string format_string, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new(format_string, @__arglist);
	}

	public static GVariantHandle NewArray(GVariantTypeHandle child_type, GVariant[] children, int n_children)
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

	public static GVariantHandle NewBytestringArray(string strv, int length)
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

	public static GVariantHandle NewFixedArray(GVariantTypeHandle element_type, IntPtr elements, int n_elements, int element_size)
	{
		return GVariantExterns.g_variant_new_fixed_array(element_type, elements, n_elements, element_size);
	}

	public static GVariantHandle NewFromBytes(GVariantTypeHandle type, GBytesHandle bytes, bool trusted)
	{
		return GVariantExterns.g_variant_new_from_bytes(type, bytes, trusted);
	}

	public static GVariantHandle NewFromData(GVariantTypeHandle type, IntPtr data, int size, bool trusted, GDestroyNotify notify, IntPtr user_data)
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

	public static GVariantHandle NewObjv(string strv, int length)
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

	public static GVariantHandle NewStrv(string strv, int length)
	{
		return GVariantExterns.g_variant_new_strv(strv, length);
	}

	public static GVariantHandle NewTakeString(string @string)
	{
		return GVariantExterns.g_variant_new_take_string(@string);
	}

	public static GVariantHandle NewTuple(GVariant[] children, int n_children)
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

internal class GVariantExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new(string format_string, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_array(GVariantTypeHandle child_type, GVariant[] children, int n_children);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_boolean(bool value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_byte(byte value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_bytestring(string @string);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_bytestring_array(string strv, int length);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_dict_entry(GVariantHandle key, GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_double(double value);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_fixed_array(GVariantTypeHandle element_type, IntPtr elements, int n_elements, int element_size);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_from_bytes(GVariantTypeHandle type, GBytesHandle bytes, bool trusted);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_from_data(GVariantTypeHandle type, IntPtr data, int size, bool trusted, GDestroyNotify notify, IntPtr user_data);

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
	internal static extern GVariantHandle g_variant_new_objv(string strv, int length);

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
	internal static extern GVariantHandle g_variant_new_strv(string strv, int length);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_take_string(string @string);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_new_tuple(GVariant[] children, int n_children);

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

}

public struct GVariant
{
}
