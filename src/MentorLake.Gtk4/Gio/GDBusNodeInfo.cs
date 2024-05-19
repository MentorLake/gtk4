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
