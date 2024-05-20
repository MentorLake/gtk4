namespace MentorLake.Gtk4.Gio;

public class GFileInfoHandle : GObjectHandle
{
	public static GFileInfoHandle New()
	{
		return GFileInfoExterns.g_file_info_new();
	}

}

public static class GFileInfoHandleExtensions
{
	public static GFileInfoHandle ClearStatus(this GFileInfoHandle info)
	{
		GFileInfoExterns.g_file_info_clear_status(info);
		return info;
	}

	public static GFileInfoHandle CopyInto(this GFileInfoHandle src_info, GFileInfoHandle dest_info)
	{
		GFileInfoExterns.g_file_info_copy_into(src_info, dest_info);
		return src_info;
	}

	public static GFileInfoHandle Dup(this GFileInfoHandle other)
	{
		return GFileInfoExterns.g_file_info_dup(other);
	}

	public static GDateTimeHandle GetAccessDateTime(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_access_date_time(info);
	}

	public static string GetAttributeAsString(this GFileInfoHandle info, string attribute)
	{
		return GFileInfoExterns.g_file_info_get_attribute_as_string(info, attribute);
	}

	public static bool GetAttributeBoolean(this GFileInfoHandle info, string attribute)
	{
		return GFileInfoExterns.g_file_info_get_attribute_boolean(info, attribute);
	}

	public static string GetAttributeByteString(this GFileInfoHandle info, string attribute)
	{
		return GFileInfoExterns.g_file_info_get_attribute_byte_string(info, attribute);
	}

	public static bool GetAttributeData(this GFileInfoHandle info, string attribute, out GFileAttributeType type, out IntPtr value_pp, out GFileAttributeStatus status)
	{
		return GFileInfoExterns.g_file_info_get_attribute_data(info, attribute, out type, out value_pp, out status);
	}

	public static string GetAttributeFilePath(this GFileInfoHandle info, string attribute)
	{
		return GFileInfoExterns.g_file_info_get_attribute_file_path(info, attribute);
	}

	public static int GetAttributeInt32(this GFileInfoHandle info, string attribute)
	{
		return GFileInfoExterns.g_file_info_get_attribute_int32(info, attribute);
	}

	public static long GetAttributeInt64(this GFileInfoHandle info, string attribute)
	{
		return GFileInfoExterns.g_file_info_get_attribute_int64(info, attribute);
	}

	public static GObjectHandle GetAttributeObject(this GFileInfoHandle info, string attribute)
	{
		return GFileInfoExterns.g_file_info_get_attribute_object(info, attribute);
	}

	public static GFileAttributeStatus GetAttributeStatus(this GFileInfoHandle info, string attribute)
	{
		return GFileInfoExterns.g_file_info_get_attribute_status(info, attribute);
	}

	public static string GetAttributeString(this GFileInfoHandle info, string attribute)
	{
		return GFileInfoExterns.g_file_info_get_attribute_string(info, attribute);
	}

	public static IntPtr GetAttributeStringv(this GFileInfoHandle info, string attribute)
	{
		return GFileInfoExterns.g_file_info_get_attribute_stringv(info, attribute);
	}

	public static GFileAttributeType GetAttributeType(this GFileInfoHandle info, string attribute)
	{
		return GFileInfoExterns.g_file_info_get_attribute_type(info, attribute);
	}

	public static uint GetAttributeUint32(this GFileInfoHandle info, string attribute)
	{
		return GFileInfoExterns.g_file_info_get_attribute_uint32(info, attribute);
	}

	public static ulong GetAttributeUint64(this GFileInfoHandle info, string attribute)
	{
		return GFileInfoExterns.g_file_info_get_attribute_uint64(info, attribute);
	}

	public static string GetContentType(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_content_type(info);
	}

	public static GDateTimeHandle GetCreationDateTime(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_creation_date_time(info);
	}

	public static GDateTimeHandle GetDeletionDate(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_deletion_date(info);
	}

	public static string GetDisplayName(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_display_name(info);
	}

	public static string GetEditName(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_edit_name(info);
	}

	public static string GetEtag(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_etag(info);
	}

	public static GFileType GetFileType(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_file_type(info);
	}

	public static GIconHandle GetIcon(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_icon(info);
	}

	public static bool GetIsBackup(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_is_backup(info);
	}

	public static bool GetIsHidden(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_is_hidden(info);
	}

	public static bool GetIsSymlink(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_is_symlink(info);
	}

	public static GDateTimeHandle GetModificationDateTime(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_modification_date_time(info);
	}

	public static GFileInfoHandle GetModificationTime(this GFileInfoHandle info, out GTimeVal result)
	{
		GFileInfoExterns.g_file_info_get_modification_time(info, out result);
		return info;
	}

	public static string GetName(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_name(info);
	}

	public static int GetSize(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_size(info);
	}

	public static int GetSortOrder(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_sort_order(info);
	}

	public static GIconHandle GetSymbolicIcon(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_symbolic_icon(info);
	}

	public static string GetSymlinkTarget(this GFileInfoHandle info)
	{
		return GFileInfoExterns.g_file_info_get_symlink_target(info);
	}

	public static bool HasAttribute(this GFileInfoHandle info, string attribute)
	{
		return GFileInfoExterns.g_file_info_has_attribute(info, attribute);
	}

	public static bool HasNamespace(this GFileInfoHandle info, string name_space)
	{
		return GFileInfoExterns.g_file_info_has_namespace(info, name_space);
	}

	public static IntPtr ListAttributes(this GFileInfoHandle info, string name_space)
	{
		return GFileInfoExterns.g_file_info_list_attributes(info, name_space);
	}

	public static GFileInfoHandle RemoveAttribute(this GFileInfoHandle info, string attribute)
	{
		GFileInfoExterns.g_file_info_remove_attribute(info, attribute);
		return info;
	}

	public static GFileInfoHandle SetAccessDateTime(this GFileInfoHandle info, GDateTimeHandle atime)
	{
		GFileInfoExterns.g_file_info_set_access_date_time(info, atime);
		return info;
	}

	public static GFileInfoHandle SetAttribute(this GFileInfoHandle info, string attribute, GFileAttributeType type, IntPtr value_p)
	{
		GFileInfoExterns.g_file_info_set_attribute(info, attribute, type, value_p);
		return info;
	}

	public static GFileInfoHandle SetAttributeBoolean(this GFileInfoHandle info, string attribute, bool attr_value)
	{
		GFileInfoExterns.g_file_info_set_attribute_boolean(info, attribute, attr_value);
		return info;
	}

	public static GFileInfoHandle SetAttributeByteString(this GFileInfoHandle info, string attribute, string attr_value)
	{
		GFileInfoExterns.g_file_info_set_attribute_byte_string(info, attribute, attr_value);
		return info;
	}

	public static GFileInfoHandle SetAttributeFilePath(this GFileInfoHandle info, string attribute, string attr_value)
	{
		GFileInfoExterns.g_file_info_set_attribute_file_path(info, attribute, attr_value);
		return info;
	}

	public static GFileInfoHandle SetAttributeInt32(this GFileInfoHandle info, string attribute, int attr_value)
	{
		GFileInfoExterns.g_file_info_set_attribute_int32(info, attribute, attr_value);
		return info;
	}

	public static GFileInfoHandle SetAttributeInt64(this GFileInfoHandle info, string attribute, long attr_value)
	{
		GFileInfoExterns.g_file_info_set_attribute_int64(info, attribute, attr_value);
		return info;
	}

	public static GFileInfoHandle SetAttributeMask(this GFileInfoHandle info, GFileAttributeMatcherHandle mask)
	{
		GFileInfoExterns.g_file_info_set_attribute_mask(info, mask);
		return info;
	}

	public static GFileInfoHandle SetAttributeObject(this GFileInfoHandle info, string attribute, GObjectHandle attr_value)
	{
		GFileInfoExterns.g_file_info_set_attribute_object(info, attribute, attr_value);
		return info;
	}

	public static bool SetAttributeStatus(this GFileInfoHandle info, string attribute, GFileAttributeStatus status)
	{
		return GFileInfoExterns.g_file_info_set_attribute_status(info, attribute, status);
	}

	public static GFileInfoHandle SetAttributeString(this GFileInfoHandle info, string attribute, string attr_value)
	{
		GFileInfoExterns.g_file_info_set_attribute_string(info, attribute, attr_value);
		return info;
	}

	public static GFileInfoHandle SetAttributeStringv(this GFileInfoHandle info, string attribute, string[] attr_value)
	{
		GFileInfoExterns.g_file_info_set_attribute_stringv(info, attribute, attr_value);
		return info;
	}

	public static GFileInfoHandle SetAttributeUint32(this GFileInfoHandle info, string attribute, uint attr_value)
	{
		GFileInfoExterns.g_file_info_set_attribute_uint32(info, attribute, attr_value);
		return info;
	}

	public static GFileInfoHandle SetAttributeUint64(this GFileInfoHandle info, string attribute, ulong attr_value)
	{
		GFileInfoExterns.g_file_info_set_attribute_uint64(info, attribute, attr_value);
		return info;
	}

	public static GFileInfoHandle SetContentType(this GFileInfoHandle info, string content_type)
	{
		GFileInfoExterns.g_file_info_set_content_type(info, content_type);
		return info;
	}

	public static GFileInfoHandle SetCreationDateTime(this GFileInfoHandle info, GDateTimeHandle creation_time)
	{
		GFileInfoExterns.g_file_info_set_creation_date_time(info, creation_time);
		return info;
	}

	public static GFileInfoHandle SetDisplayName(this GFileInfoHandle info, string display_name)
	{
		GFileInfoExterns.g_file_info_set_display_name(info, display_name);
		return info;
	}

	public static GFileInfoHandle SetEditName(this GFileInfoHandle info, string edit_name)
	{
		GFileInfoExterns.g_file_info_set_edit_name(info, edit_name);
		return info;
	}

	public static GFileInfoHandle SetFileType(this GFileInfoHandle info, GFileType type)
	{
		GFileInfoExterns.g_file_info_set_file_type(info, type);
		return info;
	}

	public static GFileInfoHandle SetIcon(this GFileInfoHandle info, GIconHandle icon)
	{
		GFileInfoExterns.g_file_info_set_icon(info, icon);
		return info;
	}

	public static GFileInfoHandle SetIsHidden(this GFileInfoHandle info, bool is_hidden)
	{
		GFileInfoExterns.g_file_info_set_is_hidden(info, is_hidden);
		return info;
	}

	public static GFileInfoHandle SetIsSymlink(this GFileInfoHandle info, bool is_symlink)
	{
		GFileInfoExterns.g_file_info_set_is_symlink(info, is_symlink);
		return info;
	}

	public static GFileInfoHandle SetModificationDateTime(this GFileInfoHandle info, GDateTimeHandle mtime)
	{
		GFileInfoExterns.g_file_info_set_modification_date_time(info, mtime);
		return info;
	}

	public static GFileInfoHandle SetModificationTime(this GFileInfoHandle info, GTimeValHandle mtime)
	{
		GFileInfoExterns.g_file_info_set_modification_time(info, mtime);
		return info;
	}

	public static GFileInfoHandle SetName(this GFileInfoHandle info, string name)
	{
		GFileInfoExterns.g_file_info_set_name(info, name);
		return info;
	}

	public static GFileInfoHandle SetSize(this GFileInfoHandle info, int size)
	{
		GFileInfoExterns.g_file_info_set_size(info, size);
		return info;
	}

	public static GFileInfoHandle SetSortOrder(this GFileInfoHandle info, int sort_order)
	{
		GFileInfoExterns.g_file_info_set_sort_order(info, sort_order);
		return info;
	}

	public static GFileInfoHandle SetSymbolicIcon(this GFileInfoHandle info, GIconHandle icon)
	{
		GFileInfoExterns.g_file_info_set_symbolic_icon(info, icon);
		return info;
	}

	public static GFileInfoHandle SetSymlinkTarget(this GFileInfoHandle info, string symlink_target)
	{
		GFileInfoExterns.g_file_info_set_symlink_target(info, symlink_target);
		return info;
	}

	public static GFileInfoHandle UnsetAttributeMask(this GFileInfoHandle info)
	{
		GFileInfoExterns.g_file_info_unset_attribute_mask(info);
		return info;
	}

}

internal class GFileInfoExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GFileInfoHandle g_file_info_new();

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_clear_status(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_copy_into(GFileInfoHandle src_info, GFileInfoHandle dest_info);

	[DllImport(Libraries.Gio)]
	internal static extern GFileInfoHandle g_file_info_dup(GFileInfoHandle other);

	[DllImport(Libraries.Gio)]
	internal static extern GDateTimeHandle g_file_info_get_access_date_time(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_info_get_attribute_as_string(GFileInfoHandle info, string attribute);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_info_get_attribute_boolean(GFileInfoHandle info, string attribute);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_info_get_attribute_byte_string(GFileInfoHandle info, string attribute);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_info_get_attribute_data(GFileInfoHandle info, string attribute, out GFileAttributeType type, out IntPtr value_pp, out GFileAttributeStatus status);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_info_get_attribute_file_path(GFileInfoHandle info, string attribute);

	[DllImport(Libraries.Gio)]
	internal static extern int g_file_info_get_attribute_int32(GFileInfoHandle info, string attribute);

	[DllImport(Libraries.Gio)]
	internal static extern long g_file_info_get_attribute_int64(GFileInfoHandle info, string attribute);

	[DllImport(Libraries.Gio)]
	internal static extern GObjectHandle g_file_info_get_attribute_object(GFileInfoHandle info, string attribute);

	[DllImport(Libraries.Gio)]
	internal static extern GFileAttributeStatus g_file_info_get_attribute_status(GFileInfoHandle info, string attribute);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_info_get_attribute_string(GFileInfoHandle info, string attribute);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_file_info_get_attribute_stringv(GFileInfoHandle info, string attribute);

	[DllImport(Libraries.Gio)]
	internal static extern GFileAttributeType g_file_info_get_attribute_type(GFileInfoHandle info, string attribute);

	[DllImport(Libraries.Gio)]
	internal static extern uint g_file_info_get_attribute_uint32(GFileInfoHandle info, string attribute);

	[DllImport(Libraries.Gio)]
	internal static extern ulong g_file_info_get_attribute_uint64(GFileInfoHandle info, string attribute);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_info_get_content_type(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern GDateTimeHandle g_file_info_get_creation_date_time(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern GDateTimeHandle g_file_info_get_deletion_date(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_info_get_display_name(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_info_get_edit_name(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_info_get_etag(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern GFileType g_file_info_get_file_type(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern GIconHandle g_file_info_get_icon(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_info_get_is_backup(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_info_get_is_hidden(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_info_get_is_symlink(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern GDateTimeHandle g_file_info_get_modification_date_time(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_get_modification_time(GFileInfoHandle info, out GTimeVal result);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_info_get_name(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern int g_file_info_get_size(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern int g_file_info_get_sort_order(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern GIconHandle g_file_info_get_symbolic_icon(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern string g_file_info_get_symlink_target(GFileInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_info_has_attribute(GFileInfoHandle info, string attribute);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_info_has_namespace(GFileInfoHandle info, string name_space);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_file_info_list_attributes(GFileInfoHandle info, string name_space);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_remove_attribute(GFileInfoHandle info, string attribute);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_access_date_time(GFileInfoHandle info, GDateTimeHandle atime);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_attribute(GFileInfoHandle info, string attribute, GFileAttributeType type, IntPtr value_p);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_attribute_boolean(GFileInfoHandle info, string attribute, bool attr_value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_attribute_byte_string(GFileInfoHandle info, string attribute, string attr_value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_attribute_file_path(GFileInfoHandle info, string attribute, string attr_value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_attribute_int32(GFileInfoHandle info, string attribute, int attr_value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_attribute_int64(GFileInfoHandle info, string attribute, long attr_value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_attribute_mask(GFileInfoHandle info, GFileAttributeMatcherHandle mask);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_attribute_object(GFileInfoHandle info, string attribute, GObjectHandle attr_value);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_info_set_attribute_status(GFileInfoHandle info, string attribute, GFileAttributeStatus status);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_attribute_string(GFileInfoHandle info, string attribute, string attr_value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_attribute_stringv(GFileInfoHandle info, string attribute, string[] attr_value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_attribute_uint32(GFileInfoHandle info, string attribute, uint attr_value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_attribute_uint64(GFileInfoHandle info, string attribute, ulong attr_value);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_content_type(GFileInfoHandle info, string content_type);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_creation_date_time(GFileInfoHandle info, GDateTimeHandle creation_time);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_display_name(GFileInfoHandle info, string display_name);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_edit_name(GFileInfoHandle info, string edit_name);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_file_type(GFileInfoHandle info, GFileType type);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_icon(GFileInfoHandle info, GIconHandle icon);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_is_hidden(GFileInfoHandle info, bool is_hidden);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_is_symlink(GFileInfoHandle info, bool is_symlink);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_modification_date_time(GFileInfoHandle info, GDateTimeHandle mtime);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_modification_time(GFileInfoHandle info, GTimeValHandle mtime);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_name(GFileInfoHandle info, string name);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_size(GFileInfoHandle info, int size);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_sort_order(GFileInfoHandle info, int sort_order);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_symbolic_icon(GFileInfoHandle info, GIconHandle icon);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_set_symlink_target(GFileInfoHandle info, string symlink_target);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_info_unset_attribute_mask(GFileInfoHandle info);

}
