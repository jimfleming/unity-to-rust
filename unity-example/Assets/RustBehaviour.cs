using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class RustBehaviour : MonoBehaviour {

  // The plugin referenced by `DLLImport` must be compiled
  // and placed in your project's Assets/Plugins/ folder.

  // Make sure that you rename the lib<name>.dylib to
  // lib<name>.bundle so that Unity can find it.

  [DllImport("libunity_rust")]
  private static extern int double_input(int x);

  [DllImport("libunity_rust")]
  private static extern int triple_input(int x);

  void Start() {
    Debug.Log(double_input(4)); // 8
    Debug.Log(triple_input(4)); // 12
  }
}
