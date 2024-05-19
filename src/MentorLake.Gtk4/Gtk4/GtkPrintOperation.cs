namespace MentorLake.Gtk4.Gtk4;

public class GtkPrintOperationHandle : GObjectHandle, GtkPrintOperationPreviewHandle
{
	public static GtkPrintOperationHandle New()
	{
		return GtkPrintOperationExterns.gtk_print_operation_new();
	}

}

public static class GtkPrintOperationSignalExtensions
{

	public static IObservable<GtkPrintOperationSignalStructs.BeginPrintSignal> Signal_BeginPrint(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.BeginPrintSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.BeginPrint handler = (GtkPrintOperationHandle self, GtkPrintContextHandle context, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.BeginPrintSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "begin_print", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.CreateCustomWidgetSignal> Signal_CreateCustomWidget(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.CreateCustomWidgetSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.CreateCustomWidget handler = (GtkPrintOperationHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.CreateCustomWidgetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "create_custom_widget", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.CustomWidgetApplySignal> Signal_CustomWidgetApply(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.CustomWidgetApplySignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.CustomWidgetApply handler = (GtkPrintOperationHandle self, GtkWidgetHandle widget, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.CustomWidgetApplySignal()
				{
					Self = self, Widget = widget, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "custom_widget_apply", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.DoneSignal> Signal_Done(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.DoneSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.Done handler = (GtkPrintOperationHandle self, GtkPrintOperationResult result, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.DoneSignal()
				{
					Self = self, Result = result, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "done", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.DrawPageSignal> Signal_DrawPage(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.DrawPageSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.DrawPage handler = (GtkPrintOperationHandle self, GtkPrintContextHandle context, int page_nr, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.DrawPageSignal()
				{
					Self = self, Context = context, PageNr = page_nr, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "draw_page", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.EndPrintSignal> Signal_EndPrint(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.EndPrintSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.EndPrint handler = (GtkPrintOperationHandle self, GtkPrintContextHandle context, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.EndPrintSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "end_print", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.PaginateSignal> Signal_Paginate(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.PaginateSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.Paginate handler = (GtkPrintOperationHandle self, GtkPrintContextHandle context, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.PaginateSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "paginate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.PreviewSignal> Signal_Preview(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.PreviewSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.Preview handler = (GtkPrintOperationHandle self, GtkPrintOperationPreviewHandle preview, GtkPrintContextHandle context, GtkWindowHandle parent, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.PreviewSignal()
				{
					Self = self, Preview = preview, Context = context, Parent = parent, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "preview", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.RequestPageSetupSignal> Signal_RequestPageSetup(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.RequestPageSetupSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.RequestPageSetup handler = (GtkPrintOperationHandle self, GtkPrintContextHandle context, int page_nr, GtkPageSetupHandle setup, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.RequestPageSetupSignal()
				{
					Self = self, Context = context, PageNr = page_nr, Setup = setup, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "request_page_setup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.StatusChangedSignal> Signal_StatusChanged(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.StatusChangedSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.StatusChanged handler = (GtkPrintOperationHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.StatusChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "status_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.UpdateCustomWidgetSignal> Signal_UpdateCustomWidget(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.UpdateCustomWidgetSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.UpdateCustomWidget handler = (GtkPrintOperationHandle self, GtkWidgetHandle widget, GtkPageSetupHandle setup, GtkPrintSettingsHandle settings, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.UpdateCustomWidgetSignal()
				{
					Self = self, Widget = widget, Setup = setup, Settings = settings, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "update_custom_widget", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkPrintOperationSignalStructs
{

public struct BeginPrintSignal
{
	public GtkPrintOperationHandle Self;
	public GtkPrintContextHandle Context;
	public IntPtr UserData;
}

public struct CreateCustomWidgetSignal
{
	public GtkPrintOperationHandle Self;
	public IntPtr UserData;
	public GObjectHandle ReturnValue;
}

public struct CustomWidgetApplySignal
{
	public GtkPrintOperationHandle Self;
	public GtkWidgetHandle Widget;
	public IntPtr UserData;
}

public struct DoneSignal
{
	public GtkPrintOperationHandle Self;
	public GtkPrintOperationResult Result;
	public IntPtr UserData;
}

public struct DrawPageSignal
{
	public GtkPrintOperationHandle Self;
	public GtkPrintContextHandle Context;
	public int PageNr;
	public IntPtr UserData;
}

public struct EndPrintSignal
{
	public GtkPrintOperationHandle Self;
	public GtkPrintContextHandle Context;
	public IntPtr UserData;
}

public struct PaginateSignal
{
	public GtkPrintOperationHandle Self;
	public GtkPrintContextHandle Context;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct PreviewSignal
{
	public GtkPrintOperationHandle Self;
	public GtkPrintOperationPreviewHandle Preview;
	public GtkPrintContextHandle Context;
	public GtkWindowHandle Parent;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct RequestPageSetupSignal
{
	public GtkPrintOperationHandle Self;
	public GtkPrintContextHandle Context;
	public int PageNr;
	public GtkPageSetupHandle Setup;
	public IntPtr UserData;
}

public struct StatusChangedSignal
{
	public GtkPrintOperationHandle Self;
	public IntPtr UserData;
}

public struct UpdateCustomWidgetSignal
{
	public GtkPrintOperationHandle Self;
	public GtkWidgetHandle Widget;
	public GtkPageSetupHandle Setup;
	public GtkPrintSettingsHandle Settings;
	public IntPtr UserData;
}
}

public static class GtkPrintOperationSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void BeginPrint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, GtkPrintContextHandle context, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate GObjectHandle CreateCustomWidget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void CustomWidgetApply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, GtkWidgetHandle widget, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, GtkPrintOperationResult result, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DrawPage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, GtkPrintContextHandle context, int page_nr, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void EndPrint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, GtkPrintContextHandle context, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool Paginate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, GtkPrintContextHandle context, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool Preview([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, GtkPrintOperationPreviewHandle preview, GtkPrintContextHandle context, GtkWindowHandle parent, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void RequestPageSetup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, GtkPrintContextHandle context, int page_nr, GtkPageSetupHandle setup, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void StatusChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void UpdateCustomWidget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, GtkWidgetHandle widget, GtkPageSetupHandle setup, GtkPrintSettingsHandle settings, IntPtr user_data);
}


public static class GtkPrintOperationHandleExtensions
{
	public static GtkPrintOperationHandle Cancel(this GtkPrintOperationHandle op)
	{
		GtkPrintOperationExterns.gtk_print_operation_cancel(op);
		return op;
	}

	public static GtkPrintOperationHandle DrawPageFinish(this GtkPrintOperationHandle op)
	{
		GtkPrintOperationExterns.gtk_print_operation_draw_page_finish(op);
		return op;
	}

	public static GtkPageSetupHandle GetDefaultPageSetup(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_default_page_setup(op);
	}

	public static bool GetEmbedPageSetup(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_embed_page_setup(op);
	}

	public static GtkPrintOperationHandle GetError(this GtkPrintOperationHandle op, out GErrorHandle error)
	{
		GtkPrintOperationExterns.gtk_print_operation_get_error(op, out error);
		return op;
	}

	public static bool GetHasSelection(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_has_selection(op);
	}

	public static int GetNPagesToPrint(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_n_pages_to_print(op);
	}

	public static GtkPrintSettingsHandle GetPrintSettings(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_print_settings(op);
	}

	public static GtkPrintStatus GetStatus(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_status(op);
	}

	public static string GetStatusString(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_status_string(op);
	}

	public static bool GetSupportSelection(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_support_selection(op);
	}

	public static bool IsFinished(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_is_finished(op);
	}

	public static GtkPrintOperationResult Run(this GtkPrintOperationHandle op, GtkPrintOperationAction action, GtkWindowHandle parent, out GErrorHandle error)
	{
		return GtkPrintOperationExterns.gtk_print_operation_run(op, action, parent, out error);
	}

	public static GtkPrintOperationHandle SetAllowAsync(this GtkPrintOperationHandle op, bool allow_async)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_allow_async(op, allow_async);
		return op;
	}

	public static GtkPrintOperationHandle SetCurrentPage(this GtkPrintOperationHandle op, int current_page)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_current_page(op, current_page);
		return op;
	}

	public static GtkPrintOperationHandle SetCustomTabLabel(this GtkPrintOperationHandle op, string label)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_custom_tab_label(op, label);
		return op;
	}

	public static GtkPrintOperationHandle SetDefaultPageSetup(this GtkPrintOperationHandle op, GtkPageSetupHandle default_page_setup)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_default_page_setup(op, default_page_setup);
		return op;
	}

	public static GtkPrintOperationHandle SetDeferDrawing(this GtkPrintOperationHandle op)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_defer_drawing(op);
		return op;
	}

	public static GtkPrintOperationHandle SetEmbedPageSetup(this GtkPrintOperationHandle op, bool embed)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_embed_page_setup(op, embed);
		return op;
	}

	public static GtkPrintOperationHandle SetExportFilename(this GtkPrintOperationHandle op, string filename)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_export_filename(op, filename);
		return op;
	}

	public static GtkPrintOperationHandle SetHasSelection(this GtkPrintOperationHandle op, bool has_selection)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_has_selection(op, has_selection);
		return op;
	}

	public static GtkPrintOperationHandle SetJobName(this GtkPrintOperationHandle op, string job_name)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_job_name(op, job_name);
		return op;
	}

	public static GtkPrintOperationHandle SetNPages(this GtkPrintOperationHandle op, int n_pages)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_n_pages(op, n_pages);
		return op;
	}

	public static GtkPrintOperationHandle SetPrintSettings(this GtkPrintOperationHandle op, GtkPrintSettingsHandle print_settings)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_print_settings(op, print_settings);
		return op;
	}

	public static GtkPrintOperationHandle SetShowProgress(this GtkPrintOperationHandle op, bool show_progress)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_show_progress(op, show_progress);
		return op;
	}

	public static GtkPrintOperationHandle SetSupportSelection(this GtkPrintOperationHandle op, bool support_selection)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_support_selection(op, support_selection);
		return op;
	}

	public static GtkPrintOperationHandle SetTrackPrintStatus(this GtkPrintOperationHandle op, bool track_status)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_track_print_status(op, track_status);
		return op;
	}

	public static GtkPrintOperationHandle SetUnit(this GtkPrintOperationHandle op, GtkUnit unit)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_unit(op, unit);
		return op;
	}

	public static GtkPrintOperationHandle SetUseFullPage(this GtkPrintOperationHandle op, bool full_page)
	{
		GtkPrintOperationExterns.gtk_print_operation_set_use_full_page(op, full_page);
		return op;
	}

}

internal class GtkPrintOperationExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintOperationHandle gtk_print_operation_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_cancel(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_draw_page_finish(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageSetupHandle gtk_print_operation_get_default_page_setup(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_operation_get_embed_page_setup(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_get_error(GtkPrintOperationHandle op, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_operation_get_has_selection(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_print_operation_get_n_pages_to_print(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintSettingsHandle gtk_print_operation_get_print_settings(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintStatus gtk_print_operation_get_status(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_operation_get_status_string(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_operation_get_support_selection(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_operation_is_finished(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintOperationResult gtk_print_operation_run(GtkPrintOperationHandle op, GtkPrintOperationAction action, GtkWindowHandle parent, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_allow_async(GtkPrintOperationHandle op, bool allow_async);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_current_page(GtkPrintOperationHandle op, int current_page);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_custom_tab_label(GtkPrintOperationHandle op, string label);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_default_page_setup(GtkPrintOperationHandle op, GtkPageSetupHandle default_page_setup);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_defer_drawing(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_embed_page_setup(GtkPrintOperationHandle op, bool embed);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_export_filename(GtkPrintOperationHandle op, string filename);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_has_selection(GtkPrintOperationHandle op, bool has_selection);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_job_name(GtkPrintOperationHandle op, string job_name);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_n_pages(GtkPrintOperationHandle op, int n_pages);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_print_settings(GtkPrintOperationHandle op, GtkPrintSettingsHandle print_settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_show_progress(GtkPrintOperationHandle op, bool show_progress);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_support_selection(GtkPrintOperationHandle op, bool support_selection);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_track_print_status(GtkPrintOperationHandle op, bool track_status);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_unit(GtkPrintOperationHandle op, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_set_use_full_page(GtkPrintOperationHandle op, bool full_page);

}
