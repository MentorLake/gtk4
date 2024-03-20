using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GObjectAdaptors
{
	public static IntPtr GTypeInterfacePeek(this GObjectHandle instance_class, GType iface_type)
	{
		return GObjectExterns.g_type_interface_peek(instance_class, iface_type);
	}

	public static GObjectHandle GSignalEmitValist(this GObjectHandle instance, uint signal_id, GQuark detail, IntPtr @__argList)
	{
		GObjectExterns.g_signal_emit_valist(instance, signal_id, detail, @__argList);
		return instance;
	}

	public static GObjectHandle GSignalEmit(this GObjectHandle instance, uint signal_id, GQuark detail, IntPtr @__argList)
	{
		GObjectExterns.g_signal_emit(instance, signal_id, detail, @__argList);
		return instance;
	}

	public static GObjectHandle GSignalEmitByName(this GObjectHandle instance, string detailed_signal, IntPtr @__argList)
	{
		GObjectExterns.g_signal_emit_by_name(instance, detailed_signal, @__argList);
		return instance;
	}

	public static GSignalInvocationHintHandle GSignalGetInvocationHint(this GObjectHandle instance)
	{
		return GObjectExterns.g_signal_get_invocation_hint(instance);
	}

	public static GObjectHandle GSignalStopEmission(this GObjectHandle instance, uint signal_id, GQuark detail)
	{
		GObjectExterns.g_signal_stop_emission(instance, signal_id, detail);
		return instance;
	}

	public static GObjectHandle GSignalStopEmissionByName(this GObjectHandle instance, string detailed_signal)
	{
		GObjectExterns.g_signal_stop_emission_by_name(instance, detailed_signal);
		return instance;
	}

	public static int GSignalHasHandlerPending(this GObjectHandle instance, uint signal_id, GQuark detail, int may_be_blocked)
	{
		return GObjectExterns.g_signal_has_handler_pending(instance, signal_id, detail, may_be_blocked);
	}

	public static nuint GSignalConnectClosureById(this GObjectHandle instance, uint signal_id, GQuark detail, GClosureHandle closure, int after)
	{
		return GObjectExterns.g_signal_connect_closure_by_id(instance, signal_id, detail, closure, after);
	}

	public static nuint GSignalConnectClosure(this GObjectHandle instance, string detailed_signal, GClosureHandle closure, int after)
	{
		return GObjectExterns.g_signal_connect_closure(instance, detailed_signal, closure, after);
	}

	public static nuint GSignalConnectData(this GObjectHandle instance, string detailed_signal, GCallback c_handler, IntPtr data, GClosureNotify destroy_data, GConnectFlags connect_flags)
	{
		return GObjectExterns.g_signal_connect_data(instance, detailed_signal, c_handler, data, destroy_data, connect_flags);
	}

	public static T GSignalConnect<T>(this T instance, string detailed_signal, GCallback c_handler) where T : GObjectHandle
	{
		GObjectExterns.g_signal_connect_data(instance, detailed_signal, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}

	public static GObjectHandle GSignalHandlerBlock(this GObjectHandle instance, nuint handler_id)
	{
		GObjectExterns.g_signal_handler_block(instance, handler_id);
		return instance;
	}

	public static GObjectHandle GSignalHandlerUnblock(this GObjectHandle instance, nuint handler_id)
	{
		GObjectExterns.g_signal_handler_unblock(instance, handler_id);
		return instance;
	}

	public static GObjectHandle GSignalHandlerDisconnect(this GObjectHandle instance, nuint handler_id)
	{
		GObjectExterns.g_signal_handler_disconnect(instance, handler_id);
		return instance;
	}

	public static int GSignalHandlerIsConnected(this GObjectHandle instance, nuint handler_id)
	{
		return GObjectExterns.g_signal_handler_is_connected(instance, handler_id);
	}

	public static nuint GSignalHandlerFind(this GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectExterns.g_signal_handler_find(instance, mask, signal_id, detail, closure, func, data);
	}

	public static uint GSignalHandlersBlockMatched(this GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectExterns.g_signal_handlers_block_matched(instance, mask, signal_id, detail, closure, func, data);
	}

	public static uint GSignalHandlersUnblockMatched(this GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectExterns.g_signal_handlers_unblock_matched(instance, mask, signal_id, detail, closure, func, data);
	}

	public static uint GSignalHandlersDisconnectMatched(this GObjectHandle instance, GSignalMatchType mask, uint signal_id, GQuark detail, GClosureHandle closure, IntPtr func, IntPtr data)
	{
		return GObjectExterns.g_signal_handlers_disconnect_matched(instance, mask, signal_id, detail, closure, func, data);
	}

	public static GObjectHandle GSignalChainFromOverriddenHandler(this GObjectHandle instance, IntPtr @__argList)
	{
		GObjectExterns.g_signal_chain_from_overridden_handler(instance, @__argList);
		return instance;
	}

	public static GObjectHandle GSignalHandlersDestroy(this GObjectHandle instance)
	{
		GObjectExterns.g_signal_handlers_destroy(instance);
		return instance;
	}

	public static GObjectHandle Setv(this GObjectHandle @object, uint n_properties, string[] names, GValue[] values)
	{
		GObjectExterns.g_object_setv(@object, n_properties, names, values);
		return @object;
	}

	public static GObjectHandle SetValist(this GObjectHandle @object, string first_property_name, IntPtr @__argList)
	{
		GObjectExterns.g_object_set_valist(@object, first_property_name, @__argList);
		return @object;
	}

	public static GObjectHandle Getv(this GObjectHandle @object, uint n_properties, string[] names, GValue[] values)
	{
		GObjectExterns.g_object_getv(@object, n_properties, names, values);
		return @object;
	}

	public static GObjectHandle GetValist(this GObjectHandle @object, string first_property_name, IntPtr @__argList)
	{
		GObjectExterns.g_object_get_valist(@object, first_property_name, @__argList);
		return @object;
	}

	public static GObjectHandle SetProperty(this GObjectHandle @object, string property_name, GValueHandle value)
	{
		GObjectExterns.g_object_set_property(@object, property_name, value);
		return @object;
	}

	public static GObjectHandle GetProperty(this GObjectHandle @object, string property_name, GValueHandle value)
	{
		GObjectExterns.g_object_get_property(@object, property_name, value);
		return @object;
	}

	public static GObjectHandle FreezeNotify(this GObjectHandle @object)
	{
		GObjectExterns.g_object_freeze_notify(@object);
		return @object;
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

	public static GObjectHandle ThawNotify(this GObjectHandle @object)
	{
		GObjectExterns.g_object_thaw_notify(@object);
		return @object;
	}

	public static int IsFloating(this GObjectHandle @object)
	{
		return GObjectExterns.g_object_is_floating(@object);
	}

	public static IntPtr RefSink(this GObjectHandle @object)
	{
		return GObjectExterns.g_object_ref_sink(@object);
	}

	public static IntPtr TakeRef(this GObjectHandle @object)
	{
		return GObjectExterns.g_object_take_ref(@object);
	}

	public static IntPtr Ref(this GObjectHandle @object)
	{
		return GObjectExterns.g_object_ref(@object);
	}

	public static GObjectHandle Unref(this GObjectHandle @object)
	{
		GObjectExterns.g_object_unref(@object);
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

	public static GObjectHandle AddWeakPointer(this GObjectHandle @object, IntPtr weak_pointer_location)
	{
		GObjectExterns.g_object_add_weak_pointer(@object, weak_pointer_location);
		return @object;
	}

	public static GObjectHandle RemoveWeakPointer(this GObjectHandle @object, IntPtr weak_pointer_location)
	{
		GObjectExterns.g_object_remove_weak_pointer(@object, weak_pointer_location);
		return @object;
	}

	public static GObjectHandle AddToggleRef(this GObjectHandle @object, GToggleNotify notify, IntPtr data)
	{
		GObjectExterns.g_object_add_toggle_ref(@object, notify, data);
		return @object;
	}

	public static GObjectHandle RemoveToggleRef(this GObjectHandle @object, GToggleNotify notify, IntPtr data)
	{
		GObjectExterns.g_object_remove_toggle_ref(@object, notify, data);
		return @object;
	}

	public static IntPtr GetQdata(this GObjectHandle @object, GQuark quark)
	{
		return GObjectExterns.g_object_get_qdata(@object, quark);
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

	public static IntPtr StealQdata(this GObjectHandle @object, GQuark quark)
	{
		return GObjectExterns.g_object_steal_qdata(@object, quark);
	}

	public static IntPtr DupQdata(this GObjectHandle @object, GQuark quark, GDuplicateFunc dup_func, IntPtr user_data)
	{
		return GObjectExterns.g_object_dup_qdata(@object, quark, dup_func, user_data);
	}

	public static int ReplaceQdata(this GObjectHandle @object, GQuark quark, IntPtr oldval, IntPtr newval, GDestroyNotify destroy, out GDestroyNotify old_destroy)
	{
		return GObjectExterns.g_object_replace_qdata(@object, quark, oldval, newval, destroy, out old_destroy);
	}

	public static IntPtr GetData(this GObjectHandle @object, string key)
	{
		return GObjectExterns.g_object_get_data(@object, key);
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

	public static IntPtr StealData(this GObjectHandle @object, string key)
	{
		return GObjectExterns.g_object_steal_data(@object, key);
	}

	public static IntPtr DupData(this GObjectHandle @object, string key, GDuplicateFunc dup_func, IntPtr user_data)
	{
		return GObjectExterns.g_object_dup_data(@object, key, dup_func, user_data);
	}

	public static int ReplaceData(this GObjectHandle @object, string key, IntPtr oldval, IntPtr newval, GDestroyNotify destroy, out GDestroyNotify old_destroy)
	{
		return GObjectExterns.g_object_replace_data(@object, key, oldval, newval, destroy, out old_destroy);
	}

	public static GObjectHandle WatchClosure(this GObjectHandle @object, GClosureHandle closure)
	{
		GObjectExterns.g_object_watch_closure(@object, closure);
		return @object;
	}

	public static nuint GSignalConnectObject(this GObjectHandle instance, string detailed_signal, GCallback c_handler, IntPtr gobject, GConnectFlags connect_flags)
	{
		return GObjectExterns.g_signal_connect_object(instance, detailed_signal, c_handler, gobject, connect_flags);
	}

	public static GObjectHandle ForceFloating(this GObjectHandle @object)
	{
		GObjectExterns.g_object_force_floating(@object);
		return @object;
	}

	public static GObjectHandle RunDispose(this GObjectHandle @object)
	{
		GObjectExterns.g_object_run_dispose(@object);
		return @object;
	}

	public static GObjectHandle NewValist(GType object_type, string first_property_name, IntPtr @__arglist)
	{
		return GObjectExterns.g_object_new_valist(object_type, first_property_name, @__arglist);
	}
}
