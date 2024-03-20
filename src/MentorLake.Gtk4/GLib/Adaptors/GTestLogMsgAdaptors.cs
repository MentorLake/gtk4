using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GTestLogMsgAdaptors
{
    public static GTestLogMsgHandle Free(this GTestLogMsgHandle tmsg)
    {
        GTestLogMsgExterns.g_test_log_msg_free(tmsg);
        return tmsg;
    }
}
