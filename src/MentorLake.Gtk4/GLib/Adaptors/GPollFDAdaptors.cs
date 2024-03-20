using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GPollFDAdaptors
{
    public static int GPoll(this GPollFDHandle fds, uint nfds, int timeout)
    {
        return GPollFDExterns.g_poll(fds, nfds, timeout);
    }
}
