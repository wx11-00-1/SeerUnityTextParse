using System;
using System.Collections.Generic;

namespace core.config.petBody
{
	// Token: 0x02002779 RID: 10105
	public class PetBodyInfos
	{
		// Token: 0x06013DC0 RID: 81344 RVA: 0x005363FC File Offset: 0x005345FC
		public static Dictionary<PetBodyInfoManager.PetBodyPositionType, PetBodyInfos> Parse(byte[] bytes)
		{
			int num = 0;
			int num2 = ByteUtil.ReadSignedInt(bytes, ref num);
			Dictionary<PetBodyInfoManager.PetBodyPositionType, PetBodyInfos> dictionary = new Dictionary<PetBodyInfoManager.PetBodyPositionType, PetBodyInfos>(num2);
			for (int i = 0; i < num2; i++)
			{
				PetBodyInfos petBodyInfos = new PetBodyInfos();
				petBodyInfos.petBodyPositionType = (PetBodyInfoManager.PetBodyPositionType)ByteUtil.ReadSignedInt(bytes, ref num);
				int num3 = ByteUtil.ReadSignedInt(bytes, ref num);
				petBodyInfos.infos = new Dictionary<int, PetBodyInfo>(num3);
				for (int j = 0; j < num3; j++)
				{
					PetBodyInfo petBodyInfo = new PetBodyInfo();
					petBodyInfo.Parse(bytes, ref num);
					petBodyInfos.infos.Add(petBodyInfo.petId, petBodyInfo);
				}
				dictionary.Add(petBodyInfos.petBodyPositionType, petBodyInfos);
			}
			return dictionary;
		}

		// Token: 0x06013DC1 RID: 81345 RVA: 0x0053649C File Offset: 0x0053469C
		public static byte[] ToBytes(Dictionary<PetBodyInfoManager.PetBodyPositionType, PetBodyInfos> infos)
		{
			List<byte> list = new List<byte>();
			list.AddRange(BitConverter.GetBytes(infos.Count));
			foreach (KeyValuePair<PetBodyInfoManager.PetBodyPositionType, PetBodyInfos> keyValuePair in infos)
			{
				list.AddRange(BitConverter.GetBytes((int)keyValuePair.Key));
				list.AddRange(BitConverter.GetBytes(keyValuePair.Value.infos.Count));
				foreach (KeyValuePair<int, PetBodyInfo> keyValuePair2 in keyValuePair.Value.infos)
				{
					list.AddRange(BitConverter.GetBytes(keyValuePair2.Value.petId));
					list.AddRange(BitConverter.GetBytes(keyValuePair2.Value.position.x));
					list.AddRange(BitConverter.GetBytes(keyValuePair2.Value.position.y));
					list.AddRange(BitConverter.GetBytes(keyValuePair2.Value.scale));
				}
			}
			return list.ToArray();
		}

		// Token: 0x04013240 RID: 78400
		public PetBodyInfoManager.PetBodyPositionType petBodyPositionType;

		// Token: 0x04013241 RID: 78401
		public Dictionary<int, PetBodyInfo> infos;
	}
}
