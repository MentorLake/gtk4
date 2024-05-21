namespace MentorLake.Gtk4.Gio;

public class GIOExtensionHandle : BaseSafeHandle
{
}


public static class GIOExtensionHandleExtensions
{
	public static string GIoExtensionGetName(this GIOExtensionHandle extension)
	{
		return GIOExtensionExterns.g_io_extension_get_name(extension);
	}

	public static int GIoExtensionGetPriority(this GIOExtensionHandle extension)
	{
		return GIOExtensionExterns.g_io_extension_get_priority(extension);
	}

	public static GType GIoExtensionGetType(this GIOExtensionHandle extension)
	{
		return GIOExtensionExterns.g_io_extension_get_type(extension);
	}

	public static GTypeClassHandle GIoExtensionRefClass(this GIOExtensionHandle extension)
	{
		return GIOExtensionExterns.g_io_extension_ref_class(extension);
	}

}
internal class GIOExtensionExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern string g_io_extension_get_name(GIOExtensionHandle extension);

	[DllImport(Libraries.Gio)]
	internal static extern int g_io_extension_get_priority(GIOExtensionHandle extension);

	[DllImport(Libraries.Gio)]
	internal static extern GType g_io_extension_get_type(GIOExtensionHandle extension);

	[DllImport(Libraries.Gio)]
	internal static extern GTypeClassHandle g_io_extension_ref_class(GIOExtensionHandle extension);

}

public struct GIOExtension
{
}
