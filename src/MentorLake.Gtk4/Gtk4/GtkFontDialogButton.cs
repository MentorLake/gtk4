namespace MentorLake.Gtk4.Gtk4;

public class GtkFontDialogButtonHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkFontDialogButtonHandle New(GtkFontDialogHandle dialog)
	{
		return GtkFontDialogButtonExterns.gtk_font_dialog_button_new(dialog);
	}

}

public static class GtkFontDialogButtonSignalExtensions
{

	public static IObservable<GtkFontDialogButtonSignalStructs.ActivateSignal> Signal_Activate(this GtkFontDialogButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkFontDialogButtonSignalStructs.ActivateSignal> obs) =>
		{
			GtkFontDialogButtonSignalDelegates.Activate handler = (GtkFontDialogButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFontDialogButtonSignalStructs.ActivateSignal()
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

public static class GtkFontDialogButtonSignalStructs
{

public struct ActivateSignal
{
	public GtkFontDialogButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkFontDialogButtonSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFontDialogButtonHandle>))] GtkFontDialogButtonHandle self, IntPtr user_data);
}


public static class GtkFontDialogButtonHandleExtensions
{
	public static GtkFontDialogHandle GetDialog(this GtkFontDialogButtonHandle self)
	{
		return GtkFontDialogButtonExterns.gtk_font_dialog_button_get_dialog(self);
	}

	public static PangoFontDescriptionHandle GetFontDesc(this GtkFontDialogButtonHandle self)
	{
		return GtkFontDialogButtonExterns.gtk_font_dialog_button_get_font_desc(self);
	}

	public static string GetFontFeatures(this GtkFontDialogButtonHandle self)
	{
		return GtkFontDialogButtonExterns.gtk_font_dialog_button_get_font_features(self);
	}

	public static PangoLanguageHandle GetLanguage(this GtkFontDialogButtonHandle self)
	{
		return GtkFontDialogButtonExterns.gtk_font_dialog_button_get_language(self);
	}

	public static GtkFontLevel GetLevel(this GtkFontDialogButtonHandle self)
	{
		return GtkFontDialogButtonExterns.gtk_font_dialog_button_get_level(self);
	}

	public static bool GetUseFont(this GtkFontDialogButtonHandle self)
	{
		return GtkFontDialogButtonExterns.gtk_font_dialog_button_get_use_font(self);
	}

	public static bool GetUseSize(this GtkFontDialogButtonHandle self)
	{
		return GtkFontDialogButtonExterns.gtk_font_dialog_button_get_use_size(self);
	}

	public static GtkFontDialogButtonHandle SetDialog(this GtkFontDialogButtonHandle self, GtkFontDialogHandle dialog)
	{
		GtkFontDialogButtonExterns.gtk_font_dialog_button_set_dialog(self, dialog);
		return self;
	}

	public static GtkFontDialogButtonHandle SetFontDesc(this GtkFontDialogButtonHandle self, PangoFontDescriptionHandle font_desc)
	{
		GtkFontDialogButtonExterns.gtk_font_dialog_button_set_font_desc(self, font_desc);
		return self;
	}

	public static GtkFontDialogButtonHandle SetFontFeatures(this GtkFontDialogButtonHandle self, string font_features)
	{
		GtkFontDialogButtonExterns.gtk_font_dialog_button_set_font_features(self, font_features);
		return self;
	}

	public static GtkFontDialogButtonHandle SetLanguage(this GtkFontDialogButtonHandle self, PangoLanguageHandle language)
	{
		GtkFontDialogButtonExterns.gtk_font_dialog_button_set_language(self, language);
		return self;
	}

	public static GtkFontDialogButtonHandle SetLevel(this GtkFontDialogButtonHandle self, GtkFontLevel level)
	{
		GtkFontDialogButtonExterns.gtk_font_dialog_button_set_level(self, level);
		return self;
	}

	public static GtkFontDialogButtonHandle SetUseFont(this GtkFontDialogButtonHandle self, bool use_font)
	{
		GtkFontDialogButtonExterns.gtk_font_dialog_button_set_use_font(self, use_font);
		return self;
	}

	public static GtkFontDialogButtonHandle SetUseSize(this GtkFontDialogButtonHandle self, bool use_size)
	{
		GtkFontDialogButtonExterns.gtk_font_dialog_button_set_use_size(self, use_size);
		return self;
	}

}

internal class GtkFontDialogButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFontDialogButtonHandle gtk_font_dialog_button_new(GtkFontDialogHandle dialog);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFontDialogHandle gtk_font_dialog_button_get_dialog(GtkFontDialogButtonHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoFontDescriptionHandle gtk_font_dialog_button_get_font_desc(GtkFontDialogButtonHandle self);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_dialog_button_get_font_features(GtkFontDialogButtonHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern PangoLanguageHandle gtk_font_dialog_button_get_language(GtkFontDialogButtonHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFontLevel gtk_font_dialog_button_get_level(GtkFontDialogButtonHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_font_dialog_button_get_use_font(GtkFontDialogButtonHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_font_dialog_button_get_use_size(GtkFontDialogButtonHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_button_set_dialog(GtkFontDialogButtonHandle self, GtkFontDialogHandle dialog);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_button_set_font_desc(GtkFontDialogButtonHandle self, PangoFontDescriptionHandle font_desc);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_button_set_font_features(GtkFontDialogButtonHandle self, string font_features);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_button_set_language(GtkFontDialogButtonHandle self, PangoLanguageHandle language);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_button_set_level(GtkFontDialogButtonHandle self, GtkFontLevel level);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_button_set_use_font(GtkFontDialogButtonHandle self, bool use_font);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_font_dialog_button_set_use_size(GtkFontDialogButtonHandle self, bool use_size);

}
