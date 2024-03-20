using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCellAreaClassAdaptors
{
    public static GtkCellAreaClassHandle InstallCellProperty(this GtkCellAreaClassHandle aclass, uint property_id, GParamSpecHandle pspec)
    {
        GtkCellAreaClassExterns.gtk_cell_area_class_install_cell_property(aclass, property_id, pspec);
        return aclass;
    }

    public static GParamSpecHandle FindCellProperty(this GtkCellAreaClassHandle aclass, string property_name)
    {
        return GtkCellAreaClassExterns.gtk_cell_area_class_find_cell_property(aclass, property_name);
    }

    public static GParamSpecHandle[] ListCellProperties(this GtkCellAreaClassHandle aclass, out uint n_properties)
    {
        return GtkCellAreaClassExterns.gtk_cell_area_class_list_cell_properties(aclass, out n_properties);
    }
}
