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

namespace MentorLake.Gtk4.Pango;

public class PangoFontFaceHandle : GObjectHandle
{
}

public static class PangoFontFaceSignals
{
}

public static class PangoFontFaceHandleExtensions
{
	public static PangoFontDescriptionHandle Describe(this PangoFontFaceHandle face)
	{
		return PangoFontFaceExterns.pango_font_face_describe(face);
	}

	public static string GetFaceName(this PangoFontFaceHandle face)
	{
		return PangoFontFaceExterns.pango_font_face_get_face_name(face);
	}

	public static PangoFontFamilyHandle GetFamily(this PangoFontFaceHandle face)
	{
		return PangoFontFaceExterns.pango_font_face_get_family(face);
	}

	public static bool IsSynthesized(this PangoFontFaceHandle face)
	{
		return PangoFontFaceExterns.pango_font_face_is_synthesized(face);
	}

	public static PangoFontFaceHandle ListSizes(this PangoFontFaceHandle face, out int[] sizes, out int n_sizes)
	{
		PangoFontFaceExterns.pango_font_face_list_sizes(face, out sizes, out n_sizes);
		return face;
	}

}

internal class PangoFontFaceExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoFontDescriptionHandle pango_font_face_describe(PangoFontFaceHandle face);
	[DllImport(Libraries.Pango)]
	internal static extern string pango_font_face_get_face_name(PangoFontFaceHandle face);
	[DllImport(Libraries.Pango)]
	internal static extern PangoFontFamilyHandle pango_font_face_get_family(PangoFontFaceHandle face);
	[DllImport(Libraries.Pango)]
	internal static extern bool pango_font_face_is_synthesized(PangoFontFaceHandle face);
	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_face_list_sizes(PangoFontFaceHandle face, out int[] sizes, out int n_sizes);
}
