namespace MentorLake.Gtk4.Gdk4;

public class GdkContentFormatsBuilderHandle : BaseSafeHandle
{
	public static GdkContentFormatsBuilderHandle New()
	{
		return GdkContentFormatsBuilderExterns.gdk_content_formats_builder_new();
	}

}

internal class GdkContentFormatsBuilderExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsBuilderHandle gdk_content_formats_builder_new();

}

public struct GdkContentFormatsBuilder
{
}
