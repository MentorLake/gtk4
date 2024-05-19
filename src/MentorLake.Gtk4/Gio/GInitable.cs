namespace MentorLake.Gtk4.Gio;

public interface GInitableHandle
{
}

internal class GInitableHandleImpl : BaseSafeHandle, GInitableHandle
{
}

public static class GInitableHandleExtensions
{
	public static bool Init(this GInitableHandle initable, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GInitableExterns.g_initable_init(initable, cancellable, out error);
	}

}

internal class GInitableExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_initable_init(GInitableHandle initable, GCancellableHandle cancellable, out GErrorHandle error);

}
