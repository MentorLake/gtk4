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

public class GtkConstantExpressionHandle : GtkExpressionHandle
{
	public static GtkConstantExpressionHandle New(GType value_type, IntPtr @__arglist)
	{
		return GtkConstantExpressionExterns.gtk_constant_expression_new(value_type, @__arglist);
	}

	public static GtkConstantExpressionHandle NewForValue(GValueHandle value)
	{
		return GtkConstantExpressionExterns.gtk_constant_expression_new_for_value(value);
	}

}

public static class GtkConstantExpressionHandleExtensions
{
	public static GValueHandle GetValue(this GtkConstantExpressionHandle expression)
	{
		return GtkConstantExpressionExterns.gtk_constant_expression_get_value(expression);
	}

}

internal class GtkConstantExpressionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkConstantExpressionHandle gtk_constant_expression_new(GType value_type, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkConstantExpressionHandle gtk_constant_expression_new_for_value(GValueHandle value);

	[DllImport(Libraries.Gtk4)]
	internal static extern GValueHandle gtk_constant_expression_get_value(GtkExpressionHandle expression);

}
