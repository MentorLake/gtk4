using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkFlowBoxHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
	public static GtkFlowBoxHandle New()
	{
		return GtkFlowBoxExterns.gtk_flow_box_new();
	}

}

public static class GtkFlowBoxSignalExtensions
{

	public static IObservable<GtkFlowBoxSignalStructs.ActivateCursorChildSignal> Signal_ActivateCursorChild(this GtkFlowBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkFlowBoxSignalStructs.ActivateCursorChildSignal> obs) =>
		{
			GtkFlowBoxSignalDelegates.ActivateCursorChild handler = (GtkFlowBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxSignalStructs.ActivateCursorChildSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate_cursor_child", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFlowBoxSignalStructs.ChildActivatedSignal> Signal_ChildActivated(this GtkFlowBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkFlowBoxSignalStructs.ChildActivatedSignal> obs) =>
		{
			GtkFlowBoxSignalDelegates.ChildActivated handler = (GtkFlowBoxHandle self, GtkFlowBoxChildHandle child, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxSignalStructs.ChildActivatedSignal()
				{
					Self = self, Child = child, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "child_activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFlowBoxSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkFlowBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkFlowBoxSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkFlowBoxSignalDelegates.MoveCursor handler = (GtkFlowBoxHandle self, ref GtkMovementStep step, int count, bool extend, bool modify, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxSignalStructs.MoveCursorSignal()
				{
					Self = self, Step = step, Count = count, Extend = extend, Modify = modify, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFlowBoxSignalStructs.SelectAllSignal> Signal_SelectAll(this GtkFlowBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkFlowBoxSignalStructs.SelectAllSignal> obs) =>
		{
			GtkFlowBoxSignalDelegates.SelectAll handler = (GtkFlowBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxSignalStructs.SelectAllSignal()
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

	public static IObservable<GtkFlowBoxSignalStructs.SelectedChildrenChangedSignal> Signal_SelectedChildrenChanged(this GtkFlowBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkFlowBoxSignalStructs.SelectedChildrenChangedSignal> obs) =>
		{
			GtkFlowBoxSignalDelegates.SelectedChildrenChanged handler = (GtkFlowBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxSignalStructs.SelectedChildrenChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "selected_children_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFlowBoxSignalStructs.ToggleCursorChildSignal> Signal_ToggleCursorChild(this GtkFlowBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkFlowBoxSignalStructs.ToggleCursorChildSignal> obs) =>
		{
			GtkFlowBoxSignalDelegates.ToggleCursorChild handler = (GtkFlowBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxSignalStructs.ToggleCursorChildSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "toggle_cursor_child", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkFlowBoxSignalStructs.UnselectAllSignal> Signal_UnselectAll(this GtkFlowBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkFlowBoxSignalStructs.UnselectAllSignal> obs) =>
		{
			GtkFlowBoxSignalDelegates.UnselectAll handler = (GtkFlowBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFlowBoxSignalStructs.UnselectAllSignal()
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

public static class GtkFlowBoxSignalStructs
{

public struct ActivateCursorChildSignal
{
	public GtkFlowBoxHandle Self;
	public IntPtr UserData;
}

public struct ChildActivatedSignal
{
	public GtkFlowBoxHandle Self;
	public GtkFlowBoxChildHandle Child;
	public IntPtr UserData;
}

public struct MoveCursorSignal
{
	public GtkFlowBoxHandle Self;
	public GtkMovementStep Step;
	public int Count;
	public bool Extend;
	public bool Modify;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct SelectAllSignal
{
	public GtkFlowBoxHandle Self;
	public IntPtr UserData;
}

public struct SelectedChildrenChangedSignal
{
	public GtkFlowBoxHandle Self;
	public IntPtr UserData;
}

public struct ToggleCursorChildSignal
{
	public GtkFlowBoxHandle Self;
	public IntPtr UserData;
}

public struct UnselectAllSignal
{
	public GtkFlowBoxHandle Self;
	public IntPtr UserData;
}
}

public static class GtkFlowBoxSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ActivateCursorChild([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxHandle>))] GtkFlowBoxHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ChildActivated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxHandle>))] GtkFlowBoxHandle self, GtkFlowBoxChildHandle child, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool MoveCursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxHandle>))] GtkFlowBoxHandle self, ref GtkMovementStep step, int count, bool extend, bool modify, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void SelectAll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxHandle>))] GtkFlowBoxHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void SelectedChildrenChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxHandle>))] GtkFlowBoxHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ToggleCursorChild([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxHandle>))] GtkFlowBoxHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void UnselectAll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFlowBoxHandle>))] GtkFlowBoxHandle self, IntPtr user_data);
}


public static class GtkFlowBoxHandleExtensions
{
	public static GtkFlowBoxHandle Append(this GtkFlowBoxHandle self, GtkWidgetHandle child)
	{
		GtkFlowBoxExterns.gtk_flow_box_append(self, child);
		return self;
	}

	public static GtkFlowBoxHandle BindModel(this GtkFlowBoxHandle box, GListModelHandle model, GtkFlowBoxCreateWidgetFunc create_widget_func, IntPtr user_data, GDestroyNotify user_data_free_func)
	{
		GtkFlowBoxExterns.gtk_flow_box_bind_model(box, model, create_widget_func, user_data, user_data_free_func);
		return box;
	}

	public static bool GetActivateOnSingleClick(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_activate_on_single_click(box);
	}

	public static GtkFlowBoxChildHandle GetChildAtIndex(this GtkFlowBoxHandle box, int idx)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_child_at_index(box, idx);
	}

	public static GtkFlowBoxChildHandle GetChildAtPos(this GtkFlowBoxHandle box, int x, int y)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_child_at_pos(box, x, y);
	}

	public static uint GetColumnSpacing(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_column_spacing(box);
	}

	public static bool GetHomogeneous(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_homogeneous(box);
	}

	public static uint GetMaxChildrenPerLine(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_max_children_per_line(box);
	}

	public static uint GetMinChildrenPerLine(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_min_children_per_line(box);
	}

	public static uint GetRowSpacing(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_row_spacing(box);
	}

	public static GListHandle GetSelectedChildren(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_selected_children(box);
	}

	public static GtkSelectionMode GetSelectionMode(this GtkFlowBoxHandle box)
	{
		return GtkFlowBoxExterns.gtk_flow_box_get_selection_mode(box);
	}

	public static GtkFlowBoxHandle Insert(this GtkFlowBoxHandle box, GtkWidgetHandle widget, int position)
	{
		GtkFlowBoxExterns.gtk_flow_box_insert(box, widget, position);
		return box;
	}

	public static GtkFlowBoxHandle InvalidateFilter(this GtkFlowBoxHandle box)
	{
		GtkFlowBoxExterns.gtk_flow_box_invalidate_filter(box);
		return box;
	}

	public static GtkFlowBoxHandle InvalidateSort(this GtkFlowBoxHandle box)
	{
		GtkFlowBoxExterns.gtk_flow_box_invalidate_sort(box);
		return box;
	}

	public static GtkFlowBoxHandle Prepend(this GtkFlowBoxHandle self, GtkWidgetHandle child)
	{
		GtkFlowBoxExterns.gtk_flow_box_prepend(self, child);
		return self;
	}

	public static GtkFlowBoxHandle Remove(this GtkFlowBoxHandle box, GtkWidgetHandle widget)
	{
		GtkFlowBoxExterns.gtk_flow_box_remove(box, widget);
		return box;
	}

	public static GtkFlowBoxHandle RemoveAll(this GtkFlowBoxHandle box)
	{
		GtkFlowBoxExterns.gtk_flow_box_remove_all(box);
		return box;
	}

	public static GtkFlowBoxHandle SelectAll(this GtkFlowBoxHandle box)
	{
		GtkFlowBoxExterns.gtk_flow_box_select_all(box);
		return box;
	}

	public static GtkFlowBoxHandle SelectChild(this GtkFlowBoxHandle box, GtkFlowBoxChildHandle child)
	{
		GtkFlowBoxExterns.gtk_flow_box_select_child(box, child);
		return box;
	}

	public static GtkFlowBoxHandle SelectedForeach(this GtkFlowBoxHandle box, GtkFlowBoxForeachFunc func, IntPtr data)
	{
		GtkFlowBoxExterns.gtk_flow_box_selected_foreach(box, func, data);
		return box;
	}

	public static GtkFlowBoxHandle SetActivateOnSingleClick(this GtkFlowBoxHandle box, bool single)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_activate_on_single_click(box, single);
		return box;
	}

	public static GtkFlowBoxHandle SetColumnSpacing(this GtkFlowBoxHandle box, uint spacing)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_column_spacing(box, spacing);
		return box;
	}

	public static GtkFlowBoxHandle SetFilterFunc(this GtkFlowBoxHandle box, GtkFlowBoxFilterFunc filter_func, IntPtr user_data, GDestroyNotify destroy)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_filter_func(box, filter_func, user_data, destroy);
		return box;
	}

	public static GtkFlowBoxHandle SetHadjustment(this GtkFlowBoxHandle box, GtkAdjustmentHandle adjustment)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_hadjustment(box, adjustment);
		return box;
	}

	public static GtkFlowBoxHandle SetHomogeneous(this GtkFlowBoxHandle box, bool homogeneous)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_homogeneous(box, homogeneous);
		return box;
	}

	public static GtkFlowBoxHandle SetMaxChildrenPerLine(this GtkFlowBoxHandle box, uint n_children)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_max_children_per_line(box, n_children);
		return box;
	}

	public static GtkFlowBoxHandle SetMinChildrenPerLine(this GtkFlowBoxHandle box, uint n_children)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_min_children_per_line(box, n_children);
		return box;
	}

	public static GtkFlowBoxHandle SetRowSpacing(this GtkFlowBoxHandle box, uint spacing)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_row_spacing(box, spacing);
		return box;
	}

	public static GtkFlowBoxHandle SetSelectionMode(this GtkFlowBoxHandle box, GtkSelectionMode mode)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_selection_mode(box, mode);
		return box;
	}

	public static GtkFlowBoxHandle SetSortFunc(this GtkFlowBoxHandle box, GtkFlowBoxSortFunc sort_func, IntPtr user_data, GDestroyNotify destroy)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_sort_func(box, sort_func, user_data, destroy);
		return box;
	}

	public static GtkFlowBoxHandle SetVadjustment(this GtkFlowBoxHandle box, GtkAdjustmentHandle adjustment)
	{
		GtkFlowBoxExterns.gtk_flow_box_set_vadjustment(box, adjustment);
		return box;
	}

	public static GtkFlowBoxHandle UnselectAll(this GtkFlowBoxHandle box)
	{
		GtkFlowBoxExterns.gtk_flow_box_unselect_all(box);
		return box;
	}

	public static GtkFlowBoxHandle UnselectChild(this GtkFlowBoxHandle box, GtkFlowBoxChildHandle child)
	{
		GtkFlowBoxExterns.gtk_flow_box_unselect_child(box, child);
		return box;
	}

}

internal class GtkFlowBoxExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFlowBoxHandle gtk_flow_box_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_append(GtkFlowBoxHandle self, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_bind_model(GtkFlowBoxHandle box, GListModelHandle model, GtkFlowBoxCreateWidgetFunc create_widget_func, IntPtr user_data, GDestroyNotify user_data_free_func);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_flow_box_get_activate_on_single_click(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFlowBoxChildHandle gtk_flow_box_get_child_at_index(GtkFlowBoxHandle box, int idx);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFlowBoxChildHandle gtk_flow_box_get_child_at_pos(GtkFlowBoxHandle box, int x, int y);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_flow_box_get_column_spacing(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_flow_box_get_homogeneous(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_flow_box_get_max_children_per_line(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_flow_box_get_min_children_per_line(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_flow_box_get_row_spacing(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListHandle gtk_flow_box_get_selected_children(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSelectionMode gtk_flow_box_get_selection_mode(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_insert(GtkFlowBoxHandle box, GtkWidgetHandle widget, int position);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_invalidate_filter(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_invalidate_sort(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_prepend(GtkFlowBoxHandle self, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_remove(GtkFlowBoxHandle box, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_remove_all(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_select_all(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_select_child(GtkFlowBoxHandle box, GtkFlowBoxChildHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_selected_foreach(GtkFlowBoxHandle box, GtkFlowBoxForeachFunc func, IntPtr data);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_set_activate_on_single_click(GtkFlowBoxHandle box, bool single);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_set_column_spacing(GtkFlowBoxHandle box, uint spacing);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_set_filter_func(GtkFlowBoxHandle box, GtkFlowBoxFilterFunc filter_func, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_set_hadjustment(GtkFlowBoxHandle box, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_set_homogeneous(GtkFlowBoxHandle box, bool homogeneous);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_set_max_children_per_line(GtkFlowBoxHandle box, uint n_children);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_set_min_children_per_line(GtkFlowBoxHandle box, uint n_children);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_set_row_spacing(GtkFlowBoxHandle box, uint spacing);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_set_selection_mode(GtkFlowBoxHandle box, GtkSelectionMode mode);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_set_sort_func(GtkFlowBoxHandle box, GtkFlowBoxSortFunc sort_func, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_set_vadjustment(GtkFlowBoxHandle box, GtkAdjustmentHandle adjustment);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_unselect_all(GtkFlowBoxHandle box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_flow_box_unselect_child(GtkFlowBoxHandle box, GtkFlowBoxChildHandle child);

}
