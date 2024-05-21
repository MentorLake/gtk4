namespace MentorLake.Gtk4.Gio;

public class GIOModuleScopeHandle : BaseSafeHandle
{
}


public static class GIOModuleScopeHandleExtensions
{
	public static GIOModuleScopeHandle GIoModuleScopeBlock(this GIOModuleScopeHandle scope, string basename)
	{
		GIOModuleScopeExterns.g_io_module_scope_block(scope, basename);
		return scope;
	}

	public static GIOModuleScopeHandle GIoModuleScopeFree(this GIOModuleScopeHandle scope)
	{
		GIOModuleScopeExterns.g_io_module_scope_free(scope);
		return scope;
	}

}
internal class GIOModuleScopeExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_io_module_scope_block(GIOModuleScopeHandle scope, string basename);

	[DllImport(Libraries.Gio)]
	internal static extern void g_io_module_scope_free(GIOModuleScopeHandle scope);

}

public struct GIOModuleScope
{
}
