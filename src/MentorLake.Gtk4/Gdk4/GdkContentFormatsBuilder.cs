namespace MentorLake.Gtk4.Gdk4;

public class GdkContentFormatsBuilderHandle : BaseSafeHandle
{
	public static GdkContentFormatsBuilderHandle New()
	{
		return GdkContentFormatsBuilderExterns.gdk_content_formats_builder_new();
	}

}


public static class GdkContentFormatsBuilderHandleExtensions
{
	public static GdkContentFormatsBuilderHandle AddFormats(this GdkContentFormatsBuilderHandle builder, GdkContentFormatsHandle formats)
	{
		GdkContentFormatsBuilderExterns.gdk_content_formats_builder_add_formats(builder, formats);
		return builder;
	}

	public static GdkContentFormatsBuilderHandle AddGtype(this GdkContentFormatsBuilderHandle builder, GType type)
	{
		GdkContentFormatsBuilderExterns.gdk_content_formats_builder_add_gtype(builder, type);
		return builder;
	}

	public static GdkContentFormatsBuilderHandle AddMimeType(this GdkContentFormatsBuilderHandle builder, string mime_type)
	{
		GdkContentFormatsBuilderExterns.gdk_content_formats_builder_add_mime_type(builder, mime_type);
		return builder;
	}

	public static GdkContentFormatsHandle FreeToFormats(this GdkContentFormatsBuilderHandle builder)
	{
		return GdkContentFormatsBuilderExterns.gdk_content_formats_builder_free_to_formats(builder);
	}

	public static GdkContentFormatsBuilderHandle Ref(this GdkContentFormatsBuilderHandle builder)
	{
		return GdkContentFormatsBuilderExterns.gdk_content_formats_builder_ref(builder);
	}

	public static GdkContentFormatsHandle ToFormats(this GdkContentFormatsBuilderHandle builder)
	{
		return GdkContentFormatsBuilderExterns.gdk_content_formats_builder_to_formats(builder);
	}

	public static GdkContentFormatsBuilderHandle Unref(this GdkContentFormatsBuilderHandle builder)
	{
		GdkContentFormatsBuilderExterns.gdk_content_formats_builder_unref(builder);
		return builder;
	}

}
internal class GdkContentFormatsBuilderExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsBuilderHandle gdk_content_formats_builder_new();

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_formats_builder_add_formats(GdkContentFormatsBuilderHandle builder, GdkContentFormatsHandle formats);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_formats_builder_add_gtype(GdkContentFormatsBuilderHandle builder, GType type);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_formats_builder_add_mime_type(GdkContentFormatsBuilderHandle builder, string mime_type);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_content_formats_builder_free_to_formats(GdkContentFormatsBuilderHandle builder);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsBuilderHandle gdk_content_formats_builder_ref(GdkContentFormatsBuilderHandle builder);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkContentFormatsHandle gdk_content_formats_builder_to_formats(GdkContentFormatsBuilderHandle builder);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_content_formats_builder_unref(GdkContentFormatsBuilderHandle builder);

}

public struct GdkContentFormatsBuilder
{
}
