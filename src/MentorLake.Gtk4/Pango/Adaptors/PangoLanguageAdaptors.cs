using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoLanguageAdaptors
{
    public static string ToString(this PangoLanguageHandle language)
    {
        return PangoLanguageExterns.pango_language_to_string(language);
    }

    public static string GetSampleString(this PangoLanguageHandle language)
    {
        return PangoLanguageExterns.pango_language_get_sample_string(language);
    }

    public static int Matches(this PangoLanguageHandle language, string range_list)
    {
        return PangoLanguageExterns.pango_language_matches(language, range_list);
    }

    public static int IncludesScript(this PangoLanguageHandle language, PangoScript script)
    {
        return PangoLanguageExterns.pango_language_includes_script(language, script);
    }

    public static PangoScript[] GetScripts(this PangoLanguageHandle language, out int num_scripts)
    {
        return PangoLanguageExterns.pango_language_get_scripts(language, out num_scripts);
    }

    public static PangoAttributeHandle PangoAttrLanguageNew(this PangoLanguageHandle language)
    {
        return PangoLanguageExterns.pango_attr_language_new(language);
    }

    public static PangoFontsetSimpleHandle PangoFontsetSimpleNew(this PangoLanguageHandle language)
    {
        return PangoLanguageExterns.pango_fontset_simple_new(language);
    }
}
