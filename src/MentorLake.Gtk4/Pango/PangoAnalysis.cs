namespace MentorLake.Gtk4.Pango;

public class PangoAnalysisHandle : BaseSafeHandle
{
}


public static class PangoAnalysisHandleExtensions
{
}
internal class PangoAnalysisExterns
{
}

public struct PangoAnalysis
{
	public IntPtr shape_engine;
	public IntPtr lang_engine;
	public PangoFontHandle font;
	public byte level;
	public byte gravity;
	public byte flags;
	public byte script;
	public PangoLanguageHandle language;
	public GSListHandle extra_attrs;
}
