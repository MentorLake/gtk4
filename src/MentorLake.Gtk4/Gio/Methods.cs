using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gio;

public static class Methods
{
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_action_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_action_get_name(GActionHandle action);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantTypeHandle g_action_get_parameter_type(GActionHandle action);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantTypeHandle g_action_get_state_type(GActionHandle action);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_action_get_state_hint(GActionHandle action);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_action_get_enabled(GActionHandle action);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_action_get_state(GActionHandle action);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_action_change_state(GActionHandle action, GVariantHandle value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_action_activate(GActionHandle action, GVariantHandle parameter);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_action_name_is_valid(string action_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_action_parse_detailed_name(string detailed_name, string[] action_name, out GVariantHandle target_value, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_action_print_detailed_name(string action_name, GVariantHandle target_value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_action_group_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_action_group_has_action(GActionGroupHandle action_group, string action_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_action_group_list_actions(GActionGroupHandle action_group);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantTypeHandle g_action_group_get_action_parameter_type(GActionGroupHandle action_group, string action_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantTypeHandle g_action_group_get_action_state_type(GActionGroupHandle action_group, string action_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_action_group_get_action_state_hint(GActionGroupHandle action_group, string action_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_action_group_get_action_enabled(GActionGroupHandle action_group, string action_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_action_group_get_action_state(GActionGroupHandle action_group, string action_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_action_group_change_action_state(GActionGroupHandle action_group, string action_name, GVariantHandle value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_action_group_activate_action(GActionGroupHandle action_group, string action_name, GVariantHandle parameter);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_action_group_action_added(GActionGroupHandle action_group, string action_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_action_group_action_removed(GActionGroupHandle action_group, string action_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_action_group_action_enabled_changed(GActionGroupHandle action_group, string action_name, int enabled);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_action_group_action_state_changed(GActionGroupHandle action_group, string action_name, GVariantHandle state);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_action_group_query_action(GActionGroupHandle action_group, string action_name, [NativeTypeName("gboolean *")] int* enabled, [NativeTypeName("const GVariantType **")] _GVariantTypeHandle* parameter_type, [NativeTypeName("const GVariantType **")] _GVariantTypeHandle* state_type, out GVariantHandle state_hint, out GVariantHandle state);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_dbus_connection_export_action_group(GDBusConnectionHandle connection, string object_path, GActionGroupHandle action_group, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_connection_unexport_action_group(GDBusConnectionHandle connection, uint export_id);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_action_map_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GActionHandle g_action_map_lookup_action(GActionMapHandle action_map, string action_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_action_map_add_action(GActionMapHandle action_map, GActionHandle action);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_action_map_remove_action(GActionMapHandle action_map, string action_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_action_map_add_action_entries(GActionMapHandle action_map, GActionEntryHandle entries, int n_entries, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_app_info_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GAppInfoHandle g_app_info_create_from_commandline(string commandline, string application_name, GAppInfoCreateFlags flags, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GAppInfoHandle g_app_info_dup(GAppInfoHandle appinfo);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_app_info_equal(GAppInfoHandle appinfo1, GAppInfoHandle appinfo2);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_app_info_get_id(GAppInfoHandle appinfo);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_app_info_get_name(GAppInfoHandle appinfo);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_app_info_get_display_name(GAppInfoHandle appinfo);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_app_info_get_description(GAppInfoHandle appinfo);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_app_info_get_executable(GAppInfoHandle appinfo);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_app_info_get_commandline(GAppInfoHandle appinfo);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_app_info_get_icon(GAppInfoHandle appinfo);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_app_info_launch(GAppInfoHandle appinfo, GListHandle files, GAppLaunchContextHandle context, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_app_info_supports_uris(GAppInfoHandle appinfo);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_app_info_supports_files(GAppInfoHandle appinfo);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_app_info_launch_uris(GAppInfoHandle appinfo, GListHandle uris, GAppLaunchContextHandle context, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_app_info_launch_uris_async(GAppInfoHandle appinfo, GListHandle uris, GAppLaunchContextHandle context, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_app_info_launch_uris_finish(GAppInfoHandle appinfo, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_app_info_should_show(GAppInfoHandle appinfo);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_app_info_set_as_default_for_type(GAppInfoHandle appinfo, string content_type, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_app_info_set_as_default_for_extension(GAppInfoHandle appinfo, string extension, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_app_info_add_supports_type(GAppInfoHandle appinfo, string content_type, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_app_info_can_remove_supports_type(GAppInfoHandle appinfo);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_app_info_remove_supports_type(GAppInfoHandle appinfo, string content_type, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_app_info_get_supported_types(GAppInfoHandle appinfo);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_app_info_can_delete(GAppInfoHandle appinfo);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_app_info_delete(GAppInfoHandle appinfo);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_app_info_set_as_last_used_for_type(GAppInfoHandle appinfo, string content_type, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_app_info_get_all();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_app_info_get_all_for_type(string content_type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_app_info_get_recommended_for_type(string content_type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_app_info_get_fallback_for_type(string content_type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_app_info_reset_type_associations(string content_type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GAppInfoHandle g_app_info_get_default_for_type(string content_type, int must_support_uris);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GAppInfoHandle g_app_info_get_default_for_uri_scheme(string uri_scheme);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_app_info_launch_default_for_uri(string uri, GAppLaunchContextHandle context, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_app_info_launch_default_for_uri_async(string uri, GAppLaunchContextHandle context, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_app_info_launch_default_for_uri_finish(GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_app_launch_context_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GAppLaunchContextHandle g_app_launch_context_new();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_app_launch_context_setenv(GAppLaunchContextHandle context, string variable, string value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_app_launch_context_unsetenv(GAppLaunchContextHandle context, string variable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_app_launch_context_get_environment(GAppLaunchContextHandle context);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_app_launch_context_get_display(GAppLaunchContextHandle context, GAppInfoHandle info, GListHandle files);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_app_launch_context_get_startup_notify_id(GAppLaunchContextHandle context, GAppInfoHandle info, GListHandle files);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_app_launch_context_launch_failed(GAppLaunchContextHandle context, string startup_notify_id);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_app_info_monitor_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GAppInfoMonitorHandle g_app_info_monitor_get();
	//
	[DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GType g_application_get_type();

	[DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int g_application_id_is_valid(string application_id);

	[DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern GApplicationHandle g_application_get_default();

	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_application_command_line_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_application_command_line_get_arguments(GApplicationCommandLineHandle cmdline, int* argc);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantDictHandle g_application_command_line_get_options_dict(GApplicationCommandLineHandle cmdline);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInputStreamHandle g_application_command_line_get_stdin(GApplicationCommandLineHandle cmdline);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_application_command_line_get_environ(GApplicationCommandLineHandle cmdline);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_application_command_line_getenv(GApplicationCommandLineHandle cmdline, string name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_application_command_line_get_cwd(GApplicationCommandLineHandle cmdline);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_application_command_line_get_is_remote(GApplicationCommandLineHandle cmdline);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_application_command_line_print(GApplicationCommandLineHandle cmdline, string format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_application_command_line_printerr(GApplicationCommandLineHandle cmdline, string format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_application_command_line_get_exit_status(GApplicationCommandLineHandle cmdline);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_application_command_line_set_exit_status(GApplicationCommandLineHandle cmdline, int exit_status);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_application_command_line_get_platform_data(GApplicationCommandLineHandle cmdline);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_application_command_line_create_file_for_arg(GApplicationCommandLineHandle cmdline, string arg);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_initable_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_initable_init(GInitableHandle initable, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern IntPtr g_initable_new(GType object_type, GCancellableHandle cancellable, out GErrorHandle error, string first_property_name, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern IntPtr g_initable_newv(GType object_type, uint n_parameters, GParameterHandle parameters, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GObjectHandle g_initable_new_valist(GType object_type, string first_property_name, object[] var_args, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_async_initable_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_async_initable_init_async(GAsyncInitableHandle initable, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_async_initable_init_finish(GAsyncInitableHandle initable, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_async_initable_new_async(GType object_type, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data, string first_property_name, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_async_initable_newv_async(GType object_type, uint n_parameters, GParameterHandle parameters, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_async_initable_new_valist_async(GType object_type, string first_property_name, object[] var_args, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GObjectHandle g_async_initable_new_finish(GAsyncInitableHandle initable, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_async_result_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern IntPtr g_async_result_get_user_data(GAsyncResultHandle res);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GObjectHandle g_async_result_get_source_object(GAsyncResultHandle res);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_async_result_legacy_propagate_error(GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_async_result_is_tagged(GAsyncResultHandle res, IntPtr source_tag);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_input_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_input_stream_read(GInputStreamHandle stream, byte[] buffer, nuint count, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_input_stream_read_all(GInputStreamHandle stream, byte[] buffer, nuint count, out nuint bytes_read, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GBytesHandle g_input_stream_read_bytes(GInputStreamHandle stream, nuint count, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_input_stream_skip(GInputStreamHandle stream, nuint count, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_input_stream_close(GInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_input_stream_read_async(GInputStreamHandle stream, byte[] buffer, nuint count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_input_stream_read_finish(GInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_input_stream_read_all_async(GInputStreamHandle stream, byte[] buffer, nuint count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_input_stream_read_all_finish(GInputStreamHandle stream, GAsyncResultHandle result, out nuint bytes_read, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_input_stream_read_bytes_async(GInputStreamHandle stream, nuint count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GBytesHandle g_input_stream_read_bytes_finish(GInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_input_stream_skip_async(GInputStreamHandle stream, nuint count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_input_stream_skip_finish(GInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_input_stream_close_async(GInputStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_input_stream_close_finish(GInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_input_stream_is_closed(GInputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_input_stream_has_pending(GInputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_input_stream_set_pending(GInputStreamHandle stream, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_input_stream_clear_pending(GInputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_filter_input_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInputStreamHandle g_filter_input_stream_get_base_stream(GFilterInputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_filter_input_stream_get_close_base_stream(GFilterInputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_filter_input_stream_set_close_base_stream(GFilterInputStreamHandle stream, int close_base);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_buffered_input_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInputStreamHandle g_buffered_input_stream_new(GInputStreamHandle base_stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInputStreamHandle g_buffered_input_stream_new_sized(GInputStreamHandle base_stream, nuint size);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nuint g_buffered_input_stream_get_buffer_size(GBufferedInputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_buffered_input_stream_set_buffer_size(GBufferedInputStreamHandle stream, nuint size);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nuint g_buffered_input_stream_get_available(GBufferedInputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nuint g_buffered_input_stream_peek(GBufferedInputStreamHandle stream, void* buffer, nuint offset, nuint count);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("const void *")]
	// public static extern void* g_buffered_input_stream_peek_buffer(GBufferedInputStreamHandle stream, [NativeTypeName("gsize *")] nuint* count);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_buffered_input_stream_fill(GBufferedInputStreamHandle stream, nint count, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_buffered_input_stream_fill_async(GBufferedInputStreamHandle stream, nint count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_buffered_input_stream_fill_finish(GBufferedInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_buffered_input_stream_read_byte(GBufferedInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_output_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_output_stream_write(GOutputStreamHandle stream, byte[] buffer, nuint count, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_output_stream_write_all(GOutputStreamHandle stream, byte[] buffer, nuint count, out nuint bytes_written, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_output_stream_writev(GOutputStreamHandle stream, GOutputVectorHandle vectors, nuint n_vectors, out nuint bytes_written, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_output_stream_writev_all(GOutputStreamHandle stream, GOutputVectorHandle vectors, nuint n_vectors, out nuint bytes_written, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_output_stream_printf(GOutputStreamHandle stream, out nuint bytes_written, GCancellableHandle cancellable, out GErrorHandle error, string format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_output_stream_vprintf(GOutputStreamHandle stream, out nuint bytes_written, GCancellableHandle cancellable, out GErrorHandle error, string format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_output_stream_write_bytes(GOutputStreamHandle stream, GBytesHandle bytes, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_output_stream_splice(GOutputStreamHandle stream, GInputStreamHandle source, GOutputStreamSpliceFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_output_stream_flush(GOutputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_output_stream_close(GOutputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_output_stream_write_async(GOutputStreamHandle stream, byte[] buffer, nuint count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_output_stream_write_finish(GOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_output_stream_write_all_async(GOutputStreamHandle stream, byte[] buffer, nuint count, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_output_stream_write_all_finish(GOutputStreamHandle stream, GAsyncResultHandle result, out nuint bytes_written, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_output_stream_writev_async(GOutputStreamHandle stream, GOutputVectorHandle vectors, nuint n_vectors, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_output_stream_writev_finish(GOutputStreamHandle stream, GAsyncResultHandle result, out nuint bytes_written, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_output_stream_writev_all_async(GOutputStreamHandle stream, GOutputVectorHandle vectors, nuint n_vectors, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_output_stream_writev_all_finish(GOutputStreamHandle stream, GAsyncResultHandle result, out nuint bytes_written, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_output_stream_write_bytes_async(GOutputStreamHandle stream, GBytesHandle bytes, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_output_stream_write_bytes_finish(GOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_output_stream_splice_async(GOutputStreamHandle stream, GInputStreamHandle source, GOutputStreamSpliceFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_output_stream_splice_finish(GOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_output_stream_flush_async(GOutputStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_output_stream_flush_finish(GOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_output_stream_close_async(GOutputStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_output_stream_close_finish(GOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_output_stream_is_closed(GOutputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_output_stream_is_closing(GOutputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_output_stream_has_pending(GOutputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_output_stream_set_pending(GOutputStreamHandle stream, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_output_stream_clear_pending(GOutputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_filter_output_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GOutputStreamHandle g_filter_output_stream_get_base_stream(GFilterOutputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_filter_output_stream_get_close_base_stream(GFilterOutputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_filter_output_stream_set_close_base_stream(GFilterOutputStreamHandle stream, int close_base);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_buffered_output_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GOutputStreamHandle g_buffered_output_stream_new(GOutputStreamHandle base_stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GOutputStreamHandle g_buffered_output_stream_new_sized(GOutputStreamHandle base_stream, nuint size);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nuint g_buffered_output_stream_get_buffer_size(GBufferedOutputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_buffered_output_stream_set_buffer_size(GBufferedOutputStreamHandle stream, nuint size);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_buffered_output_stream_get_auto_grow(GBufferedOutputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_buffered_output_stream_set_auto_grow(GBufferedOutputStreamHandle stream, int auto_grow);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_bytes_icon_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_bytes_icon_new(GBytesHandle bytes);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GBytesHandle g_bytes_icon_get_bytes(GBytesIconHandle icon);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_cancellable_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GCancellableHandle g_cancellable_new();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_cancellable_is_cancelled(GCancellableHandle cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_cancellable_set_error_if_cancelled(GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_cancellable_get_fd(GCancellableHandle cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_cancellable_make_pollfd(GCancellableHandle cancellable, GPollFDHandle pollfd);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_cancellable_release_fd(GCancellableHandle cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSourceHandle g_cancellable_source_new(GCancellableHandle cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GCancellableHandle g_cancellable_get_current();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_cancellable_push_current(GCancellableHandle cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_cancellable_pop_current(GCancellableHandle cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_cancellable_reset(GCancellableHandle cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nuint g_cancellable_connect(GCancellableHandle cancellable, [NativeTypeName("GCallback")] IntPtr callback, IntPtr data, GDestroyNotify data_destroy_func);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_cancellable_disconnect(GCancellableHandle cancellable, nuint handler_id);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_cancellable_cancel(GCancellableHandle cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_converter_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GConverterResult g_converter_convert(GConverterHandle converter, [NativeTypeName("const void *")] void* inbuf, nuint inbuf_size, void* outbuf, nuint outbuf_size, GConverterFlags flags, out nuint bytes_read, out nuint bytes_written, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_converter_reset(GConverterHandle converter);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_charset_converter_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GCharsetConverterHandle g_charset_converter_new(string to_charset, string from_charset, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_charset_converter_set_use_fallback(GCharsetConverterHandle converter, int use_fallback);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_charset_converter_get_use_fallback(GCharsetConverterHandle converter);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_charset_converter_get_num_fallbacks(GCharsetConverterHandle converter);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_content_type_equals(string type1, string type2);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_content_type_is_a(string type, string supertype);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_content_type_is_mime_type(string type, string mime_type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_content_type_is_unknown(string type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_content_type_get_description(string type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_content_type_get_mime_type(string type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_content_type_get_icon(string type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_content_type_get_symbolic_icon(string type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_content_type_get_generic_icon_name(string type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_content_type_can_be_executable(string type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_content_type_from_mime_type(string mime_type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_content_type_guess(string filename, string data, nuint data_size, [NativeTypeName("gboolean *")] int* result_uncertain);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_content_type_guess_for_tree(GFileHandle root);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_content_types_get_registered();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_content_type_get_mime_dirs();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_content_type_set_mime_dirs(string dirs);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_converter_input_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInputStreamHandle g_converter_input_stream_new(GInputStreamHandle base_stream, GConverterHandle converter);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GConverterHandle g_converter_input_stream_get_converter(GConverterInputStreamHandle converter_stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_converter_output_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GOutputStreamHandle g_converter_output_stream_new(GOutputStreamHandle base_stream, GConverterHandle converter);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GConverterHandle g_converter_output_stream_get_converter(GConverterOutputStreamHandle converter_stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_credentials_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GCredentialsHandle g_credentials_new();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_credentials_to_string(GCredentialsHandle credentials);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern IntPtr g_credentials_get_native(GCredentialsHandle credentials, GCredentialsType native_type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_credentials_set_native(GCredentialsHandle credentials, GCredentialsType native_type, IntPtr native);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_credentials_is_same_user(GCredentialsHandle credentials, GCredentialsHandle other_credentials, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_credentials_get_unix_pid(GCredentialsHandle credentials, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_credentials_get_unix_user(GCredentialsHandle credentials, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_credentials_set_unix_user(GCredentialsHandle credentials, [NativeTypeName("uid_t")] uint uid, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_datagram_based_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_datagram_based_receive_messages(GDatagramBasedHandle datagram_based, GInputMessageHandle messages, uint num_messages, int flags, nint timeout, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_datagram_based_send_messages(GDatagramBasedHandle datagram_based, GOutputMessageHandle messages, uint num_messages, int flags, nint timeout, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSourceHandle g_datagram_based_create_source(GDatagramBasedHandle datagram_based, GIOCondition condition, GCancellableHandle cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOCondition g_datagram_based_condition_check(GDatagramBasedHandle datagram_based, GIOCondition condition);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_datagram_based_condition_wait(GDatagramBasedHandle datagram_based, GIOCondition condition, nint timeout, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_data_input_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDataInputStreamHandle g_data_input_stream_new(GInputStreamHandle base_stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_data_input_stream_set_byte_order(GDataInputStreamHandle stream, GDataStreamByteOrder order);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDataStreamByteOrder g_data_input_stream_get_byte_order(GDataInputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_data_input_stream_set_newline_type(GDataInputStreamHandle stream, GDataStreamNewlineType type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDataStreamNewlineType g_data_input_stream_get_newline_type(GDataInputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern char g_data_input_stream_read_byte(GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern short g_data_input_stream_read_int16(GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern ushort g_data_input_stream_read_uint16(GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_data_input_stream_read_int32(GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_data_input_stream_read_uint32(GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_data_input_stream_read_int64(GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nuint g_data_input_stream_read_uint64(GDataInputStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_data_input_stream_read_line(GDataInputStreamHandle stream, [NativeTypeName("gsize *")] nuint* length, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_data_input_stream_read_line_utf8(GDataInputStreamHandle stream, [NativeTypeName("gsize *")] nuint* length, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_data_input_stream_read_line_async(GDataInputStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_data_input_stream_read_line_finish(GDataInputStreamHandle stream, GAsyncResultHandle result, [NativeTypeName("gsize *")] nuint* length, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_data_input_stream_read_line_finish_utf8(GDataInputStreamHandle stream, GAsyncResultHandle result, [NativeTypeName("gsize *")] nuint* length, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_data_input_stream_read_until(GDataInputStreamHandle stream, string stop_chars, [NativeTypeName("gsize *")] nuint* length, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_data_input_stream_read_until_async(GDataInputStreamHandle stream, string stop_chars, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_data_input_stream_read_until_finish(GDataInputStreamHandle stream, GAsyncResultHandle result, [NativeTypeName("gsize *")] nuint* length, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_data_input_stream_read_upto(GDataInputStreamHandle stream, string stop_chars, nint stop_chars_len, [NativeTypeName("gsize *")] nuint* length, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_data_input_stream_read_upto_async(GDataInputStreamHandle stream, string stop_chars, nint stop_chars_len, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_data_input_stream_read_upto_finish(GDataInputStreamHandle stream, GAsyncResultHandle result, [NativeTypeName("gsize *")] nuint* length, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_data_output_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDataOutputStreamHandle g_data_output_stream_new(GOutputStreamHandle base_stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_data_output_stream_set_byte_order(GDataOutputStreamHandle stream, GDataStreamByteOrder order);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDataStreamByteOrder g_data_output_stream_get_byte_order(GDataOutputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_data_output_stream_put_byte(GDataOutputStreamHandle stream, char data, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_data_output_stream_put_int16(GDataOutputStreamHandle stream, short data, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_data_output_stream_put_uint16(GDataOutputStreamHandle stream, ushort data, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_data_output_stream_put_int32(GDataOutputStreamHandle stream, int data, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_data_output_stream_put_uint32(GDataOutputStreamHandle stream, uint data, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_data_output_stream_put_int64(GDataOutputStreamHandle stream, nint data, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_data_output_stream_put_uint64(GDataOutputStreamHandle stream, nuint data, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_data_output_stream_put_string(GDataOutputStreamHandle stream, string str, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_action_group_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusActionGroupHandle g_dbus_action_group_get(GDBusConnectionHandle connection, string bus_name, string object_path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_address_escape_value(string @string);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_is_address(string @string);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_is_supported_address(string @string, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_address_get_stream(string address, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOStreamHandle g_dbus_address_get_stream_finish(GAsyncResultHandle res, string[] out_guid, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOStreamHandle g_dbus_address_get_stream_sync(string address, string[] out_guid, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_address_get_for_bus_sync(GBusType bus_type, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_auth_observer_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusAuthObserverHandle g_dbus_auth_observer_new();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_auth_observer_authorize_authenticated_peer(GDBusAuthObserverHandle observer, GIOStreamHandle stream, GCredentialsHandle credentials);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_auth_observer_allow_mechanism(GDBusAuthObserverHandle observer, string mechanism);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_connection_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_bus_get(GBusType bus_type, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusConnectionHandle g_bus_get_finish(GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusConnectionHandle g_bus_get_sync(GBusType bus_type, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_connection_new(GIOStreamHandle stream, string guid, GDBusConnectionFlags flags, GDBusAuthObserverHandle observer, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusConnectionHandle g_dbus_connection_new_finish(GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusConnectionHandle g_dbus_connection_new_sync(GIOStreamHandle stream, string guid, GDBusConnectionFlags flags, GDBusAuthObserverHandle observer, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_connection_new_for_address(string address, GDBusConnectionFlags flags, GDBusAuthObserverHandle observer, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusConnectionHandle g_dbus_connection_new_for_address_finish(GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusConnectionHandle g_dbus_connection_new_for_address_sync(string address, GDBusConnectionFlags flags, GDBusAuthObserverHandle observer, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_connection_start_message_processing(GDBusConnectionHandle connection);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_connection_is_closed(GDBusConnectionHandle connection);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOStreamHandle g_dbus_connection_get_stream(GDBusConnectionHandle connection);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_connection_get_guid(GDBusConnectionHandle connection);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_connection_get_unique_name(GDBusConnectionHandle connection);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GCredentialsHandle g_dbus_connection_get_peer_credentials(GDBusConnectionHandle connection);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_dbus_connection_get_last_serial(GDBusConnectionHandle connection);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_connection_get_exit_on_close(GDBusConnectionHandle connection);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_connection_set_exit_on_close(GDBusConnectionHandle connection, int exit_on_close);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusCapabilityFlags g_dbus_connection_get_capabilities(GDBusConnectionHandle connection);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusConnectionFlags g_dbus_connection_get_flags(GDBusConnectionHandle connection);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_connection_close(GDBusConnectionHandle connection, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_connection_close_finish(GDBusConnectionHandle connection, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_connection_close_sync(GDBusConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_connection_flush(GDBusConnectionHandle connection, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_connection_flush_finish(GDBusConnectionHandle connection, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_connection_flush_sync(GDBusConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_connection_send_message(GDBusConnectionHandle connection, GDBusMessageHandle message, GDBusSendMessageFlags flags, out uint out_serial, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_connection_send_message_with_reply(GDBusConnectionHandle connection, GDBusMessageHandle message, GDBusSendMessageFlags flags, int timeout_msec, out uint out_serial, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMessageHandle g_dbus_connection_send_message_with_reply_finish(GDBusConnectionHandle connection, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMessageHandle g_dbus_connection_send_message_with_reply_sync(GDBusConnectionHandle connection, GDBusMessageHandle message, GDBusSendMessageFlags flags, int timeout_msec, out uint out_serial, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_connection_emit_signal(GDBusConnectionHandle connection, string destination_bus_name, string object_path, string interface_name, string signal_name, GVariantHandle parameters, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_connection_call(GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, GVariantHandle parameters, GVariantTypeHandle reply_type, GDBusCallFlags flags, int timeout_msec, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_dbus_connection_call_finish(GDBusConnectionHandle connection, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_dbus_connection_call_sync(GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, GVariantHandle parameters, GVariantTypeHandle reply_type, GDBusCallFlags flags, int timeout_msec, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_connection_call_with_unix_fd_list(GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, GVariantHandle parameters, GVariantTypeHandle reply_type, GDBusCallFlags flags, int timeout_msec, GUnixFDListHandle fd_list, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_dbus_connection_call_with_unix_fd_list_finish(GDBusConnectionHandle connection, out GUnixFDListHandle out_fd_list, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_dbus_connection_call_with_unix_fd_list_sync(GDBusConnectionHandle connection, string bus_name, string object_path, string interface_name, string method_name, GVariantHandle parameters, GVariantTypeHandle reply_type, GDBusCallFlags flags, int timeout_msec, GUnixFDListHandle fd_list, out GUnixFDListHandle out_fd_list, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_dbus_connection_register_object(GDBusConnectionHandle connection, string object_path, GDBusInterfaceInfoHandle interface_info, GDBusInterfaceVTableHandle vtable, IntPtr user_data, GDestroyNotify user_data_free_func, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_dbus_connection_register_object_with_closures(GDBusConnectionHandle connection, string object_path, GDBusInterfaceInfoHandle interface_info, GClosureHandle method_call_closure, GClosureHandle get_property_closure, GClosureHandle set_property_closure, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_connection_unregister_object(GDBusConnectionHandle connection, uint registration_id);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_dbus_connection_register_subtree(GDBusConnectionHandle connection, string object_path, GDBusSubtreeVTableHandle vtable, GDBusSubtreeFlags flags, IntPtr user_data, GDestroyNotify user_data_free_func, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_connection_unregister_subtree(GDBusConnectionHandle connection, uint registration_id);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_dbus_connection_signal_subscribe(GDBusConnectionHandle connection, string sender, string interface_name, string member, string object_path, string arg0, GDBusSignalFlags flags, GDBusSignalCallback callback, IntPtr user_data, GDestroyNotify user_data_free_func);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_connection_signal_unsubscribe(GDBusConnectionHandle connection, uint subscription_id);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_dbus_connection_add_filter(GDBusConnectionHandle connection, GDBusMessageFilterFunction filter_function, IntPtr user_data, GDestroyNotify user_data_free_func);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_connection_remove_filter(GDBusConnectionHandle connection, uint filter_id);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GQuark g_dbus_error_quark();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_error_is_remote_error(GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_error_get_remote_error(GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_error_strip_remote_error(GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_error_register_error(GQuark error_domain, int error_code, string dbus_error_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_error_unregister_error(GQuark error_domain, int error_code, string dbus_error_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_error_register_error_domain(string error_domain_quark_name, [NativeTypeName("gsize *")] nuint* quark_volatile, GDBusErrorEntryHandle entries, uint num_entries);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GErrorHandle g_dbus_error_new_for_dbus_error(string dbus_error_name, string dbus_error_message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_error_set_dbus_error(out GErrorHandle error, string dbus_error_name, string dbus_error_message, string format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_error_set_dbus_error_valist(out GErrorHandle error, string dbus_error_name, string dbus_error_message, string format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_error_encode_gerror(GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_interface_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusInterfaceInfoHandle g_dbus_interface_get_info(GDBusInterfaceHandle interface_);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusObjectHandle g_dbus_interface_get_object(GDBusInterfaceHandle interface_);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_interface_set_object(GDBusInterfaceHandle interface_, GDBusObjectHandle @object);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusObjectHandle g_dbus_interface_dup_object(GDBusInterfaceHandle interface_);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_interface_skeleton_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusInterfaceSkeletonFlags g_dbus_interface_skeleton_get_flags(GDBusInterfaceSkeletonHandle interface_);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_interface_skeleton_set_flags(GDBusInterfaceSkeletonHandle interface_, GDBusInterfaceSkeletonFlags flags);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusInterfaceInfoHandle g_dbus_interface_skeleton_get_info(GDBusInterfaceSkeletonHandle interface_);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusInterfaceVTableHandle g_dbus_interface_skeleton_get_vtable(GDBusInterfaceSkeletonHandle interface_);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_dbus_interface_skeleton_get_properties(GDBusInterfaceSkeletonHandle interface_);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_interface_skeleton_flush(GDBusInterfaceSkeletonHandle interface_);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_interface_skeleton_export(GDBusInterfaceSkeletonHandle interface_, GDBusConnectionHandle connection, string object_path, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_interface_skeleton_unexport(GDBusInterfaceSkeletonHandle interface_);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_interface_skeleton_unexport_from_connection(GDBusInterfaceSkeletonHandle interface_, GDBusConnectionHandle connection);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusConnectionHandle g_dbus_interface_skeleton_get_connection(GDBusInterfaceSkeletonHandle interface_);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_dbus_interface_skeleton_get_connections(GDBusInterfaceSkeletonHandle interface_);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_interface_skeleton_has_connection(GDBusInterfaceSkeletonHandle interface_, GDBusConnectionHandle connection);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_interface_skeleton_get_object_path(GDBusInterfaceSkeletonHandle interface_);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_annotation_info_lookup(out GDBusAnnotationInfoHandle annotations, string name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMethodInfoHandle g_dbus_interface_info_lookup_method(GDBusInterfaceInfoHandle info, string name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusSignalInfoHandle g_dbus_interface_info_lookup_signal(GDBusInterfaceInfoHandle info, string name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusPropertyInfoHandle g_dbus_interface_info_lookup_property(GDBusInterfaceInfoHandle info, string name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_interface_info_cache_build(GDBusInterfaceInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_interface_info_cache_release(GDBusInterfaceInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_interface_info_generate_xml(GDBusInterfaceInfoHandle info, uint indent, GStringHandle string_builder);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusNodeInfoHandle g_dbus_node_info_new_for_xml(string xml_data, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusInterfaceInfoHandle g_dbus_node_info_lookup_interface(GDBusNodeInfoHandle info, string name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_node_info_generate_xml(GDBusNodeInfoHandle info, uint indent, GStringHandle string_builder);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusNodeInfoHandle g_dbus_node_info_ref(GDBusNodeInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusInterfaceInfoHandle g_dbus_interface_info_ref(GDBusInterfaceInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMethodInfoHandle g_dbus_method_info_ref(GDBusMethodInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusSignalInfoHandle g_dbus_signal_info_ref(GDBusSignalInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusPropertyInfoHandle g_dbus_property_info_ref(GDBusPropertyInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusArgInfoHandle g_dbus_arg_info_ref(GDBusArgInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusAnnotationInfoHandle g_dbus_annotation_info_ref(GDBusAnnotationInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_node_info_unref(GDBusNodeInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_interface_info_unref(GDBusInterfaceInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_method_info_unref(GDBusMethodInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_signal_info_unref(GDBusSignalInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_property_info_unref(GDBusPropertyInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_arg_info_unref(GDBusArgInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_annotation_info_unref(GDBusAnnotationInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_node_info_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_interface_info_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_method_info_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_signal_info_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_property_info_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_arg_info_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_annotation_info_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_menu_model_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMenuModelHandle g_dbus_menu_model_get(GDBusConnectionHandle connection, string bus_name, string object_path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_message_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMessageHandle g_dbus_message_new();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMessageHandle g_dbus_message_new_signal(string path, string interface_, string signal);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMessageHandle g_dbus_message_new_method_call(string name, string path, string interface_, string method);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMessageHandle g_dbus_message_new_method_reply(GDBusMessageHandle method_call_message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMessageHandle g_dbus_message_new_method_error(GDBusMessageHandle method_call_message, string error_name, string error_message_format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMessageHandle g_dbus_message_new_method_error_valist(GDBusMessageHandle method_call_message, string error_name, string error_message_format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMessageHandle g_dbus_message_new_method_error_literal(GDBusMessageHandle method_call_message, string error_name, string error_message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_message_print(GDBusMessageHandle message, uint indent);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_message_get_locked(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_message_lock(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMessageHandle g_dbus_message_copy(GDBusMessageHandle message, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMessageByteOrder g_dbus_message_get_byte_order(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_message_set_byte_order(GDBusMessageHandle message, GDBusMessageByteOrder byte_order);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMessageType g_dbus_message_get_message_type(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_message_set_message_type(GDBusMessageHandle message, GDBusMessageType type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMessageFlags g_dbus_message_get_flags(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_message_set_flags(GDBusMessageHandle message, GDBusMessageFlags flags);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_dbus_message_get_serial(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_message_set_serial(GDBusMessageHandle message, uint serial);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_dbus_message_get_header(GDBusMessageHandle message, GDBusMessageHeaderField header_field);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_message_set_header(GDBusMessageHandle message, GDBusMessageHeaderField header_field, GVariantHandle value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_message_get_header_fields(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_dbus_message_get_body(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_message_set_body(GDBusMessageHandle message, GVariantHandle body);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GUnixFDListHandle g_dbus_message_get_unix_fd_list(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_message_set_unix_fd_list(GDBusMessageHandle message, GUnixFDListHandle fd_list);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_dbus_message_get_reply_serial(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_message_set_reply_serial(GDBusMessageHandle message, uint value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_message_get_interface(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_message_set_interface(GDBusMessageHandle message, string value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_message_get_member(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_message_set_member(GDBusMessageHandle message, string value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_message_get_path(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_message_set_path(GDBusMessageHandle message, string value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_message_get_sender(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_message_set_sender(GDBusMessageHandle message, string value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_message_get_destination(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_message_set_destination(GDBusMessageHandle message, string value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_message_get_error_name(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_message_set_error_name(GDBusMessageHandle message, string value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_message_get_signature(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_message_set_signature(GDBusMessageHandle message, string value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_dbus_message_get_num_unix_fds(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_message_set_num_unix_fds(GDBusMessageHandle message, uint value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_message_get_arg0(GDBusMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMessageHandle g_dbus_message_new_from_blob(string blob, nuint blob_len, GDBusCapabilityFlags capabilities, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_dbus_message_bytes_needed(string blob, nuint blob_len, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_message_to_blob(GDBusMessageHandle message, [NativeTypeName("gsize *")] nuint* out_size, GDBusCapabilityFlags capabilities, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_message_to_gerror(GDBusMessageHandle message, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_method_invocation_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_method_invocation_get_sender(GDBusMethodInvocationHandle invocation);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_method_invocation_get_object_path(GDBusMethodInvocationHandle invocation);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_method_invocation_get_interface_name(GDBusMethodInvocationHandle invocation);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_method_invocation_get_method_name(GDBusMethodInvocationHandle invocation);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMethodInfoHandle g_dbus_method_invocation_get_method_info(GDBusMethodInvocationHandle invocation);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusPropertyInfoHandle g_dbus_method_invocation_get_property_info(GDBusMethodInvocationHandle invocation);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusConnectionHandle g_dbus_method_invocation_get_connection(GDBusMethodInvocationHandle invocation);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusMessageHandle g_dbus_method_invocation_get_message(GDBusMethodInvocationHandle invocation);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_dbus_method_invocation_get_parameters(GDBusMethodInvocationHandle invocation);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern IntPtr g_dbus_method_invocation_get_user_data(GDBusMethodInvocationHandle invocation);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_method_invocation_return_value(GDBusMethodInvocationHandle invocation, GVariantHandle parameters);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_method_invocation_return_value_with_unix_fd_list(GDBusMethodInvocationHandle invocation, GVariantHandle parameters, GUnixFDListHandle fd_list);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_method_invocation_return_error(GDBusMethodInvocationHandle invocation, GQuark domain, int code, string format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_method_invocation_return_error_valist(GDBusMethodInvocationHandle invocation, GQuark domain, int code, string format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_method_invocation_return_error_literal(GDBusMethodInvocationHandle invocation, GQuark domain, int code, string message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_method_invocation_return_gerror(GDBusMethodInvocationHandle invocation, GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_method_invocation_take_error(GDBusMethodInvocationHandle invocation, GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_method_invocation_return_dbus_error(GDBusMethodInvocationHandle invocation, string error_name, string error_message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_bus_own_name(GBusType bus_type, string name, GBusNameOwnerFlags flags, GBusAcquiredCallback bus_acquired_handler, GBusNameAcquiredCallback name_acquired_handler, GBusNameLostCallback name_lost_handler, IntPtr user_data, GDestroyNotify user_data_free_func);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_bus_own_name_on_connection(GDBusConnectionHandle connection, string name, GBusNameOwnerFlags flags, GBusNameAcquiredCallback name_acquired_handler, GBusNameLostCallback name_lost_handler, IntPtr user_data, GDestroyNotify user_data_free_func);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_bus_own_name_with_closures(GBusType bus_type, string name, GBusNameOwnerFlags flags, GClosureHandle bus_acquired_closure, GClosureHandle name_acquired_closure, GClosureHandle name_lost_closure);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_bus_own_name_on_connection_with_closures(GDBusConnectionHandle connection, string name, GBusNameOwnerFlags flags, GClosureHandle name_acquired_closure, GClosureHandle name_lost_closure);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_bus_unown_name(uint owner_id);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_bus_watch_name(GBusType bus_type, string name, GBusNameWatcherFlags flags, GBusNameAppearedCallback name_appeared_handler, GBusNameVanishedCallback name_vanished_handler, IntPtr user_data, GDestroyNotify user_data_free_func);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_bus_watch_name_on_connection(GDBusConnectionHandle connection, string name, GBusNameWatcherFlags flags, GBusNameAppearedCallback name_appeared_handler, GBusNameVanishedCallback name_vanished_handler, IntPtr user_data, GDestroyNotify user_data_free_func);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_bus_watch_name_with_closures(GBusType bus_type, string name, GBusNameWatcherFlags flags, GClosureHandle name_appeared_closure, GClosureHandle name_vanished_closure);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_bus_watch_name_on_connection_with_closures(GDBusConnectionHandle connection, string name, GBusNameWatcherFlags flags, GClosureHandle name_appeared_closure, GClosureHandle name_vanished_closure);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_bus_unwatch_name(uint watcher_id);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_object_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_object_get_object_path(GDBusObjectHandle @object);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_dbus_object_get_interfaces(GDBusObjectHandle @object);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusInterfaceHandle g_dbus_object_get_interface(GDBusObjectHandle @object, string interface_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_object_manager_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_object_manager_get_object_path(GDBusObjectManagerHandle manager);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_dbus_object_manager_get_objects(GDBusObjectManagerHandle manager);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusObjectHandle g_dbus_object_manager_get_object(GDBusObjectManagerHandle manager, string object_path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusInterfaceHandle g_dbus_object_manager_get_interface(GDBusObjectManagerHandle manager, string object_path, string interface_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_object_manager_client_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_object_manager_client_new(GDBusConnectionHandle connection, GDBusObjectManagerClientFlags flags, string name, string object_path, GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, GDestroyNotify get_proxy_type_destroy_notify, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusObjectManagerHandle g_dbus_object_manager_client_new_finish(GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusObjectManagerHandle g_dbus_object_manager_client_new_sync(GDBusConnectionHandle connection, GDBusObjectManagerClientFlags flags, string name, string object_path, GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, GDestroyNotify get_proxy_type_destroy_notify, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_object_manager_client_new_for_bus(GBusType bus_type, GDBusObjectManagerClientFlags flags, string name, string object_path, GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, GDestroyNotify get_proxy_type_destroy_notify, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusObjectManagerHandle g_dbus_object_manager_client_new_for_bus_finish(GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusObjectManagerHandle g_dbus_object_manager_client_new_for_bus_sync(GBusType bus_type, GDBusObjectManagerClientFlags flags, string name, string object_path, GDBusProxyTypeFunc get_proxy_type_func, IntPtr get_proxy_type_user_data, GDestroyNotify get_proxy_type_destroy_notify, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusConnectionHandle g_dbus_object_manager_client_get_connection(GDBusObjectManagerClientHandle manager);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusObjectManagerClientFlags g_dbus_object_manager_client_get_flags(GDBusObjectManagerClientHandle manager);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_object_manager_client_get_name(GDBusObjectManagerClientHandle manager);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_object_manager_client_get_name_owner(GDBusObjectManagerClientHandle manager);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_object_manager_server_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusObjectManagerServerHandle g_dbus_object_manager_server_new(string object_path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusConnectionHandle g_dbus_object_manager_server_get_connection(GDBusObjectManagerServerHandle manager);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_object_manager_server_set_connection(GDBusObjectManagerServerHandle manager, GDBusConnectionHandle connection);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_object_manager_server_export(GDBusObjectManagerServerHandle manager, GDBusObjectSkeletonHandle @object);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_object_manager_server_export_uniquely(GDBusObjectManagerServerHandle manager, GDBusObjectSkeletonHandle @object);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_object_manager_server_is_exported(GDBusObjectManagerServerHandle manager, GDBusObjectSkeletonHandle @object);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_object_manager_server_unexport(GDBusObjectManagerServerHandle manager, string object_path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_object_proxy_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusObjectProxyHandle g_dbus_object_proxy_new(GDBusConnectionHandle connection, string object_path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusConnectionHandle g_dbus_object_proxy_get_connection(GDBusObjectProxyHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_object_skeleton_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusObjectSkeletonHandle g_dbus_object_skeleton_new(string object_path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_object_skeleton_flush(GDBusObjectSkeletonHandle @object);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_object_skeleton_add_interface(GDBusObjectSkeletonHandle @object, GDBusInterfaceSkeletonHandle interface_);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_object_skeleton_remove_interface(GDBusObjectSkeletonHandle @object, GDBusInterfaceSkeletonHandle interface_);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_object_skeleton_remove_interface_by_name(GDBusObjectSkeletonHandle @object, string interface_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_object_skeleton_set_object_path(GDBusObjectSkeletonHandle @object, string object_path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_proxy_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_proxy_new(GDBusConnectionHandle connection, GDBusProxyFlags flags, GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusProxyHandle g_dbus_proxy_new_finish(GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusProxyHandle g_dbus_proxy_new_sync(GDBusConnectionHandle connection, GDBusProxyFlags flags, GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_proxy_new_for_bus(GBusType bus_type, GDBusProxyFlags flags, GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusProxyHandle g_dbus_proxy_new_for_bus_finish(GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusProxyHandle g_dbus_proxy_new_for_bus_sync(GBusType bus_type, GDBusProxyFlags flags, GDBusInterfaceInfoHandle info, string name, string object_path, string interface_name, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusConnectionHandle g_dbus_proxy_get_connection(GDBusProxyHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusProxyFlags g_dbus_proxy_get_flags(GDBusProxyHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_proxy_get_name(GDBusProxyHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_proxy_get_name_owner(GDBusProxyHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_proxy_get_object_path(GDBusProxyHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_proxy_get_interface_name(GDBusProxyHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_proxy_get_default_timeout(GDBusProxyHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_proxy_set_default_timeout(GDBusProxyHandle proxy, int timeout_msec);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusInterfaceInfoHandle g_dbus_proxy_get_interface_info(GDBusProxyHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_proxy_set_interface_info(GDBusProxyHandle proxy, GDBusInterfaceInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_dbus_proxy_get_cached_property(GDBusProxyHandle proxy, string property_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_proxy_set_cached_property(GDBusProxyHandle proxy, string property_name, GVariantHandle value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_dbus_proxy_get_cached_property_names(GDBusProxyHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_proxy_call(GDBusProxyHandle proxy, string method_name, GVariantHandle parameters, GDBusCallFlags flags, int timeout_msec, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_dbus_proxy_call_finish(GDBusProxyHandle proxy, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_dbus_proxy_call_sync(GDBusProxyHandle proxy, string method_name, GVariantHandle parameters, GDBusCallFlags flags, int timeout_msec, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_proxy_call_with_unix_fd_list(GDBusProxyHandle proxy, string method_name, GVariantHandle parameters, GDBusCallFlags flags, int timeout_msec, GUnixFDListHandle fd_list, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_dbus_proxy_call_with_unix_fd_list_finish(GDBusProxyHandle proxy, out GUnixFDListHandle out_fd_list, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_dbus_proxy_call_with_unix_fd_list_sync(GDBusProxyHandle proxy, string method_name, GVariantHandle parameters, GDBusCallFlags flags, int timeout_msec, GUnixFDListHandle fd_list, out GUnixFDListHandle out_fd_list, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_server_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusServerHandle g_dbus_server_new_sync(string address, GDBusServerFlags flags, string guid, GDBusAuthObserverHandle observer, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_server_get_client_address(GDBusServerHandle server);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_server_get_guid(GDBusServerHandle server);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDBusServerFlags g_dbus_server_get_flags(GDBusServerHandle server);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_server_start(GDBusServerHandle server);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_server_stop(GDBusServerHandle server);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_server_is_active(GDBusServerHandle server);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_is_guid(string @string);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_generate_guid();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_is_name(string @string);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_is_unique_name(string @string);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_is_member_name(string @string);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_is_interface_name(string @string);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dbus_is_error_name(string @string);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_gvariant_to_gvalue(GVariantHandle value, GValueHandle out_gvalue);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_dbus_gvalue_to_gvariant(GValueHandle gvalue, GVariantTypeHandle type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_escape_object_path_bytestring([NativeTypeName("const guint8 *")] byte* bytes);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dbus_escape_object_path(string s);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("guint8 *")]
	// public static extern byte* g_dbus_unescape_object_path(string s);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_debug_controller_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_debug_controller_get_debug_enabled(GDebugControllerHandle self);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_debug_controller_set_debug_enabled(GDebugControllerHandle self, int debug_enabled);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_debug_controller_dbus_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDebugControllerDBusHandle g_debug_controller_dbus_new(GDBusConnectionHandle connection, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_debug_controller_dbus_stop(GDebugControllerDBusHandle self);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_drive_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_drive_get_name(GDriveHandle drive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_drive_get_icon(GDriveHandle drive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_drive_get_symbolic_icon(GDriveHandle drive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_drive_has_volumes(GDriveHandle drive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_drive_get_volumes(GDriveHandle drive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_drive_is_removable(GDriveHandle drive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_drive_is_media_removable(GDriveHandle drive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_drive_has_media(GDriveHandle drive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_drive_is_media_check_automatic(GDriveHandle drive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_drive_can_poll_for_media(GDriveHandle drive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_drive_can_eject(GDriveHandle drive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_drive_eject(GDriveHandle drive, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern int g_drive_eject_finish(GDriveHandle drive, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_drive_poll_for_media(GDriveHandle drive, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_drive_poll_for_media_finish(GDriveHandle drive, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_drive_get_identifier(GDriveHandle drive, string kind);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_drive_enumerate_identifiers(GDriveHandle drive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDriveStartStopType g_drive_get_start_stop_type(GDriveHandle drive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_drive_can_start(GDriveHandle drive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_drive_can_start_degraded(GDriveHandle drive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_drive_start(GDriveHandle drive, GDriveStartFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_drive_start_finish(GDriveHandle drive, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_drive_can_stop(GDriveHandle drive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_drive_stop(GDriveHandle drive, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_drive_stop_finish(GDriveHandle drive, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_drive_eject_with_operation(GDriveHandle drive, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_drive_eject_with_operation_finish(GDriveHandle drive, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_drive_get_sort_key(GDriveHandle drive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dtls_connection_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dtls_connection_set_database(GDtlsConnectionHandle conn, GTlsDatabaseHandle database);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsDatabaseHandle g_dtls_connection_get_database(GDtlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dtls_connection_set_certificate(GDtlsConnectionHandle conn, GTlsCertificateHandle certificate);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateHandle g_dtls_connection_get_certificate(GDtlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dtls_connection_set_interaction(GDtlsConnectionHandle conn, GTlsInteractionHandle interaction);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsInteractionHandle g_dtls_connection_get_interaction(GDtlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateHandle g_dtls_connection_get_peer_certificate(GDtlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateFlags g_dtls_connection_get_peer_certificate_errors(GDtlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dtls_connection_set_require_close_notify(GDtlsConnectionHandle conn, int require_close_notify);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dtls_connection_get_require_close_notify(GDtlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_dtls_connection_set_rehandshake_mode(GDtlsConnectionHandle conn, GTlsRehandshakeMode mode);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern GTlsRehandshakeMode g_dtls_connection_get_rehandshake_mode(GDtlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dtls_connection_handshake(GDtlsConnectionHandle conn, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dtls_connection_handshake_async(GDtlsConnectionHandle conn, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dtls_connection_handshake_finish(GDtlsConnectionHandle conn, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dtls_connection_shutdown(GDtlsConnectionHandle conn, int shutdown_read, int shutdown_write, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dtls_connection_shutdown_async(GDtlsConnectionHandle conn, int shutdown_read, int shutdown_write, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dtls_connection_shutdown_finish(GDtlsConnectionHandle conn, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dtls_connection_close(GDtlsConnectionHandle conn, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dtls_connection_close_async(GDtlsConnectionHandle conn, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dtls_connection_close_finish(GDtlsConnectionHandle conn, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dtls_connection_emit_accept_certificate(GDtlsConnectionHandle conn, GTlsCertificateHandle peer_cert, GTlsCertificateFlags errors);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dtls_connection_set_advertised_protocols(GDtlsConnectionHandle conn, string protocols);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dtls_connection_get_negotiated_protocol(GDtlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_dtls_connection_get_channel_binding_data(GDtlsConnectionHandle conn, GTlsChannelBindingType type, GByteArrayHandle data, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsProtocolVersion g_dtls_connection_get_protocol_version(GDtlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_dtls_connection_get_ciphersuite_name(GDtlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dtls_client_connection_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDatagramBasedHandle g_dtls_client_connection_new(GDatagramBasedHandle base_socket, GSocketConnectableHandle server_identity, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateFlags g_dtls_client_connection_get_validation_flags(GDtlsClientConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dtls_client_connection_set_validation_flags(GDtlsClientConnectionHandle conn, GTlsCertificateFlags flags);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectableHandle g_dtls_client_connection_get_server_identity(GDtlsClientConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dtls_client_connection_set_server_identity(GDtlsClientConnectionHandle conn, GSocketConnectableHandle identity);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_dtls_client_connection_get_accepted_cas(GDtlsClientConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dtls_server_connection_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDatagramBasedHandle g_dtls_server_connection_new(GDatagramBasedHandle base_socket, GTlsCertificateHandle certificate, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_icon_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_icon_hash(IntPtr icon);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_icon_equal(GIconHandle icon1, GIconHandle icon2);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_icon_to_string(GIconHandle icon);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_icon_new_for_string(string str, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_icon_serialize(GIconHandle icon);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_icon_deserialize(GVariantHandle value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_emblem_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GEmblemHandle g_emblem_new(GIconHandle icon);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GEmblemHandle g_emblem_new_with_origin(GIconHandle icon, GEmblemOrigin origin);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_emblem_get_icon(GEmblemHandle emblem);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GEmblemOrigin g_emblem_get_origin(GEmblemHandle emblem);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_emblemed_icon_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_emblemed_icon_new(GIconHandle icon, GEmblemHandle emblem);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_emblemed_icon_get_icon(GEmblemedIconHandle emblemed);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_emblemed_icon_get_emblems(GEmblemedIconHandle emblemed);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_emblemed_icon_add_emblem(GEmblemedIconHandle emblemed, GEmblemHandle emblem);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_emblemed_icon_clear_emblems(GEmblemedIconHandle emblemed);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_new_for_path(string path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_new_for_uri(string uri);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_new_for_commandline_arg(string arg);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_new_for_commandline_arg_and_cwd(string arg, string cwd);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_new_tmp(string tmpl, out GFileIOStreamHandle iostream, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_parse_name(string parse_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_new_build_filename(string first_element, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_dup(GFileHandle file);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_file_hash(IntPtr file);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_equal(GFileHandle file1, GFileHandle file2);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_get_basename(GFileHandle file);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_get_path(GFileHandle file);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_peek_path(GFileHandle file);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_get_uri(GFileHandle file);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_get_parse_name(GFileHandle file);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_get_parent(GFileHandle file);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_has_parent(GFileHandle file, GFileHandle parent);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_get_child(GFileHandle file, string name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_get_child_for_display_name(GFileHandle file, string display_name, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_has_prefix(GFileHandle file, GFileHandle prefix);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_get_relative_path(GFileHandle parent, GFileHandle descendant);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_resolve_relative_path(GFileHandle file, string relative_path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_is_native(GFileHandle file);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_has_uri_scheme(GFileHandle file, string uri_scheme);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_get_uri_scheme(GFileHandle file);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileInputStreamHandle g_file_read(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_read_async(GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileInputStreamHandle g_file_read_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileOutputStreamHandle g_file_append_to(GFileHandle file, GFileCreateFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileOutputStreamHandle g_file_create(GFileHandle file, GFileCreateFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileOutputStreamHandle g_file_replace(GFileHandle file, string etag, int make_backup, GFileCreateFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_append_to_async(GFileHandle file, GFileCreateFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileOutputStreamHandle g_file_append_to_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_create_async(GFileHandle file, GFileCreateFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileOutputStreamHandle g_file_create_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_replace_async(GFileHandle file, string etag, int make_backup, GFileCreateFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileOutputStreamHandle g_file_replace_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileIOStreamHandle g_file_open_readwrite(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_open_readwrite_async(GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileIOStreamHandle g_file_open_readwrite_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileIOStreamHandle g_file_create_readwrite(GFileHandle file, GFileCreateFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_create_readwrite_async(GFileHandle file, GFileCreateFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileIOStreamHandle g_file_create_readwrite_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileIOStreamHandle g_file_replace_readwrite(GFileHandle file, string etag, int make_backup, GFileCreateFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_replace_readwrite_async(GFileHandle file, string etag, int make_backup, GFileCreateFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileIOStreamHandle g_file_replace_readwrite_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_query_exists(GFileHandle file, GCancellableHandle cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileType g_file_query_file_type(GFileHandle file, GFileQueryInfoFlags flags, GCancellableHandle cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileInfoHandle g_file_query_info(GFileHandle file, string attributes, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_query_info_async(GFileHandle file, string attributes, GFileQueryInfoFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileInfoHandle g_file_query_info_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileInfoHandle g_file_query_filesystem_info(GFileHandle file, string attributes, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_query_filesystem_info_async(GFileHandle file, string attributes, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileInfoHandle g_file_query_filesystem_info_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GMountHandle g_file_find_enclosing_mount(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_find_enclosing_mount_async(GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GMountHandle g_file_find_enclosing_mount_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileEnumeratorHandle g_file_enumerate_children(GFileHandle file, string attributes, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_enumerate_children_async(GFileHandle file, string attributes, GFileQueryInfoFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileEnumeratorHandle g_file_enumerate_children_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_set_display_name(GFileHandle file, string display_name, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_set_display_name_async(GFileHandle file, string display_name, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_set_display_name_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_delete(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_delete_async(GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_delete_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_trash(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_trash_async(GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_trash_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_copy(GFileHandle source, GFileHandle destination, GFileCopyFlags flags, GCancellableHandle cancellable, GFileProgressCallback progress_callback, IntPtr progress_callback_data, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_copy_async(GFileHandle source, GFileHandle destination, GFileCopyFlags flags, int io_priority, GCancellableHandle cancellable, GFileProgressCallback progress_callback, IntPtr progress_callback_data, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_copy_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_move(GFileHandle source, GFileHandle destination, GFileCopyFlags flags, GCancellableHandle cancellable, GFileProgressCallback progress_callback, IntPtr progress_callback_data, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_move_async(GFileHandle source, GFileHandle destination, GFileCopyFlags flags, int io_priority, GCancellableHandle cancellable, GFileProgressCallback progress_callback, IntPtr progress_callback_data, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_move_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_make_directory(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_make_directory_async(GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_make_directory_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_make_directory_with_parents(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_make_symbolic_link(GFileHandle file, string symlink_value, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileAttributeInfoListHandle g_file_query_settable_attributes(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileAttributeInfoListHandle g_file_query_writable_namespaces(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_set_attribute(GFileHandle file, string attribute, GFileAttributeType type, IntPtr value_p, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_set_attributes_from_info(GFileHandle file, GFileInfoHandle info, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_set_attributes_async(GFileHandle file, GFileInfoHandle info, GFileQueryInfoFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_set_attributes_finish(GFileHandle file, GAsyncResultHandle result, out GFileInfoHandle info, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_set_attribute_string(GFileHandle file, string attribute, string value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_set_attribute_byte_string(GFileHandle file, string attribute, string value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_set_attribute_uint32(GFileHandle file, string attribute, uint value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_set_attribute_int32(GFileHandle file, string attribute, int value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_set_attribute_uint64(GFileHandle file, string attribute, nuint value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_set_attribute_int64(GFileHandle file, string attribute, nint value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_mount_enclosing_volume(GFileHandle location, GMountMountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_mount_enclosing_volume_finish(GFileHandle location, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_mount_mountable(GFileHandle file, GMountMountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_mount_mountable_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_file_unmount_mountable(GFileHandle file, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern int g_file_unmount_mountable_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_unmount_mountable_with_operation(GFileHandle file, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_unmount_mountable_with_operation_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_file_eject_mountable(GFileHandle file, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern int g_file_eject_mountable_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_eject_mountable_with_operation(GFileHandle file, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_eject_mountable_with_operation_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_build_attribute_list_for_copy(GFileHandle file, GFileCopyFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_copy_attributes(GFileHandle source, GFileHandle destination, GFileCopyFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileMonitorHandle g_file_monitor_directory(GFileHandle file, GFileMonitorFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileMonitorHandle g_file_monitor_file(GFileHandle file, GFileMonitorFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileMonitorHandle g_file_monitor(GFileHandle file, GFileMonitorFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_measure_disk_usage(GFileHandle file, GFileMeasureFlags flags, GCancellableHandle cancellable, GFileMeasureProgressCallback progress_callback, IntPtr progress_data, [NativeTypeName("guint64 *")] nuint* disk_usage, [NativeTypeName("guint64 *")] nuint* num_dirs, [NativeTypeName("guint64 *")] nuint* num_files, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_measure_disk_usage_async(GFileHandle file, GFileMeasureFlags flags, int io_priority, GCancellableHandle cancellable, GFileMeasureProgressCallback progress_callback, IntPtr progress_data, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_measure_disk_usage_finish(GFileHandle file, GAsyncResultHandle result, [NativeTypeName("guint64 *")] nuint* disk_usage, [NativeTypeName("guint64 *")] nuint* num_dirs, [NativeTypeName("guint64 *")] nuint* num_files, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_start_mountable(GFileHandle file, GDriveStartFlags flags, GMountOperationHandle start_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_start_mountable_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_stop_mountable(GFileHandle file, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_stop_mountable_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_poll_mountable(GFileHandle file, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_poll_mountable_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GAppInfoHandle g_file_query_default_handler(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_query_default_handler_async(GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GAppInfoHandle g_file_query_default_handler_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_load_contents(GFileHandle file, GCancellableHandle cancellable, string[] contents, [NativeTypeName("gsize *")] nuint* length, string[] etag_out, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_load_contents_async(GFileHandle file, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_load_contents_finish(GFileHandle file, GAsyncResultHandle res, string[] contents, [NativeTypeName("gsize *")] nuint* length, string[] etag_out, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_load_partial_contents_async(GFileHandle file, GCancellableHandle cancellable, GFileReadMoreCallback read_more_callback, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_load_partial_contents_finish(GFileHandle file, GAsyncResultHandle res, string[] contents, [NativeTypeName("gsize *")] nuint* length, string[] etag_out, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_replace_contents(GFileHandle file, string contents, nuint length, string etag, int make_backup, GFileCreateFlags flags, string[] new_etag, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_replace_contents_async(GFileHandle file, string contents, nuint length, string etag, int make_backup, GFileCreateFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_replace_contents_bytes_async(GFileHandle file, GBytesHandle contents, string etag, int make_backup, GFileCreateFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_replace_contents_finish(GFileHandle file, GAsyncResultHandle res, string[] new_etag, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_supports_thread_contexts(GFileHandle file);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GBytesHandle g_file_load_bytes(GFileHandle file, GCancellableHandle cancellable, string[] etag_out, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_load_bytes_async(GFileHandle file, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GBytesHandle g_file_load_bytes_finish(GFileHandle file, GAsyncResultHandle result, string[] etag_out, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_attribute_info_list_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileAttributeInfoListHandle g_file_attribute_info_list_new();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileAttributeInfoListHandle g_file_attribute_info_list_ref(GFileAttributeInfoListHandle list);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_attribute_info_list_unref(GFileAttributeInfoListHandle list);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileAttributeInfoListHandle g_file_attribute_info_list_dup(GFileAttributeInfoListHandle list);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileAttributeInfoHandle g_file_attribute_info_list_lookup(GFileAttributeInfoListHandle list, string name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_attribute_info_list_add(GFileAttributeInfoListHandle list, string name, GFileAttributeType type, GFileAttributeInfoFlags flags);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_enumerator_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileInfoHandle g_file_enumerator_next_file(GFileEnumeratorHandle enumerator, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_enumerator_close(GFileEnumeratorHandle enumerator, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_enumerator_next_files_async(GFileEnumeratorHandle enumerator, int num_files, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_file_enumerator_next_files_finish(GFileEnumeratorHandle enumerator, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_enumerator_close_async(GFileEnumeratorHandle enumerator, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_enumerator_close_finish(GFileEnumeratorHandle enumerator, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_enumerator_is_closed(GFileEnumeratorHandle enumerator);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_enumerator_has_pending(GFileEnumeratorHandle enumerator);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_enumerator_set_pending(GFileEnumeratorHandle enumerator, int pending);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_enumerator_get_container(GFileEnumeratorHandle enumerator);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_enumerator_get_child(GFileEnumeratorHandle enumerator, GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_enumerator_iterate(GFileEnumeratorHandle direnum, out GFileInfoHandle out_info, out GFileHandle out_child, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_icon_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_file_icon_new(GFileHandle file);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_file_icon_get_file(GFileIconHandle icon);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_info_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileInfoHandle g_file_info_new();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileInfoHandle g_file_info_dup(GFileInfoHandle other);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_copy_into(GFileInfoHandle src_info, GFileInfoHandle dest_info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_info_has_attribute(GFileInfoHandle info, string attribute);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_info_has_namespace(GFileInfoHandle info, string name_space);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_file_info_list_attributes(GFileInfoHandle info, string name_space);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_info_get_attribute_data(GFileInfoHandle info, string attribute, GFileAttributeType* type, [NativeTypeName("gpointer *")] void** value_pp, GFileAttributeStatus* status);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileAttributeType g_file_info_get_attribute_type(GFileInfoHandle info, string attribute);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_remove_attribute(GFileInfoHandle info, string attribute);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileAttributeStatus g_file_info_get_attribute_status(GFileInfoHandle info, string attribute);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_info_set_attribute_status(GFileInfoHandle info, string attribute, GFileAttributeStatus status);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_info_get_attribute_as_string(GFileInfoHandle info, string attribute);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_info_get_attribute_string(GFileInfoHandle info, string attribute);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_info_get_attribute_byte_string(GFileInfoHandle info, string attribute);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_info_get_attribute_boolean(GFileInfoHandle info, string attribute);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_file_info_get_attribute_uint32(GFileInfoHandle info, string attribute);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_info_get_attribute_int32(GFileInfoHandle info, string attribute);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nuint g_file_info_get_attribute_uint64(GFileInfoHandle info, string attribute);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_file_info_get_attribute_int64(GFileInfoHandle info, string attribute);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GObjectHandle g_file_info_get_attribute_object(GFileInfoHandle info, string attribute);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_file_info_get_attribute_stringv(GFileInfoHandle info, string attribute);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_attribute(GFileInfoHandle info, string attribute, GFileAttributeType type, IntPtr value_p);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_attribute_string(GFileInfoHandle info, string attribute, string attr_value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_attribute_byte_string(GFileInfoHandle info, string attribute, string attr_value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_attribute_boolean(GFileInfoHandle info, string attribute, int attr_value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_attribute_uint32(GFileInfoHandle info, string attribute, uint attr_value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_attribute_int32(GFileInfoHandle info, string attribute, int attr_value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_attribute_uint64(GFileInfoHandle info, string attribute, nuint attr_value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_attribute_int64(GFileInfoHandle info, string attribute, nint attr_value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_attribute_object(GFileInfoHandle info, string attribute, GObjectHandle attr_value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_attribute_stringv(GFileInfoHandle info, string attribute, string[] attr_value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_clear_status(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDateTimeHandle g_file_info_get_deletion_date(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileType g_file_info_get_file_type(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_info_get_is_hidden(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_info_get_is_backup(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_info_get_is_symlink(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_info_get_name(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_info_get_display_name(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_info_get_edit_name(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_file_info_get_icon(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_file_info_get_symbolic_icon(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_info_get_content_type(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_file_info_get_size(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_file_info_get_modification_time(GFileInfoHandle info, GTimeValHandle result);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDateTimeHandle g_file_info_get_modification_date_time(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDateTimeHandle g_file_info_get_access_date_time(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDateTimeHandle g_file_info_get_creation_date_time(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_info_get_symlink_target(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_info_get_etag(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_info_get_sort_order(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_attribute_mask(GFileInfoHandle info, GFileAttributeMatcherHandle mask);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_unset_attribute_mask(GFileInfoHandle info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_file_type(GFileInfoHandle info, GFileType type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_is_hidden(GFileInfoHandle info, int is_hidden);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_is_symlink(GFileInfoHandle info, int is_symlink);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_name(GFileInfoHandle info, string name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_display_name(GFileInfoHandle info, string display_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_edit_name(GFileInfoHandle info, string edit_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_icon(GFileInfoHandle info, GIconHandle icon);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_symbolic_icon(GFileInfoHandle info, GIconHandle icon);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_content_type(GFileInfoHandle info, string content_type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_size(GFileInfoHandle info, nint size);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_file_info_set_modification_time(GFileInfoHandle info, GTimeValHandle mtime);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_modification_date_time(GFileInfoHandle info, GDateTimeHandle mtime);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_access_date_time(GFileInfoHandle info, GDateTimeHandle atime);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_creation_date_time(GFileInfoHandle info, GDateTimeHandle creation_time);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_symlink_target(GFileInfoHandle info, string symlink_target);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_info_set_sort_order(GFileInfoHandle info, int sort_order);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_attribute_matcher_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileAttributeMatcherHandle g_file_attribute_matcher_new(string attributes);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileAttributeMatcherHandle g_file_attribute_matcher_ref(GFileAttributeMatcherHandle matcher);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_attribute_matcher_unref(GFileAttributeMatcherHandle matcher);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileAttributeMatcherHandle g_file_attribute_matcher_subtract(GFileAttributeMatcherHandle matcher, GFileAttributeMatcherHandle subtract);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_attribute_matcher_matches(GFileAttributeMatcherHandle matcher, string attribute);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_attribute_matcher_matches_only(GFileAttributeMatcherHandle matcher, string attribute);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_attribute_matcher_enumerate_namespace(GFileAttributeMatcherHandle matcher, string ns);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_attribute_matcher_enumerate_next(GFileAttributeMatcherHandle matcher);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_attribute_matcher_to_string(GFileAttributeMatcherHandle matcher);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_input_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileInfoHandle g_file_input_stream_query_info(GFileInputStreamHandle stream, string attributes, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_input_stream_query_info_async(GFileInputStreamHandle stream, string attributes, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileInfoHandle g_file_input_stream_query_info_finish(GFileInputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GQuark g_io_error_quark();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOErrorEnum g_io_error_from_errno(int err_no);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_io_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInputStreamHandle g_io_stream_get_input_stream(GIOStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GOutputStreamHandle g_io_stream_get_output_stream(GIOStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_io_stream_splice_async(GIOStreamHandle stream1, GIOStreamHandle stream2, GIOStreamSpliceFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_io_stream_splice_finish(GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_io_stream_close(GIOStreamHandle stream, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_io_stream_close_async(GIOStreamHandle stream, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_io_stream_close_finish(GIOStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_io_stream_is_closed(GIOStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_io_stream_has_pending(GIOStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_io_stream_set_pending(GIOStreamHandle stream, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_io_stream_clear_pending(GIOStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_io_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileInfoHandle g_file_io_stream_query_info(GFileIOStreamHandle stream, string attributes, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_io_stream_query_info_async(GFileIOStreamHandle stream, string attributes, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileInfoHandle g_file_io_stream_query_info_finish(GFileIOStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_io_stream_get_etag(GFileIOStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_monitor_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_monitor_cancel(GFileMonitorHandle monitor);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_file_monitor_is_cancelled(GFileMonitorHandle monitor);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_monitor_set_rate_limit(GFileMonitorHandle monitor, int limit_msecs);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_monitor_emit_event(GFileMonitorHandle monitor, GFileHandle child, GFileHandle other_file, GFileMonitorEvent event_type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_filename_completer_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFilenameCompleterHandle g_filename_completer_new();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_filename_completer_get_completion_suffix(GFilenameCompleterHandle completer, string initial_text);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_filename_completer_get_completions(GFilenameCompleterHandle completer, string initial_text);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_filename_completer_set_dirs_only(GFilenameCompleterHandle completer, int dirs_only);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_output_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileInfoHandle g_file_output_stream_query_info(GFileOutputStreamHandle stream, string attributes, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_file_output_stream_query_info_async(GFileOutputStreamHandle stream, string attributes, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileInfoHandle g_file_output_stream_query_info_finish(GFileOutputStreamHandle stream, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_file_output_stream_get_etag(GFileOutputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_inet_address_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInetAddressHandle g_inet_address_new_from_string(string @string);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInetAddressHandle g_inet_address_new_from_bytes([NativeTypeName("const guint8 *")] byte* bytes, GSocketFamily family);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInetAddressHandle g_inet_address_new_loopback(GSocketFamily family);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInetAddressHandle g_inet_address_new_any(GSocketFamily family);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_inet_address_equal(GInetAddressHandle address, GInetAddressHandle other_address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_inet_address_to_string(GInetAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [return: NativeTypeName("const guint8 *")]
	// public static extern byte* g_inet_address_to_bytes(GInetAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nuint g_inet_address_get_native_size(GInetAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketFamily g_inet_address_get_family(GInetAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_inet_address_get_is_any(GInetAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_inet_address_get_is_loopback(GInetAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_inet_address_get_is_link_local(GInetAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_inet_address_get_is_site_local(GInetAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_inet_address_get_is_multicast(GInetAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_inet_address_get_is_mc_global(GInetAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_inet_address_get_is_mc_link_local(GInetAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_inet_address_get_is_mc_node_local(GInetAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_inet_address_get_is_mc_org_local(GInetAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_inet_address_get_is_mc_site_local(GInetAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_inet_address_mask_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInetAddressMaskHandle g_inet_address_mask_new(GInetAddressHandle addr, uint length, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInetAddressMaskHandle g_inet_address_mask_new_from_string(string mask_string, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_inet_address_mask_to_string(GInetAddressMaskHandle mask);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketFamily g_inet_address_mask_get_family(GInetAddressMaskHandle mask);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInetAddressHandle g_inet_address_mask_get_address(GInetAddressMaskHandle mask);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_inet_address_mask_get_length(GInetAddressMaskHandle mask);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_inet_address_mask_matches(GInetAddressMaskHandle mask, GInetAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_inet_address_mask_equal(GInetAddressMaskHandle mask, GInetAddressMaskHandle mask2);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_socket_address_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketFamily g_socket_address_get_family(GSocketAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketAddressHandle g_socket_address_new_from_native(IntPtr native, nuint len);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_address_to_native(GSocketAddressHandle address, IntPtr dest, nuint destlen, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_socket_address_get_native_size(GSocketAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_inet_socket_address_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketAddressHandle g_inet_socket_address_new(GInetAddressHandle address, ushort port);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketAddressHandle g_inet_socket_address_new_from_string(string address, uint port);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInetAddressHandle g_inet_socket_address_get_address(GInetSocketAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern ushort g_inet_socket_address_get_port(GInetSocketAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_inet_socket_address_get_flowinfo(GInetSocketAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_inet_socket_address_get_scope_id(GInetSocketAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_app_info_create_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_converter_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_converter_result_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_data_stream_byte_order_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_data_stream_newline_type_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_attribute_type_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_attribute_info_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_attribute_status_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_query_info_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_create_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_measure_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_mount_mount_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_mount_unmount_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_drive_start_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_drive_start_stop_type_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_copy_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_monitor_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_type_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_filesystem_preview_type_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_file_monitor_event_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_io_error_enum_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_ask_password_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_password_save_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_mount_operation_result_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_output_stream_splice_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_io_stream_splice_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_emblem_origin_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_resolver_error_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_resolver_record_type_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_resource_error_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_resource_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_resource_lookup_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_socket_family_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_socket_type_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_socket_msg_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_socket_protocol_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_zlib_compressor_format_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_unix_socket_address_type_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_bus_type_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_bus_name_owner_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_bus_name_watcher_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_proxy_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_error_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_connection_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_capability_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_call_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_message_type_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_message_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_message_header_field_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_property_info_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_subtree_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_server_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_signal_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_send_message_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_credentials_type_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_message_byte_order_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_application_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_error_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_certificate_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_authentication_mode_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_channel_binding_type_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_channel_binding_error_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_rehandshake_mode_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_password_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_interaction_result_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_interface_skeleton_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_dbus_object_manager_client_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_database_verify_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_database_lookup_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_certificate_request_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_protocol_version_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_io_module_scope_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_socket_client_event_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_socket_listener_event_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_test_dbus_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_subprocess_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_notification_priority_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_network_connectivity_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_pollable_return_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_memory_monitor_warning_level_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_resolver_name_lookup_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_settings_bind_flags_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOModuleScopeHandle g_io_module_scope_new(GIOModuleScopeFlags flags);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_io_module_scope_free(GIOModuleScopeHandle scope);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_io_module_scope_block(GIOModuleScopeHandle scope, string basename);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_io_module_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOModuleHandle g_io_module_new(string filename);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_io_modules_scan_all_in_directory(string dirname);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_io_modules_load_all_in_directory(string dirname);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_io_modules_scan_all_in_directory_with_scope(string dirname, GIOModuleScopeHandle scope);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_io_modules_load_all_in_directory_with_scope(string dirname, GIOModuleScopeHandle scope);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOExtensionPointHandle g_io_extension_point_register(string name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOExtensionPointHandle g_io_extension_point_lookup(string name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_io_extension_point_set_required_type(GIOExtensionPointHandle extension_point, GType type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_io_extension_point_get_required_type(GIOExtensionPointHandle extension_point);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_io_extension_point_get_extensions(GIOExtensionPointHandle extension_point);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOExtensionHandle g_io_extension_point_get_extension_by_name(GIOExtensionPointHandle extension_point, string name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOExtensionHandle g_io_extension_point_implement(string extension_point_name, GType type, string extension_name, int priority);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_io_extension_get_type(GIOExtensionHandle extension);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_io_extension_get_name(GIOExtensionHandle extension);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_io_extension_get_priority(GIOExtensionHandle extension);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTypeClassHandle g_io_extension_ref_class(GIOExtensionHandle extension);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_io_module_load(GIOModuleHandle module);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_io_module_unload(GIOModuleHandle module);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_io_module_query();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete("GThreadPool or g_task_run_in_thread")]
	// public static extern void g_io_scheduler_push_job(GIOSchedulerJobFunc job_func, IntPtr user_data, GDestroyNotify notify, int io_priority, GCancellableHandle cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_io_scheduler_cancel_all_jobs();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern int g_io_scheduler_job_send_to_mainloop(GIOSchedulerJobHandle job, [NativeTypeName("GSourceFunc")] IntPtr func, IntPtr user_data, GDestroyNotify notify);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_io_scheduler_job_send_to_mainloop_async(GIOSchedulerJobHandle job, [NativeTypeName("GSourceFunc")] IntPtr func, IntPtr user_data, GDestroyNotify notify);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_list_model_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_list_model_get_item_type(GListModelHandle list);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_list_model_get_n_items(GListModelHandle list);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern IntPtr g_list_model_get_item(GListModelHandle list, uint position);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GObjectHandle g_list_model_get_object(GListModelHandle list, uint position);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_list_model_items_changed(GListModelHandle list, uint position, uint removed, uint added);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_list_store_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListStoreHandle g_list_store_new(GType item_type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_list_store_insert(GListStoreHandle store, uint position, IntPtr item);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_list_store_insert_sorted(GListStoreHandle store, IntPtr item, [NativeTypeName("GCompareDataFunc")] IntPtr compare_func, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_list_store_sort(GListStoreHandle store, [NativeTypeName("GCompareDataFunc")] IntPtr compare_func, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_list_store_append(GListStoreHandle store, IntPtr item);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_list_store_remove(GListStoreHandle store, uint position);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_list_store_remove_all(GListStoreHandle store);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_list_store_splice(GListStoreHandle store, uint position, uint n_removals, [NativeTypeName("gpointer *")] void** additions, uint n_additions);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_list_store_find(GListStoreHandle store, IntPtr item, [NativeTypeName("guint *")] uint* position);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_list_store_find_with_equal_func(GListStoreHandle store, IntPtr item, [NativeTypeName("GEqualFunc")] IntPtr equal_func, [NativeTypeName("guint *")] uint* position);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_loadable_icon_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInputStreamHandle g_loadable_icon_load(GLoadableIconHandle icon, int size, string[] type, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_loadable_icon_load_async(GLoadableIconHandle icon, int size, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInputStreamHandle g_loadable_icon_load_finish(GLoadableIconHandle icon, GAsyncResultHandle res, string[] type, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_memory_input_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInputStreamHandle g_memory_input_stream_new();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInputStreamHandle g_memory_input_stream_new_from_data([NativeTypeName("const void *")] void* data, nint len, GDestroyNotify destroy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInputStreamHandle g_memory_input_stream_new_from_bytes(GBytesHandle bytes);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_memory_input_stream_add_data(GMemoryInputStreamHandle stream, [NativeTypeName("const void *")] void* data, nint len, GDestroyNotify destroy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_memory_input_stream_add_bytes(GMemoryInputStreamHandle stream, GBytesHandle bytes);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_memory_monitor_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GMemoryMonitorHandle g_memory_monitor_dup_default();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_memory_output_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GOutputStreamHandle g_memory_output_stream_new(IntPtr data, nuint size, GReallocFunc realloc_function, GDestroyNotify destroy_function);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GOutputStreamHandle g_memory_output_stream_new_resizable();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern IntPtr g_memory_output_stream_get_data(GMemoryOutputStreamHandle ostream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nuint g_memory_output_stream_get_size(GMemoryOutputStreamHandle ostream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nuint g_memory_output_stream_get_data_size(GMemoryOutputStreamHandle ostream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern IntPtr g_memory_output_stream_steal_data(GMemoryOutputStreamHandle ostream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GBytesHandle g_memory_output_stream_steal_as_bytes(GMemoryOutputStreamHandle ostream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_menu_model_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_menu_model_is_mutable(GMenuModelHandle model);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_menu_model_get_n_items(GMenuModelHandle model);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GMenuAttributeIterHandle g_menu_model_iterate_item_attributes(GMenuModelHandle model, int item_index);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_menu_model_get_item_attribute_value(GMenuModelHandle model, int item_index, string attribute, GVariantTypeHandle expected_type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_menu_model_get_item_attribute(GMenuModelHandle model, int item_index, string attribute, string format_string, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GMenuLinkIterHandle g_menu_model_iterate_item_links(GMenuModelHandle model, int item_index);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GMenuModelHandle g_menu_model_get_item_link(GMenuModelHandle model, int item_index, string link);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_model_items_changed(GMenuModelHandle model, int position, int removed, int added);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_menu_attribute_iter_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_menu_attribute_iter_get_next(GMenuAttributeIterHandle iter, [NativeTypeName("const gchar **")] sbyte** out_name, out GVariantHandle value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_menu_attribute_iter_next(GMenuAttributeIterHandle iter);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_menu_attribute_iter_get_name(GMenuAttributeIterHandle iter);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_menu_attribute_iter_get_value(GMenuAttributeIterHandle iter);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_menu_link_iter_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_menu_link_iter_get_next(GMenuLinkIterHandle iter, [NativeTypeName("const gchar **")] sbyte** out_link, out GMenuModelHandle value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_menu_link_iter_next(GMenuLinkIterHandle iter);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_menu_link_iter_get_name(GMenuLinkIterHandle iter);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GMenuModelHandle g_menu_link_iter_get_value(GMenuLinkIterHandle iter);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_menu_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GMenuHandle g_menu_new();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_freeze(GMenuHandle menu);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_insert_item(GMenuHandle menu, int position, GMenuItemHandle item);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_prepend_item(GMenuHandle menu, GMenuItemHandle item);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_append_item(GMenuHandle menu, GMenuItemHandle item);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_remove(GMenuHandle menu, int position);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_remove_all(GMenuHandle menu);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_insert(GMenuHandle menu, int position, string label, string detailed_action);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_prepend(GMenuHandle menu, string label, string detailed_action);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_append(GMenuHandle menu, string label, string detailed_action);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_insert_section(GMenuHandle menu, int position, string label, GMenuModelHandle section);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_prepend_section(GMenuHandle menu, string label, GMenuModelHandle section);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_append_section(GMenuHandle menu, string label, GMenuModelHandle section);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_insert_submenu(GMenuHandle menu, int position, string label, GMenuModelHandle submenu);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_prepend_submenu(GMenuHandle menu, string label, GMenuModelHandle submenu);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_append_submenu(GMenuHandle menu, string label, GMenuModelHandle submenu);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_menu_item_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GMenuItemHandle g_menu_item_new(string label, string detailed_action);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GMenuItemHandle g_menu_item_new_from_model(GMenuModelHandle model, int item_index);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GMenuItemHandle g_menu_item_new_submenu(string label, GMenuModelHandle submenu);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GMenuItemHandle g_menu_item_new_section(string label, GMenuModelHandle section);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_menu_item_get_attribute_value(GMenuItemHandle menu_item, string attribute, GVariantTypeHandle expected_type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_menu_item_get_attribute(GMenuItemHandle menu_item, string attribute, string format_string, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GMenuModelHandle g_menu_item_get_link(GMenuItemHandle menu_item, string link);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_item_set_attribute_value(GMenuItemHandle menu_item, string attribute, GVariantHandle value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_item_set_attribute(GMenuItemHandle menu_item, string attribute, string format_string, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_item_set_link(GMenuItemHandle menu_item, string link, GMenuModelHandle model);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_item_set_label(GMenuItemHandle menu_item, string label);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_item_set_submenu(GMenuItemHandle menu_item, GMenuModelHandle submenu);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_item_set_section(GMenuItemHandle menu_item, GMenuModelHandle section);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_item_set_action_and_target_value(GMenuItemHandle menu_item, string action, GVariantHandle target_value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_item_set_action_and_target(GMenuItemHandle menu_item, string action, string format_string, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_item_set_detailed_action(GMenuItemHandle menu_item, string detailed_action);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_menu_item_set_icon(GMenuItemHandle menu_item, GIconHandle icon);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_dbus_connection_export_menu_model(GDBusConnectionHandle connection, string object_path, GMenuModelHandle menu, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_dbus_connection_unexport_menu_model(GDBusConnectionHandle connection, uint export_id);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_mount_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_mount_get_root(GMountHandle mount);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_mount_get_default_location(GMountHandle mount);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_mount_get_name(GMountHandle mount);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_mount_get_icon(GMountHandle mount);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_mount_get_symbolic_icon(GMountHandle mount);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_mount_get_uuid(GMountHandle mount);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVolumeHandle g_mount_get_volume(GMountHandle mount);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDriveHandle g_mount_get_drive(GMountHandle mount);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_mount_can_unmount(GMountHandle mount);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_mount_can_eject(GMountHandle mount);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_mount_unmount(GMountHandle mount, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern int g_mount_unmount_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_mount_eject(GMountHandle mount, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern int g_mount_eject_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_mount_remount(GMountHandle mount, GMountMountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_mount_remount_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_mount_guess_content_type(GMountHandle mount, int force_rescan, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_mount_guess_content_type_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_mount_guess_content_type_sync(GMountHandle mount, int force_rescan, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_mount_is_shadowed(GMountHandle mount);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_mount_shadow(GMountHandle mount);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_mount_unshadow(GMountHandle mount);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_mount_unmount_with_operation(GMountHandle mount, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_mount_unmount_with_operation_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_mount_eject_with_operation(GMountHandle mount, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_mount_eject_with_operation_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_mount_get_sort_key(GMountHandle mount);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_mount_operation_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GMountOperationHandle g_mount_operation_new();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_mount_operation_get_username(GMountOperationHandle op);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_mount_operation_set_username(GMountOperationHandle op, string username);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_mount_operation_get_password(GMountOperationHandle op);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_mount_operation_set_password(GMountOperationHandle op, string password);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_mount_operation_get_anonymous(GMountOperationHandle op);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_mount_operation_set_anonymous(GMountOperationHandle op, int anonymous);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_mount_operation_get_domain(GMountOperationHandle op);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_mount_operation_set_domain(GMountOperationHandle op, string domain);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GPasswordSave g_mount_operation_get_password_save(GMountOperationHandle op);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_mount_operation_set_password_save(GMountOperationHandle op, GPasswordSave save);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_mount_operation_get_choice(GMountOperationHandle op);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_mount_operation_set_choice(GMountOperationHandle op, int choice);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_mount_operation_reply(GMountOperationHandle op, GMountOperationResult result);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_mount_operation_get_is_tcrypt_hidden_volume(GMountOperationHandle op);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_mount_operation_set_is_tcrypt_hidden_volume(GMountOperationHandle op, int hidden_volume);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_mount_operation_get_is_tcrypt_system_volume(GMountOperationHandle op);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_mount_operation_set_is_tcrypt_system_volume(GMountOperationHandle op, int system_volume);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_mount_operation_get_pim(GMountOperationHandle op);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_mount_operation_set_pim(GMountOperationHandle op, uint pim);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_native_socket_address_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketAddressHandle g_native_socket_address_new(IntPtr native, nuint len);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_volume_monitor_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVolumeMonitorHandle g_volume_monitor_get();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_volume_monitor_get_connected_drives(GVolumeMonitorHandle volume_monitor);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_volume_monitor_get_volumes(GVolumeMonitorHandle volume_monitor);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_volume_monitor_get_mounts(GVolumeMonitorHandle volume_monitor);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVolumeHandle g_volume_monitor_get_volume_for_uuid(GVolumeMonitorHandle volume_monitor, string uuid);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GMountHandle g_volume_monitor_get_mount_for_uuid(GVolumeMonitorHandle volume_monitor, string uuid);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVolumeHandle g_volume_monitor_adopt_orphan_mount(GMountHandle mount);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_native_volume_monitor_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_network_address_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectableHandle g_network_address_new(string hostname, ushort port);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectableHandle g_network_address_new_loopback(ushort port);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectableHandle g_network_address_parse(string host_and_port, ushort default_port, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectableHandle g_network_address_parse_uri(string uri, ushort default_port, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_network_address_get_hostname(GNetworkAddressHandle addr);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern ushort g_network_address_get_port(GNetworkAddressHandle addr);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_network_address_get_scheme(GNetworkAddressHandle addr);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_network_monitor_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GNetworkMonitorHandle g_network_monitor_get_default();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_network_monitor_get_network_available(GNetworkMonitorHandle monitor);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_network_monitor_get_network_metered(GNetworkMonitorHandle monitor);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GNetworkConnectivity g_network_monitor_get_connectivity(GNetworkMonitorHandle monitor);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_network_monitor_can_reach(GNetworkMonitorHandle monitor, GSocketConnectableHandle connectable, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_network_monitor_can_reach_async(GNetworkMonitorHandle monitor, GSocketConnectableHandle connectable, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_network_monitor_can_reach_finish(GNetworkMonitorHandle monitor, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_network_service_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectableHandle g_network_service_new(string service, string protocol, string domain);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_network_service_get_service(GNetworkServiceHandle srv);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_network_service_get_protocol(GNetworkServiceHandle srv);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_network_service_get_domain(GNetworkServiceHandle srv);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_network_service_get_scheme(GNetworkServiceHandle srv);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_network_service_set_scheme(GNetworkServiceHandle srv, string scheme);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_notification_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GNotificationHandle g_notification_new(string title);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_notification_set_title(GNotificationHandle notification, string title);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_notification_set_body(GNotificationHandle notification, string body);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_notification_set_icon(GNotificationHandle notification, GIconHandle icon);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_notification_set_urgent(GNotificationHandle notification, int urgent);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_notification_set_priority(GNotificationHandle notification, GNotificationPriority priority);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_notification_set_category(GNotificationHandle notification, string category);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_notification_add_button(GNotificationHandle notification, string label, string detailed_action);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_notification_add_button_with_target(GNotificationHandle notification, string label, string action, string target_format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_notification_add_button_with_target_value(GNotificationHandle notification, string label, string action, GVariantHandle target);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_notification_set_default_action(GNotificationHandle notification, string detailed_action);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_notification_set_default_action_and_target(GNotificationHandle notification, string action, string target_format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_notification_set_default_action_and_target_value(GNotificationHandle notification, string action, GVariantHandle target);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_permission_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_permission_acquire(GPermissionHandle permission, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_permission_acquire_async(GPermissionHandle permission, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_permission_acquire_finish(GPermissionHandle permission, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_permission_release(GPermissionHandle permission, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_permission_release_async(GPermissionHandle permission, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_permission_release_finish(GPermissionHandle permission, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_permission_get_allowed(GPermissionHandle permission);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_permission_get_can_acquire(GPermissionHandle permission);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_permission_get_can_release(GPermissionHandle permission);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_permission_impl_update(GPermissionHandle permission, int allowed, int can_acquire, int can_release);
	//
	// public static nuint G_TYPE_ACTION => (g_action_get_type());
	//
	// public static nuint G_TYPE_ACTION_GROUP => (g_action_group_get_type());
	//
	// public static nuint G_TYPE_ACTION_MAP => (g_action_map_get_type());
	//
	// public static nuint G_TYPE_APP_INFO => (g_app_info_get_type());
	//
	// public static nuint G_TYPE_APP_LAUNCH_CONTEXT => (g_app_launch_context_get_type());
	//
	// public static nuint G_TYPE_APP_INFO_MONITOR => (g_app_info_monitor_get_type());
	//
	// public static nuint G_TYPE_APPLICATION => (g_application_get_type());
	//
	// public static nuint G_TYPE_APPLICATION_COMMAND_LINE => (g_application_command_line_get_type());
	//
	// public static nuint G_TYPE_INITABLE => (g_initable_get_type());
	//
	// public static nuint G_TYPE_ASYNC_INITABLE => (g_async_initable_get_type());
	//
	// public static nuint G_TYPE_ASYNC_RESULT => (g_async_result_get_type());
	//
	// public static nuint G_TYPE_INPUT_STREAM => (g_input_stream_get_type());
	//
	// public static nuint G_TYPE_FILTER_INPUT_STREAM => (g_filter_input_stream_get_type());
	//
	// public static nuint G_TYPE_BUFFERED_INPUT_STREAM => (g_buffered_input_stream_get_type());
	//
	// public static nuint G_TYPE_OUTPUT_STREAM => (g_output_stream_get_type());
	//
	// public static nuint G_TYPE_FILTER_OUTPUT_STREAM => (g_filter_output_stream_get_type());
	//
	// public static nuint G_TYPE_BUFFERED_OUTPUT_STREAM => (g_buffered_output_stream_get_type());
	//
	// public static nuint G_TYPE_BYTES_ICON => (g_bytes_icon_get_type());
	//
	// public static nuint G_TYPE_CANCELLABLE => (g_cancellable_get_type());
	//
	// public static nuint G_TYPE_CONVERTER => (g_converter_get_type());
	//
	// public static nuint G_TYPE_CHARSET_CONVERTER => (g_charset_converter_get_type());
	//
	// public static nuint G_TYPE_CONVERTER_INPUT_STREAM => (g_converter_input_stream_get_type());
	//
	// public static nuint G_TYPE_CONVERTER_OUTPUT_STREAM => (g_converter_output_stream_get_type());
	//
	// public static nuint G_TYPE_CREDENTIALS => (g_credentials_get_type());
	//
	// public static nuint G_TYPE_DATAGRAM_BASED => (g_datagram_based_get_type());
	//
	// public static nuint G_TYPE_DATA_INPUT_STREAM => (g_data_input_stream_get_type());
	//
	// public static nuint G_TYPE_DATA_OUTPUT_STREAM => (g_data_output_stream_get_type());
	//
	// public static nuint G_TYPE_DBUS_ACTION_GROUP => (g_dbus_action_group_get_type());
	//
	// public static nuint G_TYPE_DBUS_AUTH_OBSERVER => (g_dbus_auth_observer_get_type());
	//
	// public static nuint G_TYPE_DBUS_CONNECTION => (g_dbus_connection_get_type());
	//
	// public static uint G_DBUS_ERROR => g_dbus_error_quark();
	//
	// public static nuint G_TYPE_DBUS_INTERFACE => (g_dbus_interface_get_type());
	//
	// public static nuint G_TYPE_DBUS_INTERFACE_SKELETON => (g_dbus_interface_skeleton_get_type());
	//
	// public static nuint G_TYPE_DBUS_NODE_INFO => (g_dbus_node_info_get_type());
	//
	// public static nuint G_TYPE_DBUS_INTERFACE_INFO => (g_dbus_interface_info_get_type());
	//
	// public static nuint G_TYPE_DBUS_METHOD_INFO => (g_dbus_method_info_get_type());
	//
	// public static nuint G_TYPE_DBUS_SIGNAL_INFO => (g_dbus_signal_info_get_type());
	//
	// public static nuint G_TYPE_DBUS_PROPERTY_INFO => (g_dbus_property_info_get_type());
	//
	// public static nuint G_TYPE_DBUS_ARG_INFO => (g_dbus_arg_info_get_type());
	//
	// public static nuint G_TYPE_DBUS_ANNOTATION_INFO => (g_dbus_annotation_info_get_type());
	//
	// public static nuint G_TYPE_DBUS_MENU_MODEL => (g_dbus_menu_model_get_type());
	//
	// public static nuint G_TYPE_DBUS_MESSAGE => (g_dbus_message_get_type());
	//
	// public static nuint G_TYPE_DBUS_METHOD_INVOCATION => (g_dbus_method_invocation_get_type());
	//
	// public const bool G_DBUS_METHOD_INVOCATION_HANDLED = (0 == 0);
	//
	// public const int G_DBUS_METHOD_INVOCATION_UNHANDLED = (0);
	//
	// public static nuint G_TYPE_DBUS_OBJECT => (g_dbus_object_get_type());
	//
	// public static nuint G_TYPE_DBUS_OBJECT_MANAGER => (g_dbus_object_manager_get_type());
	//
	// public static nuint G_TYPE_DBUS_OBJECT_MANAGER_CLIENT => (g_dbus_object_manager_client_get_type());
	//
	// public static nuint G_TYPE_DBUS_OBJECT_MANAGER_SERVER => (g_dbus_object_manager_server_get_type());
	//
	// public static nuint G_TYPE_DBUS_OBJECT_PROXY => (g_dbus_object_proxy_get_type());
	//
	// public static nuint G_TYPE_DBUS_OBJECT_SKELETON => (g_dbus_object_skeleton_get_type());
	//
	// public static nuint G_TYPE_DBUS_PROXY => (g_dbus_proxy_get_type());
	//
	// public static nuint G_TYPE_DBUS_SERVER => (g_dbus_server_get_type());
	//
	// public static ReadOnlySpan<byte> G_DEBUG_CONTROLLER_EXTENSION_POINT_NAME => "gio-debug-controller"u8;
	//
	// public static nuint G_TYPE_DEBUG_CONTROLLER => (g_debug_controller_get_type());
	//
	// public static nuint G_TYPE_DEBUG_CONTROLLER_DBUS => (g_debug_controller_dbus_get_type());
	//
	// public static ReadOnlySpan<byte> G_DRIVE_IDENTIFIER_KIND_UNIX_DEVICE => "unix-device"u8;
	//
	// public static nuint G_TYPE_DRIVE => (g_drive_get_type());
	//
	// public static nuint G_TYPE_DTLS_CONNECTION => (g_dtls_connection_get_type());
	//
	// public static nuint G_TYPE_DTLS_CLIENT_CONNECTION => (g_dtls_client_connection_get_type());
	//
	// public static nuint G_TYPE_DTLS_SERVER_CONNECTION => (g_dtls_server_connection_get_type());
	//
	// public static nuint G_TYPE_ICON => (g_icon_get_type());
	//
	// public static nuint G_TYPE_EMBLEM => (g_emblem_get_type());
	//
	// public static nuint G_TYPE_EMBLEMED_ICON => (g_emblemed_icon_get_type());
	//
	// public static nuint G_TYPE_FILE => (g_file_get_type());
	//
	// public static nuint G_TYPE_FILE_ATTRIBUTE_INFO_LIST => (g_file_attribute_info_list_get_type());
	//
	// public static nuint G_TYPE_FILE_ENUMERATOR => (g_file_enumerator_get_type());
	//
	// public static nuint G_TYPE_FILE_ICON => (g_file_icon_get_type());
	//
	// public static nuint G_TYPE_FILE_INFO => (g_file_info_get_type());
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_TYPE => "standard::type"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_IS_HIDDEN => "standard::is-hidden"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_IS_BACKUP => "standard::is-backup"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_IS_SYMLINK => "standard::is-symlink"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_IS_VIRTUAL => "standard::is-virtual"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_IS_VOLATILE => "standard::is-volatile"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_NAME => "standard::name"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_DISPLAY_NAME => "standard::display-name"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_EDIT_NAME => "standard::edit-name"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_COPY_NAME => "standard::copy-name"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_DESCRIPTION => "standard::description"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_ICON => "standard::icon"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_SYMBOLIC_ICON => "standard::symbolic-icon"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_CONTENT_TYPE => "standard::content-type"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_FAST_CONTENT_TYPE => "standard::fast-content-type"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_SIZE => "standard::size"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_ALLOCATED_SIZE => "standard::allocated-size"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_SYMLINK_TARGET => "standard::symlink-target"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_TARGET_URI => "standard::target-uri"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_STANDARD_SORT_ORDER => "standard::sort-order"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_ETAG_VALUE => "etag::value"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_ID_FILE => "id::file"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_ID_FILESYSTEM => "id::filesystem"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_ACCESS_CAN_READ => "access::can-read"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_ACCESS_CAN_WRITE => "access::can-write"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_ACCESS_CAN_EXECUTE => "access::can-execute"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_ACCESS_CAN_DELETE => "access::can-delete"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_ACCESS_CAN_TRASH => "access::can-trash"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_ACCESS_CAN_RENAME => "access::can-rename"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_MOUNTABLE_CAN_MOUNT => "mountable::can-mount"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_MOUNTABLE_CAN_UNMOUNT => "mountable::can-unmount"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_MOUNTABLE_CAN_EJECT => "mountable::can-eject"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_MOUNTABLE_UNIX_DEVICE => "mountable::unix-device"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_MOUNTABLE_UNIX_DEVICE_FILE => "mountable::unix-device-file"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_MOUNTABLE_HAL_UDI => "mountable::hal-udi"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_MOUNTABLE_CAN_START => "mountable::can-start"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_MOUNTABLE_CAN_START_DEGRADED => "mountable::can-start-degraded"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_MOUNTABLE_CAN_STOP => "mountable::can-stop"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_MOUNTABLE_START_STOP_TYPE => "mountable::start-stop-type"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_MOUNTABLE_CAN_POLL => "mountable::can-poll"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_MOUNTABLE_IS_MEDIA_CHECK_AUTOMATIC => "mountable::is-media-check-automatic"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_TIME_MODIFIED => "time::modified"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_TIME_MODIFIED_USEC => "time::modified-usec"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_TIME_ACCESS => "time::access"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_TIME_ACCESS_USEC => "time::access-usec"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_TIME_CHANGED => "time::changed"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_TIME_CHANGED_USEC => "time::changed-usec"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_TIME_CREATED => "time::created"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_TIME_CREATED_USEC => "time::created-usec"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_UNIX_DEVICE => "unix::device"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_UNIX_INODE => "unix::inode"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_UNIX_MODE => "unix::mode"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_UNIX_NLINK => "unix::nlink"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_UNIX_UID => "unix::uid"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_UNIX_GID => "unix::gid"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_UNIX_RDEV => "unix::rdev"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_UNIX_BLOCK_SIZE => "unix::block-size"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_UNIX_BLOCKS => "unix::blocks"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_UNIX_IS_MOUNTPOINT => "unix::is-mountpoint"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_DOS_IS_ARCHIVE => "dos::is-archive"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_DOS_IS_SYSTEM => "dos::is-system"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_DOS_IS_MOUNTPOINT => "dos::is-mountpoint"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_DOS_REPARSE_POINT_TAG => "dos::reparse-point-tag"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_OWNER_USER => "owner::user"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_OWNER_USER_REAL => "owner::user-real"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_OWNER_GROUP => "owner::group"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_THUMBNAIL_PATH => "thumbnail::path"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_THUMBNAILING_FAILED => "thumbnail::failed"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_THUMBNAIL_IS_VALID => "thumbnail::is-valid"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_PREVIEW_ICON => "preview::icon"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_FILESYSTEM_SIZE => "filesystem::size"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_FILESYSTEM_FREE => "filesystem::free"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_FILESYSTEM_USED => "filesystem::used"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_FILESYSTEM_TYPE => "filesystem::type"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_FILESYSTEM_READONLY => "filesystem::readonly"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_FILESYSTEM_USE_PREVIEW => "filesystem::use-preview"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_FILESYSTEM_REMOTE => "filesystem::remote"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_GVFS_BACKEND => "gvfs::backend"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_SELINUX_CONTEXT => "selinux::context"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_TRASH_ITEM_COUNT => "trash::item-count"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_TRASH_ORIG_PATH => "trash::orig-path"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_TRASH_DELETION_DATE => "trash::deletion-date"u8;
	//
	// public static ReadOnlySpan<byte> G_FILE_ATTRIBUTE_RECENT_MODIFIED => "recent::modified"u8;
	//
	// public static nuint G_TYPE_FILE_ATTRIBUTE_MATCHER => (g_file_attribute_matcher_get_type());
	//
	// public static nuint G_TYPE_FILE_INPUT_STREAM => (g_file_input_stream_get_type());
	//
	// public static uint G_IO_ERROR => g_io_error_quark();
	//
	// public static nuint G_TYPE_IO_STREAM => (g_io_stream_get_type());
	//
	// public static nuint G_TYPE_FILE_IO_STREAM => (g_file_io_stream_get_type());
	//
	// public static nuint G_TYPE_FILE_MONITOR => (g_file_monitor_get_type());
	//
	// public static nuint G_TYPE_FILENAME_COMPLETER => (g_filename_completer_get_type());
	//
	// public static nuint G_TYPE_FILE_OUTPUT_STREAM => (g_file_output_stream_get_type());
	//
	// public static nuint G_TYPE_INET_ADDRESS => (g_inet_address_get_type());
	//
	// public static nuint G_TYPE_INET_ADDRESS_MASK => (g_inet_address_mask_get_type());
	//
	// public static nuint G_TYPE_SOCKET_ADDRESS => (g_socket_address_get_type());
	//
	// public static nuint G_TYPE_INET_SOCKET_ADDRESS => (g_inet_socket_address_get_type());
	//
	// public static nuint G_TYPE_APP_INFO_CREATE_FLAGS => (g_app_info_create_flags_get_type());
	//
	// public static nuint G_TYPE_CONVERTER_FLAGS => (g_converter_flags_get_type());
	//
	// public static nuint G_TYPE_CONVERTER_RESULT => (g_converter_result_get_type());
	//
	// public static nuint G_TYPE_DATA_STREAM_BYTE_ORDER => (g_data_stream_byte_order_get_type());
	//
	// public static nuint G_TYPE_DATA_STREAM_NEWLINE_TYPE => (g_data_stream_newline_type_get_type());
	//
	// public static nuint G_TYPE_FILE_ATTRIBUTE_TYPE => (g_file_attribute_type_get_type());
	//
	// public static nuint G_TYPE_FILE_ATTRIBUTE_INFO_FLAGS => (g_file_attribute_info_flags_get_type());
	//
	// public static nuint G_TYPE_FILE_ATTRIBUTE_STATUS => (g_file_attribute_status_get_type());
	//
	// public static nuint G_TYPE_FILE_QUERY_INFO_FLAGS => (g_file_query_info_flags_get_type());
	//
	// public static nuint G_TYPE_FILE_CREATE_FLAGS => (g_file_create_flags_get_type());
	//
	// public static nuint G_TYPE_FILE_MEASURE_FLAGS => (g_file_measure_flags_get_type());
	//
	// public static nuint G_TYPE_MOUNT_MOUNT_FLAGS => (g_mount_mount_flags_get_type());
	//
	// public static nuint G_TYPE_MOUNT_UNMOUNT_FLAGS => (g_mount_unmount_flags_get_type());
	//
	// public static nuint G_TYPE_DRIVE_START_FLAGS => (g_drive_start_flags_get_type());
	//
	// public static nuint G_TYPE_DRIVE_START_STOP_TYPE => (g_drive_start_stop_type_get_type());
	//
	// public static nuint G_TYPE_FILE_COPY_FLAGS => (g_file_copy_flags_get_type());
	//
	// public static nuint G_TYPE_FILE_MONITOR_FLAGS => (g_file_monitor_flags_get_type());
	//
	// public static nuint G_TYPE_FILE_TYPE => (g_file_type_get_type());
	//
	// public static nuint G_TYPE_FILESYSTEM_PREVIEW_TYPE => (g_filesystem_preview_type_get_type());
	//
	// public static nuint G_TYPE_FILE_MONITOR_EVENT => (g_file_monitor_event_get_type());
	//
	// public static nuint G_TYPE_IO_ERROR_ENUM => (g_io_error_enum_get_type());
	//
	// public static nuint G_TYPE_ASK_PASSWORD_FLAGS => (g_ask_password_flags_get_type());
	//
	// public static nuint G_TYPE_PASSWORD_SAVE => (g_password_save_get_type());
	//
	// public static nuint G_TYPE_MOUNT_OPERATION_RESULT => (g_mount_operation_result_get_type());
	//
	// public static nuint G_TYPE_OUTPUT_STREAM_SPLICE_FLAGS => (g_output_stream_splice_flags_get_type());
	//
	// public static nuint G_TYPE_IO_STREAM_SPLICE_FLAGS => (g_io_stream_splice_flags_get_type());
	//
	// public static nuint G_TYPE_EMBLEM_ORIGIN => (g_emblem_origin_get_type());
	//
	// public static nuint G_TYPE_RESOLVER_ERROR => (g_resolver_error_get_type());
	//
	// public static nuint G_TYPE_RESOLVER_RECORD_TYPE => (g_resolver_record_type_get_type());
	//
	// public static nuint G_TYPE_RESOURCE_ERROR => (g_resource_error_get_type());
	//
	// public static nuint G_TYPE_RESOURCE_FLAGS => (g_resource_flags_get_type());
	//
	// public static nuint G_TYPE_RESOURCE_LOOKUP_FLAGS => (g_resource_lookup_flags_get_type());
	//
	// public static nuint G_TYPE_SOCKET_FAMILY => (g_socket_family_get_type());
	//
	// public static nuint G_TYPE_SOCKET_TYPE => (g_socket_type_get_type());
	//
	// public static nuint G_TYPE_SOCKET_MSG_FLAGS => (g_socket_msg_flags_get_type());
	//
	// public static nuint G_TYPE_SOCKET_PROTOCOL => (g_socket_protocol_get_type());
	//
	// public static nuint G_TYPE_ZLIB_COMPRESSOR_FORMAT => (g_zlib_compressor_format_get_type());
	//
	// public static nuint G_TYPE_UNIX_SOCKET_ADDRESS_TYPE => (g_unix_socket_address_type_get_type());
	//
	// public static nuint G_TYPE_BUS_TYPE => (g_bus_type_get_type());
	//
	// public static nuint G_TYPE_BUS_NAME_OWNER_FLAGS => (g_bus_name_owner_flags_get_type());
	//
	// public static nuint G_TYPE_BUS_NAME_WATCHER_FLAGS => (g_bus_name_watcher_flags_get_type());
	//
	// public static nuint G_TYPE_DBUS_PROXY_FLAGS => (g_dbus_proxy_flags_get_type());
	//
	// public static nuint G_TYPE_DBUS_ERROR => (g_dbus_error_get_type());
	//
	// public static nuint G_TYPE_DBUS_CONNECTION_FLAGS => (g_dbus_connection_flags_get_type());
	//
	// public static nuint G_TYPE_DBUS_CAPABILITY_FLAGS => (g_dbus_capability_flags_get_type());
	//
	// public static nuint G_TYPE_DBUS_CALL_FLAGS => (g_dbus_call_flags_get_type());
	//
	// public static nuint G_TYPE_DBUS_MESSAGE_TYPE => (g_dbus_message_type_get_type());
	//
	// public static nuint G_TYPE_DBUS_MESSAGE_FLAGS => (g_dbus_message_flags_get_type());
	//
	// public static nuint G_TYPE_DBUS_MESSAGE_HEADER_FIELD => (g_dbus_message_header_field_get_type());
	//
	// public static nuint G_TYPE_DBUS_PROPERTY_INFO_FLAGS => (g_dbus_property_info_flags_get_type());
	//
	// public static nuint G_TYPE_DBUS_SUBTREE_FLAGS => (g_dbus_subtree_flags_get_type());
	//
	// public static nuint G_TYPE_DBUS_SERVER_FLAGS => (g_dbus_server_flags_get_type());
	//
	// public static nuint G_TYPE_DBUS_SIGNAL_FLAGS => (g_dbus_signal_flags_get_type());
	//
	// public static nuint G_TYPE_DBUS_SEND_MESSAGE_FLAGS => (g_dbus_send_message_flags_get_type());
	//
	// public static nuint G_TYPE_CREDENTIALS_TYPE => (g_credentials_type_get_type());
	//
	// public static nuint G_TYPE_DBUS_MESSAGE_BYTE_ORDER => (g_dbus_message_byte_order_get_type());
	//
	// public static nuint G_TYPE_APPLICATION_FLAGS => (g_application_flags_get_type());
	//
	// public static nuint G_TYPE_TLS_ERROR => (g_tls_error_get_type());
	//
	// public static nuint G_TYPE_TLS_CERTIFICATE_FLAGS => (g_tls_certificate_flags_get_type());
	//
	// public static nuint G_TYPE_TLS_AUTHENTICATION_MODE => (g_tls_authentication_mode_get_type());
	//
	// public static nuint G_TYPE_TLS_CHANNEL_BINDING_TYPE => (g_tls_channel_binding_type_get_type());
	//
	// public static nuint G_TYPE_TLS_CHANNEL_BINDING_ERROR => (g_tls_channel_binding_error_get_type());
	//
	// public static nuint G_TYPE_TLS_REHANDSHAKE_MODE => (g_tls_rehandshake_mode_get_type());
	//
	// public static nuint G_TYPE_TLS_PASSWORD_FLAGS => (g_tls_password_flags_get_type());
	//
	// public static nuint G_TYPE_TLS_INTERACTION_RESULT => (g_tls_interaction_result_get_type());
	//
	// public static nuint G_TYPE_DBUS_INTERFACE_SKELETON_FLAGS => (g_dbus_interface_skeleton_flags_get_type());
	//
	// public static nuint G_TYPE_DBUS_OBJECT_MANAGER_CLIENT_FLAGS => (g_dbus_object_manager_client_flags_get_type());
	//
	// public static nuint G_TYPE_TLS_DATABASE_VERIFY_FLAGS => (g_tls_database_verify_flags_get_type());
	//
	// public static nuint G_TYPE_TLS_DATABASE_LOOKUP_FLAGS => (g_tls_database_lookup_flags_get_type());
	//
	// public static nuint G_TYPE_TLS_CERTIFICATE_REQUEST_FLAGS => (g_tls_certificate_request_flags_get_type());
	//
	// public static nuint G_TYPE_TLS_PROTOCOL_VERSION => (g_tls_protocol_version_get_type());
	//
	// public static nuint G_TYPE_IO_MODULE_SCOPE_FLAGS => (g_io_module_scope_flags_get_type());
	//
	// public static nuint G_TYPE_SOCKET_CLIENT_EVENT => (g_socket_client_event_get_type());
	//
	// public static nuint G_TYPE_SOCKET_LISTENER_EVENT => (g_socket_listener_event_get_type());
	//
	// public static nuint G_TYPE_TEST_DBUS_FLAGS => (g_test_dbus_flags_get_type());
	//
	// public static nuint G_TYPE_SUBPROCESS_FLAGS => (g_subprocess_flags_get_type());
	//
	// public static nuint G_TYPE_NOTIFICATION_PRIORITY => (g_notification_priority_get_type());
	//
	// public static nuint G_TYPE_NETWORK_CONNECTIVITY => (g_network_connectivity_get_type());
	//
	// public static nuint G_TYPE_POLLABLE_RETURN => (g_pollable_return_get_type());
	//
	// public static nuint G_TYPE_MEMORY_MONITOR_WARNING_LEVEL => (g_memory_monitor_warning_level_get_type());
	//
	// public static nuint G_TYPE_RESOLVER_NAME_LOOKUP_FLAGS => (g_resolver_name_lookup_flags_get_type());
	//
	// public static nuint G_TYPE_SETTINGS_BIND_FLAGS => (g_settings_bind_flags_get_type());
	//
	// public static nuint G_IO_TYPE_MODULE => (g_io_module_get_type());
	//
	// public static nuint G_TYPE_LIST_MODEL => g_list_model_get_type();
	//
	// public static nuint G_TYPE_LIST_STORE => (g_list_store_get_type());
	//
	// public static nuint G_TYPE_LOADABLE_ICON => (g_loadable_icon_get_type());
	//
	// public static nuint G_TYPE_MEMORY_INPUT_STREAM => (g_memory_input_stream_get_type());
	//
	// public static ReadOnlySpan<byte> G_MEMORY_MONITOR_EXTENSION_POINT_NAME => "gio-memory-monitor"u8;
	//
	// public static nuint G_TYPE_MEMORY_MONITOR => (g_memory_monitor_get_type());
	//
	// public static nuint G_TYPE_MEMORY_OUTPUT_STREAM => (g_memory_output_stream_get_type());
	//
	// public static ReadOnlySpan<byte> G_MENU_ATTRIBUTE_ACTION => "action"u8;
	//
	// public static ReadOnlySpan<byte> G_MENU_ATTRIBUTE_ACTION_NAMESPACE => "action-namespace"u8;
	//
	// public static ReadOnlySpan<byte> G_MENU_ATTRIBUTE_TARGET => "target"u8;
	//
	// public static ReadOnlySpan<byte> G_MENU_ATTRIBUTE_LABEL => "label"u8;
	//
	// public static ReadOnlySpan<byte> G_MENU_ATTRIBUTE_ICON => "icon"u8;
	//
	// public static ReadOnlySpan<byte> G_MENU_LINK_SUBMENU => "submenu"u8;
	//
	// public static ReadOnlySpan<byte> G_MENU_LINK_SECTION => "section"u8;
	//
	// public static nuint G_TYPE_MENU_MODEL => (g_menu_model_get_type());
	//
	// public static nuint G_TYPE_MENU_ATTRIBUTE_ITER => (g_menu_attribute_iter_get_type());
	//
	// public static nuint G_TYPE_MENU_LINK_ITER => (g_menu_link_iter_get_type());
	//
	// public static nuint G_TYPE_MENU => (g_menu_get_type());
	//
	// public static nuint G_TYPE_MENU_ITEM => (g_menu_item_get_type());
	//
	// public static nuint G_TYPE_MOUNT => (g_mount_get_type());
	//
	// public static nuint G_TYPE_MOUNT_OPERATION => (g_mount_operation_get_type());
	//
	// public static nuint G_TYPE_NATIVE_SOCKET_ADDRESS => (g_native_socket_address_get_type());
	//
	// public static nuint G_TYPE_VOLUME_MONITOR => (g_volume_monitor_get_type());
	//
	// public static ReadOnlySpan<byte> G_VOLUME_MONITOR_EXTENSION_POINT_NAME => "gio-volume-monitor"u8;
	//
	// public static nuint G_TYPE_NATIVE_VOLUME_MONITOR => (g_native_volume_monitor_get_type());
	//
	// public static ReadOnlySpan<byte> G_NATIVE_VOLUME_MONITOR_EXTENSION_POINT_NAME => "gio-native-volume-monitor"u8;
	//
	// public static nuint G_TYPE_NETWORK_ADDRESS => (g_network_address_get_type());
	//
	// public static ReadOnlySpan<byte> G_NETWORK_MONITOR_EXTENSION_POINT_NAME => "gio-network-monitor"u8;
	//
	// public static nuint G_TYPE_NETWORK_MONITOR => (g_network_monitor_get_type());
	//
	// public static nuint G_TYPE_NETWORK_SERVICE => (g_network_service_get_type());
	//
	// public static nuint G_TYPE_NOTIFICATION => (g_notification_get_type());
	//
	// public static nuint G_TYPE_PERMISSION => (g_permission_get_type());
	//
	// public static ReadOnlySpan<byte> G_POWER_PROFILE_MONITOR_EXTENSION_POINT_NAME => "gio-power-profile-monitor"u8;
	//
	// public static ReadOnlySpan<byte> G_PROXY_EXTENSION_POINT_NAME => "gio-proxy"u8;
	//
	// public static ReadOnlySpan<byte> G_PROXY_RESOLVER_EXTENSION_POINT_NAME => "gio-proxy-resolver"u8;
	//
	// public static ReadOnlySpan<byte> G_TLS_BACKEND_EXTENSION_POINT_NAME => "gio-tls-backend"u8;
	//
	// public static ReadOnlySpan<byte> G_TLS_DATABASE_PURPOSE_AUTHENTICATE_SERVER => "1.3.6.1.5.5.7.3.1"u8;
	//
	// public static ReadOnlySpan<byte> G_TLS_DATABASE_PURPOSE_AUTHENTICATE_CLIENT => "1.3.6.1.5.5.7.3.2"u8;
	//
	// public static ReadOnlySpan<byte> G_VFS_EXTENSION_POINT_NAME => "gio-vfs"u8;
	//
	// public static ReadOnlySpan<byte> G_VOLUME_IDENTIFIER_KIND_HAL_UDI => "hal-udi"u8;
	//
	// public static ReadOnlySpan<byte> G_VOLUME_IDENTIFIER_KIND_UNIX_DEVICE => "unix-device"u8;
	//
	// public static ReadOnlySpan<byte> G_VOLUME_IDENTIFIER_KIND_LABEL => "label"u8;
	//
	// public static ReadOnlySpan<byte> G_VOLUME_IDENTIFIER_KIND_UUID => "uuid"u8;
	//
	// public static ReadOnlySpan<byte> G_VOLUME_IDENTIFIER_KIND_NFS_MOUNT => "nfs-mount"u8;
	//
	// public static ReadOnlySpan<byte> G_VOLUME_IDENTIFIER_KIND_CLASS => "class"u8;
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_pollable_input_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_pollable_input_stream_can_poll(GPollableInputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_pollable_input_stream_is_readable(GPollableInputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSourceHandle g_pollable_input_stream_create_source(GPollableInputStreamHandle stream, GCancellableHandle cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_pollable_input_stream_read_nonblocking(GPollableInputStreamHandle stream, void* buffer, nuint count, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_pollable_output_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_pollable_output_stream_can_poll(GPollableOutputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_pollable_output_stream_is_writable(GPollableOutputStreamHandle stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSourceHandle g_pollable_output_stream_create_source(GPollableOutputStreamHandle stream, GCancellableHandle cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_pollable_output_stream_write_nonblocking(GPollableOutputStreamHandle stream, byte[] buffer, nuint count, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GPollableReturn g_pollable_output_stream_writev_nonblocking(GPollableOutputStreamHandle stream, GOutputVectorHandle vectors, nuint n_vectors, out nuint bytes_written, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSourceHandle g_pollable_source_new(GObjectHandle pollable_stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSourceHandle g_pollable_source_new_full(IntPtr pollable_stream, GSourceHandle child_source, GCancellableHandle cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_pollable_stream_read(GInputStreamHandle stream, void* buffer, nuint count, int blocking, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_pollable_stream_write(GOutputStreamHandle stream, byte[] buffer, nuint count, int blocking, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_pollable_stream_write_all(GOutputStreamHandle stream, byte[] buffer, nuint count, int blocking, out nuint bytes_written, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_power_profile_monitor_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GPowerProfileMonitorHandle g_power_profile_monitor_dup_default();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_power_profile_monitor_get_power_saver_enabled(GPowerProfileMonitorHandle monitor);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_property_action_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GPropertyActionHandle g_property_action_new(string name, IntPtr @object, string property_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_proxy_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GProxyHandle g_proxy_get_default_for_protocol(string protocol);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOStreamHandle g_proxy_connect(GProxyHandle proxy, GIOStreamHandle connection, GProxyAddressHandle proxy_address, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_proxy_connect_async(GProxyHandle proxy, GIOStreamHandle connection, GProxyAddressHandle proxy_address, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOStreamHandle g_proxy_connect_finish(GProxyHandle proxy, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_proxy_supports_hostname(GProxyHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_proxy_address_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketAddressHandle g_proxy_address_new(GInetAddressHandle inetaddr, ushort port, string protocol, string dest_hostname, ushort dest_port, string username, string password);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_proxy_address_get_protocol(GProxyAddressHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_proxy_address_get_destination_protocol(GProxyAddressHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_proxy_address_get_destination_hostname(GProxyAddressHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern ushort g_proxy_address_get_destination_port(GProxyAddressHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_proxy_address_get_username(GProxyAddressHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_proxy_address_get_password(GProxyAddressHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_proxy_address_get_uri(GProxyAddressHandle proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_socket_address_enumerator_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketAddressHandle g_socket_address_enumerator_next(GSocketAddressEnumeratorHandle enumerator, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_address_enumerator_next_async(GSocketAddressEnumeratorHandle enumerator, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketAddressHandle g_socket_address_enumerator_next_finish(GSocketAddressEnumeratorHandle enumerator, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_proxy_address_enumerator_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_proxy_resolver_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GProxyResolverHandle g_proxy_resolver_get_default();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_proxy_resolver_is_supported(GProxyResolverHandle resolver);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_proxy_resolver_lookup(GProxyResolverHandle resolver, string uri, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_proxy_resolver_lookup_async(GProxyResolverHandle resolver, string uri, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_proxy_resolver_lookup_finish(GProxyResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_remote_action_group_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_remote_action_group_activate_action_full(GRemoteActionGroupHandle remote, string action_name, GVariantHandle parameter, GVariantHandle platform_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_remote_action_group_change_action_state_full(GRemoteActionGroupHandle remote, string action_name, GVariantHandle value, GVariantHandle platform_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_resolver_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GResolverHandle g_resolver_get_default();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_resolver_set_default(GResolverHandle resolver);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_resolver_lookup_by_name(GResolverHandle resolver, string hostname, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_resolver_lookup_by_name_async(GResolverHandle resolver, string hostname, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_resolver_lookup_by_name_finish(GResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_resolver_lookup_by_name_with_flags_async(GResolverHandle resolver, string hostname, GResolverNameLookupFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_resolver_lookup_by_name_with_flags_finish(GResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_resolver_lookup_by_name_with_flags(GResolverHandle resolver, string hostname, GResolverNameLookupFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_resolver_free_addresses(GListHandle addresses);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_resolver_lookup_by_address(GResolverHandle resolver, GInetAddressHandle address, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_resolver_lookup_by_address_async(GResolverHandle resolver, GInetAddressHandle address, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_resolver_lookup_by_address_finish(GResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_resolver_lookup_service(GResolverHandle resolver, string service, string protocol, string domain, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_resolver_lookup_service_async(GResolverHandle resolver, string service, string protocol, string domain, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_resolver_lookup_service_finish(GResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_resolver_lookup_records(GResolverHandle resolver, string rrname, GResolverRecordType record_type, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_resolver_lookup_records_async(GResolverHandle resolver, string rrname, GResolverRecordType record_type, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_resolver_lookup_records_finish(GResolverHandle resolver, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_resolver_free_targets(GListHandle targets);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GQuark g_resolver_error_quark();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GQuark g_resource_error_quark();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_resource_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GResourceHandle g_resource_new_from_data(GBytesHandle data, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GResourceHandle g_resource_ref(GResourceHandle resource);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_resource_unref(GResourceHandle resource);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GResourceHandle g_resource_load(string filename, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInputStreamHandle g_resource_open_stream(GResourceHandle resource, string path, GResourceLookupFlags lookup_flags, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GBytesHandle g_resource_lookup_data(GResourceHandle resource, string path, GResourceLookupFlags lookup_flags, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_resource_enumerate_children(GResourceHandle resource, string path, GResourceLookupFlags lookup_flags, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_resource_get_info(GResourceHandle resource, string path, GResourceLookupFlags lookup_flags, [NativeTypeName("gsize *")] nuint* size, [NativeTypeName("guint32 *")] uint* flags, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_resources_register(GResourceHandle resource);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_resources_unregister(GResourceHandle resource);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInputStreamHandle g_resources_open_stream(string path, GResourceLookupFlags lookup_flags, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GBytesHandle g_resources_lookup_data(string path, GResourceLookupFlags lookup_flags, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_resources_enumerate_children(string path, GResourceLookupFlags lookup_flags, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_resources_get_info(string path, GResourceLookupFlags lookup_flags, [NativeTypeName("gsize *")] nuint* size, [NativeTypeName("guint32 *")] uint* flags, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_static_resource_init(GStaticResourceHandle static_resource);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_static_resource_fini(GStaticResourceHandle static_resource);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GResourceHandle g_static_resource_get_resource(GStaticResourceHandle static_resource);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_seekable_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_seekable_tell(GSeekableHandle seekable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_seekable_can_seek(GSeekableHandle seekable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_seekable_seek(GSeekableHandle seekable, nint offset, GSeekType type, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_seekable_can_truncate(GSeekableHandle seekable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_seekable_truncate(GSeekableHandle seekable, nint offset, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_settings_schema_source_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSettingsSchemaSourceHandle g_settings_schema_source_get_default();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSettingsSchemaSourceHandle g_settings_schema_source_ref(GSettingsSchemaSourceHandle source);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_settings_schema_source_unref(GSettingsSchemaSourceHandle source);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSettingsSchemaSourceHandle g_settings_schema_source_new_from_directory(string directory, GSettingsSchemaSourceHandle parent, int trusted, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSettingsSchemaHandle g_settings_schema_source_lookup(GSettingsSchemaSourceHandle source, string schema_id, int recursive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_settings_schema_source_list_schemas(GSettingsSchemaSourceHandle source, int recursive, [NativeTypeName("gchar ***")] sbyte*** non_relocatable, [NativeTypeName("gchar ***")] sbyte*** relocatable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_settings_schema_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSettingsSchemaHandle g_settings_schema_ref(GSettingsSchemaHandle schema);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_settings_schema_unref(GSettingsSchemaHandle schema);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_settings_schema_get_id(GSettingsSchemaHandle schema);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_settings_schema_get_path(GSettingsSchemaHandle schema);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSettingsSchemaKeyHandle g_settings_schema_get_key(GSettingsSchemaHandle schema, string name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_schema_has_key(GSettingsSchemaHandle schema, string name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_settings_schema_list_keys(GSettingsSchemaHandle schema);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_settings_schema_list_children(GSettingsSchemaHandle schema);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_settings_schema_key_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSettingsSchemaKeyHandle g_settings_schema_key_ref(GSettingsSchemaKeyHandle key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_settings_schema_key_unref(GSettingsSchemaKeyHandle key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantTypeHandle g_settings_schema_key_get_value_type(GSettingsSchemaKeyHandle key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_settings_schema_key_get_default_value(GSettingsSchemaKeyHandle key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_settings_schema_key_get_range(GSettingsSchemaKeyHandle key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_schema_key_range_check(GSettingsSchemaKeyHandle key, GVariantHandle value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_settings_schema_key_get_name(GSettingsSchemaKeyHandle key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_settings_schema_key_get_summary(GSettingsSchemaKeyHandle key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_settings_schema_key_get_description(GSettingsSchemaKeyHandle key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_settings_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_settings_list_schemas();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_settings_list_relocatable_schemas();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSettingsHandle g_settings_new(string schema_id);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSettingsHandle g_settings_new_with_path(string schema_id, string path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSettingsHandle g_settings_new_with_backend(string schema_id, GSettingsBackendHandle backend);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSettingsHandle g_settings_new_with_backend_and_path(string schema_id, GSettingsBackendHandle backend, string path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSettingsHandle g_settings_new_full(GSettingsSchemaHandle schema, GSettingsBackendHandle backend, string path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_settings_list_children(GSettingsHandle settings);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_settings_list_keys(GSettingsHandle settings);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_settings_get_range(GSettingsHandle settings, string key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern int g_settings_range_check(GSettingsHandle settings, string key, GVariantHandle value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_set_value(GSettingsHandle settings, string key, GVariantHandle value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_settings_get_value(GSettingsHandle settings, string key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_settings_get_user_value(GSettingsHandle settings, string key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVariantHandle g_settings_get_default_value(GSettingsHandle settings, string key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_set(GSettingsHandle settings, string key, string format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_settings_get(GSettingsHandle settings, string key, string format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_settings_reset(GSettingsHandle settings, string key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_get_int(GSettingsHandle settings, string key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_set_int(GSettingsHandle settings, string key, int value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_settings_get_int64(GSettingsHandle settings, string key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_set_int64(GSettingsHandle settings, string key, nint value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_settings_get_uint(GSettingsHandle settings, string key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_set_uint(GSettingsHandle settings, string key, uint value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nuint g_settings_get_uint64(GSettingsHandle settings, string key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_set_uint64(GSettingsHandle settings, string key, nuint value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_settings_get_string(GSettingsHandle settings, string key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_set_string(GSettingsHandle settings, string key, string value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_get_boolean(GSettingsHandle settings, string key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_set_boolean(GSettingsHandle settings, string key, int value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern double g_settings_get_double(GSettingsHandle settings, string key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_set_double(GSettingsHandle settings, string key, double value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_settings_get_strv(GSettingsHandle settings, string key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_set_strv(GSettingsHandle settings, string key, string value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_get_enum(GSettingsHandle settings, string key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_set_enum(GSettingsHandle settings, string key, int value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_settings_get_flags(GSettingsHandle settings, string key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_set_flags(GSettingsHandle settings, string key, uint value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSettingsHandle g_settings_get_child(GSettingsHandle settings, string name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_is_writable(GSettingsHandle settings, string name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_settings_delay(GSettingsHandle settings);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_settings_apply(GSettingsHandle settings);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_settings_revert(GSettingsHandle settings);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_settings_get_has_unapplied(GSettingsHandle settings);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_settings_sync();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_settings_bind(GSettingsHandle settings, string key, IntPtr @object, string property, GSettingsBindFlags flags);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_settings_bind_with_mapping(GSettingsHandle settings, string key, IntPtr @object, string property, GSettingsBindFlags flags, GSettingsBindGetMapping get_mapping, GSettingsBindSetMapping set_mapping, IntPtr user_data, GDestroyNotify destroy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_settings_bind_writable(GSettingsHandle settings, string key, IntPtr @object, string property, int inverted);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_settings_unbind(IntPtr @object, string property);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GActionHandle g_settings_create_action(GSettingsHandle settings, string key);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern IntPtr g_settings_get_mapped(GSettingsHandle settings, string key, GSettingsGetMapping mapping, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_simple_action_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSimpleActionHandle g_simple_action_new(string name, GVariantTypeHandle parameter_type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSimpleActionHandle g_simple_action_new_stateful(string name, GVariantTypeHandle parameter_type, GVariantHandle state);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_simple_action_set_enabled(GSimpleActionHandle simple, int enabled);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_simple_action_set_state(GSimpleActionHandle simple, GVariantHandle value);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_simple_action_set_state_hint(GSimpleActionHandle simple, GVariantHandle state_hint);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_simple_action_group_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSimpleActionGroupHandle g_simple_action_group_new();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GActionHandle g_simple_action_group_lookup(GSimpleActionGroupHandle simple, string action_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_simple_action_group_insert(GSimpleActionGroupHandle simple, GActionHandle action);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_simple_action_group_remove(GSimpleActionGroupHandle simple, string action_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_simple_action_group_add_entries(GSimpleActionGroupHandle simple, GActionEntryHandle entries, int n_entries, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_simple_async_result_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSimpleAsyncResultHandle g_simple_async_result_new(GObjectHandle source_object, GAsyncReadyCallback callback, IntPtr user_data, IntPtr source_tag);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSimpleAsyncResultHandle g_simple_async_result_new_error(GObjectHandle source_object, GAsyncReadyCallback callback, IntPtr user_data, GQuark domain, int code, string format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSimpleAsyncResultHandle g_simple_async_result_new_from_error(GObjectHandle source_object, GAsyncReadyCallback callback, IntPtr user_data, GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSimpleAsyncResultHandle g_simple_async_result_new_take_error(GObjectHandle source_object, GAsyncReadyCallback callback, IntPtr user_data, GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_simple_async_result_set_op_res_gpointer(GSimpleAsyncResultHandle simple, IntPtr op_res, GDestroyNotify destroy_op_res);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern IntPtr g_simple_async_result_get_op_res_gpointer(GSimpleAsyncResultHandle simple);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_simple_async_result_set_op_res_gssize(GSimpleAsyncResultHandle simple, nint op_res);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern nint g_simple_async_result_get_op_res_gssize(GSimpleAsyncResultHandle simple);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_simple_async_result_set_op_res_gboolean(GSimpleAsyncResultHandle simple, int op_res);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern int g_simple_async_result_get_op_res_gboolean(GSimpleAsyncResultHandle simple);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_simple_async_result_set_check_cancellable(GSimpleAsyncResultHandle simple, GCancellableHandle check_cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern IntPtr g_simple_async_result_get_source_tag(GSimpleAsyncResultHandle simple);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_simple_async_result_set_handle_cancellation(GSimpleAsyncResultHandle simple, int handle_cancellation);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_simple_async_result_complete(GSimpleAsyncResultHandle simple);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_simple_async_result_complete_in_idle(GSimpleAsyncResultHandle simple);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_simple_async_result_run_in_thread(GSimpleAsyncResultHandle simple, GSimpleAsyncThreadFunc func, int io_priority, GCancellableHandle cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_simple_async_result_set_from_error(GSimpleAsyncResultHandle simple, GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_simple_async_result_take_error(GSimpleAsyncResultHandle simple, GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern int g_simple_async_result_propagate_error(GSimpleAsyncResultHandle simple, out GErrorHandle dest);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_simple_async_result_set_error(GSimpleAsyncResultHandle simple, GQuark domain, int code, string format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_simple_async_result_set_error_va(GSimpleAsyncResultHandle simple, GQuark domain, int code, string format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern int g_simple_async_result_is_valid(GAsyncResultHandle result, GObjectHandle source, IntPtr source_tag);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_simple_async_report_error_in_idle(GObjectHandle @object, GAsyncReadyCallback callback, IntPtr user_data, GQuark domain, int code, string format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_simple_async_report_gerror_in_idle(GObjectHandle @object, GAsyncReadyCallback callback, IntPtr user_data, GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_simple_async_report_take_gerror_in_idle(GObjectHandle @object, GAsyncReadyCallback callback, IntPtr user_data, GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_simple_io_stream_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOStreamHandle g_simple_io_stream_new(GInputStreamHandle input_stream, GOutputStreamHandle output_stream);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_simple_permission_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GPermissionHandle g_simple_permission_new(int allowed);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_simple_proxy_resolver_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GProxyResolverHandle g_simple_proxy_resolver_new(string default_proxy, string[] ignore_hosts);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_simple_proxy_resolver_set_default_proxy(GSimpleProxyResolverHandle resolver, string default_proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_simple_proxy_resolver_set_ignore_hosts(GSimpleProxyResolverHandle resolver, string[] ignore_hosts);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_simple_proxy_resolver_set_uri_proxy(GSimpleProxyResolverHandle resolver, string uri_scheme, string proxy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_socket_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketHandle g_socket_new(GSocketFamily family, GSocketType type, GSocketProtocol protocol, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketHandle g_socket_new_from_fd(int fd, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_get_fd(GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketFamily g_socket_get_family(GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketType g_socket_get_socket_type(GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketProtocol g_socket_get_protocol(GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketAddressHandle g_socket_get_local_address(GSocketHandle socket, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketAddressHandle g_socket_get_remote_address(GSocketHandle socket, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_set_blocking(GSocketHandle socket, int blocking);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_get_blocking(GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_set_keepalive(GSocketHandle socket, int keepalive);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_get_keepalive(GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_get_listen_backlog(GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_set_listen_backlog(GSocketHandle socket, int backlog);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_socket_get_timeout(GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_set_timeout(GSocketHandle socket, uint timeout);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_socket_get_ttl(GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_set_ttl(GSocketHandle socket, uint ttl);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_get_broadcast(GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_set_broadcast(GSocketHandle socket, int broadcast);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_get_multicast_loopback(GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_set_multicast_loopback(GSocketHandle socket, int loopback);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_socket_get_multicast_ttl(GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_set_multicast_ttl(GSocketHandle socket, uint ttl);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_is_connected(GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_bind(GSocketHandle socket, GSocketAddressHandle address, int allow_reuse, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_join_multicast_group(GSocketHandle socket, GInetAddressHandle group, int source_specific, string iface, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_leave_multicast_group(GSocketHandle socket, GInetAddressHandle group, int source_specific, string iface, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_join_multicast_group_ssm(GSocketHandle socket, GInetAddressHandle group, GInetAddressHandle source_specific, string iface, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_leave_multicast_group_ssm(GSocketHandle socket, GInetAddressHandle group, GInetAddressHandle source_specific, string iface, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_connect(GSocketHandle socket, GSocketAddressHandle address, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_check_connect_result(GSocketHandle socket, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_socket_get_available_bytes(GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOCondition g_socket_condition_check(GSocketHandle socket, GIOCondition condition);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_condition_wait(GSocketHandle socket, GIOCondition condition, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_condition_timed_wait(GSocketHandle socket, GIOCondition condition, nint timeout_us, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketHandle g_socket_accept(GSocketHandle socket, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_listen(GSocketHandle socket, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_socket_receive(GSocketHandle socket, string buffer, nuint size, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_socket_receive_from(GSocketHandle socket, out GSocketAddressHandle address, string buffer, nuint size, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_socket_send(GSocketHandle socket, string buffer, nuint size, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_socket_send_to(GSocketHandle socket, GSocketAddressHandle address, string buffer, nuint size, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_socket_receive_message(GSocketHandle socket, out GSocketAddressHandle address, GInputVectorHandle vectors, int num_vectors, out GSocketControlMessageHandle messages, [NativeTypeName("gint *")] int* num_messages, [NativeTypeName("gint *")] int* flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_socket_send_message(GSocketHandle socket, GSocketAddressHandle address, GOutputVectorHandle vectors, int num_vectors, out GSocketControlMessageHandle messages, int num_messages, int flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_receive_messages(GSocketHandle socket, GInputMessageHandle messages, uint num_messages, int flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_send_messages(GSocketHandle socket, GOutputMessageHandle messages, uint num_messages, int flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_close(GSocketHandle socket, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_shutdown(GSocketHandle socket, int shutdown_read, int shutdown_write, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_is_closed(GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSourceHandle g_socket_create_source(GSocketHandle socket, GIOCondition condition, GCancellableHandle cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_speaks_ipv4(GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GCredentialsHandle g_socket_get_credentials(GSocketHandle socket, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_socket_receive_with_blocking(GSocketHandle socket, string buffer, nuint size, int blocking, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_socket_send_with_blocking(GSocketHandle socket, string buffer, nuint size, int blocking, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GPollableReturn g_socket_send_message_with_timeout(GSocketHandle socket, GSocketAddressHandle address, GOutputVectorHandle vectors, int num_vectors, out GSocketControlMessageHandle messages, int num_messages, int flags, nint timeout_us, out nuint bytes_written, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_get_option(GSocketHandle socket, int level, int optname, [NativeTypeName("gint *")] int* value, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_set_option(GSocketHandle socket, int level, int optname, int value, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_socket_client_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketClientHandle g_socket_client_new();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketFamily g_socket_client_get_family(GSocketClientHandle client);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_client_set_family(GSocketClientHandle client, GSocketFamily family);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketType g_socket_client_get_socket_type(GSocketClientHandle client);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_client_set_socket_type(GSocketClientHandle client, GSocketType type);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketProtocol g_socket_client_get_protocol(GSocketClientHandle client);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_client_set_protocol(GSocketClientHandle client, GSocketProtocol protocol);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketAddressHandle g_socket_client_get_local_address(GSocketClientHandle client);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_client_set_local_address(GSocketClientHandle client, GSocketAddressHandle address);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern uint g_socket_client_get_timeout(GSocketClientHandle client);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_client_set_timeout(GSocketClientHandle client, uint timeout);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_client_get_enable_proxy(GSocketClientHandle client);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_client_set_enable_proxy(GSocketClientHandle client, int enable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_client_get_tls(GSocketClientHandle client);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_client_set_tls(GSocketClientHandle client, int tls);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern GTlsCertificateFlags g_socket_client_get_tls_validation_flags(GSocketClientHandle client);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_socket_client_set_tls_validation_flags(GSocketClientHandle client, GTlsCertificateFlags flags);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GProxyResolverHandle g_socket_client_get_proxy_resolver(GSocketClientHandle client);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_client_set_proxy_resolver(GSocketClientHandle client, GProxyResolverHandle proxy_resolver);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectionHandle g_socket_client_connect(GSocketClientHandle client, GSocketConnectableHandle connectable, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectionHandle g_socket_client_connect_to_host(GSocketClientHandle client, string host_and_port, ushort default_port, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectionHandle g_socket_client_connect_to_service(GSocketClientHandle client, string domain, string service, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectionHandle g_socket_client_connect_to_uri(GSocketClientHandle client, string uri, ushort default_port, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_client_connect_async(GSocketClientHandle client, GSocketConnectableHandle connectable, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectionHandle g_socket_client_connect_finish(GSocketClientHandle client, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_client_connect_to_host_async(GSocketClientHandle client, string host_and_port, ushort default_port, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectionHandle g_socket_client_connect_to_host_finish(GSocketClientHandle client, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_client_connect_to_service_async(GSocketClientHandle client, string domain, string service, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectionHandle g_socket_client_connect_to_service_finish(GSocketClientHandle client, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_client_connect_to_uri_async(GSocketClientHandle client, string uri, ushort default_port, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectionHandle g_socket_client_connect_to_uri_finish(GSocketClientHandle client, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_client_add_application_proxy(GSocketClientHandle client, string protocol);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_socket_connectable_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketAddressEnumeratorHandle g_socket_connectable_enumerate(GSocketConnectableHandle connectable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketAddressEnumeratorHandle g_socket_connectable_proxy_enumerate(GSocketConnectableHandle connectable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_socket_connectable_to_string(GSocketConnectableHandle connectable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_socket_connection_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_connection_is_connected(GSocketConnectionHandle connection);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_connection_connect(GSocketConnectionHandle connection, GSocketAddressHandle address, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_connection_connect_async(GSocketConnectionHandle connection, GSocketAddressHandle address, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_connection_connect_finish(GSocketConnectionHandle connection, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketHandle g_socket_connection_get_socket(GSocketConnectionHandle connection);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketAddressHandle g_socket_connection_get_local_address(GSocketConnectionHandle connection, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketAddressHandle g_socket_connection_get_remote_address(GSocketConnectionHandle connection, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_connection_factory_register_type(GType g_type, GSocketFamily family, GSocketType type, int protocol);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_socket_connection_factory_lookup_type(GSocketFamily family, GSocketType type, int protocol_id);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectionHandle g_socket_connection_factory_create_connection(GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_socket_control_message_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nuint g_socket_control_message_get_size(GSocketControlMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_control_message_get_level(GSocketControlMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_control_message_get_msg_type(GSocketControlMessageHandle message);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_control_message_serialize(GSocketControlMessageHandle message, IntPtr data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketControlMessageHandle g_socket_control_message_deserialize(int level, int type, nuint size, IntPtr data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_socket_listener_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketListenerHandle g_socket_listener_new();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_listener_set_backlog(GSocketListenerHandle listener, int listen_backlog);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_listener_add_socket(GSocketListenerHandle listener, GSocketHandle socket, GObjectHandle source_object, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_listener_add_address(GSocketListenerHandle listener, GSocketAddressHandle address, GSocketType type, GSocketProtocol protocol, GObjectHandle source_object, out GSocketAddressHandle effective_address, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_listener_add_inet_port(GSocketListenerHandle listener, ushort port, GObjectHandle source_object, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern ushort g_socket_listener_add_any_inet_port(GSocketListenerHandle listener, GObjectHandle source_object, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketHandle g_socket_listener_accept_socket(GSocketListenerHandle listener, out GObjectHandle source_object, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_listener_accept_socket_async(GSocketListenerHandle listener, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketHandle g_socket_listener_accept_socket_finish(GSocketListenerHandle listener, GAsyncResultHandle result, out GObjectHandle source_object, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectionHandle g_socket_listener_accept(GSocketListenerHandle listener, out GObjectHandle source_object, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_listener_accept_async(GSocketListenerHandle listener, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectionHandle g_socket_listener_accept_finish(GSocketListenerHandle listener, GAsyncResultHandle result, out GObjectHandle source_object, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_listener_close(GSocketListenerHandle listener);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_socket_service_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketServiceHandle g_socket_service_new();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_service_start(GSocketServiceHandle service);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_socket_service_stop(GSocketServiceHandle service);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_socket_service_is_active(GSocketServiceHandle service);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_srv_target_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSrvTargetHandle g_srv_target_new(string hostname, ushort port, ushort priority, ushort weight);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSrvTargetHandle g_srv_target_copy(GSrvTargetHandle target);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_srv_target_free(GSrvTargetHandle target);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_srv_target_get_hostname(GSrvTargetHandle target);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern ushort g_srv_target_get_port(GSrvTargetHandle target);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern ushort g_srv_target_get_priority(GSrvTargetHandle target);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern ushort g_srv_target_get_weight(GSrvTargetHandle target);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_srv_target_list_sort(GListHandle targets);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_subprocess_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSubprocessHandle g_subprocess_new(GSubprocessFlags flags, out GErrorHandle error, string argv0, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSubprocessHandle g_subprocess_newv(string argv, GSubprocessFlags flags, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GOutputStreamHandle g_subprocess_get_stdin_pipe(GSubprocessHandle subprocess);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInputStreamHandle g_subprocess_get_stdout_pipe(GSubprocessHandle subprocess);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GInputStreamHandle g_subprocess_get_stderr_pipe(GSubprocessHandle subprocess);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_subprocess_get_identifier(GSubprocessHandle subprocess);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_send_signal(GSubprocessHandle subprocess, int signal_num);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_force_exit(GSubprocessHandle subprocess);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_subprocess_wait(GSubprocessHandle subprocess, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_wait_async(GSubprocessHandle subprocess, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_subprocess_wait_finish(GSubprocessHandle subprocess, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_subprocess_wait_check(GSubprocessHandle subprocess, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_wait_check_async(GSubprocessHandle subprocess, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_subprocess_wait_check_finish(GSubprocessHandle subprocess, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_subprocess_get_status(GSubprocessHandle subprocess);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_subprocess_get_successful(GSubprocessHandle subprocess);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_subprocess_get_if_exited(GSubprocessHandle subprocess);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_subprocess_get_exit_status(GSubprocessHandle subprocess);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_subprocess_get_if_signaled(GSubprocessHandle subprocess);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_subprocess_get_term_sig(GSubprocessHandle subprocess);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_subprocess_communicate(GSubprocessHandle subprocess, GBytesHandle stdin_buf, GCancellableHandle cancellable, out GBytesHandle stdout_buf, out GBytesHandle stderr_buf, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_communicate_async(GSubprocessHandle subprocess, GBytesHandle stdin_buf, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_subprocess_communicate_finish(GSubprocessHandle subprocess, GAsyncResultHandle result, out GBytesHandle stdout_buf, out GBytesHandle stderr_buf, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_subprocess_communicate_utf8(GSubprocessHandle subprocess, string stdin_buf, GCancellableHandle cancellable, string[] stdout_buf, string[] stderr_buf, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_communicate_utf8_async(GSubprocessHandle subprocess, string stdin_buf, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_subprocess_communicate_utf8_finish(GSubprocessHandle subprocess, GAsyncResultHandle result, string[] stdout_buf, string[] stderr_buf, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_subprocess_launcher_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSubprocessLauncherHandle g_subprocess_launcher_new(GSubprocessFlags flags);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSubprocessHandle g_subprocess_launcher_spawn(GSubprocessLauncherHandle self, out GErrorHandle error, string argv0, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSubprocessHandle g_subprocess_launcher_spawnv(GSubprocessLauncherHandle self, string argv, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_launcher_set_environ(GSubprocessLauncherHandle self, string[] env);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_launcher_setenv(GSubprocessLauncherHandle self, string variable, string value, int overwrite);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_launcher_unsetenv(GSubprocessLauncherHandle self, string variable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_subprocess_launcher_getenv(GSubprocessLauncherHandle self, string variable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_launcher_set_cwd(GSubprocessLauncherHandle self, string cwd);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_launcher_set_flags(GSubprocessLauncherHandle self, GSubprocessFlags flags);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_launcher_set_stdin_file_path(GSubprocessLauncherHandle self, string path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_launcher_take_stdin_fd(GSubprocessLauncherHandle self, int fd);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_launcher_set_stdout_file_path(GSubprocessLauncherHandle self, string path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_launcher_take_stdout_fd(GSubprocessLauncherHandle self, int fd);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_launcher_set_stderr_file_path(GSubprocessLauncherHandle self, string path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_launcher_take_stderr_fd(GSubprocessLauncherHandle self, int fd);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_launcher_take_fd(GSubprocessLauncherHandle self, int source_fd, int target_fd);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_launcher_close(GSubprocessLauncherHandle self);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_subprocess_launcher_set_child_setup(GSubprocessLauncherHandle self, GSpawnChildSetupFunc child_setup, IntPtr user_data, GDestroyNotify destroy_notify);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_task_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTaskHandle g_task_new(IntPtr source_object, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr callback_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_task_report_error(IntPtr source_object, GAsyncReadyCallback callback, IntPtr callback_data, IntPtr source_tag, GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_task_report_new_error(IntPtr source_object, GAsyncReadyCallback callback, IntPtr callback_data, IntPtr source_tag, GQuark domain, int code, string format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_task_set_task_data(GTaskHandle task, IntPtr task_data, GDestroyNotify task_data_destroy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_task_set_priority(GTaskHandle task, int priority);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_task_set_check_cancellable(GTaskHandle task, int check_cancellable);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_task_set_source_tag(GTaskHandle task, IntPtr source_tag);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_task_set_name(GTaskHandle task, string name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern IntPtr g_task_get_source_object(GTaskHandle task);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern IntPtr g_task_get_task_data(GTaskHandle task);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_task_get_priority(GTaskHandle task);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GMainContextHandle g_task_get_context(GTaskHandle task);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GCancellableHandle g_task_get_cancellable(GTaskHandle task);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_task_get_check_cancellable(GTaskHandle task);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern IntPtr g_task_get_source_tag(GTaskHandle task);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_task_get_name(GTaskHandle task);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_task_is_valid(IntPtr result, IntPtr source_object);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_task_run_in_thread(GTaskHandle task, GTaskThreadFunc task_func);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_task_run_in_thread_sync(GTaskHandle task, GTaskThreadFunc task_func);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_task_set_return_on_cancel(GTaskHandle task, int return_on_cancel);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_task_get_return_on_cancel(GTaskHandle task);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_task_attach_source(GTaskHandle task, GSourceHandle source, GSourceFunc callback);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_task_return_pointer(GTaskHandle task, IntPtr result, GDestroyNotify result_destroy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_task_return_boolean(GTaskHandle task, int result);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_task_return_int(GTaskHandle task, nint result);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_task_return_error(GTaskHandle task, GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_task_return_new_error(GTaskHandle task, GQuark domain, int code, string format, __arglist);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_task_return_value(GTaskHandle task, GValueHandle result);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_task_return_error_if_cancelled(GTaskHandle task);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern IntPtr g_task_propagate_pointer(GTaskHandle task, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_task_propagate_boolean(GTaskHandle task, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern nint g_task_propagate_int(GTaskHandle task, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_task_propagate_value(GTaskHandle task, GValueHandle value, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_task_had_error(GTaskHandle task);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_task_get_completed(GTaskHandle task);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tcp_connection_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tcp_connection_set_graceful_disconnect(GTcpConnectionHandle connection, int graceful_disconnect);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_tcp_connection_get_graceful_disconnect(GTcpConnectionHandle connection);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tcp_wrapper_connection_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectionHandle g_tcp_wrapper_connection_new(GIOStreamHandle base_io_stream, GSocketHandle socket);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOStreamHandle g_tcp_wrapper_connection_get_base_io_stream(GTcpWrapperConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_test_dbus_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTestDBusHandle g_test_dbus_new(GTestDBusFlags flags);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTestDBusFlags g_test_dbus_get_flags(GTestDBusHandle self);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_test_dbus_get_bus_address(GTestDBusHandle self);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_test_dbus_add_service_dir(GTestDBusHandle self, string path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_test_dbus_up(GTestDBusHandle self);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_test_dbus_stop(GTestDBusHandle self);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_test_dbus_down(GTestDBusHandle self);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_test_dbus_unset();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_themed_icon_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_themed_icon_new(string iconname);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_themed_icon_new_with_default_fallbacks(string iconname);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_themed_icon_new_from_names(string[] iconnames, int len);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_themed_icon_prepend_name(GThemedIconHandle icon, string iconname);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_themed_icon_append_name(GThemedIconHandle icon, string iconname);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_themed_icon_get_names(GThemedIconHandle icon);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_threaded_socket_service_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketServiceHandle g_threaded_socket_service_new(int max_threads);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_backend_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsBackendHandle g_tls_backend_get_default();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsDatabaseHandle g_tls_backend_get_default_database(GTlsBackendHandle backend);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_backend_set_default_database(GTlsBackendHandle backend, GTlsDatabaseHandle database);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_tls_backend_supports_tls(GTlsBackendHandle backend);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_tls_backend_supports_dtls(GTlsBackendHandle backend);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_backend_get_certificate_type(GTlsBackendHandle backend);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_backend_get_client_connection_type(GTlsBackendHandle backend);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_backend_get_server_connection_type(GTlsBackendHandle backend);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_backend_get_file_database_type(GTlsBackendHandle backend);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_backend_get_dtls_client_connection_type(GTlsBackendHandle backend);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_backend_get_dtls_server_connection_type(GTlsBackendHandle backend);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_certificate_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateHandle g_tls_certificate_new_from_pem(string data, nint length, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateHandle g_tls_certificate_new_from_pkcs12([NativeTypeName("const guint8 *")] byte* data, nuint length, string password, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateHandle g_tls_certificate_new_from_file_with_password(string file, string password, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateHandle g_tls_certificate_new_from_file(string file, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateHandle g_tls_certificate_new_from_files(string cert_file, string key_file, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateHandle g_tls_certificate_new_from_pkcs11_uris(string pkcs11_uri, string private_key_pkcs11_uri, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_tls_certificate_list_new_from_file(string file, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateHandle g_tls_certificate_get_issuer(GTlsCertificateHandle cert);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateFlags g_tls_certificate_verify(GTlsCertificateHandle cert, GSocketConnectableHandle identity, GTlsCertificateHandle trusted_ca);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_tls_certificate_is_same(GTlsCertificateHandle cert_one, GTlsCertificateHandle cert_two);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDateTimeHandle g_tls_certificate_get_not_valid_before(GTlsCertificateHandle cert);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDateTimeHandle g_tls_certificate_get_not_valid_after(GTlsCertificateHandle cert);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_tls_certificate_get_subject_name(GTlsCertificateHandle cert);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_tls_certificate_get_issuer_name(GTlsCertificateHandle cert);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GPtrArrayHandle g_tls_certificate_get_dns_names(GTlsCertificateHandle cert);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GPtrArrayHandle g_tls_certificate_get_ip_addresses(GTlsCertificateHandle cert);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_connection_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_tls_connection_set_use_system_certdb(GTlsConnectionHandle conn, int use_system_certdb);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern int g_tls_connection_get_use_system_certdb(GTlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_connection_set_database(GTlsConnectionHandle conn, GTlsDatabaseHandle database);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsDatabaseHandle g_tls_connection_get_database(GTlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_connection_set_certificate(GTlsConnectionHandle conn, GTlsCertificateHandle certificate);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateHandle g_tls_connection_get_certificate(GTlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_connection_set_interaction(GTlsConnectionHandle conn, GTlsInteractionHandle interaction);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsInteractionHandle g_tls_connection_get_interaction(GTlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateHandle g_tls_connection_get_peer_certificate(GTlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateFlags g_tls_connection_get_peer_certificate_errors(GTlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_connection_set_require_close_notify(GTlsConnectionHandle conn, int require_close_notify);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_tls_connection_get_require_close_notify(GTlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_tls_connection_set_rehandshake_mode(GTlsConnectionHandle conn, GTlsRehandshakeMode mode);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern GTlsRehandshakeMode g_tls_connection_get_rehandshake_mode(GTlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_connection_set_advertised_protocols(GTlsConnectionHandle conn, string protocols);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_tls_connection_get_negotiated_protocol(GTlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_tls_connection_get_channel_binding_data(GTlsConnectionHandle conn, GTlsChannelBindingType type, GByteArrayHandle data, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_tls_connection_handshake(GTlsConnectionHandle conn, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_connection_handshake_async(GTlsConnectionHandle conn, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_tls_connection_handshake_finish(GTlsConnectionHandle conn, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsProtocolVersion g_tls_connection_get_protocol_version(GTlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_tls_connection_get_ciphersuite_name(GTlsConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GQuark g_tls_error_quark();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GQuark g_tls_channel_binding_error_quark();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_tls_connection_emit_accept_certificate(GTlsConnectionHandle conn, GTlsCertificateHandle peer_cert, GTlsCertificateFlags errors);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_client_connection_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOStreamHandle g_tls_client_connection_new(GIOStreamHandle base_io_stream, GSocketConnectableHandle server_identity, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern GTlsCertificateFlags g_tls_client_connection_get_validation_flags(GTlsClientConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_tls_client_connection_set_validation_flags(GTlsClientConnectionHandle conn, GTlsCertificateFlags flags);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GSocketConnectableHandle g_tls_client_connection_get_server_identity(GTlsClientConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_client_connection_set_server_identity(GTlsClientConnectionHandle conn, GSocketConnectableHandle identity);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern int g_tls_client_connection_get_use_ssl3(GTlsClientConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_tls_client_connection_set_use_ssl3(GTlsClientConnectionHandle conn, int use_ssl3);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_tls_client_connection_get_accepted_cas(GTlsClientConnectionHandle conn);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_client_connection_copy_session_state(GTlsClientConnectionHandle conn, GTlsClientConnectionHandle source);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_database_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateFlags g_tls_database_verify_chain(GTlsDatabaseHandle self, GTlsCertificateHandle chain, string purpose, GSocketConnectableHandle identity, GTlsInteractionHandle interaction, GTlsDatabaseVerifyFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_database_verify_chain_async(GTlsDatabaseHandle self, GTlsCertificateHandle chain, string purpose, GSocketConnectableHandle identity, GTlsInteractionHandle interaction, GTlsDatabaseVerifyFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateFlags g_tls_database_verify_chain_finish(GTlsDatabaseHandle self, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_tls_database_create_certificate_handle(GTlsDatabaseHandle self, GTlsCertificateHandle certificate);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateHandle g_tls_database_lookup_certificate_for_handle(GTlsDatabaseHandle self, string handle, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_database_lookup_certificate_for_handle_async(GTlsDatabaseHandle self, string handle, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateHandle g_tls_database_lookup_certificate_for_handle_finish(GTlsDatabaseHandle self, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateHandle g_tls_database_lookup_certificate_issuer(GTlsDatabaseHandle self, GTlsCertificateHandle certificate, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_database_lookup_certificate_issuer_async(GTlsDatabaseHandle self, GTlsCertificateHandle certificate, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsCertificateHandle g_tls_database_lookup_certificate_issuer_finish(GTlsDatabaseHandle self, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_tls_database_lookup_certificates_issued_by(GTlsDatabaseHandle self, GByteArrayHandle issuer_raw_dn, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_database_lookup_certificates_issued_by_async(GTlsDatabaseHandle self, GByteArrayHandle issuer_raw_dn, GTlsInteractionHandle interaction, GTlsDatabaseLookupFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GListHandle g_tls_database_lookup_certificates_issued_by_finish(GTlsDatabaseHandle self, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_file_database_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsDatabaseHandle g_tls_file_database_new(string anchors, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_interaction_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsInteractionResult g_tls_interaction_invoke_ask_password(GTlsInteractionHandle interaction, GTlsPasswordHandle password, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsInteractionResult g_tls_interaction_ask_password(GTlsInteractionHandle interaction, GTlsPasswordHandle password, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_interaction_ask_password_async(GTlsInteractionHandle interaction, GTlsPasswordHandle password, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsInteractionResult g_tls_interaction_ask_password_finish(GTlsInteractionHandle interaction, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsInteractionResult g_tls_interaction_invoke_request_certificate(GTlsInteractionHandle interaction, GTlsConnectionHandle connection, GTlsCertificateRequestFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsInteractionResult g_tls_interaction_request_certificate(GTlsInteractionHandle interaction, GTlsConnectionHandle connection, GTlsCertificateRequestFlags flags, GCancellableHandle cancellable, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_interaction_request_certificate_async(GTlsInteractionHandle interaction, GTlsConnectionHandle connection, GTlsCertificateRequestFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsInteractionResult g_tls_interaction_request_certificate_finish(GTlsInteractionHandle interaction, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_password_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GTlsPasswordHandle g_tls_password_new(_GTlsPasswordFlags flags, string description);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_tls_password_get_value(GTlsPasswordHandle password, out nuint length);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_password_set_value(GTlsPasswordHandle password, string value, nint length);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_password_set_value_full(GTlsPasswordHandle password, string value, nint length, GDestroyNotify destroy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern _GTlsPasswordFlags g_tls_password_get_flags(GTlsPasswordHandle password);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_password_set_flags(GTlsPasswordHandle password, _GTlsPasswordFlags flags);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_tls_password_get_description(GTlsPasswordHandle password);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_password_set_description(GTlsPasswordHandle password, string description);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_tls_password_get_warning(GTlsPasswordHandle password);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_tls_password_set_warning(GTlsPasswordHandle password, string warning);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_tls_server_connection_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIOStreamHandle g_tls_server_connection_new(GIOStreamHandle base_io_stream, GTlsCertificateHandle certificate, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_vfs_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_vfs_is_active(GVfsHandle vfs);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_vfs_get_file_for_path(GVfsHandle vfs, string path);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_vfs_get_file_for_uri(GVfsHandle vfs, string uri);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_vfs_get_supported_uri_schemes(GVfsHandle vfs);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_vfs_parse_name(GVfsHandle vfs, string parse_name);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVfsHandle g_vfs_get_default();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GVfsHandle g_vfs_get_local();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_vfs_register_uri_scheme(GVfsHandle vfs, string scheme, GVfsFileLookupFunc uri_func, IntPtr uri_data, GDestroyNotify uri_destroy, GVfsFileLookupFunc parse_name_func, IntPtr parse_name_data, GDestroyNotify parse_name_destroy);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_vfs_unregister_uri_scheme(GVfsHandle vfs, string scheme);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_volume_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_volume_get_name(GVolumeHandle volume);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_volume_get_icon(GVolumeHandle volume);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GIconHandle g_volume_get_symbolic_icon(GVolumeHandle volume);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_volume_get_uuid(GVolumeHandle volume);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GDriveHandle g_volume_get_drive(GVolumeHandle volume);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GMountHandle g_volume_get_mount(GVolumeHandle volume);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_volume_can_mount(GVolumeHandle volume);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_volume_can_eject(GVolumeHandle volume);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_volume_should_automount(GVolumeHandle volume);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_volume_mount(GVolumeHandle volume, GMountMountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_volume_mount_finish(GVolumeHandle volume, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern void g_volume_eject(GVolumeHandle volume, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// [Obsolete]
	// public static extern int g_volume_eject_finish(GVolumeHandle volume, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_volume_get_identifier(GVolumeHandle volume, string kind);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string[] g_volume_enumerate_identifiers(GVolumeHandle volume);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileHandle g_volume_get_activation_root(GVolumeHandle volume);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_volume_eject_with_operation(GVolumeHandle volume, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern int g_volume_eject_with_operation_finish(GVolumeHandle volume, GAsyncResultHandle result, out GErrorHandle error);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern string g_volume_get_sort_key(GVolumeHandle volume);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_zlib_compressor_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GZlibCompressorHandle g_zlib_compressor_new(GZlibCompressorFormat format, int level);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileInfoHandle g_zlib_compressor_get_file_info(GZlibCompressorHandle compressor);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern void g_zlib_compressor_set_file_info(GZlibCompressorHandle compressor, GFileInfoHandle file_info);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GType g_zlib_decompressor_get_type();
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GZlibDecompressorHandle g_zlib_decompressor_new(GZlibCompressorFormat format);
	//
	// [DllImport(Libraries.Gio, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	// public static extern GFileInfoHandle g_zlib_decompressor_get_file_info(GZlibDecompressorHandle decompressor);
}
