using R2API;
using RoR2;
using UnityEngine;

namespace PassiveAgression.Croc
{
    public static class PathogenSpecialScepter
    {
        public static AssignableSkillDef def;

        static PathogenSpecialScepter()
        {

            LanguageAPI.Add("PASSIVEAGRESSION_CROCSPREAD_SCEPTER", "Virulent Carrier Pathogen");
            def = ScriptableObject.Instantiate(PathogenSpecial.def);
            def.skillNameToken = "PASSIVEAGRESSION_CROCSPREAD_SCEPTER";
            (def as ScriptableObject).name = def.skillNameToken;
            def.skillDescriptionToken = "PASSIVEAGRESSION_CROCSPREAD_SCEPTERDESC";
            ContentAddition.AddSkillDef(def);
            PathogenSpecial.scepterDef = def;
            LanguageAPI.Add("PASSIVEAGRESSION_CROCSPREAD_SCEPTERDESC", Language.GetString("PASSIVEAGRESSION_CROCSPREAD_DESC") + "\n<color=#d299ff>SCEPTER: Every bounce is as potent as the original strain.</color>");
        }


    }
}
