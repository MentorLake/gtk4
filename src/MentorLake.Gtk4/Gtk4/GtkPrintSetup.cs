namespace MentorLake.Gtk4.Gtk4;

public class GtkPrintSetupHandle : BaseSafeHandle
{
}


public static class GtkPrintSetupHandleExtensions
{
	public static GtkPageSetupHandle GetPageSetup(this GtkPrintSetupHandle setup)
	{
		return GtkPrintSetupExterns.gtk_print_setup_get_page_setup(setup);
	}

	public static GtkPrintSettingsHandle GetPrintSettings(this GtkPrintSetupHandle setup)
	{
		return GtkPrintSetupExterns.gtk_print_setup_get_print_settings(setup);
	}

	public static GtkPrintSetupHandle Ref(this GtkPrintSetupHandle setup)
	{
		return GtkPrintSetupExterns.gtk_print_setup_ref(setup);
	}

	public static GtkPrintSetupHandle Unref(this GtkPrintSetupHandle setup)
	{
		GtkPrintSetupExterns.gtk_print_setup_unref(setup);
		return setup;
	}

}
internal class GtkPrintSetupExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageSetupHandle gtk_print_setup_get_page_setup(GtkPrintSetupHandle setup);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintSettingsHandle gtk_print_setup_get_print_settings(GtkPrintSetupHandle setup);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintSetupHandle gtk_print_setup_ref(GtkPrintSetupHandle setup);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_setup_unref(GtkPrintSetupHandle setup);

}

public struct GtkPrintSetup
{
}
