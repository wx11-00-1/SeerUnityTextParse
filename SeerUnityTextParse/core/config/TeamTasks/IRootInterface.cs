using System;

namespace core.config.TeamTasks
{
	// Token: 0x02002486 RID: 9350
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x1700227B RID: 8827
		// (get) Token: 0x0601215A RID: 74074 RVA: 0x004B1E60 File Offset: 0x004B0060
		public override string fileName
		{
			get
			{
				return "TeamTasks";
			}
		}

		// Token: 0x1700227C RID: 8828
		// (get) Token: 0x0601215B RID: 74075 RVA: 0x004B1E67 File Offset: 0x004B0067
		// (set) Token: 0x0601215C RID: 74076 RVA: 0x004B1E6F File Offset: 0x004B006F
		public ITeamTasks TeamTasks { get; set; }

		// Token: 0x0601215D RID: 74077 RVA: 0x004B1E78 File Offset: 0x004B0078
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.TeamTasks = new ITeamTasks();
				this.TeamTasks.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0601215E RID: 74078 RVA: 0x004B1E9C File Offset: 0x004B009C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
