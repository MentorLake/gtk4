namespace MentorLake.Gtk4.Gtk4;

public class GtkAccessibleListHandle : BaseSafeHandle
{
	public static GtkAccessibleListHandle NewFromArray(GtkAccessibleHandle[] accessibles, int n_accessibles)
	{
		return GtkAccessibleListExterns.gtk_accessible_list_new_from_array(accessibles, n_accessibles);
	}

	public static GtkAccessibleListHandle NewFromList(GListHandle list)
	{
		return GtkAccessibleListExterns.gtk_accessible_list_new_from_list(list);
	}

}

internal class GtkAccessibleListExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAccessibleListHandle gtk_accessible_list_new_from_array(GtkAccessibleHandle[] accessibles, int n_accessibles);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAccessibleListHandle gtk_accessible_list_new_from_list(GListHandle list);

}

public struct GtkAccessibleList
{
}
