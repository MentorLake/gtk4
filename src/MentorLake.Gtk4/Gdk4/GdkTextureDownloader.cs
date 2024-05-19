namespace MentorLake.Gtk4.Gdk4;

public class GdkTextureDownloaderHandle : BaseSafeHandle
{
	public static GdkTextureDownloaderHandle New(GdkTextureHandle texture)
	{
		return GdkTextureDownloaderExterns.gdk_texture_downloader_new(texture);
	}

}

internal class GdkTextureDownloaderExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkTextureDownloaderHandle gdk_texture_downloader_new(GdkTextureHandle texture);

}

public struct GdkTextureDownloader
{
}
