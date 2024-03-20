using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkListViewAdaptors
{
    public static GtkSelectionModelHandle GetModel(this GtkListViewHandle self)
    {
        return GtkListViewExterns.gtk_list_view_get_model(self);
    }

    public static GtkListViewHandle SetModel(this GtkListViewHandle self, GtkSelectionModelHandle model)
    {
        GtkListViewExterns.gtk_list_view_set_model(self, model);
        return self;
    }

    public static GtkListViewHandle SetFactory(this GtkListViewHandle self, GtkListItemFactoryHandle factory)
    {
        GtkListViewExterns.gtk_list_view_set_factory(self, factory);
        return self;
    }

    public static GtkListItemFactoryHandle GetFactory(this GtkListViewHandle self)
    {
        return GtkListViewExterns.gtk_list_view_get_factory(self);
    }

    public static GtkListViewHandle SetShowSeparators(this GtkListViewHandle self, int show_separators)
    {
        GtkListViewExterns.gtk_list_view_set_show_separators(self, show_separators);
        return self;
    }

    public static int GetShowSeparators(this GtkListViewHandle self)
    {
        return GtkListViewExterns.gtk_list_view_get_show_separators(self);
    }

    public static GtkListViewHandle SetSingleClickActivate(this GtkListViewHandle self, int single_click_activate)
    {
        GtkListViewExterns.gtk_list_view_set_single_click_activate(self, single_click_activate);
        return self;
    }

    public static int GetSingleClickActivate(this GtkListViewHandle self)
    {
        return GtkListViewExterns.gtk_list_view_get_single_click_activate(self);
    }

    public static GtkListViewHandle SetEnableRubberband(this GtkListViewHandle self, int enable_rubberband)
    {
        GtkListViewExterns.gtk_list_view_set_enable_rubberband(self, enable_rubberband);
        return self;
    }

    public static int GetEnableRubberband(this GtkListViewHandle self)
    {
        return GtkListViewExterns.gtk_list_view_get_enable_rubberband(self);
    }
}
