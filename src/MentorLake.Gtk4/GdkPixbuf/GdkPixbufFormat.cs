namespace MentorLake.Gtk4.GdkPixbuf;

public class GdkPixbufFormatHandle : BaseSafeHandle
{
}

internal class GdkPixbufFormatExterns
{
}

public struct GdkPixbufFormat
{
	public string name;
	public GdkPixbufModulePatternHandle signature;
	public string domain;
	public string description;
	public string[] mime_types;
	public string[] extensions;
	public uint flags;
	public bool disabled;
	public string license;
}
