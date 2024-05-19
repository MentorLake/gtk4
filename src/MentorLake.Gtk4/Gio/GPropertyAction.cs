namespace MentorLake.Gtk4.Gio;

public class GPropertyActionHandle : GObjectHandle, GActionHandle
{
	public static GPropertyActionHandle New(string name, GObjectHandle @object, string property_name)
	{
		return GPropertyActionExterns.g_property_action_new(name, @object, property_name);
	}

}

public static class GPropertyActionHandleExtensions
{
}

internal class GPropertyActionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GPropertyActionHandle g_property_action_new(string name, GObjectHandle @object, string property_name);

}
