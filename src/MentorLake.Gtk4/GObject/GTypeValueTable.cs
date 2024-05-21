namespace MentorLake.Gtk4.GObject;

public class GTypeValueTableHandle : BaseSafeHandle
{
}


public static class GTypeValueTableHandleExtensions
{
}
internal class GTypeValueTableExterns
{
}

public struct GTypeValueTable
{
	public GTypeValueInitFunc value_init;
	public GTypeValueFreeFunc value_free;
	public GTypeValueCopyFunc value_copy;
	public GTypeValuePeekPointerFunc value_peek_pointer;
	public string collect_format;
	public GTypeValueCollectFunc collect_value;
	public string lcopy_format;
	public GTypeValueLCopyFunc lcopy_value;
}
