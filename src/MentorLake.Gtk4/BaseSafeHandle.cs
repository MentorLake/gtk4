using Microsoft.Win32.SafeHandles;

namespace MentorLake.Gtk4;

public class BaseSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	public BaseSafeHandle() : base(true) { }

	protected override bool ReleaseHandle() => true;
}
