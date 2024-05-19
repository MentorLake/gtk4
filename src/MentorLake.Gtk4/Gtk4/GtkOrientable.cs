namespace MentorLake.Gtk4.Gtk4;

public interface GtkOrientableHandle
{
}

internal class GtkOrientableHandleImpl : BaseSafeHandle, GtkOrientableHandle
{
}

public static class GtkOrientableHandleExtensions
{
	public static GtkOrientation GetOrientation(this GtkOrientableHandle orientable)
	{
		return GtkOrientableExterns.gtk_orientable_get_orientation(orientable);
	}

	public static GtkOrientableHandle SetOrientation(this GtkOrientableHandle orientable, GtkOrientation orientation)
	{
		GtkOrientableExterns.gtk_orientable_set_orientation(orientable, orientation);
		return orientable;
	}

}

internal class GtkOrientableExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkOrientation gtk_orientable_get_orientation(GtkOrientableHandle orientable);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_orientable_set_orientation(GtkOrientableHandle orientable, GtkOrientation orientation);

}
