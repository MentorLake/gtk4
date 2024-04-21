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

namespace MentorLake.Gtk4.Gsk4;

public class GskTransformHandle : BaseSafeHandle
{
	public static GskTransformHandle New()
	{
		return GskTransformExterns.gsk_transform_new();
	}

}

internal class GskTransformExterns
{
	[DllImport(Libraries.Gsk4)]
	internal static extern GskTransformHandle gsk_transform_new();

}

public struct GskTransform
{
}
