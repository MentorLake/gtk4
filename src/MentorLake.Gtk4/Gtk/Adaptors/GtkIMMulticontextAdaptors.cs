using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkIMMulticontextAdaptors
{
    public static string GtkImMulticontextGetContextId(this GtkIMMulticontextHandle context)
    {
        return GtkIMMulticontextExterns.gtk_im_multicontext_get_context_id(context);
    }

    public static GtkIMMulticontextHandle GtkImMulticontextSetContextId(this GtkIMMulticontextHandle context, string context_id)
    {
        GtkIMMulticontextExterns.gtk_im_multicontext_set_context_id(context, context_id);
        return context;
    }
}
