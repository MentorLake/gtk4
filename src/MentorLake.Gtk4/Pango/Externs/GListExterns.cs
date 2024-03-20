using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Pango;

public static class GListExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "pango_reorder_items")]
	internal static extern GListHandle pango_reorder_items(this GListHandle items);
}
