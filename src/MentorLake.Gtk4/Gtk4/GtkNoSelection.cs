namespace MentorLake.Gtk4.Gtk4;

public class GtkNoSelectionHandle : GObjectHandle, GListModelHandle, GtkSectionModelHandle, GtkSelectionModelHandle
{
	public static GtkNoSelectionHandle New(GListModelHandle model)
	{
		return GtkNoSelectionExterns.gtk_no_selection_new(model);
	}

}

public static class GtkNoSelectionHandleExtensions
{
	public static GListModelHandle GetModel(this GtkNoSelectionHandle self)
	{
		return GtkNoSelectionExterns.gtk_no_selection_get_model(self);
	}

	public static GtkNoSelectionHandle SetModel(this GtkNoSelectionHandle self, GListModelHandle model)
	{
		GtkNoSelectionExterns.gtk_no_selection_set_model(self, model);
		return self;
	}

}

internal class GtkNoSelectionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkNoSelectionHandle gtk_no_selection_new(GListModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_no_selection_get_model(GtkNoSelectionHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_no_selection_set_model(GtkNoSelectionHandle self, GListModelHandle model);

}
