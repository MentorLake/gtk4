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

public class GtkPrintUnixDialogHandle : GtkDialogHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkNativeHandle, GtkRootHandle, GtkShortcutManagerHandle
{
	public static GtkPrintUnixDialogHandle New(string title, GtkWindowHandle parent)
	{
		return GtkPrintUnixDialogExterns.gtk_print_unix_dialog_new(title, parent);
	}

}

public static class GtkPrintUnixDialogHandleExtensions
{
	public static GtkPrintUnixDialogHandle AddCustomTab(this GtkPrintUnixDialogHandle dialog, GtkWidgetHandle child, GtkWidgetHandle tab_label)
	{
		GtkPrintUnixDialogExterns.gtk_print_unix_dialog_add_custom_tab(dialog, child, tab_label);
		return dialog;
	}

	public static int GetCurrentPage(this GtkPrintUnixDialogHandle dialog)
	{
		return GtkPrintUnixDialogExterns.gtk_print_unix_dialog_get_current_page(dialog);
	}

	public static bool GetEmbedPageSetup(this GtkPrintUnixDialogHandle dialog)
	{
		return GtkPrintUnixDialogExterns.gtk_print_unix_dialog_get_embed_page_setup(dialog);
	}

	public static bool GetHasSelection(this GtkPrintUnixDialogHandle dialog)
	{
		return GtkPrintUnixDialogExterns.gtk_print_unix_dialog_get_has_selection(dialog);
	}

	public static GtkPrintCapabilities GetManualCapabilities(this GtkPrintUnixDialogHandle dialog)
	{
		return GtkPrintUnixDialogExterns.gtk_print_unix_dialog_get_manual_capabilities(dialog);
	}

	public static GtkPageSetupHandle GetPageSetup(this GtkPrintUnixDialogHandle dialog)
	{
		return GtkPrintUnixDialogExterns.gtk_print_unix_dialog_get_page_setup(dialog);
	}

	public static bool GetPageSetupSet(this GtkPrintUnixDialogHandle dialog)
	{
		return GtkPrintUnixDialogExterns.gtk_print_unix_dialog_get_page_setup_set(dialog);
	}

	public static GtkPrinterHandle GetSelectedPrinter(this GtkPrintUnixDialogHandle dialog)
	{
		return GtkPrintUnixDialogExterns.gtk_print_unix_dialog_get_selected_printer(dialog);
	}

	public static GtkPrintSettingsHandle GetSettings(this GtkPrintUnixDialogHandle dialog)
	{
		return GtkPrintUnixDialogExterns.gtk_print_unix_dialog_get_settings(dialog);
	}

	public static bool GetSupportSelection(this GtkPrintUnixDialogHandle dialog)
	{
		return GtkPrintUnixDialogExterns.gtk_print_unix_dialog_get_support_selection(dialog);
	}

	public static GtkPrintUnixDialogHandle SetCurrentPage(this GtkPrintUnixDialogHandle dialog, int current_page)
	{
		GtkPrintUnixDialogExterns.gtk_print_unix_dialog_set_current_page(dialog, current_page);
		return dialog;
	}

	public static GtkPrintUnixDialogHandle SetEmbedPageSetup(this GtkPrintUnixDialogHandle dialog, bool embed)
	{
		GtkPrintUnixDialogExterns.gtk_print_unix_dialog_set_embed_page_setup(dialog, embed);
		return dialog;
	}

	public static GtkPrintUnixDialogHandle SetHasSelection(this GtkPrintUnixDialogHandle dialog, bool has_selection)
	{
		GtkPrintUnixDialogExterns.gtk_print_unix_dialog_set_has_selection(dialog, has_selection);
		return dialog;
	}

	public static GtkPrintUnixDialogHandle SetManualCapabilities(this GtkPrintUnixDialogHandle dialog, GtkPrintCapabilities capabilities)
	{
		GtkPrintUnixDialogExterns.gtk_print_unix_dialog_set_manual_capabilities(dialog, capabilities);
		return dialog;
	}

	public static GtkPrintUnixDialogHandle SetPageSetup(this GtkPrintUnixDialogHandle dialog, GtkPageSetupHandle page_setup)
	{
		GtkPrintUnixDialogExterns.gtk_print_unix_dialog_set_page_setup(dialog, page_setup);
		return dialog;
	}

	public static GtkPrintUnixDialogHandle SetSettings(this GtkPrintUnixDialogHandle dialog, GtkPrintSettingsHandle settings)
	{
		GtkPrintUnixDialogExterns.gtk_print_unix_dialog_set_settings(dialog, settings);
		return dialog;
	}

	public static GtkPrintUnixDialogHandle SetSupportSelection(this GtkPrintUnixDialogHandle dialog, bool support_selection)
	{
		GtkPrintUnixDialogExterns.gtk_print_unix_dialog_set_support_selection(dialog, support_selection);
		return dialog;
	}

}

internal class GtkPrintUnixDialogExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintUnixDialogHandle gtk_print_unix_dialog_new(string title, GtkWindowHandle parent);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_unix_dialog_add_custom_tab(GtkPrintUnixDialogHandle dialog, GtkWidgetHandle child, GtkWidgetHandle tab_label);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_print_unix_dialog_get_current_page(GtkPrintUnixDialogHandle dialog);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_unix_dialog_get_embed_page_setup(GtkPrintUnixDialogHandle dialog);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_unix_dialog_get_has_selection(GtkPrintUnixDialogHandle dialog);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintCapabilities gtk_print_unix_dialog_get_manual_capabilities(GtkPrintUnixDialogHandle dialog);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageSetupHandle gtk_print_unix_dialog_get_page_setup(GtkPrintUnixDialogHandle dialog);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_unix_dialog_get_page_setup_set(GtkPrintUnixDialogHandle dialog);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrinterHandle gtk_print_unix_dialog_get_selected_printer(GtkPrintUnixDialogHandle dialog);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintSettingsHandle gtk_print_unix_dialog_get_settings(GtkPrintUnixDialogHandle dialog);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_unix_dialog_get_support_selection(GtkPrintUnixDialogHandle dialog);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_unix_dialog_set_current_page(GtkPrintUnixDialogHandle dialog, int current_page);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_unix_dialog_set_embed_page_setup(GtkPrintUnixDialogHandle dialog, bool embed);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_unix_dialog_set_has_selection(GtkPrintUnixDialogHandle dialog, bool has_selection);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_unix_dialog_set_manual_capabilities(GtkPrintUnixDialogHandle dialog, GtkPrintCapabilities capabilities);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_unix_dialog_set_page_setup(GtkPrintUnixDialogHandle dialog, GtkPageSetupHandle page_setup);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_unix_dialog_set_settings(GtkPrintUnixDialogHandle dialog, GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_unix_dialog_set_support_selection(GtkPrintUnixDialogHandle dialog, bool support_selection);

}
