namespace MentorLake.Gtk4.Gsk4;

public class GskSubsurfaceNodeHandle : GskRenderNodeHandle
{
	public static GskSubsurfaceNodeHandle New(GskRenderNodeHandle child, IntPtr subsurface)
	{
		return GskSubsurfaceNodeExterns.gsk_subsurface_node_new(child, subsurface);
	}

	public static IntPtr GetSubsurface(GskRenderNodeHandle node)
	{
		return GskSubsurfaceNodeExterns.gsk_subsurface_node_get_subsurface(node);
	}

}

public static class GskSubsurfaceNodeHandleExtensions
{
	public static GskRenderNodeHandle GetChild(this GskSubsurfaceNodeHandle node)
	{
		return GskSubsurfaceNodeExterns.gsk_subsurface_node_get_child(node);
	}

}

internal class GskSubsurfaceNodeExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskSubsurfaceNodeHandle gsk_subsurface_node_new(GskRenderNodeHandle child, IntPtr subsurface);

	[DllImport(Libraries.Gsk4)]
	internal static extern GskRenderNodeHandle gsk_subsurface_node_get_child(GskRenderNodeHandle node);

	[DllImport(Libraries.Gsk4)]
	internal static extern IntPtr gsk_subsurface_node_get_subsurface(GskRenderNodeHandle node);

}
