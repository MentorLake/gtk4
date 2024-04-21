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

public class GObjectHandle : GTypeInstanceHandle
{
	public static GObjectHandle New(GType object_type, string first_property_name, IntPtr @__arglist)
	{
		return GObjectExterns.g_object_new(object_type, first_property_name, @__arglist);
	}

	public static GObjectHandle NewValist(GType object_type, string first_property_name, IntPtr var_args)
	{
		return GObjectExterns.g_object_new_valist(object_type, first_property_name, var_args);
	}

	public static GObjectHandle NewWithProperties(GType object_type, uint n_properties, string[] names, GValue[] values)
	{
		return GObjectExterns.g_object_new_with_properties(object_type, n_properties, names, values);
	}

	public static GObjectHandle Newv(GType object_type, uint n_parameters, GParameter[] parameters)
	{
		return GObjectExterns.g_object_newv(object_type, n_parameters, parameters);
	}

	public static int CompatControl(int what, IntPtr data)
	{
		return GObjectExterns.g_object_compat_control(what, data);
	}

	public static GParamSpecHandle InterfaceFindProperty(GTypeInterfaceHandle g_iface, string property_name)
	{
		return GObjectExterns.g_object_interface_find_property(g_iface, property_name);
	}

	public static void InterfaceInstallProperty(GTypeInterfaceHandle g_iface, GParamSpecHandle pspec)
	{
		GObjectExterns.g_object_interface_install_property(g_iface, pspec);
	}

	public static GParamSpecHandle[] InterfaceListProperties(GTypeInterfaceHandle g_iface, out uint n_properties_p)
	{
		return GObjectExterns.g_object_interface_list_properties(g_iface, out n_properties_p);
	}

}

public class GObjectSignal
{
	public string Value { get; set; }
	public GObjectSignal(string value) => Value = value;
}

public static class GObjectSignals
{
	public static GObjectSignal Notify = new("BindingTransform.MethodDeclaration");
}

public static class GObjectHandleExtensions
{
	public static GObjectHandle AddToggleRef(this GObjectHandle @object, GToggleNotify notify, IntPtr data)
	{
		GObjectExterns.g_object_add_toggle_ref(@object, notify, data);
		return @object;
	}

	public static GObjectHandle AddWeakPointer(this GObjectHandle @object, ref IntPtr weak_pointer_location)
	{
		GObjectExterns.g_object_add_weak_pointer(@object, ref weak_pointer_location);
		return @object;
	}

	public static GBindingHandle BindProperty(this GObjectHandle source, string source_property, GObjectHandle target, string target_property, GBindingFlags flags)
	{
		return GObjectExterns.g_object_bind_property(source, source_property, target, target_property, flags);
	}

	public static GBindingHandle BindPropertyFull(this GObjectHandle source, string source_property, GObjectHandle target, string target_property, GBindingFlags flags, GBindingTransformFunc transform_to, GBindingTransformFunc transform_from, IntPtr user_data, GDestroyNotify notify)
	{
		return GObjectExterns.g_object_bind_property_full(source, source_property, target, target_property, flags, transform_to, transform_from, user_data, notify);
	}

	public static GBindingHandle BindPropertyWithClosures(this GObjectHandle source, string source_property, GObjectHandle target, string target_property, GBindingFlags flags, GClosureHandle transform_to, GClosureHandle transform_from)
	{
		return GObjectExterns.g_object_bind_property_with_closures(source, source_property, target, target_property, flags, transform_to, transform_from);
	}

	public static GObjectHandle Connect(this GObjectHandle @object, string signal_spec, IntPtr @__arglist)
	{
		return GObjectExterns.g_object_connect(@object, signal_spec, @__arglist);
	}

	public static GObjectHandle Disconnect(this GObjectHandle @object, string signal_spec, IntPtr @__arglist)
	{
		GObjectExterns.g_object_disconnect(@object, signal_spec, @__arglist);
		return @object;
	}

	public static IntPtr DupData(this GObjectHandle @object, string key, GDuplicateFunc dup_func, IntPtr user_data)
	{
		return GObjectExterns.g_object_dup_data(@object, key, dup_func, user_data);
	}

	public static IntPtr DupQdata(this GObjectHandle @object, GQuark quark, GDuplicateFunc dup_func, IntPtr user_data)
	{
		return GObjectExterns.g_object_dup_qdata(@object, quark, dup_func, user_data);
	}

	public static GObjectHandle ForceFloating(this GObjectHandle @object)
	{
		GObjectExterns.g_object_force_floating(@object);
		return @object;
	}

	public static GObjectHandle FreezeNotify(this GObjectHandle @object)
	{
		GObjectExterns.g_object_freeze_notify(@object);
		return @object;
	}

	public static GObjectHandle Get(this GObjectHandle @object, string first_property_name, IntPtr @__arglist)
	{
		GObjectExterns.g_object_get(@object, first_property_name, @__arglist);
		return @object;
	}

	public static IntPtr GetData(this GObjectHandle @object, string key)
	{
		return GObjectExterns.g_object_get_data(@object, key);
	}

	public static GObjectHandle GetProperty(this GObjectHandle @object, string property_name, out GValue value)
	{
		GObjectExterns.g_object_get_property(@object, property_name, out value);
		return @object;
	}

	public static IntPtr GetQdata(this GObjectHandle @object, GQuark quark)
	{
		return GObjectExterns.g_object_get_qdata(@object, quark);
	}

	public static GObjectHandle GetValist(this GObjectHandle @object, string first_property_name, out IntPtr var_args)
	{
		GObjectExterns.g_object_get_valist(@object, first_property_name, out var_args);
		return @object;
	}

	public static GObjectHandle Getv(this GObjectHandle @object, uint n_properties, string[] names, GValue[] values)
	{
		GObjectExterns.g_object_getv(@object, n_properties, names, values);
		return @object;
	}

	public static bool IsFloating(this GObjectHandle @object)
	{
		return GObjectExterns.g_object_is_floating(@object);
	}

	public static GObjectHandle Notify(this GObjectHandle @object, string property_name)
	{
		GObjectExterns.g_object_notify(@object, property_name);
		return @object;
	}

	public static GObjectHandle NotifyByPspec(this GObjectHandle @object, GParamSpecHandle pspec)
	{
		GObjectExterns.g_object_notify_by_pspec(@object, pspec);
		return @object;
	}

	public static GObjectHandle Ref(this GObjectHandle @object)
	{
		return GObjectExterns.g_object_ref(@object);
	}

	public static GObjectHandle RefSink(this GObjectHandle @object)
	{
		return GObjectExterns.g_object_ref_sink(@object);
	}

	public static GObjectHandle RemoveToggleRef(this GObjectHandle @object, GToggleNotify notify, IntPtr data)
	{
		GObjectExterns.g_object_remove_toggle_ref(@object, notify, data);
		return @object;
	}

	public static GObjectHandle RemoveWeakPointer(this GObjectHandle @object, ref IntPtr weak_pointer_location)
	{
		GObjectExterns.g_object_remove_weak_pointer(@object, ref weak_pointer_location);
		return @object;
	}

	public static bool ReplaceData(this GObjectHandle @object, string key, IntPtr oldval, IntPtr newval, GDestroyNotify destroy, out GDestroyNotify old_destroy)
	{
		return GObjectExterns.g_object_replace_data(@object, key, oldval, newval, destroy, out old_destroy);
	}

	public static bool ReplaceQdata(this GObjectHandle @object, GQuark quark, IntPtr oldval, IntPtr newval, GDestroyNotify destroy, out GDestroyNotify old_destroy)
	{
		return GObjectExterns.g_object_replace_qdata(@object, quark, oldval, newval, destroy, out old_destroy);
	}

	public static GObjectHandle RunDispose(this GObjectHandle @object)
	{
		GObjectExterns.g_object_run_dispose(@object);
		return @object;
	}

	public static GObjectHandle Set(this GObjectHandle @object, string first_property_name, IntPtr @__arglist)
	{
		GObjectExterns.g_object_set(@object, first_property_name, @__arglist);
		return @object;
	}

	public static GObjectHandle SetData(this GObjectHandle @object, string key, IntPtr data)
	{
		GObjectExterns.g_object_set_data(@object, key, data);
		return @object;
	}

	public static GObjectHandle SetDataFull(this GObjectHandle @object, string key, IntPtr data, GDestroyNotify destroy)
	{
		GObjectExterns.g_object_set_data_full(@object, key, data, destroy);
		return @object;
	}

	public static GObjectHandle SetProperty(this GObjectHandle @object, string property_name, GValueHandle value)
	{
		GObjectExterns.g_object_set_property(@object, property_name, value);
		return @object;
	}

	public static GObjectHandle SetQdata(this GObjectHandle @object, GQuark quark, IntPtr data)
	{
		GObjectExterns.g_object_set_qdata(@object, quark, data);
		return @object;
	}

	public static GObjectHandle SetQdataFull(this GObjectHandle @object, GQuark quark, IntPtr data, GDestroyNotify destroy)
	{
		GObjectExterns.g_object_set_qdata_full(@object, quark, data, destroy);
		return @object;
	}

	public static GObjectHandle SetValist(this GObjectHandle @object, string first_property_name, IntPtr var_args)
	{
		GObjectExterns.g_object_set_valist(@object, first_property_name, var_args);
		return @object;
	}

	public static GObjectHandle Setv(this GObjectHandle @object, uint n_properties, string[] names, GValue[] values)
	{
		GObjectExterns.g_object_setv(@object, n_properties, names, values);
		return @object;
	}

	public static IntPtr StealData(this GObjectHandle @object, string key)
	{
		return GObjectExterns.g_object_steal_data(@object, key);
	}

	public static IntPtr StealQdata(this GObjectHandle @object, GQuark quark)
	{
		return GObjectExterns.g_object_steal_qdata(@object, quark);
	}

	public static GObjectHandle TakeRef(this GObjectHandle @object)
	{
		return GObjectExterns.g_object_take_ref(@object);
	}

	public static GObjectHandle ThawNotify(this GObjectHandle @object)
	{
		GObjectExterns.g_object_thaw_notify(@object);
		return @object;
	}

	public static GObjectHandle Unref(this GObjectHandle @object)
	{
		GObjectExterns.g_object_unref(@object);
		return @object;
	}

	public static GObjectHandle WatchClosure(this GObjectHandle @object, GClosureHandle closure)
	{
		GObjectExterns.g_object_watch_closure(@object, closure);
		return @object;
	}

	public static GObjectHandle WeakRef(this GObjectHandle @object, GWeakNotify notify, IntPtr data)
	{
		GObjectExterns.g_object_weak_ref(@object, notify, data);
		return @object;
	}

	public static GObjectHandle WeakUnref(this GObjectHandle @object, GWeakNotify notify, IntPtr data)
	{
		GObjectExterns.g_object_weak_unref(@object, notify, data);
		return @object;
	}

	public static GObjectHandle GSignalStopEmissionByName(this GObjectHandle instance, string detailed_signal)
	{
		GObjectExterns.g_signal_stop_emission_by_name(instance, detailed_signal);
		return instance;
	}

	public static ulong GSignalHandlerFind(this GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectExterns.g_signal_handler_find(instance, mask, signal_id, detail, closure, func, data);
	}

	public static uint GSignalHandlersUnblockMatched(this GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectExterns.g_signal_handlers_unblock_matched(instance, mask, signal_id, detail, closure, func, data);
	}

	public static GObjectHandle GSignalEmitByName(this GObjectHandle instance, string detailed_signal, IntPtr @__arglist)
	{
		GObjectExterns.g_signal_emit_by_name(instance, detailed_signal, @__arglist);
		return instance;
	}

	public static GObjectHandle GSignalHandlersDestroy(this GObjectHandle instance)
	{
		GObjectExterns.g_signal_handlers_destroy(instance);
		return instance;
	}

	public static bool GSignalHasHandlerPending(this GObjectHandle instance, uint signal_id, GQuark detail, bool may_be_blocked)
	{
		return GObjectExterns.g_signal_has_handler_pending(instance, signal_id, detail, may_be_blocked);
	}

	public static ulong GSignalConnectClosureById(this GObjectHandle instance, uint signal_id, GQuark detail, GClosureHandle closure, bool after)
	{
		return GObjectExterns.g_signal_connect_closure_by_id(instance, signal_id, detail, closure, after);
	}

	public static GObjectHandle GSignalEmit(this GObjectHandle instance, uint signal_id, GQuark detail, IntPtr @__arglist)
	{
		GObjectExterns.g_signal_emit(instance, signal_id, detail, @__arglist);
		return instance;
	}

	public static uint GSignalHandlersDisconnectMatched(this GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectExterns.g_signal_handlers_disconnect_matched(instance, mask, signal_id, detail, closure, func, data);
	}

	public static GObjectHandle GSignalHandlerUnblock(this GObjectHandle instance, ulong handler_id)
	{
		GObjectExterns.g_signal_handler_unblock(instance, handler_id);
		return instance;
	}

	public static bool GSignalHandlerIsConnected(this GObjectHandle instance, ulong handler_id)
	{
		return GObjectExterns.g_signal_handler_is_connected(instance, handler_id);
	}

	public static ulong GSignalConnectData(this GObjectHandle instance, string detailed_signal, IntPtr c_handler, IntPtr data, GClosureNotify destroy_data, GConnectFlags connect_flags)
	{
		return GObjectExterns.g_signal_connect_data(instance, detailed_signal, c_handler, data, destroy_data, connect_flags);
	}

	public static GSignalInvocationHintHandle GSignalGetInvocationHint(this GObjectHandle instance)
	{
		return GObjectExterns.g_signal_get_invocation_hint(instance);
	}

	public static GObjectHandle GSignalHandlerBlock(this GObjectHandle instance, ulong handler_id)
	{
		GObjectExterns.g_signal_handler_block(instance, handler_id);
		return instance;
	}

	public static GObjectHandle GSignalHandlerDisconnect(this GObjectHandle instance, ulong handler_id)
	{
		GObjectExterns.g_signal_handler_disconnect(instance, handler_id);
		return instance;
	}

	public static uint GSignalHandlersBlockMatched(this GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectExterns.g_signal_handlers_block_matched(instance, mask, signal_id, detail, closure, func, data);
	}

	public static ulong GSignalConnectClosure(this GObjectHandle instance, string detailed_signal, GClosureHandle closure, bool after)
	{
		return GObjectExterns.g_signal_connect_closure(instance, detailed_signal, closure, after);
	}

	public static GObjectHandle GSignalStopEmission(this GObjectHandle instance, uint signal_id, GQuark detail)
	{
		GObjectExterns.g_signal_stop_emission(instance, signal_id, detail);
		return instance;
	}

	public static GObjectHandle Signal_Notify(this GObjectHandle instance, GObjectDelegates.Notify handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "notify", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GObjectDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GObjectHandle>))] GObjectHandle self, GParamSpecHandle pspec, IntPtr user_data);
}

internal class GObjectExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_object_new(GType object_type, string first_property_name, IntPtr @__arglist);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_object_new_valist(GType object_type, string first_property_name, IntPtr var_args);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_object_new_with_properties(GType object_type, uint n_properties, string[] names, GValue[] values);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_object_newv(GType object_type, uint n_parameters, GParameter[] parameters);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_add_toggle_ref(GObjectHandle @object, GToggleNotify notify, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_add_weak_pointer(GObjectHandle @object, ref IntPtr weak_pointer_location);

	[DllImport(Libraries.GObject)]
	internal static extern GBindingHandle g_object_bind_property(GObjectHandle source, string source_property, GObjectHandle target, string target_property, GBindingFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern GBindingHandle g_object_bind_property_full(GObjectHandle source, string source_property, GObjectHandle target, string target_property, GBindingFlags flags, GBindingTransformFunc transform_to, GBindingTransformFunc transform_from, IntPtr user_data, GDestroyNotify notify);

	[DllImport(Libraries.GObject)]
	internal static extern GBindingHandle g_object_bind_property_with_closures(GObjectHandle source, string source_property, GObjectHandle target, string target_property, GBindingFlags flags, GClosureHandle transform_to, GClosureHandle transform_from);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_object_connect(GObjectHandle @object, string signal_spec, IntPtr @__arglist);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_disconnect(GObjectHandle @object, string signal_spec, IntPtr @__arglist);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_object_dup_data(GObjectHandle @object, string key, GDuplicateFunc dup_func, IntPtr user_data);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_object_dup_qdata(GObjectHandle @object, GQuark quark, GDuplicateFunc dup_func, IntPtr user_data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_force_floating(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_freeze_notify(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_get(GObjectHandle @object, string first_property_name, IntPtr @__arglist);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_object_get_data(GObjectHandle @object, string key);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_get_property(GObjectHandle @object, string property_name, out GValue value);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_object_get_qdata(GObjectHandle @object, GQuark quark);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_get_valist(GObjectHandle @object, string first_property_name, out IntPtr var_args);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_getv(GObjectHandle @object, uint n_properties, string[] names, GValue[] values);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_object_is_floating(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_notify(GObjectHandle @object, string property_name);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_notify_by_pspec(GObjectHandle @object, GParamSpecHandle pspec);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_object_ref(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_object_ref_sink(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_remove_toggle_ref(GObjectHandle @object, GToggleNotify notify, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_remove_weak_pointer(GObjectHandle @object, ref IntPtr weak_pointer_location);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_object_replace_data(GObjectHandle @object, string key, IntPtr oldval, IntPtr newval, GDestroyNotify destroy, out GDestroyNotify old_destroy);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_object_replace_qdata(GObjectHandle @object, GQuark quark, IntPtr oldval, IntPtr newval, GDestroyNotify destroy, out GDestroyNotify old_destroy);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_run_dispose(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_set(GObjectHandle @object, string first_property_name, IntPtr @__arglist);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_set_data(GObjectHandle @object, string key, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_set_data_full(GObjectHandle @object, string key, IntPtr data, GDestroyNotify destroy);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_set_property(GObjectHandle @object, string property_name, GValueHandle value);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_set_qdata(GObjectHandle @object, GQuark quark, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_set_qdata_full(GObjectHandle @object, GQuark quark, IntPtr data, GDestroyNotify destroy);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_set_valist(GObjectHandle @object, string first_property_name, IntPtr var_args);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_setv(GObjectHandle @object, uint n_properties, string[] names, GValue[] values);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_object_steal_data(GObjectHandle @object, string key);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_object_steal_qdata(GObjectHandle @object, GQuark quark);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_object_take_ref(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_thaw_notify(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_unref(GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_watch_closure(GObjectHandle @object, GClosureHandle closure);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_weak_ref(GObjectHandle @object, GWeakNotify notify, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_weak_unref(GObjectHandle @object, GWeakNotify notify, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_stop_emission_by_name(GObjectHandle instance, string detailed_signal);

	[DllImport(Libraries.GObject)]
	internal static extern ulong g_signal_handler_find(GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern uint g_signal_handlers_unblock_matched(GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_emit_by_name(GObjectHandle instance, string detailed_signal, IntPtr @__arglist);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_handlers_destroy(GObjectHandle instance);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_signal_has_handler_pending(GObjectHandle instance, uint signal_id, GQuark detail, bool may_be_blocked);

	[DllImport(Libraries.GObject)]
	internal static extern ulong g_signal_connect_closure_by_id(GObjectHandle instance, uint signal_id, GQuark detail, GClosureHandle closure, bool after);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_emit(GObjectHandle instance, uint signal_id, GQuark detail, IntPtr @__arglist);

	[DllImport(Libraries.GObject)]
	internal static extern uint g_signal_handlers_disconnect_matched(GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_handler_unblock(GObjectHandle instance, ulong handler_id);

	[DllImport(Libraries.GObject)]
	internal static extern bool g_signal_handler_is_connected(GObjectHandle instance, ulong handler_id);

	[DllImport(Libraries.GObject)]
	internal static extern ulong g_signal_connect_data(GObjectHandle instance, string detailed_signal, IntPtr c_handler, IntPtr data, GClosureNotify destroy_data, GConnectFlags connect_flags);

	[DllImport(Libraries.GObject)]
	internal static extern GSignalInvocationHintHandle g_signal_get_invocation_hint(GObjectHandle instance);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_handler_block(GObjectHandle instance, ulong handler_id);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_handler_disconnect(GObjectHandle instance, ulong handler_id);

	[DllImport(Libraries.GObject)]
	internal static extern uint g_signal_handlers_block_matched(GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern ulong g_signal_connect_closure(GObjectHandle instance, string detailed_signal, GClosureHandle closure, bool after);

	[DllImport(Libraries.GObject)]
	internal static extern void g_signal_stop_emission(GObjectHandle instance, uint signal_id, GQuark detail);

	[DllImport(Libraries.GObject)]
	internal static extern int g_object_compat_control(int what, IntPtr data);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle g_object_interface_find_property(GTypeInterfaceHandle g_iface, string property_name);

	[DllImport(Libraries.GObject)]
	internal static extern void g_object_interface_install_property(GTypeInterfaceHandle g_iface, GParamSpecHandle pspec);

	[DllImport(Libraries.GObject)]
	internal static extern GParamSpecHandle[] g_object_interface_list_properties(GTypeInterfaceHandle g_iface, out uint n_properties_p);

}
