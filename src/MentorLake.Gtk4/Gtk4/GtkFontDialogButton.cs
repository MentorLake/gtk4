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

public class GtkFontDialogButtonHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkFontDialogButtonHandle New(GtkFontDialogHandle dialog)
	{
		return GtkFontDialogButtonExterns.gtk_font_dialog_button_new(dialog);
	}

}

public class GtkFontDialogButtonSignal
{
	public string Value { get; set; }
	public GtkFontDialogButtonSignal(string value) => Value = value;
}

public static class GtkFontDialogButtonSignals
{
	public static GtkFontDialogButtonSignal Activate = new("activate");
}

public static class GtkFontDialogButtonHandleExtensions
{
	public static GtkFontDialogHandle GetDialog(this GtkFontDialogButtonHandle self)
	{
		return GtkFontDialogButtonExterns.gtk_font_dialog_button_get_dialog(self);
	}

	public static PangoFontDescriptionHandle GetFontDesc(this GtkFontDialogButtonHandle self)
	{
		return GtkFontDialogButtonExterns.gtk_font_dialog_button_get_font_desc(self);
	}

	public static string GetFontFeatures(this GtkFontDialogButtonHandle self)
	{
		return GtkFontDialogButtonExterns.gtk_font_dialog_button_get_font_features(self);
	}

	public static PangoLanguageHandle GetLanguage(this GtkFontDialogButtonHandle self)
	{
		return GtkFontDialogButtonExterns.gtk_font_dialog_button_get_language(self);
	}

	public static GtkFontLevel GetLevel(this GtkFontDialogButtonHandle self)
	{
		return GtkFontDialogButtonExterns.gtk_font_dialog_button_get_level(self);
	}

	public static bool GetUseFont(this GtkFontDialogButtonHandle self)
	{
		return GtkFontDialogButtonExterns.gtk_font_dialog_button_get_use_font(self);
	}

	public static bool GetUseSize(this GtkFontDialogButtonHandle self)
	{
		return GtkFontDialogButtonExterns.gtk_font_dialog_button_get_use_size(self);
	}

	public static GtkFontDialogButtonHandle SetDialog(this GtkFontDialogButtonHandle self, GtkFontDialogHandle dialog)
	{
		GtkFontDialogButtonExterns.gtk_font_dialog_button_set_dialog(self, dialog);
		return self;
	}

	public static GtkFontDialogButtonHandle SetFontDesc(this GtkFontDialogButtonHandle self, PangoFontDescriptionHandle font_desc)
	{
		GtkFontDialogButtonExterns.gtk_font_dialog_button_set_font_desc(self, font_desc);
		return self;
	}

	public static GtkFontDialogButtonHandle SetFontFeatures(this GtkFontDialogButtonHandle self, string font_features)
	{
		GtkFontDialogButtonExterns.gtk_font_dialog_button_set_font_features(self, font_features);
		return self;
	}

	public static GtkFontDialogButtonHandle SetLanguage(this GtkFontDialogButtonHandle self, PangoLanguageHandle language)
	{
		GtkFontDialogButtonExterns.gtk_font_dialog_button_set_language(self, language);
		return self;
	}

	public static GtkFontDialogButtonHandle SetLevel(this GtkFontDialogButtonHandle self, GtkFontLevel level)
	{
		GtkFontDialogButtonExterns.gtk_font_dialog_button_set_level(self, level);
		return self;
	}

	public static GtkFontDialogButtonHandle SetUseFont(this GtkFontDialogButtonHandle self, bool use_font)
	{
		GtkFontDialogButtonExterns.gtk_font_dialog_button_set_use_font(self, use_font);
		return self;
	}

	public static GtkFontDialogButtonHandle SetUseSize(this GtkFontDialogButtonHandle self, bool use_size)
	{
		GtkFontDialogButtonExterns.gtk_font_dialog_button_set_use_size(self, use_size);
		return self;
	}

	public static GtkFontDialogButtonHandle Connect(this GtkFontDialogButtonHandle instance, GtkFontDialogButtonSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkFontDialogButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFontDialogButtonHandle gtk_font_dialog_button_new(GtkFontDialogHandle dialog);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFontDialogHandle gtk_font_dialog_button_get_dialog(GtkFontDialogButtonHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern PangoFontDescriptionHandle gtk_font_dialog_button_get_font_desc(GtkFontDialogButtonHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_font_dialog_button_get_font_features(GtkFontDialogButtonHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern PangoLanguageHandle gtk_font_dialog_button_get_language(GtkFontDialogButtonHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFontLevel gtk_font_dialog_button_get_level(GtkFontDialogButtonHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_font_dialog_button_get_use_font(GtkFontDialogButtonHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_font_dialog_button_get_use_size(GtkFontDialogButtonHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_button_set_dialog(GtkFontDialogButtonHandle self, GtkFontDialogHandle dialog);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_button_set_font_desc(GtkFontDialogButtonHandle self, PangoFontDescriptionHandle font_desc);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_button_set_font_features(GtkFontDialogButtonHandle self, string font_features);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_button_set_language(GtkFontDialogButtonHandle self, PangoLanguageHandle language);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_button_set_level(GtkFontDialogButtonHandle self, GtkFontLevel level);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_button_set_use_font(GtkFontDialogButtonHandle self, bool use_font);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_button_set_use_size(GtkFontDialogButtonHandle self, bool use_size);
}
