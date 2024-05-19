namespace MentorLake.Gtk4.Gtk4;

public class GtkSelectionFilterModelHandle : GObjectHandle, GListModelHandle
{
	public static GtkSelectionFilterModelHandle New(GtkSelectionModelHandle model)
	{
		return GtkSelectionFilterModelExterns.gtk_selection_filter_model_new(model);
	}

}

public static class GtkSelectionFilterModelHandleExtensions
{
	public static GtkSelectionModelHandle GetModel(this GtkSelectionFilterModelHandle self)
	{
		return GtkSelectionFilterModelExterns.gtk_selection_filter_model_get_model(self);
	}

	public static GtkSelectionFilterModelHandle SetModel(this GtkSelectionFilterModelHandle self, GtkSelectionModelHandle model)
	{
		GtkSelectionFilterModelExterns.gtk_selection_filter_model_set_model(self, model);
		return self;
	}

}

internal class GtkSelectionFilterModelExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSelectionFilterModelHandle gtk_selection_filter_model_new(GtkSelectionModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSelectionModelHandle gtk_selection_filter_model_get_model(GtkSelectionFilterModelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_selection_filter_model_set_model(GtkSelectionFilterModelHandle self, GtkSelectionModelHandle model);

}
