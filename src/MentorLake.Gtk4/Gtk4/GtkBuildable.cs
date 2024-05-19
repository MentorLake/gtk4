namespace MentorLake.Gtk4.Gtk4;

public interface GtkBuildableHandle
{
}

internal class GtkBuildableHandleImpl : BaseSafeHandle, GtkBuildableHandle
{
}

public static class GtkBuildableHandleExtensions
{
	public static string GetBuildableId(this GtkBuildableHandle buildable)
	{
		return GtkBuildableExterns.gtk_buildable_get_buildable_id(buildable);
	}

}

internal class GtkBuildableExterns
{
	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_buildable_get_buildable_id(GtkBuildableHandle buildable);

}
