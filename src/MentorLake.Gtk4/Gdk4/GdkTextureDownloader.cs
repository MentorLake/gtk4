using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

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
