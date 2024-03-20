using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkGridViewAdaptors
{
    public static GtkSelectionModelHandle GetModel(this GtkGridViewHandle self)
    {
        return GtkGridViewExterns.gtk_grid_view_get_model(self);
    }

    public static GtkGridViewHandle SetModel(this GtkGridViewHandle self, GtkSelectionModelHandle model)
    {
        GtkGridViewExterns.gtk_grid_view_set_model(self, model);
        return self;
    }

    public static GtkGridViewHandle SetFactory(this GtkGridViewHandle self, GtkListItemFactoryHandle factory)
    {
        GtkGridViewExterns.gtk_grid_view_set_factory(self, factory);
        return self;
    }

    public static GtkListItemFactoryHandle GetFactory(this GtkGridViewHandle self)
    {
        return GtkGridViewExterns.gtk_grid_view_get_factory(self);
    }

    public static uint GetMinColumns(this GtkGridViewHandle self)
    {
        return GtkGridViewExterns.gtk_grid_view_get_min_columns(self);
    }

    public static GtkGridViewHandle SetMinColumns(this GtkGridViewHandle self, uint min_columns)
    {
        GtkGridViewExterns.gtk_grid_view_set_min_columns(self, min_columns);
        return self;
    }

    public static uint GetMaxColumns(this GtkGridViewHandle self)
    {
        return GtkGridViewExterns.gtk_grid_view_get_max_columns(self);
    }

    public static GtkGridViewHandle SetMaxColumns(this GtkGridViewHandle self, uint max_columns)
    {
        GtkGridViewExterns.gtk_grid_view_set_max_columns(self, max_columns);
        return self;
    }

    public static GtkGridViewHandle SetEnableRubberband(this GtkGridViewHandle self, int enable_rubberband)
    {
        GtkGridViewExterns.gtk_grid_view_set_enable_rubberband(self, enable_rubberband);
        return self;
    }

    public static int GetEnableRubberband(this GtkGridViewHandle self)
    {
        return GtkGridViewExterns.gtk_grid_view_get_enable_rubberband(self);
    }

    public static GtkGridViewHandle SetSingleClickActivate(this GtkGridViewHandle self, int single_click_activate)
    {
        GtkGridViewExterns.gtk_grid_view_set_single_click_activate(self, single_click_activate);
        return self;
    }

    public static int GetSingleClickActivate(this GtkGridViewHandle self)
    {
        return GtkGridViewExterns.gtk_grid_view_get_single_click_activate(self);
    }
}
