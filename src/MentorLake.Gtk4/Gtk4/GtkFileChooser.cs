namespace MentorLake.Gtk4.Gtk4;

public interface GtkFileChooserHandle
{
}

internal class GtkFileChooserHandleImpl : BaseSafeHandle, GtkFileChooserHandle
{
}

public static class GtkFileChooserHandleExtensions
{
	public static GtkFileChooserHandle AddChoice(this GtkFileChooserHandle chooser, string id, string label, string[] options, string[] option_labels)
	{
		GtkFileChooserExterns.gtk_file_chooser_add_choice(chooser, id, label, options, option_labels);
		return chooser;
	}

	public static GtkFileChooserHandle AddFilter(this GtkFileChooserHandle chooser, GtkFileFilterHandle filter)
	{
		GtkFileChooserExterns.gtk_file_chooser_add_filter(chooser, filter);
		return chooser;
	}

	public static bool AddShortcutFolder(this GtkFileChooserHandle chooser, GFileHandle folder, out GErrorHandle error)
	{
		return GtkFileChooserExterns.gtk_file_chooser_add_shortcut_folder(chooser, folder, out error);
	}

	public static GtkFileChooserAction GetAction(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_action(chooser);
	}

	public static string GetChoice(this GtkFileChooserHandle chooser, string id)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_choice(chooser, id);
	}

	public static bool GetCreateFolders(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_create_folders(chooser);
	}

	public static GFileHandle GetCurrentFolder(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_current_folder(chooser);
	}

	public static string GetCurrentName(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_current_name(chooser);
	}

	public static GFileHandle GetFile(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_file(chooser);
	}

	public static GListModelHandle GetFiles(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_files(chooser);
	}

	public static GtkFileFilterHandle GetFilter(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_filter(chooser);
	}

	public static GListModelHandle GetFilters(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_filters(chooser);
	}

	public static bool GetSelectMultiple(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_select_multiple(chooser);
	}

	public static GListModelHandle GetShortcutFolders(this GtkFileChooserHandle chooser)
	{
		return GtkFileChooserExterns.gtk_file_chooser_get_shortcut_folders(chooser);
	}

	public static GtkFileChooserHandle RemoveChoice(this GtkFileChooserHandle chooser, string id)
	{
		GtkFileChooserExterns.gtk_file_chooser_remove_choice(chooser, id);
		return chooser;
	}

	public static GtkFileChooserHandle RemoveFilter(this GtkFileChooserHandle chooser, GtkFileFilterHandle filter)
	{
		GtkFileChooserExterns.gtk_file_chooser_remove_filter(chooser, filter);
		return chooser;
	}

	public static bool RemoveShortcutFolder(this GtkFileChooserHandle chooser, GFileHandle folder, out GErrorHandle error)
	{
		return GtkFileChooserExterns.gtk_file_chooser_remove_shortcut_folder(chooser, folder, out error);
	}

	public static GtkFileChooserHandle SetAction(this GtkFileChooserHandle chooser, GtkFileChooserAction action)
	{
		GtkFileChooserExterns.gtk_file_chooser_set_action(chooser, action);
		return chooser;
	}

	public static GtkFileChooserHandle SetChoice(this GtkFileChooserHandle chooser, string id, string option)
	{
		GtkFileChooserExterns.gtk_file_chooser_set_choice(chooser, id, option);
		return chooser;
	}

	public static GtkFileChooserHandle SetCreateFolders(this GtkFileChooserHandle chooser, bool create_folders)
	{
		GtkFileChooserExterns.gtk_file_chooser_set_create_folders(chooser, create_folders);
		return chooser;
	}

	public static bool SetCurrentFolder(this GtkFileChooserHandle chooser, GFileHandle file, out GErrorHandle error)
	{
		return GtkFileChooserExterns.gtk_file_chooser_set_current_folder(chooser, file, out error);
	}

	public static GtkFileChooserHandle SetCurrentName(this GtkFileChooserHandle chooser, string name)
	{
		GtkFileChooserExterns.gtk_file_chooser_set_current_name(chooser, name);
		return chooser;
	}

	public static bool SetFile(this GtkFileChooserHandle chooser, GFileHandle file, out GErrorHandle error)
	{
		return GtkFileChooserExterns.gtk_file_chooser_set_file(chooser, file, out error);
	}

	public static GtkFileChooserHandle SetFilter(this GtkFileChooserHandle chooser, GtkFileFilterHandle filter)
	{
		GtkFileChooserExterns.gtk_file_chooser_set_filter(chooser, filter);
		return chooser;
	}

	public static GtkFileChooserHandle SetSelectMultiple(this GtkFileChooserHandle chooser, bool select_multiple)
	{
		GtkFileChooserExterns.gtk_file_chooser_set_select_multiple(chooser, select_multiple);
		return chooser;
	}

}

internal class GtkFileChooserExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_chooser_add_choice(GtkFileChooserHandle chooser, string id, string label, string[] options, string[] option_labels);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_chooser_add_filter(GtkFileChooserHandle chooser, GtkFileFilterHandle filter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_file_chooser_add_shortcut_folder(GtkFileChooserHandle chooser, GFileHandle folder, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFileChooserAction gtk_file_chooser_get_action(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_get_choice(GtkFileChooserHandle chooser, string id);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_file_chooser_get_create_folders(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk4)]
	internal static extern GFileHandle gtk_file_chooser_get_current_folder(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_file_chooser_get_current_name(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk4)]
	internal static extern GFileHandle gtk_file_chooser_get_file(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_file_chooser_get_files(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFileFilterHandle gtk_file_chooser_get_filter(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_file_chooser_get_filters(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_file_chooser_get_select_multiple(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_file_chooser_get_shortcut_folders(GtkFileChooserHandle chooser);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_chooser_remove_choice(GtkFileChooserHandle chooser, string id);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_chooser_remove_filter(GtkFileChooserHandle chooser, GtkFileFilterHandle filter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_file_chooser_remove_shortcut_folder(GtkFileChooserHandle chooser, GFileHandle folder, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_chooser_set_action(GtkFileChooserHandle chooser, GtkFileChooserAction action);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_chooser_set_choice(GtkFileChooserHandle chooser, string id, string option);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_chooser_set_create_folders(GtkFileChooserHandle chooser, bool create_folders);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_file_chooser_set_current_folder(GtkFileChooserHandle chooser, GFileHandle file, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_chooser_set_current_name(GtkFileChooserHandle chooser, string name);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_file_chooser_set_file(GtkFileChooserHandle chooser, GFileHandle file, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_chooser_set_filter(GtkFileChooserHandle chooser, GtkFileFilterHandle filter);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_file_chooser_set_select_multiple(GtkFileChooserHandle chooser, bool select_multiple);

}
