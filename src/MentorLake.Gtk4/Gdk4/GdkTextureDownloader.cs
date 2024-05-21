namespace MentorLake.Gtk4.Gdk4;

public class GdkTextureDownloaderHandle : BaseSafeHandle
{
	public static GdkTextureDownloaderHandle New(GdkTextureHandle texture)
	{
		return GdkTextureDownloaderExterns.gdk_texture_downloader_new(texture);
	}

}


public static class GdkTextureDownloaderHandleExtensions
{
	public static GdkTextureDownloaderHandle Copy(this GdkTextureDownloaderHandle self)
	{
		return GdkTextureDownloaderExterns.gdk_texture_downloader_copy(self);
	}

	public static GBytesHandle DownloadBytes(this GdkTextureDownloaderHandle self, out UIntPtr out_stride)
	{
		return GdkTextureDownloaderExterns.gdk_texture_downloader_download_bytes(self, out out_stride);
	}

	public static GdkTextureDownloaderHandle DownloadInto(this GdkTextureDownloaderHandle self, string data, UIntPtr stride)
	{
		GdkTextureDownloaderExterns.gdk_texture_downloader_download_into(self, data, stride);
		return self;
	}

	public static GdkTextureDownloaderHandle Free(this GdkTextureDownloaderHandle self)
	{
		GdkTextureDownloaderExterns.gdk_texture_downloader_free(self);
		return self;
	}

	public static GdkMemoryFormat GetFormat(this GdkTextureDownloaderHandle self)
	{
		return GdkTextureDownloaderExterns.gdk_texture_downloader_get_format(self);
	}

	public static GdkTextureHandle GetTexture(this GdkTextureDownloaderHandle self)
	{
		return GdkTextureDownloaderExterns.gdk_texture_downloader_get_texture(self);
	}

	public static GdkTextureDownloaderHandle SetFormat(this GdkTextureDownloaderHandle self, GdkMemoryFormat format)
	{
		GdkTextureDownloaderExterns.gdk_texture_downloader_set_format(self, format);
		return self;
	}

	public static GdkTextureDownloaderHandle SetTexture(this GdkTextureDownloaderHandle self, GdkTextureHandle texture)
	{
		GdkTextureDownloaderExterns.gdk_texture_downloader_set_texture(self, texture);
		return self;
	}

}
internal class GdkTextureDownloaderExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkTextureDownloaderHandle gdk_texture_downloader_new(GdkTextureHandle texture);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkTextureDownloaderHandle gdk_texture_downloader_copy(GdkTextureDownloaderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern GBytesHandle gdk_texture_downloader_download_bytes(GdkTextureDownloaderHandle self, out UIntPtr out_stride);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_texture_downloader_download_into(GdkTextureDownloaderHandle self, string data, UIntPtr stride);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_texture_downloader_free(GdkTextureDownloaderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkMemoryFormat gdk_texture_downloader_get_format(GdkTextureDownloaderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkTextureHandle gdk_texture_downloader_get_texture(GdkTextureDownloaderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_texture_downloader_set_format(GdkTextureDownloaderHandle self, GdkMemoryFormat format);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_texture_downloader_set_texture(GdkTextureDownloaderHandle self, GdkTextureHandle texture);

}

public struct GdkTextureDownloader
{
}
