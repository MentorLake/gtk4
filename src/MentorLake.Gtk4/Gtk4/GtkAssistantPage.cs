namespace MentorLake.Gtk4.Gtk4;

public class GtkAssistantPageHandle : GObjectHandle
{
}

public static class GtkAssistantPageHandleExtensions
{
	public static GtkWidgetHandle GetChild(this GtkAssistantPageHandle page)
	{
		return GtkAssistantPageExterns.gtk_assistant_page_get_child(page);
	}

}

internal class GtkAssistantPageExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_assistant_page_get_child(GtkAssistantPageHandle page);

}
