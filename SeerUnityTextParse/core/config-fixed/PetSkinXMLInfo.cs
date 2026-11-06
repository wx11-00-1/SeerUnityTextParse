using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using common;
using core.config.pet_skin;
using core.model;

namespace core.config
{
    public class PetSkinXMLInfo : ConfigManagerSingleton<PetSkinXMLInfo>
    {

        private Dictionary<int, PetSkinInfo> s_DataMap;

        private Dictionary<int, List<PetSkinInfo>> s_DataMapByPetId = new Dictionary<int, List<PetSkinInfo>>(521);

        private static int[] TypeArr4Limit = new int[14]
        {
            4, 5, 6, 7, 8, 9, 11, 12, 13, 15,
            16, 17, 18, 19
        };

        private List<string> typeMapCn = new List<string>
        {
            "默认",
            "英雄",
            "史诗",
            "传说",
            "周年限定",
            "万圣限定",
            "中秋节限定",
            "春节限定",
            "圣诞节限定",
            "青春校园",
            string.Empty,
            "周年限定",
            "周年限定",
            "异元时空",
            "神话",
            "七夕限定",
            "限定",
            "至臻"
        };

        public List<PetSkinInfo> getSkinInfosByPetId(int petId)
        {
            List<PetSkinInfo> result = new List<PetSkinInfo>();
            //HashSet<int> skinIds = new HashSet<int>();
            //PetFormManager ins = ResetableSingleTon<PetFormManager>.Ins;
            //int showPetIdFromCfg = ins.GetShowPetIdFromCfg(petId);
            //AddSkinInfos(showPetIdFromCfg, result, skinIds);
            //int[] petsFromCfg = ins.GetPetsFromCfg(showPetIdFromCfg);
            //if (petsFromCfg != null)
            //{
            //    int[] array = petsFromCfg;
            //    foreach (int petId2 in array)
            //    {
            //        AddSkinInfos(petId2, result, skinIds);
            //    }
            //}
            //AddSkinInfos(petId, result, skinIds);
            return result;
        }

        private void AddSkinInfos(int petId, List<PetSkinInfo> result, HashSet<int> skinIds)
        {
            List<PetSkinInfo> value;
            if (!s_DataMapByPetId.TryGetValue(petId, out value))
            {
                return;
            }
            for (int i = 0; i < value.Count; i++)
            {
                if (skinIds.Add(value[i].id))
                {
                    result.Add(value[i]);
                }
            }
        }

        public bool IsSkinApplicableToPet(int skinId, int petId)
        {
            //PetSkinInfo skinInfo = getSkinInfo(skinId);
            //if (petId <= 0 || ((skinInfo != null) ? skinInfo.monIDs : null) == null)
            //{
            //    return false;
            //}
            //PetFormManager ins = ResetableSingleTon<PetFormManager>.Ins;
            //int showPetIdFromCfg = ins.GetShowPetIdFromCfg(petId);
            //int[] monIDs = skinInfo.monIDs;
            //foreach (int petId2 in monIDs)
            //{
            //    if (ins.GetShowPetIdFromCfg(petId2) == showPetIdFromCfg)
            //    {
            //        return true;
            //    }
            //}
            return false;
        }

        //public static HandbookSkinType GetHandbookSkinType(PetSkinInfo info)
        //{
        //    if (info.type == 0)
        //    {
        //        return HandbookSkinType.经典;
        //    }
        //    if (info.type == 2)
        //    {
        //        return HandbookSkinType.史诗;
        //    }
        //    if (info.type == 3)
        //    {
        //        return HandbookSkinType.传说;
        //    }
        //    if (TypeArr4Limit.Contains(info.type))
        //    {
        //        return HandbookSkinType.限定;
        //    }
        //    if (info.type == 14)
        //    {
        //        return HandbookSkinType.神话;
        //    }
        //    if (info.type == 20)
        //    {
        //        return HandbookSkinType.至臻;
        //    }
        //    return HandbookSkinType.所有;
        //}

        public PetSkinInfo getSkinInfo(int id)
        {
            id = PetSkinForm.GetSkinId(id);
            PetSkinInfo value;
            if (!s_DataMap.TryGetValue(id, out value))
            {
                return null;
            }
            return value;
        }

        public string getTypeCn(int type)
        {
            if (type < 0 || type >= typeMapCn.Count)
            {
                return "经典";
            }
            return typeMapCn[type];
        }

        public int getSkinPetId(int skinId, int petId = 0)
        {
            skinId = PetSkinForm.GetSkinId(skinId);
            if (petId == 0)
            {
                PetSkinInfo skinInfo = getSkinInfo(skinId);
                if (skinInfo != null)
                {
                    return skinInfo.skinPetId;
                }
            }
            if (skinId != 0)
            {
                PetSkinInfo skinInfo2 = getSkinInfo(skinId);
                if (skinInfo2 != null && IsSkinApplicableToPet(skinId, petId))
                {
                    petId = skinInfo2.skinPetId;
                }
            }
            return petId;
        }

        public List<PetSkinInfo> getAllSkin()
        {
            return s_DataMap.Values.ToList();
        }

        public PetSkinInfo getPetDefaultSkin(int petId)
        {
            return new PetSkinInfo
            {
                monIDs = [petId],
                name = ResetableSingleTon<PetXMLInfo>.Ins.getName(petId),
                skinPetId = petId,
                type = 9999
            };
        }
    }
}
