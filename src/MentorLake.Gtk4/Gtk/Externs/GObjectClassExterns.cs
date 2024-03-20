using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;

public static class GObjectClassExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_install_properties")]
	internal static extern uint gtk_editable_install_properties(this GObjectClassHandle object_class, uint first_prop);
}
