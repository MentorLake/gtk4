namespace MentorLake.Gtk4.GLib;

public class GTestSuiteHandle : BaseSafeHandle
{
}


public static class GTestSuiteHandleExtensions
{
	public static GTestSuiteHandle Add(this GTestSuiteHandle suite, GTestCaseHandle test_case)
	{
		GTestSuiteExterns.g_test_suite_add(suite, test_case);
		return suite;
	}

	public static GTestSuiteHandle AddSuite(this GTestSuiteHandle suite, GTestSuiteHandle nestedsuite)
	{
		GTestSuiteExterns.g_test_suite_add_suite(suite, nestedsuite);
		return suite;
	}

	public static GTestSuiteHandle Free(this GTestSuiteHandle suite)
	{
		GTestSuiteExterns.g_test_suite_free(suite);
		return suite;
	}

}
internal class GTestSuiteExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_test_suite_add(GTestSuiteHandle suite, GTestCaseHandle test_case);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_suite_add_suite(GTestSuiteHandle suite, GTestSuiteHandle nestedsuite);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_suite_free(GTestSuiteHandle suite);

}

public struct GTestSuite
{
}
