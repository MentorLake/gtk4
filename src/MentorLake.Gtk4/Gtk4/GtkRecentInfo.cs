namespace MentorLake.Gtk4.Gtk4;

public class GtkRecentInfoHandle : BaseSafeHandle
{
}


public static class GtkRecentInfoHandleExtensions
{
	public static GAppInfoHandle CreateAppInfo(this GtkRecentInfoHandle info, string app_name, out GErrorHandle error)
	{
		return GtkRecentInfoExterns.gtk_recent_info_create_app_info(info, app_name, out error);
	}

	public static bool Exists(this GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_exists(info);
	}

	public static GDateTimeHandle GetAdded(this GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_added(info);
	}

	public static int GetAge(this GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_age(info);
	}

	public static bool GetApplicationInfo(this GtkRecentInfoHandle info, string app_name, out string app_exec, out uint count, out GDateTimeHandle stamp)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_application_info(info, app_name, out app_exec, out count, out stamp);
	}

	public static IntPtr GetApplications(this GtkRecentInfoHandle info, out UIntPtr length)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_applications(info, out length);
	}

	public static string GetDescription(this GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_description(info);
	}

	public static string GetDisplayName(this GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_display_name(info);
	}

	public static GIconHandle GetGicon(this GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_gicon(info);
	}

	public static IntPtr GetGroups(this GtkRecentInfoHandle info, out UIntPtr length)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_groups(info, out length);
	}

	public static string GetMimeType(this GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_mime_type(info);
	}

	public static GDateTimeHandle GetModified(this GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_modified(info);
	}

	public static bool GetPrivateHint(this GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_private_hint(info);
	}

	public static string GetShortName(this GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_short_name(info);
	}

	public static string GetUri(this GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_uri(info);
	}

	public static string GetUriDisplay(this GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_uri_display(info);
	}

	public static GDateTimeHandle GetVisited(this GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_get_visited(info);
	}

	public static bool HasApplication(this GtkRecentInfoHandle info, string app_name)
	{
		return GtkRecentInfoExterns.gtk_recent_info_has_application(info, app_name);
	}

	public static bool HasGroup(this GtkRecentInfoHandle info, string group_name)
	{
		return GtkRecentInfoExterns.gtk_recent_info_has_group(info, group_name);
	}

	public static bool IsLocal(this GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_is_local(info);
	}

	public static string LastApplication(this GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_last_application(info);
	}

	public static bool Match(this GtkRecentInfoHandle info_a, GtkRecentInfoHandle info_b)
	{
		return GtkRecentInfoExterns.gtk_recent_info_match(info_a, info_b);
	}

	public static GtkRecentInfoHandle Ref(this GtkRecentInfoHandle info)
	{
		return GtkRecentInfoExterns.gtk_recent_info_ref(info);
	}

	public static GtkRecentInfoHandle Unref(this GtkRecentInfoHandle info)
	{
		GtkRecentInfoExterns.gtk_recent_info_unref(info);
		return info;
	}

}
internal class GtkRecentInfoExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GAppInfoHandle gtk_recent_info_create_app_info(GtkRecentInfoHandle info, string app_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_recent_info_exists(GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk4)]
	internal static extern GDateTimeHandle gtk_recent_info_get_added(GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_recent_info_get_age(GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_recent_info_get_application_info(GtkRecentInfoHandle info, string app_name, out string app_exec, out uint count, out GDateTimeHandle stamp);

	[DllImport(Libraries.Gtk4)]
	internal static extern IntPtr gtk_recent_info_get_applications(GtkRecentInfoHandle info, out UIntPtr length);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_get_description(GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_get_display_name(GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk4)]
	internal static extern GIconHandle gtk_recent_info_get_gicon(GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk4)]
	internal static extern IntPtr gtk_recent_info_get_groups(GtkRecentInfoHandle info, out UIntPtr length);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_get_mime_type(GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk4)]
	internal static extern GDateTimeHandle gtk_recent_info_get_modified(GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_recent_info_get_private_hint(GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_recent_info_get_short_name(GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_recent_info_get_uri(GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_recent_info_get_uri_display(GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk4)]
	internal static extern GDateTimeHandle gtk_recent_info_get_visited(GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_recent_info_has_application(GtkRecentInfoHandle info, string app_name);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_recent_info_has_group(GtkRecentInfoHandle info, string group_name);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_recent_info_is_local(GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_recent_info_last_application(GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_recent_info_match(GtkRecentInfoHandle info_a, GtkRecentInfoHandle info_b);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkRecentInfoHandle gtk_recent_info_ref(GtkRecentInfoHandle info);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_recent_info_unref(GtkRecentInfoHandle info);

}

public struct GtkRecentInfo
{
}
