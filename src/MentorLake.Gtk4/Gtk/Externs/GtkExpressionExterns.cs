using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkExpressionExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expression_ref")]
    internal static extern GtkExpressionHandle gtk_expression_ref(this GtkExpressionHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expression_unref")]
    internal static extern void gtk_expression_unref(this GtkExpressionHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expression_get_value_type")]
    internal static extern GType gtk_expression_get_value_type(this GtkExpressionHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expression_is_static")]
    internal static extern int gtk_expression_is_static(this GtkExpressionHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expression_evaluate")]
    internal static extern int gtk_expression_evaluate(this GtkExpressionHandle self, IntPtr this_, GValueHandle value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expression_watch")]
    internal static extern GtkExpressionWatchHandle gtk_expression_watch(this GtkExpressionHandle self, IntPtr this_, GtkExpressionNotify notify, IntPtr user_data, GDestroyNotify user_destroy);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_expression_bind")]
    internal static extern GtkExpressionWatchHandle gtk_expression_bind(this GtkExpressionHandle self, IntPtr target, string property, IntPtr this_);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_property_expression_new_for_pspec")]
    internal static extern GtkExpressionHandle gtk_property_expression_new_for_pspec(this GtkExpressionHandle expression, GParamSpecHandle pspec);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_property_expression_get_expression")]
    internal static extern GtkExpressionHandle gtk_property_expression_get_expression(this GtkExpressionHandle expression);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_property_expression_get_pspec")]
    internal static extern GParamSpecHandle gtk_property_expression_get_pspec(this GtkExpressionHandle expression);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_constant_expression_get_value")]
    internal static extern GValueHandle gtk_constant_expression_get_value(this GtkExpressionHandle expression);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_object_expression_get_object")]
    internal static extern GObjectHandle gtk_object_expression_get_object(this GtkExpressionHandle expression);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_bool_filter_new")]
    internal static extern GtkBoolFilterHandle gtk_bool_filter_new(this GtkExpressionHandle expression);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_numeric_sorter_new")]
    internal static extern GtkNumericSorterHandle gtk_numeric_sorter_new(this GtkExpressionHandle expression);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_string_filter_new")]
    internal static extern GtkStringFilterHandle gtk_string_filter_new(this GtkExpressionHandle expression);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_string_sorter_new")]
    internal static extern GtkStringSorterHandle gtk_string_sorter_new(this GtkExpressionHandle expression);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkExpressionHandle gtk_property_expression_new(GType this_type, GtkExpressionHandle expression, string property_name);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkExpressionHandle gtk_constant_expression_new(GType value_type, IntPtr @__arglist);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkExpressionHandle gtk_constant_expression_new_for_value(GValueHandle value);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkExpressionHandle gtk_object_expression_new(GObjectHandle @object);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkExpressionHandle gtk_closure_expression_new(GType value_type, GClosureHandle closure, uint n_params, out GtkExpression[] @params);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkExpressionHandle gtk_cclosure_expression_new(GType value_type, GClosureMarshal marshal, uint n_params, GtkExpression[] @params, GCallback callback_func, IntPtr user_data, GClosureNotify user_destroy);
}
