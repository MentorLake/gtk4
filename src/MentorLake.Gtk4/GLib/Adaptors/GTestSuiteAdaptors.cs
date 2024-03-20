using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GTestSuiteAdaptors
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

    public static int GTestRunSuite(this GTestSuiteHandle suite)
    {
        return GTestSuiteExterns.g_test_run_suite(suite);
    }

    public static GTestSuiteHandle Free(this GTestSuiteHandle suite)
    {
        GTestSuiteExterns.g_test_suite_free(suite);
        return suite;
    }
}
