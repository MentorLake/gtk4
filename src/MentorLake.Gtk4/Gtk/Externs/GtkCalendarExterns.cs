using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCalendarExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_calendar_select_day")]
    internal static extern void gtk_calendar_select_day(this GtkCalendarHandle self, GDateTimeHandle date);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_calendar_mark_day")]
    internal static extern void gtk_calendar_mark_day(this GtkCalendarHandle calendar, uint day);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_calendar_unmark_day")]
    internal static extern void gtk_calendar_unmark_day(this GtkCalendarHandle calendar, uint day);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_calendar_clear_marks")]
    internal static extern void gtk_calendar_clear_marks(this GtkCalendarHandle calendar);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_calendar_set_show_week_numbers")]
    internal static extern void gtk_calendar_set_show_week_numbers(this GtkCalendarHandle self, int value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_calendar_get_show_week_numbers")]
    internal static extern int gtk_calendar_get_show_week_numbers(this GtkCalendarHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_calendar_set_show_heading")]
    internal static extern void gtk_calendar_set_show_heading(this GtkCalendarHandle self, int value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_calendar_get_show_heading")]
    internal static extern int gtk_calendar_get_show_heading(this GtkCalendarHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_calendar_set_show_day_names")]
    internal static extern void gtk_calendar_set_show_day_names(this GtkCalendarHandle self, int value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_calendar_get_show_day_names")]
    internal static extern int gtk_calendar_get_show_day_names(this GtkCalendarHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_calendar_get_date")]
    internal static extern GDateTimeHandle gtk_calendar_get_date(this GtkCalendarHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_calendar_get_day_is_marked")]
    internal static extern int gtk_calendar_get_day_is_marked(this GtkCalendarHandle calendar, uint day);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkCalendarHandle gtk_calendar_new();
}
