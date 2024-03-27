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

public class GtkFileDialogHandle : GObjectHandle
{
	public static GtkFileDialogHandle New()
	{
		return GtkFileDialogExterns.gtk_file_dialog_new();
	}
}

public static class GtkFileDialogSignals
{
}

public static class GtkFileDialogHandleExtensions
{
	public static string GetAcceptLabel(this GtkFileDialogHandle self)
	{
		return GtkFileDialogExterns.gtk_file_dialog_get_accept_label(self);
	}

	public static GtkFileFilterHandle GetDefaultFilter(this GtkFileDialogHandle self)
	{
		return GtkFileDialogExterns.gtk_file_dialog_get_default_filter(self);
	}

	public static GListModelHandle GetFilters(this GtkFileDialogHandle self)
	{
		return GtkFileDialogExterns.gtk_file_dialog_get_filters(self);
	}

	public static GFileHandle GetInitialFile(this GtkFileDialogHandle self)
	{
		return GtkFileDialogExterns.gtk_file_dialog_get_initial_file(self);
	}

	public static GFileHandle GetInitialFolder(this GtkFileDialogHandle self)
	{
		return GtkFileDialogExterns.gtk_file_dialog_get_initial_folder(self);
	}

	public static string GetInitialName(this GtkFileDialogHandle self)
	{
		return GtkFileDialogExterns.gtk_file_dialog_get_initial_name(self);
	}

	public static bool GetModal(this GtkFileDialogHandle self)
	{
		return GtkFileDialogExterns.gtk_file_dialog_get_modal(self);
	}

	public static string GetTitle(this GtkFileDialogHandle self)
	{
		return GtkFileDialogExterns.gtk_file_dialog_get_title(self);
	}

	public static GtkFileDialogHandle Open(this GtkFileDialogHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkFileDialogExterns.gtk_file_dialog_open(self, parent, cancellable, callback, user_data);
		return self;
	}

	public static GFileHandle OpenFinish(this GtkFileDialogHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkFileDialogExterns.gtk_file_dialog_open_finish(self, result, out error);
	}

	public static GtkFileDialogHandle OpenMultiple(this GtkFileDialogHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkFileDialogExterns.gtk_file_dialog_open_multiple(self, parent, cancellable, callback, user_data);
		return self;
	}

	public static GListModelHandle OpenMultipleFinish(this GtkFileDialogHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkFileDialogExterns.gtk_file_dialog_open_multiple_finish(self, result, out error);
	}

	public static GtkFileDialogHandle Save(this GtkFileDialogHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkFileDialogExterns.gtk_file_dialog_save(self, parent, cancellable, callback, user_data);
		return self;
	}

	public static GFileHandle SaveFinish(this GtkFileDialogHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkFileDialogExterns.gtk_file_dialog_save_finish(self, result, out error);
	}

	public static GtkFileDialogHandle SelectFolder(this GtkFileDialogHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkFileDialogExterns.gtk_file_dialog_select_folder(self, parent, cancellable, callback, user_data);
		return self;
	}

	public static GFileHandle SelectFolderFinish(this GtkFileDialogHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkFileDialogExterns.gtk_file_dialog_select_folder_finish(self, result, out error);
	}

	public static GtkFileDialogHandle SelectMultipleFolders(this GtkFileDialogHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkFileDialogExterns.gtk_file_dialog_select_multiple_folders(self, parent, cancellable, callback, user_data);
		return self;
	}

	public static GListModelHandle SelectMultipleFoldersFinish(this GtkFileDialogHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkFileDialogExterns.gtk_file_dialog_select_multiple_folders_finish(self, result, out error);
	}

	public static GtkFileDialogHandle SetAcceptLabel(this GtkFileDialogHandle self, string accept_label)
	{
		GtkFileDialogExterns.gtk_file_dialog_set_accept_label(self, accept_label);
		return self;
	}

	public static GtkFileDialogHandle SetDefaultFilter(this GtkFileDialogHandle self, GtkFileFilterHandle filter)
	{
		GtkFileDialogExterns.gtk_file_dialog_set_default_filter(self, filter);
		return self;
	}

	public static GtkFileDialogHandle SetFilters(this GtkFileDialogHandle self, GListModelHandle filters)
	{
		GtkFileDialogExterns.gtk_file_dialog_set_filters(self, filters);
		return self;
	}

	public static GtkFileDialogHandle SetInitialFile(this GtkFileDialogHandle self, GFileHandle file)
	{
		GtkFileDialogExterns.gtk_file_dialog_set_initial_file(self, file);
		return self;
	}

	public static GtkFileDialogHandle SetInitialFolder(this GtkFileDialogHandle self, GFileHandle folder)
	{
		GtkFileDialogExterns.gtk_file_dialog_set_initial_folder(self, folder);
		return self;
	}

	public static GtkFileDialogHandle SetInitialName(this GtkFileDialogHandle self, string name)
	{
		GtkFileDialogExterns.gtk_file_dialog_set_initial_name(self, name);
		return self;
	}

	public static GtkFileDialogHandle SetModal(this GtkFileDialogHandle self, bool modal)
	{
		GtkFileDialogExterns.gtk_file_dialog_set_modal(self, modal);
		return self;
	}

	public static GtkFileDialogHandle SetTitle(this GtkFileDialogHandle self, string title)
	{
		GtkFileDialogExterns.gtk_file_dialog_set_title(self, title);
		return self;
	}

}

internal class GtkFileDialogExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_file_dialog_get_accept_label(GtkFileDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFileFilterHandle gtk_file_dialog_get_default_filter(GtkFileDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_file_dialog_get_filters(GtkFileDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GFileHandle gtk_file_dialog_get_initial_file(GtkFileDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GFileHandle gtk_file_dialog_get_initial_folder(GtkFileDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_file_dialog_get_initial_name(GtkFileDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_file_dialog_get_modal(GtkFileDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_file_dialog_get_title(GtkFileDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_dialog_open(GtkFileDialogHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gtk4)]
	internal static extern GFileHandle gtk_file_dialog_open_finish(GtkFileDialogHandle self, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_dialog_open_multiple(GtkFileDialogHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_file_dialog_open_multiple_finish(GtkFileDialogHandle self, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_dialog_save(GtkFileDialogHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gtk4)]
	internal static extern GFileHandle gtk_file_dialog_save_finish(GtkFileDialogHandle self, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_dialog_select_folder(GtkFileDialogHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gtk4)]
	internal static extern GFileHandle gtk_file_dialog_select_folder_finish(GtkFileDialogHandle self, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_dialog_select_multiple_folders(GtkFileDialogHandle self, GtkWindowHandle parent, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_file_dialog_select_multiple_folders_finish(GtkFileDialogHandle self, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_dialog_set_accept_label(GtkFileDialogHandle self, string accept_label);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_dialog_set_default_filter(GtkFileDialogHandle self, GtkFileFilterHandle filter);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_dialog_set_filters(GtkFileDialogHandle self, GListModelHandle filters);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_dialog_set_initial_file(GtkFileDialogHandle self, GFileHandle file);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_dialog_set_initial_folder(GtkFileDialogHandle self, GFileHandle folder);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_dialog_set_initial_name(GtkFileDialogHandle self, string name);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_dialog_set_modal(GtkFileDialogHandle self, bool modal);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_dialog_set_title(GtkFileDialogHandle self, string title);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFileDialogHandle gtk_file_dialog_new();
}
