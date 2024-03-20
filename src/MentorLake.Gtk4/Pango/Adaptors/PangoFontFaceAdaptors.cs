using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoFontFaceAdaptors
{
    public static PangoFontDescriptionHandle Describe(this PangoFontFaceHandle face)
    {
        return PangoFontFaceExterns.pango_font_face_describe(face);
    }

    public static string GetFaceName(this PangoFontFaceHandle face)
    {
        return PangoFontFaceExterns.pango_font_face_get_face_name(face);
    }

    public static PangoFontFaceHandle ListSizes(this PangoFontFaceHandle face, out int[] sizes, out int n_sizes)
    {
        PangoFontFaceExterns.pango_font_face_list_sizes(face, out sizes, out n_sizes);
        return face;
    }

    public static int IsSynthesized(this PangoFontFaceHandle face)
    {
        return PangoFontFaceExterns.pango_font_face_is_synthesized(face);
    }

    public static PangoFontFamilyHandle GetFamily(this PangoFontFaceHandle face)
    {
        return PangoFontFaceExterns.pango_font_face_get_family(face);
    }
}
