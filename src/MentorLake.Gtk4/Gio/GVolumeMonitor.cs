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
}

public class GVolumeMonitorSignal
{
	public string Value { get; set; }
	public GVolumeMonitorSignal(string value) => Value = value;
}

public static class GVolumeMonitorSignals
{
	public static GVolumeMonitorSignal DriveChanged = new("drive-changed");
	public static GVolumeMonitorSignal DriveConnected = new("drive-connected");
	public static GVolumeMonitorSignal DriveDisconnected = new("drive-disconnected");
	public static GVolumeMonitorSignal DriveEjectButton = new("drive-eject-button");
	public static GVolumeMonitorSignal DriveStopButton = new("drive-stop-button");
	public static GVolumeMonitorSignal MountAdded = new("mount-added");
	public static GVolumeMonitorSignal MountChanged = new("mount-changed");
	public static GVolumeMonitorSignal MountPreUnmount = new("mount-pre-unmount");
	public static GVolumeMonitorSignal MountRemoved = new("mount-removed");
	public static GVolumeMonitorSignal VolumeAdded = new("volume-added");
	public static GVolumeMonitorSignal VolumeChanged = new("volume-changed");
	public static GVolumeMonitorSignal VolumeRemoved = new("volume-removed");
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

	public static GVolumeHandle AdoptOrphanMount(this GMountHandle mount)
	{
		return GVolumeMonitorExterns.g_volume_monitor_adopt_orphan_mount(mount);
	}

	public static GVolumeMonitorHandle Get()
	{
		return GVolumeMonitorExterns.g_volume_monitor_get();
	}

	public static GVolumeMonitorHandle Connect(this GVolumeMonitorHandle instance, GVolumeMonitorSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
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
