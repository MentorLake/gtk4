using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GDateTimeExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_unref")]
    internal static extern void g_date_time_unref(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_ref")]
    internal static extern GDateTimeHandle g_date_time_ref(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_add")]
    internal static extern GDateTimeHandle g_date_time_add(this GDateTimeHandle datetime, GTimeSpan timespan);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_add_years")]
    internal static extern GDateTimeHandle g_date_time_add_years(this GDateTimeHandle datetime, int years);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_add_months")]
    internal static extern GDateTimeHandle g_date_time_add_months(this GDateTimeHandle datetime, int months);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_add_weeks")]
    internal static extern GDateTimeHandle g_date_time_add_weeks(this GDateTimeHandle datetime, int weeks);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_add_days")]
    internal static extern GDateTimeHandle g_date_time_add_days(this GDateTimeHandle datetime, int days);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_add_hours")]
    internal static extern GDateTimeHandle g_date_time_add_hours(this GDateTimeHandle datetime, int hours);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_add_minutes")]
    internal static extern GDateTimeHandle g_date_time_add_minutes(this GDateTimeHandle datetime, int minutes);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_add_seconds")]
    internal static extern GDateTimeHandle g_date_time_add_seconds(this GDateTimeHandle datetime, double seconds);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_add_full")]
    internal static extern GDateTimeHandle g_date_time_add_full(this GDateTimeHandle datetime, int years, int months, int days, int hours, int minutes, double seconds);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_difference")]
    internal static extern GTimeSpan g_date_time_difference(this GDateTimeHandle end, GDateTimeHandle begin);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_get_ymd")]
    internal static extern void g_date_time_get_ymd(this GDateTimeHandle datetime, out int year, out int month, out int day);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_get_year")]
    internal static extern int g_date_time_get_year(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_get_month")]
    internal static extern int g_date_time_get_month(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_get_day_of_month")]
    internal static extern int g_date_time_get_day_of_month(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_get_week_numbering_year")]
    internal static extern int g_date_time_get_week_numbering_year(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_get_week_of_year")]
    internal static extern int g_date_time_get_week_of_year(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_get_day_of_week")]
    internal static extern int g_date_time_get_day_of_week(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_get_day_of_year")]
    internal static extern int g_date_time_get_day_of_year(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_get_hour")]
    internal static extern int g_date_time_get_hour(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_get_minute")]
    internal static extern int g_date_time_get_minute(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_get_second")]
    internal static extern int g_date_time_get_second(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_get_microsecond")]
    internal static extern int g_date_time_get_microsecond(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_get_seconds")]
    internal static extern double g_date_time_get_seconds(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_to_unix")]
    internal static extern nint g_date_time_to_unix(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_to_timeval")]
    [Obsolete]
    internal static extern int g_date_time_to_timeval(this GDateTimeHandle datetime, GTimeValHandle tv);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_get_utc_offset")]
    internal static extern GTimeSpan g_date_time_get_utc_offset(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_get_timezone")]
    internal static extern GTimeZoneHandle g_date_time_get_timezone(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_get_timezone_abbreviation")]
    internal static extern string g_date_time_get_timezone_abbreviation(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_is_daylight_savings")]
    internal static extern int g_date_time_is_daylight_savings(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_to_timezone")]
    internal static extern GDateTimeHandle g_date_time_to_timezone(this GDateTimeHandle datetime, GTimeZoneHandle tz);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_to_local")]
    internal static extern GDateTimeHandle g_date_time_to_local(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_to_utc")]
    internal static extern GDateTimeHandle g_date_time_to_utc(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_format")]
    internal static extern string g_date_time_format(this GDateTimeHandle datetime, string format);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_time_format_iso8601")]
    internal static extern string g_date_time_format_iso8601(this GDateTimeHandle datetime);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GDateTimeHandle g_date_time_new_now_local();
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GDateTimeHandle g_date_time_new_now_utc();
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GDateTimeHandle g_date_time_new_from_unix_local(nint t);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GDateTimeHandle g_date_time_new_from_unix_utc(nint t);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GDateTimeHandle g_date_time_new_from_timeval_local(GTimeValHandle tv);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GDateTimeHandle g_date_time_new_from_timeval_utc(GTimeValHandle tv);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GDateTimeHandle g_date_time_new_from_iso8601(string text, GTimeZoneHandle default_tz);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GDateTimeHandle g_date_time_new_local(int year, int month, int day, int hour, int minute, double seconds);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GDateTimeHandle g_date_time_new_utc(int year, int month, int day, int hour, int minute, double seconds);
}
