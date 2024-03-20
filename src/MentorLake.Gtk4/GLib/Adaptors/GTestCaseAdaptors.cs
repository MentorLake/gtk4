using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GTestCaseAdaptors
{
    public static GTestCaseHandle Free(this GTestCaseHandle test_case)
    {
        GTestCaseExterns.g_test_case_free(test_case);
        return test_case;
    }
}
