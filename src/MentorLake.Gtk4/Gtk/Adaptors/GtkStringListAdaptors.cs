using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkStringListAdaptors
{
	public static GtkStringListHandle Append(this GtkStringListHandle self, string @string)
	{
		GtkStringListExterns.gtk_string_list_append(self, @string);
		return self;
	}

	public static GtkStringListHandle Take(this GtkStringListHandle self, string @string)
	{
		GtkStringListExterns.gtk_string_list_take(self, @string);
		return self;
	}

	public static GtkStringListHandle Remove(this GtkStringListHandle self, uint position)
	{
		GtkStringListExterns.gtk_string_list_remove(self, position);
		return self;
	}

	public static GtkStringListHandle Splice(this GtkStringListHandle self, uint position, uint n_removals, string additions)
	{
		GtkStringListExterns.gtk_string_list_splice(self, position, n_removals, additions);
		return self;
	}

	public static string GetString(this GtkStringListHandle self, uint position)
	{
		return GtkStringListExterns.gtk_string_list_get_string(self, position);
	}
}
