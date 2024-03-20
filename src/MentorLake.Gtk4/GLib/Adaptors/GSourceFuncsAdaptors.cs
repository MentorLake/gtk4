using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GSourceFuncsAdaptors
{
    public static int GSourceRemoveByFuncsUserData(this GSourceFuncsHandle funcs, IntPtr user_data)
    {
        return GSourceFuncsExterns.g_source_remove_by_funcs_user_data(funcs, user_data);
    }
}
