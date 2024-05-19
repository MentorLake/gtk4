namespace MentorLake.Gtk4.Gio;

public interface GVolumeHandle
{
}

internal class GVolumeHandleImpl : BaseSafeHandle, GVolumeHandle
{
}

public static class GVolumeHandleExtensions
{
	public static bool CanEject(this GVolumeHandle volume)
	{
		return GVolumeExterns.g_volume_can_eject(volume);
	}

	public static bool CanMount(this GVolumeHandle volume)
	{
		return GVolumeExterns.g_volume_can_mount(volume);
	}

	public static GVolumeHandle Eject(this GVolumeHandle volume, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GVolumeExterns.g_volume_eject(volume, flags, cancellable, callback, user_data);
		return volume;
	}

	public static bool EjectFinish(this GVolumeHandle volume, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GVolumeExterns.g_volume_eject_finish(volume, result, out error);
	}

	public static GVolumeHandle EjectWithOperation(this GVolumeHandle volume, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GVolumeExterns.g_volume_eject_with_operation(volume, flags, mount_operation, cancellable, callback, user_data);
		return volume;
	}

	public static bool EjectWithOperationFinish(this GVolumeHandle volume, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GVolumeExterns.g_volume_eject_with_operation_finish(volume, result, out error);
	}

	public static string[] EnumerateIdentifiers(this GVolumeHandle volume)
	{
		return GVolumeExterns.g_volume_enumerate_identifiers(volume);
	}

	public static GFileHandle GetActivationRoot(this GVolumeHandle volume)
	{
		return GVolumeExterns.g_volume_get_activation_root(volume);
	}

	public static GDriveHandle GetDrive(this GVolumeHandle volume)
	{
		return GVolumeExterns.g_volume_get_drive(volume);
	}

	public static GIconHandle GetIcon(this GVolumeHandle volume)
	{
		return GVolumeExterns.g_volume_get_icon(volume);
	}

	public static string GetIdentifier(this GVolumeHandle volume, string kind)
	{
		return GVolumeExterns.g_volume_get_identifier(volume, kind);
	}

	public static GMountHandle GetMount(this GVolumeHandle volume)
	{
		return GVolumeExterns.g_volume_get_mount(volume);
	}

	public static string GetName(this GVolumeHandle volume)
	{
		return GVolumeExterns.g_volume_get_name(volume);
	}

	public static string GetSortKey(this GVolumeHandle volume)
	{
		return GVolumeExterns.g_volume_get_sort_key(volume);
	}

	public static GIconHandle GetSymbolicIcon(this GVolumeHandle volume)
	{
		return GVolumeExterns.g_volume_get_symbolic_icon(volume);
	}

	public static string GetUuid(this GVolumeHandle volume)
	{
		return GVolumeExterns.g_volume_get_uuid(volume);
	}

	public static GVolumeHandle Mount(this GVolumeHandle volume, GMountMountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GVolumeExterns.g_volume_mount(volume, flags, mount_operation, cancellable, callback, user_data);
		return volume;
	}

	public static bool MountFinish(this GVolumeHandle volume, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GVolumeExterns.g_volume_mount_finish(volume, result, out error);
	}

	public static bool ShouldAutomount(this GVolumeHandle volume)
	{
		return GVolumeExterns.g_volume_should_automount(volume);
	}

}

internal class GVolumeExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_volume_can_eject(GVolumeHandle volume);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_volume_can_mount(GVolumeHandle volume);

	[DllImport(Libraries.Gio)]
	internal static extern void g_volume_eject(GVolumeHandle volume, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_volume_eject_finish(GVolumeHandle volume, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_volume_eject_with_operation(GVolumeHandle volume, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_volume_eject_with_operation_finish(GVolumeHandle volume, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern string[] g_volume_enumerate_identifiers(GVolumeHandle volume);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_volume_get_activation_root(GVolumeHandle volume);

	[DllImport(Libraries.Gio)]
	internal static extern GDriveHandle g_volume_get_drive(GVolumeHandle volume);

	[DllImport(Libraries.Gio)]
	internal static extern GIconHandle g_volume_get_icon(GVolumeHandle volume);

	[DllImport(Libraries.Gio)]
	internal static extern string g_volume_get_identifier(GVolumeHandle volume, string kind);

	[DllImport(Libraries.Gio)]
	internal static extern GMountHandle g_volume_get_mount(GVolumeHandle volume);

	[DllImport(Libraries.Gio)]
	internal static extern string g_volume_get_name(GVolumeHandle volume);

	[DllImport(Libraries.Gio)]
	internal static extern string g_volume_get_sort_key(GVolumeHandle volume);

	[DllImport(Libraries.Gio)]
	internal static extern GIconHandle g_volume_get_symbolic_icon(GVolumeHandle volume);

	[DllImport(Libraries.Gio)]
	internal static extern string g_volume_get_uuid(GVolumeHandle volume);

	[DllImport(Libraries.Gio)]
	internal static extern void g_volume_mount(GVolumeHandle volume, GMountMountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_volume_mount_finish(GVolumeHandle volume, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_volume_should_automount(GVolumeHandle volume);

}
