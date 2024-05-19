namespace MentorLake.Gtk4.Gtk4;

public class GtkListBoxHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkListBoxHandle New()
	{
		return GtkListBoxExterns.gtk_list_box_new();
	}

}

public static class GtkListBoxSignalExtensions
{

	public static IObservable<GtkListBoxSignalStructs.ActivateCursorRowSignal> Signal_ActivateCursorRow(this GtkListBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkListBoxSignalStructs.ActivateCursorRowSignal> obs) =>
		{
			GtkListBoxSignalDelegates.ActivateCursorRow handler = (GtkListBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxSignalStructs.ActivateCursorRowSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate_cursor_row", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkListBoxSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkListBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkListBoxSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkListBoxSignalDelegates.MoveCursor handler = (GtkListBoxHandle self, ref GtkMovementStep @object, int p0, bool p1, bool p2, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxSignalStructs.MoveCursorSignal()
				{
					Self = self, Object = @object, P0 = p0, P1 = p1, P2 = p2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkListBoxSignalStructs.RowActivatedSignal> Signal_RowActivated(this GtkListBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkListBoxSignalStructs.RowActivatedSignal> obs) =>
		{
			GtkListBoxSignalDelegates.RowActivated handler = (GtkListBoxHandle self, GtkListBoxRowHandle row, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxSignalStructs.RowActivatedSignal()
				{
					Self = self, Row = row, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "row_activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkListBoxSignalStructs.RowSelectedSignal> Signal_RowSelected(this GtkListBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkListBoxSignalStructs.RowSelectedSignal> obs) =>
		{
			GtkListBoxSignalDelegates.RowSelected handler = (GtkListBoxHandle self, GtkListBoxRowHandle row, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxSignalStructs.RowSelectedSignal()
				{
					Self = self, Row = row, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "row_selected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkListBoxSignalStructs.SelectAllSignal> Signal_SelectAll(this GtkListBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkListBoxSignalStructs.SelectAllSignal> obs) =>
		{
			GtkListBoxSignalDelegates.SelectAll handler = (GtkListBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxSignalStructs.SelectAllSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "select_all", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkListBoxSignalStructs.SelectedRowsChangedSignal> Signal_SelectedRowsChanged(this GtkListBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkListBoxSignalStructs.SelectedRowsChangedSignal> obs) =>
		{
			GtkListBoxSignalDelegates.SelectedRowsChanged handler = (GtkListBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxSignalStructs.SelectedRowsChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "selected_rows_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkListBoxSignalStructs.ToggleCursorRowSignal> Signal_ToggleCursorRow(this GtkListBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkListBoxSignalStructs.ToggleCursorRowSignal> obs) =>
		{
			GtkListBoxSignalDelegates.ToggleCursorRow handler = (GtkListBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxSignalStructs.ToggleCursorRowSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "toggle_cursor_row", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkListBoxSignalStructs.UnselectAllSignal> Signal_UnselectAll(this GtkListBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkListBoxSignalStructs.UnselectAllSignal> obs) =>
		{
			GtkListBoxSignalDelegates.UnselectAll handler = (GtkListBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxSignalStructs.UnselectAllSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "unselect_all", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkListBoxSignalStructs
{

public struct ActivateCursorRowSignal
{
	public GtkListBoxHandle Self;
	public IntPtr UserData;
}

public struct MoveCursorSignal
{
	public GtkListBoxHandle Self;
	public GtkMovementStep Object;
	public int P0;
	public bool P1;
	public bool P2;
	public IntPtr UserData;
}

public struct RowActivatedSignal
{
	public GtkListBoxHandle Self;
	public GtkListBoxRowHandle Row;
	public IntPtr UserData;
}

public struct RowSelectedSignal
{
	public GtkListBoxHandle Self;
	public GtkListBoxRowHandle Row;
	public IntPtr UserData;
}

public struct SelectAllSignal
{
	public GtkListBoxHandle Self;
	public IntPtr UserData;
}

public struct SelectedRowsChangedSignal
{
	public GtkListBoxHandle Self;
	public IntPtr UserData;
}

public struct ToggleCursorRowSignal
{
	public GtkListBoxHandle Self;
	public IntPtr UserData;
}

public struct UnselectAllSignal
{
	public GtkListBoxHandle Self;
	public IntPtr UserData;
}
}

public static class GtkListBoxSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ActivateCursorRow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkListBoxHandle>))] GtkListBoxHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MoveCursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkListBoxHandle>))] GtkListBoxHandle self, ref GtkMovementStep @object, int p0, bool p1, bool p2, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void RowActivated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkListBoxHandle>))] GtkListBoxHandle self, GtkListBoxRowHandle row, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void RowSelected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkListBoxHandle>))] GtkListBoxHandle self, GtkListBoxRowHandle row, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void SelectAll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkListBoxHandle>))] GtkListBoxHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void SelectedRowsChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkListBoxHandle>))] GtkListBoxHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ToggleCursorRow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkListBoxHandle>))] GtkListBoxHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void UnselectAll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkListBoxHandle>))] GtkListBoxHandle self, IntPtr user_data);
}


public static class GtkListBoxHandleExtensions
{
	public static GtkListBoxHandle Append(this GtkListBoxHandle box, GtkWidgetHandle child)
	{
		GtkListBoxExterns.gtk_list_box_append(box, child);
		return box;
	}

	public static GtkListBoxHandle BindModel(this GtkListBoxHandle box, GListModelHandle model, GtkListBoxCreateWidgetFunc create_widget_func, IntPtr user_data, GDestroyNotify user_data_free_func)
	{
		GtkListBoxExterns.gtk_list_box_bind_model(box, model, create_widget_func, user_data, user_data_free_func);
		return box;
	}

	public static GtkListBoxHandle DragHighlightRow(this GtkListBoxHandle box, GtkListBoxRowHandle row)
	{
		GtkListBoxExterns.gtk_list_box_drag_highlight_row(box, row);
		return box;
	}

	public static GtkListBoxHandle DragUnhighlightRow(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_drag_unhighlight_row(box);
		return box;
	}

	public static bool GetActivateOnSingleClick(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_activate_on_single_click(box);
	}

	public static GtkAdjustmentHandle GetAdjustment(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_adjustment(box);
	}

	public static GtkListBoxRowHandle GetRowAtIndex(this GtkListBoxHandle box, int index_)
	{
		return GtkListBoxExterns.gtk_list_box_get_row_at_index(box, index_);
	}

	public static GtkListBoxRowHandle GetRowAtY(this GtkListBoxHandle box, int y)
	{
		return GtkListBoxExterns.gtk_list_box_get_row_at_y(box, y);
	}

	public static GtkListBoxRowHandle GetSelectedRow(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_selected_row(box);
	}

	public static GListHandle GetSelectedRows(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_selected_rows(box);
	}

	public static GtkSelectionMode GetSelectionMode(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_selection_mode(box);
	}

	public static bool GetShowSeparators(this GtkListBoxHandle box)
	{
		return GtkListBoxExterns.gtk_list_box_get_show_separators(box);
	}

	public static GtkListBoxHandle Insert(this GtkListBoxHandle box, GtkWidgetHandle child, int position)
	{
		GtkListBoxExterns.gtk_list_box_insert(box, child, position);
		return box;
	}

	public static GtkListBoxHandle InvalidateFilter(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_invalidate_filter(box);
		return box;
	}

	public static GtkListBoxHandle InvalidateHeaders(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_invalidate_headers(box);
		return box;
	}

	public static GtkListBoxHandle InvalidateSort(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_invalidate_sort(box);
		return box;
	}

	public static GtkListBoxHandle Prepend(this GtkListBoxHandle box, GtkWidgetHandle child)
	{
		GtkListBoxExterns.gtk_list_box_prepend(box, child);
		return box;
	}

	public static GtkListBoxHandle Remove(this GtkListBoxHandle box, GtkWidgetHandle child)
	{
		GtkListBoxExterns.gtk_list_box_remove(box, child);
		return box;
	}

	public static GtkListBoxHandle RemoveAll(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_remove_all(box);
		return box;
	}

	public static GtkListBoxHandle SelectAll(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_select_all(box);
		return box;
	}

	public static GtkListBoxHandle SelectRow(this GtkListBoxHandle box, GtkListBoxRowHandle row)
	{
		GtkListBoxExterns.gtk_list_box_select_row(box, row);
		return box;
	}

	public static GtkListBoxHandle SelectedForeach(this GtkListBoxHandle box, GtkListBoxForeachFunc func, IntPtr data)
	{
		GtkListBoxExterns.gtk_list_box_selected_foreach(box, func, data);
		return box;
	}

	public static GtkListBoxHandle SetActivateOnSingleClick(this GtkListBoxHandle box, bool single)
	{
		GtkListBoxExterns.gtk_list_box_set_activate_on_single_click(box, single);
		return box;
	}

	public static GtkListBoxHandle SetAdjustment(this GtkListBoxHandle box, GtkAdjustmentHandle adjustment)
	{
		GtkListBoxExterns.gtk_list_box_set_adjustment(box, adjustment);
		return box;
	}

	public static GtkListBoxHandle SetFilterFunc(this GtkListBoxHandle box, GtkListBoxFilterFunc filter_func, IntPtr user_data, GDestroyNotify destroy)
	{
		GtkListBoxExterns.gtk_list_box_set_filter_func(box, filter_func, user_data, destroy);
		return box;
	}

	public static GtkListBoxHandle SetHeaderFunc(this GtkListBoxHandle box, GtkListBoxUpdateHeaderFunc update_header, IntPtr user_data, GDestroyNotify destroy)
	{
		GtkListBoxExterns.gtk_list_box_set_header_func(box, update_header, user_data, destroy);
		return box;
	}

	public static GtkListBoxHandle SetPlaceholder(this GtkListBoxHandle box, GtkWidgetHandle placeholder)
	{
		GtkListBoxExterns.gtk_list_box_set_placeholder(box, placeholder);
		return box;
	}

	public static GtkListBoxHandle SetSelectionMode(this GtkListBoxHandle box, GtkSelectionMode mode)
	{
		GtkListBoxExterns.gtk_list_box_set_selection_mode(box, mode);
		return box;
	}

	public static GtkListBoxHandle SetShowSeparators(this GtkListBoxHandle box, bool show_separators)
	{
		GtkListBoxExterns.gtk_list_box_set_show_separators(box, show_separators);
		return box;
	}

	public static GtkListBoxHandle SetSortFunc(this GtkListBoxHandle box, GtkListBoxSortFunc sort_func, IntPtr user_data, GDestroyNotify destroy)
	{
		GtkListBoxExterns.gtk_list_box_set_sort_func(box, sort_func, user_data, destroy);
		return box;
	}

	public static GtkListBoxHandle UnselectAll(this GtkListBoxHandle box)
	{
		GtkListBoxExterns.gtk_list_box_unselect_all(box);
		return box;
	}

	public static GtkListBoxHandle UnselectRow(this GtkListBoxHandle box, GtkListBoxRowHandle row)
	{
		GtkListBoxExterns.gtk_list_box_unselect_row(box, row);
		return box;
	}

}

internal class GtkListBoxExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListBoxHandle gtk_list_box_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_append(GtkListBoxHandle box, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_bind_model(GtkListBoxHandle box, GListModelHandle model, GtkListBoxCreateWidgetFunc create_widget_func, IntPtr user_data, GDestroyNotify user_data_free_func);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_drag_highlight_row(GtkListBoxHandle box, GtkListBoxRowHandle row);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_drag_unhighlight_row(GtkListBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_list_box_get_activate_on_single_click(GtkListBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAdjustmentHandle gtk_list_box_get_adjustment(GtkListBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListBoxRowHandle gtk_list_box_get_row_at_index(GtkListBoxHandle box, int index_);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListBoxRowHandle gtk_list_box_get_row_at_y(GtkListBoxHandle box, int y);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListBoxRowHandle gtk_list_box_get_selected_row(GtkListBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListHandle gtk_list_box_get_selected_rows(GtkListBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSelectionMode gtk_list_box_get_selection_mode(GtkListBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_list_box_get_show_separators(GtkListBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_insert(GtkListBoxHandle box, GtkWidgetHandle child, int position);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_invalidate_filter(GtkListBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_invalidate_headers(GtkListBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_invalidate_sort(GtkListBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_prepend(GtkListBoxHandle box, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_remove(GtkListBoxHandle box, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_remove_all(GtkListBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_select_all(GtkListBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_select_row(GtkListBoxHandle box, GtkListBoxRowHandle row);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_selected_foreach(GtkListBoxHandle box, GtkListBoxForeachFunc func, IntPtr data);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_set_activate_on_single_click(GtkListBoxHandle box, bool single);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_set_adjustment(GtkListBoxHandle box, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_set_filter_func(GtkListBoxHandle box, GtkListBoxFilterFunc filter_func, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_set_header_func(GtkListBoxHandle box, GtkListBoxUpdateHeaderFunc update_header, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_set_placeholder(GtkListBoxHandle box, GtkWidgetHandle placeholder);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_set_selection_mode(GtkListBoxHandle box, GtkSelectionMode mode);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_set_show_separators(GtkListBoxHandle box, bool show_separators);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_set_sort_func(GtkListBoxHandle box, GtkListBoxSortFunc sort_func, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_unselect_all(GtkListBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_unselect_row(GtkListBoxHandle box, GtkListBoxRowHandle row);

}
