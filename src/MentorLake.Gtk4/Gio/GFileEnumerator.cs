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

public class GFileEnumeratorHandle : GObjectHandle
{
}

public static class GFileEnumeratorHandleExtensions
{
	public static bool Close(this GFileEnumeratorHandle enumerator, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileEnumeratorExterns.g_file_enumerator_close(enumerator, cancellable, out error);
	}

	public static GFileEnumeratorHandle CloseAsync(this GFileEnumeratorHandle enumerator, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileEnumeratorExterns.g_file_enumerator_close_async(enumerator, io_priority, cancellable, callback, user_data);
		return enumerator;
	}

	public static bool CloseFinish(this GFileEnumeratorHandle enumerator, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileEnumeratorExterns.g_file_enumerator_close_finish(enumerator, result, out error);
	}

	public static GFileHandle GetChild(this GFileEnumeratorHandle enumerator, GFileInfoHandle info)
	{
		return GFileEnumeratorExterns.g_file_enumerator_get_child(enumerator, info);
	}

	public static GFileHandle GetContainer(this GFileEnumeratorHandle enumerator)
	{
		return GFileEnumeratorExterns.g_file_enumerator_get_container(enumerator);
	}

	public static bool HasPending(this GFileEnumeratorHandle enumerator)
	{
		return GFileEnumeratorExterns.g_file_enumerator_has_pending(enumerator);
	}

	public static bool IsClosed(this GFileEnumeratorHandle enumerator)
	{
		return GFileEnumeratorExterns.g_file_enumerator_is_closed(enumerator);
	}

	public static bool Iterate(this GFileEnumeratorHandle direnum, out GFileInfoHandle out_info, out GFileHandle out_child, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileEnumeratorExterns.g_file_enumerator_iterate(direnum, out out_info, out out_child, cancellable, out error);
	}

	public static GFileInfoHandle NextFile(this GFileEnumeratorHandle enumerator, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileEnumeratorExterns.g_file_enumerator_next_file(enumerator, cancellable, out error);
	}

	public static GFileEnumeratorHandle NextFilesAsync(this GFileEnumeratorHandle enumerator, int num_files, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileEnumeratorExterns.g_file_enumerator_next_files_async(enumerator, num_files, io_priority, cancellable, callback, user_data);
		return enumerator;
	}

	public static GListHandle NextFilesFinish(this GFileEnumeratorHandle enumerator, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileEnumeratorExterns.g_file_enumerator_next_files_finish(enumerator, result, out error);
	}

	public static GFileEnumeratorHandle SetPending(this GFileEnumeratorHandle enumerator, bool pending)
	{
		GFileEnumeratorExterns.g_file_enumerator_set_pending(enumerator, pending);
		return enumerator;
	}

}

internal class GFileEnumeratorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_enumerator_close(GFileEnumeratorHandle enumerator, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_enumerator_close_async(GFileEnumeratorHandle enumerator, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_enumerator_close_finish(GFileEnumeratorHandle enumerator, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_file_enumerator_get_child(GFileEnumeratorHandle enumerator, GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_file_enumerator_get_container(GFileEnumeratorHandle enumerator);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_enumerator_has_pending(GFileEnumeratorHandle enumerator);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_enumerator_is_closed(GFileEnumeratorHandle enumerator);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_enumerator_iterate(GFileEnumeratorHandle direnum, out GFileInfoHandle out_info, out GFileHandle out_child, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileInfoHandle g_file_enumerator_next_file(GFileEnumeratorHandle enumerator, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_enumerator_next_files_async(GFileEnumeratorHandle enumerator, int num_files, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GListHandle g_file_enumerator_next_files_finish(GFileEnumeratorHandle enumerator, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_enumerator_set_pending(GFileEnumeratorHandle enumerator, bool pending);

}
