using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkAssistantPageExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_assistant_page_get_child")]
	internal static extern GtkWidgetHandle gtk_assistant_page_get_child(this GtkAssistantPageHandle page);
}
