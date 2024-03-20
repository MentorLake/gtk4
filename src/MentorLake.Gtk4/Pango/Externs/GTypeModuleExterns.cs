using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Pango;

public static class GTypeModuleExterns
{
	[DllImport(Libraries.Pango, EntryPoint = "script_engine_init")]
	[Obsolete]
		internal static extern void script_engine_init(this GTypeModuleHandle module);
}
