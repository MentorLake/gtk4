namespace MentorLake.Gtk4.Gio;

[Flags]
public enum GFileMeasureFlags
{
	G_FILE_MEASURE_NONE = 0,
	G_FILE_MEASURE_REPORT_ANY_ERROR = 1,
	G_FILE_MEASURE_APPARENT_SIZE = 2,
	G_FILE_MEASURE_NO_XDEV = 4
}
