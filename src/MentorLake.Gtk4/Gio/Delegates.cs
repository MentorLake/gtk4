using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gio;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string[] GDBusSubtreeEnumerateFunc(GDBusConnectionHandle connection, string sender, string object_path, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GSocketSourceFunc(GSocketHandle socket, GIOCondition condition, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GDBusInterfaceInfoHandle[] GDBusSubtreeIntrospectFunc(GDBusConnectionHandle connection, string sender, string object_path, string node, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GFileReadMoreCallback(string file_contents, nint file_size, IntPtr callback_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GAsyncReadyCallback(GObjectHandle source_object, GAsyncResultHandle res, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBusNameLostCallback(GDBusConnectionHandle connection, string name, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GDBusInterfaceSetPropertyFunc(GDBusConnectionHandle connection, string sender, string object_path, string interface_name, string property_name, GVariantHandle value, out GErrorHandle error, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GIOSchedulerJobFunc(GIOSchedulerJobHandle job, GCancellableHandle cancellable, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GFileMeasureProgressCallback(int reporting, nuint current_size, nuint num_dirs, nuint num_files, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GFileProgressCallback(nint current_num_bytes, nint total_num_bytes, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GVariantHandle GDBusInterfaceGetPropertyFunc(GDBusConnectionHandle connection, string sender, string object_path, string interface_name, string property_name, out GErrorHandle error, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBusNameAcquiredCallback(GDBusConnectionHandle connection, string name, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GSimpleAsyncThreadFunc(GSimpleAsyncResultHandle res, GObjectHandle @object, GCancellableHandle cancellable);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBusNameAppearedCallback(GDBusConnectionHandle connection, string name, string name_owner, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GCancellableSourceFunc(GCancellableHandle cancellable, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GPollableSourceFunc(GObjectHandle pollable_stream, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GDBusMessageHandle GDBusMessageFilterFunction(GDBusConnectionHandle connection, GDBusMessageHandle message, int incoming, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBusAcquiredCallback(GDBusConnectionHandle connection, string name, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GDBusSignalCallback(GDBusConnectionHandle connection, string sender_name, string object_path, string interface_name, string signal_name, GVariantHandle parameters, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GSettingsGetMapping(GVariantHandle value, out IntPtr result, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GType GDBusProxyTypeFunc(GDBusObjectManagerClientHandle manager, string object_path, string interface_name, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GFileHandle GVfsFileLookupFunc(GVfsHandle vfs, string identifier, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBusNameVanishedCallback(GDBusConnectionHandle connection, string name, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GDBusInterfaceVTableHandle GDBusSubtreeDispatchFunc(GDBusConnectionHandle connection, string sender, string object_path, string interface_name, string node, out IntPtr out_user_data, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GDBusInterfaceMethodCallFunc(GDBusConnectionHandle connection, string sender, string object_path, string interface_name, string method_name, GVariantHandle parameters, GDBusMethodInvocationHandle invocation, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate IntPtr GReallocFunc(IntPtr data, nuint size);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GDatagramBasedSourceFunc(GDatagramBasedHandle datagram_based, GIOCondition condition, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int GSettingsBindGetMapping(GValueHandle value, GVariantHandle variant, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GVariantHandle GSettingsBindSetMapping(GValueHandle value, GVariantTypeHandle expected_type, IntPtr user_data);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GTaskThreadFunc(GTaskHandle task, IntPtr source_object, IntPtr task_data, GCancellableHandle cancellable);
