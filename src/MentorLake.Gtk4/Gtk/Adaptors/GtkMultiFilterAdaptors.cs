using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkMultiFilterAdaptors
{
    public static GtkMultiFilterHandle Append(this GtkMultiFilterHandle self, GtkFilterHandle filter)
    {
        GtkMultiFilterExterns.gtk_multi_filter_append(self, filter);
        return self;
    }

    public static GtkMultiFilterHandle Remove(this GtkMultiFilterHandle self, uint position)
    {
        GtkMultiFilterExterns.gtk_multi_filter_remove(self, position);
        return self;
    }
}
