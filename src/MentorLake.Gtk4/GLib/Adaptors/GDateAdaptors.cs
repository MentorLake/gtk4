using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GDateAdaptors
{
	public static GDateHandle Free(this GDateHandle date)
	{
		GDateExterns.g_date_free(date);
		return date;
	}

	public static GDateHandle Copy(this GDateHandle date)
	{
		return GDateExterns.g_date_copy(date);
	}

	public static int Valid(this GDateHandle date)
	{
		return GDateExterns.g_date_valid(date);
	}

	public static GDateWeekday GetWeekday(this GDateHandle date)
	{
		return GDateExterns.g_date_get_weekday(date);
	}

	public static GDateMonth GetMonth(this GDateHandle date)
	{
		return GDateExterns.g_date_get_month(date);
	}

	public static GDateYear GetYear(this GDateHandle date)
	{
		return GDateExterns.g_date_get_year(date);
	}

	public static GDateDay GetDay(this GDateHandle date)
	{
		return GDateExterns.g_date_get_day(date);
	}

	public static uint GetJulian(this GDateHandle date)
	{
		return GDateExterns.g_date_get_julian(date);
	}

	public static uint GetDayOfYear(this GDateHandle date)
	{
		return GDateExterns.g_date_get_day_of_year(date);
	}

	public static uint GetMondayWeekOfYear(this GDateHandle date)
	{
		return GDateExterns.g_date_get_monday_week_of_year(date);
	}

	public static uint GetSundayWeekOfYear(this GDateHandle date)
	{
		return GDateExterns.g_date_get_sunday_week_of_year(date);
	}

	public static uint GetIso8601WeekOfYear(this GDateHandle date)
	{
		return GDateExterns.g_date_get_iso8601_week_of_year(date);
	}

	public static GDateHandle Clear(this GDateHandle date, uint n_dates)
	{
		GDateExterns.g_date_clear(date, n_dates);
		return date;
	}

	public static GDateHandle SetParse(this GDateHandle date, string str)
	{
		GDateExterns.g_date_set_parse(date, str);
		return date;
	}

	public static GDateHandle SetTimeT(this GDateHandle date, time_t timet)
	{
		GDateExterns.g_date_set_time_t(date, timet);
		return date;
	}

	public static GDateHandle SetTimeVal(this GDateHandle date, GTimeValHandle timeval)
	{
		GDateExterns.g_date_set_time_val(date, timeval);
		return date;
	}

	public static GDateHandle SetTime(this GDateHandle date, GTime time_)
	{
		GDateExterns.g_date_set_time(date, time_);
		return date;
	}

	public static GDateHandle SetMonth(this GDateHandle date, GDateMonth month)
	{
		GDateExterns.g_date_set_month(date, month);
		return date;
	}

	public static GDateHandle SetDay(this GDateHandle date, GDateDay day)
	{
		GDateExterns.g_date_set_day(date, day);
		return date;
	}

	public static GDateHandle SetYear(this GDateHandle date, GDateYear year)
	{
		GDateExterns.g_date_set_year(date, year);
		return date;
	}

	public static GDateHandle SetDmy(this GDateHandle date, GDateDay day, GDateMonth month, GDateYear y)
	{
		GDateExterns.g_date_set_dmy(date, day, month, y);
		return date;
	}

	public static GDateHandle SetJulian(this GDateHandle date, uint julian_date)
	{
		GDateExterns.g_date_set_julian(date, julian_date);
		return date;
	}

	public static int IsFirstOfMonth(this GDateHandle date)
	{
		return GDateExterns.g_date_is_first_of_month(date);
	}

	public static int IsLastOfMonth(this GDateHandle date)
	{
		return GDateExterns.g_date_is_last_of_month(date);
	}

	public static GDateHandle AddDays(this GDateHandle date, uint n_days)
	{
		GDateExterns.g_date_add_days(date, n_days);
		return date;
	}

	public static GDateHandle SubtractDays(this GDateHandle date, uint n_days)
	{
		GDateExterns.g_date_subtract_days(date, n_days);
		return date;
	}

	public static GDateHandle AddMonths(this GDateHandle date, uint n_months)
	{
		GDateExterns.g_date_add_months(date, n_months);
		return date;
	}

	public static GDateHandle SubtractMonths(this GDateHandle date, uint n_months)
	{
		GDateExterns.g_date_subtract_months(date, n_months);
		return date;
	}

	public static GDateHandle AddYears(this GDateHandle date, uint n_years)
	{
		GDateExterns.g_date_add_years(date, n_years);
		return date;
	}

	public static GDateHandle SubtractYears(this GDateHandle date, uint n_years)
	{
		GDateExterns.g_date_subtract_years(date, n_years);
		return date;
	}

	public static int DaysBetween(this GDateHandle date1, GDateHandle date2)
	{
		return GDateExterns.g_date_days_between(date1, date2);
	}

	public static int Compare(this GDateHandle lhs, GDateHandle rhs)
	{
		return GDateExterns.g_date_compare(lhs, rhs);
	}

	public static GDateHandle ToStructTm(this GDateHandle date, IntPtr tm)
	{
		GDateExterns.g_date_to_struct_tm(date, tm);
		return date;
	}

	public static GDateHandle Clamp(this GDateHandle date, GDateHandle min_date, GDateHandle max_date)
	{
		GDateExterns.g_date_clamp(date, min_date, max_date);
		return date;
	}

	public static GDateHandle Order(this GDateHandle date1, GDateHandle date2)
	{
		GDateExterns.g_date_order(date1, date2);
		return date1;
	}

	public static GDateHandle NewDmy(GDateDay day, GDateMonth month, GDateYear year)
	{
		return GDateExterns.g_date_new_dmy(day, month, year);
	}

	public static GDateHandle NewJulian(uint julian_day)
	{
		return GDateExterns.g_date_new_julian(julian_day);
	}
}
