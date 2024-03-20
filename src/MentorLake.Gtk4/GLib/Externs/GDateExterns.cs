using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GDateExterns
{
    [DllImport(Libraries.GLib, EntryPoint = "g_date_free")]
    internal static extern void g_date_free(this GDateHandle date);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_copy")]
    internal static extern GDateHandle g_date_copy(this GDateHandle date);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_valid")]
    internal static extern int g_date_valid(this GDateHandle date);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_get_weekday")]
    internal static extern GDateWeekday g_date_get_weekday(this GDateHandle date);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_get_month")]
    internal static extern GDateMonth g_date_get_month(this GDateHandle date);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_get_year")]
    internal static extern GDateYear g_date_get_year(this GDateHandle date);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_get_day")]
    internal static extern GDateDay g_date_get_day(this GDateHandle date);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_get_julian")]
    internal static extern uint g_date_get_julian(this GDateHandle date);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_get_day_of_year")]
    internal static extern uint g_date_get_day_of_year(this GDateHandle date);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_get_monday_week_of_year")]
    internal static extern uint g_date_get_monday_week_of_year(this GDateHandle date);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_get_sunday_week_of_year")]
    internal static extern uint g_date_get_sunday_week_of_year(this GDateHandle date);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_get_iso8601_week_of_year")]
    internal static extern uint g_date_get_iso8601_week_of_year(this GDateHandle date);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_clear")]
    internal static extern void g_date_clear(this GDateHandle date, uint n_dates);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_set_parse")]
    internal static extern void g_date_set_parse(this GDateHandle date, string str);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_set_time_t")]
    internal static extern void g_date_set_time_t(this GDateHandle date, time_t timet);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_set_time_val")]
    [Obsolete]
    internal static extern void g_date_set_time_val(this GDateHandle date, GTimeValHandle timeval);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_set_time")]
    [Obsolete]
    internal static extern void g_date_set_time(this GDateHandle date, GTime time_);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_set_month")]
    internal static extern void g_date_set_month(this GDateHandle date, GDateMonth month);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_set_day")]
    internal static extern void g_date_set_day(this GDateHandle date, GDateDay day);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_set_year")]
    internal static extern void g_date_set_year(this GDateHandle date, GDateYear year);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_set_dmy")]
    internal static extern void g_date_set_dmy(this GDateHandle date, GDateDay day, GDateMonth month, GDateYear y);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_set_julian")]
    internal static extern void g_date_set_julian(this GDateHandle date, uint julian_date);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_is_first_of_month")]
    internal static extern int g_date_is_first_of_month(this GDateHandle date);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_is_last_of_month")]
    internal static extern int g_date_is_last_of_month(this GDateHandle date);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_add_days")]
    internal static extern void g_date_add_days(this GDateHandle date, uint n_days);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_subtract_days")]
    internal static extern void g_date_subtract_days(this GDateHandle date, uint n_days);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_add_months")]
    internal static extern void g_date_add_months(this GDateHandle date, uint n_months);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_subtract_months")]
    internal static extern void g_date_subtract_months(this GDateHandle date, uint n_months);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_add_years")]
    internal static extern void g_date_add_years(this GDateHandle date, uint n_years);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_subtract_years")]
    internal static extern void g_date_subtract_years(this GDateHandle date, uint n_years);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_days_between")]
    internal static extern int g_date_days_between(this GDateHandle date1, GDateHandle date2);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_compare")]
    internal static extern int g_date_compare(this GDateHandle lhs, GDateHandle rhs);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_to_struct_tm")]
    internal static extern void g_date_to_struct_tm(this GDateHandle date, IntPtr tm);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_clamp")]
    internal static extern void g_date_clamp(this GDateHandle date, GDateHandle min_date, GDateHandle max_date);
    [DllImport(Libraries.GLib, EntryPoint = "g_date_order")]
    internal static extern void g_date_order(this GDateHandle date1, GDateHandle date2);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GDateHandle g_date_new();
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GDateHandle g_date_new_dmy(GDateDay day, GDateMonth month, GDateYear year);
    [DllImport(Libraries.GLib, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GDateHandle g_date_new_julian(uint julian_day);
}
