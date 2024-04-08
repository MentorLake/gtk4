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

public interface GDriveHandle
{
}

public static class GDriveHandleExtensions
{
	public static bool CanEject(this GDriveHandle drive)
	{
		return GDriveExterns.g_drive_can_eject(drive);
	}

	public static bool CanPollForMedia(this GDriveHandle drive)
	{
		return GDriveExterns.g_drive_can_poll_for_media(drive);
	}

	public static bool CanStart(this GDriveHandle drive)
	{
		return GDriveExterns.g_drive_can_start(drive);
	}

	public static bool CanStartDegraded(this GDriveHandle drive)
	{
		return GDriveExterns.g_drive_can_start_degraded(drive);
	}

	public static bool CanStop(this GDriveHandle drive)
	{
		return GDriveExterns.g_drive_can_stop(drive);
	}

	public static GDriveHandle Eject(this GDriveHandle drive, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDriveExterns.g_drive_eject(drive, flags, cancellable, callback, user_data);
		return drive;
	}

	public static bool EjectFinish(this GDriveHandle drive, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GDriveExterns.g_drive_eject_finish(drive, result, out error);
	}

	public static GDriveHandle EjectWithOperation(this GDriveHandle drive, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDriveExterns.g_drive_eject_with_operation(drive, flags, mount_operation, cancellable, callback, user_data);
		return drive;
	}

	public static bool EjectWithOperationFinish(this GDriveHandle drive, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GDriveExterns.g_drive_eject_with_operation_finish(drive, result, out error);
	}

	public static string[] EnumerateIdentifiers(this GDriveHandle drive)
	{
		return GDriveExterns.g_drive_enumerate_identifiers(drive);
	}

	public static GIconHandle GetIcon(this GDriveHandle drive)
	{
		return GDriveExterns.g_drive_get_icon(drive);
	}

	public static string GetIdentifier(this GDriveHandle drive, string kind)
	{
		return GDriveExterns.g_drive_get_identifier(drive, kind);
	}

	public static string GetName(this GDriveHandle drive)
	{
		return GDriveExterns.g_drive_get_name(drive);
	}

	public static string GetSortKey(this GDriveHandle drive)
	{
		return GDriveExterns.g_drive_get_sort_key(drive);
	}

	public static GDriveStartStopType GetStartStopType(this GDriveHandle drive)
	{
		return GDriveExterns.g_drive_get_start_stop_type(drive);
	}

	public static GIconHandle GetSymbolicIcon(this GDriveHandle drive)
	{
		return GDriveExterns.g_drive_get_symbolic_icon(drive);
	}

	public static GListHandle GetVolumes(this GDriveHandle drive)
	{
		return GDriveExterns.g_drive_get_volumes(drive);
	}

	public static bool HasMedia(this GDriveHandle drive)
	{
		return GDriveExterns.g_drive_has_media(drive);
	}

	public static bool HasVolumes(this GDriveHandle drive)
	{
		return GDriveExterns.g_drive_has_volumes(drive);
	}

	public static bool IsMediaCheckAutomatic(this GDriveHandle drive)
	{
		return GDriveExterns.g_drive_is_media_check_automatic(drive);
	}

	public static bool IsMediaRemovable(this GDriveHandle drive)
	{
		return GDriveExterns.g_drive_is_media_removable(drive);
	}

	public static bool IsRemovable(this GDriveHandle drive)
	{
		return GDriveExterns.g_drive_is_removable(drive);
	}

	public static GDriveHandle PollForMedia(this GDriveHandle drive, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDriveExterns.g_drive_poll_for_media(drive, cancellable, callback, user_data);
		return drive;
	}

	public static bool PollForMediaFinish(this GDriveHandle drive, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GDriveExterns.g_drive_poll_for_media_finish(drive, result, out error);
	}

	public static GDriveHandle Start(this GDriveHandle drive, GDriveStartFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDriveExterns.g_drive_start(drive, flags, mount_operation, cancellable, callback, user_data);
		return drive;
	}

	public static bool StartFinish(this GDriveHandle drive, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GDriveExterns.g_drive_start_finish(drive, result, out error);
	}

	public static GDriveHandle Stop(this GDriveHandle drive, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GDriveExterns.g_drive_stop(drive, flags, mount_operation, cancellable, callback, user_data);
		return drive;
	}

	public static bool StopFinish(this GDriveHandle drive, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GDriveExterns.g_drive_stop_finish(drive, result, out error);
	}

}

internal class GDriveExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_drive_can_eject(GDriveHandle drive);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_drive_can_poll_for_media(GDriveHandle drive);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_drive_can_start(GDriveHandle drive);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_drive_can_start_degraded(GDriveHandle drive);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_drive_can_stop(GDriveHandle drive);
	[DllImport(Libraries.Gio)]
	internal static extern void g_drive_eject(GDriveHandle drive, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_drive_eject_finish(GDriveHandle drive, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_drive_eject_with_operation(GDriveHandle drive, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_drive_eject_with_operation_finish(GDriveHandle drive, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern string[] g_drive_enumerate_identifiers(GDriveHandle drive);
	[DllImport(Libraries.Gio)]
	internal static extern GIconHandle g_drive_get_icon(GDriveHandle drive);
	[DllImport(Libraries.Gio)]
	internal static extern string g_drive_get_identifier(GDriveHandle drive, string kind);
	[DllImport(Libraries.Gio)]
	internal static extern string g_drive_get_name(GDriveHandle drive);
	[DllImport(Libraries.Gio)]
	internal static extern string g_drive_get_sort_key(GDriveHandle drive);
	[DllImport(Libraries.Gio)]
	internal static extern GDriveStartStopType g_drive_get_start_stop_type(GDriveHandle drive);
	[DllImport(Libraries.Gio)]
	internal static extern GIconHandle g_drive_get_symbolic_icon(GDriveHandle drive);
	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_drive_get_volumes(GDriveHandle drive);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_drive_has_media(GDriveHandle drive);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_drive_has_volumes(GDriveHandle drive);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_drive_is_media_check_automatic(GDriveHandle drive);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_drive_is_media_removable(GDriveHandle drive);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_drive_is_removable(GDriveHandle drive);
	[DllImport(Libraries.Gio)]
	internal static extern void g_drive_poll_for_media(GDriveHandle drive, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_drive_poll_for_media_finish(GDriveHandle drive, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_drive_start(GDriveHandle drive, GDriveStartFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_drive_start_finish(GDriveHandle drive, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_drive_stop(GDriveHandle drive, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_drive_stop_finish(GDriveHandle drive, GAsyncResultHandle result, out GErrorHandle error);
}
