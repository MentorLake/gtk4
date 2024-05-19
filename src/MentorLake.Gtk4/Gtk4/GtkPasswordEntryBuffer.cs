namespace MentorLake.Gtk4.Gtk4;

public class GtkPasswordEntryBufferHandle : GtkEntryBufferHandle
{
	public static GtkPasswordEntryBufferHandle New()
	{
		return GtkPasswordEntryBufferExterns.gtk_password_entry_buffer_new();
	}

}

public static class GtkPasswordEntryBufferHandleExtensions
{
}

internal class GtkPasswordEntryBufferExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPasswordEntryBufferHandle gtk_password_entry_buffer_new();

}
