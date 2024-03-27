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

public class GtkColorDialogHandle : GObjectHandle
{
	public static GtkColorDialogHandle New()
	{
		return GtkColorDialogExterns.gtk_color_dialog_new();
	}
}

public static class GtkColorDialogSignals
{
}

public static class GtkColorDialogHandleExtensions
{
	public static GtkColorDialogHandle ChooseRgba(this GtkColorDialogHandle self, GtkWindowHandle parent, GdkRGBAHandle initial_color, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkColorDialogExterns.gtk_color_dialog_choose_rgba(self, parent, initial_color, cancellable, callback, user_data);
		return self;
	}

	public static GdkRGBAHandle ChooseRgbaFinish(this GtkColorDialogHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkColorDialogExterns.gtk_color_dialog_choose_rgba_finish(self, result, out error);
	}

	public static bool GetModal(this GtkColorDialogHandle self)
	{
		return GtkColorDialogExterns.gtk_color_dialog_get_modal(self);
	}

	public static string GetTitle(this GtkColorDialogHandle self)
	{
		return GtkColorDialogExterns.gtk_color_dialog_get_title(self);
	}

	public static bool GetWithAlpha(this GtkColorDialogHandle self)
	{
		return GtkColorDialogExterns.gtk_color_dialog_get_with_alpha(self);
	}

	public static GtkColorDialogHandle SetModal(this GtkColorDialogHandle self, bool modal)
	{
		GtkColorDialogExterns.gtk_color_dialog_set_modal(self, modal);
		return self;
	}

	public static GtkColorDialogHandle SetTitle(this GtkColorDialogHandle self, string title)
	{
		GtkColorDialogExterns.gtk_color_dialog_set_title(self, title);
		return self;
	}

	public static GtkColorDialogHandle SetWithAlpha(this GtkColorDialogHandle self, bool with_alpha)
	{
		GtkColorDialogExterns.gtk_color_dialog_set_with_alpha(self, with_alpha);
		return self;
	}

}

internal class GtkColorDialogExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_color_dialog_choose_rgba(GtkColorDialogHandle self, GtkWindowHandle parent, GdkRGBAHandle initial_color, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkRGBAHandle gtk_color_dialog_choose_rgba_finish(GtkColorDialogHandle self, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_color_dialog_get_modal(GtkColorDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_color_dialog_get_title(GtkColorDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_color_dialog_get_with_alpha(GtkColorDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_color_dialog_set_modal(GtkColorDialogHandle self, bool modal);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_color_dialog_set_title(GtkColorDialogHandle self, string title);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_color_dialog_set_with_alpha(GtkColorDialogHandle self, bool with_alpha);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkColorDialogHandle gtk_color_dialog_new();
}
