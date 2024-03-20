using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GClosureExterns
{
    [DllImport(Libraries.GObject, EntryPoint = "g_closure_ref")]
    internal static extern GClosureHandle g_closure_ref(this GClosureHandle closure);
    [DllImport(Libraries.GObject, EntryPoint = "g_closure_sink")]
    internal static extern void g_closure_sink(this GClosureHandle closure);
    [DllImport(Libraries.GObject, EntryPoint = "g_closure_unref")]
    internal static extern void g_closure_unref(this GClosureHandle closure);
    [DllImport(Libraries.GObject, EntryPoint = "g_closure_add_finalize_notifier")]
    internal static extern void g_closure_add_finalize_notifier(this GClosureHandle closure, IntPtr notify_data, GClosureNotify notify_func);
    [DllImport(Libraries.GObject, EntryPoint = "g_closure_remove_finalize_notifier")]
    internal static extern void g_closure_remove_finalize_notifier(this GClosureHandle closure, IntPtr notify_data, GClosureNotify notify_func);
    [DllImport(Libraries.GObject, EntryPoint = "g_closure_add_invalidate_notifier")]
    internal static extern void g_closure_add_invalidate_notifier(this GClosureHandle closure, IntPtr notify_data, GClosureNotify notify_func);
    [DllImport(Libraries.GObject, EntryPoint = "g_closure_remove_invalidate_notifier")]
    internal static extern void g_closure_remove_invalidate_notifier(this GClosureHandle closure, IntPtr notify_data, GClosureNotify notify_func);
    [DllImport(Libraries.GObject, EntryPoint = "g_closure_add_marshal_guards")]
    internal static extern void g_closure_add_marshal_guards(this GClosureHandle closure, IntPtr pre_marshal_data, GClosureNotify pre_marshal_notify, IntPtr post_marshal_data, GClosureNotify post_marshal_notify);
    [DllImport(Libraries.GObject, EntryPoint = "g_closure_set_marshal")]
    internal static extern void g_closure_set_marshal(this GClosureHandle closure, GClosureMarshal marshal);
    [DllImport(Libraries.GObject, EntryPoint = "g_closure_set_meta_marshal")]
    internal static extern void g_closure_set_meta_marshal(this GClosureHandle closure, IntPtr marshal_data, GClosureMarshal meta_marshal);
    [DllImport(Libraries.GObject, EntryPoint = "g_closure_invalidate")]
    internal static extern void g_closure_invalidate(this GClosureHandle closure);
    [DllImport(Libraries.GObject, EntryPoint = "g_closure_invoke")]
    internal static extern void g_closure_invoke(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_generic")]
    internal static extern void g_cclosure_marshal_generic(this GClosureHandle closure, GValueHandle return_gvalue, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_generic_va")]
    internal static extern void g_cclosure_marshal_generic_va(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args_list, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__VOID")]
    internal static extern void g_cclosure_marshal_VOID__VOID(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__VOIDv")]
    internal static extern void g_cclosure_marshal_VOID__VOIDv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__BOOLEAN")]
    internal static extern void g_cclosure_marshal_VOID__BOOLEAN(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__BOOLEANv")]
    internal static extern void g_cclosure_marshal_VOID__BOOLEANv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__CHAR")]
    internal static extern void g_cclosure_marshal_VOID__CHAR(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__CHARv")]
    internal static extern void g_cclosure_marshal_VOID__CHARv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__UCHAR")]
    internal static extern void g_cclosure_marshal_VOID__UCHAR(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__UCHARv")]
    internal static extern void g_cclosure_marshal_VOID__UCHARv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__INT")]
    internal static extern void g_cclosure_marshal_VOID__INT(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__INTv")]
    internal static extern void g_cclosure_marshal_VOID__INTv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__UINT")]
    internal static extern void g_cclosure_marshal_VOID__UINT(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__UINTv")]
    internal static extern void g_cclosure_marshal_VOID__UINTv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__LONG")]
    internal static extern void g_cclosure_marshal_VOID__LONG(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__LONGv")]
    internal static extern void g_cclosure_marshal_VOID__LONGv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__ULONG")]
    internal static extern void g_cclosure_marshal_VOID__ULONG(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__ULONGv")]
    internal static extern void g_cclosure_marshal_VOID__ULONGv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__ENUM")]
    internal static extern void g_cclosure_marshal_VOID__ENUM(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__ENUMv")]
    internal static extern void g_cclosure_marshal_VOID__ENUMv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__FLAGS")]
    internal static extern void g_cclosure_marshal_VOID__FLAGS(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__FLAGSv")]
    internal static extern void g_cclosure_marshal_VOID__FLAGSv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__FLOAT")]
    internal static extern void g_cclosure_marshal_VOID__FLOAT(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__FLOATv")]
    internal static extern void g_cclosure_marshal_VOID__FLOATv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__DOUBLE")]
    internal static extern void g_cclosure_marshal_VOID__DOUBLE(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__DOUBLEv")]
    internal static extern void g_cclosure_marshal_VOID__DOUBLEv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__STRING")]
    internal static extern void g_cclosure_marshal_VOID__STRING(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__STRINGv")]
    internal static extern void g_cclosure_marshal_VOID__STRINGv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__PARAM")]
    internal static extern void g_cclosure_marshal_VOID__PARAM(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__PARAMv")]
    internal static extern void g_cclosure_marshal_VOID__PARAMv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__BOXED")]
    internal static extern void g_cclosure_marshal_VOID__BOXED(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__BOXEDv")]
    internal static extern void g_cclosure_marshal_VOID__BOXEDv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__POINTER")]
    internal static extern void g_cclosure_marshal_VOID__POINTER(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__POINTERv")]
    internal static extern void g_cclosure_marshal_VOID__POINTERv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__OBJECT")]
    internal static extern void g_cclosure_marshal_VOID__OBJECT(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__OBJECTv")]
    internal static extern void g_cclosure_marshal_VOID__OBJECTv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__VARIANT")]
    internal static extern void g_cclosure_marshal_VOID__VARIANT(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__VARIANTv")]
    internal static extern void g_cclosure_marshal_VOID__VARIANTv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__UINT_POINTER")]
    internal static extern void g_cclosure_marshal_VOID__UINT_POINTER(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_VOID__UINT_POINTERv")]
    internal static extern void g_cclosure_marshal_VOID__UINT_POINTERv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_BOOLEAN__FLAGS")]
    internal static extern void g_cclosure_marshal_BOOLEAN__FLAGS(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_BOOLEAN__FLAGSv")]
    internal static extern void g_cclosure_marshal_BOOLEAN__FLAGSv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_STRING__OBJECT_POINTER")]
    internal static extern void g_cclosure_marshal_STRING__OBJECT_POINTER(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_STRING__OBJECT_POINTERv")]
    internal static extern void g_cclosure_marshal_STRING__OBJECT_POINTERv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_BOOLEAN__BOXED_BOXED")]
    internal static extern void g_cclosure_marshal_BOOLEAN__BOXED_BOXED(this GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);
    [DllImport(Libraries.GObject, EntryPoint = "g_cclosure_marshal_BOOLEAN__BOXED_BOXEDv")]
    internal static extern void g_cclosure_marshal_BOOLEAN__BOXED_BOXEDv(this GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);
    [DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GClosureHandle g_cclosure_new(GCallback callback_func, IntPtr user_data, GClosureNotify destroy_data);
    [DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GClosureHandle g_cclosure_new_swap(GCallback callback_func, IntPtr user_data, GClosureNotify destroy_data);
    [DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GClosureHandle g_signal_type_cclosure_new(GType itype, uint struct_offset);
    [DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GClosureHandle g_closure_new_simple(uint sizeof_closure, IntPtr data);
    [DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GClosureHandle g_cclosure_new_object(GCallback callback_func, GObjectHandle @object);
    [DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GClosureHandle g_cclosure_new_object_swap(GCallback callback_func, GObjectHandle @object);
    [DllImport(Libraries.GObject, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GClosureHandle g_closure_new_object(uint sizeof_closure, GObjectHandle @object);
}
