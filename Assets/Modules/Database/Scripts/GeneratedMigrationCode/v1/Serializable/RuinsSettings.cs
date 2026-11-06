//-------------------------------------------------------------------------------
//                                                                               
//    This code was automatically generated.                                     
//    Changes to this file may cause incorrect behavior and will be lost if      
//    the code is regenerated.                                                   
//                                                                               
//-------------------------------------------------------------------------------

using System;
using GameDatabase.Model;
using DatabaseMigration.v1.Enums;

namespace DatabaseMigration.v1.Serializable
{
	[Serializable]
	public class RuinsSettingsSerializable : SerializableItem
	{
		public RuinsSettingsSerializable()
		{
			ItemType = ItemType.RuinsSettings;
			FileName = "RuinsSettings.json";
		}

		public string MaxSatelliteCells = "MAX(6, FLOOR(level/2))";
		public int CreditsMultiplier = 5;
		public int FuelMin = 5;
		public int FuelMax = 14;
		public int SatelliteChance = 3;
		public int SatelliteCount = 1;
		public string ComponentLevel = "level + 35";
		public int ComponentMin = 1;
		public int ComponentMax = 2;
		public int StarsMin = 0;
		public int StarsMax = 2;
		public int FleetSizeMultiplier = 2;
	}
}
