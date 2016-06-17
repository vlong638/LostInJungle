using LostInJungle.Objects.Entities;
using LostInJungle.Objects.Enums;
using System;
using System.Collections.Generic;

namespace ConsoleManager
{
    public class DataCreator
    {
        public List<TArea> Areas = new List<TArea>()
        {
           new TArea() { AreaId = Guid.NewGuid(), AreaName = "无主林地", AreaType = EAreaType.ForestLand, AreaLevel = 1, Description = "初级", DescriptionEx = "这是一片荒芜的地区,几乎没有生物出没的踪迹." },
           new TArea() { AreaId = Guid.NewGuid(), AreaName = "无主草地", AreaType = EAreaType.GrassLand, AreaLevel = 1, Description = "初级", DescriptionEx = "这是一片荒芜的地区,几乎没有生物出没的踪迹." },
           new TArea() { AreaId = Guid.NewGuid(), AreaName = "无主水域", AreaType = EAreaType.WaterArea, AreaLevel = 1, Description = "初级", DescriptionEx = "这是一片荒芜的地区,几乎没有生物出没的踪迹." },
           new TArea() { AreaId = Guid.NewGuid(), AreaName = "无主石区", AreaType = EAreaType.MineArea, AreaLevel = 1, Description = "初级", DescriptionEx = "这是一片荒芜的地区,几乎没有生物出没的踪迹." },
           new TArea() { AreaId = Guid.NewGuid(), AreaName = "无主沼地", AreaType = EAreaType.Swamp, AreaLevel = 1, Description = "初级", DescriptionEx = "这是一片荒芜的地区,几乎没有生物出没的踪迹." },
        };
    }
}
