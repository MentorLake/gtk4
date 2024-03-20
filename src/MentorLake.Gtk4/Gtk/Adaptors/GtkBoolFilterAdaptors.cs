using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBoolFilterAdaptors
{
    public static GtkExpressionHandle GetExpression(this GtkBoolFilterHandle self)
    {
        return GtkBoolFilterExterns.gtk_bool_filter_get_expression(self);
    }

    public static GtkBoolFilterHandle SetExpression(this GtkBoolFilterHandle self, GtkExpressionHandle expression)
    {
        GtkBoolFilterExterns.gtk_bool_filter_set_expression(self, expression);
        return self;
    }

    public static int GetInvert(this GtkBoolFilterHandle self)
    {
        return GtkBoolFilterExterns.gtk_bool_filter_get_invert(self);
    }

    public static GtkBoolFilterHandle SetInvert(this GtkBoolFilterHandle self, int invert)
    {
        GtkBoolFilterExterns.gtk_bool_filter_set_invert(self, invert);
        return self;
    }
}
