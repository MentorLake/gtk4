namespace MentorLake.Gtk4.Gdk4;

public class GdkTimeCoordHandle : BaseSafeHandle
{
}

internal class GdkTimeCoordExterns
{
}

public struct GdkTimeCoord
{
	public uint time;
	public GdkAxisFlags flags;
	public None axes;
}
