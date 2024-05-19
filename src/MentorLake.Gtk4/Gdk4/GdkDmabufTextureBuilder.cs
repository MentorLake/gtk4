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

public class GdkDmabufTextureBuilderHandle : GObjectHandle
{
	public static GdkDmabufTextureBuilderHandle New()
	{
		return GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_new();
	}

}

public static class GdkDmabufTextureBuilderHandleExtensions
{
	public static GdkTextureHandle Build(this GdkDmabufTextureBuilderHandle self, GDestroyNotify destroy, IntPtr data, out GErrorHandle error)
	{
		return GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_build(self, destroy, data, out error);
	}

	public static GdkDisplayHandle GetDisplay(this GdkDmabufTextureBuilderHandle self)
	{
		return GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_get_display(self);
	}

	public static int GetFd(this GdkDmabufTextureBuilderHandle self, int plane)
	{
		return GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_get_fd(self, plane);
	}

	public static uint GetFourcc(this GdkDmabufTextureBuilderHandle self)
	{
		return GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_get_fourcc(self);
	}

	public static int GetHeight(this GdkDmabufTextureBuilderHandle self)
	{
		return GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_get_height(self);
	}

	public static ulong GetModifier(this GdkDmabufTextureBuilderHandle self)
	{
		return GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_get_modifier(self);
	}

	public static int GetNPlanes(this GdkDmabufTextureBuilderHandle self)
	{
		return GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_get_n_planes(self);
	}

	public static int GetOffset(this GdkDmabufTextureBuilderHandle self, int plane)
	{
		return GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_get_offset(self, plane);
	}

	public static bool GetPremultiplied(this GdkDmabufTextureBuilderHandle self)
	{
		return GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_get_premultiplied(self);
	}

	public static int GetStride(this GdkDmabufTextureBuilderHandle self, int plane)
	{
		return GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_get_stride(self, plane);
	}

	public static cairo_region_tHandle GetUpdateRegion(this GdkDmabufTextureBuilderHandle self)
	{
		return GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_get_update_region(self);
	}

	public static GdkTextureHandle GetUpdateTexture(this GdkDmabufTextureBuilderHandle self)
	{
		return GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_get_update_texture(self);
	}

	public static int GetWidth(this GdkDmabufTextureBuilderHandle self)
	{
		return GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_get_width(self);
	}

	public static GdkDmabufTextureBuilderHandle SetDisplay(this GdkDmabufTextureBuilderHandle self, GdkDisplayHandle display)
	{
		GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_set_display(self, display);
		return self;
	}

	public static GdkDmabufTextureBuilderHandle SetFd(this GdkDmabufTextureBuilderHandle self, int plane, int fd)
	{
		GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_set_fd(self, plane, fd);
		return self;
	}

	public static GdkDmabufTextureBuilderHandle SetFourcc(this GdkDmabufTextureBuilderHandle self, uint fourcc)
	{
		GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_set_fourcc(self, fourcc);
		return self;
	}

	public static GdkDmabufTextureBuilderHandle SetHeight(this GdkDmabufTextureBuilderHandle self, int height)
	{
		GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_set_height(self, height);
		return self;
	}

	public static GdkDmabufTextureBuilderHandle SetModifier(this GdkDmabufTextureBuilderHandle self, ulong modifier)
	{
		GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_set_modifier(self, modifier);
		return self;
	}

	public static GdkDmabufTextureBuilderHandle SetNPlanes(this GdkDmabufTextureBuilderHandle self, int n_planes)
	{
		GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_set_n_planes(self, n_planes);
		return self;
	}

	public static GdkDmabufTextureBuilderHandle SetOffset(this GdkDmabufTextureBuilderHandle self, int plane, int offset)
	{
		GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_set_offset(self, plane, offset);
		return self;
	}

	public static GdkDmabufTextureBuilderHandle SetPremultiplied(this GdkDmabufTextureBuilderHandle self, bool premultiplied)
	{
		GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_set_premultiplied(self, premultiplied);
		return self;
	}

	public static GdkDmabufTextureBuilderHandle SetStride(this GdkDmabufTextureBuilderHandle self, int plane, int stride)
	{
		GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_set_stride(self, plane, stride);
		return self;
	}

	public static GdkDmabufTextureBuilderHandle SetUpdateRegion(this GdkDmabufTextureBuilderHandle self, cairo_region_tHandle region)
	{
		GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_set_update_region(self, region);
		return self;
	}

	public static GdkDmabufTextureBuilderHandle SetUpdateTexture(this GdkDmabufTextureBuilderHandle self, GdkTextureHandle texture)
	{
		GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_set_update_texture(self, texture);
		return self;
	}

	public static GdkDmabufTextureBuilderHandle SetWidth(this GdkDmabufTextureBuilderHandle self, int width)
	{
		GdkDmabufTextureBuilderExterns.gdk_dmabuf_texture_builder_set_width(self, width);
		return self;
	}

}

internal class GdkDmabufTextureBuilderExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDmabufTextureBuilderHandle gdk_dmabuf_texture_builder_new();

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkTextureHandle gdk_dmabuf_texture_builder_build(GdkDmabufTextureBuilderHandle self, GDestroyNotify destroy, IntPtr data, out GErrorHandle error);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_dmabuf_texture_builder_get_display(GdkDmabufTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_dmabuf_texture_builder_get_fd(GdkDmabufTextureBuilderHandle self, int plane);

	[DllImport(Libraries.Gdk4)]
	internal static extern uint gdk_dmabuf_texture_builder_get_fourcc(GdkDmabufTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_dmabuf_texture_builder_get_height(GdkDmabufTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern ulong gdk_dmabuf_texture_builder_get_modifier(GdkDmabufTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_dmabuf_texture_builder_get_n_planes(GdkDmabufTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_dmabuf_texture_builder_get_offset(GdkDmabufTextureBuilderHandle self, int plane);

	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_dmabuf_texture_builder_get_premultiplied(GdkDmabufTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_dmabuf_texture_builder_get_stride(GdkDmabufTextureBuilderHandle self, int plane);

	[DllImport(Libraries.Gdk4)]
	internal static extern cairo_region_tHandle gdk_dmabuf_texture_builder_get_update_region(GdkDmabufTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern GdkTextureHandle gdk_dmabuf_texture_builder_get_update_texture(GdkDmabufTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_dmabuf_texture_builder_get_width(GdkDmabufTextureBuilderHandle self);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_dmabuf_texture_builder_set_display(GdkDmabufTextureBuilderHandle self, GdkDisplayHandle display);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_dmabuf_texture_builder_set_fd(GdkDmabufTextureBuilderHandle self, int plane, int fd);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_dmabuf_texture_builder_set_fourcc(GdkDmabufTextureBuilderHandle self, uint fourcc);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_dmabuf_texture_builder_set_height(GdkDmabufTextureBuilderHandle self, int height);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_dmabuf_texture_builder_set_modifier(GdkDmabufTextureBuilderHandle self, ulong modifier);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_dmabuf_texture_builder_set_n_planes(GdkDmabufTextureBuilderHandle self, int n_planes);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_dmabuf_texture_builder_set_offset(GdkDmabufTextureBuilderHandle self, int plane, int offset);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_dmabuf_texture_builder_set_premultiplied(GdkDmabufTextureBuilderHandle self, bool premultiplied);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_dmabuf_texture_builder_set_stride(GdkDmabufTextureBuilderHandle self, int plane, int stride);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_dmabuf_texture_builder_set_update_region(GdkDmabufTextureBuilderHandle self, cairo_region_tHandle region);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_dmabuf_texture_builder_set_update_texture(GdkDmabufTextureBuilderHandle self, GdkTextureHandle texture);

	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_dmabuf_texture_builder_set_width(GdkDmabufTextureBuilderHandle self, int width);

}
