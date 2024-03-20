using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GAllocatorAdaptors
{
	public static GAllocatorHandle Free(this GAllocatorHandle allocator)
	{
		GAllocatorExterns.g_allocator_free(allocator);
		return allocator;
	}

	public static GAllocatorHandle GListPushAllocator(this GAllocatorHandle allocator)
	{
		GAllocatorExterns.g_list_push_allocator(allocator);
		return allocator;
	}

	public static GAllocatorHandle GSlistPushAllocator(this GAllocatorHandle allocator)
	{
		GAllocatorExterns.g_slist_push_allocator(allocator);
		return allocator;
	}

	public static GAllocatorHandle GNodePushAllocator(this GAllocatorHandle allocator)
	{
		GAllocatorExterns.g_node_push_allocator(allocator);
		return allocator;
	}
}
