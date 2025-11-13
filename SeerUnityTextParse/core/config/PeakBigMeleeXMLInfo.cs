using System;
using common;
using core.config.peak_battle_mons;


namespace core.config
{
	// Token: 0x02001EAF RID: 7855
	public class PeakBigMeleeXMLInfo : ConfigManagerSingleton<PeakBigMeleeXMLInfo>
	{
		// Token: 0x0600EAB6 RID: 60086 RVA: 0x003EA951 File Offset: 0x003E8B51

		// Token: 0x0600EAB7 RID: 60087 RVA: 0x003EA95A File Offset: 0x003E8B5A
		

		// Token: 0x0600EAB8 RID: 60088 RVA: 0x003EA968 File Offset: 0x003E8B68
		

		// Token: 0x0600EAB9 RID: 60089 RVA: 0x003EA9AC File Offset: 0x003E8BAC
		public int getOfficialBanMon(int index)
		{
			IWeeklyIDItem[] weeklyID = this.s_ConfigXml.WeeklyID;
			index = ((index >= weeklyID.Length) ? (weeklyID.Length - 1) : index);
			return 0;
		}

		// Token: 0x0600EABA RID: 60090 RVA: 0x003EA9D6 File Offset: 0x003E8BD6
		public int getHomeAdditionMon(int index)
		{
			return this.s_ConfigXml.WeeklyID[index].HomeAdditionMon;
		}

		// Token: 0x0600EABB RID: 60091 RVA: 0x003EA9EA File Offset: 0x003E8BEA
		public string getNewSeIcon(int index)
		{
			return this.s_ConfigXml.WeeklyID[index].NewSeIcon;
		}

		// Token: 0x0400EEB0 RID: 61104
		private IPeakBtGlobalRule s_ConfigXml;
	}
}
