using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GTimeZoneExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_time_zone_ref")]
    internal static extern GTimeZoneHandle g_time_zone_ref(this GTimeZoneHandle tz);
    [DllImport(Libraries.GLib, EntryPoint = "g_time_zone_unref")]
    internal static extern void g_time_zone_unref(this GTimeZoneHandle tz);
    [DllImport(Libraries.GLib, EntryPoint = "g_time_zone_find_interval")]
    internal static extern int g_time_zone_find_interval(this GTimeZoneHandle tz, GTimeType type, nint time_);
    [DllImport(Libraries.GLib, EntryPoint = "g_time_zone_adjust_time")]
    internal static extern int g_time_zone_adjust_time(this GTimeZoneHandle tz, GTimeType type, ref nint time_);
    [DllImport(Libraries.GLib, EntryPoint = "g_time_zone_get_abbreviation")]
    internal static extern string g_time_zone_get_abbreviation(this GTimeZoneHandle tz, int interval);
    [DllImport(Libraries.GLib, EntryPoint = "g_time_zone_get_offset")]
    internal static extern int g_time_zone_get_offset(this GTimeZoneHandle tz, int interval);
    [DllImport(Libraries.GLib, EntryPoint = "g_time_zone_is_dst")]
    internal static extern int g_time_zone_is_dst(this GTimeZoneHandle tz, int interval);
    [DllImport(Libraries.GLib, EntryPoint = "g_time_zone_get_identifier")]
    internal static extern string g_time_zone_get_identifier(this GTimeZoneHandle tz);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_new_now")]
    internal static extern GDateTimeHandle g_date_time_new_now(this GTimeZoneHandle tz);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_new")]
    internal static extern GDateTimeHandle g_date_time_new(this GTimeZoneHandle tz, int year, int month, int day, int hour, int minute, double seconds);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GTimeZoneHandle g_time_zone_new(string identifier);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GTimeZoneHandle g_time_zone_new_identifier(string identifier);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GTimeZoneHandle g_time_zone_new_utc();
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GTimeZoneHandle g_time_zone_new_local();
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GTimeZoneHandle g_time_zone_new_offset(int seconds);
}
