using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using VL.Common.ORM.Objects;
using LostInJungle.Objects.Enums;

namespace LostInJungle.Objects.Entities
{
    [DataContract]
    public partial class TCreatureQuality : IPDMTBase
    {
        #region Properties
        [DataMember]
        public Guid CreatureId { get; set; }
        [DataMember]
        public EFirstLevelQuality FirstLevelQuality { get; set; }
        [DataMember]
        public ESecondLevelQuality SecondLevelQuality { get; set; }
        [DataMember]
        public EThirdLevelQuality ThirdLevelQuality { get; set; }
        #endregion

        #region Constructors
        public TCreatureQuality()
        {
        }
        public TCreatureQuality(IDataReader reader) : base(reader)
        {
        }
        #endregion

        #region Methods
        public override void Init(IDataReader reader)
        {
            this.CreatureId = new Guid(reader[nameof(this.CreatureId)].ToString());
            this.FirstLevelQuality = (EFirstLevelQuality)Enum.Parse(typeof(EFirstLevelQuality), reader[nameof(this.FirstLevelQuality)].ToString());
            this.SecondLevelQuality = (ESecondLevelQuality)Enum.Parse(typeof(ESecondLevelQuality), reader[nameof(this.SecondLevelQuality)].ToString());
            this.ThirdLevelQuality = (EThirdLevelQuality)Enum.Parse(typeof(EThirdLevelQuality), reader[nameof(this.ThirdLevelQuality)].ToString());
        }
        public override void Init(IDataReader reader, List<string> fields)
        {
            if (fields.Contains(nameof(CreatureId)))
            {
                this.CreatureId = new Guid(reader[nameof(this.CreatureId)].ToString());
            }
            if (fields.Contains(nameof(FirstLevelQuality)))
            {
                this.FirstLevelQuality = (EFirstLevelQuality)Enum.Parse(typeof(EFirstLevelQuality), reader[nameof(this.FirstLevelQuality)].ToString());
            }
            if (fields.Contains(nameof(SecondLevelQuality)))
            {
                this.SecondLevelQuality = (ESecondLevelQuality)Enum.Parse(typeof(ESecondLevelQuality), reader[nameof(this.SecondLevelQuality)].ToString());
            }
            if (fields.Contains(nameof(ThirdLevelQuality)))
            {
                this.ThirdLevelQuality = (EThirdLevelQuality)Enum.Parse(typeof(EThirdLevelQuality), reader[nameof(this.ThirdLevelQuality)].ToString());
            }
        }
        public override string GetTableName()
        {
            return nameof(TCreatureQuality);
        }
        #endregion
    }
}
