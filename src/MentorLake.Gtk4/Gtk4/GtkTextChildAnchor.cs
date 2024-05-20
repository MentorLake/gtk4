namespace MentorLake.Gtk4.Gtk4;

public class GtkTextChildAnchorHandle : GObjectHandle
{
	public static GtkTextChildAnchorHandle New()
	{
		return GtkTextChildAnchorExterns.gtk_text_child_anchor_new();
	}

	public static GtkTextChildAnchorHandle NewWithReplacement(string character)
	{
		return GtkTextChildAnchorExterns.gtk_text_child_anchor_new_with_replacement(character);
	}

}

public static class GtkTextChildAnchorHandleExtensions
{
	public static bool GetDeleted(this GtkTextChildAnchorHandle anchor)
	{
		return GtkTextChildAnchorExterns.gtk_text_child_anchor_get_deleted(anchor);
	}

	public static IntPtr GetWidgets(this GtkTextChildAnchorHandle anchor, out uint out_len)
	{
		return GtkTextChildAnchorExterns.gtk_text_child_anchor_get_widgets(anchor, out out_len);
	}

}

internal class GtkTextChildAnchorExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextChildAnchorHandle gtk_text_child_anchor_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextChildAnchorHandle gtk_text_child_anchor_new_with_replacement(string character);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_child_anchor_get_deleted(GtkTextChildAnchorHandle anchor);

	[DllImport(Libraries.Gtk4)]
	internal static extern IntPtr gtk_text_child_anchor_get_widgets(GtkTextChildAnchorHandle anchor, out uint out_len);

}
