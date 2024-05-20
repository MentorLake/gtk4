namespace MentorLake.Gtk4.Gio;

public class GApplicationCommandLineHandle : GObjectHandle
{
}

public static class GApplicationCommandLineHandleExtensions
{
	public static GFileHandle CreateFileForArg(this GApplicationCommandLineHandle cmdline, string arg)
	{
		return GApplicationCommandLineExterns.g_application_command_line_create_file_for_arg(cmdline, arg);
	}

	public static GApplicationCommandLineHandle Done(this GApplicationCommandLineHandle cmdline)
	{
		GApplicationCommandLineExterns.g_application_command_line_done(cmdline);
		return cmdline;
	}

	public static IntPtr GetArguments(this GApplicationCommandLineHandle cmdline, out int argc)
	{
		return GApplicationCommandLineExterns.g_application_command_line_get_arguments(cmdline, out argc);
	}

	public static string GetCwd(this GApplicationCommandLineHandle cmdline)
	{
		return GApplicationCommandLineExterns.g_application_command_line_get_cwd(cmdline);
	}

	public static IntPtr GetEnviron(this GApplicationCommandLineHandle cmdline)
	{
		return GApplicationCommandLineExterns.g_application_command_line_get_environ(cmdline);
	}

	public static int GetExitStatus(this GApplicationCommandLineHandle cmdline)
	{
		return GApplicationCommandLineExterns.g_application_command_line_get_exit_status(cmdline);
	}

	public static bool GetIsRemote(this GApplicationCommandLineHandle cmdline)
	{
		return GApplicationCommandLineExterns.g_application_command_line_get_is_remote(cmdline);
	}

	public static GVariantDictHandle GetOptionsDict(this GApplicationCommandLineHandle cmdline)
	{
		return GApplicationCommandLineExterns.g_application_command_line_get_options_dict(cmdline);
	}

	public static GVariantHandle GetPlatformData(this GApplicationCommandLineHandle cmdline)
	{
		return GApplicationCommandLineExterns.g_application_command_line_get_platform_data(cmdline);
	}

	public static GInputStreamHandle GetStdin(this GApplicationCommandLineHandle cmdline)
	{
		return GApplicationCommandLineExterns.g_application_command_line_get_stdin(cmdline);
	}

	public static string Getenv(this GApplicationCommandLineHandle cmdline, string name)
	{
		return GApplicationCommandLineExterns.g_application_command_line_getenv(cmdline, name);
	}

	public static GApplicationCommandLineHandle Print(this GApplicationCommandLineHandle cmdline, string format, IntPtr @__arglist)
	{
		GApplicationCommandLineExterns.g_application_command_line_print(cmdline, format, @__arglist);
		return cmdline;
	}

	public static GApplicationCommandLineHandle PrintLiteral(this GApplicationCommandLineHandle cmdline, string message)
	{
		GApplicationCommandLineExterns.g_application_command_line_print_literal(cmdline, message);
		return cmdline;
	}

	public static GApplicationCommandLineHandle Printerr(this GApplicationCommandLineHandle cmdline, string format, IntPtr @__arglist)
	{
		GApplicationCommandLineExterns.g_application_command_line_printerr(cmdline, format, @__arglist);
		return cmdline;
	}

	public static GApplicationCommandLineHandle PrinterrLiteral(this GApplicationCommandLineHandle cmdline, string message)
	{
		GApplicationCommandLineExterns.g_application_command_line_printerr_literal(cmdline, message);
		return cmdline;
	}

	public static GApplicationCommandLineHandle SetExitStatus(this GApplicationCommandLineHandle cmdline, int exit_status)
	{
		GApplicationCommandLineExterns.g_application_command_line_set_exit_status(cmdline, exit_status);
		return cmdline;
	}

}

internal class GApplicationCommandLineExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GFileHandle g_application_command_line_create_file_for_arg(GApplicationCommandLineHandle cmdline, string arg);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_command_line_done(GApplicationCommandLineHandle cmdline);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_application_command_line_get_arguments(GApplicationCommandLineHandle cmdline, out int argc);

	[DllImport(Libraries.Gio)]
	internal static extern string g_application_command_line_get_cwd(GApplicationCommandLineHandle cmdline);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_application_command_line_get_environ(GApplicationCommandLineHandle cmdline);

	[DllImport(Libraries.Gio)]
	internal static extern int g_application_command_line_get_exit_status(GApplicationCommandLineHandle cmdline);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_application_command_line_get_is_remote(GApplicationCommandLineHandle cmdline);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantDictHandle g_application_command_line_get_options_dict(GApplicationCommandLineHandle cmdline);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_application_command_line_get_platform_data(GApplicationCommandLineHandle cmdline);

	[DllImport(Libraries.Gio)]
	internal static extern GInputStreamHandle g_application_command_line_get_stdin(GApplicationCommandLineHandle cmdline);

	[DllImport(Libraries.Gio)]
	internal static extern string g_application_command_line_getenv(GApplicationCommandLineHandle cmdline, string name);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_command_line_print(GApplicationCommandLineHandle cmdline, string format, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_command_line_print_literal(GApplicationCommandLineHandle cmdline, string message);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_command_line_printerr(GApplicationCommandLineHandle cmdline, string format, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_command_line_printerr_literal(GApplicationCommandLineHandle cmdline, string message);

	[DllImport(Libraries.Gio)]
	internal static extern void g_application_command_line_set_exit_status(GApplicationCommandLineHandle cmdline, int exit_status);

}
