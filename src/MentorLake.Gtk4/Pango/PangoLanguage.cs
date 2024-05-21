namespace MentorLake.Gtk4.Pango;

public class PangoLanguageHandle : BaseSafeHandle
{
}


public static class PangoLanguageHandleExtensions
{
	public static string GetSampleString(this PangoLanguageHandle language)
	{
		return PangoLanguageExterns.pango_language_get_sample_string(language);
	}

	public static IntPtr GetScripts(this PangoLanguageHandle language, out int num_scripts)
	{
		return PangoLanguageExterns.pango_language_get_scripts(language, out num_scripts);
	}

	public static bool IncludesScript(this PangoLanguageHandle language, PangoScript script)
	{
		return PangoLanguageExterns.pango_language_includes_script(language, script);
	}

	public static bool Matches(this PangoLanguageHandle language, string range_list)
	{
		return PangoLanguageExterns.pango_language_matches(language, range_list);
	}

	public static string ToString(this PangoLanguageHandle language)
	{
		return PangoLanguageExterns.pango_language_to_string(language);
	}

}
internal class PangoLanguageExterns
{
	[DllImport(Libraries.Pango)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_language_get_sample_string(PangoLanguageHandle language);

	[DllImport(Libraries.Pango)]
	internal static extern IntPtr pango_language_get_scripts(PangoLanguageHandle language, out int num_scripts);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_language_includes_script(PangoLanguageHandle language, PangoScript script);

	[DllImport(Libraries.Pango)]
	internal static extern bool pango_language_matches(PangoLanguageHandle language, string range_list);

	[DllImport(Libraries.Pango)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string pango_language_to_string(PangoLanguageHandle language);

}

public struct PangoLanguage
{
}
