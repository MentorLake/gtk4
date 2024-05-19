namespace MentorLake.Gtk4.GObject;

public class GClosureHandle : BaseSafeHandle
{
	public static GClosureHandle NewObject(uint sizeof_closure, GObjectHandle @object)
	{
		return GClosureExterns.g_closure_new_object(sizeof_closure, @object);
	}

	public static GClosureHandle NewSimple(uint sizeof_closure, IntPtr data)
	{
		return GClosureExterns.g_closure_new_simple(sizeof_closure, data);
	}

}

internal class GClosureExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern GClosureHandle g_closure_new_object(uint sizeof_closure, GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern GClosureHandle g_closure_new_simple(uint sizeof_closure, IntPtr data);

}

public struct GClosure
{
	public uint in_marshal;
	public uint is_invalid;
	public IntPtr marshal;
}
