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

public class GtkExpressionHandle : GTypeInstanceHandle
{
}

public static class GtkExpressionHandleExtensions
{
	public static GtkExpressionWatchHandle Bind(this GtkExpressionHandle self, GObjectHandle target, string property, GObjectHandle this_)
	{
		return GtkExpressionExterns.gtk_expression_bind(self, target, property, this_);
	}

	public static bool Evaluate(this GtkExpressionHandle self, GObjectHandle this_, GValueHandle value)
	{
		return GtkExpressionExterns.gtk_expression_evaluate(self, this_, value);
	}

	public static GType GetValueType(this GtkExpressionHandle self)
	{
		return GtkExpressionExterns.gtk_expression_get_value_type(self);
	}

	public static bool IsStatic(this GtkExpressionHandle self)
	{
		return GtkExpressionExterns.gtk_expression_is_static(self);
	}

	public static GtkExpressionHandle Ref(this GtkExpressionHandle self)
	{
		return GtkExpressionExterns.gtk_expression_ref(self);
	}

	public static GtkExpressionHandle Unref(this GtkExpressionHandle self)
	{
		GtkExpressionExterns.gtk_expression_unref(self);
		return self;
	}

	public static GtkExpressionWatchHandle Watch(this GtkExpressionHandle self, GObjectHandle this_, GtkExpressionNotify notify, IntPtr user_data, GDestroyNotify user_destroy)
	{
		return GtkExpressionExterns.gtk_expression_watch(self, this_, notify, user_data, user_destroy);
	}

}

internal class GtkExpressionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkExpressionWatchHandle gtk_expression_bind(GtkExpressionHandle self, GObjectHandle target, string property, GObjectHandle this_);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_expression_evaluate(GtkExpressionHandle self, GObjectHandle this_, GValueHandle value);

	[DllImport(Libraries.Gtk4)]
	internal static extern GType gtk_expression_get_value_type(GtkExpressionHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_expression_is_static(GtkExpressionHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkExpressionHandle gtk_expression_ref(GtkExpressionHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_expression_unref(GtkExpressionHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkExpressionWatchHandle gtk_expression_watch(GtkExpressionHandle self, GObjectHandle this_, GtkExpressionNotify notify, IntPtr user_data, GDestroyNotify user_destroy);

}
