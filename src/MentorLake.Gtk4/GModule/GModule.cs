namespace MentorLake.Gtk4.GModule;

public class GModuleHandle : BaseSafeHandle
{
}


public static class GModuleHandleExtensions
{
	public static bool Close(this GModuleHandle module)
	{
		return GModuleExterns.g_module_close(module);
	}

	public static GModuleHandle MakeResident(this GModuleHandle module)
	{
		GModuleExterns.g_module_make_resident(module);
		return module;
	}

	public static string Name(this GModuleHandle module)
	{
		return GModuleExterns.g_module_name(module);
	}

	public static bool Symbol(this GModuleHandle module, string symbol_name, out IntPtr symbol)
	{
		return GModuleExterns.g_module_symbol(module, symbol_name, out symbol);
	}

}
internal class GModuleExterns
{
	[DllImport(Libraries.GModule)]
	internal static extern bool g_module_close(GModuleHandle module);

	[DllImport(Libraries.GModule)]
	internal static extern void g_module_make_resident(GModuleHandle module);

	[DllImport(Libraries.GModule)]
	internal static extern string g_module_name(GModuleHandle module);

	[DllImport(Libraries.GModule)]
	internal static extern bool g_module_symbol(GModuleHandle module, string symbol_name, out IntPtr symbol);

}

public struct GModule
{
}
