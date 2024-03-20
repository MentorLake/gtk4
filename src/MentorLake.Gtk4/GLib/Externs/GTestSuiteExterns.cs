using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GTestSuiteExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_test_suite_add")]
	internal static extern void g_test_suite_add(this GTestSuiteHandle suite, GTestCaseHandle test_case);

	[DllImport(Libraries.GLib, EntryPoint = "g_test_suite_add_suite")]
	internal static extern void g_test_suite_add_suite(this GTestSuiteHandle suite, GTestSuiteHandle nestedsuite);

	[DllImport(Libraries.GLib, EntryPoint = "g_test_run_suite")]
	internal static extern int g_test_run_suite(this GTestSuiteHandle suite);

	[DllImport(Libraries.GLib, EntryPoint = "g_test_suite_free")]
	internal static extern void g_test_suite_free(this GTestSuiteHandle suite);
}
