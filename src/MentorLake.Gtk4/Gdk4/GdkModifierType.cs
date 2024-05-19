namespace MentorLake.Gtk4.Gdk4;

[Flags]
public enum GdkModifierType
{
	GDK_NO_MODIFIER_MASK = 0,
	GDK_SHIFT_MASK = 1,
	GDK_LOCK_MASK = 2,
	GDK_CONTROL_MASK = 4,
	GDK_ALT_MASK = 8,
	GDK_BUTTON1_MASK = 16,
	GDK_BUTTON2_MASK = 32,
	GDK_BUTTON3_MASK = 64,
	GDK_BUTTON4_MASK = 128,
	GDK_BUTTON5_MASK = 256,
	GDK_SUPER_MASK = 512,
	GDK_HYPER_MASK = 1024,
	GDK_META_MASK = 2048
}
