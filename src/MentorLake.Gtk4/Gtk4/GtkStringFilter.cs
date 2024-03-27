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

public class GtkStringFilterHandle : GtkFilterHandle
{
	public static GtkStringFilterHandle New(GtkExpressionHandle expression)
	{
		return GtkStringFilterExterns.gtk_string_filter_new(expression);
	}
}

public static class GtkStringFilterSignals
{
}

public static class GtkStringFilterHandleExtensions
{
	public static GtkExpressionHandle GetExpression(this GtkStringFilterHandle self)
	{
		return GtkStringFilterExterns.gtk_string_filter_get_expression(self);
	}

	public static bool GetIgnoreCase(this GtkStringFilterHandle self)
	{
		return GtkStringFilterExterns.gtk_string_filter_get_ignore_case(self);
	}

	public static GtkStringFilterMatchMode GetMatchMode(this GtkStringFilterHandle self)
	{
		return GtkStringFilterExterns.gtk_string_filter_get_match_mode(self);
	}

	public static string GetSearch(this GtkStringFilterHandle self)
	{
		return GtkStringFilterExterns.gtk_string_filter_get_search(self);
	}

	public static GtkStringFilterHandle SetExpression(this GtkStringFilterHandle self, GtkExpressionHandle expression)
	{
		GtkStringFilterExterns.gtk_string_filter_set_expression(self, expression);
		return self;
	}

	public static GtkStringFilterHandle SetIgnoreCase(this GtkStringFilterHandle self, bool ignore_case)
	{
		GtkStringFilterExterns.gtk_string_filter_set_ignore_case(self, ignore_case);
		return self;
	}

	public static GtkStringFilterHandle SetMatchMode(this GtkStringFilterHandle self, GtkStringFilterMatchMode mode)
	{
		GtkStringFilterExterns.gtk_string_filter_set_match_mode(self, mode);
		return self;
	}

	public static GtkStringFilterHandle SetSearch(this GtkStringFilterHandle self, string search)
	{
		GtkStringFilterExterns.gtk_string_filter_set_search(self, search);
		return self;
	}

}

internal class GtkStringFilterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkExpressionHandle gtk_string_filter_get_expression(GtkStringFilterHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_string_filter_get_ignore_case(GtkStringFilterHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStringFilterMatchMode gtk_string_filter_get_match_mode(GtkStringFilterHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_string_filter_get_search(GtkStringFilterHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_string_filter_set_expression(GtkStringFilterHandle self, GtkExpressionHandle expression);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_string_filter_set_ignore_case(GtkStringFilterHandle self, bool ignore_case);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_string_filter_set_match_mode(GtkStringFilterHandle self, GtkStringFilterMatchMode mode);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_string_filter_set_search(GtkStringFilterHandle self, string search);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkStringFilterHandle gtk_string_filter_new(GtkExpressionHandle expression);
}
