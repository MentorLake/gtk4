namespace MentorLake.Gtk4.GLib;

[Flags]
public enum GFileTest
{
	G_FILE_TEST_IS_REGULAR = 0,
	G_FILE_TEST_IS_SYMLINK = 1,
	G_FILE_TEST_IS_DIR = 2,
	G_FILE_TEST_IS_EXECUTABLE = 4,
	G_FILE_TEST_EXISTS = 8
}
