using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;

public static class Methods
{
	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void g_type_init();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void g_type_init_with_debug_flags(GTypeDebugFlags debug_flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_type_name(GType type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GQuark g_type_qname(GType type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_type_from_name(string name);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_type_parent(GType type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_type_depth(GType type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_type_next_base(GType leaf_type, GType root_type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_type_is_a(GType type, GType is_a_type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_type_class_ref(GType type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_type_class_peek(GType type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_type_class_peek_static(GType type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_type_class_unref(IntPtr g_class);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_type_class_peek_parent(IntPtr g_class);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_type_interface_peek_parent(IntPtr g_iface);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_type_default_interface_ref(GType g_type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_type_default_interface_peek(GType g_type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_type_default_interface_unref(IntPtr g_iface);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType[] g_type_children(GType type, out uint n_children);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType[] g_type_interfaces(GType type, out uint n_interfaces);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_type_set_qdata(GType type, GQuark quark, IntPtr data);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_type_get_qdata(GType type, GQuark quark);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_type_query(GType type, GTypeQueryHandle query);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_type_get_instance_count(GType type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_type_register_static(GType parent_type, string type_name, GTypeInfoHandle info, GTypeFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_type_register_static_simple(GType parent_type, string type_name, uint class_size, GClassInitFunc class_init, uint instance_size, GInstanceInitFunc instance_init, GTypeFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_type_register_dynamic(GType parent_type, string type_name, GTypePluginHandle plugin, GTypeFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_type_register_fundamental(GType type_id, string type_name, GTypeInfoHandle info, GTypeFundamentalInfoHandle finfo, GTypeFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_type_add_interface_static(GType instance_type, GType interface_type, GInterfaceInfoHandle info);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_type_add_interface_dynamic(GType instance_type, GType interface_type, GTypePluginHandle plugin);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_type_interface_add_prerequisite(GType interface_type, GType prerequisite_type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType[] g_type_interface_prerequisites(GType interface_type, out uint n_prerequisites);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_type_interface_instantiatable_prerequisite(GType interface_type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern void g_type_class_add_private(IntPtr g_class, nuint private_size);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_type_add_instance_private(GType class_type, nuint private_size);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_type_class_adjust_private_offset(IntPtr g_class, out int private_size_or_offset);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_type_add_class_private(GType class_type, nuint private_size);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_type_class_get_instance_private_offset(IntPtr g_class);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_type_ensure(GType type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_type_get_type_registration_serial();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GTypePluginHandle g_type_get_plugin(GType type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GTypePluginHandle g_type_interface_get_plugin(GType instance_type, GType interface_type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_type_fundamental_next();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_type_fundamental(GType type_id);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GTypeInstanceHandle g_type_create_instance(GType type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_type_add_class_cache_func(IntPtr cache_data, GTypeClassCacheFunc cache_func);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_type_remove_class_cache_func(IntPtr cache_data, GTypeClassCacheFunc cache_func);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_type_class_unref_uncached(IntPtr g_class);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_type_add_interface_check(IntPtr check_data, GTypeInterfaceCheckFunc check_func);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_type_remove_interface_check(IntPtr check_data, GTypeInterfaceCheckFunc check_func);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GTypeValueTableHandle g_type_value_table_peek(GType type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_type_check_is_value_type(GType type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_type_test_flags(GType type, uint flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_value_type_compatible(GType src_type, GType dest_type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_value_type_transformable(GType src_type, GType dest_type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_value_register_transform_func(GType src_type, GType dest_type, GValueTransform transform_func);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_param_type_register_static(string name, GParamSpecTypeInfoHandle pspec_info);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_param_spec_is_valid_name(string name);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType _g_param_type_register_static_constant(string name, GParamSpecTypeInfoHandle pspec_info, GType opt_type);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_param_spec_internal(GType param_type, string name, string nick, string blurb, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_signal_newv(string signal_name, GType itype, GSignalFlags signal_flags, GClosureHandle class_closure, GSignalAccumulator accumulator, IntPtr accu_data, GSignalCMarshaller c_marshaller, GType return_type, uint n_params, GType[] param_types);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_signal_new_valist(string signal_name, GType itype, GSignalFlags signal_flags, GClosureHandle class_closure, GSignalAccumulator accumulator, IntPtr accu_data, GSignalCMarshaller c_marshaller, GType return_type, uint n_params, __arglist);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_signal_new(string signal_name, GType itype, GSignalFlags signal_flags, uint class_offset, GSignalAccumulator accumulator, IntPtr accu_data, GSignalCMarshaller c_marshaller, GType return_type, uint n_params, __arglist);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_signal_new_class_handler(string signal_name, GType itype, GSignalFlags signal_flags, GCallback class_handler, GSignalAccumulator accumulator, IntPtr accu_data, GSignalCMarshaller c_marshaller, GType return_type, uint n_params, __arglist);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_signal_set_va_marshaller(uint signal_id, GType instance_type, GSignalCVaMarshaller va_marshaller);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint g_signal_lookup(string name, GType itype);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_signal_name(uint signal_id);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_signal_query(uint signal_id, GSignalQueryHandle query);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern uint[] g_signal_list_ids(GType itype, out uint n_ids);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_signal_is_valid_name(string name);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_signal_parse_name(string detailed_signal, GType itype, out uint signal_id_p, out GQuark detail_p, int force_detail_quark);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern nuint g_signal_add_emission_hook(uint signal_id, GQuark detail, GSignalEmissionHook hook_func, IntPtr hook_data, GDestroyNotify data_destroy);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_signal_remove_emission_hook(uint signal_id, nuint hook_id);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_clear_signal_handler(IntPtr handler_id_ptr, IntPtr instance);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_signal_override_class_closure(uint signal_id, GType instance_type, GClosureHandle class_closure);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_signal_override_class_handler(string signal_name, GType instance_type, GCallback class_handler);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void _g_signals_destroy(GType itype);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_date_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_strv_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_gstring_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_hash_table_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_array_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_byte_array_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_ptr_array_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_bytes_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_variant_type_get_gtype();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_regex_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_match_info_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_error_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_date_time_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_time_zone_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_io_channel_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_io_condition_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_variant_builder_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_variant_dict_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_key_file_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_main_loop_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_main_context_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_source_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_pollfd_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_thread_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_checksum_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_markup_parse_context_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_mapped_file_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_option_group_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_uri_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_tree_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_pattern_spec_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_variant_get_gtype();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_boxed_copy(GType boxed_type, IntPtr src_boxed);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_boxed_free(GType boxed_type, IntPtr boxed);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_boxed_type_register_static(string name, GBoxedCopyFunc boxed_copy, GBoxedFreeFunc boxed_free);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_closure_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_value_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_initially_unowned_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_object_interface_install_property(IntPtr g_iface, GParamSpecHandle pspec);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_object_interface_find_property(IntPtr g_iface, string property_name);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle[] g_object_interface_list_properties(IntPtr g_iface, out uint n_properties_p);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_object_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_object_new(GType object_type, string first_property_name, __arglist);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_object_newv(GType object_type, uint n_parameters, GParameterHandle parameters);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_object_set(IntPtr @object, string first_property_name, __arglist);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_object_get(IntPtr @object, string first_property_name, __arglist);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern IntPtr g_object_connect(IntPtr @object, string signal_spec, __arglist);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_object_disconnect(IntPtr @object, string signal_spec, __arglist);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	[Obsolete]
	public static extern nuint g_object_compat_control(nuint what, IntPtr data);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_clear_object(out GObjectHandle object_ptr);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_binding_flags_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_binding_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GBindingHandle g_object_bind_property(IntPtr source, string source_property, IntPtr target, string target_property, GBindingFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GBindingHandle g_object_bind_property_full(IntPtr source, string source_property, IntPtr target, string target_property, GBindingFlags flags, GBindingTransformFunc transform_to, GBindingTransformFunc transform_from, IntPtr user_data, GDestroyNotify notify);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GBindingHandle g_object_bind_property_with_closures(IntPtr source, string source_property, IntPtr target, string target_property, GBindingFlags flags, GClosureHandle transform_to, GClosureHandle transform_from);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_binding_group_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_enum_to_string(GType g_enum_type, int value);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern string g_flags_to_string(GType flags_type, uint value);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_enum_register_static(string name, GEnumValueHandle const_static_values);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_flags_register_static(string name, GFlagsValueHandle const_static_values);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_enum_complete_type_info(GType g_enum_type, GTypeInfoHandle info, GEnumValueHandle const_values);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void g_flags_complete_type_info(GType g_flags_type, GTypeInfoHandle info, GFlagsValueHandle const_values);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_unicode_type_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_unicode_break_type_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_unicode_script_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_normalize_mode_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_char(string name, string nick, string blurb, sbyte minimum, sbyte maximum, sbyte default_value, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_uchar(string name, string nick, string blurb, byte minimum, byte maximum, byte default_value, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_boolean(string name, string nick, string blurb, int default_value, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_int(string name, string nick, string blurb, int minimum, int maximum, int default_value, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_uint(string name, string nick, string blurb, uint minimum, uint maximum, uint default_value, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_long(string name, string nick, string blurb, nint minimum, nint maximum, nint default_value, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_ulong(string name, string nick, string blurb, nuint minimum, nuint maximum, nuint default_value, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_int64(string name, string nick, string blurb, nint minimum, nint maximum, nint default_value, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_uint64(string name, string nick, string blurb, nuint minimum, nuint maximum, nuint default_value, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_unichar(string name, string nick, string blurb, uint default_value, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_enum(string name, string nick, string blurb, GType enum_type, int default_value, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_flags(string name, string nick, string blurb, GType flags_type, uint default_value, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_float(string name, string nick, string blurb, float minimum, float maximum, float default_value, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_double(string name, string nick, string blurb, double minimum, double maximum, double default_value, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_string(string name, string nick, string blurb, string default_value, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_param(string name, string nick, string blurb, GType param_type, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_boxed(string name, string nick, string blurb, GType boxed_type, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_pointer(string name, string nick, string blurb, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_value_array(string name, string nick, string blurb, GParamSpecHandle element_spec, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_object(string name, string nick, string blurb, GType object_type, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_override(string name, GParamSpecHandle overridden);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_gtype(string name, string nick, string blurb, GType is_a_type, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GParamSpecHandle g_param_spec_variant(string name, string nick, string blurb, GVariantTypeHandle type, GVariantHandle default_value, GParamFlags flags);

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_signal_group_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_type_module_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_type_plugin_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_value_array_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_gtype_get_type();

	[DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_pointer_type_register_static(string name);
}
