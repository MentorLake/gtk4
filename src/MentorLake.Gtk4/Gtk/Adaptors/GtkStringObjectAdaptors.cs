using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkStringObjectAdaptors
{
	public static string GetString(this GtkStringObjectHandle self)
	{
		return GtkStringObjectExterns.gtk_string_object_get_string(self);
	}
}
