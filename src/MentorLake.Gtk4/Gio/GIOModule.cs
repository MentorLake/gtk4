namespace MentorLake.Gtk4.Gio;

public class GIOModuleHandle : GTypeModuleHandle, GTypePluginHandle
{
	public static GIOModuleHandle GIoModuleNew(string filename)
	{
		return GIOModuleExterns.g_io_module_new(filename);
	}

	public static IntPtr GIoModuleQuery()
	{
		return GIOModuleExterns.g_io_module_query();
	}

}

public static class GIOModuleHandleExtensions
{
	public static GIOModuleHandle GIoModuleLoad(this GIOModuleHandle module)
	{
		GIOModuleExterns.g_io_module_load(module);
		return module;
	}

	public static GIOModuleHandle GIoModuleUnload(this GIOModuleHandle module)
	{
		GIOModuleExterns.g_io_module_unload(module);
		return module;
	}

}

internal class GIOModuleExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GIOModuleHandle g_io_module_new(string filename);

	[DllImport(Libraries.Gio)]
	internal static extern void g_io_module_load(GIOModuleHandle module);

	[DllImport(Libraries.Gio)]
	internal static extern void g_io_module_unload(GIOModuleHandle module);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_io_module_query();

}
