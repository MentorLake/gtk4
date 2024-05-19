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

namespace MentorLake.Gtk4.Gtk4;

public class GtkBoolFilterHandle : GtkFilterHandle
{
	public static GtkBoolFilterHandle New(GtkExpressionHandle expression)
	{
		return GtkBoolFilterExterns.gtk_bool_filter_new(expression);
	}

}

public static class GtkBoolFilterHandleExtensions
{
	public static GtkExpressionHandle GetExpression(this GtkBoolFilterHandle self)
	{
		return GtkBoolFilterExterns.gtk_bool_filter_get_expression(self);
	}

	public static bool GetInvert(this GtkBoolFilterHandle self)
	{
		return GtkBoolFilterExterns.gtk_bool_filter_get_invert(self);
	}

	public static GtkBoolFilterHandle SetExpression(this GtkBoolFilterHandle self, GtkExpressionHandle expression)
	{
		GtkBoolFilterExterns.gtk_bool_filter_set_expression(self, expression);
		return self;
	}

	public static GtkBoolFilterHandle SetInvert(this GtkBoolFilterHandle self, bool invert)
	{
		GtkBoolFilterExterns.gtk_bool_filter_set_invert(self, invert);
		return self;
	}

}

internal class GtkBoolFilterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBoolFilterHandle gtk_bool_filter_new(GtkExpressionHandle expression);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkExpressionHandle gtk_bool_filter_get_expression(GtkBoolFilterHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_bool_filter_get_invert(GtkBoolFilterHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_bool_filter_set_expression(GtkBoolFilterHandle self, GtkExpressionHandle expression);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_bool_filter_set_invert(GtkBoolFilterHandle self, bool invert);

}
