namespace MentorLake.Gtk4.Gdk4;

public class GdkDmabufFormatsHandle : BaseSafeHandle
{
}


public static class GdkDmabufFormatsHandleExtensions
{
	public static bool Contains(this GdkDmabufFormatsHandle formats, uint fourcc, ulong modifier)
	{
		return GdkDmabufFormatsExterns.gdk_dmabuf_formats_contains(formats, fourcc, modifier);
	}

	public static bool Equal(this GdkDmabufFormatsHandle formats1, GdkDmabufFormatsHandle formats2)
	{
		return GdkDmabufFormatsExterns.gdk_dmabuf_formats_equal(formats1, formats2);
	}

	public static GdkDmabufFormatsHandle GetFormat(this GdkDmabufFormatsHandle formats, UIntPtr idx, out uint fourcc, out ulong modifier)
	{
		GdkDmabufFormatsExterns.gdk_dmabuf_formats_get_format(formats, idx, out fourcc, out modifier);
		return formats;
	}

	public static UIntPtr GetNFormats(this GdkDmabufFormatsHandle formats)
	{
		return GdkDmabufFormatsExterns.gdk_dmabuf_formats_get_n_formats(formats);
	}

	public static GdkDmabufFormatsHandle Ref(this GdkDmabufFormatsHandle formats)
	{
		return GdkDmabufFormatsExterns.gdk_dmabuf_formats_ref(formats);
	}

	public static GdkDmabufFormatsHandle Unref(this GdkDmabufFormatsHandle formats)
	{
		GdkDmabufFormatsExterns.gdk_dmabuf_formats_unref(formats);
		return formats;
	}

}
internal class GdkDmabufFormatsExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_dmabuf_formats_contains(GdkDmabufFormatsHandle formats, uint fourcc, ulong modifier);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_dmabuf_formats_equal(GdkDmabufFormatsHandle formats1, GdkDmabufFormatsHandle formats2);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_dmabuf_formats_get_format(GdkDmabufFormatsHandle formats, UIntPtr idx, out uint fourcc, out ulong modifier);

	[DllImport(Libraries.Gdk4)]
	internal static extern UIntPtr gdk_dmabuf_formats_get_n_formats(GdkDmabufFormatsHandle formats);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDmabufFormatsHandle gdk_dmabuf_formats_ref(GdkDmabufFormatsHandle formats);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_dmabuf_formats_unref(GdkDmabufFormatsHandle formats);

}

public struct GdkDmabufFormats
{
}
