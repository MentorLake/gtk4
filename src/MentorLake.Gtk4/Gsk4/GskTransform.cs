namespace MentorLake.Gtk4.Gsk4;

public class GskTransformHandle : BaseSafeHandle
{
	public static GskTransformHandle New()
	{
		return GskTransformExterns.gsk_transform_new();
	}

}

internal class GskTransformExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskTransformHandle gsk_transform_new();

}

public struct GskTransform
{
}
