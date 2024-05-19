namespace MentorLake.Gtk4.GLib;

[Flags]
public enum GTestTrapFlags
{
	G_TEST_TRAP_DEFAULT = 0,
	G_TEST_TRAP_SILENCE_STDOUT = 1,
	G_TEST_TRAP_SILENCE_STDERR = 2,
	G_TEST_TRAP_INHERIT_STDIN = 4
}
