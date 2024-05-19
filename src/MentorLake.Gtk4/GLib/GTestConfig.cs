namespace MentorLake.Gtk4.GLib;

public class GTestConfigHandle : BaseSafeHandle
{
}

internal class GTestConfigExterns
{
}

public struct GTestConfig
{
	public bool test_initialized;
	public bool test_quick;
	public bool test_perf;
	public bool test_verbose;
	public bool test_quiet;
	public bool test_undefined;
}
