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

public interface GFileHandle
{
}

public static class GFileHandleExtensions
{
	public static GFileOutputStreamHandle AppendTo(this GFileHandle file, GFileCreateFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_append_to(file, flags, cancellable, out error);
	}

	public static GFileHandle AppendToAsync(this GFileHandle file, GFileCreateFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_append_to_async(file, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static GFileOutputStreamHandle AppendToFinish(this GFileHandle file, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GFileExterns.g_file_append_to_finish(file, res, out error);
	}

	public static string BuildAttributeListForCopy(this GFileHandle file, GFileCopyFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_build_attribute_list_for_copy(file, flags, cancellable, out error);
	}

	public static bool Copy(this GFileHandle source, GFileHandle destination, GFileCopyFlags flags, GCancellableHandle cancellable, GFileProgressCallback progress_callback, IntPtr progress_callback_data, out GErrorHandle error)
	{
		return GFileExterns.g_file_copy(source, destination, flags, cancellable, progress_callback, progress_callback_data, out error);
	}

	public static GFileHandle CopyAsync(this GFileHandle source, GFileHandle destination, GFileCopyFlags flags, int io_priority, GCancellableHandle cancellable, GFileProgressCallback progress_callback, IntPtr progress_callback_data, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_copy_async(source, destination, flags, io_priority, cancellable, progress_callback, progress_callback_data, callback, user_data);
		return source;
	}

	public static bool CopyAttributes(this GFileHandle source, GFileHandle destination, GFileCopyFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_copy_attributes(source, destination, flags, cancellable, out error);
	}

	public static bool CopyFinish(this GFileHandle file, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GFileExterns.g_file_copy_finish(file, res, out error);
	}

	public static GFileOutputStreamHandle Create(this GFileHandle file, GFileCreateFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_create(file, flags, cancellable, out error);
	}

	public static GFileHandle CreateAsync(this GFileHandle file, GFileCreateFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_create_async(file, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static GFileOutputStreamHandle CreateFinish(this GFileHandle file, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GFileExterns.g_file_create_finish(file, res, out error);
	}

	public static GFileIOStreamHandle CreateReadwrite(this GFileHandle file, GFileCreateFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_create_readwrite(file, flags, cancellable, out error);
	}

	public static GFileHandle CreateReadwriteAsync(this GFileHandle file, GFileCreateFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_create_readwrite_async(file, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static GFileIOStreamHandle CreateReadwriteFinish(this GFileHandle file, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GFileExterns.g_file_create_readwrite_finish(file, res, out error);
	}

	public static bool Delete(this GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_delete(file, cancellable, out error);
	}

	public static GFileHandle DeleteAsync(this GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_delete_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static bool DeleteFinish(this GFileHandle file, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileExterns.g_file_delete_finish(file, result, out error);
	}

	public static GFileHandle Dup(this GFileHandle file)
	{
		return GFileExterns.g_file_dup(file);
	}

	public static GFileHandle EjectMountable(this GFileHandle file, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_eject_mountable(file, flags, cancellable, callback, user_data);
		return file;
	}

	public static bool EjectMountableFinish(this GFileHandle file, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileExterns.g_file_eject_mountable_finish(file, result, out error);
	}

	public static GFileHandle EjectMountableWithOperation(this GFileHandle file, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_eject_mountable_with_operation(file, flags, mount_operation, cancellable, callback, user_data);
		return file;
	}

	public static bool EjectMountableWithOperationFinish(this GFileHandle file, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileExterns.g_file_eject_mountable_with_operation_finish(file, result, out error);
	}

	public static GFileEnumeratorHandle EnumerateChildren(this GFileHandle file, string attributes, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_enumerate_children(file, attributes, flags, cancellable, out error);
	}

	public static GFileHandle EnumerateChildrenAsync(this GFileHandle file, string attributes, GFileQueryInfoFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_enumerate_children_async(file, attributes, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static GFileEnumeratorHandle EnumerateChildrenFinish(this GFileHandle file, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GFileExterns.g_file_enumerate_children_finish(file, res, out error);
	}

	public static bool Equal(this GFileHandle file1, GFileHandle file2)
	{
		return GFileExterns.g_file_equal(file1, file2);
	}

	public static GMountHandle FindEnclosingMount(this GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_find_enclosing_mount(file, cancellable, out error);
	}

	public static GFileHandle FindEnclosingMountAsync(this GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_find_enclosing_mount_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static GMountHandle FindEnclosingMountFinish(this GFileHandle file, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GFileExterns.g_file_find_enclosing_mount_finish(file, res, out error);
	}

	public static string GetBasename(this GFileHandle file)
	{
		return GFileExterns.g_file_get_basename(file);
	}

	public static GFileHandle GetChild(this GFileHandle file, string name)
	{
		return GFileExterns.g_file_get_child(file, name);
	}

	public static GFileHandle GetChildForDisplayName(this GFileHandle file, string display_name, out GErrorHandle error)
	{
		return GFileExterns.g_file_get_child_for_display_name(file, display_name, out error);
	}

	public static GFileHandle GetParent(this GFileHandle file)
	{
		return GFileExterns.g_file_get_parent(file);
	}

	public static string GetParseName(this GFileHandle file)
	{
		return GFileExterns.g_file_get_parse_name(file);
	}

	public static string GetPath(this GFileHandle file)
	{
		return GFileExterns.g_file_get_path(file);
	}

	public static string GetRelativePath(this GFileHandle parent, GFileHandle descendant)
	{
		return GFileExterns.g_file_get_relative_path(parent, descendant);
	}

	public static string GetUri(this GFileHandle file)
	{
		return GFileExterns.g_file_get_uri(file);
	}

	public static string GetUriScheme(this GFileHandle file)
	{
		return GFileExterns.g_file_get_uri_scheme(file);
	}

	public static bool HasParent(this GFileHandle file, GFileHandle parent)
	{
		return GFileExterns.g_file_has_parent(file, parent);
	}

	public static bool HasPrefix(this GFileHandle file, GFileHandle prefix)
	{
		return GFileExterns.g_file_has_prefix(file, prefix);
	}

	public static bool HasUriScheme(this GFileHandle file, string uri_scheme)
	{
		return GFileExterns.g_file_has_uri_scheme(file, uri_scheme);
	}

	public static uint Hash(this IntPtr file)
	{
		return GFileExterns.g_file_hash(file);
	}

	public static bool IsNative(this GFileHandle file)
	{
		return GFileExterns.g_file_is_native(file);
	}

	public static GBytesHandle LoadBytes(this GFileHandle file, GCancellableHandle cancellable, out string etag_out, out GErrorHandle error)
	{
		return GFileExterns.g_file_load_bytes(file, cancellable, out etag_out, out error);
	}

	public static GFileHandle LoadBytesAsync(this GFileHandle file, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_load_bytes_async(file, cancellable, callback, user_data);
		return file;
	}

	public static GBytesHandle LoadBytesFinish(this GFileHandle file, GAsyncResultHandle result, out string etag_out, out GErrorHandle error)
	{
		return GFileExterns.g_file_load_bytes_finish(file, result, out etag_out, out error);
	}

	public static bool LoadContents(this GFileHandle file, GCancellableHandle cancellable, out string contents, out int length, out string etag_out, out GErrorHandle error)
	{
		return GFileExterns.g_file_load_contents(file, cancellable, out contents, out length, out etag_out, out error);
	}

	public static GFileHandle LoadContentsAsync(this GFileHandle file, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_load_contents_async(file, cancellable, callback, user_data);
		return file;
	}

	public static bool LoadContentsFinish(this GFileHandle file, GAsyncResultHandle res, out string contents, out int length, out string etag_out, out GErrorHandle error)
	{
		return GFileExterns.g_file_load_contents_finish(file, res, out contents, out length, out etag_out, out error);
	}

	public static GFileHandle LoadPartialContentsAsync(this GFileHandle file, GCancellableHandle cancellable, GFileReadMoreCallback read_more_callback, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_load_partial_contents_async(file, cancellable, read_more_callback, callback, user_data);
		return file;
	}

	public static bool LoadPartialContentsFinish(this GFileHandle file, GAsyncResultHandle res, out string contents, out int length, out string etag_out, out GErrorHandle error)
	{
		return GFileExterns.g_file_load_partial_contents_finish(file, res, out contents, out length, out etag_out, out error);
	}

	public static bool MakeDirectory(this GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_make_directory(file, cancellable, out error);
	}

	public static GFileHandle MakeDirectoryAsync(this GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_make_directory_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static bool MakeDirectoryFinish(this GFileHandle file, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileExterns.g_file_make_directory_finish(file, result, out error);
	}

	public static bool MakeDirectoryWithParents(this GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_make_directory_with_parents(file, cancellable, out error);
	}

	public static bool MakeSymbolicLink(this GFileHandle file, string symlink_value, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_make_symbolic_link(file, symlink_value, cancellable, out error);
	}

	public static GFileHandle MakeSymbolicLinkAsync(this GFileHandle file, string symlink_value, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_make_symbolic_link_async(file, symlink_value, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static bool MakeSymbolicLinkFinish(this GFileHandle file, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileExterns.g_file_make_symbolic_link_finish(file, result, out error);
	}

	public static bool MeasureDiskUsage(this GFileHandle file, GFileMeasureFlags flags, GCancellableHandle cancellable, GFileMeasureProgressCallback progress_callback, IntPtr progress_data, out ulong disk_usage, out ulong num_dirs, out ulong num_files, out GErrorHandle error)
	{
		return GFileExterns.g_file_measure_disk_usage(file, flags, cancellable, progress_callback, progress_data, out disk_usage, out num_dirs, out num_files, out error);
	}

	public static GFileHandle MeasureDiskUsageAsync(this GFileHandle file, GFileMeasureFlags flags, int io_priority, GCancellableHandle cancellable, GFileMeasureProgressCallback progress_callback, IntPtr progress_data, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_measure_disk_usage_async(file, flags, io_priority, cancellable, progress_callback, progress_data, callback, user_data);
		return file;
	}

	public static bool MeasureDiskUsageFinish(this GFileHandle file, GAsyncResultHandle result, out ulong disk_usage, out ulong num_dirs, out ulong num_files, out GErrorHandle error)
	{
		return GFileExterns.g_file_measure_disk_usage_finish(file, result, out disk_usage, out num_dirs, out num_files, out error);
	}

	public static GFileMonitorHandle Monitor(this GFileHandle file, GFileMonitorFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_monitor(file, flags, cancellable, out error);
	}

	public static GFileMonitorHandle MonitorDirectory(this GFileHandle file, GFileMonitorFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_monitor_directory(file, flags, cancellable, out error);
	}

	public static GFileMonitorHandle MonitorFile(this GFileHandle file, GFileMonitorFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_monitor_file(file, flags, cancellable, out error);
	}

	public static GFileHandle MountEnclosingVolume(this GFileHandle location, GMountMountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_mount_enclosing_volume(location, flags, mount_operation, cancellable, callback, user_data);
		return location;
	}

	public static bool MountEnclosingVolumeFinish(this GFileHandle location, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileExterns.g_file_mount_enclosing_volume_finish(location, result, out error);
	}

	public static GFileHandle MountMountable(this GFileHandle file, GMountMountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_mount_mountable(file, flags, mount_operation, cancellable, callback, user_data);
		return file;
	}

	public static GFileHandle MountMountableFinish(this GFileHandle file, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileExterns.g_file_mount_mountable_finish(file, result, out error);
	}

	public static bool Move(this GFileHandle source, GFileHandle destination, GFileCopyFlags flags, GCancellableHandle cancellable, GFileProgressCallback progress_callback, IntPtr progress_callback_data, out GErrorHandle error)
	{
		return GFileExterns.g_file_move(source, destination, flags, cancellable, progress_callback, progress_callback_data, out error);
	}

	public static GFileHandle MoveAsync(this GFileHandle source, GFileHandle destination, GFileCopyFlags flags, int io_priority, GCancellableHandle cancellable, GFileProgressCallback progress_callback, IntPtr progress_callback_data, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_move_async(source, destination, flags, io_priority, cancellable, progress_callback, progress_callback_data, callback, user_data);
		return source;
	}

	public static bool MoveFinish(this GFileHandle file, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileExterns.g_file_move_finish(file, result, out error);
	}

	public static GFileIOStreamHandle OpenReadwrite(this GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_open_readwrite(file, cancellable, out error);
	}

	public static GFileHandle OpenReadwriteAsync(this GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_open_readwrite_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static GFileIOStreamHandle OpenReadwriteFinish(this GFileHandle file, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GFileExterns.g_file_open_readwrite_finish(file, res, out error);
	}

	public static string PeekPath(this GFileHandle file)
	{
		return GFileExterns.g_file_peek_path(file);
	}

	public static GFileHandle PollMountable(this GFileHandle file, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_poll_mountable(file, cancellable, callback, user_data);
		return file;
	}

	public static bool PollMountableFinish(this GFileHandle file, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileExterns.g_file_poll_mountable_finish(file, result, out error);
	}

	public static GAppInfoHandle QueryDefaultHandler(this GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_query_default_handler(file, cancellable, out error);
	}

	public static GFileHandle QueryDefaultHandlerAsync(this GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_query_default_handler_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static GAppInfoHandle QueryDefaultHandlerFinish(this GFileHandle file, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileExterns.g_file_query_default_handler_finish(file, result, out error);
	}

	public static bool QueryExists(this GFileHandle file, GCancellableHandle cancellable)
	{
		return GFileExterns.g_file_query_exists(file, cancellable);
	}

	public static GFileType QueryFileType(this GFileHandle file, GFileQueryInfoFlags flags, GCancellableHandle cancellable)
	{
		return GFileExterns.g_file_query_file_type(file, flags, cancellable);
	}

	public static GFileInfoHandle QueryFilesystemInfo(this GFileHandle file, string attributes, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_query_filesystem_info(file, attributes, cancellable, out error);
	}

	public static GFileHandle QueryFilesystemInfoAsync(this GFileHandle file, string attributes, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_query_filesystem_info_async(file, attributes, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static GFileInfoHandle QueryFilesystemInfoFinish(this GFileHandle file, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GFileExterns.g_file_query_filesystem_info_finish(file, res, out error);
	}

	public static GFileInfoHandle QueryInfo(this GFileHandle file, string attributes, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_query_info(file, attributes, flags, cancellable, out error);
	}

	public static GFileHandle QueryInfoAsync(this GFileHandle file, string attributes, GFileQueryInfoFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_query_info_async(file, attributes, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static GFileInfoHandle QueryInfoFinish(this GFileHandle file, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GFileExterns.g_file_query_info_finish(file, res, out error);
	}

	public static GFileAttributeInfoListHandle QuerySettableAttributes(this GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_query_settable_attributes(file, cancellable, out error);
	}

	public static GFileAttributeInfoListHandle QueryWritableNamespaces(this GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_query_writable_namespaces(file, cancellable, out error);
	}

	public static GFileInputStreamHandle Read(this GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_read(file, cancellable, out error);
	}

	public static GFileHandle ReadAsync(this GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_read_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static GFileInputStreamHandle ReadFinish(this GFileHandle file, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GFileExterns.g_file_read_finish(file, res, out error);
	}

	public static GFileOutputStreamHandle Replace(this GFileHandle file, string etag, bool make_backup, GFileCreateFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_replace(file, etag, make_backup, flags, cancellable, out error);
	}

	public static GFileHandle ReplaceAsync(this GFileHandle file, string etag, bool make_backup, GFileCreateFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_replace_async(file, etag, make_backup, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static bool ReplaceContents(this GFileHandle file, string contents, int length, string etag, bool make_backup, GFileCreateFlags flags, out string new_etag, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_replace_contents(file, contents, length, etag, make_backup, flags, out new_etag, cancellable, out error);
	}

	public static GFileHandle ReplaceContentsAsync(this GFileHandle file, string contents, int length, string etag, bool make_backup, GFileCreateFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_replace_contents_async(file, contents, length, etag, make_backup, flags, cancellable, callback, user_data);
		return file;
	}

	public static GFileHandle ReplaceContentsBytesAsync(this GFileHandle file, GBytesHandle contents, string etag, bool make_backup, GFileCreateFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_replace_contents_bytes_async(file, contents, etag, make_backup, flags, cancellable, callback, user_data);
		return file;
	}

	public static bool ReplaceContentsFinish(this GFileHandle file, GAsyncResultHandle res, out string new_etag, out GErrorHandle error)
	{
		return GFileExterns.g_file_replace_contents_finish(file, res, out new_etag, out error);
	}

	public static GFileOutputStreamHandle ReplaceFinish(this GFileHandle file, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GFileExterns.g_file_replace_finish(file, res, out error);
	}

	public static GFileIOStreamHandle ReplaceReadwrite(this GFileHandle file, string etag, bool make_backup, GFileCreateFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_replace_readwrite(file, etag, make_backup, flags, cancellable, out error);
	}

	public static GFileHandle ReplaceReadwriteAsync(this GFileHandle file, string etag, bool make_backup, GFileCreateFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_replace_readwrite_async(file, etag, make_backup, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static GFileIOStreamHandle ReplaceReadwriteFinish(this GFileHandle file, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GFileExterns.g_file_replace_readwrite_finish(file, res, out error);
	}

	public static GFileHandle ResolveRelativePath(this GFileHandle file, string relative_path)
	{
		return GFileExterns.g_file_resolve_relative_path(file, relative_path);
	}

	public static bool SetAttribute(this GFileHandle file, string attribute, GFileAttributeType type, IntPtr value_p, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_set_attribute(file, attribute, type, value_p, flags, cancellable, out error);
	}

	public static bool SetAttributeByteString(this GFileHandle file, string attribute, string value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_set_attribute_byte_string(file, attribute, value, flags, cancellable, out error);
	}

	public static bool SetAttributeInt32(this GFileHandle file, string attribute, int value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_set_attribute_int32(file, attribute, value, flags, cancellable, out error);
	}

	public static bool SetAttributeInt64(this GFileHandle file, string attribute, long value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_set_attribute_int64(file, attribute, value, flags, cancellable, out error);
	}

	public static bool SetAttributeString(this GFileHandle file, string attribute, string value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_set_attribute_string(file, attribute, value, flags, cancellable, out error);
	}

	public static bool SetAttributeUint32(this GFileHandle file, string attribute, uint value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_set_attribute_uint32(file, attribute, value, flags, cancellable, out error);
	}

	public static bool SetAttributeUint64(this GFileHandle file, string attribute, ulong value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_set_attribute_uint64(file, attribute, value, flags, cancellable, out error);
	}

	public static GFileHandle SetAttributesAsync(this GFileHandle file, GFileInfoHandle info, GFileQueryInfoFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_set_attributes_async(file, info, flags, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static bool SetAttributesFinish(this GFileHandle file, GAsyncResultHandle result, out GFileInfoHandle info, out GErrorHandle error)
	{
		return GFileExterns.g_file_set_attributes_finish(file, result, out info, out error);
	}

	public static bool SetAttributesFromInfo(this GFileHandle file, GFileInfoHandle info, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_set_attributes_from_info(file, info, flags, cancellable, out error);
	}

	public static GFileHandle SetDisplayName(this GFileHandle file, string display_name, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_set_display_name(file, display_name, cancellable, out error);
	}

	public static GFileHandle SetDisplayNameAsync(this GFileHandle file, string display_name, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_set_display_name_async(file, display_name, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static GFileHandle SetDisplayNameFinish(this GFileHandle file, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GFileExterns.g_file_set_display_name_finish(file, res, out error);
	}

	public static GFileHandle StartMountable(this GFileHandle file, GDriveStartFlags flags, GMountOperationHandle start_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_start_mountable(file, flags, start_operation, cancellable, callback, user_data);
		return file;
	}

	public static bool StartMountableFinish(this GFileHandle file, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileExterns.g_file_start_mountable_finish(file, result, out error);
	}

	public static GFileHandle StopMountable(this GFileHandle file, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_stop_mountable(file, flags, mount_operation, cancellable, callback, user_data);
		return file;
	}

	public static bool StopMountableFinish(this GFileHandle file, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileExterns.g_file_stop_mountable_finish(file, result, out error);
	}

	public static bool SupportsThreadContexts(this GFileHandle file)
	{
		return GFileExterns.g_file_supports_thread_contexts(file);
	}

	public static bool Trash(this GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GFileExterns.g_file_trash(file, cancellable, out error);
	}

	public static GFileHandle TrashAsync(this GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_trash_async(file, io_priority, cancellable, callback, user_data);
		return file;
	}

	public static bool TrashFinish(this GFileHandle file, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileExterns.g_file_trash_finish(file, result, out error);
	}

	public static GFileHandle UnmountMountable(this GFileHandle file, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_unmount_mountable(file, flags, cancellable, callback, user_data);
		return file;
	}

	public static bool UnmountMountableFinish(this GFileHandle file, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileExterns.g_file_unmount_mountable_finish(file, result, out error);
	}

	public static GFileHandle UnmountMountableWithOperation(this GFileHandle file, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GFileExterns.g_file_unmount_mountable_with_operation(file, flags, mount_operation, cancellable, callback, user_data);
		return file;
	}

	public static bool UnmountMountableWithOperationFinish(this GFileHandle file, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GFileExterns.g_file_unmount_mountable_with_operation_finish(file, result, out error);
	}

}

internal class GFileExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GFileOutputStreamHandle g_file_append_to(GFileHandle file, GFileCreateFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_append_to_async(GFileHandle file, GFileCreateFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GFileOutputStreamHandle g_file_append_to_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_build_attribute_list_for_copy(GFileHandle file, GFileCopyFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_copy(GFileHandle source, GFileHandle destination, GFileCopyFlags flags, GCancellableHandle cancellable, GFileProgressCallback progress_callback, IntPtr progress_callback_data, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_copy_async(GFileHandle source, GFileHandle destination, GFileCopyFlags flags, int io_priority, GCancellableHandle cancellable, GFileProgressCallback progress_callback, IntPtr progress_callback_data, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_copy_attributes(GFileHandle source, GFileHandle destination, GFileCopyFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_copy_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileOutputStreamHandle g_file_create(GFileHandle file, GFileCreateFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_create_async(GFileHandle file, GFileCreateFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GFileOutputStreamHandle g_file_create_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileIOStreamHandle g_file_create_readwrite(GFileHandle file, GFileCreateFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_create_readwrite_async(GFileHandle file, GFileCreateFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GFileIOStreamHandle g_file_create_readwrite_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_delete(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_delete_async(GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_delete_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_file_dup(GFileHandle file);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_eject_mountable(GFileHandle file, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_eject_mountable_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_eject_mountable_with_operation(GFileHandle file, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_eject_mountable_with_operation_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileEnumeratorHandle g_file_enumerate_children(GFileHandle file, string attributes, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_enumerate_children_async(GFileHandle file, string attributes, GFileQueryInfoFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GFileEnumeratorHandle g_file_enumerate_children_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_equal(GFileHandle file1, GFileHandle file2);

	[DllImport(Libraries.Gio)]
	internal static extern GMountHandle g_file_find_enclosing_mount(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_find_enclosing_mount_async(GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GMountHandle g_file_find_enclosing_mount_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_get_basename(GFileHandle file);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_file_get_child(GFileHandle file, string name);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_file_get_child_for_display_name(GFileHandle file, string display_name, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_file_get_parent(GFileHandle file);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_get_parse_name(GFileHandle file);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_get_path(GFileHandle file);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_get_relative_path(GFileHandle parent, GFileHandle descendant);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_get_uri(GFileHandle file);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_get_uri_scheme(GFileHandle file);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_has_parent(GFileHandle file, GFileHandle parent);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_has_prefix(GFileHandle file, GFileHandle prefix);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_has_uri_scheme(GFileHandle file, string uri_scheme);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_file_hash(IntPtr file);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_is_native(GFileHandle file);

	[DllImport(Libraries.Gio)]
	internal static extern GBytesHandle g_file_load_bytes(GFileHandle file, GCancellableHandle cancellable, out string etag_out, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_load_bytes_async(GFileHandle file, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GBytesHandle g_file_load_bytes_finish(GFileHandle file, GAsyncResultHandle result, out string etag_out, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_load_contents(GFileHandle file, GCancellableHandle cancellable, out string contents, out int length, out string etag_out, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_load_contents_async(GFileHandle file, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_load_contents_finish(GFileHandle file, GAsyncResultHandle res, out string contents, out int length, out string etag_out, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_load_partial_contents_async(GFileHandle file, GCancellableHandle cancellable, GFileReadMoreCallback read_more_callback, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_load_partial_contents_finish(GFileHandle file, GAsyncResultHandle res, out string contents, out int length, out string etag_out, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_make_directory(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_make_directory_async(GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_make_directory_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_make_directory_with_parents(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_make_symbolic_link(GFileHandle file, string symlink_value, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_make_symbolic_link_async(GFileHandle file, string symlink_value, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_make_symbolic_link_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_measure_disk_usage(GFileHandle file, GFileMeasureFlags flags, GCancellableHandle cancellable, GFileMeasureProgressCallback progress_callback, IntPtr progress_data, out ulong disk_usage, out ulong num_dirs, out ulong num_files, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_measure_disk_usage_async(GFileHandle file, GFileMeasureFlags flags, int io_priority, GCancellableHandle cancellable, GFileMeasureProgressCallback progress_callback, IntPtr progress_data, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_measure_disk_usage_finish(GFileHandle file, GAsyncResultHandle result, out ulong disk_usage, out ulong num_dirs, out ulong num_files, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileMonitorHandle g_file_monitor(GFileHandle file, GFileMonitorFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileMonitorHandle g_file_monitor_directory(GFileHandle file, GFileMonitorFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileMonitorHandle g_file_monitor_file(GFileHandle file, GFileMonitorFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_mount_enclosing_volume(GFileHandle location, GMountMountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_mount_enclosing_volume_finish(GFileHandle location, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_mount_mountable(GFileHandle file, GMountMountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_file_mount_mountable_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_move(GFileHandle source, GFileHandle destination, GFileCopyFlags flags, GCancellableHandle cancellable, GFileProgressCallback progress_callback, IntPtr progress_callback_data, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_move_async(GFileHandle source, GFileHandle destination, GFileCopyFlags flags, int io_priority, GCancellableHandle cancellable, GFileProgressCallback progress_callback, IntPtr progress_callback_data, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_move_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileIOStreamHandle g_file_open_readwrite(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_open_readwrite_async(GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GFileIOStreamHandle g_file_open_readwrite_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_peek_path(GFileHandle file);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_poll_mountable(GFileHandle file, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_poll_mountable_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GAppInfoHandle g_file_query_default_handler(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_query_default_handler_async(GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GAppInfoHandle g_file_query_default_handler_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_query_exists(GFileHandle file, GCancellableHandle cancellable);

	[DllImport(Libraries.Gio)]
	internal static extern GFileType g_file_query_file_type(GFileHandle file, GFileQueryInfoFlags flags, GCancellableHandle cancellable);

	[DllImport(Libraries.Gio)]
	internal static extern GFileInfoHandle g_file_query_filesystem_info(GFileHandle file, string attributes, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_query_filesystem_info_async(GFileHandle file, string attributes, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GFileInfoHandle g_file_query_filesystem_info_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileInfoHandle g_file_query_info(GFileHandle file, string attributes, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_query_info_async(GFileHandle file, string attributes, GFileQueryInfoFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GFileInfoHandle g_file_query_info_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileAttributeInfoListHandle g_file_query_settable_attributes(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileAttributeInfoListHandle g_file_query_writable_namespaces(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileInputStreamHandle g_file_read(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_read_async(GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GFileInputStreamHandle g_file_read_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileOutputStreamHandle g_file_replace(GFileHandle file, string etag, bool make_backup, GFileCreateFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_replace_async(GFileHandle file, string etag, bool make_backup, GFileCreateFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_replace_contents(GFileHandle file, string contents, int length, string etag, bool make_backup, GFileCreateFlags flags, out string new_etag, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_replace_contents_async(GFileHandle file, string contents, int length, string etag, bool make_backup, GFileCreateFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_replace_contents_bytes_async(GFileHandle file, GBytesHandle contents, string etag, bool make_backup, GFileCreateFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_replace_contents_finish(GFileHandle file, GAsyncResultHandle res, out string new_etag, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileOutputStreamHandle g_file_replace_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileIOStreamHandle g_file_replace_readwrite(GFileHandle file, string etag, bool make_backup, GFileCreateFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_replace_readwrite_async(GFileHandle file, string etag, bool make_backup, GFileCreateFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GFileIOStreamHandle g_file_replace_readwrite_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_file_resolve_relative_path(GFileHandle file, string relative_path);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_set_attribute(GFileHandle file, string attribute, GFileAttributeType type, IntPtr value_p, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_set_attribute_byte_string(GFileHandle file, string attribute, string value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_set_attribute_int32(GFileHandle file, string attribute, int value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_set_attribute_int64(GFileHandle file, string attribute, long value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_set_attribute_string(GFileHandle file, string attribute, string value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_set_attribute_uint32(GFileHandle file, string attribute, uint value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_set_attribute_uint64(GFileHandle file, string attribute, ulong value, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_set_attributes_async(GFileHandle file, GFileInfoHandle info, GFileQueryInfoFlags flags, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_set_attributes_finish(GFileHandle file, GAsyncResultHandle result, out GFileInfoHandle info, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_set_attributes_from_info(GFileHandle file, GFileInfoHandle info, GFileQueryInfoFlags flags, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_file_set_display_name(GFileHandle file, string display_name, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_set_display_name_async(GFileHandle file, string display_name, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_file_set_display_name_finish(GFileHandle file, GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_start_mountable(GFileHandle file, GDriveStartFlags flags, GMountOperationHandle start_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_start_mountable_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_stop_mountable(GFileHandle file, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_stop_mountable_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_supports_thread_contexts(GFileHandle file);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_trash(GFileHandle file, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_trash_async(GFileHandle file, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_trash_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_unmount_mountable(GFileHandle file, GMountUnmountFlags flags, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_unmount_mountable_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_unmount_mountable_with_operation(GFileHandle file, GMountUnmountFlags flags, GMountOperationHandle mount_operation, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_unmount_mountable_with_operation_finish(GFileHandle file, GAsyncResultHandle result, out GErrorHandle error);

}
