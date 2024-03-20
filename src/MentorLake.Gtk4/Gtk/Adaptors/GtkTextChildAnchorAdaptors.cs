using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTextChildAnchorAdaptors
{
	public static GtkWidgetHandle[] GetWidgets(this GtkTextChildAnchorHandle anchor, out uint out_len)
	{
		return GtkTextChildAnchorExterns.gtk_text_child_anchor_get_widgets(anchor, out out_len);
	}

	public static int GetDeleted(this GtkTextChildAnchorHandle anchor)
	{
		return GtkTextChildAnchorExterns.gtk_text_child_anchor_get_deleted(anchor);
	}

	public static GtkTextChildAnchorHandle NewWithReplacement(string character)
	{
		return GtkTextChildAnchorExterns.gtk_text_child_anchor_new_with_replacement(character);
	}
}
