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

public class GtkInscriptionHandle : GtkWidgetHandle
{
	public static GtkInscriptionHandle New(string text)
	{
		return GtkInscriptionExterns.gtk_inscription_new(text);
	}

}

public static class GtkInscriptionHandleExtensions
{
	public static PangoAttrListHandle GetAttributes(this GtkInscriptionHandle self)
	{
		return GtkInscriptionExterns.gtk_inscription_get_attributes(self);
	}

	public static uint GetMinChars(this GtkInscriptionHandle self)
	{
		return GtkInscriptionExterns.gtk_inscription_get_min_chars(self);
	}

	public static uint GetMinLines(this GtkInscriptionHandle self)
	{
		return GtkInscriptionExterns.gtk_inscription_get_min_lines(self);
	}

	public static uint GetNatChars(this GtkInscriptionHandle self)
	{
		return GtkInscriptionExterns.gtk_inscription_get_nat_chars(self);
	}

	public static uint GetNatLines(this GtkInscriptionHandle self)
	{
		return GtkInscriptionExterns.gtk_inscription_get_nat_lines(self);
	}

	public static string GetText(this GtkInscriptionHandle self)
	{
		return GtkInscriptionExterns.gtk_inscription_get_text(self);
	}

	public static GtkInscriptionOverflow GetTextOverflow(this GtkInscriptionHandle self)
	{
		return GtkInscriptionExterns.gtk_inscription_get_text_overflow(self);
	}

	public static PangoWrapMode GetWrapMode(this GtkInscriptionHandle self)
	{
		return GtkInscriptionExterns.gtk_inscription_get_wrap_mode(self);
	}

	public static float GetXalign(this GtkInscriptionHandle self)
	{
		return GtkInscriptionExterns.gtk_inscription_get_xalign(self);
	}

	public static float GetYalign(this GtkInscriptionHandle self)
	{
		return GtkInscriptionExterns.gtk_inscription_get_yalign(self);
	}

	public static GtkInscriptionHandle SetAttributes(this GtkInscriptionHandle self, PangoAttrListHandle attrs)
	{
		GtkInscriptionExterns.gtk_inscription_set_attributes(self, attrs);
		return self;
	}

	public static GtkInscriptionHandle SetMarkup(this GtkInscriptionHandle self, string markup)
	{
		GtkInscriptionExterns.gtk_inscription_set_markup(self, markup);
		return self;
	}

	public static GtkInscriptionHandle SetMinChars(this GtkInscriptionHandle self, uint min_chars)
	{
		GtkInscriptionExterns.gtk_inscription_set_min_chars(self, min_chars);
		return self;
	}

	public static GtkInscriptionHandle SetMinLines(this GtkInscriptionHandle self, uint min_lines)
	{
		GtkInscriptionExterns.gtk_inscription_set_min_lines(self, min_lines);
		return self;
	}

	public static GtkInscriptionHandle SetNatChars(this GtkInscriptionHandle self, uint nat_chars)
	{
		GtkInscriptionExterns.gtk_inscription_set_nat_chars(self, nat_chars);
		return self;
	}

	public static GtkInscriptionHandle SetNatLines(this GtkInscriptionHandle self, uint nat_lines)
	{
		GtkInscriptionExterns.gtk_inscription_set_nat_lines(self, nat_lines);
		return self;
	}

	public static GtkInscriptionHandle SetText(this GtkInscriptionHandle self, string text)
	{
		GtkInscriptionExterns.gtk_inscription_set_text(self, text);
		return self;
	}

	public static GtkInscriptionHandle SetTextOverflow(this GtkInscriptionHandle self, GtkInscriptionOverflow overflow)
	{
		GtkInscriptionExterns.gtk_inscription_set_text_overflow(self, overflow);
		return self;
	}

	public static GtkInscriptionHandle SetWrapMode(this GtkInscriptionHandle self, PangoWrapMode wrap_mode)
	{
		GtkInscriptionExterns.gtk_inscription_set_wrap_mode(self, wrap_mode);
		return self;
	}

	public static GtkInscriptionHandle SetXalign(this GtkInscriptionHandle self, float xalign)
	{
		GtkInscriptionExterns.gtk_inscription_set_xalign(self, xalign);
		return self;
	}

	public static GtkInscriptionHandle SetYalign(this GtkInscriptionHandle self, float yalign)
	{
		GtkInscriptionExterns.gtk_inscription_set_yalign(self, yalign);
		return self;
	}

}

internal class GtkInscriptionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInscriptionHandle gtk_inscription_new(string text);
	[DllImport(Libraries.Gtk4)]
	internal static extern PangoAttrListHandle gtk_inscription_get_attributes(GtkInscriptionHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_inscription_get_min_chars(GtkInscriptionHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_inscription_get_min_lines(GtkInscriptionHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_inscription_get_nat_chars(GtkInscriptionHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_inscription_get_nat_lines(GtkInscriptionHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_inscription_get_text(GtkInscriptionHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInscriptionOverflow gtk_inscription_get_text_overflow(GtkInscriptionHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern PangoWrapMode gtk_inscription_get_wrap_mode(GtkInscriptionHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern float gtk_inscription_get_xalign(GtkInscriptionHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern float gtk_inscription_get_yalign(GtkInscriptionHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_inscription_set_attributes(GtkInscriptionHandle self, PangoAttrListHandle attrs);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_inscription_set_markup(GtkInscriptionHandle self, string markup);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_inscription_set_min_chars(GtkInscriptionHandle self, uint min_chars);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_inscription_set_min_lines(GtkInscriptionHandle self, uint min_lines);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_inscription_set_nat_chars(GtkInscriptionHandle self, uint nat_chars);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_inscription_set_nat_lines(GtkInscriptionHandle self, uint nat_lines);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_inscription_set_text(GtkInscriptionHandle self, string text);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_inscription_set_text_overflow(GtkInscriptionHandle self, GtkInscriptionOverflow overflow);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_inscription_set_wrap_mode(GtkInscriptionHandle self, PangoWrapMode wrap_mode);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_inscription_set_xalign(GtkInscriptionHandle self, float xalign);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_inscription_set_yalign(GtkInscriptionHandle self, float yalign);
}
