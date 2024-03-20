using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkATContextAdaptors
{
    public static GtkAccessibleHandle GtkAtContextGetAccessible(this GtkATContextHandle self)
    {
        return GtkATContextExterns.gtk_at_context_get_accessible(self);
    }

    public static GtkAccessibleRole GtkAtContextGetAccessibleRole(this GtkATContextHandle self)
    {
        return GtkATContextExterns.gtk_at_context_get_accessible_role(self);
    }
}
