using System.Runtime.CompilerServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gio;

public struct GCancellablePrivate { }
public struct GProxyAddressEnumeratorPrivate { }
public struct GMemoryOutputStreamPrivate { }

public struct GVolumeMonitorClass
{
	public GObjectClass parent_class;
	public IntPtr volume_added;
	public IntPtr volume_removed;
	public IntPtr volume_changed;
	public IntPtr mount_added;
	public IntPtr mount_removed;
	public IntPtr mount_pre_unmount;
	public IntPtr mount_changed;
	public IntPtr drive_connected;
	public IntPtr drive_disconnected;
	public IntPtr drive_changed;
	public IntPtr is_supported;
	public IntPtr get_connected_drives;
	public IntPtr get_volumes;
	public IntPtr get_mounts;
	public IntPtr get_volume_for_uuid;
	public IntPtr get_mount_for_uuid;
	public IntPtr adopt_orphan_mount;
	public IntPtr drive_eject_button;
	public IntPtr drive_stop_button;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
	public IntPtr _g_reserved6;
}

public struct GNetworkAddressClass
{
	public GObjectClass parent_class;
}

public struct GDBusAnnotationInfo
{
	public int ref_count;
	public string key;
	public string value;
	public GDBusAnnotationInfoHandle[] annotations;
}

public struct GInputMessage
{
	public GSocketAddressHandle[] address;
	public GInputVectorHandle vectors;
	public uint num_vectors;
	public nuint bytes_received;
	public int flags;
	public IntPtr control_messages;
	public IntPtr num_control_messages;
}

public struct GTcpConnectionPrivate { }

public struct GTlsCertificate
{
	public GObject.GObject parent_instance;
	public GTlsCertificatePrivateHandle priv;
}

public struct GFileInfoClass { }
public struct GIOModuleClass { }
public struct GDrive { }
public struct GSimplePermission { }

public struct GResolverClass
{
	public GObjectClass parent_class;
	public IntPtr reload;
	public IntPtr lookup_by_name;
	public IntPtr lookup_by_name_async;
	public IntPtr lookup_by_name_finish;
	public IntPtr lookup_by_address;
	public IntPtr lookup_by_address_async;
	public IntPtr lookup_by_address_finish;
	public IntPtr lookup_service;
	public IntPtr lookup_service_async;
	public IntPtr lookup_service_finish;
	public IntPtr lookup_records;
	public IntPtr lookup_records_async;
	public IntPtr lookup_records_finish;
	public IntPtr lookup_by_name_with_flags_async;
	public IntPtr lookup_by_name_with_flags_finish;
	public IntPtr lookup_by_name_with_flags;
}

public struct GProxyResolverInterface
{
	public GTypeInterface g_iface;
	public IntPtr is_supported;
	public IntPtr lookup;
	public IntPtr lookup_async;
	public IntPtr lookup_finish;
}

public struct GFilterInputStream
{
	public GInputStream parent_instance;
	public GInputStreamHandle base_stream;
}

public struct GFileMonitorPrivate { }
public struct GCredentials { }
public struct GIOModule { }

public struct GTlsFileDatabaseInterface
{
	public GTypeInterface g_iface;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GSocketListenerPrivate { }

public struct GListStoreClass
{
	public GObjectClass parent_class;
}

public struct GDBusSubtreeVTable
{
	public GDBusSubtreeEnumerateFunc enumerate;
	public GDBusSubtreeIntrospectFunc introspect;
	public GDBusSubtreeDispatchFunc dispatch;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GCredentialsClass { }
public struct GSettingsSchemaSource { }
public struct GAction { }
public struct GConverterOutputStreamPrivate { }

public struct GMenuLinkIter
{
	public GObject.GObject parent_instance;
	public GMenuLinkIterPrivateHandle priv;
}

public struct GVolume { }
public struct GListModel { }
public struct GPropertyAction { }

public struct GInputStreamClass
{
	public GObjectClass parent_class;
	public IntPtr read_fn;
	public IntPtr skip;
	public IntPtr close_fn;
	public IntPtr read_async;
	public IntPtr read_finish;
	public IntPtr skip_async;
	public IntPtr skip_finish;
	public IntPtr close_async;
	public IntPtr close_finish;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

public struct GMemoryInputStreamPrivate { }
public struct GSubprocessLauncher { }
public struct GTlsBackend { }

public struct GDataInputStreamClass
{
	public GBufferedInputStreamClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

public struct GSocket
{
	public GObject.GObject parent_instance;
	public GSocketPrivateHandle priv;
}

public struct GNativeVolumeMonitor
{
	public GVolumeMonitor parent_instance;
}

public struct GDtlsConnection { }

public struct GInitableIface
{
	public GTypeInterface g_iface;
	public IntPtr init;
}

public struct GDBusSignalInfo
{
	public int ref_count;
	public string name;
	public GDBusArgInfoHandle[] args;
	public GDBusAnnotationInfoHandle[] annotations;
}

public struct GDBusObjectManagerServerPrivate { }
public struct GTlsCertificatePrivate { }

public struct GInetAddressClass
{
	public GObjectClass parent_class;
	public IntPtr to_string;
	public IntPtr to_bytes;
}

public struct GListModelInterface
{
	public GTypeInterface g_iface;
	public IntPtr get_item_type;
	public IntPtr get_n_items;
	public IntPtr get_item;
}

public struct GRemoteActionGroupInterface
{
	public GTypeInterface g_iface;
	public IntPtr activate_action_full;
	public IntPtr change_action_state_full;
}

public struct GInputStream
{
	public GObject.GObject parent_instance;
	public GInputStreamPrivateHandle priv;
}

public struct GSocketClientClass
{
	public GObjectClass parent_class;
	public IntPtr @event;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
}

public struct GFileDescriptorBased { }
public struct GZlibDecompressor { }
public struct GIOStreamAdapter { }

public struct GFilterOutputStreamClass
{
	public GOutputStreamClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
}

public struct GSocketConnectionClass
{
	public GIOStreamClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
	public IntPtr _g_reserved6;
}

public struct GDBusProxyPrivate { }

public struct GOutputStreamClass
{
	public GObjectClass parent_class;
	public IntPtr write_fn;
	public IntPtr splice;
	public IntPtr flush;
	public IntPtr close_fn;
	public IntPtr write_async;
	public IntPtr write_finish;
	public IntPtr splice_async;
	public IntPtr splice_finish;
	public IntPtr flush_async;
	public IntPtr flush_finish;
	public IntPtr close_async;
	public IntPtr close_finish;
	public IntPtr writev_fn;
	public IntPtr writev_async;
	public IntPtr writev_finish;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
	public IntPtr _g_reserved6;
	public IntPtr _g_reserved7;
	public IntPtr _g_reserved8;
}

public struct GMemoryOutputStreamClass
{
	public GOutputStreamClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

public struct GConverterOutputStreamClass
{
	public GFilterOutputStreamClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

public struct GThreadedSocketService
{
	public GSocketService parent_instance;
	public GThreadedSocketServicePrivateHandle priv;
}

public struct GDBusActionGroup { }

public struct GMenuAttributeIter
{
	public GObject.GObject parent_instance;
	public GMenuAttributeIterPrivateHandle priv;
}

public struct GDBusObjectManagerServer
{
	public GObject.GObject parent_instance;
	public GDBusObjectManagerServerPrivateHandle priv;
}

public struct GMountOperationClass
{
	public GObjectClass parent_class;
	public IntPtr ask_password;
	public IntPtr ask_question;
	public IntPtr reply;
	public IntPtr aborted;
	public IntPtr show_processes;
	public IntPtr show_unmount_progress;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
	public IntPtr _g_reserved6;
	public IntPtr _g_reserved7;
	public IntPtr _g_reserved8;
	public IntPtr _g_reserved9;
}

public struct GSimpleAsyncResult { }

public struct GDBusObjectIface
{
	public GTypeInterface parent_iface;
	public IntPtr get_object_path;
	public IntPtr get_interfaces;
	public IntPtr get_interface;
	public IntPtr interface_added;
	public IntPtr interface_removed;
}

public struct GSeekable { }

public struct GTcpWrapperConnectionClass
{
	public GTcpConnectionClass parent_class;
}

public struct GThemedIconClass { }
public struct GActionMap { }
public struct GApplicationCommandLinePrivate { }

public struct GPermission
{
	public GObject.GObject parent_instance;
	public GPermissionPrivateHandle priv;
}

public struct GMenuItem { }

public struct GTlsConnection
{
	public GIOStream parent_instance;
	public GTlsConnectionPrivateHandle priv;
}

public struct GMountOperationPrivate { }

public struct GOutputStream
{
	public GObject.GObject parent_instance;
	public GOutputStreamPrivateHandle priv;
}

public struct GTlsPassword
{
	public GObject.GObject parent_instance;
	public GTlsPasswordPrivateHandle priv;
}

public struct GFileOutputStreamPrivate { }
public struct GDebugController { }
public struct GBytesIcon { }

public struct GMenuModelClass
{
	public GObjectClass parent_class;
	public IntPtr is_mutable;
	public IntPtr get_n_items;
	public IntPtr get_item_attributes;
	public IntPtr iterate_item_attributes;
	public IntPtr get_item_attribute_value;
	public IntPtr get_item_links;
	public IntPtr iterate_item_links;
	public IntPtr get_item_link;
}

public struct GDBusProxyClass
{
	public GObjectClass parent_class;
	public IntPtr g_properties_changed;
	public IntPtr g_signal;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
		public IntPtr e8;
		public IntPtr e9;
		public IntPtr e10;
		public IntPtr e11;
		public IntPtr e12;
		public IntPtr e13;
		public IntPtr e14;
		public IntPtr e15;
		public IntPtr e16;
		public IntPtr e17;
		public IntPtr e18;
		public IntPtr e19;
		public IntPtr e20;
		public IntPtr e21;
		public IntPtr e22;
		public IntPtr e23;
		public IntPtr e24;
		public IntPtr e25;
		public IntPtr e26;
		public IntPtr e27;
		public IntPtr e28;
		public IntPtr e29;
		public IntPtr e30;
		public IntPtr e31;
	}
}

public struct GProxyAddressEnumeratorClass
{
	public GSocketAddressEnumeratorClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
	public IntPtr _g_reserved6;
	public IntPtr _g_reserved7;
}

public struct GDBusArgInfo
{
	public int ref_count;
	public string name;
	public string signature;
	public GDBusAnnotationInfoHandle[] annotations;
}

public struct GFileMonitorClass
{
	public GObjectClass parent_class;
	public IntPtr changed;
	public IntPtr cancel;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

public struct GIOModuleScope { }
public struct GThemedIcon { }
public struct GDBusMenuModel { }
public struct GBufferedInputStreamPrivate { }

public struct GApplicationClass
{
	public GObjectClass parent_class;
	public IntPtr startup;
	public IntPtr activate;
	public IntPtr open;
	public IntPtr command_line;
	public IntPtr local_command_line;
	public IntPtr before_emit;
	public IntPtr after_emit;
	public IntPtr add_platform_data;
	public IntPtr quit_mainloop;
	public IntPtr run_mainloop;
	public IntPtr shutdown;
	public IntPtr dbus_register;
	public IntPtr dbus_unregister;
	public IntPtr handle_local_options;
	public IntPtr name_lost;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
	}
}

public struct GDBusObjectManager { }
public struct GMenu { }
public struct GActionGroup { }
public struct GPollableOutputStream { }

public struct GTlsClientConnectionInterface
{
	public GTypeInterface g_iface;
	public IntPtr copy_session_state;
}

public struct GBufferedInputStreamClass
{
	public GFilterInputStreamClass parent_class;
	public IntPtr fill;
	public IntPtr fill_async;
	public IntPtr fill_finish;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

public struct GIOStreamClass
{
	public GObjectClass parent_class;
	public IntPtr get_input_stream;
	public IntPtr get_output_stream;
	public IntPtr close_fn;
	public IntPtr close_async;
	public IntPtr close_finish;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
	public IntPtr _g_reserved6;
	public IntPtr _g_reserved7;
	public IntPtr _g_reserved8;
	public IntPtr _g_reserved9;
	public IntPtr _g_reserved10;
}

public struct GDtlsServerConnection { }

public struct GLoadableIconIface
{
	public GTypeInterface g_iface;
	public IntPtr load;
	public IntPtr load_async;
	public IntPtr load_finish;
}

public struct GFileIOStreamPrivate { }

public struct GSocketAddress
{
	public GObject.GObject parent_instance;
}

public struct GSocketAddressEnumeratorClass
{
	public GObjectClass parent_class;
	public IntPtr next;
	public IntPtr next_async;
	public IntPtr next_finish;
}

public struct GFileInfo { }
public struct GSocketClientPrivate { }
public struct GConverterInputStreamPrivate { }

public struct GDBusMethodInfo
{
	public int ref_count;
	public string name;
	public GDBusArgInfoHandle[] in_args;
	public GDBusArgInfoHandle[] out_args;
	public GDBusAnnotationInfoHandle[] annotations;
}

public struct GSocketControlMessagePrivate { }
public struct GSettingsPrivate { }
public struct GTestDBus { }

public struct GConverterOutputStream
{
	public GFilterOutputStream parent_instance;
	public GConverterOutputStreamPrivateHandle priv;
}

public struct GTlsConnectionPrivate { }
public struct GFileInputStreamPrivate { }

public struct GAppLaunchContext
{
	public GObject.GObject parent_instance;
	public GAppLaunchContextPrivateHandle priv;
}

public struct GIOStream
{
	public GObject.GObject parent_instance;
	public GIOStreamPrivateHandle priv;
}

public struct GAppInfo { }

public struct GTlsPasswordClass
{
	public GObjectClass parent_class;
	public IntPtr get_value;
	public IntPtr set_value;
	public IntPtr get_default_warning;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
	}
}

public struct GConverterInputStream
{
	public GFilterInputStream parent_instance;
	public GConverterInputStreamPrivateHandle priv;
}

public struct GNetworkServicePrivate { }
public struct GUnixCredentialsMessage { }

public struct GFileOutputStreamClass
{
	public GOutputStreamClass parent_class;
	public IntPtr tell;
	public IntPtr can_seek;
	public IntPtr seek;
	public IntPtr can_truncate;
	public IntPtr truncate_fn;
	public IntPtr query_info;
	public IntPtr query_info_async;
	public IntPtr query_info_finish;
	public IntPtr get_etag;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

public struct GIOStreamPrivate { }

public struct GResolver
{
	public GObject.GObject parent_instance;
	public GResolverPrivateHandle priv;
}

public struct GSocketService
{
	public GSocketListener parent_instance;
	public GSocketServicePrivateHandle priv;
}

public struct GVolumeIface
{
	public GTypeInterface g_iface;
	public IntPtr changed;
	public IntPtr removed;
	public IntPtr get_name;
	public IntPtr get_icon;
	public IntPtr get_uuid;
	public IntPtr get_drive;
	public IntPtr get_mount;
	public IntPtr can_mount;
	public IntPtr can_eject;
	public IntPtr mount_fn;
	public IntPtr mount_finish;
	public IntPtr eject;
	public IntPtr eject_finish;
	public IntPtr get_identifier;
	public IntPtr enumerate_identifiers;
	public IntPtr should_automount;
	public IntPtr get_activation_root;
	public IntPtr eject_with_operation;
	public IntPtr eject_with_operation_finish;
	public IntPtr get_sort_key;
	public IntPtr get_symbolic_icon;
}

public struct GSocketAddressEnumerator
{
	public GObject.GObject parent_instance;
}

public struct GSocketClass
{
	public GObjectClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
	public IntPtr _g_reserved6;
	public IntPtr _g_reserved7;
	public IntPtr _g_reserved8;
	public IntPtr _g_reserved9;
	public IntPtr _g_reserved10;
}

public struct GEmblemClass { }
public struct GSettingsSchemaKey { }

public struct GVolumeMonitor
{
	public GObject.GObject parent_instance;
	public IntPtr priv;
}

public struct GTlsBackendInterface
{
	public GTypeInterface g_iface;
	public IntPtr supports_tls;
	public IntPtr get_certificate_type;
	public IntPtr get_client_connection_type;
	public IntPtr get_server_connection_type;
	public IntPtr get_file_database_type;
	public IntPtr get_default_database;
	public IntPtr supports_dtls;
	public IntPtr get_dtls_client_connection_type;
	public IntPtr get_dtls_server_connection_type;
}

public struct GInetAddressPrivate { }
public struct GBufferedOutputStreamPrivate { }

public struct GFileIOStreamClass
{
	public GIOStreamClass parent_class;
	public IntPtr tell;
	public IntPtr can_seek;
	public IntPtr seek;
	public IntPtr can_truncate;
	public IntPtr truncate_fn;
	public IntPtr query_info;
	public IntPtr query_info_async;
	public IntPtr query_info_finish;
	public IntPtr get_etag;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

public struct GAsyncInitableIface
{
	public GTypeInterface g_iface;
	public IntPtr init_async;
	public IntPtr init_finish;
}

public struct GConverterIface
{
	public GTypeInterface g_iface;
	public IntPtr convert;
	public IntPtr reset;
}

public struct GMenuLinkIterClass
{
	public GObjectClass parent_class;
	public IntPtr get_next;
}

public struct GDebugControllerDBus
{
	public GObject.GObject parent_instance;
}

public struct GDBusServer { }

public struct GVfs
{
	public GObject.GObject parent_instance;
}

public struct GAppInfoMonitor { }

public struct GStaticResource
{
	public byte[] data;
	public nuint data_len;
	public GResourceHandle resource;
	public GStaticResourceHandle next;
	public IntPtr padding;
}

public struct GSimpleProxyResolver
{
	public GObject.GObject parent_instance;
	public GSimpleProxyResolverPrivateHandle priv;
}

public struct GListStore { }
public struct GTlsDatabasePrivate { }
public struct GDBusObjectProxyPrivate { }

public struct GDBusErrorEntry
{
	public int error_code;
	public string dbus_error_name;
}

public struct GDtlsServerConnectionInterface
{
	public GTypeInterface g_iface;
}

public struct GTlsServerConnection { }
public struct GSettingsBackend { }

public struct GNetworkServiceClass
{
	public GObjectClass parent_class;
}

public struct GDataOutputStreamClass
{
	public GFilterOutputStreamClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

public struct GDBusInterfaceSkeletonPrivate { }

public struct GNativeSocketAddress
{
	public GSocketAddress parent_instance;
	public GNativeSocketAddressPrivateHandle priv;
}

public struct GMemoryMonitor { }

public struct GActionGroupInterface
{
	public GTypeInterface g_iface;
	public IntPtr has_action;
	public IntPtr list_actions;
	public IntPtr get_action_enabled;
	public IntPtr get_action_parameter_type;
	public IntPtr get_action_state_type;
	public IntPtr get_action_state_hint;
	public IntPtr get_action_state;
	public IntPtr change_action_state;
	public IntPtr activate_action;
	public IntPtr action_added;
	public IntPtr action_removed;
	public IntPtr action_enabled_changed;
	public IntPtr action_state_changed;
	public IntPtr query_action;
}

public struct GCancellable
{
	public GObject.GObject parent_instance;
	public GCancellablePrivateHandle priv;
}

public struct GProxyAddress
{
	public GInetSocketAddress parent_instance;
	public GProxyAddressPrivateHandle priv;
}

public struct GSocketConnection
{
	public GIOStream parent_instance;
	public GSocketConnectionPrivateHandle priv;
}

public struct GDBusMethodInvocation { }

public struct GFilenameCompleterClass
{
	public GObjectClass parent_class;
	public IntPtr got_completion_data;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
}

public struct GInitable { }

public struct GDBusInterfaceIface
{
	public GTypeInterface parent_iface;
	public IntPtr get_info;
	public IntPtr get_object;
	public IntPtr set_object;
	public IntPtr dup_object;
}

public struct GDBusObjectManagerClientPrivate { }

public struct GDBusObjectManagerClient
{
	public GObject.GObject parent_instance;
	public GDBusObjectManagerClientPrivateHandle priv;
}

public struct GInetSocketAddressPrivate { }
public struct GTlsClientConnection { }
public struct GSocketConnectionPrivate { }

public struct GFilterInputStreamClass
{
	public GInputStreamClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
}

public struct GDBusObjectSkeletonPrivate { }

public struct GTcpConnectionClass
{
	public GSocketConnectionClass parent_class;
}

public struct GDBusObjectManagerIface
{
	public GTypeInterface parent_iface;
	public IntPtr get_object_path;
	public IntPtr get_objects;
	public IntPtr get_object;
	public IntPtr get_interface;
	public IntPtr object_added;
	public IntPtr object_removed;
	public IntPtr interface_added;
	public IntPtr interface_removed;
}

public struct GSocketConnectable { }
public struct GSocketPrivate { }
public struct GFilenameCompleter { }

public struct GEmblemedIcon
{
	public GObject.GObject parent_instance;
	public GEmblemedIconPrivateHandle priv;
}

public struct GMenuModel
{
	public GObject.GObject parent_instance;
	public GMenuModelPrivateHandle priv;
}

public struct GTaskClass { }

public struct GVfsClass
{
	public GObjectClass parent_class;
	public IntPtr is_active;
	public IntPtr get_file_for_path;
	public IntPtr get_file_for_uri;
	public IntPtr get_supported_uri_schemes;
	public IntPtr parse_name;
	public IntPtr local_file_add_info;
	public IntPtr add_writable_namespaces;
	public IntPtr local_file_set_attributes;
	public IntPtr local_file_removed;
	public IntPtr local_file_moved;
	public IntPtr deserialize_icon;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
	public IntPtr _g_reserved6;
}

public struct GDBusInterfaceInfo
{
	public int ref_count;
	public string name;
	public GDBusMethodInfoHandle[] methods;
	public GDBusSignalInfoHandle[] signals;
	public GDBusInterfaceInfoHandle[] properties;
	public GDBusInterfaceInfoHandle[] annotations;
}

public struct GTlsConnectionClass
{
	public GIOStreamClass parent_class;
	public IntPtr accept_certificate;
	public IntPtr handshake;
	public IntPtr handshake_async;
	public IntPtr handshake_finish;
	public IntPtr get_binding_data;
	public IntPtr get_negotiated_protocol;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
	}
}

public struct GSettingsClass
{
	public GObjectClass parent_class;
	public IntPtr writable_changed;
	public IntPtr changed;
	public IntPtr writable_change_event;
	public IntPtr change_event;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
		public IntPtr e8;
		public IntPtr e9;
		public IntPtr e10;
		public IntPtr e11;
		public IntPtr e12;
		public IntPtr e13;
		public IntPtr e14;
		public IntPtr e15;
		public IntPtr e16;
		public IntPtr e17;
		public IntPtr e18;
		public IntPtr e19;
	}
}

public struct GResolverPrivate { }

public struct GInetAddressMask
{
	public GObject.GObject parent_instance;
	public GInetAddressMaskPrivateHandle priv;
}

public struct GDBusMessage { }

public struct GCharsetConverterClass
{
	public GObjectClass parent_class;
}

public struct GActionInterface
{
	public GTypeInterface g_iface;
	public IntPtr get_name;
	public IntPtr get_parameter_type;
	public IntPtr get_state_type;
	public IntPtr get_state_hint;
	public IntPtr get_enabled;
	public IntPtr get_state;
	public IntPtr change_state;
	public IntPtr activate;
}

public struct GIOExtensionPoint { }

public struct GDBusObjectManagerServerClass
{
	public GObjectClass parent_class;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GMenuLinkIterPrivate { }

public struct GDataInputStream
{
	public GBufferedInputStream parent_instance;
	public GDataInputStreamPrivateHandle priv;
}

public struct GTlsInteractionPrivate { }
public struct GDataInputStreamPrivate { }
public struct GNetworkMonitor { }

public struct GMemoryInputStreamClass
{
	public GInputStreamClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

public struct GInetAddressMaskClass
{
	public GObjectClass parent_class;
}

public struct GInputVector
{
	public IntPtr buffer;
	public nuint size;
}

public struct GSocketControlMessageClass
{
	public GObjectClass parent_class;
	public IntPtr get_size;
	public IntPtr get_level;
	public IntPtr get_type;
	public IntPtr serialize;
	public IntPtr deserialize;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

public struct GOutputStreamPrivate { }
public struct GInetAddressMaskPrivate { }

public struct GNativeSocketAddressClass
{
	public GSocketAddressClass parent_class;
}

public struct GFileIcon { }
public struct GDatagramBased { }

public struct GTlsInteraction
{
	public GObject.GObject parent_instance;
	public GTlsInteractionPrivateHandle priv;
}

public struct GSocketClient
{
	public GObject.GObject parent_instance;
	public GSocketClientPrivateHandle priv;
}

public struct GProxyAddressClass
{
	public GInetSocketAddressClass parent_class;
}

public struct GSocketAddressClass
{
	public GObjectClass parent_class;
	public IntPtr get_family;
	public IntPtr get_native_size;
	public IntPtr to_native;
}

public struct GTlsPasswordPrivate { }
public struct GDBusAuthObserver { }

public struct GAppLaunchContextClass
{
	public GObjectClass parent_class;
	public IntPtr get_display;
	public IntPtr get_startup_notify_id;
	public IntPtr launch_failed;
	public IntPtr launched;
	public IntPtr launch_started;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
}

public struct GSubprocess { }

public struct GSettings
{
	public GObject.GObject parent_instance;
	public GSettingsPrivateHandle priv;
}

public struct GDataOutputStreamPrivate { }

public struct GApplicationCommandLine
{
	public GObject.GObject parent_instance;
	public GApplicationCommandLinePrivateHandle priv;
}

public struct GFileInputStreamClass
{
	public GInputStreamClass parent_class;
	public IntPtr tell;
	public IntPtr can_seek;
	public IntPtr seek;
	public IntPtr query_info;
	public IntPtr query_info_async;
	public IntPtr query_info_finish;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

public struct GProxyResolver { }

public struct GDBusInterfaceSkeletonClass
{
	public GObjectClass parent_class;
	public IntPtr get_info;
	public IntPtr get_vtable;
	public IntPtr get_properties;
	public IntPtr flush;
	public IntPtr vfunc_padding;
	public IntPtr g_authorize_method;
	public IntPtr signal_padding;

	public struct _vfunc_padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}

	public struct _signal_padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GSeekableIface
{
	public GTypeInterface g_iface;
	public IntPtr tell;
	public IntPtr can_seek;
	public IntPtr seek;
	public IntPtr can_truncate;
	public IntPtr truncate_fn;
}

public struct GSimpleAsyncResultClass { }
public struct GSimpleAction { }

public struct GActionEntry
{
	public string name;
	public IntPtr activate;
	public string parameter_type;
	public string state;
	public IntPtr change_state;
	public _padding_e__FixedBuffer padding;

	[InlineArray(3)]
	public struct _padding_e__FixedBuffer
	{
		public nuint e0;
	}
}

public struct GFilterOutputStream
{
	public GOutputStream parent_instance;
	public GOutputStreamHandle base_stream;
}

public struct GSocketServicePrivate { }

public struct GTlsServerConnectionInterface
{
	public GTypeInterface g_iface;
}

public struct GTlsInteractionClass
{
	public GObjectClass parent_class;
	public IntPtr ask_password;
	public IntPtr ask_password_async;
	public IntPtr ask_password_finish;
	public IntPtr request_certificate;
	public IntPtr request_certificate_async;
	public IntPtr request_certificate_finish;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
		public IntPtr e8;
		public IntPtr e9;
		public IntPtr e10;
		public IntPtr e11;
		public IntPtr e12;
		public IntPtr e13;
		public IntPtr e14;
		public IntPtr e15;
		public IntPtr e16;
		public IntPtr e17;
		public IntPtr e18;
		public IntPtr e19;
		public IntPtr e20;
	}
}

public struct GIconIface
{
	public GTypeInterface g_iface;
	public IntPtr hash;
	public IntPtr equal;
	public IntPtr to_tokens;
	public IntPtr from_tokens;
	public IntPtr serialize;
}

public struct GAppLaunchContextPrivate { }

public struct GCancellableClass
{
	public GObjectClass parent_class;
	public IntPtr cancelled;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

public struct GMenuAttributeIterPrivate { }

public struct GOutputMessage
{
	public GSocketAddressHandle address;
	public GOutputVectorHandle vectors;
	public uint num_vectors;
	public uint bytes_sent;
	public GSocketControlMessageHandle[] control_messages;
	public uint num_control_messages;
}

public struct GNetworkAddressPrivate { }

public struct GDBusNodeInfo
{
	public int ref_count;
	public string path;
	public GDBusInterfaceInfoHandle[] interfaces;
	public GDBusNodeInfoHandle[] nodes;
	public GDBusAnnotationInfoHandle[] annotations;
}

public struct GApplicationPrivate { }
public struct GNativeSocketAddressPrivate { }

public struct GDBusInterfaceVTable
{
	public GDBusInterfaceMethodCallFunc method_call;
	public GDBusInterfaceGetPropertyFunc get_property;
	public GDBusInterfaceSetPropertyFunc set_property;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GFileIOStream
{
	public GIOStream parent_instance;
	public GFileIOStreamPrivateHandle priv;
}

public struct GInetSocketAddressClass
{
	public GSocketAddressClass parent_class;
}

public struct GApplicationCommandLineClass
{
	public GObjectClass parent_class;
	public IntPtr print_literal;
	public IntPtr printerr_literal;
	public IntPtr get_stdin;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
		public IntPtr e8;
		public IntPtr e9;
		public IntPtr e10;
	}
}

public struct GDBusObjectSkeletonClass
{
	public GObjectClass parent_class;
	public IntPtr authorize_method;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GDBusObjectManagerClientClass
{
	public GObjectClass parent_class;
	public IntPtr interface_proxy_signal;
	public IntPtr interface_proxy_properties_changed;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GFileEnumeratorClass
{
	public GObjectClass parent_class;
	public IntPtr next_file;
	public IntPtr close_fn;
	public IntPtr next_files_async;
	public IntPtr next_files_finish;
	public IntPtr close_async;
	public IntPtr close_finish;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
	public IntPtr _g_reserved6;
	public IntPtr _g_reserved7;
}

public struct GSocketServiceClass
{
	public GSocketListenerClass parent_class;
	public IntPtr incoming;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
	public IntPtr _g_reserved6;
}

public struct GConverterInputStreamClass
{
	public GFilterInputStreamClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

public struct GOutputVector
{
	public IntPtr buffer;
	public nuint size;
}

public struct GNetworkMonitorInterface
{
	public GTypeInterface g_iface;
	public IntPtr network_changed;
	public IntPtr can_reach;
	public IntPtr can_reach_async;
	public IntPtr can_reach_finish;
}

public struct GSocketListener
{
	public GObject.GObject parent_instance;
	public GSocketListenerPrivateHandle priv;
}

public struct GBufferedInputStream
{
	public GFilterInputStream parent_instance;
	public GBufferedInputStreamPrivateHandle priv;
}

public struct GAsyncInitable { }
public struct GTlsFileDatabase { }
public struct GNotification { }

public struct GSimpleActionGroupClass
{
	public GObjectClass parent_class;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
		public IntPtr e8;
		public IntPtr e9;
		public IntPtr e10;
		public IntPtr e11;
	}
}

public struct GSrvTarget { }
public struct GPowerProfileMonitor { }

public struct GFileInputStream
{
	public GInputStream parent_instance;
	public GFileInputStreamPrivateHandle priv;
}

public struct GEmblemedIconPrivate { }
public struct GZlibCompressor { }

public struct GFileOutputStream
{
	public GOutputStream parent_instance;
	public GFileOutputStreamPrivateHandle priv;
}

public struct GPollableInputStream { }
public struct GSimpleActionGroupPrivate { }

public struct GProxyAddressEnumerator
{
	public GSocketAddressEnumerator parent_instance;
	public GProxyAddressEnumeratorPrivateHandle priv;
}

public struct GFileEnumerator
{
	public GObject.GObject parent_instance;
	public GFileEnumeratorPrivateHandle priv;
}

public struct GFile { }
public struct GAsyncResult { }
public struct GResource { }

public struct GTcpConnection
{
	public GSocketConnection parent_instance;
	public GTcpConnectionPrivateHandle priv;
}

public struct GFileAttributeMatcher { }

public struct GDataOutputStream
{
	public GFilterOutputStream parent_instance;
	public GDataOutputStreamPrivateHandle priv;
}

public struct GDBusConnection { }

public struct GThreadedSocketServiceClass
{
	public GSocketServiceClass parent_class;
	public IntPtr run;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

public struct GFileIconClass { }

public struct GFileIface
{
	public GTypeInterface g_iface;
	public IntPtr dup;
	public IntPtr hash;
	public IntPtr equal;
	public IntPtr is_native;
	public IntPtr has_uri_scheme;
	public IntPtr get_uri_scheme;
	public IntPtr get_basename;
	public IntPtr get_path;
	public IntPtr get_uri;
	public IntPtr get_parse_name;
	public IntPtr get_parent;
	public IntPtr prefix_matches;
	public IntPtr get_relative_path;
	public IntPtr resolve_relative_path;
	public IntPtr get_child_for_display_name;
	public IntPtr enumerate_children;
	public IntPtr enumerate_children_async;
	public IntPtr enumerate_children_finish;
	public IntPtr query_info;
	public IntPtr query_info_async;
	public IntPtr query_info_finish;
	public IntPtr query_filesystem_info;
	public IntPtr query_filesystem_info_async;
	public IntPtr query_filesystem_info_finish;
	public IntPtr find_enclosing_mount;
	public IntPtr find_enclosing_mount_async;
	public IntPtr find_enclosing_mount_finish;
	public IntPtr set_display_name;
	public IntPtr set_display_name_async;
	public IntPtr set_display_name_finish;
	public IntPtr query_settable_attributes;
	public IntPtr _query_settable_attributes_async;
	public IntPtr _query_settable_attributes_finish;
	public IntPtr query_writable_namespaces;
	public IntPtr _query_writable_namespaces_async;
	public IntPtr _query_writable_namespaces_finish;
	public IntPtr set_attribute;
	public IntPtr set_attributes_from_info;
	public IntPtr set_attributes_async;
	public IntPtr set_attributes_finish;
	public IntPtr read_fn;
	public IntPtr read_async;
	public IntPtr read_finish;
	public IntPtr append_to;
	public IntPtr append_to_async;
	public IntPtr append_to_finish;
	public IntPtr create;
	public IntPtr create_async;
	public IntPtr create_finish;
	public IntPtr replace;
	public IntPtr replace_async;
	public IntPtr replace_finish;
	public IntPtr delete_file;
	public IntPtr delete_file_async;
	public IntPtr delete_file_finish;
	public IntPtr trash;
	public IntPtr trash_async;
	public IntPtr trash_finish;
	public IntPtr make_directory;
	public IntPtr make_directory_async;
	public IntPtr make_directory_finish;
	public IntPtr make_symbolic_link;
	public IntPtr _make_symbolic_link_async;
	public IntPtr _make_symbolic_link_finish;
	public IntPtr copy;
	public IntPtr copy_async;
	public IntPtr copy_finish;
	public IntPtr move;
	public IntPtr move_async;
	public IntPtr move_finish;
	public IntPtr mount_mountable;
	public IntPtr mount_mountable_finish;
	public IntPtr unmount_mountable;
	public IntPtr unmount_mountable_finish;
	public IntPtr eject_mountable;
	public IntPtr eject_mountable_finish;
	public IntPtr mount_enclosing_volume;
	public IntPtr mount_enclosing_volume_finish;
	public IntPtr monitor_dir;
	public IntPtr monitor_file;
	public IntPtr open_readwrite;
	public IntPtr open_readwrite_async;
	public IntPtr open_readwrite_finish;
	public IntPtr create_readwrite;
	public IntPtr create_readwrite_async;
	public IntPtr create_readwrite_finish;
	public IntPtr replace_readwrite;
	public IntPtr replace_readwrite_async;
	public IntPtr replace_readwrite_finish;
	public IntPtr start_mountable;
	public IntPtr start_mountable_finish;
	public IntPtr stop_mountable;
	public IntPtr stop_mountable_finish;
	public int supports_thread_contexts;
	public IntPtr unmount_mountable_with_operation;
	public IntPtr unmount_mountable_with_operation_finish;
	public IntPtr eject_mountable_with_operation;
	public IntPtr eject_mountable_with_operation_finish;
	public IntPtr poll_mountable;
	public IntPtr poll_mountable_finish;
	public IntPtr measure_disk_usage;
	public IntPtr measure_disk_usage_async;
	public IntPtr measure_disk_usage_finish;
}

public struct GProxyInterface
{
	public GTypeInterface g_iface;
	public IntPtr connect;
	public IntPtr connect_async;
	public IntPtr connect_finish;
	public IntPtr supports_hostname;
}

public struct GBufferedOutputStreamClass
{
	public GFilterOutputStreamClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
}

public struct GDebugControllerInterface
{
	public GTypeInterface g_iface;
}

public struct GSimpleProxyResolverPrivate { }

public struct GTlsDatabase
{
	public GObject.GObject parent_instance;
	public GTlsDatabasePrivateHandle priv;
}

public struct GDBusObjectProxyClass
{
	public GObjectClass parent_class;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GMemoryInputStream
{
	public GInputStream parent_instance;
	public GMemoryInputStreamPrivateHandle priv;
}

public struct GNetworkService
{
	public GObject.GObject parent_instance;
	public GNetworkServicePrivateHandle priv;
}

public struct GIcon { }

public struct GTlsDatabaseClass
{
	public GObjectClass parent_class;
	public IntPtr verify_chain;
	public IntPtr verify_chain_async;
	public IntPtr verify_chain_finish;
	public IntPtr create_certificate_handle;
	public IntPtr lookup_certificate_for_handle;
	public IntPtr lookup_certificate_for_handle_async;
	public IntPtr lookup_certificate_for_handle_finish;
	public IntPtr lookup_certificate_issuer;
	public IntPtr lookup_certificate_issuer_async;
	public IntPtr lookup_certificate_issuer_finish;
	public IntPtr lookup_certificates_issued_by;
	public IntPtr lookup_certificates_issued_by_async;
	public IntPtr lookup_certificates_issued_by_finish;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
		public IntPtr e8;
		public IntPtr e9;
		public IntPtr e10;
		public IntPtr e11;
		public IntPtr e12;
		public IntPtr e13;
		public IntPtr e14;
		public IntPtr e15;
	}
}

public struct GTask { }
public struct GTcpWrapperConnectionPrivate { }
public struct GRemoteActionGroup { }
public struct GFileEnumeratorPrivate { }

public struct GDBusPropertyInfo
{
	public int ref_count;
	public string name;
	public string signature;
	public GDBusPropertyInfoFlags flags;
	public GDBusAnnotationInfoHandle[] annotations;
}

public struct GDBusObjectProxy
{
	public GObject.GObject parent_instance;
	public GDBusObjectProxyPrivateHandle priv;
}

public struct GEmblemedIconClass
{
	public GObjectClass parent_class;
}

public struct GDtlsClientConnection { }
public struct GEmblem { }

public struct GSocketControlMessage
{
	public GObject.GObject parent_instance;
	public GSocketControlMessagePrivateHandle priv;
}

public struct GZlibCompressorClass
{
	public GObjectClass parent_class;
}

public struct GThreadedSocketServicePrivate { }
public struct GUnixFDList { }

public struct GAsyncResultIface
{
	public GTypeInterface g_iface;
	public IntPtr get_user_data;
	public IntPtr get_source_object;
	public IntPtr is_tagged;
}

public struct GTcpWrapperConnection
{
	public GTcpConnection parent_instance;
	public GTcpWrapperConnectionPrivateHandle priv;
}

public struct GNativeVolumeMonitorClass
{
	public GVolumeMonitorClass parent_class;
	public IntPtr get_mount_for_mount_path;
}

public struct GPermissionClass
{
	public GObjectClass parent_class;
	public IntPtr acquire;
	public IntPtr acquire_async;
	public IntPtr acquire_finish;
	public IntPtr release;
	public IntPtr release_async;
	public IntPtr release_finish;
	public IntPtr reserved;

	public struct _reserved_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
		public IntPtr e8;
		public IntPtr e9;
		public IntPtr e10;
		public IntPtr e11;
		public IntPtr e12;
		public IntPtr e13;
		public IntPtr e14;
		public IntPtr e15;
	}
}

public struct GSimpleProxyResolverClass
{
	public GObjectClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}

public struct GMemoryOutputStream
{
	public GOutputStream parent_instance;
	public GMemoryOutputStreamPrivateHandle priv;
}

public struct GMenuAttributeIterClass
{
	public GObjectClass parent_class;
	public IntPtr get_next;
}

public struct GDBusObjectSkeleton
{
	public GObject.GObject parent_instance;
	public GDBusObjectSkeletonPrivateHandle priv;
}

public struct GTlsCertificateClass
{
	public GObjectClass parent_class;
	public IntPtr verify;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
	}
}

public struct GMount { }
public struct GLoadableIcon { }
public struct GSettingsSchema { }

public struct GDatagramBasedInterface
{
	public GTypeInterface g_iface;
	public IntPtr receive_messages;
	public IntPtr send_messages;
	public IntPtr create_source;
	public IntPtr condition_check;
	public IntPtr condition_wait;
}

public struct GDBusInterface { }

public struct GAppInfoIface
{
	public GTypeInterface g_iface;
	public IntPtr dup;
	public IntPtr equal;
	public IntPtr get_id;
	public IntPtr get_name;
	public IntPtr get_description;
	public IntPtr get_executable;
	public IntPtr get_icon;
	public IntPtr launch;
	public IntPtr supports_uris;
	public IntPtr supports_files;
	public IntPtr launch_uris;
	public IntPtr should_show;
	public IntPtr set_as_default_for_type;
	public IntPtr set_as_default_for_extension;
	public IntPtr add_supports_type;
	public IntPtr can_remove_supports_type;
	public IntPtr remove_supports_type;
	public IntPtr can_delete;
	public IntPtr do_delete;
	public IntPtr get_commandline;
	public IntPtr get_display_name;
	public IntPtr set_as_last_used_for_type;
	public IntPtr get_supported_types;
	public IntPtr launch_uris_async;
	public IntPtr launch_uris_finish;
}

public struct GIOSchedulerJob { }

public struct GPowerProfileMonitorInterface
{
	public GTypeInterface g_iface;
}

public struct GInetSocketAddress
{
	public GSocketAddress parent_instance;
	public GInetSocketAddressPrivateHandle priv;
}

public struct GConverter { }

public struct GNetworkAddress
{
	public GObject.GObject parent_instance;
	public GNetworkAddressPrivateHandle priv;
}

public struct GProxyAddressPrivate { }
public struct GIOExtension { }
public struct GProxy { }

public struct GPollableOutputStreamInterface
{
	public GTypeInterface g_iface;
	public IntPtr can_poll;
	public IntPtr is_writable;
	public IntPtr create_source;
	public IntPtr write_nonblocking;
	public IntPtr writev_nonblocking;
}

public struct GFileMonitor
{
	public GObject.GObject parent_instance;
	public GFileMonitorPrivateHandle priv;
}

public struct GMountOperation
{
	public GObject.GObject parent_instance;
	public GMountOperationPrivateHandle priv;
}

public struct GInetAddress
{
	public GObject.GObject parent_instance;
	public GInetAddressPrivateHandle priv;
}

public struct GPollableInputStreamInterface
{
	public GTypeInterface g_iface;
	public IntPtr can_poll;
	public IntPtr is_readable;
	public IntPtr create_source;
	public IntPtr read_nonblocking;
}

public struct GCharsetConverter { }
public struct GInputStreamPrivate { }

public struct GDBusProxy
{
	public GObject.GObject parent_instance;
	public GDBusProxyPrivateHandle priv;
}

public struct GFileAttributeInfoList
{
	public GFileAttributeInfoHandle infos;
	public int n_infos;
}

public struct GFileAttributeInfo
{
	public string name;
	public GFileAttributeType type;
	public GFileAttributeInfoFlags flags;
}

public struct GPermissionPrivate { }

public struct GDtlsClientConnectionInterface
{
	public GTypeInterface g_iface;
}

public struct GDebugControllerDBusClass
{
	public GObjectClass parent_class;
	public IntPtr authorize;
	public IntPtr padding;

	public struct _padding_e__FixedBuffer
	{
		public IntPtr e0;
		public IntPtr e1;
		public IntPtr e2;
		public IntPtr e3;
		public IntPtr e4;
		public IntPtr e5;
		public IntPtr e6;
		public IntPtr e7;
		public IntPtr e8;
		public IntPtr e9;
		public IntPtr e10;
		public IntPtr e11;
	}
}

public struct GZlibDecompressorClass
{
	public GObjectClass parent_class;
}

public struct GMenuModelPrivate { }
public struct GSimpleIOStream { }

public struct GSocketListenerClass
{
	public GObjectClass parent_class;
	public IntPtr changed;
	public IntPtr @event;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
	public IntPtr _g_reserved6;
}

public struct GBufferedOutputStream
{
	public GFilterOutputStream parent_instance;
	public GBufferedOutputStreamPrivateHandle priv;
}

public struct GDBusInterfaceSkeleton
{
	public GObject.GObject parent_instance;
	public GDBusInterfaceSkeletonPrivateHandle priv;
}

public struct GSocketConnectableIface
{
	public GTypeInterface g_iface;
	public IntPtr enumerate;
	public IntPtr proxy_enumerate;
	public IntPtr to_string;
}

public struct GDtlsConnectionInterface
{
	public GTypeInterface g_iface;
	public IntPtr accept_certificate;
	public IntPtr handshake;
	public IntPtr handshake_async;
	public IntPtr handshake_finish;
	public IntPtr shutdown;
	public IntPtr shutdown_async;
	public IntPtr shutdown_finish;
	public IntPtr set_advertised_protocols;
	public IntPtr get_negotiated_protocol;
	public IntPtr get_binding_data;
}

public struct GSimpleActionGroup
{
	public GObject.GObject parent_instance;
	public GSimpleActionGroupPrivateHandle priv;
}

public struct GActionMapInterface
{
	public GTypeInterface g_iface;
	public IntPtr lookup_action;
	public IntPtr add_action;
	public IntPtr remove_action;
}

public struct GDBusObject { }

public struct GMemoryMonitorInterface
{
	public GTypeInterface g_iface;
	public IntPtr low_memory_warning;
}

public struct GDriveIface
{
	public GTypeInterface g_iface;
	public IntPtr changed;
	public IntPtr disconnected;
	public IntPtr eject_button;
	public IntPtr get_name;
	public IntPtr get_icon;
	public IntPtr has_volumes;
	public IntPtr get_volumes;
	public IntPtr is_media_removable;
	public IntPtr has_media;
	public IntPtr is_media_check_automatic;
	public IntPtr can_eject;
	public IntPtr can_poll_for_media;
	public IntPtr eject;
	public IntPtr eject_finish;
	public IntPtr poll_for_media;
	public IntPtr poll_for_media_finish;
	public IntPtr get_identifier;
	public IntPtr enumerate_identifiers;
	public IntPtr get_start_stop_type;
	public IntPtr can_start;
	public IntPtr can_start_degraded;
	public IntPtr start;
	public IntPtr start_finish;
	public IntPtr can_stop;
	public IntPtr stop;
	public IntPtr stop_finish;
	public IntPtr stop_button;
	public IntPtr eject_with_operation;
	public IntPtr eject_with_operation_finish;
	public IntPtr get_sort_key;
	public IntPtr get_symbolic_icon;
	public IntPtr is_removable;
}

public struct GApplication
{
	public GObject.GObject parent_instance;
	public GApplicationPrivateHandle priv;
}

public struct GMountIface
{
	public GTypeInterface g_iface;
	public IntPtr changed;
	public IntPtr unmounted;
	public IntPtr get_root;
	public IntPtr get_name;
	public IntPtr get_icon;
	public IntPtr get_uuid;
	public IntPtr get_volume;
	public IntPtr get_drive;
	public IntPtr can_unmount;
	public IntPtr can_eject;
	public IntPtr unmount;
	public IntPtr unmount_finish;
	public IntPtr eject;
	public IntPtr eject_finish;
	public IntPtr remount;
	public IntPtr remount_finish;
	public IntPtr guess_content_type;
	public IntPtr guess_content_type_finish;
	public IntPtr guess_content_type_sync;
	public IntPtr pre_unmount;
	public IntPtr unmount_with_operation;
	public IntPtr unmount_with_operation_finish;
	public IntPtr eject_with_operation;
	public IntPtr eject_with_operation_finish;
	public IntPtr get_default_location;
	public IntPtr get_sort_key;
	public IntPtr get_symbolic_icon;
}
