using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;

public static class GValueExterns
{
	[DllImport(Libraries.GObject, EntryPoint = "g_type_check_value")]
	internal static extern int g_type_check_value(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_type_check_value_holds")]
	internal static extern int g_type_check_value_holds(this GValueHandle value, GType type);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_init")]
	internal static extern GValueHandle g_value_init(this GValueHandle value, GType g_type);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_copy")]
	internal static extern void g_value_copy(this GValueHandle src_value, GValueHandle dest_value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_reset")]
	internal static extern GValueHandle g_value_reset(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_unset")]
	internal static extern void g_value_unset(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_instance")]
	internal static extern void g_value_set_instance(this GValueHandle value, IntPtr instance);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_init_from_instance")]
	internal static extern void g_value_init_from_instance(this GValueHandle value, IntPtr instance);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_fits_pointer")]
	internal static extern int g_value_fits_pointer(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_peek_pointer")]
	internal static extern IntPtr g_value_peek_pointer(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_transform")]
	internal static extern int g_value_transform(this GValueHandle src_value, GValueHandle dest_value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_param")]
	internal static extern void g_value_set_param(this GValueHandle value, GParamSpecHandle param1);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_param")]
	internal static extern GParamSpecHandle g_value_get_param(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_dup_param")]
	internal static extern GParamSpecHandle g_value_dup_param(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_take_param")]
	internal static extern void g_value_take_param(this GValueHandle value, GParamSpecHandle param1);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_param_take_ownership")]
	[Obsolete]
		internal static extern void g_value_set_param_take_ownership(this GValueHandle value, GParamSpecHandle param1);

	[DllImport(Libraries.GObject, EntryPoint = "g_signal_emitv")]
	internal static extern void g_signal_emitv(this GValueHandle instance_and_params, uint signal_id, GQuark detail, GValueHandle return_value);

	[DllImport(Libraries.GObject, EntryPoint = "g_signal_chain_from_overridden")]
	internal static extern void g_signal_chain_from_overridden(this GValueHandle instance_and_params, GValueHandle return_value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_boxed")]
	internal static extern void g_value_set_boxed(this GValueHandle value, IntPtr v_boxed);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_static_boxed")]
	internal static extern void g_value_set_static_boxed(this GValueHandle value, IntPtr v_boxed);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_take_boxed")]
	internal static extern void g_value_take_boxed(this GValueHandle value, IntPtr v_boxed);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_boxed_take_ownership")]
	[Obsolete]
		internal static extern void g_value_set_boxed_take_ownership(this GValueHandle value, IntPtr v_boxed);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_boxed")]
	internal static extern IntPtr g_value_get_boxed(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_dup_boxed")]
	internal static extern IntPtr g_value_dup_boxed(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_object")]
	internal static extern void g_value_set_object(this GValueHandle value, IntPtr v_object);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_object")]
	internal static extern IntPtr g_value_get_object(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_dup_object")]
	internal static extern IntPtr g_value_dup_object(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_take_object")]
	internal static extern void g_value_take_object(this GValueHandle value, IntPtr v_object);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_object_take_ownership")]
	[Obsolete]
		internal static extern void g_value_set_object_take_ownership(this GValueHandle value, IntPtr v_object);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_enum")]
	internal static extern void g_value_set_enum(this GValueHandle value, int v_enum);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_enum")]
	internal static extern int g_value_get_enum(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_flags")]
	internal static extern void g_value_set_flags(this GValueHandle value, uint v_flags);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_flags")]
	internal static extern uint g_value_get_flags(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_char")]
	[Obsolete]
		internal static extern void g_value_set_char(this GValueHandle value, char v_char);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_char")]
	internal static extern char g_value_get_char(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_schar")]
	internal static extern void g_value_set_schar(this GValueHandle value, sbyte v_char);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_schar")]
	internal static extern sbyte g_value_get_schar(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_uchar")]
	internal static extern void g_value_set_uchar(this GValueHandle value, char v_uchar);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_uchar")]
	internal static extern char g_value_get_uchar(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_boolean")]
	internal static extern void g_value_set_boolean(this GValueHandle value, int v_boolean);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_boolean")]
	internal static extern int g_value_get_boolean(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_int")]
	internal static extern void g_value_set_int(this GValueHandle value, int v_int);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_int")]
	internal static extern int g_value_get_int(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_uint")]
	internal static extern void g_value_set_uint(this GValueHandle value, uint v_uint);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_uint")]
	internal static extern uint g_value_get_uint(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_long")]
	internal static extern void g_value_set_long(this GValueHandle value, nint v_long);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_long")]
	internal static extern nint g_value_get_long(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_ulong")]
	internal static extern void g_value_set_ulong(this GValueHandle value, nuint v_ulong);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_ulong")]
	internal static extern nuint g_value_get_ulong(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_int64")]
	internal static extern void g_value_set_int64(this GValueHandle value, nint v_int64);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_int64")]
	internal static extern nint g_value_get_int64(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_uint64")]
	internal static extern void g_value_set_uint64(this GValueHandle value, nuint v_uint64);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_uint64")]
	internal static extern nuint g_value_get_uint64(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_float")]
	internal static extern void g_value_set_float(this GValueHandle value, float v_float);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_float")]
	internal static extern float g_value_get_float(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_double")]
	internal static extern void g_value_set_double(this GValueHandle value, double v_double);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_double")]
	internal static extern double g_value_get_double(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_string")]
	internal static extern void g_value_set_string(this GValueHandle value, string v_string);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_static_string")]
	internal static extern void g_value_set_static_string(this GValueHandle value, string v_string);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_interned_string")]
	internal static extern void g_value_set_interned_string(this GValueHandle value, string v_string);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_string")]
	internal static extern string g_value_get_string(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_dup_string")]
	internal static extern string g_value_dup_string(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_pointer")]
	internal static extern void g_value_set_pointer(this GValueHandle value, IntPtr v_pointer);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_pointer")]
	internal static extern IntPtr g_value_get_pointer(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_gtype")]
	internal static extern void g_value_set_gtype(this GValueHandle value, GType v_gtype);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_gtype")]
	internal static extern GType g_value_get_gtype(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_variant")]
	internal static extern void g_value_set_variant(this GValueHandle value, GVariantHandle variant);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_take_variant")]
	internal static extern void g_value_take_variant(this GValueHandle value, GVariantHandle variant);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_get_variant")]
	internal static extern GVariantHandle g_value_get_variant(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_dup_variant")]
	internal static extern GVariantHandle g_value_dup_variant(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_strdup_value_contents")]
	internal static extern string g_strdup_value_contents(this GValueHandle value);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_take_string")]
	internal static extern void g_value_take_string(this GValueHandle value, string v_string);

	[DllImport(Libraries.GObject, EntryPoint = "g_value_set_string_take_ownership")]
	[Obsolete]
		internal static extern void g_value_set_string_take_ownership(this GValueHandle value, string v_string);
}
