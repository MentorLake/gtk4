using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GMainLoopAdaptors
{
    public static GMainLoopHandle Run(this GMainLoopHandle loop)
    {
        GMainLoopExterns.g_main_loop_run(loop);
        return loop;
    }

    public static GMainLoopHandle Quit(this GMainLoopHandle loop)
    {
        GMainLoopExterns.g_main_loop_quit(loop);
        return loop;
    }

    public static GMainLoopHandle Ref(this GMainLoopHandle loop)
    {
        return GMainLoopExterns.g_main_loop_ref(loop);
    }

    public static GMainLoopHandle Unref(this GMainLoopHandle loop)
    {
        GMainLoopExterns.g_main_loop_unref(loop);
        return loop;
    }

    public static int IsRunning(this GMainLoopHandle loop)
    {
        return GMainLoopExterns.g_main_loop_is_running(loop);
    }

    public static GMainContextHandle GetContext(this GMainLoopHandle loop)
    {
        return GMainLoopExterns.g_main_loop_get_context(loop);
    }
}
