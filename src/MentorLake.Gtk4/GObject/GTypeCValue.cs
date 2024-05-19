namespace MentorLake.Gtk4.GObject;

public class GTypeCValueHandle : BaseSafeHandle
{
}

internal class GTypeCValueExterns
{
}

public struct GTypeCValue
{
	public int v_int;
	public long v_long;
	public long v_int64;
	public double v_double;
	public IntPtr v_pointer;
}
