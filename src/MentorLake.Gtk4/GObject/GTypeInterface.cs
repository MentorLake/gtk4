namespace MentorLake.Gtk4.GObject;

public class GTypeInterfaceHandle : BaseSafeHandle
{
}


public static class GTypeInterfaceHandleExtensions
{
	public static GTypeInterfaceHandle PeekParent(this GTypeInterfaceHandle g_iface)
	{
		return GTypeInterfaceExterns.g_type_interface_peek_parent(g_iface);
	}

}
internal class GTypeInterfaceExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern GTypeInterfaceHandle g_type_interface_peek_parent(GTypeInterfaceHandle g_iface);

}

public struct GTypeInterface
{
}
