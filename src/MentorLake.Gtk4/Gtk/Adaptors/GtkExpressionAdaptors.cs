using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkExpressionAdaptors
{
	public static GtkExpressionHandle Ref(this GtkExpressionHandle self)
	{
		return GtkExpressionExterns.gtk_expression_ref(self);
	}

	public static GtkExpressionHandle Unref(this GtkExpressionHandle self)
	{
		GtkExpressionExterns.gtk_expression_unref(self);
		return self;
	}

	public static GType GetValueType(this GtkExpressionHandle self)
	{
		return GtkExpressionExterns.gtk_expression_get_value_type(self);
	}

	public static int IsStatic(this GtkExpressionHandle self)
	{
		return GtkExpressionExterns.gtk_expression_is_static(self);
	}

	public static int Evaluate(this GtkExpressionHandle self, IntPtr this_, GValueHandle value)
	{
		return GtkExpressionExterns.gtk_expression_evaluate(self, this_, value);
	}

	public static GtkExpressionWatchHandle Watch(this GtkExpressionHandle self, IntPtr this_, GtkExpressionNotify notify, IntPtr user_data, GDestroyNotify user_destroy)
	{
		return GtkExpressionExterns.gtk_expression_watch(self, this_, notify, user_data, user_destroy);
	}

	public static GtkExpressionWatchHandle Bind(this GtkExpressionHandle self, IntPtr target, string property, IntPtr this_)
	{
		return GtkExpressionExterns.gtk_expression_bind(self, target, property, this_);
	}

	public static GtkExpressionHandle GtkPropertyExpressionNewForPspec(this GtkExpressionHandle expression, GParamSpecHandle pspec)
	{
		return GtkExpressionExterns.gtk_property_expression_new_for_pspec(expression, pspec);
	}

	public static GtkExpressionHandle GtkPropertyExpressionGetExpression(this GtkExpressionHandle expression)
	{
		return GtkExpressionExterns.gtk_property_expression_get_expression(expression);
	}

	public static GParamSpecHandle GtkPropertyExpressionGetPspec(this GtkExpressionHandle expression)
	{
		return GtkExpressionExterns.gtk_property_expression_get_pspec(expression);
	}

	public static GValueHandle GtkConstantExpressionGetValue(this GtkExpressionHandle expression)
	{
		return GtkExpressionExterns.gtk_constant_expression_get_value(expression);
	}

	public static GObjectHandle GtkObjectExpressionGetObject(this GtkExpressionHandle expression)
	{
		return GtkExpressionExterns.gtk_object_expression_get_object(expression);
	}

	public static GtkBoolFilterHandle GtkBoolFilterNew(this GtkExpressionHandle expression)
	{
		return GtkExpressionExterns.gtk_bool_filter_new(expression);
	}

	public static GtkNumericSorterHandle GtkNumericSorterNew(this GtkExpressionHandle expression)
	{
		return GtkExpressionExterns.gtk_numeric_sorter_new(expression);
	}

	public static GtkStringFilterHandle GtkStringFilterNew(this GtkExpressionHandle expression)
	{
		return GtkExpressionExterns.gtk_string_filter_new(expression);
	}

	public static GtkStringSorterHandle GtkStringSorterNew(this GtkExpressionHandle expression)
	{
		return GtkExpressionExterns.gtk_string_sorter_new(expression);
	}

	public static GtkExpressionHandle GtkConstantExpressionNew(GType value_type, IntPtr @__arglist)
	{
		return GtkExpressionExterns.gtk_constant_expression_new(value_type, @__arglist);
	}

	public static GtkExpressionHandle GtkConstantExpressionNewForValue(GValueHandle value)
	{
		return GtkExpressionExterns.gtk_constant_expression_new_for_value(value);
	}

	public static GtkExpressionHandle GtkObjectExpressionNew(GObjectHandle @object)
	{
		return GtkExpressionExterns.gtk_object_expression_new(@object);
	}

	public static GtkExpressionHandle GtkClosureExpressionNew(GType value_type, GClosureHandle closure, uint n_params, out GtkExpression[] @params)
	{
		return GtkExpressionExterns.gtk_closure_expression_new(value_type, closure, n_params, out @params);
	}

	public static GtkExpressionHandle GtkCclosureExpressionNew(GType value_type, GClosureMarshal marshal, uint n_params, GtkExpression[] @params, GCallback callback_func, IntPtr user_data, GClosureNotify user_destroy)
	{
		return GtkExpressionExterns.gtk_cclosure_expression_new(value_type, marshal, n_params, @params, callback_func, user_data, user_destroy);
	}
}
