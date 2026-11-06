using System;
using common;
using core.config;
using core.config.pet_skin;

namespace core.model
{
    public class PetSkinInfo
    {
        public int id;

        public int type;

        public int[] monIDs;

        public int shopId;

        public int skinPetId;

        public string go;

        public string name;

        public string goType;

        public int jumpTarget;

        public ISkinItem config;

        public PetSkinInfo(ISkinItem info = null)
        {
            if (info != null)
            {
                config = info;
                id = info.ID;
                name = info.Name;
                monIDs = [info.MonID];
                skinPetId = ResetableSingleTon<PetXMLInfo>.Ins.getRealId(1400000 + id);
                type = info.Type;
                go = info.Go;
                goType = info.GoType;
                jumpTarget = info.Jumptarget;
            }
        }

        [Obsolete("请使用PetSkinXMLInfo.Ins.getPetDefaultSkin")]
        public static void getPetDefaultSkin()
        {
        }
    }
}
