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

public class GtkLabelHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkAccessibleTextHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkLabelHandle New(string str)
	{
		return GtkLabelExterns.gtk_label_new(str);
	}

	public static GtkLabelHandle NewWithMnemonic(string str)
	{
		return GtkLabelExterns.gtk_label_new_with_mnemonic(str);
	}

}

public static class GtkLabelSignalExtensions
{

	public static IObservable<GtkLabelSignalStructs.ActivateCurrentLinkSignal> Signal_ActivateCurrentLink(this GtkLabelHandle instance)
	{
		return Observable.Create((IObserver<GtkLabelSignalStructs.ActivateCurrentLinkSignal> obs) =>
		{
			GtkLabelSignalDelegates.ActivateCurrentLink handler = (GtkLabelHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelSignalStructs.ActivateCurrentLinkSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate_current_link", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkLabelSignalStructs.ActivateLinkSignal> Signal_ActivateLink(this GtkLabelHandle instance)
	{
		return Observable.Create((IObserver<GtkLabelSignalStructs.ActivateLinkSignal> obs) =>
		{
			GtkLabelSignalDelegates.ActivateLink handler = (GtkLabelHandle self, string uri, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelSignalStructs.ActivateLinkSignal()
				{
					Self = self, Uri = uri, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "activate_link", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkLabelSignalStructs.CopyClipboardSignal> Signal_CopyClipboard(this GtkLabelHandle instance)
	{
		return Observable.Create((IObserver<GtkLabelSignalStructs.CopyClipboardSignal> obs) =>
		{
			GtkLabelSignalDelegates.CopyClipboard handler = (GtkLabelHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelSignalStructs.CopyClipboardSignal()
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

	public static IObservable<GtkLabelSignalStructs.MoveCursorSignal> Signal_MoveCursor(this GtkLabelHandle instance)
	{
		return Observable.Create((IObserver<GtkLabelSignalStructs.MoveCursorSignal> obs) =>
		{
			GtkLabelSignalDelegates.MoveCursor handler = (GtkLabelHandle self, ref GtkMovementStep step, int count, bool extend_selection, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLabelSignalStructs.MoveCursorSignal()
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
}

public static class GtkLabelSignalStructs
{

public struct ActivateCurrentLinkSignal
{
	public GtkLabelHandle Self;
	public IntPtr UserData;
}

public struct ActivateLinkSignal
{
	public GtkLabelHandle Self;
	public string Uri;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct CopyClipboardSignal
{
	public GtkLabelHandle Self;
	public IntPtr UserData;
}

public struct MoveCursorSignal
{
	public GtkLabelHandle Self;
	public GtkMovementStep Step;
	public int Count;
	public bool ExtendSelection;
	public IntPtr UserData;
}
}

public static class GtkLabelSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ActivateCurrentLink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkLabelHandle>))] GtkLabelHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool ActivateLink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkLabelHandle>))] GtkLabelHandle self, string uri, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void CopyClipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkLabelHandle>))] GtkLabelHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MoveCursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkLabelHandle>))] GtkLabelHandle self, ref GtkMovementStep step, int count, bool extend_selection, IntPtr user_data);
}


public static class GtkLabelHandleExtensions
{
	public static PangoAttrListHandle GetAttributes(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_attributes(self);
	}

	public static string GetCurrentUri(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_current_uri(self);
	}

	public static PangoEllipsizeMode GetEllipsize(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_ellipsize(self);
	}

	public static GMenuModelHandle GetExtraMenu(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_extra_menu(self);
	}

	public static GtkJustification GetJustify(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_justify(self);
	}

	public static string GetLabel(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_label(self);
	}

	public static PangoLayoutHandle GetLayout(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_layout(self);
	}

	public static GtkLabelHandle GetLayoutOffsets(this GtkLabelHandle self, out int x, out int y)
	{
		GtkLabelExterns.gtk_label_get_layout_offsets(self, out x, out y);
		return self;
	}

	public static int GetLines(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_lines(self);
	}

	public static int GetMaxWidthChars(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_max_width_chars(self);
	}

	public static uint GetMnemonicKeyval(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_mnemonic_keyval(self);
	}

	public static GtkWidgetHandle GetMnemonicWidget(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_mnemonic_widget(self);
	}

	public static GtkNaturalWrapMode GetNaturalWrapMode(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_natural_wrap_mode(self);
	}

	public static bool GetSelectable(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_selectable(self);
	}

	public static bool GetSelectionBounds(this GtkLabelHandle self, out int start, out int end)
	{
		return GtkLabelExterns.gtk_label_get_selection_bounds(self, out start, out end);
	}

	public static bool GetSingleLineMode(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_single_line_mode(self);
	}

	public static PangoTabArrayHandle GetTabs(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_tabs(self);
	}

	public static string GetText(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_text(self);
	}

	public static bool GetUseMarkup(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_use_markup(self);
	}

	public static bool GetUseUnderline(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_use_underline(self);
	}

	public static int GetWidthChars(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_width_chars(self);
	}

	public static bool GetWrap(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_wrap(self);
	}

	public static PangoWrapMode GetWrapMode(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_wrap_mode(self);
	}

	public static float GetXalign(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_xalign(self);
	}

	public static float GetYalign(this GtkLabelHandle self)
	{
		return GtkLabelExterns.gtk_label_get_yalign(self);
	}

	public static GtkLabelHandle SelectRegion(this GtkLabelHandle self, int start_offset, int end_offset)
	{
		GtkLabelExterns.gtk_label_select_region(self, start_offset, end_offset);
		return self;
	}

	public static GtkLabelHandle SetAttributes(this GtkLabelHandle self, PangoAttrListHandle attrs)
	{
		GtkLabelExterns.gtk_label_set_attributes(self, attrs);
		return self;
	}

	public static GtkLabelHandle SetEllipsize(this GtkLabelHandle self, PangoEllipsizeMode mode)
	{
		GtkLabelExterns.gtk_label_set_ellipsize(self, mode);
		return self;
	}

	public static GtkLabelHandle SetExtraMenu(this GtkLabelHandle self, GMenuModelHandle model)
	{
		GtkLabelExterns.gtk_label_set_extra_menu(self, model);
		return self;
	}

	public static GtkLabelHandle SetJustify(this GtkLabelHandle self, GtkJustification jtype)
	{
		GtkLabelExterns.gtk_label_set_justify(self, jtype);
		return self;
	}

	public static GtkLabelHandle SetLabel(this GtkLabelHandle self, string str)
	{
		GtkLabelExterns.gtk_label_set_label(self, str);
		return self;
	}

	public static GtkLabelHandle SetLines(this GtkLabelHandle self, int lines)
	{
		GtkLabelExterns.gtk_label_set_lines(self, lines);
		return self;
	}

	public static GtkLabelHandle SetMarkup(this GtkLabelHandle self, string str)
	{
		GtkLabelExterns.gtk_label_set_markup(self, str);
		return self;
	}

	public static GtkLabelHandle SetMarkupWithMnemonic(this GtkLabelHandle self, string str)
	{
		GtkLabelExterns.gtk_label_set_markup_with_mnemonic(self, str);
		return self;
	}

	public static GtkLabelHandle SetMaxWidthChars(this GtkLabelHandle self, int n_chars)
	{
		GtkLabelExterns.gtk_label_set_max_width_chars(self, n_chars);
		return self;
	}

	public static GtkLabelHandle SetMnemonicWidget(this GtkLabelHandle self, GtkWidgetHandle widget)
	{
		GtkLabelExterns.gtk_label_set_mnemonic_widget(self, widget);
		return self;
	}

	public static GtkLabelHandle SetNaturalWrapMode(this GtkLabelHandle self, GtkNaturalWrapMode wrap_mode)
	{
		GtkLabelExterns.gtk_label_set_natural_wrap_mode(self, wrap_mode);
		return self;
	}

	public static GtkLabelHandle SetSelectable(this GtkLabelHandle self, bool setting)
	{
		GtkLabelExterns.gtk_label_set_selectable(self, setting);
		return self;
	}

	public static GtkLabelHandle SetSingleLineMode(this GtkLabelHandle self, bool single_line_mode)
	{
		GtkLabelExterns.gtk_label_set_single_line_mode(self, single_line_mode);
		return self;
	}

	public static GtkLabelHandle SetTabs(this GtkLabelHandle self, PangoTabArrayHandle tabs)
	{
		GtkLabelExterns.gtk_label_set_tabs(self, tabs);
		return self;
	}

	public static GtkLabelHandle SetText(this GtkLabelHandle self, string str)
	{
		GtkLabelExterns.gtk_label_set_text(self, str);
		return self;
	}

	public static GtkLabelHandle SetTextWithMnemonic(this GtkLabelHandle self, string str)
	{
		GtkLabelExterns.gtk_label_set_text_with_mnemonic(self, str);
		return self;
	}

	public static GtkLabelHandle SetUseMarkup(this GtkLabelHandle self, bool setting)
	{
		GtkLabelExterns.gtk_label_set_use_markup(self, setting);
		return self;
	}

	public static GtkLabelHandle SetUseUnderline(this GtkLabelHandle self, bool setting)
	{
		GtkLabelExterns.gtk_label_set_use_underline(self, setting);
		return self;
	}

	public static GtkLabelHandle SetWidthChars(this GtkLabelHandle self, int n_chars)
	{
		GtkLabelExterns.gtk_label_set_width_chars(self, n_chars);
		return self;
	}

	public static GtkLabelHandle SetWrap(this GtkLabelHandle self, bool wrap)
	{
		GtkLabelExterns.gtk_label_set_wrap(self, wrap);
		return self;
	}

	public static GtkLabelHandle SetWrapMode(this GtkLabelHandle self, PangoWrapMode wrap_mode)
	{
		GtkLabelExterns.gtk_label_set_wrap_mode(self, wrap_mode);
		return self;
	}

	public static GtkLabelHandle SetXalign(this GtkLabelHandle self, float xalign)
	{
		GtkLabelExterns.gtk_label_set_xalign(self, xalign);
		return self;
	}

	public static GtkLabelHandle SetYalign(this GtkLabelHandle self, float yalign)
	{
		GtkLabelExterns.gtk_label_set_yalign(self, yalign);
		return self;
	}

}

internal class GtkLabelExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkLabelHandle gtk_label_new(string str);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkLabelHandle gtk_label_new_with_mnemonic(string str);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoAttrListHandle gtk_label_get_attributes(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_label_get_current_uri(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoEllipsizeMode gtk_label_get_ellipsize(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GMenuModelHandle gtk_label_get_extra_menu(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkJustification gtk_label_get_justify(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_label_get_label(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoLayoutHandle gtk_label_get_layout(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_get_layout_offsets(GtkLabelHandle self, out int x, out int y);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_label_get_lines(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_label_get_max_width_chars(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_label_get_mnemonic_keyval(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_label_get_mnemonic_widget(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkNaturalWrapMode gtk_label_get_natural_wrap_mode(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_label_get_selectable(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_label_get_selection_bounds(GtkLabelHandle self, out int start, out int end);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_label_get_single_line_mode(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoTabArrayHandle gtk_label_get_tabs(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_label_get_text(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_label_get_use_markup(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_label_get_use_underline(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_label_get_width_chars(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_label_get_wrap(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoWrapMode gtk_label_get_wrap_mode(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern float gtk_label_get_xalign(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern float gtk_label_get_yalign(GtkLabelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_select_region(GtkLabelHandle self, int start_offset, int end_offset);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_attributes(GtkLabelHandle self, PangoAttrListHandle attrs);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_ellipsize(GtkLabelHandle self, PangoEllipsizeMode mode);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_extra_menu(GtkLabelHandle self, GMenuModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_justify(GtkLabelHandle self, GtkJustification jtype);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_label(GtkLabelHandle self, string str);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_lines(GtkLabelHandle self, int lines);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_markup(GtkLabelHandle self, string str);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_markup_with_mnemonic(GtkLabelHandle self, string str);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_max_width_chars(GtkLabelHandle self, int n_chars);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_mnemonic_widget(GtkLabelHandle self, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_natural_wrap_mode(GtkLabelHandle self, GtkNaturalWrapMode wrap_mode);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_selectable(GtkLabelHandle self, bool setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_single_line_mode(GtkLabelHandle self, bool single_line_mode);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_tabs(GtkLabelHandle self, PangoTabArrayHandle tabs);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_text(GtkLabelHandle self, string str);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_text_with_mnemonic(GtkLabelHandle self, string str);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_use_markup(GtkLabelHandle self, bool setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_use_underline(GtkLabelHandle self, bool setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_width_chars(GtkLabelHandle self, int n_chars);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_wrap(GtkLabelHandle self, bool wrap);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_wrap_mode(GtkLabelHandle self, PangoWrapMode wrap_mode);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_xalign(GtkLabelHandle self, float xalign);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_label_set_yalign(GtkLabelHandle self, float yalign);

}
