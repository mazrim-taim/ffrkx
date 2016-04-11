using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FFRKInspector.GameData;

namespace FFRKInspector.GameData.Party
{
    class DataEquipmentInformation
    {
        [JsonProperty("id")]
        public uint InstanceId;

        [JsonProperty("equipment_id")]
        public uint EquipmentId;

        [JsonProperty("name")]
        public string Name;

        [JsonProperty("evolution_num")]
        public SchemaConstants.EvolutionLevel EvolutionNumber;

        [JsonProperty("level")]
        public byte Level;

        [JsonProperty("level_max")]
        public byte LevelMax;

        [JsonProperty("rarity")]
        public SchemaConstants.Rarity Rarity;

        [JsonProperty("base_rarity")]
        public SchemaConstants.Rarity BaseRarity;

        [JsonProperty("series_id")]
        public uint SeriesId;

        [JsonProperty("equipment_type")]
        public SchemaConstants.ItemType Type;

        [JsonProperty("atk")]
        public short Atk;
        [JsonProperty("matk")]
        public short Mag;
        [JsonProperty("acc")]
        public short Acc;
        [JsonProperty("def")]
        public short Def;
        [JsonProperty("mdef")]
        public short Res;
        [JsonProperty("eva")]
        public short Eva;
        [JsonProperty("mnd")]
        public short Mnd;

        [JsonProperty("sp_atk")]
        public short SeriesAtk;
        [JsonProperty("sp_matk")]
        public short SeriesMag;
        [JsonProperty("sp_acc")]
        public short SeriesAcc;
        [JsonProperty("sp_def")]
        public short SeriesDef;
        [JsonProperty("sp_mdef")]
        public short SeriesRes;
        [JsonProperty("sp_eva")]
        public short SeriesEva;
        [JsonProperty("sp_mnd")]
        public short SeriesMnd;

        [JsonProperty("category_id")]
        public SchemaConstants.EquipmentCategory Category;
    }
}
