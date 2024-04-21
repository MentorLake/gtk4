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

public class GtkClosureExpressionHandle : GtkExpressionHandle
{
	public static GtkClosureExpressionHandle New(GType value_type, GClosureHandle closure, uint n_params, GtkExpressionHandle[] @params)
	{
		return GtkClosureExpressionExterns.gtk_closure_expression_new(value_type, closure, n_params, @params);
	}

}

public static class GtkClosureExpressionHandleExtensions
{
}

internal class GtkClosureExpressionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkClosureExpressionHandle gtk_closure_expression_new(GType value_type, GClosureHandle closure, uint n_params, GtkExpressionHandle[] @params);

}
