namespace MentorLake.Gtk4.GObject;

public class GTypeInfoHandle : BaseSafeHandle
{
}

internal class GTypeInfoExterns
{
}

public struct GTypeInfo
{
	public ushort class_size;
	public GBaseInitFunc base_init;
	public GBaseFinalizeFunc base_finalize;
	public GClassInitFunc class_init;
	public GClassFinalizeFunc class_finalize;
	public IntPtr class_data;
	public ushort instance_size;
	public ushort n_preallocs;
	public GInstanceInitFunc instance_init;
	public GTypeValueTable[] value_table;
}
