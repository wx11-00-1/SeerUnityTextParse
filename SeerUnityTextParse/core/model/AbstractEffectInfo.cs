using System;
using System.Collections.Generic;
using System.Text;

namespace core.model
{
	// Token: 0x02001914 RID: 6420
	public class AbstractEffectInfo
	{
		// Token: 0x0600CA0F RID: 51727 RVA: 0x003AE498 File Offset: 0x003AC698
		public AbstractEffectInfo()
		{
			this.propDict[0] = "攻击";
			this.propDict[1] = "防御";
			this.propDict[2] = "特攻";
			this.propDict[3] = "特防";
			this.propDict[4] = "速度";
			this.propDict[5] = "命中";
			this.statusDict[0] = "麻痹";
			this.statusDict[1] = "中毒";
			this.statusDict[2] = "烧伤";
			this.statusDict[3] = "吸取对方的体力";
			this.statusDict[4] = "被对方吸取体力";
			this.statusDict[5] = "冻伤";
			this.statusDict[6] = "害怕";
			this.statusDict[7] = "疲惫";
			this.statusDict[8] = "睡眠";
			this.statusDict[9] = "石化";
			this.statusDict[10] = "混乱";
			this.statusDict[11] = "衰弱";
			this.statusDict[12] = "山神守护";
			this.statusDict[13] = "易燃";
			this.statusDict[14] = "狂暴";
			this.statusDict[15] = "冰封";
			this.statusDict[16] = "流血";
			this.statusDict[17] = "免疫能力下降";
			this.statusDict[18] = "免疫异常状态";
			this.statusDict[19] = "瘫痪";
			this.statusDict[20] = "失明";
			this.statusDict[21] = "抵抗异常";
			this.statusDict[22] = "焚烬";
			this.statusDict[23] = "诅咒";
			this.statusDict[27] = "感染";
			this.statusDict[28] = "束缚";
			this.statusDict[29] = "失神";
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x0600CA10 RID: 51728 RVA: 0x003AE6F8 File Offset: 0x003AC8F8
		public int argsNum
		{
			get
			{
				return this.m_ArgsNum;
			}
		}

		// Token: 0x0600CA11 RID: 51729 RVA: 0x003AE700 File Offset: 0x003AC900
		public virtual string getInfo(int[] arrayList = null)
		{
			return string.Empty;
		}

		// Token: 0x0600CA12 RID: 51730 RVA: 0x003AE708 File Offset: 0x003AC908
		public string getPropertyStr(int[] a, bool forceMinus = false)
		{
			this.sb.Clear();
			int num = 0;
			while (num < 6 && num < a.Length)
			{
				int num2 = a[num];
				if (num2 != 0)
				{
					this.sb.Append(this.propDict[num]);
					if (forceMinus)
					{
						this.sb.Append(-a[num]);
					}
					else
					{
						this.sb.Append((num2 > 0) ? "+" : string.Empty);
						this.sb.Append(a[num]);
					}
					this.sb.Append("，");
				}
				num++;
			}
			this.sb.Remove(this.sb.Length - 1, 1);
			return this.sb.ToString();
		}

		// Token: 0x0400DEB1 RID: 57009
		protected int m_ArgsNum;

		// Token: 0x0400DEB2 RID: 57010
		protected string[] propDict = new string[6];

		// Token: 0x0400DEB3 RID: 57011
		protected Dictionary<int, string> statusDict = new Dictionary<int, string>();

		// Token: 0x0400DEB4 RID: 57012
		private StringBuilder sb = new StringBuilder();
	}
}
