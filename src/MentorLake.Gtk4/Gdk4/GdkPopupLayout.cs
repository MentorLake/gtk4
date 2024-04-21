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

public class GdkPopupLayoutHandle : BaseSafeHandle
{
	public static GdkPopupLayoutHandle New(GdkRectangleHandle anchor_rect, GdkGravity rect_anchor, GdkGravity surface_anchor)
	{
		return GdkPopupLayoutExterns.gdk_popup_layout_new(anchor_rect, rect_anchor, surface_anchor);
	}

}

internal class GdkPopupLayoutExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkPopupLayoutHandle gdk_popup_layout_new(GdkRectangleHandle anchor_rect, GdkGravity rect_anchor, GdkGravity surface_anchor);

}

public struct GdkPopupLayout
{
}
