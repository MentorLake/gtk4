using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkStringFilterAdaptors
{
    public static string GetSearch(this GtkStringFilterHandle self)
    {
        return GtkStringFilterExterns.gtk_string_filter_get_search(self);
    }

    public static GtkStringFilterHandle SetSearch(this GtkStringFilterHandle self, string search)
    {
        GtkStringFilterExterns.gtk_string_filter_set_search(self, search);
        return self;
    }

    public static GtkExpressionHandle GetExpression(this GtkStringFilterHandle self)
    {
        return GtkStringFilterExterns.gtk_string_filter_get_expression(self);
    }

    public static GtkStringFilterHandle SetExpression(this GtkStringFilterHandle self, GtkExpressionHandle expression)
    {
        GtkStringFilterExterns.gtk_string_filter_set_expression(self, expression);
        return self;
    }

    public static int GetIgnoreCase(this GtkStringFilterHandle self)
    {
        return GtkStringFilterExterns.gtk_string_filter_get_ignore_case(self);
    }

    public static GtkStringFilterHandle SetIgnoreCase(this GtkStringFilterHandle self, int ignore_case)
    {
        GtkStringFilterExterns.gtk_string_filter_set_ignore_case(self, ignore_case);
        return self;
    }

    public static GtkStringFilterMatchMode GetMatchMode(this GtkStringFilterHandle self)
    {
        return GtkStringFilterExterns.gtk_string_filter_get_match_mode(self);
    }

    public static GtkStringFilterHandle SetMatchMode(this GtkStringFilterHandle self, GtkStringFilterMatchMode mode)
    {
        GtkStringFilterExterns.gtk_string_filter_set_match_mode(self, mode);
        return self;
    }
}
