using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structure {

    private enum StructureType {Wall}
    private enum StructureMaterial {Stone}

    StructureType type = StructureType.Wall;
    StructureMaterial material = StructureMaterial.Stone;
}
