namespace MentorLake.Gtk4.Gtk4;

public interface GtkSectionModelHandle
{
}

internal class GtkSectionModelHandleImpl : BaseSafeHandle, GtkSectionModelHandle
{
}

public static class GtkSectionModelHandleExtensions
{
	public static GtkSectionModelHandle GetSection(this GtkSectionModelHandle self, uint position, out uint out_start, out uint out_end)
	{
		GtkSectionModelExterns.gtk_section_model_get_section(self, position, out out_start, out out_end);
		return self;
	}

	public static GtkSectionModelHandle SectionsChanged(this GtkSectionModelHandle self, uint position, uint n_items)
	{
		GtkSectionModelExterns.gtk_section_model_sections_changed(self, position, n_items);
		return self;
	}

}

internal class GtkSectionModelExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_section_model_get_section(GtkSectionModelHandle self, uint position, out uint out_start, out uint out_end);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_section_model_sections_changed(GtkSectionModelHandle self, uint position, uint n_items);

}
