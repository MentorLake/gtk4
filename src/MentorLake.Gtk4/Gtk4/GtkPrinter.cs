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

public class GtkPrinterHandle : GObjectHandle
{
	public static GtkPrinterHandle New(string name, GtkPrintBackendHandle backend, bool virtual_)
	{
		return GtkPrinterExterns.gtk_printer_new(name, backend, virtual_);
	}

}

public class GtkPrinterSignal
{
	public string Value { get; set; }
	public GtkPrinterSignal(string value) => Value = value;
}

public static class GtkPrinterSignals
{
	public static GtkPrinterSignal DetailsAcquired = new("details-acquired");
}

public static class GtkPrinterHandleExtensions
{
	public static bool AcceptsPdf(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_accepts_pdf(printer);
	}

	public static bool AcceptsPs(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_accepts_ps(printer);
	}

	public static int Compare(this GtkPrinterHandle a, GtkPrinterHandle b)
	{
		return GtkPrinterExterns.gtk_printer_compare(a, b);
	}

	public static GtkPrintBackendHandle GetBackend(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_get_backend(printer);
	}

	public static GtkPrintCapabilities GetCapabilities(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_get_capabilities(printer);
	}

	public static GtkPageSetupHandle GetDefaultPageSize(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_get_default_page_size(printer);
	}

	public static string GetDescription(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_get_description(printer);
	}

	public static bool GetHardMargins(this GtkPrinterHandle printer, out double top, out double bottom, out double left, out double right)
	{
		return GtkPrinterExterns.gtk_printer_get_hard_margins(printer, out top, out bottom, out left, out right);
	}

	public static bool GetHardMarginsForPaperSize(this GtkPrinterHandle printer, GtkPaperSizeHandle paper_size, out double top, out double bottom, out double left, out double right)
	{
		return GtkPrinterExterns.gtk_printer_get_hard_margins_for_paper_size(printer, paper_size, out top, out bottom, out left, out right);
	}

	public static string GetIconName(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_get_icon_name(printer);
	}

	public static int GetJobCount(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_get_job_count(printer);
	}

	public static string GetLocation(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_get_location(printer);
	}

	public static string GetName(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_get_name(printer);
	}

	public static string GetStateMessage(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_get_state_message(printer);
	}

	public static bool HasDetails(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_has_details(printer);
	}

	public static bool IsAcceptingJobs(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_is_accepting_jobs(printer);
	}

	public static bool IsActive(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_is_active(printer);
	}

	public static bool IsDefault(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_is_default(printer);
	}

	public static bool IsPaused(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_is_paused(printer);
	}

	public static bool IsVirtual(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_is_virtual(printer);
	}

	public static GListHandle ListPapers(this GtkPrinterHandle printer)
	{
		return GtkPrinterExterns.gtk_printer_list_papers(printer);
	}

	public static GtkPrinterHandle RequestDetails(this GtkPrinterHandle printer)
	{
		GtkPrinterExterns.gtk_printer_request_details(printer);
		return printer;
	}

	public static GtkPrinterHandle Connect(this GtkPrinterHandle instance, GtkPrinterSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkPrinterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrinterHandle gtk_printer_new(string name, GtkPrintBackendHandle backend, bool virtual_);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_printer_accepts_pdf(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_printer_accepts_ps(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_printer_compare(GtkPrinterHandle a, GtkPrinterHandle b);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintBackendHandle gtk_printer_get_backend(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintCapabilities gtk_printer_get_capabilities(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageSetupHandle gtk_printer_get_default_page_size(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_printer_get_description(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_printer_get_hard_margins(GtkPrinterHandle printer, out double top, out double bottom, out double left, out double right);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_printer_get_hard_margins_for_paper_size(GtkPrinterHandle printer, GtkPaperSizeHandle paper_size, out double top, out double bottom, out double left, out double right);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_printer_get_icon_name(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_printer_get_job_count(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_printer_get_location(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_printer_get_name(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_printer_get_state_message(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_printer_has_details(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_printer_is_accepting_jobs(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_printer_is_active(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_printer_is_default(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_printer_is_paused(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_printer_is_virtual(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern GListHandle gtk_printer_list_papers(GtkPrinterHandle printer);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_printer_request_details(GtkPrinterHandle printer);
}
