using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerManager
{
    static player playerOne;
    public static player getPlayer()
    {
        return playerOne;
    }

    public static void setPlayer(player p)
    {
        playerOne = p;
    }
}
