using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkBuildableAdaptors
{
    public static string GetBuildableId(this GtkBuildableHandle buildable)
    {
        return GtkBuildableExterns.gtk_buildable_get_buildable_id(buildable);
    }
}
