namespace MentorLake.Gtk4.GObject;

public class GInterfaceInfoHandle : BaseSafeHandle
{
}

internal class GInterfaceInfoExterns
{
}

public struct GInterfaceInfo
{
	public GInterfaceInitFunc interface_init;
	public GInterfaceFinalizeFunc interface_finalize;
	public IntPtr interface_data;
}
