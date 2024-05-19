namespace MentorLake.Gtk4.Gtk4;

public interface GtkAccessibleTextHandle
{
}

internal class GtkAccessibleTextHandleImpl : BaseSafeHandle, GtkAccessibleTextHandle
{
}

public static class GtkAccessibleTextHandleExtensions
{
	public static GtkAccessibleTextHandle UpdateCaretPosition(this GtkAccessibleTextHandle self)
	{
		GtkAccessibleTextExterns.gtk_accessible_text_update_caret_position(self);
		return self;
	}

	public static GtkAccessibleTextHandle UpdateContents(this GtkAccessibleTextHandle self, GtkAccessibleTextContentChange change, int start, int end)
	{
		GtkAccessibleTextExterns.gtk_accessible_text_update_contents(self, change, start, end);
		return self;
	}

	public static GtkAccessibleTextHandle UpdateSelectionBound(this GtkAccessibleTextHandle self)
	{
		GtkAccessibleTextExterns.gtk_accessible_text_update_selection_bound(self);
		return self;
	}

}

internal class GtkAccessibleTextExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_text_update_caret_position(GtkAccessibleTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_text_update_contents(GtkAccessibleTextHandle self, GtkAccessibleTextContentChange change, int start, int end);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_accessible_text_update_selection_bound(GtkAccessibleTextHandle self);

}
