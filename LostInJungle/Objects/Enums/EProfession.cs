using System.Runtime.Serialization;

namespace LostInJungle.Objects.Enums
{
    [DataContract]
    public enum EProfession
    {
        /// <summary>
        /// 流浪者
        /// </summary>
        [EnumMember]
        None = 0,
        /// <summary>
        /// 战士
        /// </summary>
        [EnumMember]
        Warrior = 1,
        /// <summary>
        /// 探索者
        /// </summary>
        [EnumMember]
        Explorer = 2,
    }
}
