using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkExpressionWatchAdaptors
{
    public static GtkExpressionWatchHandle Ref(this GtkExpressionWatchHandle watch)
    {
        return GtkExpressionWatchExterns.gtk_expression_watch_ref(watch);
    }

    public static GtkExpressionWatchHandle Unref(this GtkExpressionWatchHandle watch)
    {
        GtkExpressionWatchExterns.gtk_expression_watch_unref(watch);
        return watch;
    }

    public static int Evaluate(this GtkExpressionWatchHandle watch, GValueHandle value)
    {
        return GtkExpressionWatchExterns.gtk_expression_watch_evaluate(watch, value);
    }

    public static GtkExpressionWatchHandle Unwatch(this GtkExpressionWatchHandle watch)
    {
        GtkExpressionWatchExterns.gtk_expression_watch_unwatch(watch);
        return watch;
    }
}
