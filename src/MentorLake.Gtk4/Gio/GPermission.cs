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

public class GPermissionHandle : GObjectHandle
{
}

public static class GPermissionHandleExtensions
{
	public static bool Acquire(this GPermissionHandle permission, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GPermissionExterns.g_permission_acquire(permission, cancellable, out error);
	}

	public static GPermissionHandle AcquireAsync(this GPermissionHandle permission, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GPermissionExterns.g_permission_acquire_async(permission, cancellable, callback, user_data);
		return permission;
	}

	public static bool AcquireFinish(this GPermissionHandle permission, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GPermissionExterns.g_permission_acquire_finish(permission, result, out error);
	}

	public static bool GetAllowed(this GPermissionHandle permission)
	{
		return GPermissionExterns.g_permission_get_allowed(permission);
	}

	public static bool GetCanAcquire(this GPermissionHandle permission)
	{
		return GPermissionExterns.g_permission_get_can_acquire(permission);
	}

	public static bool GetCanRelease(this GPermissionHandle permission)
	{
		return GPermissionExterns.g_permission_get_can_release(permission);
	}

	public static GPermissionHandle ImplUpdate(this GPermissionHandle permission, bool allowed, bool can_acquire, bool can_release)
	{
		GPermissionExterns.g_permission_impl_update(permission, allowed, can_acquire, can_release);
		return permission;
	}

	public static bool Release(this GPermissionHandle permission, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GPermissionExterns.g_permission_release(permission, cancellable, out error);
	}

	public static GPermissionHandle ReleaseAsync(this GPermissionHandle permission, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GPermissionExterns.g_permission_release_async(permission, cancellable, callback, user_data);
		return permission;
	}

	public static bool ReleaseFinish(this GPermissionHandle permission, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GPermissionExterns.g_permission_release_finish(permission, result, out error);
	}

}

internal class GPermissionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_permission_acquire(GPermissionHandle permission, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_permission_acquire_async(GPermissionHandle permission, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_permission_acquire_finish(GPermissionHandle permission, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_permission_get_allowed(GPermissionHandle permission);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_permission_get_can_acquire(GPermissionHandle permission);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_permission_get_can_release(GPermissionHandle permission);

	[DllImport(Libraries.Gio)]
	internal static extern void g_permission_impl_update(GPermissionHandle permission, bool allowed, bool can_acquire, bool can_release);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_permission_release(GPermissionHandle permission, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_permission_release_async(GPermissionHandle permission, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_permission_release_finish(GPermissionHandle permission, GAsyncResultHandle result, out GErrorHandle error);

}
