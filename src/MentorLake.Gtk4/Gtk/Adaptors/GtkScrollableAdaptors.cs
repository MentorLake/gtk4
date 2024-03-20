using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkScrollableAdaptors
{
    public static GtkAdjustmentHandle GetHadjustment(this GtkScrollableHandle scrollable)
    {
        return GtkScrollableExterns.gtk_scrollable_get_hadjustment(scrollable);
    }

    public static GtkScrollableHandle SetHadjustment(this GtkScrollableHandle scrollable, GtkAdjustmentHandle hadjustment)
    {
        GtkScrollableExterns.gtk_scrollable_set_hadjustment(scrollable, hadjustment);
        return scrollable;
    }

    public static GtkAdjustmentHandle GetVadjustment(this GtkScrollableHandle scrollable)
    {
        return GtkScrollableExterns.gtk_scrollable_get_vadjustment(scrollable);
    }

    public static GtkScrollableHandle SetVadjustment(this GtkScrollableHandle scrollable, GtkAdjustmentHandle vadjustment)
    {
        GtkScrollableExterns.gtk_scrollable_set_vadjustment(scrollable, vadjustment);
        return scrollable;
    }

    public static GtkScrollablePolicy GetHscrollPolicy(this GtkScrollableHandle scrollable)
    {
        return GtkScrollableExterns.gtk_scrollable_get_hscroll_policy(scrollable);
    }

    public static GtkScrollableHandle SetHscrollPolicy(this GtkScrollableHandle scrollable, GtkScrollablePolicy policy)
    {
        GtkScrollableExterns.gtk_scrollable_set_hscroll_policy(scrollable, policy);
        return scrollable;
    }

    public static GtkScrollablePolicy GetVscrollPolicy(this GtkScrollableHandle scrollable)
    {
        return GtkScrollableExterns.gtk_scrollable_get_vscroll_policy(scrollable);
    }

    public static GtkScrollableHandle SetVscrollPolicy(this GtkScrollableHandle scrollable, GtkScrollablePolicy policy)
    {
        GtkScrollableExterns.gtk_scrollable_set_vscroll_policy(scrollable, policy);
        return scrollable;
    }

    public static int GetBorder(this GtkScrollableHandle scrollable, GtkBorderHandle border)
    {
        return GtkScrollableExterns.gtk_scrollable_get_border(scrollable, border);
    }
}
