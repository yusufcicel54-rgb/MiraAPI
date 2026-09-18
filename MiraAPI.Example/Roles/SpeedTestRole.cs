using UnityEngine;
using MiraAPI.Roles;

namespace MyMiraMod.Roles;

public class SpeedTestRole : CustomRole
{
    // Oyunda görünecek isim
    public override string RoleName => "Flash Test";

    // İsmin ve rolün rengi (Sarı yaptık, tam Flash olsun)
    public override Color RoleColor => Color.yellow;

    // Hangi takımda olsun? (Crewmate/İyiler)
    public override RoleTeam RoleTeam => RoleTeam.Crewmate;

    // Rolün açıklaması
    public override string RoleDescription => "Test amaçlıdır: Işık hızında koşar!";
}
