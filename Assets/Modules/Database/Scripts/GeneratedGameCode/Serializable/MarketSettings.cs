//-------------------------------------------------------------------------------
//                                                                               
//    This code was automatically generated.                                     
//    Changes to this file may cause incorrect behavior and will be lost if      
//    the code is regenerated.                                                   
//                                                                               
//-------------------------------------------------------------------------------

using System;
using GameDatabase.Enums;
using GameDatabase.Model;

namespace GameDatabase.Serializable
{
	[Serializable]
	public class MarketSettingsSerializable : SerializableItem
	{
		public float FuelRenewal = 1f;
		public float TechRenewal = 60f;
		public float StarsRenewal = 1440f;
		public float ShipRenewal = -1f;
		public float CommonComponentRenewal = 1440f;
		public float RareComponentRenewal = 4320f;
		public float SatelliteRenewal = 4320f;
		public string RareComponentLevel = "level + 75";
		public int RareComponentMin = 4;
		public int RareComponentMax = 7;
		public int SatelliteCount = 3;
		public int BlackMarketMoney = 10000;
	}
}
