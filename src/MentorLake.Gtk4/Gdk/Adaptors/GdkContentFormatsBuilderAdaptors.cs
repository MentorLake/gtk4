using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;
public static class GdkContentFormatsBuilderAdaptors
{
	public static GdkContentFormatsBuilderHandle Ref(this GdkContentFormatsBuilderHandle builder)
	{
		return GdkContentFormatsBuilderExterns.gdk_content_formats_builder_ref(builder);
	}

	public static GdkContentFormatsBuilderHandle Unref(this GdkContentFormatsBuilderHandle builder)
	{
		GdkContentFormatsBuilderExterns.gdk_content_formats_builder_unref(builder);
		return builder;
	}

	public static GdkContentFormatsHandle FreeToFormats(this GdkContentFormatsBuilderHandle builder)
	{
		return GdkContentFormatsBuilderExterns.gdk_content_formats_builder_free_to_formats(builder);
	}

	public static GdkContentFormatsHandle ToFormats(this GdkContentFormatsBuilderHandle builder)
	{
		return GdkContentFormatsBuilderExterns.gdk_content_formats_builder_to_formats(builder);
	}

	public static GdkContentFormatsBuilderHandle AddFormats(this GdkContentFormatsBuilderHandle builder, GdkContentFormatsHandle formats)
	{
		GdkContentFormatsBuilderExterns.gdk_content_formats_builder_add_formats(builder, formats);
		return builder;
	}

	public static GdkContentFormatsBuilderHandle AddMimeType(this GdkContentFormatsBuilderHandle builder, string mime_type)
	{
		GdkContentFormatsBuilderExterns.gdk_content_formats_builder_add_mime_type(builder, mime_type);
		return builder;
	}

	public static GdkContentFormatsBuilderHandle AddGtype(this GdkContentFormatsBuilderHandle builder, GType type)
	{
		GdkContentFormatsBuilderExterns.gdk_content_formats_builder_add_gtype(builder, type);
		return builder;
	}
}
