using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.GObject;
public static class GSourceAdaptors
{
    public static GSourceHandle SetClosure(this GSourceHandle source, GClosureHandle closure)
    {
        GSourceExterns.g_source_set_closure(source, closure);
        return source;
    }

    public static GSourceHandle SetDummyCallback(this GSourceHandle source)
    {
        GSourceExterns.g_source_set_dummy_callback(source);
        return source;
    }
}
