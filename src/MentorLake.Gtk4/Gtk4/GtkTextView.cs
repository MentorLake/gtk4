namespace MentorLake.Gtk4.Gtk4;

public class GtkTextViewHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkAccessibleTextHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkScrollableHandle
{
	public static GtkTextViewHandle New()
	{
		return GtkTextViewExterns.gtk_text_view_new();
	}

	public static GtkTextViewHandle NewWithBuffer(GtkTextBufferHandle buffer)
	{
		return GtkTextViewExterns.gtk_text_view_new_with_buffer(buffer);
	}

}

public static class GtkTextViewSignalExtensions
{

	public static IObservable<GtkTextViewSignalStructs.BackspaceSignal> Signal_Backspace(this GtkTextViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTextViewSignalStructs.BackspaceSignal> obs) =>
		{
			GtkTextViewSignalDelegates.Backspace handler = (GtkTextViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewSignalStructs.BackspaceSignal()
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

	public static IObservable<GtkTextViewSignalStructs.CopyClipboardSignal> Signal_CopyClipboard(this GtkTextViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTextViewSignalStructs.CopyClipboardSignal> obs) =>
		{
			GtkTextViewSignalDelegates.CopyClipboard handler = (GtkTextViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewSignalStructs.CopyClipboardSignal()
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

	public static IObservable<GtkTextViewSignalStructs.CutClipboardSignal> Signal_CutClipboard(this GtkTextViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTextViewSignalStructs.CutClipboardSignal> obs) =>
		{
			GtkTextViewSignalDelegates.CutClipboard handler = (GtkTextViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewSignalStructs.CutClipboardSignal()
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

	public static IObservable<GtkTextViewSignalStructs.DeleteFromCursorSignal> Signal_DeleteFromCursor(this GtkTextViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTextViewSignalStructs.DeleteFromCursorSignal> obs) =>
		{
			GtkTextViewSignalDelegates.DeleteFromCursor handler = (GtkTextViewHandle self, ref GtkDeleteType type, int count, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewSignalStructs.DeleteFromCursorSignal()
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

	public static IObservable<GtkTextViewSignalStructs.ExtendSelectionSignal> Signal_ExtendSelection(this GtkTextViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTextViewSignalStructs.ExtendSelectionSignal> obs) =>
		{
			GtkTextViewSignalDelegates.ExtendSelection handler = (GtkTextViewHandle self, GtkTextExtendSelection granularity, GtkTextIterHandle location, GtkTextIterHandle start, GtkTextIterHandle end, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewSignalStructs.ExtendSelectionSignal()
				{
					Self = self, Granularity = granularity, Location = location, Start = start, End = end, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "extend_selection", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextViewSignalStructs.InsertAtCursorSignal> Signal_InsertAtCursor(this GtkTextViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTextViewSignalStructs.InsertAtCursorSignal> obs) =>
		{
			GtkTextViewSignalDelegates.InsertAtCursor handler = (GtkTextViewHandle self, string @string, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewSignalStructs.InsertAtCursorSignal()
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

	public static IObservable<GtkTextViewSignalStructs.InsertEmojiSignal> Signal_InsertEmoji(this GtkTextViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTextViewSignalStructs.InsertEmojiSignal> obs) =>
		{
			GtkTextViewSignalDelegates.InsertEmoji handler = (GtkTextViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewSignalStructs.InsertEmojiSignal()
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

	public static IObservable<GtkTextViewSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkTextViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTextViewSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkTextViewSignalDelegates.MoveCursor handler = (GtkTextViewHandle self, ref GtkMovementStep step, int count, bool extend_selection, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewSignalStructs.MoveCursorSignal()
				{
					Self = self, Step = step, Count = count, ExtendSelection = extend_selection, UserData = user_data
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

	public static IObservable<GtkTextViewSignalStructs.MoveViewportSignal> Signal_MoveViewport(this GtkTextViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTextViewSignalStructs.MoveViewportSignal> obs) =>
		{
			GtkTextViewSignalDelegates.MoveViewport handler = (GtkTextViewHandle self, ref GtkScrollStep step, int count, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewSignalStructs.MoveViewportSignal()
				{
					Self = self, Step = step, Count = count, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_viewport", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextViewSignalStructs.PasteClipboardSignal> Signal_PasteClipboard(this GtkTextViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTextViewSignalStructs.PasteClipboardSignal> obs) =>
		{
			GtkTextViewSignalDelegates.PasteClipboard handler = (GtkTextViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewSignalStructs.PasteClipboardSignal()
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

	public static IObservable<GtkTextViewSignalStructs.PreeditChangedSignal> Signal_PreeditChanged(this GtkTextViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTextViewSignalStructs.PreeditChangedSignal> obs) =>
		{
			GtkTextViewSignalDelegates.PreeditChanged handler = (GtkTextViewHandle self, string preedit, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewSignalStructs.PreeditChangedSignal()
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

	public static IObservable<GtkTextViewSignalStructs.SelectAllSignal> Signal_SelectAll(this GtkTextViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTextViewSignalStructs.SelectAllSignal> obs) =>
		{
			GtkTextViewSignalDelegates.SelectAll handler = (GtkTextViewHandle self, bool select, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewSignalStructs.SelectAllSignal()
				{
					Self = self, Select = select, UserData = user_data
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

	public static IObservable<GtkTextViewSignalStructs.SetAnchorSignal> Signal_SetAnchor(this GtkTextViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTextViewSignalStructs.SetAnchorSignal> obs) =>
		{
			GtkTextViewSignalDelegates.SetAnchor handler = (GtkTextViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewSignalStructs.SetAnchorSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "set_anchor", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextViewSignalStructs.ToggleCursorVisibleSignal> Signal_ToggleCursorVisible(this GtkTextViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTextViewSignalStructs.ToggleCursorVisibleSignal> obs) =>
		{
			GtkTextViewSignalDelegates.ToggleCursorVisible handler = (GtkTextViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewSignalStructs.ToggleCursorVisibleSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "toggle_cursor_visible", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkTextViewSignalStructs.ToggleOverwriteSignal> Signal_ToggleOverwrite(this GtkTextViewHandle instance)
	{
		return Observable.Create((IObserver<GtkTextViewSignalStructs.ToggleOverwriteSignal> obs) =>
		{
			GtkTextViewSignalDelegates.ToggleOverwrite handler = (GtkTextViewHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTextViewSignalStructs.ToggleOverwriteSignal()
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

public static class GtkTextViewSignalStructs
{

public struct BackspaceSignal
{
	public GtkTextViewHandle Self;
	public IntPtr UserData;
}

public struct CopyClipboardSignal
{
	public GtkTextViewHandle Self;
	public IntPtr UserData;
}

public struct CutClipboardSignal
{
	public GtkTextViewHandle Self;
	public IntPtr UserData;
}

public struct DeleteFromCursorSignal
{
	public GtkTextViewHandle Self;
	public GtkDeleteType Type;
	public int Count;
	public IntPtr UserData;
}

public struct ExtendSelectionSignal
{
	public GtkTextViewHandle Self;
	public GtkTextExtendSelection Granularity;
	public GtkTextIterHandle Location;
	public GtkTextIterHandle Start;
	public GtkTextIterHandle End;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct InsertAtCursorSignal
{
	public GtkTextViewHandle Self;
	public string String;
	public IntPtr UserData;
}

public struct InsertEmojiSignal
{
	public GtkTextViewHandle Self;
	public IntPtr UserData;
}

public struct MoveCursorSignal
{
	public GtkTextViewHandle Self;
	public GtkMovementStep Step;
	public int Count;
	public bool ExtendSelection;
	public IntPtr UserData;
}

public struct MoveViewportSignal
{
	public GtkTextViewHandle Self;
	public GtkScrollStep Step;
	public int Count;
	public IntPtr UserData;
}

public struct PasteClipboardSignal
{
	public GtkTextViewHandle Self;
	public IntPtr UserData;
}

public struct PreeditChangedSignal
{
	public GtkTextViewHandle Self;
	public string Preedit;
	public IntPtr UserData;
}

public struct SelectAllSignal
{
	public GtkTextViewHandle Self;
	public bool Select;
	public IntPtr UserData;
}

public struct SetAnchorSignal
{
	public GtkTextViewHandle Self;
	public IntPtr UserData;
}

public struct ToggleCursorVisibleSignal
{
	public GtkTextViewHandle Self;
	public IntPtr UserData;
}

public struct ToggleOverwriteSignal
{
	public GtkTextViewHandle Self;
	public IntPtr UserData;
}
}

public static class GtkTextViewSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Backspace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextViewHandle>))] GtkTextViewHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void CopyClipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextViewHandle>))] GtkTextViewHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void CutClipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextViewHandle>))] GtkTextViewHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DeleteFromCursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextViewHandle>))] GtkTextViewHandle self, ref GtkDeleteType type, int count, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool ExtendSelection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextViewHandle>))] GtkTextViewHandle self, GtkTextExtendSelection granularity, GtkTextIterHandle location, GtkTextIterHandle start, GtkTextIterHandle end, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void InsertAtCursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextViewHandle>))] GtkTextViewHandle self, string @string, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void InsertEmoji([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextViewHandle>))] GtkTextViewHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MoveCursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextViewHandle>))] GtkTextViewHandle self, ref GtkMovementStep step, int count, bool extend_selection, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MoveViewport([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextViewHandle>))] GtkTextViewHandle self, ref GtkScrollStep step, int count, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void PasteClipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextViewHandle>))] GtkTextViewHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void PreeditChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextViewHandle>))] GtkTextViewHandle self, string preedit, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void SelectAll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextViewHandle>))] GtkTextViewHandle self, bool select, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void SetAnchor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextViewHandle>))] GtkTextViewHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ToggleCursorVisible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextViewHandle>))] GtkTextViewHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ToggleOverwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTextViewHandle>))] GtkTextViewHandle self, IntPtr user_data);
}


public static class GtkTextViewHandleExtensions
{
	public static GtkTextViewHandle AddChildAtAnchor(this GtkTextViewHandle text_view, GtkWidgetHandle child, GtkTextChildAnchorHandle anchor)
	{
		GtkTextViewExterns.gtk_text_view_add_child_at_anchor(text_view, child, anchor);
		return text_view;
	}

	public static GtkTextViewHandle AddOverlay(this GtkTextViewHandle text_view, GtkWidgetHandle child, int xpos, int ypos)
	{
		GtkTextViewExterns.gtk_text_view_add_overlay(text_view, child, xpos, ypos);
		return text_view;
	}

	public static bool BackwardDisplayLine(this GtkTextViewHandle text_view, GtkTextIterHandle iter)
	{
		return GtkTextViewExterns.gtk_text_view_backward_display_line(text_view, iter);
	}

	public static bool BackwardDisplayLineStart(this GtkTextViewHandle text_view, GtkTextIterHandle iter)
	{
		return GtkTextViewExterns.gtk_text_view_backward_display_line_start(text_view, iter);
	}

	public static GtkTextViewHandle BufferToWindowCoords(this GtkTextViewHandle text_view, GtkTextWindowType win, int buffer_x, int buffer_y, out int window_x, out int window_y)
	{
		GtkTextViewExterns.gtk_text_view_buffer_to_window_coords(text_view, win, buffer_x, buffer_y, out window_x, out window_y);
		return text_view;
	}

	public static bool ForwardDisplayLine(this GtkTextViewHandle text_view, GtkTextIterHandle iter)
	{
		return GtkTextViewExterns.gtk_text_view_forward_display_line(text_view, iter);
	}

	public static bool ForwardDisplayLineEnd(this GtkTextViewHandle text_view, GtkTextIterHandle iter)
	{
		return GtkTextViewExterns.gtk_text_view_forward_display_line_end(text_view, iter);
	}

	public static bool GetAcceptsTab(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_accepts_tab(text_view);
	}

	public static int GetBottomMargin(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_bottom_margin(text_view);
	}

	public static GtkTextBufferHandle GetBuffer(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_buffer(text_view);
	}

	public static GtkTextViewHandle GetCursorLocations(this GtkTextViewHandle text_view, GtkTextIterHandle iter, out GdkRectangle strong, out GdkRectangle weak)
	{
		GtkTextViewExterns.gtk_text_view_get_cursor_locations(text_view, iter, out strong, out weak);
		return text_view;
	}

	public static bool GetCursorVisible(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_cursor_visible(text_view);
	}

	public static bool GetEditable(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_editable(text_view);
	}

	public static GMenuModelHandle GetExtraMenu(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_extra_menu(text_view);
	}

	public static GtkWidgetHandle GetGutter(this GtkTextViewHandle text_view, GtkTextWindowType win)
	{
		return GtkTextViewExterns.gtk_text_view_get_gutter(text_view, win);
	}

	public static int GetIndent(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_indent(text_view);
	}

	public static GtkInputHints GetInputHints(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_input_hints(text_view);
	}

	public static GtkInputPurpose GetInputPurpose(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_input_purpose(text_view);
	}

	public static bool GetIterAtLocation(this GtkTextViewHandle text_view, out GtkTextIter iter, int x, int y)
	{
		return GtkTextViewExterns.gtk_text_view_get_iter_at_location(text_view, out iter, x, y);
	}

	public static bool GetIterAtPosition(this GtkTextViewHandle text_view, out GtkTextIter iter, out int trailing, int x, int y)
	{
		return GtkTextViewExterns.gtk_text_view_get_iter_at_position(text_view, out iter, out trailing, x, y);
	}

	public static GtkTextViewHandle GetIterLocation(this GtkTextViewHandle text_view, GtkTextIterHandle iter, out GdkRectangle location)
	{
		GtkTextViewExterns.gtk_text_view_get_iter_location(text_view, iter, out location);
		return text_view;
	}

	public static GtkJustification GetJustification(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_justification(text_view);
	}

	public static int GetLeftMargin(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_left_margin(text_view);
	}

	public static GtkTextViewHandle GetLineAtY(this GtkTextViewHandle text_view, out GtkTextIter target_iter, int y, out int line_top)
	{
		GtkTextViewExterns.gtk_text_view_get_line_at_y(text_view, out target_iter, y, out line_top);
		return text_view;
	}

	public static GtkTextViewHandle GetLineYrange(this GtkTextViewHandle text_view, GtkTextIterHandle iter, out int y, out int height)
	{
		GtkTextViewExterns.gtk_text_view_get_line_yrange(text_view, iter, out y, out height);
		return text_view;
	}

	public static PangoContextHandle GetLtrContext(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_ltr_context(text_view);
	}

	public static bool GetMonospace(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_monospace(text_view);
	}

	public static bool GetOverwrite(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_overwrite(text_view);
	}

	public static int GetPixelsAboveLines(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_pixels_above_lines(text_view);
	}

	public static int GetPixelsBelowLines(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_pixels_below_lines(text_view);
	}

	public static int GetPixelsInsideWrap(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_pixels_inside_wrap(text_view);
	}

	public static int GetRightMargin(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_right_margin(text_view);
	}

	public static PangoContextHandle GetRtlContext(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_rtl_context(text_view);
	}

	public static PangoTabArrayHandle GetTabs(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_tabs(text_view);
	}

	public static int GetTopMargin(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_top_margin(text_view);
	}

	public static GtkTextViewHandle GetVisibleRect(this GtkTextViewHandle text_view, out GdkRectangle visible_rect)
	{
		GtkTextViewExterns.gtk_text_view_get_visible_rect(text_view, out visible_rect);
		return text_view;
	}

	public static GtkWrapMode GetWrapMode(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_get_wrap_mode(text_view);
	}

	public static bool ImContextFilterKeypress(this GtkTextViewHandle text_view, GdkEventHandle @event)
	{
		return GtkTextViewExterns.gtk_text_view_im_context_filter_keypress(text_view, @event);
	}

	public static bool MoveMarkOnscreen(this GtkTextViewHandle text_view, GtkTextMarkHandle mark)
	{
		return GtkTextViewExterns.gtk_text_view_move_mark_onscreen(text_view, mark);
	}

	public static GtkTextViewHandle MoveOverlay(this GtkTextViewHandle text_view, GtkWidgetHandle child, int xpos, int ypos)
	{
		GtkTextViewExterns.gtk_text_view_move_overlay(text_view, child, xpos, ypos);
		return text_view;
	}

	public static bool MoveVisually(this GtkTextViewHandle text_view, GtkTextIterHandle iter, int count)
	{
		return GtkTextViewExterns.gtk_text_view_move_visually(text_view, iter, count);
	}

	public static bool PlaceCursorOnscreen(this GtkTextViewHandle text_view)
	{
		return GtkTextViewExterns.gtk_text_view_place_cursor_onscreen(text_view);
	}

	public static GtkTextViewHandle Remove(this GtkTextViewHandle text_view, GtkWidgetHandle child)
	{
		GtkTextViewExterns.gtk_text_view_remove(text_view, child);
		return text_view;
	}

	public static GtkTextViewHandle ResetCursorBlink(this GtkTextViewHandle text_view)
	{
		GtkTextViewExterns.gtk_text_view_reset_cursor_blink(text_view);
		return text_view;
	}

	public static GtkTextViewHandle ResetImContext(this GtkTextViewHandle text_view)
	{
		GtkTextViewExterns.gtk_text_view_reset_im_context(text_view);
		return text_view;
	}

	public static GtkTextViewHandle ScrollMarkOnscreen(this GtkTextViewHandle text_view, GtkTextMarkHandle mark)
	{
		GtkTextViewExterns.gtk_text_view_scroll_mark_onscreen(text_view, mark);
		return text_view;
	}

	public static bool ScrollToIter(this GtkTextViewHandle text_view, GtkTextIterHandle iter, double within_margin, bool use_align, double xalign, double yalign)
	{
		return GtkTextViewExterns.gtk_text_view_scroll_to_iter(text_view, iter, within_margin, use_align, xalign, yalign);
	}

	public static GtkTextViewHandle ScrollToMark(this GtkTextViewHandle text_view, GtkTextMarkHandle mark, double within_margin, bool use_align, double xalign, double yalign)
	{
		GtkTextViewExterns.gtk_text_view_scroll_to_mark(text_view, mark, within_margin, use_align, xalign, yalign);
		return text_view;
	}

	public static GtkTextViewHandle SetAcceptsTab(this GtkTextViewHandle text_view, bool accepts_tab)
	{
		GtkTextViewExterns.gtk_text_view_set_accepts_tab(text_view, accepts_tab);
		return text_view;
	}

	public static GtkTextViewHandle SetBottomMargin(this GtkTextViewHandle text_view, int bottom_margin)
	{
		GtkTextViewExterns.gtk_text_view_set_bottom_margin(text_view, bottom_margin);
		return text_view;
	}

	public static GtkTextViewHandle SetBuffer(this GtkTextViewHandle text_view, GtkTextBufferHandle buffer)
	{
		GtkTextViewExterns.gtk_text_view_set_buffer(text_view, buffer);
		return text_view;
	}

	public static GtkTextViewHandle SetCursorVisible(this GtkTextViewHandle text_view, bool setting)
	{
		GtkTextViewExterns.gtk_text_view_set_cursor_visible(text_view, setting);
		return text_view;
	}

	public static GtkTextViewHandle SetEditable(this GtkTextViewHandle text_view, bool setting)
	{
		GtkTextViewExterns.gtk_text_view_set_editable(text_view, setting);
		return text_view;
	}

	public static GtkTextViewHandle SetExtraMenu(this GtkTextViewHandle text_view, GMenuModelHandle model)
	{
		GtkTextViewExterns.gtk_text_view_set_extra_menu(text_view, model);
		return text_view;
	}

	public static GtkTextViewHandle SetGutter(this GtkTextViewHandle text_view, GtkTextWindowType win, GtkWidgetHandle widget)
	{
		GtkTextViewExterns.gtk_text_view_set_gutter(text_view, win, widget);
		return text_view;
	}

	public static GtkTextViewHandle SetIndent(this GtkTextViewHandle text_view, int indent)
	{
		GtkTextViewExterns.gtk_text_view_set_indent(text_view, indent);
		return text_view;
	}

	public static GtkTextViewHandle SetInputHints(this GtkTextViewHandle text_view, GtkInputHints hints)
	{
		GtkTextViewExterns.gtk_text_view_set_input_hints(text_view, hints);
		return text_view;
	}

	public static GtkTextViewHandle SetInputPurpose(this GtkTextViewHandle text_view, GtkInputPurpose purpose)
	{
		GtkTextViewExterns.gtk_text_view_set_input_purpose(text_view, purpose);
		return text_view;
	}

	public static GtkTextViewHandle SetJustification(this GtkTextViewHandle text_view, GtkJustification justification)
	{
		GtkTextViewExterns.gtk_text_view_set_justification(text_view, justification);
		return text_view;
	}

	public static GtkTextViewHandle SetLeftMargin(this GtkTextViewHandle text_view, int left_margin)
	{
		GtkTextViewExterns.gtk_text_view_set_left_margin(text_view, left_margin);
		return text_view;
	}

	public static GtkTextViewHandle SetMonospace(this GtkTextViewHandle text_view, bool monospace)
	{
		GtkTextViewExterns.gtk_text_view_set_monospace(text_view, monospace);
		return text_view;
	}

	public static GtkTextViewHandle SetOverwrite(this GtkTextViewHandle text_view, bool overwrite)
	{
		GtkTextViewExterns.gtk_text_view_set_overwrite(text_view, overwrite);
		return text_view;
	}

	public static GtkTextViewHandle SetPixelsAboveLines(this GtkTextViewHandle text_view, int pixels_above_lines)
	{
		GtkTextViewExterns.gtk_text_view_set_pixels_above_lines(text_view, pixels_above_lines);
		return text_view;
	}

	public static GtkTextViewHandle SetPixelsBelowLines(this GtkTextViewHandle text_view, int pixels_below_lines)
	{
		GtkTextViewExterns.gtk_text_view_set_pixels_below_lines(text_view, pixels_below_lines);
		return text_view;
	}

	public static GtkTextViewHandle SetPixelsInsideWrap(this GtkTextViewHandle text_view, int pixels_inside_wrap)
	{
		GtkTextViewExterns.gtk_text_view_set_pixels_inside_wrap(text_view, pixels_inside_wrap);
		return text_view;
	}

	public static GtkTextViewHandle SetRightMargin(this GtkTextViewHandle text_view, int right_margin)
	{
		GtkTextViewExterns.gtk_text_view_set_right_margin(text_view, right_margin);
		return text_view;
	}

	public static GtkTextViewHandle SetTabs(this GtkTextViewHandle text_view, PangoTabArrayHandle tabs)
	{
		GtkTextViewExterns.gtk_text_view_set_tabs(text_view, tabs);
		return text_view;
	}

	public static GtkTextViewHandle SetTopMargin(this GtkTextViewHandle text_view, int top_margin)
	{
		GtkTextViewExterns.gtk_text_view_set_top_margin(text_view, top_margin);
		return text_view;
	}

	public static GtkTextViewHandle SetWrapMode(this GtkTextViewHandle text_view, GtkWrapMode wrap_mode)
	{
		GtkTextViewExterns.gtk_text_view_set_wrap_mode(text_view, wrap_mode);
		return text_view;
	}

	public static bool StartsDisplayLine(this GtkTextViewHandle text_view, GtkTextIterHandle iter)
	{
		return GtkTextViewExterns.gtk_text_view_starts_display_line(text_view, iter);
	}

	public static GtkTextViewHandle WindowToBufferCoords(this GtkTextViewHandle text_view, GtkTextWindowType win, int window_x, int window_y, out int buffer_x, out int buffer_y)
	{
		GtkTextViewExterns.gtk_text_view_window_to_buffer_coords(text_view, win, window_x, window_y, out buffer_x, out buffer_y);
		return text_view;
	}

}

internal class GtkTextViewExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextViewHandle gtk_text_view_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextViewHandle gtk_text_view_new_with_buffer(GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_add_child_at_anchor(GtkTextViewHandle text_view, GtkWidgetHandle child, GtkTextChildAnchorHandle anchor);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_add_overlay(GtkTextViewHandle text_view, GtkWidgetHandle child, int xpos, int ypos);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_view_backward_display_line(GtkTextViewHandle text_view, GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_view_backward_display_line_start(GtkTextViewHandle text_view, GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_buffer_to_window_coords(GtkTextViewHandle text_view, GtkTextWindowType win, int buffer_x, int buffer_y, out int window_x, out int window_y);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_view_forward_display_line(GtkTextViewHandle text_view, GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_view_forward_display_line_end(GtkTextViewHandle text_view, GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_view_get_accepts_tab(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_view_get_bottom_margin(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTextBufferHandle gtk_text_view_get_buffer(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_get_cursor_locations(GtkTextViewHandle text_view, GtkTextIterHandle iter, out GdkRectangle strong, out GdkRectangle weak);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_view_get_cursor_visible(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_view_get_editable(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern GMenuModelHandle gtk_text_view_get_extra_menu(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_text_view_get_gutter(GtkTextViewHandle text_view, GtkTextWindowType win);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_view_get_indent(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInputHints gtk_text_view_get_input_hints(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInputPurpose gtk_text_view_get_input_purpose(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_view_get_iter_at_location(GtkTextViewHandle text_view, out GtkTextIter iter, int x, int y);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_view_get_iter_at_position(GtkTextViewHandle text_view, out GtkTextIter iter, out int trailing, int x, int y);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_get_iter_location(GtkTextViewHandle text_view, GtkTextIterHandle iter, out GdkRectangle location);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkJustification gtk_text_view_get_justification(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_view_get_left_margin(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_get_line_at_y(GtkTextViewHandle text_view, out GtkTextIter target_iter, int y, out int line_top);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_get_line_yrange(GtkTextViewHandle text_view, GtkTextIterHandle iter, out int y, out int height);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoContextHandle gtk_text_view_get_ltr_context(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_view_get_monospace(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_view_get_overwrite(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_view_get_pixels_above_lines(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_view_get_pixels_below_lines(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_view_get_pixels_inside_wrap(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_view_get_right_margin(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoContextHandle gtk_text_view_get_rtl_context(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoTabArrayHandle gtk_text_view_get_tabs(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_text_view_get_top_margin(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_get_visible_rect(GtkTextViewHandle text_view, out GdkRectangle visible_rect);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWrapMode gtk_text_view_get_wrap_mode(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_view_im_context_filter_keypress(GtkTextViewHandle text_view, GdkEventHandle @event);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_view_move_mark_onscreen(GtkTextViewHandle text_view, GtkTextMarkHandle mark);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_move_overlay(GtkTextViewHandle text_view, GtkWidgetHandle child, int xpos, int ypos);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_view_move_visually(GtkTextViewHandle text_view, GtkTextIterHandle iter, int count);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_view_place_cursor_onscreen(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_remove(GtkTextViewHandle text_view, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_reset_cursor_blink(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_reset_im_context(GtkTextViewHandle text_view);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_scroll_mark_onscreen(GtkTextViewHandle text_view, GtkTextMarkHandle mark);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_view_scroll_to_iter(GtkTextViewHandle text_view, GtkTextIterHandle iter, double within_margin, bool use_align, double xalign, double yalign);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_scroll_to_mark(GtkTextViewHandle text_view, GtkTextMarkHandle mark, double within_margin, bool use_align, double xalign, double yalign);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_accepts_tab(GtkTextViewHandle text_view, bool accepts_tab);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_bottom_margin(GtkTextViewHandle text_view, int bottom_margin);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_buffer(GtkTextViewHandle text_view, GtkTextBufferHandle buffer);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_cursor_visible(GtkTextViewHandle text_view, bool setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_editable(GtkTextViewHandle text_view, bool setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_extra_menu(GtkTextViewHandle text_view, GMenuModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_gutter(GtkTextViewHandle text_view, GtkTextWindowType win, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_indent(GtkTextViewHandle text_view, int indent);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_input_hints(GtkTextViewHandle text_view, GtkInputHints hints);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_input_purpose(GtkTextViewHandle text_view, GtkInputPurpose purpose);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_justification(GtkTextViewHandle text_view, GtkJustification justification);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_left_margin(GtkTextViewHandle text_view, int left_margin);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_monospace(GtkTextViewHandle text_view, bool monospace);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_overwrite(GtkTextViewHandle text_view, bool overwrite);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_pixels_above_lines(GtkTextViewHandle text_view, int pixels_above_lines);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_pixels_below_lines(GtkTextViewHandle text_view, int pixels_below_lines);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_pixels_inside_wrap(GtkTextViewHandle text_view, int pixels_inside_wrap);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_right_margin(GtkTextViewHandle text_view, int right_margin);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_tabs(GtkTextViewHandle text_view, PangoTabArrayHandle tabs);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_top_margin(GtkTextViewHandle text_view, int top_margin);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_set_wrap_mode(GtkTextViewHandle text_view, GtkWrapMode wrap_mode);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_text_view_starts_display_line(GtkTextViewHandle text_view, GtkTextIterHandle iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_text_view_window_to_buffer_coords(GtkTextViewHandle text_view, GtkTextWindowType win, int window_x, int window_y, out int buffer_x, out int buffer_y);

}
