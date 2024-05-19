namespace MentorLake.Gtk4.Gio;

public class GVolumeMonitorHandle : GObjectHandle
{
	public static GVolumeHandle AdoptOrphanMount(GMountHandle mount)
	{
		return GVolumeMonitorExterns.g_volume_monitor_adopt_orphan_mount(mount);
	}

	public static GVolumeMonitorHandle Get()
	{
		return GVolumeMonitorExterns.g_volume_monitor_get();
	}

}

public static class GVolumeMonitorSignalExtensions
{

	public static IObservable<GVolumeMonitorSignalStructs.DriveChangedSignal> Signal_DriveChanged(this GVolumeMonitorHandle instance)
	{
		return Observable.Create((IObserver<GVolumeMonitorSignalStructs.DriveChangedSignal> obs) =>
		{
			GVolumeMonitorSignalDelegates.DriveChanged handler = (GVolumeMonitorHandle self, GDriveHandle drive, IntPtr user_data) =>
			{


				var signalStruct = new GVolumeMonitorSignalStructs.DriveChangedSignal()
				{
					Self = self, Drive = drive, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drive_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GVolumeMonitorSignalStructs.DriveConnectedSignal> Signal_DriveConnected(this GVolumeMonitorHandle instance)
	{
		return Observable.Create((IObserver<GVolumeMonitorSignalStructs.DriveConnectedSignal> obs) =>
		{
			GVolumeMonitorSignalDelegates.DriveConnected handler = (GVolumeMonitorHandle self, GDriveHandle drive, IntPtr user_data) =>
			{


				var signalStruct = new GVolumeMonitorSignalStructs.DriveConnectedSignal()
				{
					Self = self, Drive = drive, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drive_connected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GVolumeMonitorSignalStructs.DriveDisconnectedSignal> Signal_DriveDisconnected(this GVolumeMonitorHandle instance)
	{
		return Observable.Create((IObserver<GVolumeMonitorSignalStructs.DriveDisconnectedSignal> obs) =>
		{
			GVolumeMonitorSignalDelegates.DriveDisconnected handler = (GVolumeMonitorHandle self, GDriveHandle drive, IntPtr user_data) =>
			{


				var signalStruct = new GVolumeMonitorSignalStructs.DriveDisconnectedSignal()
				{
					Self = self, Drive = drive, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drive_disconnected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GVolumeMonitorSignalStructs.DriveEjectButtonSignal> Signal_DriveEjectButton(this GVolumeMonitorHandle instance)
	{
		return Observable.Create((IObserver<GVolumeMonitorSignalStructs.DriveEjectButtonSignal> obs) =>
		{
			GVolumeMonitorSignalDelegates.DriveEjectButton handler = (GVolumeMonitorHandle self, GDriveHandle drive, IntPtr user_data) =>
			{


				var signalStruct = new GVolumeMonitorSignalStructs.DriveEjectButtonSignal()
				{
					Self = self, Drive = drive, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drive_eject_button", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GVolumeMonitorSignalStructs.DriveStopButtonSignal> Signal_DriveStopButton(this GVolumeMonitorHandle instance)
	{
		return Observable.Create((IObserver<GVolumeMonitorSignalStructs.DriveStopButtonSignal> obs) =>
		{
			GVolumeMonitorSignalDelegates.DriveStopButton handler = (GVolumeMonitorHandle self, GDriveHandle drive, IntPtr user_data) =>
			{


				var signalStruct = new GVolumeMonitorSignalStructs.DriveStopButtonSignal()
				{
					Self = self, Drive = drive, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drive_stop_button", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GVolumeMonitorSignalStructs.MountAddedSignal> Signal_MountAdded(this GVolumeMonitorHandle instance)
	{
		return Observable.Create((IObserver<GVolumeMonitorSignalStructs.MountAddedSignal> obs) =>
		{
			GVolumeMonitorSignalDelegates.MountAdded handler = (GVolumeMonitorHandle self, GMountHandle mount, IntPtr user_data) =>
			{


				var signalStruct = new GVolumeMonitorSignalStructs.MountAddedSignal()
				{
					Self = self, Mount = mount, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "mount_added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GVolumeMonitorSignalStructs.MountChangedSignal> Signal_MountChanged(this GVolumeMonitorHandle instance)
	{
		return Observable.Create((IObserver<GVolumeMonitorSignalStructs.MountChangedSignal> obs) =>
		{
			GVolumeMonitorSignalDelegates.MountChanged handler = (GVolumeMonitorHandle self, GMountHandle mount, IntPtr user_data) =>
			{


				var signalStruct = new GVolumeMonitorSignalStructs.MountChangedSignal()
				{
					Self = self, Mount = mount, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "mount_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GVolumeMonitorSignalStructs.MountPreUnmountSignal> Signal_MountPreUnmount(this GVolumeMonitorHandle instance)
	{
		return Observable.Create((IObserver<GVolumeMonitorSignalStructs.MountPreUnmountSignal> obs) =>
		{
			GVolumeMonitorSignalDelegates.MountPreUnmount handler = (GVolumeMonitorHandle self, GMountHandle mount, IntPtr user_data) =>
			{


				var signalStruct = new GVolumeMonitorSignalStructs.MountPreUnmountSignal()
				{
					Self = self, Mount = mount, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "mount_pre_unmount", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GVolumeMonitorSignalStructs.MountRemovedSignal> Signal_MountRemoved(this GVolumeMonitorHandle instance)
	{
		return Observable.Create((IObserver<GVolumeMonitorSignalStructs.MountRemovedSignal> obs) =>
		{
			GVolumeMonitorSignalDelegates.MountRemoved handler = (GVolumeMonitorHandle self, GMountHandle mount, IntPtr user_data) =>
			{


				var signalStruct = new GVolumeMonitorSignalStructs.MountRemovedSignal()
				{
					Self = self, Mount = mount, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "mount_removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GVolumeMonitorSignalStructs.VolumeAddedSignal> Signal_VolumeAdded(this GVolumeMonitorHandle instance)
	{
		return Observable.Create((IObserver<GVolumeMonitorSignalStructs.VolumeAddedSignal> obs) =>
		{
			GVolumeMonitorSignalDelegates.VolumeAdded handler = (GVolumeMonitorHandle self, GVolumeHandle volume, IntPtr user_data) =>
			{


				var signalStruct = new GVolumeMonitorSignalStructs.VolumeAddedSignal()
				{
					Self = self, Volume = volume, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "volume_added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GVolumeMonitorSignalStructs.VolumeChangedSignal> Signal_VolumeChanged(this GVolumeMonitorHandle instance)
	{
		return Observable.Create((IObserver<GVolumeMonitorSignalStructs.VolumeChangedSignal> obs) =>
		{
			GVolumeMonitorSignalDelegates.VolumeChanged handler = (GVolumeMonitorHandle self, GVolumeHandle volume, IntPtr user_data) =>
			{


				var signalStruct = new GVolumeMonitorSignalStructs.VolumeChangedSignal()
				{
					Self = self, Volume = volume, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "volume_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GVolumeMonitorSignalStructs.VolumeRemovedSignal> Signal_VolumeRemoved(this GVolumeMonitorHandle instance)
	{
		return Observable.Create((IObserver<GVolumeMonitorSignalStructs.VolumeRemovedSignal> obs) =>
		{
			GVolumeMonitorSignalDelegates.VolumeRemoved handler = (GVolumeMonitorHandle self, GVolumeHandle volume, IntPtr user_data) =>
			{


				var signalStruct = new GVolumeMonitorSignalStructs.VolumeRemovedSignal()
				{
					Self = self, Volume = volume, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "volume_removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GVolumeMonitorSignalStructs
{

public struct DriveChangedSignal
{
	public GVolumeMonitorHandle Self;
	public GDriveHandle Drive;
	public IntPtr UserData;
}

public struct DriveConnectedSignal
{
	public GVolumeMonitorHandle Self;
	public GDriveHandle Drive;
	public IntPtr UserData;
}

public struct DriveDisconnectedSignal
{
	public GVolumeMonitorHandle Self;
	public GDriveHandle Drive;
	public IntPtr UserData;
}

public struct DriveEjectButtonSignal
{
	public GVolumeMonitorHandle Self;
	public GDriveHandle Drive;
	public IntPtr UserData;
}

public struct DriveStopButtonSignal
{
	public GVolumeMonitorHandle Self;
	public GDriveHandle Drive;
	public IntPtr UserData;
}

public struct MountAddedSignal
{
	public GVolumeMonitorHandle Self;
	public GMountHandle Mount;
	public IntPtr UserData;
}

public struct MountChangedSignal
{
	public GVolumeMonitorHandle Self;
	public GMountHandle Mount;
	public IntPtr UserData;
}

public struct MountPreUnmountSignal
{
	public GVolumeMonitorHandle Self;
	public GMountHandle Mount;
	public IntPtr UserData;
}

public struct MountRemovedSignal
{
	public GVolumeMonitorHandle Self;
	public GMountHandle Mount;
	public IntPtr UserData;
}

public struct VolumeAddedSignal
{
	public GVolumeMonitorHandle Self;
	public GVolumeHandle Volume;
	public IntPtr UserData;
}

public struct VolumeChangedSignal
{
	public GVolumeMonitorHandle Self;
	public GVolumeHandle Volume;
	public IntPtr UserData;
}

public struct VolumeRemovedSignal
{
	public GVolumeMonitorHandle Self;
	public GVolumeHandle Volume;
	public IntPtr UserData;
}
}

public static class GVolumeMonitorSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DriveChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GVolumeMonitorHandle>))] GVolumeMonitorHandle self, GDriveHandle drive, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DriveConnected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GVolumeMonitorHandle>))] GVolumeMonitorHandle self, GDriveHandle drive, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DriveDisconnected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GVolumeMonitorHandle>))] GVolumeMonitorHandle self, GDriveHandle drive, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DriveEjectButton([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GVolumeMonitorHandle>))] GVolumeMonitorHandle self, GDriveHandle drive, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DriveStopButton([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GVolumeMonitorHandle>))] GVolumeMonitorHandle self, GDriveHandle drive, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MountAdded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GVolumeMonitorHandle>))] GVolumeMonitorHandle self, GMountHandle mount, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MountChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GVolumeMonitorHandle>))] GVolumeMonitorHandle self, GMountHandle mount, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MountPreUnmount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GVolumeMonitorHandle>))] GVolumeMonitorHandle self, GMountHandle mount, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MountRemoved([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GVolumeMonitorHandle>))] GVolumeMonitorHandle self, GMountHandle mount, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void VolumeAdded([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GVolumeMonitorHandle>))] GVolumeMonitorHandle self, GVolumeHandle volume, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void VolumeChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GVolumeMonitorHandle>))] GVolumeMonitorHandle self, GVolumeHandle volume, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void VolumeRemoved([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GVolumeMonitorHandle>))] GVolumeMonitorHandle self, GVolumeHandle volume, IntPtr user_data);
}


public static class GVolumeMonitorHandleExtensions
{
	public static GListHandle GetConnectedDrives(this GVolumeMonitorHandle volume_monitor)
	{
		return GVolumeMonitorExterns.g_volume_monitor_get_connected_drives(volume_monitor);
	}

	public static GMountHandle GetMountForUuid(this GVolumeMonitorHandle volume_monitor, string uuid)
	{
		return GVolumeMonitorExterns.g_volume_monitor_get_mount_for_uuid(volume_monitor, uuid);
	}

	public static GListHandle GetMounts(this GVolumeMonitorHandle volume_monitor)
	{
		return GVolumeMonitorExterns.g_volume_monitor_get_mounts(volume_monitor);
	}

	public static GVolumeHandle GetVolumeForUuid(this GVolumeMonitorHandle volume_monitor, string uuid)
	{
		return GVolumeMonitorExterns.g_volume_monitor_get_volume_for_uuid(volume_monitor, uuid);
	}

	public static GListHandle GetVolumes(this GVolumeMonitorHandle volume_monitor)
	{
		return GVolumeMonitorExterns.g_volume_monitor_get_volumes(volume_monitor);
	}

}

internal class GVolumeMonitorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_volume_monitor_get_connected_drives(GVolumeMonitorHandle volume_monitor);

	[DllImport(Libraries.Gio)]
	internal static extern GMountHandle g_volume_monitor_get_mount_for_uuid(GVolumeMonitorHandle volume_monitor, string uuid);

	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_volume_monitor_get_mounts(GVolumeMonitorHandle volume_monitor);

	[DllImport(Libraries.Gio)]
	internal static extern GVolumeHandle g_volume_monitor_get_volume_for_uuid(GVolumeMonitorHandle volume_monitor, string uuid);

	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_volume_monitor_get_volumes(GVolumeMonitorHandle volume_monitor);

	[DllImport(Libraries.Gio)]
	internal static extern GVolumeHandle g_volume_monitor_adopt_orphan_mount(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern GVolumeMonitorHandle g_volume_monitor_get();

}
