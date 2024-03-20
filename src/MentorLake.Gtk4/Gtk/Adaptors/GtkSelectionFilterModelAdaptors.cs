using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkSelectionFilterModelAdaptors
{
    public static GtkSelectionFilterModelHandle SetModel(this GtkSelectionFilterModelHandle self, GtkSelectionModelHandle model)
    {
        GtkSelectionFilterModelExterns.gtk_selection_filter_model_set_model(self, model);
        return self;
    }

    public static GtkSelectionModelHandle GetModel(this GtkSelectionFilterModelHandle self)
    {
        return GtkSelectionFilterModelExterns.gtk_selection_filter_model_get_model(self);
    }
}
