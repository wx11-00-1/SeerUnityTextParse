using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using common;
using core.config.hide_moves;
using core.config.moves;
using core.config.move_stones;
using core.config.skillTypes;
using core.config.sp_hide_moves;






namespace core.config
{
	// Token: 0x02001EBF RID: 7871
	public class SkillXMLInfo : ConfigManagerSingleton<SkillXMLInfo>
	{
		// Token: 0x0600EB6C RID: 60268 RVA: 0x003ED684 File Offset: 0x003EB884
		

		// Token: 0x0600EB6D RID: 60269 RVA: 0x003ED6F0 File Offset: 0x003EB8F0

		// Token: 0x0600EB6E RID: 60270 RVA: 0x003ED730 File Offset: 0x003EB930
		

		// Token: 0x0600EB6F RID: 60271 RVA: 0x003ED774 File Offset: 0x003EB974
		public string getName(int id, int skinId = 0)
		{
			string result = string.Empty;
			IMoveStoneItem moveStoneItem;
			if (id <= this.TYPE_NUMBER)
			{
				IMoveItem moveItem;
				if (this.movesMap.TryGetValue(id, out moveItem))
				{
					result = moveItem.Name;
					if (skinId != 0)
					{
						string skillNameBySkinId = ResetableSingleTon<SkillNameReplaceXmlInfo>.Ins.getSkillNameBySkinId(skinId, id);
						if (skillNameBySkinId != "")
						{
							result = skillNameBySkinId;
						}
					}
				}
			}
			else if (this.s_MoveStoneMap.TryGetValue(this.getSkillIdInXML(id), out moveStoneItem))
			{
				result = moveStoneItem.Name;
			}
			return result;
		}

		// Token: 0x0600EB70 RID: 60272 RVA: 0x003ED7E6 File Offset: 0x003EB9E6
		[Obsolete("不需要，返回的就是id")]
		public int getRealId(int id)
		{
			return id;
		}

		// Token: 0x0600EB71 RID: 60273 RVA: 0x003ED7EC File Offset: 0x003EB9EC
		public int getDamage(int id)
		{
			int result = 0;
			IMoveStoneItem moveStoneItem;
			if (id <= this.TYPE_NUMBER)
			{
				IMoveItem moveItem;
				if (this.movesMap.TryGetValue(id, out moveItem) && moveItem.Power > 0)
				{
					result = moveItem.Power;
				}
			}
			else if (this.s_MoveStoneMap.TryGetValue(this.getSkillIdInXML(id), out moveStoneItem))
			{
				result = moveStoneItem.Power;
			}
			return result;
		}

		// Token: 0x0600EB72 RID: 60274 RVA: 0x003ED844 File Offset: 0x003EBA44
		public int getCommonSkill(int id)
		{
			int num = 0;
			if (id <= this.TYPE_NUMBER)
			{
				IMoveItem moveItem;
				if (!this.movesMap.TryGetValue(id, out moveItem))
				{
					return 0;
				}
				int num2 = 0;
				int num3 = (moveItem.Category > 0) ? moveItem.Category : 0;
				if (moveItem.ordinary > 0)
				{
					num2 = moveItem.ordinary;
				}
				if (num2 == 1)
				{
					return 0;
				}
				if (num == 0 && num3 > 0)
				{
					if (num3 == 4)
					{
						num = 999;
					}
					else if ((num3 == 1 || num3 == 2) && moveItem.Type > 0)
					{
						num = moveItem.Type;
					}
				}
			}
			return num;
		}

		// Token: 0x0600EB73 RID: 60275 RVA: 0x003ED8C8 File Offset: 0x003EBAC8
		public int getPP(int id)
		{
			int result = 0;
			IMoveStoneItem moveStoneItem;
			if (id <= this.TYPE_NUMBER)
			{
				IMoveItem moveItem;
				if (this.movesMap.TryGetValue(id, out moveItem) && moveItem.MaxPP > 0)
				{
					result = moveItem.MaxPP;
				}
			}
			else if (this.s_MoveStoneMap.TryGetValue(this.getSkillIdInXML(id), out moveStoneItem))
			{
				result = moveStoneItem.MaxPP;
			}
			return result;
		}

		// Token: 0x0600EB74 RID: 60276 RVA: 0x003ED920 File Offset: 0x003EBB20
		public int getEnHideSkillPetID(int id)
		{
			IMoveItem moveItem;
			if (this.movesMap.TryGetValue(id, out moveItem))
			{
				return moveItem.MonID;
			}
			return 0;
		}

		// Token: 0x0600EB75 RID: 60277 RVA: 0x003ED948 File Offset: 0x003EBB48
		public int[] getSideEffects(int id)
		{
			IMoveItem moveItem;
			if (id <= this.TYPE_NUMBER && this.movesMap.TryGetValue(id, out moveItem))
			{
				return moveItem.SideEffect;
			}
			int num = (int)Math.Floor((double)((float)(id % this.TYPE_NUMBER) / 1000f));
			foreach (IMoveStoneItem moveStoneItem in this.s_SkillStoneXMLList)
			{
				if (moveStoneItem.ID == this.getSkillIdInXML(id))
				{
					foreach (IMoveEffectItem moveEffectItem in moveStoneItem.MoveEffect)
					{
						if (moveEffectItem.ID == num)
						{
							return moveEffectItem.SideEffect;
						}
					}
				}
			}
			return new int[0];
		}

		// Token: 0x0600EB76 RID: 60278 RVA: 0x003ED9F4 File Offset: 0x003EBBF4
		//public int[] getSideEffectArgs(int id)
		//{
		//	IMoveItem moveItem;
		//	if (id > this.TYPE_NUMBER || !this.movesMap.TryGetValue(id, out moveItem))
		//	{
		//		int num = (int)Math.Floor((double)((float)(id % this.TYPE_NUMBER) / 1000f));
		//		foreach (IMoveStoneItem moveStoneItem in this.s_SkillStoneXMLList)
		//		{
		//			if (moveStoneItem.ID == this.getSkillIdInXML(id))
		//			{
		//				foreach (IMoveEffectItem moveEffectItem in moveStoneItem.MoveEffect)
		//				{
		//					if (moveEffectItem.ID == num)
		//					{
		//						return moveEffectItem.SideEffectArg;
		//					}
		//				}
		//			}
		//		}
		//		return ArrayPool<int>.Shared.Rent(0);
		//	}
		//	if (moveItem.SideEffectArg == null)
		//	{
		//		return ArrayPool<int>.Shared.Rent(0);
		//	}
		//	return moveItem.SideEffectArg;
		//}

		// Token: 0x0600EB77 RID: 60279 RVA: 0x003EDAB8 File Offset: 0x003EBCB8
		public int[] getFriendSideEffects(int id)
		{
			IMoveItem moveItem;
			if (id <= this.TYPE_NUMBER && this.movesMap.TryGetValue(id, out moveItem))
			{
				return moveItem.FriendSideEffect;
			}
			return new int[0];
		}

		// Token: 0x0600EB78 RID: 60280 RVA: 0x003EDAEC File Offset: 0x003EBCEC
		public int[] getFriendSideEffectArgs(int id)
		{
			IMoveItem moveItem;
			if (id <= this.TYPE_NUMBER && this.movesMap.TryGetValue(id, out moveItem))
			{
				return moveItem.FriendSideEffectArg;
			}
			return new int[0];
		}

		// Token: 0x0600EB79 RID: 60281 RVA: 0x003EDB20 File Offset: 0x003EBD20
		public int getCategory(int id)
		{
			int result = 0;
			if (id <= this.TYPE_NUMBER)
			{
				IMoveItem moveItem;
				if (this.movesMap.TryGetValue(id, out moveItem) && moveItem.Category > 0)
				{
					result = moveItem.Category;
				}
			}
			else
			{
				result = (int)Math.Floor((double)((float)(id / this.TYPE_NUMBER)));
			}
			return result;
		}

		// Token: 0x0600EB7A RID: 60282 RVA: 0x003EDB6C File Offset: 0x003EBD6C
		public string getCategoryName(int id)
		{
			return this.s_CategoryNames[this.getCategory(id)];
		}

		// Token: 0x0600EB7B RID: 60283 RVA: 0x003EDB7C File Offset: 0x003EBD7C
		public string getCategoryColor(int id)
		{
			return this.s_CategoryColors[this.getCategory(id)];
		}

		// Token: 0x0600EB7C RID: 60284 RVA: 0x003EDB8C File Offset: 0x003EBD8C
		public int getTypeID(int id)
		{
			if (id > this.TYPE_NUMBER)
			{
				return this.s_MoveStoneMap[this.getSkillIdInXML(id)].Type;
			}
			IMoveItem moveItem;
			if (this.movesMap.TryGetValue(id, out moveItem) && moveItem.Type > 0)
			{
				return moveItem.Type;
			}
			return 0;
		}

		// Token: 0x0600EB7D RID: 60285 RVA: 0x003EDBDC File Offset: 0x003EBDDC
		public string getInfo(int id)
		{
			if (id > this.TYPE_NUMBER)
			{
				return string.Empty;
			}
			IMoveItem moveItem;
			if (this.movesMap.TryGetValue(id, out moveItem) && moveItem.info != null)
			{
				return moveItem.info;
			}
			return string.Empty;
		}

		// Token: 0x0600EB7E RID: 60286 RVA: 0x003EDC1C File Offset: 0x003EBE1C
		public string petTypeNameCN(int typeID)
		{
			core.config.skillTypes.IItemItem itemItem;
			if (this.s_TypeMap.TryGetValue(typeID, out itemItem))
			{
				return itemItem.cn;
			}
			return string.Empty;
		}

		// Token: 0x0600EB7F RID: 60287 RVA: 0x003EDC48 File Offset: 0x003EBE48
		public string[] petTypeNameEN(int typeID)
		{
			core.config.skillTypes.IItemItem itemItem;
			if (this.s_TypeMap.TryGetValue(typeID, out itemItem))
			{
				return itemItem.en;
			}
			return new string[0];
		}

		// Token: 0x0600EB80 RID: 60288 RVA: 0x003EDC72 File Offset: 0x003EBE72
		public List<int> getAllTypes()
		{
			return this.s_AllTypes;
		}

		// Token: 0x0600EB81 RID: 60289 RVA: 0x003EDC7A File Offset: 0x003EBE7A
		public int getTypeKind(int typeID)
		{
			if (this.petTypeNameEN(typeID).Length < 2)
			{
				return 1;
			}
			return 2;
		}

		// Token: 0x0600EB82 RID: 60290 RVA: 0x003EDC8C File Offset: 0x003EBE8C
		public int getGpFtSkillType(int id)
		{
			IMoveItem moveItem;
			if (id <= this.TYPE_NUMBER && this.movesMap.TryGetValue(id, out moveItem) && moveItem.AtkType > 0)
			{
				return moveItem.AtkType;
			}
			return 2;
		}

		// Token: 0x0600EB83 RID: 60291 RVA: 0x003EDCC4 File Offset: 0x003EBEC4
		public int getGpFtSkillAtkNum(int id)
		{
			IMoveItem moveItem;
			if (id <= this.TYPE_NUMBER && this.movesMap.TryGetValue(id, out moveItem) && moveItem.AtkNum > 0)
			{
				return moveItem.AtkNum;
			}
			return 1;
		}

		// Token: 0x0600EB84 RID: 60292 RVA: 0x003EDCFB File Offset: 0x003EBEFB
		public int getSkillIdInXML(int id)
		{
			return id % 1000;
		}

		// Token: 0x0600EB85 RID: 60293 RVA: 0x003EDD04 File Offset: 0x003EBF04
		public int getHideSkillId(int pid)
		{
			int evolvesTo = ResetableSingleTon<PetXMLInfo>.Ins.getEvolvesTo(pid);
			if (evolvesTo > 0)
			{
				pid = evolvesTo;
			}
			List<ValueTuple<int, int>> list;
			if (this.hideMovesMap.TryGetValue(pid, out list))
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].Item2 == 0)
					{
						return list[i].Item1;
					}
				}
			}
			return 0;
		}

		// Token: 0x0600EB86 RID: 60294 RVA: 0x003EDD64 File Offset: 0x003EBF64
		public List<int> getAllHideSkills(int pid)
		{
			int evolvesTo = ResetableSingleTon<PetXMLInfo>.Ins.getEvolvesTo(pid);
			if (evolvesTo > 0)
			{
				pid = evolvesTo;
			}
			List<int> list = new List<int>();
			List<ValueTuple<int, int>> list2;
			if (this.hideMovesMap.TryGetValue(pid, out list2))
			{
				for (int i = 0; i < list2.Count; i++)
				{
					list.Add(list2[i].Item1);
				}
			}
			return list;
		}

		// Token: 0x0600EB87 RID: 60295 RVA: 0x003EDDC0 File Offset: 0x003EBFC0
		public List<int> getLearnHideSkills(int pid)
		{
			int evolvesTo = ResetableSingleTon<PetXMLInfo>.Ins.getEvolvesTo(pid);
			if (evolvesTo > 0)
			{
				pid = evolvesTo;
			}
			List<int> list = new List<int>();
			List<ValueTuple<int, int>> list2;
			if (this.hideMovesMap.TryGetValue(pid, out list2))
			{
				for (int i = 0; i < list2.Count; i++)
				{
					if (list2[i].Item2 == 1)
					{
						list.Add(list2[i].Item1);
					}
				}
			}
			return list;
		}

		// Token: 0x0600EB88 RID: 60296 RVA: 0x003EDE2C File Offset: 0x003EC02C
		public bool isHideSkillId(int pid, int sid)
		{
			int evolvesTo = ResetableSingleTon<PetXMLInfo>.Ins.getEvolvesTo(pid);
			if (evolvesTo > 0)
			{
				pid = evolvesTo;
			}
			List<ValueTuple<int, int>> list;
			if (this.hideMovesMap.TryGetValue(pid, out list))
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].Item1 == sid)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600EB89 RID: 60297 RVA: 0x003EDE80 File Offset: 0x003EC080
		public bool isHideSkillId(int sid)
		{
			return false;
		}

		// Token: 0x0600EB8A RID: 60298 RVA: 0x003EDEB8 File Offset: 0x003EC0B8
		public bool isOHideSkillId(int pid, int sid)
		{
			int evolvesTo = ResetableSingleTon<PetXMLInfo>.Ins.getEvolvesTo(pid);
			if (evolvesTo > 0)
			{
				pid = evolvesTo;
			}
			List<ValueTuple<int, int>> list;
			if (this.hideMovesMap.TryGetValue(pid, out list))
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].Item1 == sid && list[i].Item2 == 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600EB8B RID: 60299 RVA: 0x003EDF1C File Offset: 0x003EC11C
		public IMoveItem getSkillObj(int id)
		{
			IMoveItem result;
			if (!this.movesMap.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600EB8C RID: 60300 RVA: 0x003EDF3C File Offset: 0x003EC13C
		public ISpMovesItem getSPHideMovesInfo(int id)
		{
			ISpMovesItem result;
			if (!this.s_SpHideMovesMap.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600EB8D RID: 60301 RVA: 0x003EDF5C File Offset: 0x003EC15C
		public IMoveStoneItem GetMoveStoneItem(int id)
		{
			IMoveStoneItem result;
			if (!this.s_MoveStoneMap.TryGetValue(id, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600EB8E RID: 60302 RVA: 0x003EDF7C File Offset: 0x003EC17C
		public Dictionary<int, IMoveStoneItem> GetMoveStoneMap()
		{
			return this.s_MoveStoneMap;
		}

		// Token: 0x0600EB8F RID: 60303 RVA: 0x003EDF84 File Offset: 0x003EC184
		public SkillStudyType GetSkillStudyType(string itemName)
		{
			if (itemName == "完成精灵觉醒")
			{
				return SkillStudyType.Adv;
			}
			if (itemName == "完成元素觉醒")
			{
				return SkillStudyType.Sp;
			}
			if (!(itemName == "参与活动获得"))
			{
				return SkillStudyType.Item;
			}
			return SkillStudyType.Activity;
		}

		// Token: 0x0600EB90 RID: 60304 RVA: 0x003EDFB8 File Offset: 0x003EC1B8
		public core.config.hide_moves.IItemItem GetHideMove(int petId, int moveId)
		{
			Dictionary<int, core.config.hide_moves.IItemItem> dictionary;
			if (!this.hideMovesItemMap.TryGetValue(petId, out dictionary))
			{
				return null;
			}
			core.config.hide_moves.IItemItem result;
			if (!dictionary.TryGetValue(moveId, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600EB91 RID: 60305 RVA: 0x003EDFE8 File Offset: 0x003EC1E8
		//public string ParseAniName(int skillId, int petId, int skinId, bool needRandom = true, SkeletonAnimation spine = null, SwfClipController swfClip = null)
		//{
		//	string replaceAction = ResetableSingleTon<PetFightSkinSkillReplaceXMLInfo>.Ins.getReplaceAction(skinId, skillId, petId);
		//	string text = string.Empty;
		//	if (replaceAction.IsValidStr())
		//	{
		//		text = replaceAction;
		//	}
		//	else if (skillId == 10825 || (skillId == 12551 && petId == 1069))
		//	{
		//		text = this.ParseDefaultAnim(skillId);
		//	}
		//	else
		//	{
		//		text = string.Format("moves_{0}", skillId);
		//		if (skillId == 36302 || skillId == 36303)
		//		{
		//			text = this.ParseShuangXingAnim(skillId, spine, swfClip, needRandom);
		//		}
		//		else if (this.IsHaveSequenceByName(text, spine, swfClip))
		//		{
		//			int extraSequenceCount = this.GetExtraSequenceCount(text, spine, swfClip);
		//			if (extraSequenceCount > 0)
		//			{
		//				int num = needRandom ? Random.Range(0, extraSequenceCount + 1) : 0;
		//				if (num > 0)
		//				{
		//					text = "moves_" + skillId.ToString() + "_" + num.ToString();
		//				}
		//			}
		//		}
		//		else
		//		{
		//			text = this.ParseDefaultAnim(skillId);
		//		}
		//	}
		//	return text;
		//}

		// Token: 0x0600EB92 RID: 60306 RVA: 0x003EE0C9 File Offset: 0x003EC2C9
		private string ParseDefaultAnim(int skillId)
		{
			return SkillXMLInfo.LABEL_ARRAY[ResetableSingleTon<SkillXMLInfo>.Ins.getCategory(skillId)];
		}

		// Token: 0x0600EB93 RID: 60307 RVA: 0x003EE0E0 File Offset: 0x003EC2E0
		//private bool IsHaveSequenceByName(string name, SkeletonAnimation spine, SwfClipController swfClip)
		//{
		//	if (spine != null)
		//	{
		//		return spine != null && spine.SkeletonDataAsset.GetSkeletonData(false).FindAnimation(name) != null;
		//	}
		//	if (!(swfClip != null))
		//	{
		//		return false;
		//	}
		//	if (swfClip == null)
		//	{
		//		return false;
		//	}
		//	if (swfClip.clip.clip == null)
		//	{
		//		return false;
		//	}
		//	using (List<SwfClipAsset.Sequence>.Enumerator enumerator = swfClip.clip.clip.Sequences.GetEnumerator())
		//	{
		//		while (enumerator.MoveNext())
		//		{
		//			if (enumerator.Current.Name.Equals(name))
		//			{
		//				return true;
		//			}
		//		}
		//	}
		//	return false;
		//}

		// Token: 0x0600EB94 RID: 60308 RVA: 0x003EE1A0 File Offset: 0x003EC3A0
		//private int GetExtraSequenceCount(string name, SkeletonAnimation spine, SwfClipController swfClip)
		//{
		//	if (spine != null)
		//	{
		//		if (spine == null)
		//		{
		//			return 0;
		//		}
		//		int num = 0;
		//		Animation[] items = spine.SkeletonDataAsset.GetSkeletonData(false).Animations.Items;
		//		for (int i = 0; i < items.Length; i++)
		//		{
		//			if (items[i].Name.StartsWith(name))
		//			{
		//				num++;
		//			}
		//		}
		//		return num - 1;
		//	}
		//	else
		//	{
		//		if (!(swfClip != null))
		//		{
		//			return 0;
		//		}
		//		if (swfClip == null)
		//		{
		//			return 0;
		//		}
		//		if (swfClip.clip.clip == null)
		//		{
		//			return 0;
		//		}
		//		int num2 = 0;
		//		using (List<SwfClipAsset.Sequence>.Enumerator enumerator = swfClip.clip.clip.Sequences.GetEnumerator())
		//		{
		//			while (enumerator.MoveNext())
		//			{
		//				if (enumerator.Current.Name.StartsWith(name))
		//				{
		//					num2++;
		//				}
		//			}
		//		}
		//		return num2 - 1;
		//	}
		//}

		// Token: 0x0600EB95 RID: 60309 RVA: 0x003EE28C File Offset: 0x003EC48C
		//private string ParseShuangXingAnim(int skillId, SkeletonAnimation spine, SwfClipController swfClip, bool needRandom = true)
		//{
		//	if (!this.IsHaveSequenceByName("moves_36303_1", spine, swfClip) || !this.IsHaveSequenceByName("moves_36302", spine, swfClip))
		//	{
		//		return this.ParseDefaultAnim(skillId);
		//	}
		//	if ((needRandom ? Random.Range(0, 2) : 0) <= 0)
		//	{
		//		return "moves_36302";
		//	}
		//	return "moves_36303_1";
		//}

		// Token: 0x0400EEE8 RID: 61160
		private List<int> s_AllTypes;

		// Token: 0x0400EEE9 RID: 61161
		private IMoveStoneItem[] s_SkillStoneXMLList;

		// Token: 0x0400EEEA RID: 61162
		private Dictionary<int, core.config.skillTypes.IItemItem> s_TypeMap;

		// Token: 0x0400EEEB RID: 61163
		private Dictionary<int, IMoveStoneItem> s_MoveStoneMap;

		// Token: 0x0400EEEC RID: 61164
		private Dictionary<int, ISpMovesItem> s_SpHideMovesMap = new Dictionary<int, ISpMovesItem>();

		// Token: 0x0400EEED RID: 61165
		private string[] s_CategoryNames = new string[]
		{
			null,
			"物理攻击",
			"特殊攻击",
			null,
			"属性攻击"
		};

		// Token: 0x0400EEEE RID: 61166
		private string[] s_CategoryColors = new string[]
		{
			null,
			"#c56359",
			"#cd82ce",
			null,
			"#7cc363"
		};

		// Token: 0x0400EEEF RID: 61167
		public readonly int TYPE_NUMBER = 100000;

		// Token: 0x0400EEF0 RID: 61168
		public Dictionary<int, IMoveItem> movesMap;

		// Token: 0x0400EEF1 RID: 61169
		//[TupleElementNames(new string[]
		//{
		//	"id",
		//	"o"
		//})]
		public Dictionary<int, List<ValueTuple<int, int>>> hideMovesMap = new Dictionary<int, List<ValueTuple<int, int>>>(163);

		// Token: 0x0400EEF2 RID: 61170
		public Dictionary<int, Dictionary<int, core.config.hide_moves.IItemItem>> hideMovesItemMap = new Dictionary<int, Dictionary<int, core.config.hide_moves.IItemItem>>();

		// Token: 0x0400EEF3 RID: 61171
		private static List<string> LABEL_ARRAY = new List<string>
		{
			string.Empty,
			"attack",
			"sa",
			string.Empty,
			"cp"
		};
	}
}
