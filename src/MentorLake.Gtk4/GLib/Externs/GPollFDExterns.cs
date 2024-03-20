using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;

public static class GPollFDExterns
{
	[DllImport(Libraries.GLib, EntryPoint = "g_poll")]
	internal static extern int g_poll(this GPollFDHandle fds, uint nfds, int timeout);
}
