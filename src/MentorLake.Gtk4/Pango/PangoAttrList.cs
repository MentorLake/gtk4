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

namespace MentorLake.Gtk4.Pango;

public class PangoAttrListHandle : BaseSafeHandle
{
	public static PangoAttrListHandle New()
	{
		return PangoAttrListExterns.pango_attr_list_new();
	}

}

internal class PangoAttrListExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern PangoAttrListHandle pango_attr_list_new();

}

public struct PangoAttrList
{
}
