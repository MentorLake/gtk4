namespace MentorLake.Gtk4.Gio;

public class GDBusInterfaceSkeletonHandle : GObjectHandle, GDBusInterfaceHandle
{
}

public static class GDBusInterfaceSkeletonSignalExtensions
{

	public static IObservable<GDBusInterfaceSkeletonSignalStructs.GAuthorizeMethodSignal> Signal_GAuthorizeMethod(this GDBusInterfaceSkeletonHandle instance)
	{
		return Observable.Create((IObserver<GDBusInterfaceSkeletonSignalStructs.GAuthorizeMethodSignal> obs) =>
		{
			GDBusInterfaceSkeletonSignalDelegates.GAuthorizeMethod handler = (GDBusInterfaceSkeletonHandle self, GDBusMethodInvocationHandle invocation, IntPtr user_data) =>
			{
				

				var signalStruct = new GDBusInterfaceSkeletonSignalStructs.GAuthorizeMethodSignal()
				{
					Self = self, Invocation = invocation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "g_authorize_method", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GDBusInterfaceSkeletonSignalStructs
{

public struct GAuthorizeMethodSignal
{
	public GDBusInterfaceSkeletonHandle Self;
	public GDBusMethodInvocationHandle Invocation;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GDBusInterfaceSkeletonSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool GAuthorizeMethod([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GDBusInterfaceSkeletonHandle>))] GDBusInterfaceSkeletonHandle self, GDBusMethodInvocationHandle invocation, IntPtr user_data);
}


public static class GDBusInterfaceSkeletonHandleExtensions
{
	public static bool GDbusInterfaceSkeletonExport(this GDBusInterfaceSkeletonHandle interface_, GDBusConnectionHandle connection, string object_path, out GErrorHandle error)
	{
		return GDBusInterfaceSkeletonExterns.g_dbus_interface_skeleton_export(interface_, connection, object_path, out error);
	}

	public static GDBusInterfaceSkeletonHandle GDbusInterfaceSkeletonFlush(this GDBusInterfaceSkeletonHandle interface_)
	{
		GDBusInterfaceSkeletonExterns.g_dbus_interface_skeleton_flush(interface_);
		return interface_;
	}

	public static GDBusConnectionHandle GDbusInterfaceSkeletonGetConnection(this GDBusInterfaceSkeletonHandle interface_)
	{
		return GDBusInterfaceSkeletonExterns.g_dbus_interface_skeleton_get_connection(interface_);
	}

	public static GListHandle GDbusInterfaceSkeletonGetConnections(this GDBusInterfaceSkeletonHandle interface_)
	{
		return GDBusInterfaceSkeletonExterns.g_dbus_interface_skeleton_get_connections(interface_);
	}

	public static GDBusInterfaceSkeletonFlags GDbusInterfaceSkeletonGetFlags(this GDBusInterfaceSkeletonHandle interface_)
	{
		return GDBusInterfaceSkeletonExterns.g_dbus_interface_skeleton_get_flags(interface_);
	}

	public static GDBusInterfaceInfoHandle GDbusInterfaceSkeletonGetInfo(this GDBusInterfaceSkeletonHandle interface_)
	{
		return GDBusInterfaceSkeletonExterns.g_dbus_interface_skeleton_get_info(interface_);
	}

	public static string GDbusInterfaceSkeletonGetObjectPath(this GDBusInterfaceSkeletonHandle interface_)
	{
		return GDBusInterfaceSkeletonExterns.g_dbus_interface_skeleton_get_object_path(interface_);
	}

	public static GVariantHandle GDbusInterfaceSkeletonGetProperties(this GDBusInterfaceSkeletonHandle interface_)
	{
		return GDBusInterfaceSkeletonExterns.g_dbus_interface_skeleton_get_properties(interface_);
	}

	public static GDBusInterfaceVTableHandle GDbusInterfaceSkeletonGetVtable(this GDBusInterfaceSkeletonHandle interface_)
	{
		return GDBusInterfaceSkeletonExterns.g_dbus_interface_skeleton_get_vtable(interface_);
	}

	public static bool GDbusInterfaceSkeletonHasConnection(this GDBusInterfaceSkeletonHandle interface_, GDBusConnectionHandle connection)
	{
		return GDBusInterfaceSkeletonExterns.g_dbus_interface_skeleton_has_connection(interface_, connection);
	}

	public static GDBusInterfaceSkeletonHandle GDbusInterfaceSkeletonSetFlags(this GDBusInterfaceSkeletonHandle interface_, GDBusInterfaceSkeletonFlags flags)
	{
		GDBusInterfaceSkeletonExterns.g_dbus_interface_skeleton_set_flags(interface_, flags);
		return interface_;
	}

	public static GDBusInterfaceSkeletonHandle GDbusInterfaceSkeletonUnexport(this GDBusInterfaceSkeletonHandle interface_)
	{
		GDBusInterfaceSkeletonExterns.g_dbus_interface_skeleton_unexport(interface_);
		return interface_;
	}

	public static GDBusInterfaceSkeletonHandle GDbusInterfaceSkeletonUnexportFromConnection(this GDBusInterfaceSkeletonHandle interface_, GDBusConnectionHandle connection)
	{
		GDBusInterfaceSkeletonExterns.g_dbus_interface_skeleton_unexport_from_connection(interface_, connection);
		return interface_;
	}

}

internal class GDBusInterfaceSkeletonExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_interface_skeleton_export(GDBusInterfaceSkeletonHandle interface_, GDBusConnectionHandle connection, string object_path, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_interface_skeleton_flush(GDBusInterfaceSkeletonHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusConnectionHandle g_dbus_interface_skeleton_get_connection(GDBusInterfaceSkeletonHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_dbus_interface_skeleton_get_connections(GDBusInterfaceSkeletonHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusInterfaceSkeletonFlags g_dbus_interface_skeleton_get_flags(GDBusInterfaceSkeletonHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusInterfaceInfoHandle g_dbus_interface_skeleton_get_info(GDBusInterfaceSkeletonHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_interface_skeleton_get_object_path(GDBusInterfaceSkeletonHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_dbus_interface_skeleton_get_properties(GDBusInterfaceSkeletonHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusInterfaceVTableHandle g_dbus_interface_skeleton_get_vtable(GDBusInterfaceSkeletonHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_dbus_interface_skeleton_has_connection(GDBusInterfaceSkeletonHandle interface_, GDBusConnectionHandle connection);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_interface_skeleton_set_flags(GDBusInterfaceSkeletonHandle interface_, GDBusInterfaceSkeletonFlags flags);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_interface_skeleton_unexport(GDBusInterfaceSkeletonHandle interface_);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_interface_skeleton_unexport_from_connection(GDBusInterfaceSkeletonHandle interface_, GDBusConnectionHandle connection);

}
