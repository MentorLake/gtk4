using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Pango;

public class PangoFontFamilyHandle : GObjectHandle, GListModelHandle
{
}

public static class PangoFontFamilyHandleExtensions
{
	public static PangoFontFaceHandle GetFace(this PangoFontFamilyHandle family, string name)
	{
		return PangoFontFamilyExterns.pango_font_family_get_face(family, name);
	}

	public static string GetName(this PangoFontFamilyHandle family)
	{
		return PangoFontFamilyExterns.pango_font_family_get_name(family);
	}

	public static bool IsMonospace(this PangoFontFamilyHandle family)
	{
		return PangoFontFamilyExterns.pango_font_family_is_monospace(family);
	}

	public static bool IsVariable(this PangoFontFamilyHandle family)
	{
		return PangoFontFamilyExterns.pango_font_family_is_variable(family);
	}

	public static PangoFontFamilyHandle ListFaces(this PangoFontFamilyHandle family, out PangoFontFaceHandle[] faces, out int n_faces)
	{
		PangoFontFamilyExterns.pango_font_family_list_faces(family, out faces, out n_faces);
		return family;
	}

}

internal class PangoFontFamilyExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoFontFaceHandle pango_font_family_get_face(PangoFontFamilyHandle family, string name);

	[DllImport(Libraries.Pango)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_font_family_get_name(PangoFontFamilyHandle family);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_font_family_is_monospace(PangoFontFamilyHandle family);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_font_family_is_variable(PangoFontFamilyHandle family);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_family_list_faces(PangoFontFamilyHandle family, out PangoFontFaceHandle[] faces, out int n_faces);

}
