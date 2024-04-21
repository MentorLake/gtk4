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

public class GVolumeMonitorSignal
{
	public string Value { get; set; }
	public GVolumeMonitorSignal(string value) => Value = value;
}

public static class GVolumeMonitorSignals
{
	public static GVolumeMonitorSignal DriveChanged = new("BindingTransform.MethodDeclaration");
	public static GVolumeMonitorSignal DriveConnected = new("BindingTransform.MethodDeclaration");
	public static GVolumeMonitorSignal DriveDisconnected = new("BindingTransform.MethodDeclaration");
	public static GVolumeMonitorSignal DriveEjectButton = new("BindingTransform.MethodDeclaration");
	public static GVolumeMonitorSignal DriveStopButton = new("BindingTransform.MethodDeclaration");
	public static GVolumeMonitorSignal MountAdded = new("BindingTransform.MethodDeclaration");
	public static GVolumeMonitorSignal MountChanged = new("BindingTransform.MethodDeclaration");
	public static GVolumeMonitorSignal MountPreUnmount = new("BindingTransform.MethodDeclaration");
	public static GVolumeMonitorSignal MountRemoved = new("BindingTransform.MethodDeclaration");
	public static GVolumeMonitorSignal VolumeAdded = new("BindingTransform.MethodDeclaration");
	public static GVolumeMonitorSignal VolumeChanged = new("BindingTransform.MethodDeclaration");
	public static GVolumeMonitorSignal VolumeRemoved = new("BindingTransform.MethodDeclaration");
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

	public static GVolumeMonitorHandle Signal_DriveChanged(this GVolumeMonitorHandle instance, GVolumeMonitorDelegates.DriveChanged handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "drive_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GVolumeMonitorHandle Signal_DriveConnected(this GVolumeMonitorHandle instance, GVolumeMonitorDelegates.DriveConnected handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "drive_connected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GVolumeMonitorHandle Signal_DriveDisconnected(this GVolumeMonitorHandle instance, GVolumeMonitorDelegates.DriveDisconnected handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "drive_disconnected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GVolumeMonitorHandle Signal_DriveEjectButton(this GVolumeMonitorHandle instance, GVolumeMonitorDelegates.DriveEjectButton handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "drive_eject_button", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GVolumeMonitorHandle Signal_DriveStopButton(this GVolumeMonitorHandle instance, GVolumeMonitorDelegates.DriveStopButton handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "drive_stop_button", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GVolumeMonitorHandle Signal_MountAdded(this GVolumeMonitorHandle instance, GVolumeMonitorDelegates.MountAdded handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "mount_added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GVolumeMonitorHandle Signal_MountChanged(this GVolumeMonitorHandle instance, GVolumeMonitorDelegates.MountChanged handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "mount_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GVolumeMonitorHandle Signal_MountPreUnmount(this GVolumeMonitorHandle instance, GVolumeMonitorDelegates.MountPreUnmount handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "mount_pre_unmount", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GVolumeMonitorHandle Signal_MountRemoved(this GVolumeMonitorHandle instance, GVolumeMonitorDelegates.MountRemoved handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "mount_removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GVolumeMonitorHandle Signal_VolumeAdded(this GVolumeMonitorHandle instance, GVolumeMonitorDelegates.VolumeAdded handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "volume_added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GVolumeMonitorHandle Signal_VolumeChanged(this GVolumeMonitorHandle instance, GVolumeMonitorDelegates.VolumeChanged handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "volume_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GVolumeMonitorHandle Signal_VolumeRemoved(this GVolumeMonitorHandle instance, GVolumeMonitorDelegates.VolumeRemoved handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "volume_removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GVolumeMonitorDelegates
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
