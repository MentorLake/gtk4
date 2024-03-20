using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;
public static class GdkFileListAdaptors
{
    public static GSListHandle GetFiles(this GdkFileListHandle file_list)
    {
        return GdkFileListExterns.gdk_file_list_get_files(file_list);
    }
}
