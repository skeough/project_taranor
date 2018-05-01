using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO: Split out groups of defines into interfaces
public interface iBaseItem {
    string type {get; set;}
    int value {get; set;}
    decimal quality {get; set;}
    // void Sell();
    // void Buy();
}

public interface iOwnable {
    
}

public interface iEquipable {

}

public interface iWeapon {
    string dmgType {get; set;}
    int dmg {get; set;}
}

public interface iMelee {
    Dictionary components {get; set;}

    void Strike(string dmgType);
}

public interface iRanged {
    Dictionary components {get; set;}

    void Shoot(Item projectile);
}

public interface iMagic {
    Dictionary components {get; set;}

    void Cast();
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

public interface Craftable {
    list requires {get; set;}
    string recipe {get; set;}

    void Craft();
    void Dissassemble();
}

public class Item {

}
