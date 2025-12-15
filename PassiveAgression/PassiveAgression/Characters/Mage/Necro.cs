using EntityStates;
using R2API;
using RoR2.Orbs;
using UnityEngine;

namespace PassiveAgression.Mage
{
    public static class Necromancy
    {
        public static AssignableSkillDef def;
        public static bool isHooked;

        static Necromancy()
        {
            LanguageAPI.Add("PASSIVEAGRESSION_MAGENECRO", "Necrotic Rancor");
            LanguageAPI.Add("PASSIVEAGRESSION_MAGENECRO_DESC", "Gather the spirits of the angry lost,turning them upon your enemies.");


            def = ScriptableObject.CreateInstance<AssignableSkillDef>();
            def.skillNameToken = "PASSIVEAGRESSION_MAGENECRO";
            (def as ScriptableObject).name = def.skillNameToken;
            def.skillDescriptionToken = "PASSIVEAGRESSION_MAGENECRO_DESC";
            def.baseRechargeInterval = 20f;
            def.canceledFromSprinting = false;
            def.cancelSprintingOnActivation = true;
            def.activationStateMachineName = "Weapon";
            def.activationState = new SerializableEntityStateType(typeof(NecroState));
            def.icon = PassiveAgressionPlugin.unfinishedIcon;

            def.onAssign += (skill) =>
            {
                if (!isHooked)
                {
                    isHooked = true;
                }
                return null;
            };


            ContentAddition.AddSkillDef(def);
            ContentAddition.AddEntityState(typeof(NecroState), out _);

        }

        public class NecroOrb : DevilOrb
        {

        }

        public class NecroState : BaseState
        {

        }
    }
}
