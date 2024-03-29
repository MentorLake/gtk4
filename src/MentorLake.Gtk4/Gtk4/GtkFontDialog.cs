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

public class GtkFontDialogHandle : GObjectHandle
{
	public static GtkFontDialogHandle New()
	{
		return GtkFontDialogExterns.gtk_font_dialog_new();
	}

}

public static class GtkFontDialogHandleExtensions
{
	public static GtkFontDialogHandle ChooseFace(this GtkFontDialogHandle self, GtkWindowHandle parent, PangoFontFaceHandle initial_value, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkFontDialogExterns.gtk_font_dialog_choose_face(self, parent, initial_value, cancellable, callback, user_data);
		return self;
	}

	public static PangoFontFaceHandle ChooseFaceFinish(this GtkFontDialogHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkFontDialogExterns.gtk_font_dialog_choose_face_finish(self, result, out error);
	}

	public static GtkFontDialogHandle ChooseFamily(this GtkFontDialogHandle self, GtkWindowHandle parent, PangoFontFamilyHandle initial_value, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkFontDialogExterns.gtk_font_dialog_choose_family(self, parent, initial_value, cancellable, callback, user_data);
		return self;
	}

	public static PangoFontFamilyHandle ChooseFamilyFinish(this GtkFontDialogHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkFontDialogExterns.gtk_font_dialog_choose_family_finish(self, result, out error);
	}

	public static GtkFontDialogHandle ChooseFont(this GtkFontDialogHandle self, GtkWindowHandle parent, PangoFontDescriptionHandle initial_value, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkFontDialogExterns.gtk_font_dialog_choose_font(self, parent, initial_value, cancellable, callback, user_data);
		return self;
	}

	public static GtkFontDialogHandle ChooseFontAndFeatures(this GtkFontDialogHandle self, GtkWindowHandle parent, PangoFontDescriptionHandle initial_value, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkFontDialogExterns.gtk_font_dialog_choose_font_and_features(self, parent, initial_value, cancellable, callback, user_data);
		return self;
	}

	public static bool ChooseFontAndFeaturesFinish(this GtkFontDialogHandle self, GAsyncResultHandle result, out PangoFontDescriptionHandle font_desc, out string font_features, out PangoLanguageHandle language, out GErrorHandle error)
	{
		return GtkFontDialogExterns.gtk_font_dialog_choose_font_and_features_finish(self, result, out font_desc, out font_features, out language, out error);
	}

	public static PangoFontDescriptionHandle ChooseFontFinish(this GtkFontDialogHandle self, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkFontDialogExterns.gtk_font_dialog_choose_font_finish(self, result, out error);
	}

	public static GtkFilterHandle GetFilter(this GtkFontDialogHandle self)
	{
		return GtkFontDialogExterns.gtk_font_dialog_get_filter(self);
	}

	public static PangoFontMapHandle GetFontMap(this GtkFontDialogHandle self)
	{
		return GtkFontDialogExterns.gtk_font_dialog_get_font_map(self);
	}

	public static PangoLanguageHandle GetLanguage(this GtkFontDialogHandle self)
	{
		return GtkFontDialogExterns.gtk_font_dialog_get_language(self);
	}

	public static bool GetModal(this GtkFontDialogHandle self)
	{
		return GtkFontDialogExterns.gtk_font_dialog_get_modal(self);
	}

	public static string GetTitle(this GtkFontDialogHandle self)
	{
		return GtkFontDialogExterns.gtk_font_dialog_get_title(self);
	}

	public static GtkFontDialogHandle SetFilter(this GtkFontDialogHandle self, GtkFilterHandle filter)
	{
		GtkFontDialogExterns.gtk_font_dialog_set_filter(self, filter);
		return self;
	}

	public static GtkFontDialogHandle SetFontMap(this GtkFontDialogHandle self, PangoFontMapHandle fontmap)
	{
		GtkFontDialogExterns.gtk_font_dialog_set_font_map(self, fontmap);
		return self;
	}

	public static GtkFontDialogHandle SetLanguage(this GtkFontDialogHandle self, PangoLanguageHandle language)
	{
		GtkFontDialogExterns.gtk_font_dialog_set_language(self, language);
		return self;
	}

	public static GtkFontDialogHandle SetModal(this GtkFontDialogHandle self, bool modal)
	{
		GtkFontDialogExterns.gtk_font_dialog_set_modal(self, modal);
		return self;
	}

	public static GtkFontDialogHandle SetTitle(this GtkFontDialogHandle self, string title)
	{
		GtkFontDialogExterns.gtk_font_dialog_set_title(self, title);
		return self;
	}

}

internal class GtkFontDialogExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFontDialogHandle gtk_font_dialog_new();
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_choose_face(GtkFontDialogHandle self, GtkWindowHandle parent, PangoFontFaceHandle initial_value, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gtk4)]
	internal static extern PangoFontFaceHandle gtk_font_dialog_choose_face_finish(GtkFontDialogHandle self, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_choose_family(GtkFontDialogHandle self, GtkWindowHandle parent, PangoFontFamilyHandle initial_value, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gtk4)]
	internal static extern PangoFontFamilyHandle gtk_font_dialog_choose_family_finish(GtkFontDialogHandle self, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_choose_font(GtkFontDialogHandle self, GtkWindowHandle parent, PangoFontDescriptionHandle initial_value, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_choose_font_and_features(GtkFontDialogHandle self, GtkWindowHandle parent, PangoFontDescriptionHandle initial_value, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_font_dialog_choose_font_and_features_finish(GtkFontDialogHandle self, GAsyncResultHandle result, out PangoFontDescriptionHandle font_desc, out string font_features, out PangoLanguageHandle language, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern PangoFontDescriptionHandle gtk_font_dialog_choose_font_finish(GtkFontDialogHandle self, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFilterHandle gtk_font_dialog_get_filter(GtkFontDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern PangoFontMapHandle gtk_font_dialog_get_font_map(GtkFontDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern PangoLanguageHandle gtk_font_dialog_get_language(GtkFontDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_font_dialog_get_modal(GtkFontDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_font_dialog_get_title(GtkFontDialogHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_set_filter(GtkFontDialogHandle self, GtkFilterHandle filter);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_set_font_map(GtkFontDialogHandle self, PangoFontMapHandle fontmap);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_set_language(GtkFontDialogHandle self, PangoLanguageHandle language);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_set_modal(GtkFontDialogHandle self, bool modal);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_set_title(GtkFontDialogHandle self, string title);
}
