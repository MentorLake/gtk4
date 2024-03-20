using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;
public static class GListAdaptors
{
    public static GListHandle PangoReorderItems(this GListHandle items)
    {
        return GListExterns.pango_reorder_items(items);
    }
}
