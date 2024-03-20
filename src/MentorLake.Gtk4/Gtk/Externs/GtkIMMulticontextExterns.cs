using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkIMMulticontextExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_im_multicontext_get_context_id")]
	internal static extern string gtk_im_multicontext_get_context_id(this GtkIMMulticontextHandle context);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_im_multicontext_set_context_id")]
	internal static extern void gtk_im_multicontext_set_context_id(this GtkIMMulticontextHandle context, string context_id);
}
