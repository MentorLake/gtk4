namespace MentorLake.Gtk4.Gio;

public class GDBusNodeInfoHandle : BaseSafeHandle
{
	public static GDBusNodeInfoHandle GDbusNodeInfoNewForXml(string xml_data, out GErrorHandle error)
	{
		return GDBusNodeInfoExterns.g_dbus_node_info_new_for_xml(xml_data, out error);
	}

}


public static class GDBusNodeInfoHandleExtensions
{
	public static GDBusNodeInfoHandle GDbusNodeInfoGenerateXml(this GDBusNodeInfoHandle info, uint indent, GStringHandle string_builder)
	{
		GDBusNodeInfoExterns.g_dbus_node_info_generate_xml(info, indent, string_builder);
		return info;
	}

	public static GDBusInterfaceInfoHandle GDbusNodeInfoLookupInterface(this GDBusNodeInfoHandle info, string name)
	{
		return GDBusNodeInfoExterns.g_dbus_node_info_lookup_interface(info, name);
	}

	public static GDBusNodeInfoHandle GDbusNodeInfoRef(this GDBusNodeInfoHandle info)
	{
		return GDBusNodeInfoExterns.g_dbus_node_info_ref(info);
	}

	public static GDBusNodeInfoHandle GDbusNodeInfoUnref(this GDBusNodeInfoHandle info)
	{
		GDBusNodeInfoExterns.g_dbus_node_info_unref(info);
		return info;
	}

}
internal class GDBusNodeInfoExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusNodeInfoHandle g_dbus_node_info_new_for_xml(string xml_data, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_node_info_generate_xml(GDBusNodeInfoHandle info, uint indent, GStringHandle string_builder);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusInterfaceInfoHandle g_dbus_node_info_lookup_interface(GDBusNodeInfoHandle info, string name);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusNodeInfoHandle g_dbus_node_info_ref(GDBusNodeInfoHandle info);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_node_info_unref(GDBusNodeInfoHandle info);

}

public struct GDBusNodeInfo
{
	public int ref_count;
	public string path;
	public GDBusInterfaceInfoHandle[] interfaces;
	public GDBusNodeInfoHandle[] nodes;
	public GDBusAnnotationInfoHandle[] annotations;
}
