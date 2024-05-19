namespace MentorLake.Gtk4.Gtk4;

public class GtkVideoHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkVideoHandle New()
	{
		return GtkVideoExterns.gtk_video_new();
	}

	public static GtkVideoHandle NewForFile(GFileHandle file)
	{
		return GtkVideoExterns.gtk_video_new_for_file(file);
	}

	public static GtkVideoHandle NewForFilename(string filename)
	{
		return GtkVideoExterns.gtk_video_new_for_filename(filename);
	}

	public static GtkVideoHandle NewForMediaStream(GtkMediaStreamHandle stream)
	{
		return GtkVideoExterns.gtk_video_new_for_media_stream(stream);
	}

	public static GtkVideoHandle NewForResource(string resource_path)
	{
		return GtkVideoExterns.gtk_video_new_for_resource(resource_path);
	}

}

public static class GtkVideoHandleExtensions
{
	public static bool GetAutoplay(this GtkVideoHandle self)
	{
		return GtkVideoExterns.gtk_video_get_autoplay(self);
	}

	public static GFileHandle GetFile(this GtkVideoHandle self)
	{
		return GtkVideoExterns.gtk_video_get_file(self);
	}

	public static GtkGraphicsOffloadEnabled GetGraphicsOffload(this GtkVideoHandle self)
	{
		return GtkVideoExterns.gtk_video_get_graphics_offload(self);
	}

	public static bool GetLoop(this GtkVideoHandle self)
	{
		return GtkVideoExterns.gtk_video_get_loop(self);
	}

	public static GtkMediaStreamHandle GetMediaStream(this GtkVideoHandle self)
	{
		return GtkVideoExterns.gtk_video_get_media_stream(self);
	}

	public static GtkVideoHandle SetAutoplay(this GtkVideoHandle self, bool autoplay)
	{
		GtkVideoExterns.gtk_video_set_autoplay(self, autoplay);
		return self;
	}

	public static GtkVideoHandle SetFile(this GtkVideoHandle self, GFileHandle file)
	{
		GtkVideoExterns.gtk_video_set_file(self, file);
		return self;
	}

	public static GtkVideoHandle SetFilename(this GtkVideoHandle self, string filename)
	{
		GtkVideoExterns.gtk_video_set_filename(self, filename);
		return self;
	}

	public static GtkVideoHandle SetGraphicsOffload(this GtkVideoHandle self, GtkGraphicsOffloadEnabled enabled)
	{
		GtkVideoExterns.gtk_video_set_graphics_offload(self, enabled);
		return self;
	}

	public static GtkVideoHandle SetLoop(this GtkVideoHandle self, bool loop)
	{
		GtkVideoExterns.gtk_video_set_loop(self, loop);
		return self;
	}

	public static GtkVideoHandle SetMediaStream(this GtkVideoHandle self, GtkMediaStreamHandle stream)
	{
		GtkVideoExterns.gtk_video_set_media_stream(self, stream);
		return self;
	}

	public static GtkVideoHandle SetResource(this GtkVideoHandle self, string resource_path)
	{
		GtkVideoExterns.gtk_video_set_resource(self, resource_path);
		return self;
	}

}

internal class GtkVideoExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkVideoHandle gtk_video_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkVideoHandle gtk_video_new_for_file(GFileHandle file);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkVideoHandle gtk_video_new_for_filename(string filename);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkVideoHandle gtk_video_new_for_media_stream(GtkMediaStreamHandle stream);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkVideoHandle gtk_video_new_for_resource(string resource_path);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_video_get_autoplay(GtkVideoHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GFileHandle gtk_video_get_file(GtkVideoHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGraphicsOffloadEnabled gtk_video_get_graphics_offload(GtkVideoHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_video_get_loop(GtkVideoHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMediaStreamHandle gtk_video_get_media_stream(GtkVideoHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_video_set_autoplay(GtkVideoHandle self, bool autoplay);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_video_set_file(GtkVideoHandle self, GFileHandle file);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_video_set_filename(GtkVideoHandle self, string filename);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_video_set_graphics_offload(GtkVideoHandle self, GtkGraphicsOffloadEnabled enabled);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_video_set_loop(GtkVideoHandle self, bool loop);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_video_set_media_stream(GtkVideoHandle self, GtkMediaStreamHandle stream);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_video_set_resource(GtkVideoHandle self, string resource_path);

}
