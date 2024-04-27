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

namespace MentorLake.Gtk4.Gtk4;

public class GtkCalendarHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkCalendarHandle New()
	{
		return GtkCalendarExterns.gtk_calendar_new();
	}

}

public static class GtkCalendarSignalExtensions
{
	public static GtkCalendarHandle Signal_DaySelected(this GtkCalendarHandle instance, GtkCalendarSignalDelegates.DaySelected handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "day_selected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkCalendarHandle Signal_NextMonth(this GtkCalendarHandle instance, GtkCalendarSignalDelegates.NextMonth handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "next_month", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkCalendarHandle Signal_NextYear(this GtkCalendarHandle instance, GtkCalendarSignalDelegates.NextYear handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "next_year", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkCalendarHandle Signal_PrevMonth(this GtkCalendarHandle instance, GtkCalendarSignalDelegates.PrevMonth handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "prev_month", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkCalendarHandle Signal_PrevYear(this GtkCalendarHandle instance, GtkCalendarSignalDelegates.PrevYear handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "prev_year", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkCalendarSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DaySelected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCalendarHandle>))] GtkCalendarHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void NextMonth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCalendarHandle>))] GtkCalendarHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void NextYear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCalendarHandle>))] GtkCalendarHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void PrevMonth([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCalendarHandle>))] GtkCalendarHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void PrevYear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCalendarHandle>))] GtkCalendarHandle self, IntPtr user_data);
}


public static class GtkCalendarHandleExtensions
{
	public static GtkCalendarHandle ClearMarks(this GtkCalendarHandle calendar)
	{
		GtkCalendarExterns.gtk_calendar_clear_marks(calendar);
		return calendar;
	}

	public static GDateTimeHandle GetDate(this GtkCalendarHandle self)
	{
		return GtkCalendarExterns.gtk_calendar_get_date(self);
	}

	public static int GetDay(this GtkCalendarHandle self)
	{
		return GtkCalendarExterns.gtk_calendar_get_day(self);
	}

	public static bool GetDayIsMarked(this GtkCalendarHandle calendar, uint day)
	{
		return GtkCalendarExterns.gtk_calendar_get_day_is_marked(calendar, day);
	}

	public static int GetMonth(this GtkCalendarHandle self)
	{
		return GtkCalendarExterns.gtk_calendar_get_month(self);
	}

	public static bool GetShowDayNames(this GtkCalendarHandle self)
	{
		return GtkCalendarExterns.gtk_calendar_get_show_day_names(self);
	}

	public static bool GetShowHeading(this GtkCalendarHandle self)
	{
		return GtkCalendarExterns.gtk_calendar_get_show_heading(self);
	}

	public static bool GetShowWeekNumbers(this GtkCalendarHandle self)
	{
		return GtkCalendarExterns.gtk_calendar_get_show_week_numbers(self);
	}

	public static int GetYear(this GtkCalendarHandle self)
	{
		return GtkCalendarExterns.gtk_calendar_get_year(self);
	}

	public static GtkCalendarHandle MarkDay(this GtkCalendarHandle calendar, uint day)
	{
		GtkCalendarExterns.gtk_calendar_mark_day(calendar, day);
		return calendar;
	}

	public static GtkCalendarHandle SelectDay(this GtkCalendarHandle self, GDateTimeHandle date)
	{
		GtkCalendarExterns.gtk_calendar_select_day(self, date);
		return self;
	}

	public static GtkCalendarHandle SetDay(this GtkCalendarHandle self, int day)
	{
		GtkCalendarExterns.gtk_calendar_set_day(self, day);
		return self;
	}

	public static GtkCalendarHandle SetMonth(this GtkCalendarHandle self, int month)
	{
		GtkCalendarExterns.gtk_calendar_set_month(self, month);
		return self;
	}

	public static GtkCalendarHandle SetShowDayNames(this GtkCalendarHandle self, bool value)
	{
		GtkCalendarExterns.gtk_calendar_set_show_day_names(self, value);
		return self;
	}

	public static GtkCalendarHandle SetShowHeading(this GtkCalendarHandle self, bool value)
	{
		GtkCalendarExterns.gtk_calendar_set_show_heading(self, value);
		return self;
	}

	public static GtkCalendarHandle SetShowWeekNumbers(this GtkCalendarHandle self, bool value)
	{
		GtkCalendarExterns.gtk_calendar_set_show_week_numbers(self, value);
		return self;
	}

	public static GtkCalendarHandle SetYear(this GtkCalendarHandle self, int year)
	{
		GtkCalendarExterns.gtk_calendar_set_year(self, year);
		return self;
	}

	public static GtkCalendarHandle UnmarkDay(this GtkCalendarHandle calendar, uint day)
	{
		GtkCalendarExterns.gtk_calendar_unmark_day(calendar, day);
		return calendar;
	}

}

internal class GtkCalendarExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCalendarHandle gtk_calendar_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_calendar_clear_marks(GtkCalendarHandle calendar);

	[DllImport(Libraries.Gtk4)]
	internal static extern GDateTimeHandle gtk_calendar_get_date(GtkCalendarHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_calendar_get_day(GtkCalendarHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_calendar_get_day_is_marked(GtkCalendarHandle calendar, uint day);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_calendar_get_month(GtkCalendarHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_calendar_get_show_day_names(GtkCalendarHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_calendar_get_show_heading(GtkCalendarHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_calendar_get_show_week_numbers(GtkCalendarHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_calendar_get_year(GtkCalendarHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_calendar_mark_day(GtkCalendarHandle calendar, uint day);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_calendar_select_day(GtkCalendarHandle self, GDateTimeHandle date);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_calendar_set_day(GtkCalendarHandle self, int day);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_calendar_set_month(GtkCalendarHandle self, int month);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_calendar_set_show_day_names(GtkCalendarHandle self, bool value);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_calendar_set_show_heading(GtkCalendarHandle self, bool value);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_calendar_set_show_week_numbers(GtkCalendarHandle self, bool value);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_calendar_set_year(GtkCalendarHandle self, int year);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_calendar_unmark_day(GtkCalendarHandle calendar, uint day);

}
