using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GDirAdaptors
{
    public static string ReadName(this GDirHandle dir)
    {
        return GDirExterns.g_dir_read_name(dir);
    }

    public static GDirHandle Rewind(this GDirHandle dir)
    {
        GDirExterns.g_dir_rewind(dir);
        return dir;
    }

    public static GDirHandle Close(this GDirHandle dir)
    {
        GDirExterns.g_dir_close(dir);
        return dir;
    }
}
