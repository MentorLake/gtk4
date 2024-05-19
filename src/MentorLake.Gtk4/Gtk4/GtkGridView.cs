namespace MentorLake.Gtk4.Gtk4;

public class GtkGridViewHandle : GtkListBaseHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle, GtkScrollableHandle
{
	public static GtkGridViewHandle New(GtkSelectionModelHandle model, GtkListItemFactoryHandle factory)
	{
		return GtkGridViewExterns.gtk_grid_view_new(model, factory);
	}

}

public static class GtkGridViewSignalExtensions
{

	public static IObservable<GtkGridViewSignalStructs.ActivateSignal> Signal_Activate(this GtkGridViewHandle instance)
	{
		return Observable.Create((IObserver<GtkGridViewSignalStructs.ActivateSignal> obs) =>
		{
			GtkGridViewSignalDelegates.Activate handler = (GtkGridViewHandle self, uint position, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkGridViewSignalStructs.ActivateSignal()
				{
					Self = self, Position = position, UserData = user_data
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

public static class GtkGridViewSignalStructs
{

public struct ActivateSignal
{
	public GtkGridViewHandle Self;
	public uint Position;
	public IntPtr UserData;
}
}

public static class GtkGridViewSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGridViewHandle>))] GtkGridViewHandle self, uint position, IntPtr user_data);
}


public static class GtkGridViewHandleExtensions
{
	public static bool GetEnableRubberband(this GtkGridViewHandle self)
	{
		return GtkGridViewExterns.gtk_grid_view_get_enable_rubberband(self);
	}

	public static GtkListItemFactoryHandle GetFactory(this GtkGridViewHandle self)
	{
		return GtkGridViewExterns.gtk_grid_view_get_factory(self);
	}

	public static uint GetMaxColumns(this GtkGridViewHandle self)
	{
		return GtkGridViewExterns.gtk_grid_view_get_max_columns(self);
	}

	public static uint GetMinColumns(this GtkGridViewHandle self)
	{
		return GtkGridViewExterns.gtk_grid_view_get_min_columns(self);
	}

	public static GtkSelectionModelHandle GetModel(this GtkGridViewHandle self)
	{
		return GtkGridViewExterns.gtk_grid_view_get_model(self);
	}

	public static bool GetSingleClickActivate(this GtkGridViewHandle self)
	{
		return GtkGridViewExterns.gtk_grid_view_get_single_click_activate(self);
	}

	public static GtkListTabBehavior GetTabBehavior(this GtkGridViewHandle self)
	{
		return GtkGridViewExterns.gtk_grid_view_get_tab_behavior(self);
	}

	public static GtkGridViewHandle ScrollTo(this GtkGridViewHandle self, uint pos, GtkListScrollFlags flags, GtkScrollInfoHandle scroll)
	{
		GtkGridViewExterns.gtk_grid_view_scroll_to(self, pos, flags, scroll);
		return self;
	}

	public static GtkGridViewHandle SetEnableRubberband(this GtkGridViewHandle self, bool enable_rubberband)
	{
		GtkGridViewExterns.gtk_grid_view_set_enable_rubberband(self, enable_rubberband);
		return self;
	}

	public static GtkGridViewHandle SetFactory(this GtkGridViewHandle self, GtkListItemFactoryHandle factory)
	{
		GtkGridViewExterns.gtk_grid_view_set_factory(self, factory);
		return self;
	}

	public static GtkGridViewHandle SetMaxColumns(this GtkGridViewHandle self, uint max_columns)
	{
		GtkGridViewExterns.gtk_grid_view_set_max_columns(self, max_columns);
		return self;
	}

	public static GtkGridViewHandle SetMinColumns(this GtkGridViewHandle self, uint min_columns)
	{
		GtkGridViewExterns.gtk_grid_view_set_min_columns(self, min_columns);
		return self;
	}

	public static GtkGridViewHandle SetModel(this GtkGridViewHandle self, GtkSelectionModelHandle model)
	{
		GtkGridViewExterns.gtk_grid_view_set_model(self, model);
		return self;
	}

	public static GtkGridViewHandle SetSingleClickActivate(this GtkGridViewHandle self, bool single_click_activate)
	{
		GtkGridViewExterns.gtk_grid_view_set_single_click_activate(self, single_click_activate);
		return self;
	}

	public static GtkGridViewHandle SetTabBehavior(this GtkGridViewHandle self, GtkListTabBehavior tab_behavior)
	{
		GtkGridViewExterns.gtk_grid_view_set_tab_behavior(self, tab_behavior);
		return self;
	}

}

internal class GtkGridViewExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGridViewHandle gtk_grid_view_new(GtkSelectionModelHandle model, GtkListItemFactoryHandle factory);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_grid_view_get_enable_rubberband(GtkGridViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListItemFactoryHandle gtk_grid_view_get_factory(GtkGridViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_grid_view_get_max_columns(GtkGridViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_grid_view_get_min_columns(GtkGridViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSelectionModelHandle gtk_grid_view_get_model(GtkGridViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_grid_view_get_single_click_activate(GtkGridViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkListTabBehavior gtk_grid_view_get_tab_behavior(GtkGridViewHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_view_scroll_to(GtkGridViewHandle self, uint pos, GtkListScrollFlags flags, GtkScrollInfoHandle scroll);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_view_set_enable_rubberband(GtkGridViewHandle self, bool enable_rubberband);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_view_set_factory(GtkGridViewHandle self, GtkListItemFactoryHandle factory);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_view_set_max_columns(GtkGridViewHandle self, uint max_columns);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_view_set_min_columns(GtkGridViewHandle self, uint min_columns);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_view_set_model(GtkGridViewHandle self, GtkSelectionModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_view_set_single_click_activate(GtkGridViewHandle self, bool single_click_activate);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_grid_view_set_tab_behavior(GtkGridViewHandle self, GtkListTabBehavior tab_behavior);

}
