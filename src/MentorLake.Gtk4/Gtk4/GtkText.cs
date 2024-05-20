namespace MentorLake.Gtk4.Gtk4;

public class GtkTextHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkAccessibleTextHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkEditableHandle
{
	public static GtkTextHandle New()
	{
		return GtkTextExterns.gtk_text_new();
	}

	public static GtkTextHandle NewWithBuffer(GtkEntryBufferHandle buffer)
	{
		return GtkTextExterns.gtk_text_new_with_buffer(buffer);
	}

}

public static class GtkTextSignalExtensions
{

	public static IObservable<GtkTextSignalStructs.ActivateSignal> Signal_Activate(this GtkTextHandle instance)
	{
		return Observable.Create((IObserver<GtkTextSignalStructs.ActivateSignal> obs) =>
		{
			GtkTextSignalDelegates.activate handler = (GtkTextHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextSignalStructs.ActivateSignal()
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

	public static IObservable<GtkTextSignalStructs.BackspaceSignal> Signal_Backspace(this GtkTextHandle instance)
	{
		return Observable.Create((IObserver<GtkTextSignalStructs.BackspaceSignal> obs) =>
		{
			GtkTextSignalDelegates.backspace handler = (GtkTextHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextSignalStructs.BackspaceSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "backspace", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextSignalStructs.CopyClipboardSignal> Signal_CopyClipboard(this GtkTextHandle instance)
	{
		return Observable.Create((IObserver<GtkTextSignalStructs.CopyClipboardSignal> obs) =>
		{
			GtkTextSignalDelegates.copy_clipboard handler = (GtkTextHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextSignalStructs.CopyClipboardSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "copy_clipboard", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextSignalStructs.CutClipboardSignal> Signal_CutClipboard(this GtkTextHandle instance)
	{
		return Observable.Create((IObserver<GtkTextSignalStructs.CutClipboardSignal> obs) =>
		{
			GtkTextSignalDelegates.cut_clipboard handler = (GtkTextHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextSignalStructs.CutClipboardSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cut_clipboard", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextSignalStructs.DeleteFromCursorSignal> Signal_DeleteFromCursor(this GtkTextHandle instance)
	{
		return Observable.Create((IObserver<GtkTextSignalStructs.DeleteFromCursorSignal> obs) =>
		{
			GtkTextSignalDelegates.delete_from_cursor handler = (GtkTextHandle self, ref GtkDeleteType type, int count, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextSignalStructs.DeleteFromCursorSignal()
				{
					Self = self, Type = type, Count = count, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "delete_from_cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextSignalStructs.InsertAtCursorSignal> Signal_InsertAtCursor(this GtkTextHandle instance)
	{
		return Observable.Create((IObserver<GtkTextSignalStructs.InsertAtCursorSignal> obs) =>
		{
			GtkTextSignalDelegates.insert_at_cursor handler = (GtkTextHandle self, string @string, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextSignalStructs.InsertAtCursorSignal()
				{
					Self = self, String = @string, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "insert_at_cursor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextSignalStructs.InsertEmojiSignal> Signal_InsertEmoji(this GtkTextHandle instance)
	{
		return Observable.Create((IObserver<GtkTextSignalStructs.InsertEmojiSignal> obs) =>
		{
			GtkTextSignalDelegates.insert_emoji handler = (GtkTextHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextSignalStructs.InsertEmojiSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "insert_emoji", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkTextHandle instance)
	{
		return Observable.Create((IObserver<GtkTextSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkTextSignalDelegates.move_cursor handler = (GtkTextHandle self, ref GtkMovementStep step, int count, bool extend, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextSignalStructs.MoveCursorSignal()
				{
					Self = self, Step = step, Count = count, Extend = extend, UserData = user_data
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

	public static IObservable<GtkTextSignalStructs.PasteClipboardSignal> Signal_PasteClipboard(this GtkTextHandle instance)
	{
		return Observable.Create((IObserver<GtkTextSignalStructs.PasteClipboardSignal> obs) =>
		{
			GtkTextSignalDelegates.paste_clipboard handler = (GtkTextHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextSignalStructs.PasteClipboardSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "paste_clipboard", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextSignalStructs.PreeditChangedSignal> Signal_PreeditChanged(this GtkTextHandle instance)
	{
		return Observable.Create((IObserver<GtkTextSignalStructs.PreeditChangedSignal> obs) =>
		{
			GtkTextSignalDelegates.preedit_changed handler = (GtkTextHandle self, string preedit, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextSignalStructs.PreeditChangedSignal()
				{
					Self = self, Preedit = preedit, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "preedit_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextSignalStructs.ToggleOverwriteSignal> Signal_ToggleOverwrite(this GtkTextHandle instance)
	{
		return Observable.Create((IObserver<GtkTextSignalStructs.ToggleOverwriteSignal> obs) =>
		{
			GtkTextSignalDelegates.toggle_overwrite handler = (GtkTextHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextSignalStructs.ToggleOverwriteSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "toggle_overwrite", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkTextSignalStructs
{

public struct ActivateSignal
{
	public GtkTextHandle Self;
	public IntPtr UserData;
}

public struct BackspaceSignal
{
	public GtkTextHandle Self;
	public IntPtr UserData;
}

public struct CopyClipboardSignal
{
	public GtkTextHandle Self;
	public IntPtr UserData;
}

public struct CutClipboardSignal
{
	public GtkTextHandle Self;
	public IntPtr UserData;
}

public struct DeleteFromCursorSignal
{
	public GtkTextHandle Self;
	public GtkDeleteType Type;
	public int Count;
	public IntPtr UserData;
}

public struct InsertAtCursorSignal
{
	public GtkTextHandle Self;
	public string String;
	public IntPtr UserData;
}

public struct InsertEmojiSignal
{
	public GtkTextHandle Self;
	public IntPtr UserData;
}

public struct MoveCursorSignal
{
	public GtkTextHandle Self;
	public GtkMovementStep Step;
	public int Count;
	public bool Extend;
	public IntPtr UserData;
}

public struct PasteClipboardSignal
{
	public GtkTextHandle Self;
	public IntPtr UserData;
}

public struct PreeditChangedSignal
{
	public GtkTextHandle Self;
	public string Preedit;
	public IntPtr UserData;
}

public struct ToggleOverwriteSignal
{
	public GtkTextHandle Self;
	public IntPtr UserData;
}
}

public static class GtkTextSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void backspace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void copy_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void cut_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void delete_from_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, ref GtkDeleteType type, int count, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_at_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, string @string, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void insert_emoji([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, ref GtkMovementStep step, int count, bool extend, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void paste_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void preedit_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, string preedit, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggle_overwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextHandle>))] GtkTextHandle self, IntPtr user_data);

}


public static class GtkTextHandleExtensions
{
	public static GtkTextHandle ComputeCursorExtents(this GtkTextHandle self, UIntPtr position, out graphene_rect_t strong, out graphene_rect_t weak)
	{
		GtkTextExterns.gtk_text_compute_cursor_extents(self, position, out strong, out weak);
		return self;
	}

	public static bool GetActivatesDefault(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_activates_default(self);
	}

	public static PangoAttrListHandle GetAttributes(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_attributes(self);
	}

	public static GtkEntryBufferHandle GetBuffer(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_buffer(self);
	}

	public static bool GetEnableEmojiCompletion(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_enable_emoji_completion(self);
	}

	public static GMenuModelHandle GetExtraMenu(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_extra_menu(self);
	}

	public static GtkInputHints GetInputHints(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_input_hints(self);
	}

	public static GtkInputPurpose GetInputPurpose(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_input_purpose(self);
	}

	public static char GetInvisibleChar(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_invisible_char(self);
	}

	public static int GetMaxLength(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_max_length(self);
	}

	public static bool GetOverwriteMode(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_overwrite_mode(self);
	}

	public static string GetPlaceholderText(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_placeholder_text(self);
	}

	public static bool GetPropagateTextWidth(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_propagate_text_width(self);
	}

	public static PangoTabArrayHandle GetTabs(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_tabs(self);
	}

	public static ushort GetTextLength(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_text_length(self);
	}

	public static bool GetTruncateMultiline(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_truncate_multiline(self);
	}

	public static bool GetVisibility(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_get_visibility(self);
	}

	public static bool GrabFocusWithoutSelecting(this GtkTextHandle self)
	{
		return GtkTextExterns.gtk_text_grab_focus_without_selecting(self);
	}

	public static GtkTextHandle SetActivatesDefault(this GtkTextHandle self, bool activates)
	{
		GtkTextExterns.gtk_text_set_activates_default(self, activates);
		return self;
	}

	public static GtkTextHandle SetAttributes(this GtkTextHandle self, PangoAttrListHandle attrs)
	{
		GtkTextExterns.gtk_text_set_attributes(self, attrs);
		return self;
	}

	public static GtkTextHandle SetBuffer(this GtkTextHandle self, GtkEntryBufferHandle buffer)
	{
		GtkTextExterns.gtk_text_set_buffer(self, buffer);
		return self;
	}

	public static GtkTextHandle SetEnableEmojiCompletion(this GtkTextHandle self, bool enable_emoji_completion)
	{
		GtkTextExterns.gtk_text_set_enable_emoji_completion(self, enable_emoji_completion);
		return self;
	}

	public static GtkTextHandle SetExtraMenu(this GtkTextHandle self, GMenuModelHandle model)
	{
		GtkTextExterns.gtk_text_set_extra_menu(self, model);
		return self;
	}

	public static GtkTextHandle SetInputHints(this GtkTextHandle self, GtkInputHints hints)
	{
		GtkTextExterns.gtk_text_set_input_hints(self, hints);
		return self;
	}

	public static GtkTextHandle SetInputPurpose(this GtkTextHandle self, GtkInputPurpose purpose)
	{
		GtkTextExterns.gtk_text_set_input_purpose(self, purpose);
		return self;
	}

	public static GtkTextHandle SetInvisibleChar(this GtkTextHandle self, char ch)
	{
		GtkTextExterns.gtk_text_set_invisible_char(self, ch);
		return self;
	}

	public static GtkTextHandle SetMaxLength(this GtkTextHandle self, int length)
	{
		GtkTextExterns.gtk_text_set_max_length(self, length);
		return self;
	}

	public static GtkTextHandle SetOverwriteMode(this GtkTextHandle self, bool overwrite)
	{
		GtkTextExterns.gtk_text_set_overwrite_mode(self, overwrite);
		return self;
	}

	public static GtkTextHandle SetPlaceholderText(this GtkTextHandle self, string text)
	{
		GtkTextExterns.gtk_text_set_placeholder_text(self, text);
		return self;
	}

	public static GtkTextHandle SetPropagateTextWidth(this GtkTextHandle self, bool propagate_text_width)
	{
		GtkTextExterns.gtk_text_set_propagate_text_width(self, propagate_text_width);
		return self;
	}

	public static GtkTextHandle SetTabs(this GtkTextHandle self, PangoTabArrayHandle tabs)
	{
		GtkTextExterns.gtk_text_set_tabs(self, tabs);
		return self;
	}

	public static GtkTextHandle SetTruncateMultiline(this GtkTextHandle self, bool truncate_multiline)
	{
		GtkTextExterns.gtk_text_set_truncate_multiline(self, truncate_multiline);
		return self;
	}

	public static GtkTextHandle SetVisibility(this GtkTextHandle self, bool visible)
	{
		GtkTextExterns.gtk_text_set_visibility(self, visible);
		return self;
	}

	public static GtkTextHandle UnsetInvisibleChar(this GtkTextHandle self)
	{
		GtkTextExterns.gtk_text_unset_invisible_char(self);
		return self;
	}

}

internal class GtkTextExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextHandle gtk_text_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextHandle gtk_text_new_with_buffer(GtkEntryBufferHandle buffer);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_compute_cursor_extents(GtkTextHandle self, UIntPtr position, out graphene_rect_t strong, out graphene_rect_t weak);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_get_activates_default(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoAttrListHandle gtk_text_get_attributes(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEntryBufferHandle gtk_text_get_buffer(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_get_enable_emoji_completion(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GMenuModelHandle gtk_text_get_extra_menu(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInputHints gtk_text_get_input_hints(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInputPurpose gtk_text_get_input_purpose(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern char gtk_text_get_invisible_char(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_get_max_length(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_get_overwrite_mode(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_text_get_placeholder_text(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_get_propagate_text_width(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoTabArrayHandle gtk_text_get_tabs(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern ushort gtk_text_get_text_length(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_get_truncate_multiline(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_get_visibility(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_grab_focus_without_selecting(GtkTextHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_activates_default(GtkTextHandle self, bool activates);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_attributes(GtkTextHandle self, PangoAttrListHandle attrs);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_buffer(GtkTextHandle self, GtkEntryBufferHandle buffer);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_enable_emoji_completion(GtkTextHandle self, bool enable_emoji_completion);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_extra_menu(GtkTextHandle self, GMenuModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_input_hints(GtkTextHandle self, GtkInputHints hints);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_input_purpose(GtkTextHandle self, GtkInputPurpose purpose);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_invisible_char(GtkTextHandle self, char ch);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_max_length(GtkTextHandle self, int length);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_overwrite_mode(GtkTextHandle self, bool overwrite);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_placeholder_text(GtkTextHandle self, string text);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_propagate_text_width(GtkTextHandle self, bool propagate_text_width);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_tabs(GtkTextHandle self, PangoTabArrayHandle tabs);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_truncate_multiline(GtkTextHandle self, bool truncate_multiline);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_set_visibility(GtkTextHandle self, bool visible);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_unset_invisible_char(GtkTextHandle self);

}
