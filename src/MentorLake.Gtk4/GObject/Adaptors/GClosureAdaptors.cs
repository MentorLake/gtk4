using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GClosureAdaptors
{
	public static GClosureHandle Ref(this GClosureHandle closure)
	{
		return GClosureExterns.g_closure_ref(closure);
	}

	public static GClosureHandle Sink(this GClosureHandle closure)
	{
		GClosureExterns.g_closure_sink(closure);
		return closure;
	}

	public static GClosureHandle Unref(this GClosureHandle closure)
	{
		GClosureExterns.g_closure_unref(closure);
		return closure;
	}

	public static GClosureHandle AddFinalizeNotifier(this GClosureHandle closure, IntPtr notify_data, GClosureNotify notify_func)
	{
		GClosureExterns.g_closure_add_finalize_notifier(closure, notify_data, notify_func);
		return closure;
	}

	public static GClosureHandle RemoveFinalizeNotifier(this GClosureHandle closure, IntPtr notify_data, GClosureNotify notify_func)
	{
		GClosureExterns.g_closure_remove_finalize_notifier(closure, notify_data, notify_func);
		return closure;
	}

	public static GClosureHandle AddInvalidateNotifier(this GClosureHandle closure, IntPtr notify_data, GClosureNotify notify_func)
	{
		GClosureExterns.g_closure_add_invalidate_notifier(closure, notify_data, notify_func);
		return closure;
	}

	public static GClosureHandle RemoveInvalidateNotifier(this GClosureHandle closure, IntPtr notify_data, GClosureNotify notify_func)
	{
		GClosureExterns.g_closure_remove_invalidate_notifier(closure, notify_data, notify_func);
		return closure;
	}

	public static GClosureHandle AddMarshalGuards(this GClosureHandle closure, IntPtr pre_marshal_data, GClosureNotify pre_marshal_notify, IntPtr post_marshal_data, GClosureNotify post_marshal_notify)
	{
		GClosureExterns.g_closure_add_marshal_guards(closure, pre_marshal_data, pre_marshal_notify, post_marshal_data, post_marshal_notify);
		return closure;
	}

	public static GClosureHandle SetMarshal(this GClosureHandle closure, GClosureMarshal marshal)
	{
		GClosureExterns.g_closure_set_marshal(closure, marshal);
		return closure;
	}

	public static GClosureHandle SetMetaMarshal(this GClosureHandle closure, IntPtr marshal_data, GClosureMarshal meta_marshal)
	{
		GClosureExterns.g_closure_set_meta_marshal(closure, marshal_data, meta_marshal);
		return closure;
	}

	public static GClosureHandle Invalidate(this GClosureHandle closure)
	{
		GClosureExterns.g_closure_invalidate(closure);
		return closure;
	}

	public static GClosureHandle Invoke(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint)
	{
		GClosureExterns.g_closure_invoke(closure, return_value, n_param_values, param_values, invocation_hint);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalGeneric(this GClosureHandle closure, GValueHandle return_gvalue, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_generic(closure, return_gvalue, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalGenericVa(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args_list, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_generic_va(closure, return_value, instance, args_list, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidVoid(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__VOID(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidVoiDv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__VOIDv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidBoolean(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__BOOLEAN(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidBooleaNv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__BOOLEANv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidChar(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__CHAR(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidChaRv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__CHARv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidUchar(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__UCHAR(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidUchaRv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__UCHARv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidInt(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__INT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidInTv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__INTv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidUint(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__UINT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidUinTv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__UINTv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidLong(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__LONG(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidLonGv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__LONGv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidUlong(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__ULONG(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidUlonGv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__ULONGv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidEnum(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__ENUM(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidEnuMv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__ENUMv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidFlags(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__FLAGS(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidFlagSv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__FLAGSv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidFloat(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__FLOAT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidFloaTv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__FLOATv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidDouble(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__DOUBLE(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidDoublEv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__DOUBLEv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidString(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__STRING(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidStrinGv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__STRINGv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidParam(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__PARAM(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidParaMv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__PARAMv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidBoxed(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__BOXED(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidBoxeDv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__BOXEDv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidPointer(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidPointeRv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__POINTERv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidObject(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__OBJECT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidObjecTv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__OBJECTv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidVariant(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__VARIANT(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidVarianTv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__VARIANTv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidUintPointer(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_VOID__UINT_POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalVoidUintPointeRv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_VOID__UINT_POINTERv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalBooleanFlags(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_BOOLEAN__FLAGS(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalBooleanFlagSv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_BOOLEAN__FLAGSv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalStringObjectPointer(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_STRING__OBJECT_POINTER(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalStringObjectPointeRv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_STRING__OBJECT_POINTERv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalBooleanBoxedBoxed(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data)
	{
		GClosureExterns.g_cclosure_marshal_BOOLEAN__BOXED_BOXED(closure, return_value, n_param_values, param_values, invocation_hint, marshal_data);
		return closure;
	}

	public static GClosureHandle GCclosureMarshalBooleanBoxedBoxeDv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types)
	{
		GClosureExterns.g_cclosure_marshal_BOOLEAN__BOXED_BOXEDv(closure, return_value, instance, args, marshal_data, n_params, param_types);
		return closure;
	}

	public static GClosureHandle GCclosureNewSwap(GCallback callback_func, IntPtr user_data, GClosureNotify destroy_data)
	{
		return GClosureExterns.g_cclosure_new_swap(callback_func, user_data, destroy_data);
	}

	public static GClosureHandle GSignalTypeCclosureNew(GType itype, uint struct_offset)
	{
		return GClosureExterns.g_signal_type_cclosure_new(itype, struct_offset);
	}

	public static GClosureHandle NewSimple(uint sizeof_closure, IntPtr data)
	{
		return GClosureExterns.g_closure_new_simple(sizeof_closure, data);
	}

	public static GClosureHandle GCclosureNewObject(GCallback callback_func, GObjectHandle @object)
	{
		return GClosureExterns.g_cclosure_new_object(callback_func, @object);
	}

	public static GClosureHandle GCclosureNewObjectSwap(GCallback callback_func, GObjectHandle @object)
	{
		return GClosureExterns.g_cclosure_new_object_swap(callback_func, @object);
	}

	public static GClosureHandle NewObject(uint sizeof_closure, GObjectHandle @object)
	{
		return GClosureExterns.g_closure_new_object(sizeof_closure, @object);
	}
}
