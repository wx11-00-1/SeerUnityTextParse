using System;
using System.Collections.Generic;

namespace core.config.petBody
{
	public class PetBodyInfos
	{
		public PetBodyInfoManager.PetBodyPositionType petBodyPositionType;

		public Dictionary<int, PetBodyInfo> infos;

		public static Dictionary<PetBodyInfoManager.PetBodyPositionType, PetBodyInfos> Parse(byte[] bytes)
		{
			int index = 0;
			int num = ByteUtil.ReadSignedInt(bytes, ref index);
			Dictionary<PetBodyInfoManager.PetBodyPositionType, PetBodyInfos> dictionary = new Dictionary<PetBodyInfoManager.PetBodyPositionType, PetBodyInfos>(num);
			for (int i = 0; i < num; i++)
			{
				PetBodyInfos petBodyInfos = new PetBodyInfos();
				petBodyInfos.petBodyPositionType = (PetBodyInfoManager.PetBodyPositionType)ByteUtil.ReadSignedInt(bytes, ref index);
				int num2 = ByteUtil.ReadSignedInt(bytes, ref index);
				petBodyInfos.infos = new Dictionary<int, PetBodyInfo>(num2);
				for (int j = 0; j < num2; j++)
				{
					PetBodyInfo petBodyInfo = new PetBodyInfo();
					petBodyInfo.Parse(bytes, ref index);
					petBodyInfos.infos.Add(petBodyInfo.petId, petBodyInfo);
				}
				dictionary.Add(petBodyInfos.petBodyPositionType, petBodyInfos);
			}
			return dictionary;
		}

		public static byte[] ToBytes(Dictionary<PetBodyInfoManager.PetBodyPositionType, PetBodyInfos> infos)
		{
			List<byte> list = new List<byte>();
			list.AddRange(BitConverter.GetBytes(infos.Count));
			foreach (KeyValuePair<PetBodyInfoManager.PetBodyPositionType, PetBodyInfos> info in infos)
			{
				list.AddRange(BitConverter.GetBytes((int)info.Key));
				list.AddRange(BitConverter.GetBytes(info.Value.infos.Count));
				foreach (KeyValuePair<int, PetBodyInfo> info2 in info.Value.infos)
				{
					list.AddRange(BitConverter.GetBytes(info2.Value.petId));
					list.AddRange(BitConverter.GetBytes(info2.Value.position.x));
					list.AddRange(BitConverter.GetBytes(info2.Value.position.y));
					list.AddRange(BitConverter.GetBytes(info2.Value.scale));
				}
			}
			return list.ToArray();
		}
	}
}
