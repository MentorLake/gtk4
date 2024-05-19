namespace MentorLake.Gtk4.GObject;

public class GValueArrayHandle : BaseSafeHandle
{
	public static GValueArrayHandle New(uint n_prealloced)
	{
		return GValueArrayExterns.g_value_array_new(n_prealloced);
	}

}

internal class GValueArrayExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern GValueArrayHandle g_value_array_new(uint n_prealloced);

}

public struct GValueArray
{
	public uint n_values;
	public GValueHandle values;
}
