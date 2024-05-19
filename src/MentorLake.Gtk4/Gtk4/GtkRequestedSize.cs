namespace MentorLake.Gtk4.Gtk4;

public class GtkRequestedSizeHandle : BaseSafeHandle
{
}

internal class GtkRequestedSizeExterns
{
}

public struct GtkRequestedSize
{
	public IntPtr data;
	public int minimum_size;
	public int natural_size;
}
