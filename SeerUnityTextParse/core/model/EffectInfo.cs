using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using common;
using core.config;
using core.manager;

namespace core.model
{
	// Token: 0x02001927 RID: 6439
	public class EffectInfo : AbstractEffectInfo
	{
		// Token: 0x0600CAB4 RID: 51892 RVA: 0x003B0614 File Offset: 0x003AE814
		public EffectInfo(int argsNum, string msg, int[] param)
		{
			this.m_ArgsNum = argsNum;
			this.m_Msg = msg;
			this.m_Param = param;
			this.m_FightTypeDic[0] = "物理攻击";
			this.m_FightTypeDic[1] = "特殊攻击";
			this.m_FightTypeDic[2] = "物理攻击和特殊攻击";
		}

		// Token: 0x0600CAB5 RID: 51893 RVA: 0x003B067C File Offset: 0x003AE87C
		public void init(int argsNum, string msg, int[] param)
		{
			this.m_ArgsNum = argsNum;
			this.m_Msg = msg;
			this.m_Param = param;
			this.m_FightTypeDic[0] = "物理攻击";
			this.m_FightTypeDic[1] = "特殊攻击";
			this.m_FightTypeDic[2] = "物理攻击和特殊攻击";
		}

		// Token: 0x0600CAB6 RID: 51894 RVA: 0x003B06D4 File Offset: 0x003AE8D4
		public override string getInfo(int[] array = null)
		{
			string[] array2 = new string[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = array[i].ToString();
			}
			string text = this.m_Msg;
			if (this.m_Param != null && this.m_Param.Length != 0)
			{
				int num = this.m_Param.Length / 3;
				int j = 0;
				while (j < num)
				{
					int num2 = this.m_Param[j * 3];
					int num3 = this.m_Param[j * 3 + 1];
					int num4 = this.m_Param[j * 3 + 2];
					string text2 = string.Empty;
					if (num2 <= 16)
					{
						if (num2 != 0)
						{
							if (num2 != 14)
							{
								if (num2 != 16)
								{
									goto IL_1C1;
								}
								string text3 = string.Empty;
								for (int k = 0; k < 6; k++)
								{
									if (array[num3 + k] > 0)
									{
										if (text3.Length > 0)
										{
											text3 += "、";
										}
										text3 += this.getCommParamStr(num2, k);
									}
								}
								array2[num3] = text2 + text3;
							}
							else if (array[num3] >= 0)
							{
								array2[num3] = "+" + array[num3].ToString();
							}
						}
						else
						{
							int[] subArray = RuntimeHelpers.GetSubArray<int>(array, new Range(num3, num3 + 6));
							text2 = base.getPropertyStr(subArray, false);
							array2[num3] = text2;
						}
					}
					else if (num2 != 19)
					{
						if (num2 != 22)
						{
							if (num2 != 24)
							{
								goto IL_1C1;
							}
							int[] subArray2 = RuntimeHelpers.GetSubArray<int>(array, new Range(num3, num3 + 6));
							text2 = base.getPropertyStr(subArray2, true);
							array2[num3] = text2;
						}
						else
						{
							array2[num3] = ResetableSingleTon<SkillXMLInfo>.Ins.petTypeNameCN(array[num3]);
						}
					}
					IL_1D5:
					j++;
					continue;
					IL_1C1:
					text2 = this.getCommParamStr(num2, array[num3]);
					array2[num3] = text2;
					goto IL_1D5;
				}
			}
			if (array != null)
			{
				for (int j = 0; j < array.Length; j++)
				{
					text = text.Replace("{" + j.ToString() + "}", array2[j]);
				}
			}
			return text;
		}

		// Token: 0x0600CAB7 RID: 51895 RVA: 0x003B08F4 File Offset: 0x003AEAF4
		private string getCommParamStr(int id, int index)
		{
			//string empty = string.Empty;
			//string[] effectParamType = ResetableSingleTon<EffectInfoManager>.Ins.getEffectParamType(id);
			//return empty + effectParamType[index];
			return "";
		}

		// Token: 0x0400DF76 RID: 57206
		private string m_Msg;

		// Token: 0x0400DF77 RID: 57207
		private int[] m_Param;

		// Token: 0x0400DF78 RID: 57208
		private Dictionary<int, string> m_FightTypeDic = new Dictionary<int, string>();
	}
}
