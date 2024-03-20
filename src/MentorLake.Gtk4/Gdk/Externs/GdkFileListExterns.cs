using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;

public static class GdkFileListExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_file_list_get_files")]
	internal static extern GSListHandle gdk_file_list_get_files(this GdkFileListHandle file_list);
}
