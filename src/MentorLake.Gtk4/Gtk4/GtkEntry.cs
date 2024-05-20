namespace MentorLake.Gtk4.Gtk4;

public class GtkEntryHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkConstraintTargetHandle, GtkEditableHandle
{
	public static GtkEntryHandle New()
	{
		return GtkEntryExterns.gtk_entry_new();
	}

	public static GtkEntryHandle NewWithBuffer(GtkEntryBufferHandle buffer)
	{
		return GtkEntryExterns.gtk_entry_new_with_buffer(buffer);
	}

}

public static class GtkEntrySignalExtensions
{

	public static IObservable<GtkEntrySignalStructs.ActivateSignal> Signal_Activate(this GtkEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkEntrySignalStructs.ActivateSignal> obs) =>
		{
			GtkEntrySignalDelegates.activate handler = (GtkEntryHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntrySignalStructs.ActivateSignal()
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

	public static IObservable<GtkEntrySignalStructs.IconPressSignal> Signal_IconPress(this GtkEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkEntrySignalStructs.IconPressSignal> obs) =>
		{
			GtkEntrySignalDelegates.icon_press handler = (GtkEntryHandle self, GtkEntryIconPosition icon_pos, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntrySignalStructs.IconPressSignal()
				{
					Self = self, IconPos = icon_pos, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "icon_press", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntrySignalStructs.IconReleaseSignal> Signal_IconRelease(this GtkEntryHandle instance)
	{
		return Observable.Create((IObserver<GtkEntrySignalStructs.IconReleaseSignal> obs) =>
		{
			GtkEntrySignalDelegates.icon_release handler = (GtkEntryHandle self, GtkEntryIconPosition icon_pos, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntrySignalStructs.IconReleaseSignal()
				{
					Self = self, IconPos = icon_pos, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "icon_release", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkEntrySignalStructs
{

public struct ActivateSignal
{
	public GtkEntryHandle Self;
	public IntPtr UserData;
}

public struct IconPressSignal
{
	public GtkEntryHandle Self;
	public GtkEntryIconPosition IconPos;
	public IntPtr UserData;
}

public struct IconReleaseSignal
{
	public GtkEntryHandle Self;
	public GtkEntryIconPosition IconPos;
	public IntPtr UserData;
}
}

public static class GtkEntrySignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryHandle>))] GtkEntryHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void icon_press([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryHandle>))] GtkEntryHandle self, GtkEntryIconPosition icon_pos, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void icon_release([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryHandle>))] GtkEntryHandle self, GtkEntryIconPosition icon_pos, IntPtr user_data);

}


public static class GtkEntryHandleExtensions
{
	public static bool GetActivatesDefault(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_activates_default(entry);
	}

	public static float GetAlignment(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_alignment(entry);
	}

	public static PangoAttrListHandle GetAttributes(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_attributes(entry);
	}

	public static GtkEntryBufferHandle GetBuffer(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_buffer(entry);
	}

	public static GtkEntryCompletionHandle GetCompletion(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_completion(entry);
	}

	public static int GetCurrentIconDragSource(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_current_icon_drag_source(entry);
	}

	public static GMenuModelHandle GetExtraMenu(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_extra_menu(entry);
	}

	public static bool GetHasFrame(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_has_frame(entry);
	}

	public static bool GetIconActivatable(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_activatable(entry, icon_pos);
	}

	public static GtkEntryHandle GetIconArea(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, out GdkRectangle icon_area)
	{
		GtkEntryExterns.gtk_entry_get_icon_area(entry, icon_pos, out icon_area);
		return entry;
	}

	public static int GetIconAtPos(this GtkEntryHandle entry, int x, int y)
	{
		return GtkEntryExterns.gtk_entry_get_icon_at_pos(entry, x, y);
	}

	public static GIconHandle GetIconGicon(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_gicon(entry, icon_pos);
	}

	public static string GetIconName(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_name(entry, icon_pos);
	}

	public static GdkPaintableHandle GetIconPaintable(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_paintable(entry, icon_pos);
	}

	public static bool GetIconSensitive(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_sensitive(entry, icon_pos);
	}

	public static GtkImageType GetIconStorageType(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_storage_type(entry, icon_pos);
	}

	public static string GetIconTooltipMarkup(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_tooltip_markup(entry, icon_pos);
	}

	public static string GetIconTooltipText(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos)
	{
		return GtkEntryExterns.gtk_entry_get_icon_tooltip_text(entry, icon_pos);
	}

	public static GtkInputHints GetInputHints(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_input_hints(entry);
	}

	public static GtkInputPurpose GetInputPurpose(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_input_purpose(entry);
	}

	public static char GetInvisibleChar(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_invisible_char(entry);
	}

	public static int GetMaxLength(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_max_length(entry);
	}

	public static bool GetOverwriteMode(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_overwrite_mode(entry);
	}

	public static string GetPlaceholderText(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_placeholder_text(entry);
	}

	public static double GetProgressFraction(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_progress_fraction(entry);
	}

	public static double GetProgressPulseStep(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_progress_pulse_step(entry);
	}

	public static PangoTabArrayHandle GetTabs(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_tabs(entry);
	}

	public static ushort GetTextLength(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_text_length(entry);
	}

	public static bool GetVisibility(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_get_visibility(entry);
	}

	public static bool GrabFocusWithoutSelecting(this GtkEntryHandle entry)
	{
		return GtkEntryExterns.gtk_entry_grab_focus_without_selecting(entry);
	}

	public static GtkEntryHandle ProgressPulse(this GtkEntryHandle entry)
	{
		GtkEntryExterns.gtk_entry_progress_pulse(entry);
		return entry;
	}

	public static GtkEntryHandle ResetImContext(this GtkEntryHandle entry)
	{
		GtkEntryExterns.gtk_entry_reset_im_context(entry);
		return entry;
	}

	public static GtkEntryHandle SetActivatesDefault(this GtkEntryHandle entry, bool setting)
	{
		GtkEntryExterns.gtk_entry_set_activates_default(entry, setting);
		return entry;
	}

	public static GtkEntryHandle SetAlignment(this GtkEntryHandle entry, float xalign)
	{
		GtkEntryExterns.gtk_entry_set_alignment(entry, xalign);
		return entry;
	}

	public static GtkEntryHandle SetAttributes(this GtkEntryHandle entry, PangoAttrListHandle attrs)
	{
		GtkEntryExterns.gtk_entry_set_attributes(entry, attrs);
		return entry;
	}

	public static GtkEntryHandle SetBuffer(this GtkEntryHandle entry, GtkEntryBufferHandle buffer)
	{
		GtkEntryExterns.gtk_entry_set_buffer(entry, buffer);
		return entry;
	}

	public static GtkEntryHandle SetCompletion(this GtkEntryHandle entry, GtkEntryCompletionHandle completion)
	{
		GtkEntryExterns.gtk_entry_set_completion(entry, completion);
		return entry;
	}

	public static GtkEntryHandle SetExtraMenu(this GtkEntryHandle entry, GMenuModelHandle model)
	{
		GtkEntryExterns.gtk_entry_set_extra_menu(entry, model);
		return entry;
	}

	public static GtkEntryHandle SetHasFrame(this GtkEntryHandle entry, bool setting)
	{
		GtkEntryExterns.gtk_entry_set_has_frame(entry, setting);
		return entry;
	}

	public static GtkEntryHandle SetIconActivatable(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, bool activatable)
	{
		GtkEntryExterns.gtk_entry_set_icon_activatable(entry, icon_pos, activatable);
		return entry;
	}

	public static GtkEntryHandle SetIconDragSource(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GdkContentProviderHandle provider, GdkDragAction actions)
	{
		GtkEntryExterns.gtk_entry_set_icon_drag_source(entry, icon_pos, provider, actions);
		return entry;
	}

	public static GtkEntryHandle SetIconFromGicon(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GIconHandle icon)
	{
		GtkEntryExterns.gtk_entry_set_icon_from_gicon(entry, icon_pos, icon);
		return entry;
	}

	public static GtkEntryHandle SetIconFromIconName(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string icon_name)
	{
		GtkEntryExterns.gtk_entry_set_icon_from_icon_name(entry, icon_pos, icon_name);
		return entry;
	}

	public static GtkEntryHandle SetIconFromPaintable(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GdkPaintableHandle paintable)
	{
		GtkEntryExterns.gtk_entry_set_icon_from_paintable(entry, icon_pos, paintable);
		return entry;
	}

	public static GtkEntryHandle SetIconSensitive(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, bool sensitive)
	{
		GtkEntryExterns.gtk_entry_set_icon_sensitive(entry, icon_pos, sensitive);
		return entry;
	}

	public static GtkEntryHandle SetIconTooltipMarkup(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string tooltip)
	{
		GtkEntryExterns.gtk_entry_set_icon_tooltip_markup(entry, icon_pos, tooltip);
		return entry;
	}

	public static GtkEntryHandle SetIconTooltipText(this GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string tooltip)
	{
		GtkEntryExterns.gtk_entry_set_icon_tooltip_text(entry, icon_pos, tooltip);
		return entry;
	}

	public static GtkEntryHandle SetInputHints(this GtkEntryHandle entry, GtkInputHints hints)
	{
		GtkEntryExterns.gtk_entry_set_input_hints(entry, hints);
		return entry;
	}

	public static GtkEntryHandle SetInputPurpose(this GtkEntryHandle entry, GtkInputPurpose purpose)
	{
		GtkEntryExterns.gtk_entry_set_input_purpose(entry, purpose);
		return entry;
	}

	public static GtkEntryHandle SetInvisibleChar(this GtkEntryHandle entry, char ch)
	{
		GtkEntryExterns.gtk_entry_set_invisible_char(entry, ch);
		return entry;
	}

	public static GtkEntryHandle SetMaxLength(this GtkEntryHandle entry, int max)
	{
		GtkEntryExterns.gtk_entry_set_max_length(entry, max);
		return entry;
	}

	public static GtkEntryHandle SetOverwriteMode(this GtkEntryHandle entry, bool overwrite)
	{
		GtkEntryExterns.gtk_entry_set_overwrite_mode(entry, overwrite);
		return entry;
	}

	public static GtkEntryHandle SetPlaceholderText(this GtkEntryHandle entry, string text)
	{
		GtkEntryExterns.gtk_entry_set_placeholder_text(entry, text);
		return entry;
	}

	public static GtkEntryHandle SetProgressFraction(this GtkEntryHandle entry, double fraction)
	{
		GtkEntryExterns.gtk_entry_set_progress_fraction(entry, fraction);
		return entry;
	}

	public static GtkEntryHandle SetProgressPulseStep(this GtkEntryHandle entry, double fraction)
	{
		GtkEntryExterns.gtk_entry_set_progress_pulse_step(entry, fraction);
		return entry;
	}

	public static GtkEntryHandle SetTabs(this GtkEntryHandle entry, PangoTabArrayHandle tabs)
	{
		GtkEntryExterns.gtk_entry_set_tabs(entry, tabs);
		return entry;
	}

	public static GtkEntryHandle SetVisibility(this GtkEntryHandle entry, bool visible)
	{
		GtkEntryExterns.gtk_entry_set_visibility(entry, visible);
		return entry;
	}

	public static GtkEntryHandle UnsetInvisibleChar(this GtkEntryHandle entry)
	{
		GtkEntryExterns.gtk_entry_unset_invisible_char(entry);
		return entry;
	}

}

internal class GtkEntryExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEntryHandle gtk_entry_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEntryHandle gtk_entry_new_with_buffer(GtkEntryBufferHandle buffer);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_entry_get_activates_default(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern float gtk_entry_get_alignment(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoAttrListHandle gtk_entry_get_attributes(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEntryBufferHandle gtk_entry_get_buffer(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEntryCompletionHandle gtk_entry_get_completion(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_entry_get_current_icon_drag_source(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern GMenuModelHandle gtk_entry_get_extra_menu(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_entry_get_has_frame(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_entry_get_icon_activatable(GtkEntryHandle entry, GtkEntryIconPosition icon_pos);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_get_icon_area(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, out GdkRectangle icon_area);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_entry_get_icon_at_pos(GtkEntryHandle entry, int x, int y);

	[DllImport(Libraries.Gtk4)]
	internal static extern GIconHandle gtk_entry_get_icon_gicon(GtkEntryHandle entry, GtkEntryIconPosition icon_pos);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_get_icon_name(GtkEntryHandle entry, GtkEntryIconPosition icon_pos);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkPaintableHandle gtk_entry_get_icon_paintable(GtkEntryHandle entry, GtkEntryIconPosition icon_pos);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_entry_get_icon_sensitive(GtkEntryHandle entry, GtkEntryIconPosition icon_pos);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkImageType gtk_entry_get_icon_storage_type(GtkEntryHandle entry, GtkEntryIconPosition icon_pos);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_entry_get_icon_tooltip_markup(GtkEntryHandle entry, GtkEntryIconPosition icon_pos);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_entry_get_icon_tooltip_text(GtkEntryHandle entry, GtkEntryIconPosition icon_pos);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInputHints gtk_entry_get_input_hints(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInputPurpose gtk_entry_get_input_purpose(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern char gtk_entry_get_invisible_char(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_entry_get_max_length(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_entry_get_overwrite_mode(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_get_placeholder_text(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_entry_get_progress_fraction(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_entry_get_progress_pulse_step(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoTabArrayHandle gtk_entry_get_tabs(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern ushort gtk_entry_get_text_length(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_entry_get_visibility(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_entry_grab_focus_without_selecting(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_progress_pulse(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_reset_im_context(GtkEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_activates_default(GtkEntryHandle entry, bool setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_alignment(GtkEntryHandle entry, float xalign);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_attributes(GtkEntryHandle entry, PangoAttrListHandle attrs);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_buffer(GtkEntryHandle entry, GtkEntryBufferHandle buffer);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_completion(GtkEntryHandle entry, GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_extra_menu(GtkEntryHandle entry, GMenuModelHandle model);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_has_frame(GtkEntryHandle entry, bool setting);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_icon_activatable(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, bool activatable);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_icon_drag_source(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GdkContentProviderHandle provider, GdkDragAction actions);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_icon_from_gicon(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GIconHandle icon);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_icon_from_icon_name(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string icon_name);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_icon_from_paintable(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, GdkPaintableHandle paintable);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_icon_sensitive(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, bool sensitive);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_icon_tooltip_markup(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string tooltip);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_icon_tooltip_text(GtkEntryHandle entry, GtkEntryIconPosition icon_pos, string tooltip);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_input_hints(GtkEntryHandle entry, GtkInputHints hints);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_input_purpose(GtkEntryHandle entry, GtkInputPurpose purpose);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_invisible_char(GtkEntryHandle entry, char ch);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_max_length(GtkEntryHandle entry, int max);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_overwrite_mode(GtkEntryHandle entry, bool overwrite);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_placeholder_text(GtkEntryHandle entry, string text);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_progress_fraction(GtkEntryHandle entry, double fraction);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_progress_pulse_step(GtkEntryHandle entry, double fraction);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_tabs(GtkEntryHandle entry, PangoTabArrayHandle tabs);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_set_visibility(GtkEntryHandle entry, bool visible);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_entry_unset_invisible_char(GtkEntryHandle entry);

}
