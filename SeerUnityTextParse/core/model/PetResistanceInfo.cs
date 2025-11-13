using System;
using System.Collections.Generic;

namespace core.model
{
	// Token: 0x0200195A RID: 6490
	public class PetResistanceInfo
	{
		// Token: 0x0600CC19 RID: 52249 RVA: 0x003B45B0 File Offset: 0x003B27B0
		public void SetData(ByteArray data)
		{
			this.tmpData[0] = (int)data.ReadUnsignedInt();
			this.cirt = PetResistanceInfo.getbitValue(this.tmpData[0], 17, 16);
			this.cirt_adj = PetResistanceInfo.getbitValue(this.tmpData[0], 1, 16);
			this.tmpData[1] = (int)data.ReadUnsignedInt();
			this.regular = PetResistanceInfo.getbitValue(this.tmpData[1], 17, 16);
			this.regular_adj = PetResistanceInfo.getbitValue(this.tmpData[1], 1, 16);
			this.tmpData[2] = (int)data.ReadUnsignedInt();
			this.precent = PetResistanceInfo.getbitValue(this.tmpData[2], 17, 16);
			this.precent_adj = PetResistanceInfo.getbitValue(this.tmpData[2], 1, 16);
			this.weakAndCtlDict.Clear();
			for (int i = 1; i < 4; i++)
			{
				this.tmpData[i + 2] = (int)data.ReadUnsignedInt();
				this.weakAndCtlDict.Add("ctl_" + i.ToString() + "_idx", PetResistanceInfo.getbitValue(this.tmpData[i + 2], 17, 8));
				this.weakAndCtlDict.Add("ctl_" + i.ToString(), PetResistanceInfo.getbitValue(this.tmpData[i + 2], 9, 8));
				this.weakAndCtlDict.Add("ctl_" + i.ToString() + "_adj", PetResistanceInfo.getbitValue(this.tmpData[i + 2], 1, 8));
			}
			for (int j = 1; j < 4; j++)
			{
				this.tmpData[j + 5] = (int)data.ReadUnsignedInt();
				this.weakAndCtlDict.Add("weak_" + j.ToString() + "_idx", PetResistanceInfo.getbitValue(this.tmpData[j + 5], 17, 8));
				this.weakAndCtlDict.Add("weak_" + j.ToString(), PetResistanceInfo.getbitValue(this.tmpData[j + 5], 9, 8));
				this.weakAndCtlDict.Add("weak_" + j.ToString() + "_adj", PetResistanceInfo.getbitValue(this.tmpData[j + 5], 1, 8));
			}
			this.resist_all = (int)data.ReadUnsignedInt();
			this.resist_state = (int)data.ReadUnsignedInt();
			this.red_gem = (int)data.ReadUnsignedInt();
			this.green_gem = (int)data.ReadUnsignedInt();
			this.reserve = (int)data.ReadUnsignedInt();
			this.ctl_1 = this.weakAndCtlDict["ctl_1"];
			this.ctl_1_idx = this.weakAndCtlDict["ctl_1_idx"];
			this.ctl_1_adj = this.weakAndCtlDict["ctl_1_adj"];
			this.ctl_2 = this.weakAndCtlDict["ctl_2"];
			this.ctl_2_idx = this.weakAndCtlDict["ctl_2_idx"];
			this.ctl_2_adj = this.weakAndCtlDict["ctl_2_adj"];
			this.ctl_3 = this.weakAndCtlDict["ctl_3"];
			this.ctl_3_idx = this.weakAndCtlDict["ctl_3_idx"];
			this.ctl_3_adj = this.weakAndCtlDict["ctl_3_adj"];
			this.weak_1 = this.weakAndCtlDict["weak_1"];
			this.weak_1_idx = this.weakAndCtlDict["weak_1_idx"];
			this.weak_1_adj = this.weakAndCtlDict["weak_1_adj"];
			this.weak_2 = this.weakAndCtlDict["weak_2"];
			this.weak_2_idx = this.weakAndCtlDict["weak_2_idx"];
			this.weak_2_adj = this.weakAndCtlDict["weak_2_adj"];
			this.weak_3 = this.weakAndCtlDict["weak_3"];
			this.weak_3_idx = this.weakAndCtlDict["weak_3_idx"];
			this.weak_3_adj = this.weakAndCtlDict["weak_3_adj"];
		}

		// Token: 0x0600CC1A RID: 52250 RVA: 0x003B49AC File Offset: 0x003B2BAC
		public int getCtlValue(string key)
		{
			int result;
			this.weakAndCtlDict.TryGetValue(key, out result);
			return result;
		}

		// Token: 0x0600CC1B RID: 52251 RVA: 0x003B49CC File Offset: 0x003B2BCC
		public int getWeakValue(string key)
		{
			int result;
			this.weakAndCtlDict.TryGetValue(key, out result);
			return result;
		}

		// Token: 0x0600CC1C RID: 52252 RVA: 0x003B49EC File Offset: 0x003B2BEC
		private static int getbitValue(int value, int bitstart, int num)
		{
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				num2 += Convert.ToInt32((double)KTool.getBit(value, bitstart + i) * Math.Pow(2.0, (double)i));
			}
			return num2;
		}

		// Token: 0x0600CC1D RID: 52253 RVA: 0x003B4A2C File Offset: 0x003B2C2C
		internal void GetSaveByteArray(ByteArray data)
		{
			for (int i = 0; i < this.tmpData.Length; i++)
			{
				data.WriteSignedInt(this.tmpData[i]);
			}
			data.WriteSignedInt(this.resist_all);
			data.WriteSignedInt(this.resist_state);
			data.WriteSignedInt(this.red_gem);
			data.WriteSignedInt(this.green_gem);
			data.WriteSignedInt(this.reserve);
		}

		// Token: 0x0400E223 RID: 57891
		public int resist_state;

		// Token: 0x0400E224 RID: 57892
		public int red_gem;

		// Token: 0x0400E225 RID: 57893
		public int green_gem;

		// Token: 0x0400E226 RID: 57894
		public int reserve;

		// Token: 0x0400E227 RID: 57895
		public int resist_all;

		// Token: 0x0400E228 RID: 57896
		public int cirt;

		// Token: 0x0400E229 RID: 57897
		public int cirt_adj;

		// Token: 0x0400E22A RID: 57898
		public int regular;

		// Token: 0x0400E22B RID: 57899
		public int regular_adj;

		// Token: 0x0400E22C RID: 57900
		public int precent;

		// Token: 0x0400E22D RID: 57901
		public int precent_adj;

		// Token: 0x0400E22E RID: 57902
		public int ctl_1_idx;

		// Token: 0x0400E22F RID: 57903
		public int ctl_1;

		// Token: 0x0400E230 RID: 57904
		public int ctl_1_adj;

		// Token: 0x0400E231 RID: 57905
		public int ctl_2_idx;

		// Token: 0x0400E232 RID: 57906
		public int ctl_2;

		// Token: 0x0400E233 RID: 57907
		public int ctl_2_adj;

		// Token: 0x0400E234 RID: 57908
		public int ctl_3_idx;

		// Token: 0x0400E235 RID: 57909
		public int ctl_3;

		// Token: 0x0400E236 RID: 57910
		public int ctl_3_adj;

		// Token: 0x0400E237 RID: 57911
		public int weak_1_idx;

		// Token: 0x0400E238 RID: 57912
		public int weak_1;

		// Token: 0x0400E239 RID: 57913
		public int weak_1_adj;

		// Token: 0x0400E23A RID: 57914
		public int weak_2_idx;

		// Token: 0x0400E23B RID: 57915
		public int weak_2;

		// Token: 0x0400E23C RID: 57916
		public int weak_2_adj;

		// Token: 0x0400E23D RID: 57917
		public int weak_3_idx;

		// Token: 0x0400E23E RID: 57918
		public int weak_3;

		// Token: 0x0400E23F RID: 57919
		public int weak_3_adj;

		// Token: 0x0400E240 RID: 57920
		private Dictionary<string, int> weakAndCtlDict = new Dictionary<string, int>();

		// Token: 0x0400E241 RID: 57921
		private int[] tmpData = new int[9];
	}
}
