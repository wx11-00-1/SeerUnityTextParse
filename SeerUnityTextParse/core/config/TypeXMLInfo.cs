using System;
using System.Collections.Generic;
using common;
using core.config.typesRelation;


namespace core.config
{
	// Token: 0x02001EC2 RID: 7874
	public class TypeXMLInfo : ConfigManagerSingleton<TypeXMLInfo>
	{
		// Token: 0x0600EBAC RID: 60332 RVA: 0x003EE876 File Offset: 0x003ECA76
		

		// Token: 0x0600EBAD RID: 60333 RVA: 0x003EE888 File Offset: 0x003ECA88
		

		// Token: 0x0600EBAE RID: 60334 RVA: 0x003EE898 File Offset: 0x003ECA98
		

		// Token: 0x0600EBAF RID: 60335 RVA: 0x003EE8DB File Offset: 0x003ECADB
		private float getRelation(string attack, string attacked)
		{
			return this.typeInfos[attack][attacked];
		}

		// Token: 0x0600EBB0 RID: 60336 RVA: 0x003EE8EF File Offset: 0x003ECAEF
		private int getDivisor(float effect11, float effect21)
		{
			if (effect11 == 2f && effect21 == 2f)
			{
				return 1;
			}
			if (effect11 == 0f || effect21 == 0f)
			{
				return 4;
			}
			return 2;
		}

		// Token: 0x0600EBB1 RID: 60337 RVA: 0x003EE918 File Offset: 0x003ECB18
		public float getRelations(string[] attack, string[] attacked)
		{
			if (attack.Length == 1)
			{
				if (attacked.Length == 1)
				{
					return this.getRelation(attack[0], attacked[0]);
				}
				if (attacked.Length == 2)
				{
					return (this.getRelation(attack[0], attacked[0]) + this.getRelation(attack[0], attacked[1])) / 2f;
				}
			}
			else if (attack.Length == 2)
			{
				if (attacked.Length == 1)
				{
					return (this.getRelation(attack[0], attacked[0]) + this.getRelation(attack[1], attacked[0])) / 2f;
				}
				if (attacked.Length == 2)
				{
					return (this.getRelation(attack[0], attacked[0]) + this.getRelation(attack[0], attacked[1]) + this.getRelation(attack[1], attacked[0]) + this.getRelation(attack[1], attacked[1])) / 4f;
				}
			}
			return 0f;
		}

		// Token: 0x0600EBB2 RID: 60338 RVA: 0x003EE9D8 File Offset: 0x003ECBD8
		public float getRelationsPow(string[] attack, string[] attacked)
		{
			if (attack.Length == 1)
			{
				if (attacked.Length == 1)
				{
					return this.getRelation(attack[0], attacked[0]);
				}
				if (attacked.Length == 2)
				{
					float relation = this.getRelation(attack[0], attacked[0]);
					float relation2 = this.getRelation(attack[0], attacked[1]);
					return (relation + relation2) / (float)this.getDivisor(relation, relation2);
				}
			}
			else if (attack.Length == 2)
			{
				if (attacked.Length == 1)
				{
					float relation3 = this.getRelation(attack[0], attacked[0]);
					float relation4 = this.getRelation(attack[1], attacked[0]);
					return (relation3 + relation4) / (float)this.getDivisor(relation3, relation4);
				}
				if (attacked.Length == 2)
				{
					float relation5 = this.getRelation(attack[0], attacked[0]);
					float relation6 = this.getRelation(attack[1], attacked[0]);
					float relation7 = this.getRelation(attack[0], attacked[1]);
					float relation8 = this.getRelation(attack[1], attacked[1]);
					return ((relation5 + relation6) / (float)this.getDivisor(relation5, relation6) + (relation7 + relation8) / (float)this.getDivisor(relation7, relation8)) / 2f;
				}
			}
			return 0f;
		}

		// Token: 0x0400EEF9 RID: 61177
		public Dictionary<string, Dictionary<string, float>> typeInfos;
	}
}
