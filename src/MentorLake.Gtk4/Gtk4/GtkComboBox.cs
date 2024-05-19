namespace MentorLake.Gtk4.Gtk4;

public class GtkComboBoxHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkCellLayoutHandle, GtkConstraintTargetHandle
{
	public static GtkComboBoxHandle New()
	{
		return GtkComboBoxExterns.gtk_combo_box_new();
	}

	public static GtkComboBoxHandle NewWithEntry()
	{
		return GtkComboBoxExterns.gtk_combo_box_new_with_entry();
	}

	public static GtkComboBoxHandle NewWithModel(GtkTreeModelHandle model)
	{
		return GtkComboBoxExterns.gtk_combo_box_new_with_model(model);
	}

	public static GtkComboBoxHandle NewWithModelAndEntry(GtkTreeModelHandle model)
	{
		return GtkComboBoxExterns.gtk_combo_box_new_with_model_and_entry(model);
	}

}

public static class GtkComboBoxSignalExtensions
{

	public static IObservable<GtkComboBoxSignalStructs.ActivateSignal> Signal_Activate(this GtkComboBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkComboBoxSignalStructs.ActivateSignal> obs) =>
		{
			GtkComboBoxSignalDelegates.Activate handler = (GtkComboBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkComboBoxSignalStructs.ChangedSignal> Signal_Changed(this GtkComboBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkComboBoxSignalStructs.ChangedSignal> obs) =>
		{
			GtkComboBoxSignalDelegates.Changed handler = (GtkComboBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxSignalStructs.ChangedSignal()
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

	public static IObservable<GtkComboBoxSignalStructs.FormatEntryTextSignal> Signal_FormatEntryText(this GtkComboBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkComboBoxSignalStructs.FormatEntryTextSignal> obs) =>
		{
			GtkComboBoxSignalDelegates.FormatEntryText handler = (GtkComboBoxHandle self, string path, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxSignalStructs.FormatEntryTextSignal()
				{
					Self = self, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "format_entry_text", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkComboBoxSignalStructs.MoveActiveSignal> Signal_MoveActive(this GtkComboBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkComboBoxSignalStructs.MoveActiveSignal> obs) =>
		{
			GtkComboBoxSignalDelegates.MoveActive handler = (GtkComboBoxHandle self, ref GtkScrollType scroll_type, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxSignalStructs.MoveActiveSignal()
				{
					Self = self, ScrollType = scroll_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_active", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkComboBoxSignalStructs.PopdownSignal> Signal_Popdown(this GtkComboBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkComboBoxSignalStructs.PopdownSignal> obs) =>
		{
			GtkComboBoxSignalDelegates.Popdown handler = (GtkComboBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxSignalStructs.PopdownSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "popdown", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkComboBoxSignalStructs.PopupSignal> Signal_Popup(this GtkComboBoxHandle instance)
	{
		return Observable.Create((IObserver<GtkComboBoxSignalStructs.PopupSignal> obs) =>
		{
			GtkComboBoxSignalDelegates.Popup handler = (GtkComboBoxHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkComboBoxSignalStructs.PopupSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkComboBoxSignalStructs
{

public struct ActivateSignal
{
	public GtkComboBoxHandle Self;
	public IntPtr UserData;
}

public struct ChangedSignal
{
	public GtkComboBoxHandle Self;
	public IntPtr UserData;
}

public struct FormatEntryTextSignal
{
	public GtkComboBoxHandle Self;
	public string Path;
	public IntPtr UserData;
	public string ReturnValue;
}

public struct MoveActiveSignal
{
	public GtkComboBoxHandle Self;
	public GtkScrollType ScrollType;
	public IntPtr UserData;
}

public struct PopdownSignal
{
	public GtkComboBoxHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct PopupSignal
{
	public GtkComboBoxHandle Self;
	public IntPtr UserData;
}
}

public static class GtkComboBoxSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkComboBoxHandle>))] GtkComboBoxHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkComboBoxHandle>))] GtkComboBoxHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate string FormatEntryText([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkComboBoxHandle>))] GtkComboBoxHandle self, string path, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MoveActive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkComboBoxHandle>))] GtkComboBoxHandle self, ref GtkScrollType scroll_type, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool Popdown([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkComboBoxHandle>))] GtkComboBoxHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkComboBoxHandle>))] GtkComboBoxHandle self, IntPtr user_data);
}


public static class GtkComboBoxHandleExtensions
{
	public static int GetActive(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_active(combo_box);
	}

	public static string GetActiveId(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_active_id(combo_box);
	}

	public static bool GetActiveIter(this GtkComboBoxHandle combo_box, out GtkTreeIter iter)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_active_iter(combo_box, out iter);
	}

	public static GtkSensitivityType GetButtonSensitivity(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_button_sensitivity(combo_box);
	}

	public static GtkWidgetHandle GetChild(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_child(combo_box);
	}

	public static int GetEntryTextColumn(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_entry_text_column(combo_box);
	}

	public static bool GetHasEntry(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_has_entry(combo_box);
	}

	public static int GetIdColumn(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_id_column(combo_box);
	}

	public static GtkTreeModelHandle GetModel(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_model(combo_box);
	}

	public static bool GetPopupFixedWidth(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_popup_fixed_width(combo_box);
	}

	public static GtkTreeViewRowSeparatorFunc GetRowSeparatorFunc(this GtkComboBoxHandle combo_box)
	{
		return GtkComboBoxExterns.gtk_combo_box_get_row_separator_func(combo_box);
	}

	public static GtkComboBoxHandle Popdown(this GtkComboBoxHandle combo_box)
	{
		GtkComboBoxExterns.gtk_combo_box_popdown(combo_box);
		return combo_box;
	}

	public static GtkComboBoxHandle Popup(this GtkComboBoxHandle combo_box)
	{
		GtkComboBoxExterns.gtk_combo_box_popup(combo_box);
		return combo_box;
	}

	public static GtkComboBoxHandle PopupForDevice(this GtkComboBoxHandle combo_box, GdkDeviceHandle device)
	{
		GtkComboBoxExterns.gtk_combo_box_popup_for_device(combo_box, device);
		return combo_box;
	}

	public static GtkComboBoxHandle SetActive(this GtkComboBoxHandle combo_box, int index_)
	{
		GtkComboBoxExterns.gtk_combo_box_set_active(combo_box, index_);
		return combo_box;
	}

	public static bool SetActiveId(this GtkComboBoxHandle combo_box, string active_id)
	{
		return GtkComboBoxExterns.gtk_combo_box_set_active_id(combo_box, active_id);
	}

	public static GtkComboBoxHandle SetActiveIter(this GtkComboBoxHandle combo_box, GtkTreeIterHandle iter)
	{
		GtkComboBoxExterns.gtk_combo_box_set_active_iter(combo_box, iter);
		return combo_box;
	}

	public static GtkComboBoxHandle SetButtonSensitivity(this GtkComboBoxHandle combo_box, GtkSensitivityType sensitivity)
	{
		GtkComboBoxExterns.gtk_combo_box_set_button_sensitivity(combo_box, sensitivity);
		return combo_box;
	}

	public static GtkComboBoxHandle SetChild(this GtkComboBoxHandle combo_box, GtkWidgetHandle child)
	{
		GtkComboBoxExterns.gtk_combo_box_set_child(combo_box, child);
		return combo_box;
	}

	public static GtkComboBoxHandle SetEntryTextColumn(this GtkComboBoxHandle combo_box, int text_column)
	{
		GtkComboBoxExterns.gtk_combo_box_set_entry_text_column(combo_box, text_column);
		return combo_box;
	}

	public static GtkComboBoxHandle SetIdColumn(this GtkComboBoxHandle combo_box, int id_column)
	{
		GtkComboBoxExterns.gtk_combo_box_set_id_column(combo_box, id_column);
		return combo_box;
	}

	public static GtkComboBoxHandle SetModel(this GtkComboBoxHandle combo_box, GtkTreeModelHandle model)
	{
		GtkComboBoxExterns.gtk_combo_box_set_model(combo_box, model);
		return combo_box;
	}

	public static GtkComboBoxHandle SetPopupFixedWidth(this GtkComboBoxHandle combo_box, bool @fixed)
	{
		GtkComboBoxExterns.gtk_combo_box_set_popup_fixed_width(combo_box, @fixed);
		return combo_box;
	}

	public static GtkComboBoxHandle SetRowSeparatorFunc(this GtkComboBoxHandle combo_box, GtkTreeViewRowSeparatorFunc func, IntPtr data, GDestroyNotify destroy)
	{
		GtkComboBoxExterns.gtk_combo_box_set_row_separator_func(combo_box, func, data, destroy);
		return combo_box;
	}

}

internal class GtkComboBoxExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkComboBoxHandle gtk_combo_box_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkComboBoxHandle gtk_combo_box_new_with_entry();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkComboBoxHandle gtk_combo_box_new_with_model(GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkComboBoxHandle gtk_combo_box_new_with_model_and_entry(GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_combo_box_get_active(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_combo_box_get_active_id(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_combo_box_get_active_iter(GtkComboBoxHandle combo_box, out GtkTreeIter iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSensitivityType gtk_combo_box_get_button_sensitivity(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_combo_box_get_child(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_combo_box_get_entry_text_column(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_combo_box_get_has_entry(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_combo_box_get_id_column(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeModelHandle gtk_combo_box_get_model(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_combo_box_get_popup_fixed_width(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeViewRowSeparatorFunc gtk_combo_box_get_row_separator_func(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_popdown(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_popup(GtkComboBoxHandle combo_box);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_popup_for_device(GtkComboBoxHandle combo_box, GdkDeviceHandle device);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_active(GtkComboBoxHandle combo_box, int index_);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_combo_box_set_active_id(GtkComboBoxHandle combo_box, string active_id);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_active_iter(GtkComboBoxHandle combo_box, GtkTreeIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_button_sensitivity(GtkComboBoxHandle combo_box, GtkSensitivityType sensitivity);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_child(GtkComboBoxHandle combo_box, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_entry_text_column(GtkComboBoxHandle combo_box, int text_column);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_id_column(GtkComboBoxHandle combo_box, int id_column);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_model(GtkComboBoxHandle combo_box, GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_popup_fixed_width(GtkComboBoxHandle combo_box, bool @fixed);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_combo_box_set_row_separator_func(GtkComboBoxHandle combo_box, GtkTreeViewRowSeparatorFunc func, IntPtr data, GDestroyNotify destroy);

}
