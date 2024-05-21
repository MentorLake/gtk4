namespace MentorLake.Gtk4.GLib;

public class GAllocatorHandle : BaseSafeHandle
{
}


public static class GAllocatorHandleExtensions
{
	public static GAllocatorHandle Free(this GAllocatorHandle allocator)
	{
		GAllocatorExterns.g_allocator_free(allocator);
		return allocator;
	}

}
internal class GAllocatorExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_allocator_free(GAllocatorHandle allocator);

}

public struct GAllocator
{
}
