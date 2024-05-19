namespace MentorLake.Gtk4.Pango;

public class PangoLayoutLineHandle : BaseSafeHandle
{
}

internal class PangoLayoutLineExterns
{
}

public struct PangoLayoutLine
{
	public PangoLayoutHandle layout;
	public int start_index;
	public int length;
	public GSListHandle runs;
	public uint is_paragraph_start;
	public uint resolved_dir;
}
