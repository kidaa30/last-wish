﻿namespace Server.Items
{
    public class PumpkinScarecrow : Item
	{
		public override int LabelNumber { get { return 1096947; } }

		[Constructable]
		public PumpkinScarecrow()
			: base( Utility.RandomBool() ? 0x469B : 0x469C )
		{
		}

		public PumpkinScarecrow( Serial serial )
			: base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( ( int )0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
