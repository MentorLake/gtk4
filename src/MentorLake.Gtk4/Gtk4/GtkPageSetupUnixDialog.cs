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

public class GtkPageSetupUnixDialogHandle : GtkDialogHandle
{
	public static GtkPageSetupUnixDialogHandle New(string title, GtkWindowHandle parent)
	{
		return GtkPageSetupUnixDialogExterns.gtk_page_setup_unix_dialog_new(title, parent);
	}

}

public static class GtkPageSetupUnixDialogHandleExtensions
{
	public static GtkPageSetupHandle GetPageSetup(this GtkPageSetupUnixDialogHandle dialog)
	{
		return GtkPageSetupUnixDialogExterns.gtk_page_setup_unix_dialog_get_page_setup(dialog);
	}

	public static GtkPrintSettingsHandle GetPrintSettings(this GtkPageSetupUnixDialogHandle dialog)
	{
		return GtkPageSetupUnixDialogExterns.gtk_page_setup_unix_dialog_get_print_settings(dialog);
	}

	public static GtkPageSetupUnixDialogHandle SetPageSetup(this GtkPageSetupUnixDialogHandle dialog, GtkPageSetupHandle page_setup)
	{
		GtkPageSetupUnixDialogExterns.gtk_page_setup_unix_dialog_set_page_setup(dialog, page_setup);
		return dialog;
	}

	public static GtkPageSetupUnixDialogHandle SetPrintSettings(this GtkPageSetupUnixDialogHandle dialog, GtkPrintSettingsHandle print_settings)
	{
		GtkPageSetupUnixDialogExterns.gtk_page_setup_unix_dialog_set_print_settings(dialog, print_settings);
		return dialog;
	}

}

internal class GtkPageSetupUnixDialogExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageSetupUnixDialogHandle gtk_page_setup_unix_dialog_new(string title, GtkWindowHandle parent);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageSetupHandle gtk_page_setup_unix_dialog_get_page_setup(GtkPageSetupUnixDialogHandle dialog);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintSettingsHandle gtk_page_setup_unix_dialog_get_print_settings(GtkPageSetupUnixDialogHandle dialog);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_page_setup_unix_dialog_set_page_setup(GtkPageSetupUnixDialogHandle dialog, GtkPageSetupHandle page_setup);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_page_setup_unix_dialog_set_print_settings(GtkPageSetupUnixDialogHandle dialog, GtkPrintSettingsHandle print_settings);
}
