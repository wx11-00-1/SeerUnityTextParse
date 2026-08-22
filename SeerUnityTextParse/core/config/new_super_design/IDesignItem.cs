using System;

namespace core.config.new_super_design
{
	public class IDesignItem
	{
		public IAchievement Achievement { get; set; }

		public IConfigure Configure { get; set; }

		public IEasyBattle EasyBattle { get; set; }

		public INormalBattle HardBattle { get; set; }

		public INormalBattle NormalBattle { get; set; }

		public IReward Reward { get; set; }

		public IRules Rules { get; set; }

		public ISweep Sweep { get; set; }

		public int ID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int byteIndex2 = byteIndex;
			if (byteIndex2 >= bytes.Length)
			{
				return;
			}
			if (bytes[byteIndex2++] != 0)
			{
				Achievement = new IAchievement();
				Achievement.Parse(bytes, ref byteIndex2);
			}
			if (byteIndex2 >= bytes.Length)
			{
				return;
			}
			if (bytes[byteIndex2++] != 0)
			{
				Configure = new IConfigure();
				Configure.Parse(bytes, ref byteIndex2);
			}
			if (byteIndex2 >= bytes.Length)
			{
				return;
			}
			if (bytes[byteIndex2++] != 0)
			{
				EasyBattle = new IEasyBattle();
				EasyBattle.Parse(bytes, ref byteIndex2);
			}
			if (byteIndex2 >= bytes.Length)
			{
				return;
			}
			if (bytes[byteIndex2++] != 0)
			{
				HardBattle = new INormalBattle();
				HardBattle.Parse(bytes, ref byteIndex2);
			}
			if (byteIndex2 + 4 > bytes.Length)
			{
				return;
			}
			ID = BitConverter.ToInt32(bytes, byteIndex2);
			byteIndex2 += 4;
			if (byteIndex2 >= bytes.Length)
			{
				return;
			}
			if (bytes[byteIndex2++] != 0)
			{
				NormalBattle = new INormalBattle();
				NormalBattle.Parse(bytes, ref byteIndex2);
			}
			if (byteIndex2 >= bytes.Length)
			{
				return;
			}
			if (bytes[byteIndex2++] != 0)
			{
				Reward = new IReward();
				Reward.Parse(bytes, ref byteIndex2);
			}
			if (byteIndex2 >= bytes.Length)
			{
				return;
			}
			if (bytes[byteIndex2++] != 0)
			{
				Rules = new IRules();
				Rules.Parse(bytes, ref byteIndex2);
			}
			if (byteIndex2 < bytes.Length)
			{
				if (bytes[byteIndex2++] != 0)
				{
					Sweep = new ISweep();
					Sweep.Parse(bytes, ref byteIndex2);
				}
				byteIndex = byteIndex2;
			}
		}
	}
}
