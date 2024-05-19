namespace MentorLake.Gtk4.Gtk4;

public class GtkIMContextSimpleHandle : GtkIMContextHandle
{
	public static GtkIMContextSimpleHandle GtkImContextSimpleNew()
	{
		return GtkIMContextSimpleExterns.gtk_im_context_simple_new();
	}

}

public static class GtkIMContextSimpleHandleExtensions
{
	public static GtkIMContextSimpleHandle GtkImContextSimpleAddComposeFile(this GtkIMContextSimpleHandle context_simple, string compose_file)
	{
		GtkIMContextSimpleExterns.gtk_im_context_simple_add_compose_file(context_simple, compose_file);
		return context_simple;
	}

	public static GtkIMContextSimpleHandle GtkImContextSimpleAddTable(this GtkIMContextSimpleHandle context_simple, ushort[] data, int max_seq_len, int n_seqs)
	{
		GtkIMContextSimpleExterns.gtk_im_context_simple_add_table(context_simple, data, max_seq_len, n_seqs);
		return context_simple;
	}

}

internal class GtkIMContextSimpleExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkIMContextSimpleHandle gtk_im_context_simple_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_im_context_simple_add_compose_file(GtkIMContextSimpleHandle context_simple, string compose_file);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_im_context_simple_add_table(GtkIMContextSimpleHandle context_simple, ushort[] data, int max_seq_len, int n_seqs);

}
