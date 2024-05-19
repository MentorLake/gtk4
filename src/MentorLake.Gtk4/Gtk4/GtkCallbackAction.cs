namespace MentorLake.Gtk4.Gtk4;

public class GtkCallbackActionHandle : GtkShortcutActionHandle
{
	public static GtkCallbackActionHandle New(GtkShortcutFunc callback, IntPtr data, GDestroyNotify destroy)
	{
		return GtkCallbackActionExterns.gtk_callback_action_new(callback, data, destroy);
	}

}

public static class GtkCallbackActionHandleExtensions
{
}

internal class GtkCallbackActionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCallbackActionHandle gtk_callback_action_new(GtkShortcutFunc callback, IntPtr data, GDestroyNotify destroy);

}
