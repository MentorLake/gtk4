namespace MentorLake.Gtk4.Gtk4;

public class GtkEntryCompletionHandle : GObjectHandle, GtkBuildableHandle, GtkCellLayoutHandle
{
	public static GtkEntryCompletionHandle New()
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_new();
	}

	public static GtkEntryCompletionHandle NewWithArea(GtkCellAreaHandle area)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_new_with_area(area);
	}

}

public static class GtkEntryCompletionSignalExtensions
{

	public static IObservable<GtkEntryCompletionSignalStructs.CursorOnMatchSignal> Signal_CursorOnMatch(this GtkEntryCompletionHandle instance)
	{
		return Observable.Create((IObserver<GtkEntryCompletionSignalStructs.CursorOnMatchSignal> obs) =>
		{
			GtkEntryCompletionSignalDelegates.CursorOnMatch handler = (GtkEntryCompletionHandle self, GtkTreeModelHandle model, GtkTreeIterHandle iter, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryCompletionSignalStructs.CursorOnMatchSignal()
				{
					Self = self, Model = model, Iter = iter, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cursor_on_match", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntryCompletionSignalStructs.InsertPrefixSignal> Signal_InsertPrefix(this GtkEntryCompletionHandle instance)
	{
		return Observable.Create((IObserver<GtkEntryCompletionSignalStructs.InsertPrefixSignal> obs) =>
		{
			GtkEntryCompletionSignalDelegates.InsertPrefix handler = (GtkEntryCompletionHandle self, string prefix, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryCompletionSignalStructs.InsertPrefixSignal()
				{
					Self = self, Prefix = prefix, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "insert_prefix", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntryCompletionSignalStructs.MatchSelectedSignal> Signal_MatchSelected(this GtkEntryCompletionHandle instance)
	{
		return Observable.Create((IObserver<GtkEntryCompletionSignalStructs.MatchSelectedSignal> obs) =>
		{
			GtkEntryCompletionSignalDelegates.MatchSelected handler = (GtkEntryCompletionHandle self, GtkTreeModelHandle model, GtkTreeIterHandle iter, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryCompletionSignalStructs.MatchSelectedSignal()
				{
					Self = self, Model = model, Iter = iter, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "match_selected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntryCompletionSignalStructs.NoMatchesSignal> Signal_NoMatches(this GtkEntryCompletionHandle instance)
	{
		return Observable.Create((IObserver<GtkEntryCompletionSignalStructs.NoMatchesSignal> obs) =>
		{
			GtkEntryCompletionSignalDelegates.NoMatches handler = (GtkEntryCompletionHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryCompletionSignalStructs.NoMatchesSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "no_matches", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkEntryCompletionSignalStructs
{

public struct CursorOnMatchSignal
{
	public GtkEntryCompletionHandle Self;
	public GtkTreeModelHandle Model;
	public GtkTreeIterHandle Iter;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct InsertPrefixSignal
{
	public GtkEntryCompletionHandle Self;
	public string Prefix;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct MatchSelectedSignal
{
	public GtkEntryCompletionHandle Self;
	public GtkTreeModelHandle Model;
	public GtkTreeIterHandle Iter;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct NoMatchesSignal
{
	public GtkEntryCompletionHandle Self;
	public IntPtr UserData;
}
}

public static class GtkEntryCompletionSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool CursorOnMatch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryCompletionHandle>))] GtkEntryCompletionHandle self, GtkTreeModelHandle model, GtkTreeIterHandle iter, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool InsertPrefix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryCompletionHandle>))] GtkEntryCompletionHandle self, string prefix, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool MatchSelected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryCompletionHandle>))] GtkEntryCompletionHandle self, GtkTreeModelHandle model, GtkTreeIterHandle iter, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void NoMatches([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryCompletionHandle>))] GtkEntryCompletionHandle self, IntPtr user_data);
}


public static class GtkEntryCompletionHandleExtensions
{
	public static GtkEntryCompletionHandle Complete(this GtkEntryCompletionHandle completion)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_complete(completion);
		return completion;
	}

	public static string ComputePrefix(this GtkEntryCompletionHandle completion, string key)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_compute_prefix(completion, key);
	}

	public static string GetCompletionPrefix(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_completion_prefix(completion);
	}

	public static GtkWidgetHandle GetEntry(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_entry(completion);
	}

	public static bool GetInlineCompletion(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_inline_completion(completion);
	}

	public static bool GetInlineSelection(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_inline_selection(completion);
	}

	public static int GetMinimumKeyLength(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_minimum_key_length(completion);
	}

	public static GtkTreeModelHandle GetModel(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_model(completion);
	}

	public static bool GetPopupCompletion(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_popup_completion(completion);
	}

	public static bool GetPopupSetWidth(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_popup_set_width(completion);
	}

	public static bool GetPopupSingleMatch(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_popup_single_match(completion);
	}

	public static int GetTextColumn(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_text_column(completion);
	}

	public static GtkEntryCompletionHandle InsertPrefix(this GtkEntryCompletionHandle completion)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_insert_prefix(completion);
		return completion;
	}

	public static GtkEntryCompletionHandle SetInlineCompletion(this GtkEntryCompletionHandle completion, bool inline_completion)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_inline_completion(completion, inline_completion);
		return completion;
	}

	public static GtkEntryCompletionHandle SetInlineSelection(this GtkEntryCompletionHandle completion, bool inline_selection)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_inline_selection(completion, inline_selection);
		return completion;
	}

	public static GtkEntryCompletionHandle SetMatchFunc(this GtkEntryCompletionHandle completion, GtkEntryCompletionMatchFunc func, IntPtr func_data, GDestroyNotify func_notify)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_match_func(completion, func, func_data, func_notify);
		return completion;
	}

	public static GtkEntryCompletionHandle SetMinimumKeyLength(this GtkEntryCompletionHandle completion, int length)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_minimum_key_length(completion, length);
		return completion;
	}

	public static GtkEntryCompletionHandle SetModel(this GtkEntryCompletionHandle completion, GtkTreeModelHandle model)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_model(completion, model);
		return completion;
	}

	public static GtkEntryCompletionHandle SetPopupCompletion(this GtkEntryCompletionHandle completion, bool popup_completion)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_popup_completion(completion, popup_completion);
		return completion;
	}

	public static GtkEntryCompletionHandle SetPopupSetWidth(this GtkEntryCompletionHandle completion, bool popup_set_width)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_popup_set_width(completion, popup_set_width);
		return completion;
	}

	public static GtkEntryCompletionHandle SetPopupSingleMatch(this GtkEntryCompletionHandle completion, bool popup_single_match)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_popup_single_match(completion, popup_single_match);
		return completion;
	}

	public static GtkEntryCompletionHandle SetTextColumn(this GtkEntryCompletionHandle completion, int column)
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_text_column(completion, column);
		return completion;
	}

}

internal class GtkEntryCompletionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEntryCompletionHandle gtk_entry_completion_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEntryCompletionHandle gtk_entry_completion_new_with_area(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_complete(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_entry_completion_compute_prefix(GtkEntryCompletionHandle completion, string key);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_completion_get_completion_prefix(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_entry_completion_get_entry(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_entry_completion_get_inline_completion(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_entry_completion_get_inline_selection(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_entry_completion_get_minimum_key_length(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeModelHandle gtk_entry_completion_get_model(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_entry_completion_get_popup_completion(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_entry_completion_get_popup_set_width(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_entry_completion_get_popup_single_match(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_entry_completion_get_text_column(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_insert_prefix(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_inline_completion(GtkEntryCompletionHandle completion, bool inline_completion);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_inline_selection(GtkEntryCompletionHandle completion, bool inline_selection);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_match_func(GtkEntryCompletionHandle completion, GtkEntryCompletionMatchFunc func, IntPtr func_data, GDestroyNotify func_notify);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_minimum_key_length(GtkEntryCompletionHandle completion, int length);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_model(GtkEntryCompletionHandle completion, GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_popup_completion(GtkEntryCompletionHandle completion, bool popup_completion);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_popup_set_width(GtkEntryCompletionHandle completion, bool popup_set_width);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_popup_single_match(GtkEntryCompletionHandle completion, bool popup_single_match);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_completion_set_text_column(GtkEntryCompletionHandle completion, int column);

}
