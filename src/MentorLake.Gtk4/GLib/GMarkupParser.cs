namespace MentorLake.Gtk4.GLib;

public class GMarkupParserHandle : BaseSafeHandle
{
}

internal class GMarkupParserExterns
{
}

public struct GMarkupParser
{
	public IntPtr start_element;
	public IntPtr end_element;
	public IntPtr text;
	public IntPtr passthrough;
	public IntPtr error;
}
