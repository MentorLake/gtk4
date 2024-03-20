using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkRecentInfoAdaptors
{
    public static GtkRecentInfoHandle Ref(this GtkRecentInfoHandle info)
    {
        return GtkRecentInfoExterns.gtk_recent_info_ref(info);
    }

    public static GtkRecentInfoHandle Unref(this GtkRecentInfoHandle info)
    {
        GtkRecentInfoExterns.gtk_recent_info_unref(info);
        return info;
    }

    public static string GetUri(this GtkRecentInfoHandle info)
    {
        return GtkRecentInfoExterns.gtk_recent_info_get_uri(info);
    }

    public static string GetDisplayName(this GtkRecentInfoHandle info)
    {
        return GtkRecentInfoExterns.gtk_recent_info_get_display_name(info);
    }

    public static string GetDescription(this GtkRecentInfoHandle info)
    {
        return GtkRecentInfoExterns.gtk_recent_info_get_description(info);
    }

    public static string GetMimeType(this GtkRecentInfoHandle info)
    {
        return GtkRecentInfoExterns.gtk_recent_info_get_mime_type(info);
    }

    public static GDateTimeHandle GetAdded(this GtkRecentInfoHandle info)
    {
        return GtkRecentInfoExterns.gtk_recent_info_get_added(info);
    }

    public static GDateTimeHandle GetModified(this GtkRecentInfoHandle info)
    {
        return GtkRecentInfoExterns.gtk_recent_info_get_modified(info);
    }

    public static GDateTimeHandle GetVisited(this GtkRecentInfoHandle info)
    {
        return GtkRecentInfoExterns.gtk_recent_info_get_visited(info);
    }

    public static int GetPrivateHint(this GtkRecentInfoHandle info)
    {
        return GtkRecentInfoExterns.gtk_recent_info_get_private_hint(info);
    }

    public static int GetApplicationInfo(this GtkRecentInfoHandle info, string app_name, out string[] app_exec, out uint count, out GDateTimeHandle stamp)
    {
        return GtkRecentInfoExterns.gtk_recent_info_get_application_info(info, app_name, out app_exec, out count, out stamp);
    }

    public static GAppInfoHandle CreateAppInfo(this GtkRecentInfoHandle info, string app_name, out GErrorHandle error)
    {
        return GtkRecentInfoExterns.gtk_recent_info_create_app_info(info, app_name, out error);
    }

    public static string[] GetApplications(this GtkRecentInfoHandle info, out nuint length)
    {
        return GtkRecentInfoExterns.gtk_recent_info_get_applications(info, out length);
    }

    public static string LastApplication(this GtkRecentInfoHandle info)
    {
        return GtkRecentInfoExterns.gtk_recent_info_last_application(info);
    }

    public static int HasApplication(this GtkRecentInfoHandle info, string app_name)
    {
        return GtkRecentInfoExterns.gtk_recent_info_has_application(info, app_name);
    }

    public static string[] GetGroups(this GtkRecentInfoHandle info, out nuint length)
    {
        return GtkRecentInfoExterns.gtk_recent_info_get_groups(info, out length);
    }

    public static int HasGroup(this GtkRecentInfoHandle info, string group_name)
    {
        return GtkRecentInfoExterns.gtk_recent_info_has_group(info, group_name);
    }

    public static GIconHandle GetGicon(this GtkRecentInfoHandle info)
    {
        return GtkRecentInfoExterns.gtk_recent_info_get_gicon(info);
    }

    public static string GetShortName(this GtkRecentInfoHandle info)
    {
        return GtkRecentInfoExterns.gtk_recent_info_get_short_name(info);
    }

    public static string GetUriDisplay(this GtkRecentInfoHandle info)
    {
        return GtkRecentInfoExterns.gtk_recent_info_get_uri_display(info);
    }

    public static int GetAge(this GtkRecentInfoHandle info)
    {
        return GtkRecentInfoExterns.gtk_recent_info_get_age(info);
    }

    public static int IsLocal(this GtkRecentInfoHandle info)
    {
        return GtkRecentInfoExterns.gtk_recent_info_is_local(info);
    }

    public static int Exists(this GtkRecentInfoHandle info)
    {
        return GtkRecentInfoExterns.gtk_recent_info_exists(info);
    }

    public static int Match(this GtkRecentInfoHandle info_a, GtkRecentInfoHandle info_b)
    {
        return GtkRecentInfoExterns.gtk_recent_info_match(info_a, info_b);
    }
}
