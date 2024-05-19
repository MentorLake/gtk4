namespace MentorLake.Gtk4.Gtk4;

public class GtkTreeSelectionHandle : GObjectHandle
{
}

public static class GtkTreeSelectionSignalExtensions
{

	public static IObservable<GtkTreeSelectionSignalStructs.ChangedSignal> Signal_Changed(this GtkTreeSelectionHandle instance)
	{
		return Observable.Create((IObserver<GtkTreeSelectionSignalStructs.ChangedSignal> obs) =>
		{
			GtkTreeSelectionSignalDelegates.Changed handler = (GtkTreeSelectionHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeSelectionSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkTreeSelectionSignalStructs
{

public struct ChangedSignal
{
	public GtkTreeSelectionHandle Self;
	public IntPtr UserData;
}
}

public static class GtkTreeSelectionSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeSelectionHandle>))] GtkTreeSelectionHandle self, IntPtr user_data);
}


public static class GtkTreeSelectionHandleExtensions
{
	public static int CountSelectedRows(this GtkTreeSelectionHandle selection)
	{
		return GtkTreeSelectionExterns.gtk_tree_selection_count_selected_rows(selection);
	}

	public static GtkSelectionMode GetMode(this GtkTreeSelectionHandle selection)
	{
		return GtkTreeSelectionExterns.gtk_tree_selection_get_mode(selection);
	}

	public static GtkTreeSelectionFunc GetSelectFunction(this GtkTreeSelectionHandle selection)
	{
		return GtkTreeSelectionExterns.gtk_tree_selection_get_select_function(selection);
	}

	public static bool GetSelected(this GtkTreeSelectionHandle selection, out GtkTreeModelHandle model, out GtkTreeIter iter)
	{
		return GtkTreeSelectionExterns.gtk_tree_selection_get_selected(selection, out model, out iter);
	}

	public static GListHandle GetSelectedRows(this GtkTreeSelectionHandle selection, out GtkTreeModelHandle model)
	{
		return GtkTreeSelectionExterns.gtk_tree_selection_get_selected_rows(selection, out model);
	}

	public static GtkTreeViewHandle GetTreeView(this GtkTreeSelectionHandle selection)
	{
		return GtkTreeSelectionExterns.gtk_tree_selection_get_tree_view(selection);
	}

	public static IntPtr GetUserData(this GtkTreeSelectionHandle selection)
	{
		return GtkTreeSelectionExterns.gtk_tree_selection_get_user_data(selection);
	}

	public static bool IterIsSelected(this GtkTreeSelectionHandle selection, GtkTreeIterHandle iter)
	{
		return GtkTreeSelectionExterns.gtk_tree_selection_iter_is_selected(selection, iter);
	}

	public static bool PathIsSelected(this GtkTreeSelectionHandle selection, GtkTreePathHandle path)
	{
		return GtkTreeSelectionExterns.gtk_tree_selection_path_is_selected(selection, path);
	}

	public static GtkTreeSelectionHandle SelectAll(this GtkTreeSelectionHandle selection)
	{
		GtkTreeSelectionExterns.gtk_tree_selection_select_all(selection);
		return selection;
	}

	public static GtkTreeSelectionHandle SelectIter(this GtkTreeSelectionHandle selection, GtkTreeIterHandle iter)
	{
		GtkTreeSelectionExterns.gtk_tree_selection_select_iter(selection, iter);
		return selection;
	}

	public static GtkTreeSelectionHandle SelectPath(this GtkTreeSelectionHandle selection, GtkTreePathHandle path)
	{
		GtkTreeSelectionExterns.gtk_tree_selection_select_path(selection, path);
		return selection;
	}

	public static GtkTreeSelectionHandle SelectRange(this GtkTreeSelectionHandle selection, GtkTreePathHandle start_path, GtkTreePathHandle end_path)
	{
		GtkTreeSelectionExterns.gtk_tree_selection_select_range(selection, start_path, end_path);
		return selection;
	}

	public static GtkTreeSelectionHandle SelectedForeach(this GtkTreeSelectionHandle selection, GtkTreeSelectionForeachFunc func, IntPtr data)
	{
		GtkTreeSelectionExterns.gtk_tree_selection_selected_foreach(selection, func, data);
		return selection;
	}

	public static GtkTreeSelectionHandle SetMode(this GtkTreeSelectionHandle selection, GtkSelectionMode type)
	{
		GtkTreeSelectionExterns.gtk_tree_selection_set_mode(selection, type);
		return selection;
	}

	public static GtkTreeSelectionHandle SetSelectFunction(this GtkTreeSelectionHandle selection, GtkTreeSelectionFunc func, IntPtr data, GDestroyNotify destroy)
	{
		GtkTreeSelectionExterns.gtk_tree_selection_set_select_function(selection, func, data, destroy);
		return selection;
	}

	public static GtkTreeSelectionHandle UnselectAll(this GtkTreeSelectionHandle selection)
	{
		GtkTreeSelectionExterns.gtk_tree_selection_unselect_all(selection);
		return selection;
	}

	public static GtkTreeSelectionHandle UnselectIter(this GtkTreeSelectionHandle selection, GtkTreeIterHandle iter)
	{
		GtkTreeSelectionExterns.gtk_tree_selection_unselect_iter(selection, iter);
		return selection;
	}

	public static GtkTreeSelectionHandle UnselectPath(this GtkTreeSelectionHandle selection, GtkTreePathHandle path)
	{
		GtkTreeSelectionExterns.gtk_tree_selection_unselect_path(selection, path);
		return selection;
	}

	public static GtkTreeSelectionHandle UnselectRange(this GtkTreeSelectionHandle selection, GtkTreePathHandle start_path, GtkTreePathHandle end_path)
	{
		GtkTreeSelectionExterns.gtk_tree_selection_unselect_range(selection, start_path, end_path);
		return selection;
	}

}

internal class GtkTreeSelectionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_tree_selection_count_selected_rows(GtkTreeSelectionHandle selection);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSelectionMode gtk_tree_selection_get_mode(GtkTreeSelectionHandle selection);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeSelectionFunc gtk_tree_selection_get_select_function(GtkTreeSelectionHandle selection);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_selection_get_selected(GtkTreeSelectionHandle selection, out GtkTreeModelHandle model, out GtkTreeIter iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListHandle gtk_tree_selection_get_selected_rows(GtkTreeSelectionHandle selection, out GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeViewHandle gtk_tree_selection_get_tree_view(GtkTreeSelectionHandle selection);

	[DllImport(Libraries.Gtk4)]
	internal static extern IntPtr gtk_tree_selection_get_user_data(GtkTreeSelectionHandle selection);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_selection_iter_is_selected(GtkTreeSelectionHandle selection, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_selection_path_is_selected(GtkTreeSelectionHandle selection, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_selection_select_all(GtkTreeSelectionHandle selection);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_selection_select_iter(GtkTreeSelectionHandle selection, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_selection_select_path(GtkTreeSelectionHandle selection, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_selection_select_range(GtkTreeSelectionHandle selection, GtkTreePathHandle start_path, GtkTreePathHandle end_path);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_selection_selected_foreach(GtkTreeSelectionHandle selection, GtkTreeSelectionForeachFunc func, IntPtr data);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_selection_set_mode(GtkTreeSelectionHandle selection, GtkSelectionMode type);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_selection_set_select_function(GtkTreeSelectionHandle selection, GtkTreeSelectionFunc func, IntPtr data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_selection_unselect_all(GtkTreeSelectionHandle selection);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_selection_unselect_iter(GtkTreeSelectionHandle selection, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_selection_unselect_path(GtkTreeSelectionHandle selection, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_selection_unselect_range(GtkTreeSelectionHandle selection, GtkTreePathHandle start_path, GtkTreePathHandle end_path);

}
