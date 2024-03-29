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

public class GtkObjectExpressionHandle : GtkExpressionHandle
{
	public static GtkObjectExpressionHandle New(GObjectHandle @object)
	{
		return GtkObjectExpressionExterns.gtk_object_expression_new(@object);
	}

}

public static class GtkObjectExpressionHandleExtensions
{
	public static GObjectHandle GetObject(this GtkObjectExpressionHandle expression)
	{
		return GtkObjectExpressionExterns.gtk_object_expression_get_object(expression);
	}

}

internal class GtkObjectExpressionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkObjectExpressionHandle gtk_object_expression_new(GObjectHandle @object);
	[DllImport(Libraries.Gtk4)]
	internal static extern GObjectHandle gtk_object_expression_get_object(GtkExpressionHandle expression);
}
