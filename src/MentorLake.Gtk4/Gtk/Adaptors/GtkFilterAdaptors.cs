using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFilterAdaptors
{
    public static int Match(this GtkFilterHandle self, IntPtr item)
    {
        return GtkFilterExterns.gtk_filter_match(self, item);
    }

    public static GtkFilterMatch GetStrictness(this GtkFilterHandle self)
    {
        return GtkFilterExterns.gtk_filter_get_strictness(self);
    }

    public static GtkFilterHandle Changed(this GtkFilterHandle self, GtkFilterChange change)
    {
        GtkFilterExterns.gtk_filter_changed(self, change);
        return self;
    }
}
