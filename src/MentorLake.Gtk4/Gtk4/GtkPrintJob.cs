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

public class GtkPrintJobHandle : GObjectHandle
{
	public static GtkPrintJobHandle New(string title, GtkPrinterHandle printer, GtkPrintSettingsHandle settings, GtkPageSetupHandle page_setup)
	{
		return GtkPrintJobExterns.gtk_print_job_new(title, printer, settings, page_setup);
	}

}

public static class GtkPrintJobSignalExtensions
{
	public static GtkPrintJobHandle Signal_StatusChanged(this GtkPrintJobHandle instance, GtkPrintJobSignalDelegates.StatusChanged handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "status_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkPrintJobSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void StatusChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintJobHandle>))] GtkPrintJobHandle self, IntPtr user_data);
}


public static class GtkPrintJobHandleExtensions
{
	public static bool GetCollate(this GtkPrintJobHandle job)
	{
		return GtkPrintJobExterns.gtk_print_job_get_collate(job);
	}

	public static uint GetNUp(this GtkPrintJobHandle job)
	{
		return GtkPrintJobExterns.gtk_print_job_get_n_up(job);
	}

	public static GtkNumberUpLayout GetNUpLayout(this GtkPrintJobHandle job)
	{
		return GtkPrintJobExterns.gtk_print_job_get_n_up_layout(job);
	}

	public static int GetNumCopies(this GtkPrintJobHandle job)
	{
		return GtkPrintJobExterns.gtk_print_job_get_num_copies(job);
	}

	public static GtkPageRange[] GetPageRanges(this GtkPrintJobHandle job, out int n_ranges)
	{
		return GtkPrintJobExterns.gtk_print_job_get_page_ranges(job, out n_ranges);
	}

	public static GtkPageSet GetPageSet(this GtkPrintJobHandle job)
	{
		return GtkPrintJobExterns.gtk_print_job_get_page_set(job);
	}

	public static GtkPrintPages GetPages(this GtkPrintJobHandle job)
	{
		return GtkPrintJobExterns.gtk_print_job_get_pages(job);
	}

	public static GtkPrinterHandle GetPrinter(this GtkPrintJobHandle job)
	{
		return GtkPrintJobExterns.gtk_print_job_get_printer(job);
	}

	public static bool GetReverse(this GtkPrintJobHandle job)
	{
		return GtkPrintJobExterns.gtk_print_job_get_reverse(job);
	}

	public static bool GetRotate(this GtkPrintJobHandle job)
	{
		return GtkPrintJobExterns.gtk_print_job_get_rotate(job);
	}

	public static double GetScale(this GtkPrintJobHandle job)
	{
		return GtkPrintJobExterns.gtk_print_job_get_scale(job);
	}

	public static GtkPrintSettingsHandle GetSettings(this GtkPrintJobHandle job)
	{
		return GtkPrintJobExterns.gtk_print_job_get_settings(job);
	}

	public static GtkPrintStatus GetStatus(this GtkPrintJobHandle job)
	{
		return GtkPrintJobExterns.gtk_print_job_get_status(job);
	}

	public static cairo_surface_tHandle GetSurface(this GtkPrintJobHandle job, out GErrorHandle error)
	{
		return GtkPrintJobExterns.gtk_print_job_get_surface(job, out error);
	}

	public static string GetTitle(this GtkPrintJobHandle job)
	{
		return GtkPrintJobExterns.gtk_print_job_get_title(job);
	}

	public static bool GetTrackPrintStatus(this GtkPrintJobHandle job)
	{
		return GtkPrintJobExterns.gtk_print_job_get_track_print_status(job);
	}

	public static GtkPrintJobHandle Send(this GtkPrintJobHandle job, GtkPrintJobCompleteFunc callback, IntPtr user_data, GDestroyNotify dnotify)
	{
		GtkPrintJobExterns.gtk_print_job_send(job, callback, user_data, dnotify);
		return job;
	}

	public static GtkPrintJobHandle SetCollate(this GtkPrintJobHandle job, bool collate)
	{
		GtkPrintJobExterns.gtk_print_job_set_collate(job, collate);
		return job;
	}

	public static GtkPrintJobHandle SetNUp(this GtkPrintJobHandle job, uint n_up)
	{
		GtkPrintJobExterns.gtk_print_job_set_n_up(job, n_up);
		return job;
	}

	public static GtkPrintJobHandle SetNUpLayout(this GtkPrintJobHandle job, GtkNumberUpLayout layout)
	{
		GtkPrintJobExterns.gtk_print_job_set_n_up_layout(job, layout);
		return job;
	}

	public static GtkPrintJobHandle SetNumCopies(this GtkPrintJobHandle job, int num_copies)
	{
		GtkPrintJobExterns.gtk_print_job_set_num_copies(job, num_copies);
		return job;
	}

	public static GtkPrintJobHandle SetPageRanges(this GtkPrintJobHandle job, GtkPageRange[] ranges, int n_ranges)
	{
		GtkPrintJobExterns.gtk_print_job_set_page_ranges(job, ranges, n_ranges);
		return job;
	}

	public static GtkPrintJobHandle SetPageSet(this GtkPrintJobHandle job, GtkPageSet page_set)
	{
		GtkPrintJobExterns.gtk_print_job_set_page_set(job, page_set);
		return job;
	}

	public static GtkPrintJobHandle SetPages(this GtkPrintJobHandle job, GtkPrintPages pages)
	{
		GtkPrintJobExterns.gtk_print_job_set_pages(job, pages);
		return job;
	}

	public static GtkPrintJobHandle SetReverse(this GtkPrintJobHandle job, bool reverse)
	{
		GtkPrintJobExterns.gtk_print_job_set_reverse(job, reverse);
		return job;
	}

	public static GtkPrintJobHandle SetRotate(this GtkPrintJobHandle job, bool rotate)
	{
		GtkPrintJobExterns.gtk_print_job_set_rotate(job, rotate);
		return job;
	}

	public static GtkPrintJobHandle SetScale(this GtkPrintJobHandle job, double scale)
	{
		GtkPrintJobExterns.gtk_print_job_set_scale(job, scale);
		return job;
	}

	public static bool SetSourceFd(this GtkPrintJobHandle job, int fd, out GErrorHandle error)
	{
		return GtkPrintJobExterns.gtk_print_job_set_source_fd(job, fd, out error);
	}

	public static bool SetSourceFile(this GtkPrintJobHandle job, string filename, out GErrorHandle error)
	{
		return GtkPrintJobExterns.gtk_print_job_set_source_file(job, filename, out error);
	}

	public static GtkPrintJobHandle SetTrackPrintStatus(this GtkPrintJobHandle job, bool track_status)
	{
		GtkPrintJobExterns.gtk_print_job_set_track_print_status(job, track_status);
		return job;
	}

}

internal class GtkPrintJobExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintJobHandle gtk_print_job_new(string title, GtkPrinterHandle printer, GtkPrintSettingsHandle settings, GtkPageSetupHandle page_setup);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_job_get_collate(GtkPrintJobHandle job);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_print_job_get_n_up(GtkPrintJobHandle job);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkNumberUpLayout gtk_print_job_get_n_up_layout(GtkPrintJobHandle job);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_print_job_get_num_copies(GtkPrintJobHandle job);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageRange[] gtk_print_job_get_page_ranges(GtkPrintJobHandle job, out int n_ranges);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageSet gtk_print_job_get_page_set(GtkPrintJobHandle job);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintPages gtk_print_job_get_pages(GtkPrintJobHandle job);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrinterHandle gtk_print_job_get_printer(GtkPrintJobHandle job);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_job_get_reverse(GtkPrintJobHandle job);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_job_get_rotate(GtkPrintJobHandle job);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_print_job_get_scale(GtkPrintJobHandle job);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintSettingsHandle gtk_print_job_get_settings(GtkPrintJobHandle job);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintStatus gtk_print_job_get_status(GtkPrintJobHandle job);

	[DllImport(Libraries.Gtk4)]
	internal static extern cairo_surface_tHandle gtk_print_job_get_surface(GtkPrintJobHandle job, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_job_get_title(GtkPrintJobHandle job);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_job_get_track_print_status(GtkPrintJobHandle job);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_job_send(GtkPrintJobHandle job, GtkPrintJobCompleteFunc callback, IntPtr user_data, GDestroyNotify dnotify);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_job_set_collate(GtkPrintJobHandle job, bool collate);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_job_set_n_up(GtkPrintJobHandle job, uint n_up);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_job_set_n_up_layout(GtkPrintJobHandle job, GtkNumberUpLayout layout);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_job_set_num_copies(GtkPrintJobHandle job, int num_copies);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_job_set_page_ranges(GtkPrintJobHandle job, GtkPageRange[] ranges, int n_ranges);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_job_set_page_set(GtkPrintJobHandle job, GtkPageSet page_set);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_job_set_pages(GtkPrintJobHandle job, GtkPrintPages pages);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_job_set_reverse(GtkPrintJobHandle job, bool reverse);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_job_set_rotate(GtkPrintJobHandle job, bool rotate);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_job_set_scale(GtkPrintJobHandle job, double scale);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_job_set_source_fd(GtkPrintJobHandle job, int fd, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_job_set_source_file(GtkPrintJobHandle job, string filename, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_job_set_track_print_status(GtkPrintJobHandle job, bool track_status);

}
