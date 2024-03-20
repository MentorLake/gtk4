using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GBindingTransformFunc(GBindingHandle binding, GValueHandle from_value, GValueHandle to_value, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTypePluginCompleteInterfaceInfo(GTypePluginHandle plugin, GType instance_type, GType interface_type, GInterfaceInfoHandle info);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GSignalCVaMarshaller();

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GVaClosureMarshal(GClosureHandle closure, GValueHandle return_value, IntPtr instance, object[] args, IntPtr marshal_data, int n_params, GType[] param_types);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GBoxedCopyFunc(IntPtr boxed);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GClosureMarshal(GClosureHandle closure, GValueHandle return_value, uint n_param_values, GValueHandle param_values, IntPtr invocation_hint, IntPtr marshal_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTypePluginUnuse(GTypePluginHandle plugin);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GValueTransform(GValueHandle src_value, GValueHandle dest_value);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GToggleNotify(IntPtr data, GObjectHandle @object, int is_last_ref);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GClassFinalizeFunc(IntPtr g_class, IntPtr class_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GInstanceInitFunc(GTypeInstanceHandle instance, IntPtr g_class);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GObjectGetPropertyFunc(GObjectHandle @object, uint property_id, GValueHandle value, GParamSpecHandle pspec);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBaseFinalizeFunc(IntPtr g_class);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GTypeClassCacheFunc(IntPtr cache_data, GTypeClassHandle g_class);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GSignalCMarshaller();

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTypeInterfaceCheckFunc(IntPtr check_data, IntPtr g_iface);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GSignalAccumulator(GSignalInvocationHintHandle ihint, GValueHandle return_accu, GValueHandle handler_return, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GObjectFinalizeFunc(GObjectHandle @object);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTypePluginCompleteTypeInfo(GTypePluginHandle plugin, GType g_type, GTypeInfoHandle info, GTypeValueTableHandle value_table);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTypePluginUse(GTypePluginHandle plugin);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBaseInitFunc(IntPtr g_class);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GWeakNotify(IntPtr data, GObjectHandle where_the_object_was);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GObjectSetPropertyFunc(GObjectHandle @object, uint property_id, GValueHandle value, GParamSpecHandle pspec);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GInterfaceFinalizeFunc(IntPtr g_iface, IntPtr iface_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBoxedFreeFunc(IntPtr boxed);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GCallback();

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GClassInitFunc(IntPtr g_class, IntPtr class_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GSignalEmissionHook(GSignalInvocationHintHandle ihint, uint n_param_values, GValueHandle param_values, IntPtr data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GInterfaceInitFunc(IntPtr g_iface, IntPtr iface_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GClosureNotify(IntPtr data, GClosureHandle closure);
