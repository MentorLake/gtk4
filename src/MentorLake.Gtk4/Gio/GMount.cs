using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gio;

public interface GMountHandle
{
}

internal class GMountHandleImpl : BaseSafeHandle, GMountHandle
{
}

public static class GMountHandleExtensions
{
	public static bool CanEject(this GMountHandle mount)
	{
		return GMountExterns.g_mount_can_eject(mount);
	}

	public static bool CanUnmount(this GMountHandle mount)
	{
		return GMountExterns.g_mount_can_unmount(mount);
	}

	public static GMountHandle Eject(this GMountHandle mount, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GMountExterns.g_mount_eject(mount, flags, cancellable, callback, user_data);
		return mount;
	}

	public static bool EjectFinish(this GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GMountExterns.g_mount_eject_finish(mount, result, out error);
	}

	public static GMountHandle EjectWithOperation(this GMountHandle mount, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GMountExterns.g_mount_eject_with_operation(mount, flags, mount_operation, cancellable, callback, user_data);
		return mount;
	}

	public static bool EjectWithOperationFinish(this GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GMountExterns.g_mount_eject_with_operation_finish(mount, result, out error);
	}

	public static GFileHandle GetDefaultLocation(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_default_location(mount);
	}

	public static GDriveHandle GetDrive(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_drive(mount);
	}

	public static GIconHandle GetIcon(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_icon(mount);
	}

	public static string GetName(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_name(mount);
	}

	public static GFileHandle GetRoot(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_root(mount);
	}

	public static string GetSortKey(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_sort_key(mount);
	}

	public static GIconHandle GetSymbolicIcon(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_symbolic_icon(mount);
	}

	public static string GetUuid(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_uuid(mount);
	}

	public static GVolumeHandle GetVolume(this GMountHandle mount)
	{
		return GMountExterns.g_mount_get_volume(mount);
	}

	public static GMountHandle GuessContentType(this GMountHandle mount, bool force_rescan, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GMountExterns.g_mount_guess_content_type(mount, force_rescan, cancellable, callback, user_data);
		return mount;
	}

	public static string[] GuessContentTypeFinish(this GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GMountExterns.g_mount_guess_content_type_finish(mount, result, out error);
	}

	public static string[] GuessContentTypeSync(this GMountHandle mount, bool force_rescan, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GMountExterns.g_mount_guess_content_type_sync(mount, force_rescan, cancellable, out error);
	}

	public static bool IsShadowed(this GMountHandle mount)
	{
		return GMountExterns.g_mount_is_shadowed(mount);
	}

	public static GMountHandle Remount(this GMountHandle mount, GMountMountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GMountExterns.g_mount_remount(mount, flags, mount_operation, cancellable, callback, user_data);
		return mount;
	}

	public static bool RemountFinish(this GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GMountExterns.g_mount_remount_finish(mount, result, out error);
	}

	public static GMountHandle Shadow(this GMountHandle mount)
	{
		GMountExterns.g_mount_shadow(mount);
		return mount;
	}

	public static GMountHandle Unmount(this GMountHandle mount, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GMountExterns.g_mount_unmount(mount, flags, cancellable, callback, user_data);
		return mount;
	}

	public static bool UnmountFinish(this GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GMountExterns.g_mount_unmount_finish(mount, result, out error);
	}

	public static GMountHandle UnmountWithOperation(this GMountHandle mount, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GMountExterns.g_mount_unmount_with_operation(mount, flags, mount_operation, cancellable, callback, user_data);
		return mount;
	}

	public static bool UnmountWithOperationFinish(this GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GMountExterns.g_mount_unmount_with_operation_finish(mount, result, out error);
	}

	public static GMountHandle Unshadow(this GMountHandle mount)
	{
		GMountExterns.g_mount_unshadow(mount);
		return mount;
	}

}

internal class GMountExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_can_eject(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_can_unmount(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_eject(GMountHandle mount, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_eject_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_eject_with_operation(GMountHandle mount, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_eject_with_operation_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_mount_get_default_location(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern GDriveHandle g_mount_get_drive(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern GIconHandle g_mount_get_icon(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern string g_mount_get_name(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_mount_get_root(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern string g_mount_get_sort_key(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern GIconHandle g_mount_get_symbolic_icon(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern string g_mount_get_uuid(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern GVolumeHandle g_mount_get_volume(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_guess_content_type(GMountHandle mount, bool force_rescan, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern string[] g_mount_guess_content_type_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern string[] g_mount_guess_content_type_sync(GMountHandle mount, bool force_rescan, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_is_shadowed(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_remount(GMountHandle mount, GMountMountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_remount_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_shadow(GMountHandle mount);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_unmount(GMountHandle mount, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_unmount_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_unmount_with_operation(GMountHandle mount, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_mount_unmount_with_operation_finish(GMountHandle mount, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_mount_unshadow(GMountHandle mount);

}
