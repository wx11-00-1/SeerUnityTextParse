using System;
using System.Collections.Generic;
using common;
using core.model;

namespace core.config
{
	public static class PetSkinForm
	{
		public const int FormStep = 100000;

		public const int CustomDisplayFormShift = 21;

		public const int CustomDisplayIdMask = 2097151;

		public const int MaxCustomDisplayFormIndex = 7;

		private const int CustomSkinIdOffset = 1400000;

		public static int GetSkinId(int value)
		{
			return value % 100000;
		}

		public static int GetFormIndex(int value)
		{
			return value / 100000;
		}

		public static int Encode(int skinId, int formIndex)
		{
			return formIndex * 100000 + GetSkinId(skinId);
		}

		public static int[] ParseResourceIds(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				return Array.Empty<int>();
			}
			string[] array = value.Split(';', StringSplitOptions.None);
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				int result;
				if (int.TryParse(array[i], out result) && result > 0)
				{
					array2[i] = result;
				}
			}
			return array2;
		}

		public static int[] GetResourceIds(int petId, int skinId)
		{
			if (!ResetableSingleTon<PetSkinPoly>.Ins.IsLoaded)
			{
				return Array.Empty<int>();
			}
			return FindResourceIds(petId, skinId, ResetableSingleTon<PetSkinXMLInfo>.Ins.getSkinPetId(GetSkinId(skinId), petId), ResetableSingleTon<PetSkinPoly>.Ins.getItems());
		}

		public static int[] FindResourceIds(int petId, int skinId, int originalId, IEnumerable<IPetSkinPolyInfo> items)
		{
			foreach (IPetSkinPolyInfo item in items)
			{
				int skinId2 = GetSkinId(skinId);
				if ((skinId2 == 0 && item.petid == petId && item.skinid == 0) || (skinId2 > 0 && item.skinid == skinId2))
				{
					int[] array = ParseResourceIds(item.replaceid);
					int[] array2 = new int[array.Length + 1];
					array2[0] = originalId;
					Array.Copy(array, 0, array2, 1, array.Length);
					return array2;
				}
			}
			return Array.Empty<int>();
		}

		public static int ResolveResourceId(int fallback, int encodedSkinId, int[] resourceIds)
		{
			int formIndex = GetFormIndex(encodedSkinId);
			if (formIndex < 0 || formIndex >= resourceIds.Length || resourceIds[formIndex] <= 0)
			{
				return fallback;
			}
			return resourceIds[formIndex];
		}

		public static int GetDisplayPetId(int petId, int encodedSkinId)
		{
			return ResolveResourceId(ResetableSingleTon<PetSkinXMLInfo>.Ins.getSkinPetId(GetSkinId(encodedSkinId), petId), encodedSkinId, GetResourceIds(petId, encodedSkinId));
		}

		public static int EncodeCustomDisplayId(int originalShowId, int formIndex)
		{
			if (originalShowId <= 0 || originalShowId > 2097151)
			{
				throw new ArgumentOutOfRangeException("originalShowId");
			}
			if (formIndex < 0 || formIndex > 7)
			{
				throw new ArgumentOutOfRangeException("formIndex");
			}
			return originalShowId | (formIndex << 21);
		}

		public static int GetCustomOriginalId(int showId)
		{
			return showId & 0x1FFFFF;
		}

		public static int GetCustomFormIndex(int showId)
		{
			return (showId >> 21) & 7;
		}

		public static int GetCustomDisplayId(int petId, int encodedSkinId)
		{
			int skinId = GetSkinId(encodedSkinId);
			return EncodeCustomDisplayId((skinId == 0) ? petId : (1400000 + skinId), GetFormIndex(encodedSkinId));
		}

		public static int GetCustomDisplayPetId(int id)
		{
			int customOriginalId = GetCustomOriginalId(id);
			int num = ((customOriginalId >= 1400000) ? (customOriginalId - 1400000) : 0);
			int petId = customOriginalId;
			if (num > 0)
			{
				PetSkinInfo skinInfo = ResetableSingleTon<PetSkinXMLInfo>.Ins.getSkinInfo(num);
				if (skinInfo == null || skinInfo.monIDs == null || skinInfo.monIDs.Length == 0)
				{
					return ResetableSingleTon<PetXMLInfo>.Ins.getRealId(customOriginalId);
				}
				petId = skinInfo.monIDs[0];
			}
			return GetDisplayPetId(petId, Encode(num, GetCustomFormIndex(id)));
		}

		public static List<PetSkinInfo> GetForms(int petId, PetSkinInfo info)
		{
			List<PetSkinInfo> list = new List<PetSkinInfo>();
			int[] resourceIds = GetResourceIds(petId, info.id);
			for (int i = 0; i < resourceIds.Length; i++)
			{
				if (resourceIds[i] > 0)
				{
					list.Add(new PetSkinInfo
					{
						id = Encode(info.id, i),
						type = info.type,
						monIDs = info.monIDs,
						skinPetId = resourceIds[i],
						name = info.name,
						config = info.config
					});
				}
			}
			return list;
		}
	}
}
