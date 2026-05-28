#if TOOLS
using Godot;
namespace SpatialAudioCS;

[Tool]
public partial class Plugin : EditorPlugin
{
	//private Button AddAcousticButton = null;

	public override void _EnterTree()
	{
		// TODO: Editor Interface selection changed signal connection
	}

	public override void _ExitTree()
	{
		// TODO: RemoveButton()
		// TODO: Disconnect from selection signal.
	}

	// TODO: private void OnSelectionChanged()

	// TODO: private void ShowButton(Node3D target)

	// TODO: private void RemoveButton()

	// TODO: private void OnAddAcousticButtonPressed(Node3D target)
}
#endif
