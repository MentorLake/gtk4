using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;
public static class GtkRootAdaptors
{
    public static GdkDisplayHandle GetDisplay(this GtkRootHandle self)
    {
        return GtkRootExterns.gtk_root_get_display(self);
    }

    public static GtkRootHandle SetFocus(this GtkRootHandle self, GtkWidgetHandle focus)
    {
        GtkRootExterns.gtk_root_set_focus(self, focus);
        return self;
    }

    public static GtkWidgetHandle GetFocus(this GtkRootHandle self)
    {
        return GtkRootExterns.gtk_root_get_focus(self);
    }
}
