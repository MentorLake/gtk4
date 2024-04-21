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

namespace MentorLake.Gtk4.GObject;

internal class GlobalFunctionExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern GType g_type_from_name(string name);

	[DllImport(Libraries.GObject)]
	internal static extern uint g_type_get_type_registration_serial();

	[DllImport(Libraries.GObject)]
	internal static extern GClosureHandle g_signal_type_cclosure_new(GType itype, uint struct_offset);

	[DllImport(Libraries.GObject)]
	internal static extern GType g_type_fundamental_next();

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_ulong(string name, string nick, string blurb, ulong minimum, ulong maximum, ulong default_value, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern GQuark g_type_qname(GType type);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_signal_parse_name(string detailed_signal, GType itype, out uint signal_id_p, out GQuark detail_p, bool force_detail_quark);

	[DllImport(Libraries.GObject)]
	internal static extern string g_flags_to_string(GType flags_type, uint value);

	[DllImport(Libraries.GObject)]
	internal static extern GTypeInterfaceHandle g_type_default_interface_peek(GType g_type);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_ensure(GType type);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_type_check_instance(GTypeInstanceHandle instance);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_add_class_cache_func(IntPtr cache_data, GTypeClassCacheFunc cache_func);

	[DllImport(Libraries.GObject)]
	internal static extern GTypeInstanceHandle g_type_check_instance_cast(GTypeInstanceHandle instance, GType iface_type);

	[DllImport(Libraries.GObject)]
	internal static extern GEnumValueHandle g_enum_get_value(GEnumClassHandle enum_class, int value);

	[DllImport(Libraries.GObject)]
	internal static extern GFlagsValueHandle g_flags_get_value_by_name(GFlagsClassHandle flags_class, string name);

	[DllImport(Libraries.GObject)]
	internal static extern string g_signal_name(uint signal_id);

	[DllImport(Libraries.GObject)]
	internal static extern GType g_gtype_get_type();

	[DllImport(Libraries.GObject)]
	internal static extern GType g_type_fundamental(GType type_id);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_chain_from_overridden(GValue[] instance_and_params, GValueHandle return_value);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_boxed_copy(GType boxed_type, IntPtr src_boxed);

	[DllImport(Libraries.GObject)]
	internal static extern string g_type_name(GType type);

	[DllImport(Libraries.GObject)]
	internal static extern void g_source_set_closure(GSourceHandle source, GClosureHandle closure);

	[DllImport(Libraries.GObject)]
	internal static extern string g_strdup_value_contents(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern GType g_boxed_type_register_static(string name, GBoxedCopyFunc boxed_copy, GBoxedFreeFunc boxed_free);

	[DllImport(Libraries.GObject)]
	internal static extern GType g_flags_register_static(string name, GFlagsValue[] const_static_values);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_param(string name, string nick, string blurb, GType param_type, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern GFlagsValueHandle g_flags_get_value_by_nick(GFlagsClassHandle flags_class, string nick);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_type_test_flags(GType type, uint flags);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_init_with_debug_flags(GTypeDebugFlags debug_flags);

	[DllImport(Libraries.GObject)]
	internal static extern void g_clear_object(ref GObjectHandle object_ptr);

	[DllImport(Libraries.GObject)]
	internal static extern uint g_type_depth(GType type);

	[DllImport(Libraries.GObject)]
	internal static extern uint g_signal_new(string signal_name, GType itype, GSignalFlags signal_flags, uint class_offset, GSignalAccumulator accumulator, IntPtr accu_data, GSignalCMarshaller c_marshaller, GType return_type, uint n_params, IntPtr @__arglist);

	[DllImport(Libraries.GObject)]
	internal static extern void g_clear_signal_handler(ref ulong handler_id_ptr, GObjectHandle instance);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_variant(string name, string nick, string blurb, GVariantTypeHandle type, GVariantHandle default_value, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern GType g_enum_register_static(string name, GEnumValue[] const_static_values);

	[DllImport(Libraries.GObject)]
	internal static extern GType g_type_register_dynamic(GType parent_type, string type_name, GTypePluginHandle plugin, GTypeFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern ulong g_signal_add_emission_hook(uint signal_id, GQuark detail, GSignalEmissionHook hook_func, IntPtr hook_data, GDestroyNotify data_destroy);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_int64(string name, string nick, string blurb, long minimum, long maximum, long default_value, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_boxed(string name, string nick, string blurb, GType boxed_type, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_value_array(string name, string nick, string blurb, GParamSpecHandle element_spec, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_signal_is_valid_name(string name);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_object(string name, string nick, string blurb, GType object_type, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_uchar(string name, string nick, string blurb, byte minimum, byte maximum, byte default_value, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern GTypeInstanceHandle g_type_create_instance(GType type);

	[DllImport(Libraries.GObject)]
	internal static extern GFlagsValueHandle g_flags_get_first_value(GFlagsClassHandle flags_class, uint value);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_uint(string name, string nick, string blurb, uint minimum, uint maximum, uint default_value, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_unichar(string name, string nick, string blurb, char default_value, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_double(string name, string nick, string blurb, double minimum, double maximum, double default_value, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern GTypePluginHandle g_type_get_plugin(GType type);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_type_check_class_is_a(GTypeClassHandle g_class, GType is_a_type);

	[DllImport(Libraries.GObject)]
	internal static extern string g_type_name_from_class(GTypeClassHandle g_class);

	[DllImport(Libraries.GObject)]
	internal static extern GType g_type_parent(GType type);

	[DllImport(Libraries.GObject)]
	internal static extern int g_type_get_instance_count(GType type);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_string(string name, string nick, string blurb, string default_value, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_float(string name, string nick, string blurb, float minimum, float maximum, float default_value, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_signal_accumulator_first_wins(GSignalInvocationHintHandle ihint, GValueHandle return_accu, GValueHandle handler_return, IntPtr dummy);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_int(string name, string nick, string blurb, int minimum, int maximum, int default_value, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern string g_type_name_from_instance(GTypeInstanceHandle instance);

	[DllImport(Libraries.GObject)]
	internal static extern int g_type_add_instance_private(GType class_type, int private_size);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_boolean(string name, string nick, string blurb, bool default_value, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern GType g_variant_get_gtype();

	[DllImport(Libraries.GObject)]
	internal static extern GType g_type_next_base(GType leaf_type, GType root_type);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_add_interface_dynamic(GType instance_type, GType interface_type, GTypePluginHandle plugin);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_add_interface_static(GType instance_type, GType interface_type, GInterfaceInfoHandle info);

	[DllImport(Libraries.GObject)]
	internal static extern GEnumValueHandle g_enum_get_value_by_nick(GEnumClassHandle enum_class, string nick);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_override(string name, GParamSpecHandle overridden);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_add_interface_check(IntPtr check_data, GTypeInterfaceCheckFunc check_func);

	[DllImport(Libraries.GObject)]
	internal static extern GType g_type_register_static_simple(GType parent_type, string type_name, uint class_size, GClassInitFunc class_init, uint instance_size, GInstanceInitFunc instance_init, GTypeFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_type_check_instance_is_fundamentally_a(GTypeInstanceHandle instance, GType fundamental_type);

	[DllImport(Libraries.GObject)]
	internal static extern void g_source_set_dummy_callback(GSourceHandle source);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_enum(string name, string nick, string blurb, GType enum_type, int default_value, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_pointer(string name, string nick, string blurb, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_set_qdata(GType type, GQuark quark, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_char(string name, string nick, string blurb, byte minimum, byte maximum, byte default_value, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_gtype(string name, string nick, string blurb, GType is_a_type, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern void g_flags_complete_type_info(GType g_flags_type, out GTypeInfo info, GFlagsValue[] const_values);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_remove_emission_hook(uint signal_id, ulong hook_id);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_type_check_is_value_type(GType type);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_type_get_qdata(GType type, GQuark quark);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_default_interface_unref(GTypeInterfaceHandle g_iface);

	[DllImport(Libraries.GObject)]
	internal static extern GType g_param_type_register_static(string name, GParamSpecTypeInfoHandle pspec_info);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_override_class_handler(string signal_name, GType instance_type, IntPtr class_handler);

	[DllImport(Libraries.GObject)]
	internal static extern GType g_type_register_static(GType parent_type, string type_name, GTypeInfoHandle info, GTypeFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_type_check_value_holds(GValueHandle value, GType type);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_chain_from_overridden_handler(GTypeInstanceHandle instance, IntPtr @__arglist);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_query(GType type, out GTypeQuery query);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_init();

	[DllImport(Libraries.GObject)]
	internal static extern GType[] g_type_interfaces(GType type, out uint n_interfaces);

	[DllImport(Libraries.GObject)]
	internal static extern GTypeInterfaceHandle g_type_default_interface_ref(GType g_type);

	[DllImport(Libraries.GObject)]
	internal static extern uint[] g_signal_list_ids(GType itype, out uint n_ids);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_free_instance(GTypeInstanceHandle instance);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_remove_class_cache_func(IntPtr cache_data, GTypeClassCacheFunc cache_func);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_flags(string name, string nick, string blurb, GType flags_type, uint default_value, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_type_check_value(GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_override_class_closure(uint signal_id, GType instance_type, GClosureHandle class_closure);

	[DllImport(Libraries.GObject)]
	internal static extern uint g_signal_new_class_handler(string signal_name, GType itype, GSignalFlags signal_flags, IntPtr class_handler, GSignalAccumulator accumulator, IntPtr accu_data, GSignalCMarshaller c_marshaller, GType return_type, uint n_params, IntPtr @__arglist);

	[DllImport(Libraries.GObject)]
	internal static extern void g_boxed_free(GType boxed_type, IntPtr boxed);

	[DllImport(Libraries.GObject)]
	internal static extern void g_enum_complete_type_info(GType g_enum_type, out GTypeInfo info, GEnumValue[] const_values);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_set_va_marshaller(uint signal_id, GType instance_type, GSignalCVaMarshaller va_marshaller);

	[DllImport(Libraries.GObject)]
	internal static extern uint g_signal_lookup(string name, GType itype);

	[DllImport(Libraries.GObject)]
	internal static extern GType[] g_type_children(GType type, out uint n_children);

	[DllImport(Libraries.GObject)]
	internal static extern GType g_pointer_type_register_static(string name);

	[DllImport(Libraries.GObject)]
	internal static extern GEnumValueHandle g_enum_get_value_by_name(GEnumClassHandle enum_class, string name);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_type_is_a(GType type, GType is_a_type);

	[DllImport(Libraries.GObject)]
	internal static extern uint g_signal_newv(string signal_name, GType itype, GSignalFlags signal_flags, GClosureHandle class_closure, GSignalAccumulator accumulator, IntPtr accu_data, GSignalCMarshaller c_marshaller, GType return_type, uint n_params, GType[] param_types);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_emitv(GValue[] instance_and_params, uint signal_id, GQuark detail, GValueHandle return_value);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_long(string name, string nick, string blurb, long minimum, long maximum, long default_value, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern ulong g_signal_connect_object(GTypeInstanceHandle instance, string detailed_signal, IntPtr c_handler, GObjectHandle gobject, GConnectFlags connect_flags);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_remove_interface_check(IntPtr check_data, GTypeInterfaceCheckFunc check_func);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_add_class_private(GType class_type, int private_size);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_signal_accumulator_true_handled(GSignalInvocationHintHandle ihint, GValueHandle return_accu, GValueHandle handler_return, IntPtr dummy);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_emit_valist(GTypeInstanceHandle instance, uint signal_id, GQuark detail, IntPtr var_args);

	[DllImport(Libraries.GObject)]
	internal static extern GType g_type_register_fundamental(GType type_id, string type_name, GTypeInfoHandle info, GTypeFundamentalInfoHandle finfo, GTypeFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern GTypeClassHandle g_type_check_class_cast(GTypeClassHandle g_class, GType is_a_type);

	[DllImport(Libraries.GObject)]
	internal static extern string g_enum_to_string(GType g_enum_type, int value);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_param_spec_uint64(string name, string nick, string blurb, ulong minimum, ulong maximum, ulong default_value, GParamFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_type_check_instance_is_a(GTypeInstanceHandle instance, GType iface_type);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_query(uint signal_id, out GSignalQuery query);

	[DllImport(Libraries.GObject)]
	internal static extern uint g_signal_new_valist(string signal_name, GType itype, GSignalFlags signal_flags, GClosureHandle class_closure, GSignalAccumulator accumulator, IntPtr accu_data, GSignalCMarshaller c_marshaller, GType return_type, uint n_params, IntPtr args);

}
