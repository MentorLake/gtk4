using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GValueAdaptors
{
    public static GValueHandle GtkValueSetExpression(this GValueHandle value, GtkExpressionHandle expression)
    {
        GValueExterns.gtk_value_set_expression(value, expression);
        return value;
    }

    public static GValueHandle GtkValueTakeExpression(this GValueHandle value, GtkExpressionHandle expression)
    {
        GValueExterns.gtk_value_take_expression(value, expression);
        return value;
    }

    public static GtkExpressionHandle GtkValueGetExpression(this GValueHandle value)
    {
        return GValueExterns.gtk_value_get_expression(value);
    }

    public static GtkExpressionHandle GtkValueDupExpression(this GValueHandle value)
    {
        return GValueExterns.gtk_value_dup_expression(value);
    }

    public static GtkWidgetHandle GtkDragIconCreateWidgetForValue(this GValueHandle value)
    {
        return GValueExterns.gtk_drag_icon_create_widget_for_value(value);
    }

    public static int GtkTreeGetRowDragData(this GValueHandle value, out GtkTreeModelHandle tree_model, out GtkTreePathHandle path)
    {
        return GValueExterns.gtk_tree_get_row_drag_data(value, out tree_model, out path);
    }
}
