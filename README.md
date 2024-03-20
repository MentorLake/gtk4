***<p style="color:#AA0000">This is still a work in progress.</p>***

### Summary
**Bindings for the GTK4 libraries (GTK, GDK, GLib, etc.).**

The GTK API is exposed via extension methods off of the safe handle classes.  The P/Invoke definitions are internal so you don't interact with them directly. The constructor-like methods to create the safe handles are regular static methods off of the safe handle types.

Functions from the GTK API that normally would return void (e.g., gtk_button_set_label) return a safe handle instead to create a fluent DSL.

### Example
```csharp
var box = GtkBoxHandle.New(GtkOrientation.GTK_ORIENTATION_HORIZONTAL, 0)
	.Append(GtkButtonHandle.New()
		.SetLabel("Hello World"))
```

### Warning

I generated the initial bindings using ClangSharpPInvokeGenerator, massaged the output into safe code via regular expressions and Roslyn, and manually updated definitions where necessary.  There's no guarantee that the struct types or extern method signatures are correct.  If you find issues, please submit a pull request.
