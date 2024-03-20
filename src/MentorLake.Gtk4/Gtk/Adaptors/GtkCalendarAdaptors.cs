using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCalendarAdaptors
{
	public static GtkCalendarHandle SelectDay(this GtkCalendarHandle self, GDateTimeHandle date)
	{
		GtkCalendarExterns.gtk_calendar_select_day(self, date);
		return self;
	}

	public static GtkCalendarHandle MarkDay(this GtkCalendarHandle calendar, uint day)
	{
		GtkCalendarExterns.gtk_calendar_mark_day(calendar, day);
		return calendar;
	}

	public static GtkCalendarHandle UnmarkDay(this GtkCalendarHandle calendar, uint day)
	{
		GtkCalendarExterns.gtk_calendar_unmark_day(calendar, day);
		return calendar;
	}

	public static GtkCalendarHandle ClearMarks(this GtkCalendarHandle calendar)
	{
		GtkCalendarExterns.gtk_calendar_clear_marks(calendar);
		return calendar;
	}

	public static GtkCalendarHandle SetShowWeekNumbers(this GtkCalendarHandle self, int value)
	{
		GtkCalendarExterns.gtk_calendar_set_show_week_numbers(self, value);
		return self;
	}

	public static int GetShowWeekNumbers(this GtkCalendarHandle self)
	{
		return GtkCalendarExterns.gtk_calendar_get_show_week_numbers(self);
	}

	public static GtkCalendarHandle SetShowHeading(this GtkCalendarHandle self, int value)
	{
		GtkCalendarExterns.gtk_calendar_set_show_heading(self, value);
		return self;
	}

	public static int GetShowHeading(this GtkCalendarHandle self)
	{
		return GtkCalendarExterns.gtk_calendar_get_show_heading(self);
	}

	public static GtkCalendarHandle SetShowDayNames(this GtkCalendarHandle self, int value)
	{
		GtkCalendarExterns.gtk_calendar_set_show_day_names(self, value);
		return self;
	}

	public static int GetShowDayNames(this GtkCalendarHandle self)
	{
		return GtkCalendarExterns.gtk_calendar_get_show_day_names(self);
	}

	public static GDateTimeHandle GetDate(this GtkCalendarHandle self)
	{
		return GtkCalendarExterns.gtk_calendar_get_date(self);
	}

	public static int GetDayIsMarked(this GtkCalendarHandle calendar, uint day)
	{
		return GtkCalendarExterns.gtk_calendar_get_day_is_marked(calendar, day);
	}
}
