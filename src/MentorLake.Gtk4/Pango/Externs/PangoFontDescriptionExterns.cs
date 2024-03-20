using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoFontDescriptionExterns
{
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_copy")]
    internal static extern PangoFontDescriptionHandle pango_font_description_copy(this PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_copy_static")]
    internal static extern PangoFontDescriptionHandle pango_font_description_copy_static(this PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_hash")]
    internal static extern uint pango_font_description_hash(this PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_equal")]
    internal static extern int pango_font_description_equal(this PangoFontDescriptionHandle desc1, PangoFontDescriptionHandle desc2);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_free")]
    internal static extern void pango_font_description_free(this PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_set_family")]
    internal static extern void pango_font_description_set_family(this PangoFontDescriptionHandle desc, string family);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_set_family_static")]
    internal static extern void pango_font_description_set_family_static(this PangoFontDescriptionHandle desc, string family);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_get_family")]
    internal static extern string pango_font_description_get_family(this PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_set_style")]
    internal static extern void pango_font_description_set_style(this PangoFontDescriptionHandle desc, PangoStyle style);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_get_style")]
    internal static extern PangoStyle pango_font_description_get_style(this PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_set_variant")]
    internal static extern void pango_font_description_set_variant(this PangoFontDescriptionHandle desc, PangoVariant variant);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_get_variant")]
    internal static extern PangoVariant pango_font_description_get_variant(this PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_set_weight")]
    internal static extern void pango_font_description_set_weight(this PangoFontDescriptionHandle desc, PangoWeight weight);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_get_weight")]
    internal static extern PangoWeight pango_font_description_get_weight(this PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_set_stretch")]
    internal static extern void pango_font_description_set_stretch(this PangoFontDescriptionHandle desc, PangoStretch stretch);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_get_stretch")]
    internal static extern PangoStretch pango_font_description_get_stretch(this PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_set_size")]
    internal static extern void pango_font_description_set_size(this PangoFontDescriptionHandle desc, int size);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_get_size")]
    internal static extern int pango_font_description_get_size(this PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_set_absolute_size")]
    internal static extern void pango_font_description_set_absolute_size(this PangoFontDescriptionHandle desc, double size);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_get_size_is_absolute")]
    internal static extern int pango_font_description_get_size_is_absolute(this PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_set_gravity")]
    internal static extern void pango_font_description_set_gravity(this PangoFontDescriptionHandle desc, PangoGravity gravity);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_get_gravity")]
    internal static extern PangoGravity pango_font_description_get_gravity(this PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_set_variations_static")]
    internal static extern void pango_font_description_set_variations_static(this PangoFontDescriptionHandle desc, string variations);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_set_variations")]
    internal static extern void pango_font_description_set_variations(this PangoFontDescriptionHandle desc, string variations);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_get_variations")]
    internal static extern string pango_font_description_get_variations(this PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_get_set_fields")]
    internal static extern PangoFontMask pango_font_description_get_set_fields(this PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_unset_fields")]
    internal static extern void pango_font_description_unset_fields(this PangoFontDescriptionHandle desc, PangoFontMask to_unset);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_merge")]
    internal static extern void pango_font_description_merge(this PangoFontDescriptionHandle desc, PangoFontDescriptionHandle desc_to_merge, int replace_existing);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_merge_static")]
    internal static extern void pango_font_description_merge_static(this PangoFontDescriptionHandle desc, PangoFontDescriptionHandle desc_to_merge, int replace_existing);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_better_match")]
    internal static extern int pango_font_description_better_match(this PangoFontDescriptionHandle desc, PangoFontDescriptionHandle old_match, PangoFontDescriptionHandle new_match);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_to_string")]
    internal static extern string pango_font_description_to_string(this PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_font_description_to_filename")]
    internal static extern string pango_font_description_to_filename(this PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, EntryPoint = "pango_attr_font_desc_new")]
    internal static extern PangoAttributeHandle pango_attr_font_desc_new(this PangoFontDescriptionHandle desc);
    [DllImport(Libraries.Pango, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern PangoFontDescriptionHandle pango_font_description_new();
}
