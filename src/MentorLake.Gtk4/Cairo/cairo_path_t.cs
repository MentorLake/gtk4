using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public class cairo_path_tHandle : BaseSafeHandle { }

public struct cairo_path_t
{
	public cairo_status_t status;
	public cairo_path_data_tHandle data;
	public int num_data;
}

public static class cairo_path_tAdaptors
{
	public static cairo_path_tHandle CairoPathDestroy(this cairo_path_tHandle pathT)
	{
		cairo_path_tExterns.cairo_path_destroy(pathT);
		return pathT;
	}
}

public static class cairo_path_tExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_path_destroy")]
	internal static extern void cairo_path_destroy(this cairo_path_tHandle pathT);
}
