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

public class GtkPrintOperationHandle : GObjectHandle
{
	public static GtkPrintOperationHandle New()
	{
		return GtkPrintOperationExterns.gtk_print_operation_new();
	}
}

public class GtkPrintOperationSignal
{
	public string Value { get; set; }
	public GtkPrintOperationSignal(string value) => Value = value;
}

public static class GtkPrintOperationSignals
{
	public static GtkPrintOperationSignal BeginPrint = new("begin-print");
	public static GtkPrintOperationSignal CreateCustomWidget = new("create-custom-widget");
	public static GtkPrintOperationSignal CustomWidgetApply = new("custom-widget-apply");
	public static GtkPrintOperationSignal Done = new("done");
	public static GtkPrintOperationSignal DrawPage = new("draw-page");
	public static GtkPrintOperationSignal EndPrint = new("end-print");
	public static GtkPrintOperationSignal Paginate = new("paginate");
	public static GtkPrintOperationSignal Preview = new("preview");
	public static GtkPrintOperationSignal RequestPageSetup = new("request-page-setup");
	public static GtkPrintOperationSignal StatusChanged = new("status-changed");
	public static GtkPrintOperationSignal UpdateCustomWidget = new("update-custom-widget");
}

public static class GtkPrintOperationHandleExtensions
{
	public static GtkPrintOperationHandle Cancel(this GtkPrintOperationHandle op)
	{
		GtkPrintOperationExterns.gtk_print_operation_cancel(op);
		return op;
	}

	public static GtkPrintOperationHandle DrawPageFinish(this GtkPrintOperationHandle op)
	{
		GtkPrintOperationExterns.gtk_print_operation_draw_page_finish(op);
		return op;
	}

	public static GtkPageSetupHandle GetDefaultPageSetup(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_default_page_setup(op);
	}

	public static bool GetEmbedPageSetup(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_embed_page_setup(op);
	}

	public static GtkPrintOperationHandle GetError(this GtkPrintOperationHandle op, out GErrorHandle error)
	{
		GtkPrintOperationExterns.gtk_print_operation_get_error(op, out error);
		return op;
	}

	public static bool GetHasSelection(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_has_selection(op);
	}

	public static int GetNPagesToPrint(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_n_pages_to_print(op);
	}

	public static GtkPrintSettingsHandle GetPrintSettings(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_print_settings(op);
	}

	public static GtkPrintStatus GetStatus(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_status(op);
	}

	public static string GetStatusString(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_status_string(op);
	}

	public static bool GetSupportSelection(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_support_selection(op);
	}

	public static bool IsFinished(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_is_finished(op);
	}

	public static GtkPrintOperationResult Run(this GtkPrintOperationHandle op, GtkPrintOperationAction action, GtkWindowHandle parent, out GErrorHandle error)
	{
		return GtkPrintOperationExterns.gtk_print_operation_run(op, action, parent, out error);
	}

	public static GtkPrintOperationHandle SetAllowAsync(this GtkPrintOperationHandle op, bool allow_async)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_allow_async(op, allow_async);
		return op;
	}

	public static GtkPrintOperationHandle SetCurrentPage(this GtkPrintOperationHandle op, int current_page)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_current_page(op, current_page);
		return op;
	}

	public static GtkPrintOperationHandle SetCustomTabLabel(this GtkPrintOperationHandle op, string label)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_custom_tab_label(op, label);
		return op;
	}

	public static GtkPrintOperationHandle SetDefaultPageSetup(this GtkPrintOperationHandle op, GtkPageSetupHandle default_page_setup)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_default_page_setup(op, default_page_setup);
		return op;
	}

	public static GtkPrintOperationHandle SetDeferDrawing(this GtkPrintOperationHandle op)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_defer_drawing(op);
		return op;
	}

	public static GtkPrintOperationHandle SetEmbedPageSetup(this GtkPrintOperationHandle op, bool embed)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_embed_page_setup(op, embed);
		return op;
	}

	public static GtkPrintOperationHandle SetExportFilename(this GtkPrintOperationHandle op, string filename)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_export_filename(op, filename);
		return op;
	}

	public static GtkPrintOperationHandle SetHasSelection(this GtkPrintOperationHandle op, bool has_selection)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_has_selection(op, has_selection);
		return op;
	}

	public static GtkPrintOperationHandle SetJobName(this GtkPrintOperationHandle op, string job_name)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_job_name(op, job_name);
		return op;
	}

	public static GtkPrintOperationHandle SetNPages(this GtkPrintOperationHandle op, int n_pages)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_n_pages(op, n_pages);
		return op;
	}

	public static GtkPrintOperationHandle SetPrintSettings(this GtkPrintOperationHandle op, GtkPrintSettingsHandle print_settings)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_print_settings(op, print_settings);
		return op;
	}

	public static GtkPrintOperationHandle SetShowProgress(this GtkPrintOperationHandle op, bool show_progress)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_show_progress(op, show_progress);
		return op;
	}

	public static GtkPrintOperationHandle SetSupportSelection(this GtkPrintOperationHandle op, bool support_selection)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_support_selection(op, support_selection);
		return op;
	}

	public static GtkPrintOperationHandle SetTrackPrintStatus(this GtkPrintOperationHandle op, bool track_status)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_track_print_status(op, track_status);
		return op;
	}

	public static GtkPrintOperationHandle SetUnit(this GtkPrintOperationHandle op, GtkUnit unit)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_unit(op, unit);
		return op;
	}

	public static GtkPrintOperationHandle SetUseFullPage(this GtkPrintOperationHandle op, bool full_page)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_use_full_page(op, full_page);
		return op;
	}

	public static GtkPrintOperationHandle Connect(this GtkPrintOperationHandle instance, GtkPrintOperationSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkPrintOperationExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_cancel(GtkPrintOperationHandle op);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_draw_page_finish(GtkPrintOperationHandle op);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageSetupHandle gtk_print_operation_get_default_page_setup(GtkPrintOperationHandle op);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_operation_get_embed_page_setup(GtkPrintOperationHandle op);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_get_error(GtkPrintOperationHandle op, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_operation_get_has_selection(GtkPrintOperationHandle op);
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_print_operation_get_n_pages_to_print(GtkPrintOperationHandle op);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintSettingsHandle gtk_print_operation_get_print_settings(GtkPrintOperationHandle op);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintStatus gtk_print_operation_get_status(GtkPrintOperationHandle op);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_print_operation_get_status_string(GtkPrintOperationHandle op);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_operation_get_support_selection(GtkPrintOperationHandle op);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_operation_is_finished(GtkPrintOperationHandle op);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintOperationResult gtk_print_operation_run(GtkPrintOperationHandle op, GtkPrintOperationAction action, GtkWindowHandle parent, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_allow_async(GtkPrintOperationHandle op, bool allow_async);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_current_page(GtkPrintOperationHandle op, int current_page);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_custom_tab_label(GtkPrintOperationHandle op, string label);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_default_page_setup(GtkPrintOperationHandle op, GtkPageSetupHandle default_page_setup);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_defer_drawing(GtkPrintOperationHandle op);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_embed_page_setup(GtkPrintOperationHandle op, bool embed);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_export_filename(GtkPrintOperationHandle op, string filename);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_has_selection(GtkPrintOperationHandle op, bool has_selection);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_job_name(GtkPrintOperationHandle op, string job_name);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_n_pages(GtkPrintOperationHandle op, int n_pages);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_print_settings(GtkPrintOperationHandle op, GtkPrintSettingsHandle print_settings);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_show_progress(GtkPrintOperationHandle op, bool show_progress);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_support_selection(GtkPrintOperationHandle op, bool support_selection);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_track_print_status(GtkPrintOperationHandle op, bool track_status);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_unit(GtkPrintOperationHandle op, GtkUnit unit);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_use_full_page(GtkPrintOperationHandle op, bool full_page);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintOperationHandle gtk_print_operation_new();
}
