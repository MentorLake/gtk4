namespace MentorLake.Gtk4.Gsk4;

public class GskPathBuilderHandle : BaseSafeHandle
{
	public static GskPathBuilderHandle New()
	{
		return GskPathBuilderExterns.gsk_path_builder_new();
	}

}

internal class GskPathBuilderExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskPathBuilderHandle gsk_path_builder_new();

}

public struct GskPathBuilder
{
}
