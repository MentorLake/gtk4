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

namespace MentorLake.Gtk4.Gio;

public class GDBusNodeInfoHandle : BaseSafeHandle
{
	public static GDBusNodeInfoHandle GDbusNodeInfoNewForXml(string xml_data, out GErrorHandle error)
	{
		return GDBusNodeInfoExterns.g_dbus_node_info_new_for_xml(xml_data, out error);
	}

}

internal class GDBusNodeInfoExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusNodeInfoHandle g_dbus_node_info_new_for_xml(string xml_data, out GErrorHandle error);
}

public struct GDBusNodeInfo
{
	public int ref_count;
	public string path;
	public GDBusInterfaceInfoHandle[] interfaces;
	public GDBusNodeInfoHandle[] nodes;
	public GDBusAnnotationInfoHandle[] annotations;
}
