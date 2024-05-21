namespace MentorLake.Gtk4.GLib;

public class GIConvHandle : BaseSafeHandle
{
}


public static class GIConvHandleExtensions
{
	public static UIntPtr GIconv(this GIConv converter, ref string inbuf, ref UIntPtr inbytes_left, ref string outbuf, ref UIntPtr outbytes_left)
	{
		return GIConvExterns.g_iconv(converter, ref inbuf, ref inbytes_left, ref outbuf, ref outbytes_left);
	}

	public static int GIconvClose(this GIConv converter)
	{
		return GIConvExterns.g_iconv_close(converter);
	}

}
internal class GIConvExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern UIntPtr g_iconv(GIConv converter, ref string inbuf, ref UIntPtr inbytes_left, ref string outbuf, ref UIntPtr outbytes_left);

	[DllImport(Libraries.GLib)]
	internal static extern int g_iconv_close(GIConv converter);

}

public struct GIConv
{
}
