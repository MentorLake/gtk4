using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkEditableLabelAdaptors
{
	public static int GetEditing(this GtkEditableLabelHandle self)
	{
		return GtkEditableLabelExterns.gtk_editable_label_get_editing(self);
	}

	public static GtkEditableLabelHandle StartEditing(this GtkEditableLabelHandle self)
	{
		GtkEditableLabelExterns.gtk_editable_label_start_editing(self);
		return self;
	}

	public static GtkEditableLabelHandle StopEditing(this GtkEditableLabelHandle self, int commit)
	{
		GtkEditableLabelExterns.gtk_editable_label_stop_editing(self, commit);
		return self;
	}
}
