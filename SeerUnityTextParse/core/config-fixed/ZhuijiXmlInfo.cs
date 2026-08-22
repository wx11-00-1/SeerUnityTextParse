using System;
using System.Collections.Generic;
using common;
using core.config.addmoves;


namespace core.config
{
	// Token: 0x02001EC5 RID: 7877
	public class ZhuijiXmlInfo : ConfigManagerSingleton<ZhuijiXmlInfo>
	{
		// Token: 0x0600EBBF RID: 60351 RVA: 0x003EEC5B File Offset: 0x003ECE5B
		

		// Token: 0x0600EBC0 RID: 60352 RVA: 0x003EEC6D File Offset: 0x003ECE6D
		

		// Token: 0x0600EBC1 RID: 60353 RVA: 0x003EEC7C File Offset: 0x003ECE7C
		

		// Token: 0x0600EBC2 RID: 60354 RVA: 0x003EECC0 File Offset: 0x003ECEC0
		public int getMonsterID(int id)
		{
			IMoveItem moveItem;
			if (this.s_DataMap.TryGetValue(id, out moveItem))
			{
				return moveItem.monster;
			}
			return 0;
		}

		// Token: 0x0600EBC3 RID: 60355 RVA: 0x003EECE8 File Offset: 0x003ECEE8
		public bool showDamage(int id)
		{
			IMoveItem moveItem;
			return this.s_DataMap.TryGetValue(id, out moveItem) && moveItem.damage == 1;
		}

		// Token: 0x0600EBC4 RID: 60356 RVA: 0x003EED10 File Offset: 0x003ECF10
		public string getAnmStr(int id, int skinId = 0)
		{
			IMoveItem moveItem;
			if (!this.s_DataMap.TryGetValue(id, out moveItem))
			{
				return string.Empty;
			}
			if (moveItem.skin == null || moveItem.skin.Length == 0)
			{
				return moveItem.anm[0];
			}
			int num = Array.IndexOf<int>(moveItem.skin, skinId);
			if (num == -1)
			{
				num = 0;
			}
			return moveItem.anm[num];
		}

		// Token: 0x0600EBC5 RID: 60357 RVA: 0x003EED68 File Offset: 0x003ECF68
		public int getCover(int id)
		{
			IMoveItem moveItem;
			if (this.s_DataMap.TryGetValue(id, out moveItem))
			{
				return moveItem.cover;
			}
			return 0;
		}

		// Token: 0x0600EBC6 RID: 60358 RVA: 0x003EED90 File Offset: 0x003ECF90
		//public string getReportTxtStr(int id, int skinId = 0)
		//{
		//	IMoveItem moveItem;
		//	if (this.s_DataMap.TryGetValue(id, out moveItem))
		//	{
		//		int num;
		//		if (moveItem.skin == null || moveItem.skin.Length == 0)
		//		{
		//			num = 0;
		//		}
		//		else
		//		{
		//			num = Array.IndexOf<int>(moveItem.skin, skinId);
		//		}
		//		if (num == -1)
		//		{
		//			num = 0;
		//		}
		//		string[] reportname = moveItem.reportname;
		//		string[] reportskill = moveItem.reportskill;
		//		string[] reporttxt = moveItem.reporttxt;
		//		string str = reporttxt[num].IsValidStr() ? (reportname[num] + reporttxt[num]) : string.Empty;
		//		return reportname[num] + "使用了" + reportskill[num] + str;
		//	}
		//	return string.Empty;
		//}

		// Token: 0x0600EBC7 RID: 60359 RVA: 0x003EEE24 File Offset: 0x003ED024
		public string getSkillName(int id, int skinId = 0)
		{
			IMoveItem moveItem;
			if (!this.s_DataMap.TryGetValue(id, out moveItem))
			{
				return string.Empty;
			}
			if (moveItem.skin == null || moveItem.skin.Length == 0)
			{
				return moveItem.reportskill[0];
			}
			int num = Array.IndexOf<int>(moveItem.skin, skinId);
			if (num == -1)
			{
				num = 0;
			}
			return moveItem.reportskill[num];
		}

		// Token: 0x0600EBC8 RID: 60360 RVA: 0x003EEE7C File Offset: 0x003ED07C
		public string getPetName(int id, int skinId = 0, string pName = "")
		{
			IMoveItem moveItem;
			if (!this.s_DataMap.TryGetValue(id, out moveItem))
			{
				return pName;
			}
			if (moveItem.skin == null || moveItem.skin.Length == 0)
			{
				return moveItem.reportname[0];
			}
			int num = Array.IndexOf<int>(moveItem.skin, skinId);
			if (num == -1)
			{
				return pName;
			}
			return moveItem.reportname[num];
		}

		// Token: 0x0600EBC9 RID: 60361 RVA: 0x003EEED0 File Offset: 0x003ED0D0
		public string getReportTxt(int id, int skinId = 0)
		{
			IMoveItem moveItem;
			if (!this.s_DataMap.TryGetValue(id, out moveItem))
			{
				return string.Empty;
			}
			if (moveItem.skin == null || moveItem.skin.Length == 0)
			{
				return moveItem.reporttxt[0];
			}
			int num = Array.IndexOf<int>(moveItem.skin, skinId);
			if (num == -1)
			{
				num = 0;
			}
			return moveItem.reporttxt[num];
		}

		// Token: 0x0400EEFB RID: 61179
		private Dictionary<int, IMoveItem> s_DataMap;
	}
}
