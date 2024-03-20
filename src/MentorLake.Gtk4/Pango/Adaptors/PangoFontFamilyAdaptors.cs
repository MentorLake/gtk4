using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Pango;
public static class PangoFontFamilyAdaptors
{
    public static PangoFontFamilyHandle ListFaces(this PangoFontFamilyHandle family, out PangoFontFaceHandle faces, out int n_faces)
    {
        PangoFontFamilyExterns.pango_font_family_list_faces(family, out faces, out n_faces);
        return family;
    }

    public static string GetName(this PangoFontFamilyHandle family)
    {
        return PangoFontFamilyExterns.pango_font_family_get_name(family);
    }

    public static int IsMonospace(this PangoFontFamilyHandle family)
    {
        return PangoFontFamilyExterns.pango_font_family_is_monospace(family);
    }

    public static int IsVariable(this PangoFontFamilyHandle family)
    {
        return PangoFontFamilyExterns.pango_font_family_is_variable(family);
    }

    public static PangoFontFaceHandle GetFace(this PangoFontFamilyHandle family, string name)
    {
        return PangoFontFamilyExterns.pango_font_family_get_face(family, name);
    }
}
