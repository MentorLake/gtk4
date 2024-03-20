using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFontChooserAdaptors
{
    public static PangoFontFamilyHandle GetFontFamily(this GtkFontChooserHandle fontchooser)
    {
        return GtkFontChooserExterns.gtk_font_chooser_get_font_family(fontchooser);
    }

    public static PangoFontFaceHandle GetFontFace(this GtkFontChooserHandle fontchooser)
    {
        return GtkFontChooserExterns.gtk_font_chooser_get_font_face(fontchooser);
    }

    public static int GetFontSize(this GtkFontChooserHandle fontchooser)
    {
        return GtkFontChooserExterns.gtk_font_chooser_get_font_size(fontchooser);
    }

    public static PangoFontDescriptionHandle GetFontDesc(this GtkFontChooserHandle fontchooser)
    {
        return GtkFontChooserExterns.gtk_font_chooser_get_font_desc(fontchooser);
    }

    public static GtkFontChooserHandle SetFontDesc(this GtkFontChooserHandle fontchooser, PangoFontDescriptionHandle font_desc)
    {
        GtkFontChooserExterns.gtk_font_chooser_set_font_desc(fontchooser, font_desc);
        return fontchooser;
    }

    public static string GetFont(this GtkFontChooserHandle fontchooser)
    {
        return GtkFontChooserExterns.gtk_font_chooser_get_font(fontchooser);
    }

    public static GtkFontChooserHandle SetFont(this GtkFontChooserHandle fontchooser, string fontname)
    {
        GtkFontChooserExterns.gtk_font_chooser_set_font(fontchooser, fontname);
        return fontchooser;
    }

    public static string GetPreviewText(this GtkFontChooserHandle fontchooser)
    {
        return GtkFontChooserExterns.gtk_font_chooser_get_preview_text(fontchooser);
    }

    public static GtkFontChooserHandle SetPreviewText(this GtkFontChooserHandle fontchooser, string text)
    {
        GtkFontChooserExterns.gtk_font_chooser_set_preview_text(fontchooser, text);
        return fontchooser;
    }

    public static int GetShowPreviewEntry(this GtkFontChooserHandle fontchooser)
    {
        return GtkFontChooserExterns.gtk_font_chooser_get_show_preview_entry(fontchooser);
    }

    public static GtkFontChooserHandle SetShowPreviewEntry(this GtkFontChooserHandle fontchooser, int show_preview_entry)
    {
        GtkFontChooserExterns.gtk_font_chooser_set_show_preview_entry(fontchooser, show_preview_entry);
        return fontchooser;
    }

    public static GtkFontChooserHandle SetFilterFunc(this GtkFontChooserHandle fontchooser, GtkFontFilterFunc filter, IntPtr user_data, GDestroyNotify destroy)
    {
        GtkFontChooserExterns.gtk_font_chooser_set_filter_func(fontchooser, filter, user_data, destroy);
        return fontchooser;
    }

    public static GtkFontChooserHandle SetFontMap(this GtkFontChooserHandle fontchooser, PangoFontMapHandle fontmap)
    {
        GtkFontChooserExterns.gtk_font_chooser_set_font_map(fontchooser, fontmap);
        return fontchooser;
    }

    public static PangoFontMapHandle GetFontMap(this GtkFontChooserHandle fontchooser)
    {
        return GtkFontChooserExterns.gtk_font_chooser_get_font_map(fontchooser);
    }

    public static GtkFontChooserHandle SetLevel(this GtkFontChooserHandle fontchooser, GtkFontChooserLevel level)
    {
        GtkFontChooserExterns.gtk_font_chooser_set_level(fontchooser, level);
        return fontchooser;
    }

    public static GtkFontChooserLevel GetLevel(this GtkFontChooserHandle fontchooser)
    {
        return GtkFontChooserExterns.gtk_font_chooser_get_level(fontchooser);
    }

    public static string GetFontFeatures(this GtkFontChooserHandle fontchooser)
    {
        return GtkFontChooserExterns.gtk_font_chooser_get_font_features(fontchooser);
    }

    public static string GetLanguage(this GtkFontChooserHandle fontchooser)
    {
        return GtkFontChooserExterns.gtk_font_chooser_get_language(fontchooser);
    }

    public static GtkFontChooserHandle SetLanguage(this GtkFontChooserHandle fontchooser, string language)
    {
        GtkFontChooserExterns.gtk_font_chooser_set_language(fontchooser, language);
        return fontchooser;
    }
}
