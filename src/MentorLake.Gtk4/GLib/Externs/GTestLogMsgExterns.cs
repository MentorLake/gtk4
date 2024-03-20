using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GTestLogMsgExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_test_log_msg_free")]
	internal static extern void g_test_log_msg_free(this GTestLogMsgHandle tmsg);
}
