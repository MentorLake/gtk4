namespace MentorLake.Gtk4;

public static class Extensions
{
	public static T With<T>(this T o, Action<T> action)
	{
		action(o);
		return o;
	}

	public static int[] MarshalIntArray(this IntPtr source, int size)
	{
		var dest = new int[size];
		Marshal.Copy(source, dest, 0, size);
		return dest;
	}

	public static byte[] MarshalByteArray(this IntPtr source, int size)
	{
		var dest = new byte[size];
		Marshal.Copy(source, dest, 0, size);
		return dest;
	}

	public static string[] MarshalStringArray(this IntPtr source, int size)
	{
		var dest = new IntPtr[size];
		Marshal.Copy(source, dest, 0, size);
		var result = new string[size];

		for (int i = 0; i < size; i++)
		{
			result[i] = Marshal.PtrToStringBSTR(dest[i]);
		}

		return result;
	}

	public static List<string> GetSignals(this GObjectHandle o)
	{
		var typeName = GObjectGlobalFunctionExterns.g_type_name_from_instance(o);
		var gtype = GObjectGlobalFunctionExterns.g_type_from_name(typeName);
		var idArrayPointer = GObjectGlobalFunctionExterns.g_signal_list_ids(gtype, out var size);
		var ids = idArrayPointer.MarshalIntArray((int)size);
		Marshal.FreeHGlobal(idArrayPointer);
		return ids.Select(id => GObjectGlobalFunctionExterns.g_signal_name((uint)id)).ToList();
	}

	private static readonly Dictionary<string, object> s_managedData = new();

	public static T SetManagedData<T>(this T obj, string key, object val) where T : GObjectHandle
	{
		lock (s_managedData)
		{
			var fullKey = $"{obj.GetHashCode()}_{key}";
			s_managedData[fullKey] = val;
			obj.WeakRef((_, _) => { lock (s_managedData) s_managedData.Remove(fullKey); }, IntPtr.Zero);
		}

		return obj;
	}

	public static T GetManagedData<T>(this GObjectHandle obj, string key) where T : class
	{
		lock (s_managedData)
		{
			return s_managedData[$"{obj.GetHashCode()}_{key}"] as T;
		}
	}
}
