using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeIterAdaptors
{
    public static GtkTreeIterHandle Copy(this GtkTreeIterHandle iter)
    {
        return GtkTreeIterExterns.gtk_tree_iter_copy(iter);
    }

    public static GtkTreeIterHandle Free(this GtkTreeIterHandle iter)
    {
        GtkTreeIterExterns.gtk_tree_iter_free(iter);
        return iter;
    }
}
