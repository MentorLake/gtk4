namespace MentorLake.Gtk4.GLib;

public class GTestCaseHandle : BaseSafeHandle
{
}


public static class GTestCaseHandleExtensions
{
	public static GTestCaseHandle Free(this GTestCaseHandle test_case)
	{
		GTestCaseExterns.g_test_case_free(test_case);
		return test_case;
	}

}
internal class GTestCaseExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_test_case_free(GTestCaseHandle test_case);

}

public struct GTestCase
{
}
