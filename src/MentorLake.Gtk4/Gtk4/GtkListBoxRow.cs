namespace MentorLake.Gtk4.Gtk4;

public class GtkListBoxRowHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkActionableHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkListBoxRowHandle New()
	{
		return GtkListBoxRowExterns.gtk_list_box_row_new();
	}

}

public static class GtkListBoxRowSignalExtensions
{

	public static IObservable<GtkListBoxRowSignalStructs.ActivateSignal> Signal_Activate(this GtkListBoxRowHandle instance)
	{
		return Observable.Create((IObserver<GtkListBoxRowSignalStructs.ActivateSignal> obs) =>
		{
			GtkListBoxRowSignalDelegates.activate handler = (GtkListBoxRowHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkListBoxRowSignalStructs.ActivateSignal()
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
}

public static class GtkListBoxRowSignalStructs
{

public struct ActivateSignal
{
	public GtkListBoxRowHandle Self;
	public IntPtr UserData;
}
}

public static class GtkListBoxRowSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkListBoxRowHandle>))] GtkListBoxRowHandle self, IntPtr user_data);

}


public static class GtkListBoxRowHandleExtensions
{
	public static GtkListBoxRowHandle Changed(this GtkListBoxRowHandle row)
	{
		GtkListBoxRowExterns.gtk_list_box_row_changed(row);
		return row;
	}

	public static bool GetActivatable(this GtkListBoxRowHandle row)
	{
		return GtkListBoxRowExterns.gtk_list_box_row_get_activatable(row);
	}

	public static GtkWidgetHandle GetChild(this GtkListBoxRowHandle row)
	{
		return GtkListBoxRowExterns.gtk_list_box_row_get_child(row);
	}

	public static GtkWidgetHandle GetHeader(this GtkListBoxRowHandle row)
	{
		return GtkListBoxRowExterns.gtk_list_box_row_get_header(row);
	}

	public static int GetIndex(this GtkListBoxRowHandle row)
	{
		return GtkListBoxRowExterns.gtk_list_box_row_get_index(row);
	}

	public static bool GetSelectable(this GtkListBoxRowHandle row)
	{
		return GtkListBoxRowExterns.gtk_list_box_row_get_selectable(row);
	}

	public static bool IsSelected(this GtkListBoxRowHandle row)
	{
		return GtkListBoxRowExterns.gtk_list_box_row_is_selected(row);
	}

	public static GtkListBoxRowHandle SetActivatable(this GtkListBoxRowHandle row, bool activatable)
	{
		GtkListBoxRowExterns.gtk_list_box_row_set_activatable(row, activatable);
		return row;
	}

	public static GtkListBoxRowHandle SetChild(this GtkListBoxRowHandle row, GtkWidgetHandle child)
	{
		GtkListBoxRowExterns.gtk_list_box_row_set_child(row, child);
		return row;
	}

	public static GtkListBoxRowHandle SetHeader(this GtkListBoxRowHandle row, GtkWidgetHandle header)
	{
		GtkListBoxRowExterns.gtk_list_box_row_set_header(row, header);
		return row;
	}

	public static GtkListBoxRowHandle SetSelectable(this GtkListBoxRowHandle row, bool selectable)
	{
		GtkListBoxRowExterns.gtk_list_box_row_set_selectable(row, selectable);
		return row;
	}

}

internal class GtkListBoxRowExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListBoxRowHandle gtk_list_box_row_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_row_changed(GtkListBoxRowHandle row);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_list_box_row_get_activatable(GtkListBoxRowHandle row);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_list_box_row_get_child(GtkListBoxRowHandle row);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_list_box_row_get_header(GtkListBoxRowHandle row);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_list_box_row_get_index(GtkListBoxRowHandle row);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_list_box_row_get_selectable(GtkListBoxRowHandle row);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_list_box_row_is_selected(GtkListBoxRowHandle row);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_row_set_activatable(GtkListBoxRowHandle row, bool activatable);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_row_set_child(GtkListBoxRowHandle row, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_row_set_header(GtkListBoxRowHandle row, GtkWidgetHandle header);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_list_box_row_set_selectable(GtkListBoxRowHandle row, bool selectable);

}
