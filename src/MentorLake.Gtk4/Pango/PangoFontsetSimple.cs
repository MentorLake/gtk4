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

public class PangoFontsetSimpleHandle : PangoFontsetHandle
{
	public static PangoFontsetSimpleHandle New(PangoLanguageHandle language)
	{
		return PangoFontsetSimpleExterns.pango_fontset_simple_new(language);
	}

}

public static class PangoFontsetSimpleHandleExtensions
{
	public static PangoFontsetSimpleHandle Append(this PangoFontsetSimpleHandle fontset, PangoFontHandle font)
	{
		PangoFontsetSimpleExterns.pango_fontset_simple_append(fontset, font);
		return fontset;
	}

	public static int Size(this PangoFontsetSimpleHandle fontset)
	{
		return PangoFontsetSimpleExterns.pango_fontset_simple_size(fontset);
	}

}

internal class PangoFontsetSimpleExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoFontsetSimpleHandle pango_fontset_simple_new(PangoLanguageHandle language);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_fontset_simple_append(PangoFontsetSimpleHandle fontset, PangoFontHandle font);

	[DllImport(Libraries.Pango)]
	internal static extern int pango_fontset_simple_size(PangoFontsetSimpleHandle fontset);

}
