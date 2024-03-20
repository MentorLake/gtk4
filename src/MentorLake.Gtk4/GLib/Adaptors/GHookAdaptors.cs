using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GHookAdaptors
{
    public static int CompareIds(this GHookHandle new_hook, GHookHandle sibling)
    {
        return GHookExterns.g_hook_compare_ids(new_hook, sibling);
    }
}
