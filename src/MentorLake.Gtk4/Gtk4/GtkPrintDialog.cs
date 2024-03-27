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

public class GtkPrintDialogHandle : GObjectHandle
{
	public static GtkPrintDialogHandle New()
	{
		return GtkPrintDialogExterns.gtk_print_dialog_new();
	}
}

public static class GtkPrintDialogSignals
{
}

public static class GtkPrintDialogHandleExtensions
{
	public static string GetAcceptLabel(this GtkPrintDialogHandle self)
	{
		return GtkPrintDialogExterns.gtk_print_dialog_get_accept_label(self);
	}

	public static bool GetModal(this GtkPrintDialogHandle self)
	{
		return GtkPrintDialogExterns.gtk_print_dialog_get_modal(self);
	}

	public static GtkPageSetupHandle GetPageSetup(this GtkPrintDialogHandle self)
	{
		return GtkPrintDialogExterns.gtk_print_dialog_get_page_setup(self);
	}

	public static GtkPrintSettingsHandle GetPrintSettings(this GtkPrintDialogHandle self)
	{
		return GtkPrintDialogExterns.gtk_print_dialog_get_print_settings(self);
	}

	public static string GetTitle(this GtkPrintDialogHandle self)
	{
		return GtkPrintDialogExterns.gtk_print_dialog_get_title(self);
	}

	public static GtkPrintDialogHandle Print(this GtkPrintDialogHandle self, GtkWindowHandle parent, GtkPrintSetupHandle setup, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkPrintDialogExterns.gtk_print_dialog_print(self, parent, setup, cancellable, callback, user_data);
		return self;
	}

	public static GtkPrintDialogHandle PrintFile(this GtkPrintDialogHandle self, GtkWindowHandle parent, GtkPrintSetupHandle setup, GFileHandle file, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkPrintDialogExterns.gtk_print_dialog_print_file(self, parent, setup, file, cancellable, callback, user_data);
		return self;
	}

	public static bool PrintFileFinish(this GtkPrintDialogHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkPrintDialogExterns.gtk_print_dialog_print_file_finish(self, result, out error);
	}

	public static GOutputStreamHandle PrintFinish(this GtkPrintDialogHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkPrintDialogExterns.gtk_print_dialog_print_finish(self, result, out error);
	}

	public static GtkPrintDialogHandle SetAcceptLabel(this GtkPrintDialogHandle self, string accept_label)
	{
		GtkPrintDialogExterns.gtk_print_dialog_set_accept_label(self, accept_label);
		return self;
	}

	public static GtkPrintDialogHandle SetModal(this GtkPrintDialogHandle self, bool modal)
	{
		GtkPrintDialogExterns.gtk_print_dialog_set_modal(self, modal);
		return self;
	}

	public static GtkPrintDialogHandle SetPageSetup(this GtkPrintDialogHandle self, GtkPageSetupHandle page_setup)
	{
		GtkPrintDialogExterns.gtk_print_dialog_set_page_setup(self, page_setup);
		return self;
	}

	public static GtkPrintDialogHandle SetPrintSettings(this GtkPrintDialogHandle self, GtkPrintSettingsHandle print_settings)
	{
		GtkPrintDialogExterns.gtk_print_dialog_set_print_settings(self, print_settings);
		return self;
	}

	public static GtkPrintDialogHandle SetTitle(this GtkPrintDialogHandle self, string title)
	{
		GtkPrintDialogExterns.gtk_print_dialog_set_title(self, title);
		return self;
	}

	public static GtkPrintDialogHandle Setup(this GtkPrintDialogHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkPrintDialogExterns.gtk_print_dialog_setup(self, parent, cancellable, callback, user_data);
		return self;
	}

	public static GtkPrintSetupHandle SetupFinish(this GtkPrintDialogHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkPrintDialogExterns.gtk_print_dialog_setup_finish(self, result, out error);
	}

}

internal class GtkPrintDialogExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_print_dialog_get_accept_label(GtkPrintDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_dialog_get_modal(GtkPrintDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageSetupHandle gtk_print_dialog_get_page_setup(GtkPrintDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintSettingsHandle gtk_print_dialog_get_print_settings(GtkPrintDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_print_dialog_get_title(GtkPrintDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_dialog_print(GtkPrintDialogHandle self, GtkWindowHandle parent, GtkPrintSetupHandle setup, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_dialog_print_file(GtkPrintDialogHandle self, GtkWindowHandle parent, GtkPrintSetupHandle setup, GFileHandle file, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_dialog_print_file_finish(GtkPrintDialogHandle self, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern GOutputStreamHandle gtk_print_dialog_print_finish(GtkPrintDialogHandle self, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_dialog_set_accept_label(GtkPrintDialogHandle self, string accept_label);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_dialog_set_modal(GtkPrintDialogHandle self, bool modal);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_dialog_set_page_setup(GtkPrintDialogHandle self, GtkPageSetupHandle page_setup);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_dialog_set_print_settings(GtkPrintDialogHandle self, GtkPrintSettingsHandle print_settings);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_dialog_set_title(GtkPrintDialogHandle self, string title);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_dialog_setup(GtkPrintDialogHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintSetupHandle gtk_print_dialog_setup_finish(GtkPrintDialogHandle self, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintDialogHandle gtk_print_dialog_new();
}
