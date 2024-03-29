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

public class GtkStringSorterHandle : GtkSorterHandle
{
	public static GtkStringSorterHandle New(GtkExpressionHandle expression)
	{
		return GtkStringSorterExterns.gtk_string_sorter_new(expression);
	}

}

public static class GtkStringSorterHandleExtensions
{
	public static GtkCollation GetCollation(this GtkStringSorterHandle self)
	{
		return GtkStringSorterExterns.gtk_string_sorter_get_collation(self);
	}

	public static GtkExpressionHandle GetExpression(this GtkStringSorterHandle self)
	{
		return GtkStringSorterExterns.gtk_string_sorter_get_expression(self);
	}

	public static bool GetIgnoreCase(this GtkStringSorterHandle self)
	{
		return GtkStringSorterExterns.gtk_string_sorter_get_ignore_case(self);
	}

	public static GtkStringSorterHandle SetCollation(this GtkStringSorterHandle self, GtkCollation collation)
	{
		GtkStringSorterExterns.gtk_string_sorter_set_collation(self, collation);
		return self;
	}

	public static GtkStringSorterHandle SetExpression(this GtkStringSorterHandle self, GtkExpressionHandle expression)
	{
		GtkStringSorterExterns.gtk_string_sorter_set_expression(self, expression);
		return self;
	}

	public static GtkStringSorterHandle SetIgnoreCase(this GtkStringSorterHandle self, bool ignore_case)
	{
		GtkStringSorterExterns.gtk_string_sorter_set_ignore_case(self, ignore_case);
		return self;
	}

}

internal class GtkStringSorterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStringSorterHandle gtk_string_sorter_new(GtkExpressionHandle expression);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCollation gtk_string_sorter_get_collation(GtkStringSorterHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkExpressionHandle gtk_string_sorter_get_expression(GtkStringSorterHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_string_sorter_get_ignore_case(GtkStringSorterHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_string_sorter_set_collation(GtkStringSorterHandle self, GtkCollation collation);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_string_sorter_set_expression(GtkStringSorterHandle self, GtkExpressionHandle expression);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_string_sorter_set_ignore_case(GtkStringSorterHandle self, bool ignore_case);
}
