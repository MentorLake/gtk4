using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkIMContextSimpleExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_im_context_simple_add_table")]
	[Obsolete]
		internal static extern void gtk_im_context_simple_add_table(this GtkIMContextSimpleHandle context_simple, ushort[] data, int max_seq_len, int n_seqs);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_im_context_simple_add_compose_file")]
	internal static extern void gtk_im_context_simple_add_compose_file(this GtkIMContextSimpleHandle context_simple, string compose_file);
}
