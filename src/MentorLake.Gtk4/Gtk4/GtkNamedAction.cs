namespace MentorLake.Gtk4.Gtk4;

public class GtkNamedActionHandle : GtkShortcutActionHandle
{
	public static GtkNamedActionHandle New(string name)
	{
		return GtkNamedActionExterns.gtk_named_action_new(name);
	}

}

public static class GtkNamedActionHandleExtensions
{
	public static string GetActionName(this GtkNamedActionHandle self)
	{
		return GtkNamedActionExterns.gtk_named_action_get_action_name(self);
	}

}

internal class GtkNamedActionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkNamedActionHandle gtk_named_action_new(string name);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_named_action_get_action_name(GtkNamedActionHandle self);

}
