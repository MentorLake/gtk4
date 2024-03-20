using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GObjectClassAdaptors
{
    public static uint GtkEditableInstallProperties(this GObjectClassHandle object_class, uint first_prop)
    {
        return GObjectClassExterns.gtk_editable_install_properties(object_class, first_prop);
    }
}
