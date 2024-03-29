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

public class GtkPropertyExpressionHandle : GtkExpressionHandle
{
	public static GtkPropertyExpressionHandle New(GType this_type, GtkExpressionHandle expression, string property_name)
	{
		return GtkPropertyExpressionExterns.gtk_property_expression_new(this_type, expression, property_name);
	}

	public static GtkPropertyExpressionHandle NewForPspec(GtkExpressionHandle expression, GParamSpecHandle pspec)
	{
		return GtkPropertyExpressionExterns.gtk_property_expression_new_for_pspec(expression, pspec);
	}

}

public static class GtkPropertyExpressionHandleExtensions
{
	public static GtkExpressionHandle GetExpression(this GtkPropertyExpressionHandle expression)
	{
		return GtkPropertyExpressionExterns.gtk_property_expression_get_expression(expression);
	}

	public static GParamSpecHandle GetPspec(this GtkPropertyExpressionHandle expression)
	{
		return GtkPropertyExpressionExterns.gtk_property_expression_get_pspec(expression);
	}

}

internal class GtkPropertyExpressionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPropertyExpressionHandle gtk_property_expression_new(GType this_type, GtkExpressionHandle expression, string property_name);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPropertyExpressionHandle gtk_property_expression_new_for_pspec(GtkExpressionHandle expression, GParamSpecHandle pspec);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkExpressionHandle gtk_property_expression_get_expression(GtkExpressionHandle expression);
	[DllImport(Libraries.Gtk4)]
	internal static extern GParamSpecHandle gtk_property_expression_get_pspec(GtkExpressionHandle expression);
}
