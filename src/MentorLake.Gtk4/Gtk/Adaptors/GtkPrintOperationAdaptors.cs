using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPrintOperationAdaptors
{
	public static GtkPrintOperationHandle SetDefaultPageSetup(this GtkPrintOperationHandle op, GtkPageSetupHandle default_page_setup)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_default_page_setup(op, default_page_setup);
		return op;
	}

	public static GtkPageSetupHandle GetDefaultPageSetup(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_default_page_setup(op);
	}

	public static GtkPrintOperationHandle SetPrintSettings(this GtkPrintOperationHandle op, GtkPrintSettingsHandle print_settings)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_print_settings(op, print_settings);
		return op;
	}

	public static GtkPrintSettingsHandle GetPrintSettings(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_print_settings(op);
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

	public static GtkPrintOperationHandle SetCurrentPage(this GtkPrintOperationHandle op, int current_page)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_current_page(op, current_page);
		return op;
	}

	public static GtkPrintOperationHandle SetUseFullPage(this GtkPrintOperationHandle op, int full_page)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_use_full_page(op, full_page);
		return op;
	}

	public static GtkPrintOperationHandle SetUnit(this GtkPrintOperationHandle op, GtkUnit unit)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_unit(op, unit);
		return op;
	}

	public static GtkPrintOperationHandle SetExportFilename(this GtkPrintOperationHandle op, string filename)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_export_filename(op, filename);
		return op;
	}

	public static GtkPrintOperationHandle SetTrackPrintStatus(this GtkPrintOperationHandle op, int track_status)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_track_print_status(op, track_status);
		return op;
	}

	public static GtkPrintOperationHandle SetShowProgress(this GtkPrintOperationHandle op, int show_progress)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_show_progress(op, show_progress);
		return op;
	}

	public static GtkPrintOperationHandle SetAllowAsync(this GtkPrintOperationHandle op, int allow_async)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_allow_async(op, allow_async);
		return op;
	}

	public static GtkPrintOperationHandle SetCustomTabLabel(this GtkPrintOperationHandle op, string label)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_custom_tab_label(op, label);
		return op;
	}

	public static GtkPrintOperationResult Run(this GtkPrintOperationHandle op, GtkPrintOperationAction action, GtkWindowHandle parent, out GErrorHandle error)
	{
		return GtkPrintOperationExterns.gtk_print_operation_run(op, action, parent, out error);
	}

	public static GtkPrintOperationHandle GetError(this GtkPrintOperationHandle op, out GErrorHandle error)
	{
		GtkPrintOperationExterns.gtk_print_operation_get_error(op, out error);
		return op;
	}

	public static GtkPrintStatus GetStatus(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_status(op);
	}

	public static string GetStatusString(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_status_string(op);
	}

	public static int IsFinished(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_is_finished(op);
	}

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

	public static GtkPrintOperationHandle SetDeferDrawing(this GtkPrintOperationHandle op)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_defer_drawing(op);
		return op;
	}

	public static GtkPrintOperationHandle SetSupportSelection(this GtkPrintOperationHandle op, int support_selection)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_support_selection(op, support_selection);
		return op;
	}

	public static int GetSupportSelection(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_support_selection(op);
	}

	public static GtkPrintOperationHandle SetHasSelection(this GtkPrintOperationHandle op, int has_selection)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_has_selection(op, has_selection);
		return op;
	}

	public static int GetHasSelection(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_has_selection(op);
	}

	public static GtkPrintOperationHandle SetEmbedPageSetup(this GtkPrintOperationHandle op, int embed)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_embed_page_setup(op, embed);
		return op;
	}

	public static int GetEmbedPageSetup(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_embed_page_setup(op);
	}

	public static int GetNPagesToPrint(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_n_pages_to_print(op);
	}
}
