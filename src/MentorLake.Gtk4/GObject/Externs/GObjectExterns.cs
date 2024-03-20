using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GObjectExterns
{
    [DllImport(Libraries.GObject, EntryPoint = "g_type_interface_peek")]
    internal static extern IntPtr g_type_interface_peek(this GObjectHandle instance_class, GType iface_type);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_emit_valist")]
    internal static extern void g_signal_emit_valist(this GObjectHandle instance, uint signal_id, GQuark detail, IntPtr @__argList);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_emit")]
    internal static extern void g_signal_emit(this GObjectHandle instance, uint signal_id, GQuark detail, IntPtr @__argList);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_emit_by_name")]
    internal static extern void g_signal_emit_by_name(this GObjectHandle instance, string detailed_signal, IntPtr @__argList);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_get_invocation_hint")]
    internal static extern GSignalInvocationHintHandle g_signal_get_invocation_hint(this GObjectHandle instance);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_stop_emission")]
    internal static extern void g_signal_stop_emission(this GObjectHandle instance, uint signal_id, GQuark detail);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_stop_emission_by_name")]
    internal static extern void g_signal_stop_emission_by_name(this GObjectHandle instance, string detailed_signal);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_has_handler_pending")]
    internal static extern int g_signal_has_handler_pending(this GObjectHandle instance, uint signal_id, GQuark detail, int may_be_blocked);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_connect_closure_by_id")]
    internal static extern nuint g_signal_connect_closure_by_id(this GObjectHandle instance, uint signal_id, GQuark detail, GClosureHandle closure, int after);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_connect_closure")]
    internal static extern nuint g_signal_connect_closure(this GObjectHandle instance, string detailed_signal, GClosureHandle closure, int after);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_connect_data")]
    internal static extern nuint g_signal_connect_data(this GObjectHandle instance, string detailed_signal, GCallback c_handler, IntPtr data, GClosureNotify destroy_data, GConnectFlags connect_flags);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_handler_block")]
    internal static extern void g_signal_handler_block(this GObjectHandle instance, nuint handler_id);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_handler_unblock")]
    internal static extern void g_signal_handler_unblock(this GObjectHandle instance, nuint handler_id);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_handler_disconnect")]
    internal static extern void g_signal_handler_disconnect(this GObjectHandle instance, nuint handler_id);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_handler_is_connected")]
    internal static extern int g_signal_handler_is_connected(this GObjectHandle instance, nuint handler_id);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_handler_find")]
    internal static extern nuint g_signal_handler_find(this GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_handlers_block_matched")]
    internal static extern uint g_signal_handlers_block_matched(this GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_handlers_unblock_matched")]
    internal static extern uint g_signal_handlers_unblock_matched(this GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_handlers_disconnect_matched")]
    internal static extern uint g_signal_handlers_disconnect_matched(this GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_chain_from_overridden_handler")]
    internal static extern void g_signal_chain_from_overridden_handler(this GObjectHandle instance, IntPtr @__argList);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_handlers_destroy")]
    internal static extern void g_signal_handlers_destroy(this GObjectHandle instance);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_setv")]
    internal static extern void g_object_setv(this GObjectHandle @object, uint n_properties, string[] names, GValue[] values);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_set_valist")]
    internal static extern void g_object_set_valist(this GObjectHandle @object, string first_property_name, IntPtr @__argList);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_getv")]
    internal static extern void g_object_getv(this GObjectHandle @object, uint n_properties, string[] names, GValue[] values);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_get_valist")]
    internal static extern void g_object_get_valist(this GObjectHandle @object, string first_property_name, IntPtr @__argList);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_set_property")]
    internal static extern void g_object_set_property(this GObjectHandle @object, string property_name, GValueHandle value);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_get_property")]
    internal static extern void g_object_get_property(this GObjectHandle @object, string property_name, GValueHandle value);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_freeze_notify")]
    internal static extern void g_object_freeze_notify(this GObjectHandle @object);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_notify")]
    internal static extern void g_object_notify(this GObjectHandle @object, string property_name);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_notify_by_pspec")]
    internal static extern void g_object_notify_by_pspec(this GObjectHandle @object, GParamSpecHandle pspec);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_thaw_notify")]
    internal static extern void g_object_thaw_notify(this GObjectHandle @object);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_is_floating")]
    internal static extern int g_object_is_floating(this GObjectHandle @object);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_ref_sink")]
    internal static extern IntPtr g_object_ref_sink(this GObjectHandle @object);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_take_ref")]
    internal static extern IntPtr g_object_take_ref(this GObjectHandle @object);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_ref")]
    internal static extern IntPtr g_object_ref(this GObjectHandle @object);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_unref")]
    internal static extern void g_object_unref(this GObjectHandle @object);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_weak_ref")]
    internal static extern void g_object_weak_ref(this GObjectHandle @object, GWeakNotify notify, IntPtr data);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_weak_unref")]
    internal static extern void g_object_weak_unref(this GObjectHandle @object, GWeakNotify notify, IntPtr data);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_add_weak_pointer")]
    internal static extern void g_object_add_weak_pointer(this GObjectHandle @object, IntPtr weak_pointer_location);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_remove_weak_pointer")]
    internal static extern void g_object_remove_weak_pointer(this GObjectHandle @object, IntPtr weak_pointer_location);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_add_toggle_ref")]
    internal static extern void g_object_add_toggle_ref(this GObjectHandle @object, GToggleNotify notify, IntPtr data);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_remove_toggle_ref")]
    internal static extern void g_object_remove_toggle_ref(this GObjectHandle @object, GToggleNotify notify, IntPtr data);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_get_qdata")]
    internal static extern IntPtr g_object_get_qdata(this GObjectHandle @object, GQuark quark);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_set_qdata")]
    internal static extern void g_object_set_qdata(this GObjectHandle @object, GQuark quark, IntPtr data);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_set_qdata_full")]
    internal static extern void g_object_set_qdata_full(this GObjectHandle @object, GQuark quark, IntPtr data, GDestroyNotify destroy);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_steal_qdata")]
    internal static extern IntPtr g_object_steal_qdata(this GObjectHandle @object, GQuark quark);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_dup_qdata")]
    internal static extern IntPtr g_object_dup_qdata(this GObjectHandle @object, GQuark quark, GDuplicateFunc dup_func, IntPtr user_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_replace_qdata")]
    internal static extern int g_object_replace_qdata(this GObjectHandle @object, GQuark quark, IntPtr oldval, IntPtr newval, GDestroyNotify destroy, out GDestroyNotify old_destroy);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_get_data")]
    internal static extern IntPtr g_object_get_data(this GObjectHandle @object, string key);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_set_data")]
    internal static extern void g_object_set_data(this GObjectHandle @object, string key, IntPtr data);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_set_data_full")]
    internal static extern void g_object_set_data_full(this GObjectHandle @object, string key, IntPtr data, GDestroyNotify destroy);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_steal_data")]
    internal static extern IntPtr g_object_steal_data(this GObjectHandle @object, string key);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_dup_data")]
    internal static extern IntPtr g_object_dup_data(this GObjectHandle @object, string key, GDuplicateFunc dup_func, IntPtr user_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_replace_data")]
    internal static extern int g_object_replace_data(this GObjectHandle @object, string key, IntPtr oldval, IntPtr newval, GDestroyNotify destroy, out GDestroyNotify old_destroy);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_watch_closure")]
    internal static extern void g_object_watch_closure(this GObjectHandle @object, GClosureHandle closure);
    [DllImport(Libraries.GObject, EntryPoint = "g_signal_connect_object")]
    internal static extern nuint g_signal_connect_object(this GObjectHandle instance, string detailed_signal, GCallback c_handler, IntPtr gobject, GConnectFlags connect_flags);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_force_floating")]
    internal static extern void g_object_force_floating(this GObjectHandle @object);
    [DllImport(Libraries.GObject, EntryPoint = "g_object_run_dispose")]
    internal static extern void g_object_run_dispose(this GObjectHandle @object);
    [DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GObjectHandle g_object_new_with_properties(GType object_type, uint n_properties, string[] names, GValue[] values);
    [DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GObjectHandle g_object_new_valist(GType object_type, string first_property_name, IntPtr @__arglist);
}
