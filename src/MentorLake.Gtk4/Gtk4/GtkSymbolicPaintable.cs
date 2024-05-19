namespace MentorLake.Gtk4.Gtk4;

public interface GtkSymbolicPaintableHandle
{
}

internal class GtkSymbolicPaintableHandleImpl : BaseSafeHandle, GtkSymbolicPaintableHandle
{
}

public static class GtkSymbolicPaintableHandleExtensions
{
	public static GtkSymbolicPaintableHandle SnapshotSymbolic(this GtkSymbolicPaintableHandle paintable, GdkSnapshotHandle snapshot, double width, double height, GdkRGBA[] colors, int n_colors)
	{
		GtkSymbolicPaintableExterns.gtk_symbolic_paintable_snapshot_symbolic(paintable, snapshot, width, height, colors, n_colors);
		return paintable;
	}

}

internal class GtkSymbolicPaintableExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_symbolic_paintable_snapshot_symbolic(GtkSymbolicPaintableHandle paintable, GdkSnapshotHandle snapshot, double width, double height, GdkRGBA[] colors, int n_colors);

}
