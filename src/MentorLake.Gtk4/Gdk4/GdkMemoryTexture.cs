using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gdk4;

public class GdkMemoryTextureHandle : GdkTextureHandle, GdkPaintableHandle, GIconHandle, GLoadableIconHandle
{
	public static GdkMemoryTextureHandle New(int width, int height, GdkMemoryFormat format, GBytesHandle bytes, int stride)
	{
		return GdkMemoryTextureExterns.gdk_memory_texture_new(width, height, format, bytes, stride);
	}

}

public static class GdkMemoryTextureHandleExtensions
{
}

internal class GdkMemoryTextureExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkMemoryTextureHandle gdk_memory_texture_new(int width, int height, GdkMemoryFormat format, GBytesHandle bytes, int stride);

}
