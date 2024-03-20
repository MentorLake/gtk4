using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.GLib;
public static class GMemVTableAdaptors
{
    public static GMemVTableHandle GMemSetVtable(this GMemVTableHandle vtable)
    {
        GMemVTableExterns.g_mem_set_vtable(vtable);
        return vtable;
    }
}
