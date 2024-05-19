namespace MentorLake.Gtk4.Gsk4;

public class GskVulkanRendererHandle : GskRendererHandle
{
	public static GskVulkanRendererHandle New()
	{
		return GskVulkanRendererExterns.gsk_vulkan_renderer_new();
	}

}

public static class GskVulkanRendererHandleExtensions
{
}

internal class GskVulkanRendererExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskVulkanRendererHandle gsk_vulkan_renderer_new();

}
