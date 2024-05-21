namespace MentorLake.Gtk4.GObject;

public class GTypeInstanceHandle : BaseSafeHandle
{
}


public static class GTypeInstanceHandleExtensions
{
	public static IntPtr GetPrivate(this GTypeInstanceHandle instance, GType private_type)
	{
		return GTypeInstanceExterns.g_type_instance_get_private(instance, private_type);
	}

}
internal class GTypeInstanceExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_type_instance_get_private(GTypeInstanceHandle instance, GType private_type);

}

public struct GTypeInstance
{
}
