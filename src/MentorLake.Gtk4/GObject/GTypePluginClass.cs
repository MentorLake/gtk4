namespace MentorLake.Gtk4.GObject;

public class GTypePluginClassHandle : BaseSafeHandle
{
}

internal class GTypePluginClassExterns
{
}

public struct GTypePluginClass
{
	public GTypePluginUse use_plugin;
	public GTypePluginUnuse unuse_plugin;
	public GTypePluginCompleteTypeInfo complete_type_info;
	public GTypePluginCompleteInterfaceInfo complete_interface_info;
}
