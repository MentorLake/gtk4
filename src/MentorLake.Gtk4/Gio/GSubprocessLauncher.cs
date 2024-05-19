namespace MentorLake.Gtk4.Gio;

public class GSubprocessLauncherHandle : GObjectHandle
{
	public static GSubprocessLauncherHandle New(GSubprocessFlags flags)
	{
		return GSubprocessLauncherExterns.g_subprocess_launcher_new(flags);
	}

}

public static class GSubprocessLauncherHandleExtensions
{
	public static GSubprocessLauncherHandle Close(this GSubprocessLauncherHandle self)
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_close(self);
		return self;
	}

	public static string Getenv(this GSubprocessLauncherHandle self, string variable)
	{
		return GSubprocessLauncherExterns.g_subprocess_launcher_getenv(self, variable);
	}

	public static GSubprocessLauncherHandle SetChildSetup(this GSubprocessLauncherHandle self, GSpawnChildSetupFunc child_setup, IntPtr user_data, GDestroyNotify destroy_notify)
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_set_child_setup(self, child_setup, user_data, destroy_notify);
		return self;
	}

	public static GSubprocessLauncherHandle SetCwd(this GSubprocessLauncherHandle self, string cwd)
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_set_cwd(self, cwd);
		return self;
	}

	public static GSubprocessLauncherHandle SetEnviron(this GSubprocessLauncherHandle self, string[] env)
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_set_environ(self, env);
		return self;
	}

	public static GSubprocessLauncherHandle SetFlags(this GSubprocessLauncherHandle self, GSubprocessFlags flags)
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_set_flags(self, flags);
		return self;
	}

	public static GSubprocessLauncherHandle SetStderrFilePath(this GSubprocessLauncherHandle self, string path)
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_set_stderr_file_path(self, path);
		return self;
	}

	public static GSubprocessLauncherHandle SetStdinFilePath(this GSubprocessLauncherHandle self, string path)
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_set_stdin_file_path(self, path);
		return self;
	}

	public static GSubprocessLauncherHandle SetStdoutFilePath(this GSubprocessLauncherHandle self, string path)
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_set_stdout_file_path(self, path);
		return self;
	}

	public static GSubprocessLauncherHandle Setenv(this GSubprocessLauncherHandle self, string variable, string value, bool overwrite)
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_setenv(self, variable, value, overwrite);
		return self;
	}

	public static GSubprocessHandle Spawn(this GSubprocessLauncherHandle self, out GErrorHandle error, string argv0, IntPtr @__arglist)
	{
		return GSubprocessLauncherExterns.g_subprocess_launcher_spawn(self, out error, argv0, @__arglist);
	}

	public static GSubprocessHandle Spawnv(this GSubprocessLauncherHandle self, string argv, out GErrorHandle error)
	{
		return GSubprocessLauncherExterns.g_subprocess_launcher_spawnv(self, argv, out error);
	}

	public static GSubprocessLauncherHandle TakeFd(this GSubprocessLauncherHandle self, int source_fd, int target_fd)
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_take_fd(self, source_fd, target_fd);
		return self;
	}

	public static GSubprocessLauncherHandle TakeStderrFd(this GSubprocessLauncherHandle self, int fd)
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_take_stderr_fd(self, fd);
		return self;
	}

	public static GSubprocessLauncherHandle TakeStdinFd(this GSubprocessLauncherHandle self, int fd)
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_take_stdin_fd(self, fd);
		return self;
	}

	public static GSubprocessLauncherHandle TakeStdoutFd(this GSubprocessLauncherHandle self, int fd)
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_take_stdout_fd(self, fd);
		return self;
	}

	public static GSubprocessLauncherHandle Unsetenv(this GSubprocessLauncherHandle self, string variable)
	{
		GSubprocessLauncherExterns.g_subprocess_launcher_unsetenv(self, variable);
		return self;
	}

}

internal class GSubprocessLauncherExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSubprocessLauncherHandle g_subprocess_launcher_new(GSubprocessFlags flags);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_close(GSubprocessLauncherHandle self);

	[DllImport(Libraries.Gio)]
	internal static extern string g_subprocess_launcher_getenv(GSubprocessLauncherHandle self, string variable);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_set_child_setup(GSubprocessLauncherHandle self, GSpawnChildSetupFunc child_setup, IntPtr user_data, GDestroyNotify destroy_notify);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_set_cwd(GSubprocessLauncherHandle self, string cwd);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_set_environ(GSubprocessLauncherHandle self, string[] env);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_set_flags(GSubprocessLauncherHandle self, GSubprocessFlags flags);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_set_stderr_file_path(GSubprocessLauncherHandle self, string path);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_set_stdin_file_path(GSubprocessLauncherHandle self, string path);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_set_stdout_file_path(GSubprocessLauncherHandle self, string path);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_setenv(GSubprocessLauncherHandle self, string variable, string value, bool overwrite);

	[DllImport(Libraries.Gio)]
	internal static extern GSubprocessHandle g_subprocess_launcher_spawn(GSubprocessLauncherHandle self, out GErrorHandle error, string argv0, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern GSubprocessHandle g_subprocess_launcher_spawnv(GSubprocessLauncherHandle self, string argv, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_take_fd(GSubprocessLauncherHandle self, int source_fd, int target_fd);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_take_stderr_fd(GSubprocessLauncherHandle self, int fd);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_take_stdin_fd(GSubprocessLauncherHandle self, int fd);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_take_stdout_fd(GSubprocessLauncherHandle self, int fd);

	[DllImport(Libraries.Gio)]
	internal static extern void g_subprocess_launcher_unsetenv(GSubprocessLauncherHandle self, string variable);

}
