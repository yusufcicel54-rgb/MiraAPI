using HarmonyLib;
using UnityEngine;

namespace MyMiraMod.Patches;

[HarmonyPatch(typeof(PlayerPhysics), nameof(PlayerPhysics.FixedUpdate))]
public static class SpeedPatch
{
    [HarmonyPostfix]
    public static void Postfix(PlayerPhysics __instance)
    {
        // 1. Sadece kendi kontrol ettiğimiz karaktere uygula
        if (__instance.myPlayer != null && __instance.myPlayer.AmOwner)
        {
            // 2. Karakter hareket ediyorsa anlık hız vektörünü 8 ile çarp
            // (Neden velocity? Çünkü durduğunda kaymaz, sadece yürüdüğün yöne 8 kat uçar!)
            __instance.body.velocity *= 8f;
        }
    }
}
