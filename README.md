***<p style="color:#AA0000">This is still a work in progress.</p>***

### Summary
**Bindings for the GTK4 libraries (GTK, GDK, GLib, etc.).**

The GTK API is exposed via extension methods off of the safe handle classes.  The P/Invoke definitions are internal so you don't interact with them directly. The constructor-like methods to create the safe handles are regular static methods off of the safe handle types.

Functions from the GTK API that normally would return void (e.g., gtk_button_set_label) return a safe handle instead to create a fluent DSL.

### Example
```csharp
var window = GtkWindowHandle.New()
	.SetChild(GtkBoxHandle.New(GtkOrientation.GTK_ORIENTATION_HORIZONTAL, 0)
		.Append(GtkButtonHandle.New()
			.SetLabel("TEST")
			.Connect(GtkButtonSignals.Clicked, () => Console.WriteLine("CLICK")))
		.Append(GtkImageHandle.NewFromIconName("face-smile")
			.SetIconSize(GtkIconSize.GTK_ICON_SIZE_LARGE)
			.SetSizeRequest(64, 64)));
```

### Warning

The bindings are generated from the API docs and heuristics were needed to determine between arrays, pointers, out parameters, ref parameters, etc.  If you find an issue then please submit a pull request.
