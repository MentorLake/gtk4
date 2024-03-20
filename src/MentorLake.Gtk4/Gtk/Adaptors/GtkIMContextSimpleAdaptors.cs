using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkIMContextSimpleAdaptors
{
    public static GtkIMContextSimpleHandle GtkImContextSimpleAddTable(this GtkIMContextSimpleHandle context_simple, ushort[] data, int max_seq_len, int n_seqs)
    {
        GtkIMContextSimpleExterns.gtk_im_context_simple_add_table(context_simple, data, max_seq_len, n_seqs);
        return context_simple;
    }

    public static GtkIMContextSimpleHandle GtkImContextSimpleAddComposeFile(this GtkIMContextSimpleHandle context_simple, string compose_file)
    {
        GtkIMContextSimpleExterns.gtk_im_context_simple_add_compose_file(context_simple, compose_file);
        return context_simple;
    }
}
