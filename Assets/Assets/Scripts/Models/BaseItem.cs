using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iBaseItem {
    int value {get; set;}
    string material {get; set;}
}
public interface iMelee {
    void Strike(string dmgType);
}

public interface iRanged {
    void Shoot(string projectile);
}

public interface iStackable {

    int stackTo {get; set;}
    int storeTo {get; set;}

    void Store();
    void Stack();
}

public interface iPileable {
    int pileTo {get; set;}
    int storeTo {get; set;}
}

public class Item {

    //TODO: Split out groups of defines into interfaces

}
