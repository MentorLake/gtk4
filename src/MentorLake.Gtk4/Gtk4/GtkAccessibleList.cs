namespace MentorLake.Gtk4.Gtk4;

public class GtkAccessibleListHandle : BaseSafeHandle
{
	public static GtkAccessibleListHandle NewFromArray(GtkAccessibleHandle[] accessibles, UIntPtr n_accessibles)
	{
		return GtkAccessibleListExterns.gtk_accessible_list_new_from_array(accessibles, n_accessibles);
	}

	public static GtkAccessibleListHandle NewFromList(GListHandle list)
	{
		return GtkAccessibleListExterns.gtk_accessible_list_new_from_list(list);
	}

}


public static class GtkAccessibleListHandleExtensions
{
	public static GListHandle GetObjects(this GtkAccessibleListHandle accessible_list)
	{
		return GtkAccessibleListExterns.gtk_accessible_list_get_objects(accessible_list);
	}

}
internal class GtkAccessibleListExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAccessibleListHandle gtk_accessible_list_new_from_array(GtkAccessibleHandle[] accessibles, UIntPtr n_accessibles);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAccessibleListHandle gtk_accessible_list_new_from_list(GListHandle list);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListHandle gtk_accessible_list_get_objects(GtkAccessibleListHandle accessible_list);

}

public struct GtkAccessibleList
{
}
