using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GTestCaseExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_test_case_free")]
	internal static extern void g_test_case_free(this GTestCaseHandle test_case);
}
