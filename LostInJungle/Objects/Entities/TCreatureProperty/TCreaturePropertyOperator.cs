using System.Collections.Generic;
using System.Linq;
using VL.Common.DAS.Objects;
using VL.Common.ORM.Utilities.QueryBuilders;
using VL.Common.ORM.Utilities.QueryOperators;

namespace LostInJungle.Objects.Entities
{
    public static partial class EntityOperator
    {
        #region Methods
        #region 写
        public static bool DbDelete(this TCreatureProperty entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TCreaturePropertyProperties.CreatureId, OperatorType.Equal, entity.CreatureId));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TCreatureProperty>(session, query);
        }
        public static bool DbDelete(this List<TCreatureProperty> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            var Ids = entities.Select(c =>c.CreatureId );
            query.DeleteBuilder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TCreaturePropertyProperties.CreatureId, OperatorType.In, Ids));
            return IDbQueryOperator.GetQueryOperator(session).Delete<TCreatureProperty>(session, query);
        }
        public static bool DbInsert(this TCreatureProperty entity, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            InsertBuilder builder = new InsertBuilder();
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.CreatureId, entity.CreatureId));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.HitPoint, entity.HitPoint));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.MagicPoint, entity.MagicPoint));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.Strength, entity.Strength));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.Agility, entity.Agility));
            builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.Intelligence, entity.Intelligence));
            query.InsertBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Insert<TCreatureProperty>(session, query);
        }
        public static bool DbInsert(this List<TCreatureProperty> entities, DbSession session)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                InsertBuilder builder = new InsertBuilder();
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.CreatureId, entity.CreatureId));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.HitPoint, entity.HitPoint));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.MagicPoint, entity.MagicPoint));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.Strength, entity.Strength));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.Agility, entity.Agility));
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.Intelligence, entity.Intelligence));
                query.InsertBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).InsertAll<TCreatureProperty>(session, query);
        }
        public static bool DbUpdate(this TCreatureProperty entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            UpdateBuilder builder = new UpdateBuilder();
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TCreaturePropertyProperties.CreatureId, OperatorType.Equal, entity.CreatureId));
            if (fields.Contains(TCreaturePropertyProperties.HitPoint.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.HitPoint, entity.HitPoint));
            }
            if (fields.Contains(TCreaturePropertyProperties.MagicPoint.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.MagicPoint, entity.MagicPoint));
            }
            if (fields.Contains(TCreaturePropertyProperties.Strength.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.Strength, entity.Strength));
            }
            if (fields.Contains(TCreaturePropertyProperties.Agility.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.Agility, entity.Agility));
            }
            if (fields.Contains(TCreaturePropertyProperties.Intelligence.Title))
            {
                builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.Intelligence, entity.Intelligence));
            }
            query.UpdateBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Update<TCreatureProperty>(session, query);
        }
        public static bool DbUpdate(this List<TCreatureProperty> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            foreach (var entity in entities)
            {
                UpdateBuilder builder = new UpdateBuilder();
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TCreaturePropertyProperties.CreatureId, OperatorType.Equal, entity.CreatureId));
                if (fields.Contains(TCreaturePropertyProperties.HitPoint.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.HitPoint, entity.HitPoint));
                }
                if (fields.Contains(TCreaturePropertyProperties.MagicPoint.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.MagicPoint, entity.MagicPoint));
                }
                if (fields.Contains(TCreaturePropertyProperties.Strength.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.Strength, entity.Strength));
                }
                if (fields.Contains(TCreaturePropertyProperties.Agility.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.Agility, entity.Agility));
                }
                if (fields.Contains(TCreaturePropertyProperties.Intelligence.Title))
                {
                    builder.ComponentValue.Values.Add(new PDMDbPropertyValue(TCreaturePropertyProperties.Intelligence, entity.Intelligence));
                }
                query.UpdateBuilders.Add(builder);
            }
            return IDbQueryOperator.GetQueryOperator(session).UpdateAll<TCreatureProperty>(session, query);
        }
        #endregion
        #region 读
        public static TCreatureProperty DbSelect(this TCreatureProperty entity, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TCreaturePropertyProperties.CreatureId, OperatorType.Equal, entity.CreatureId));
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).Select<TCreatureProperty>(session, query);
        }
        public static List<TCreatureProperty> DbSelect(this List<TCreatureProperty> entities, DbSession session, params string[] fields)
        {
            var query = IDbQueryBuilder.GetDbQueryBuilder(session);
            SelectBuilder builder = new SelectBuilder();
            foreach (var field in fields)
            {
                builder.ComponentFieldAliases.FieldAliases.Add(new FieldAlias(field));
            }
            var Ids = entities.Select(c =>c.CreatureId );
            if (Ids.Count() != 0)
            {
                builder.ComponentWhere.Wheres.Add(new PDMDbPropertyOperateValue(TCreaturePropertyProperties.CreatureId, OperatorType.In, Ids));
            }
            query.SelectBuilders.Add(builder);
            return IDbQueryOperator.GetQueryOperator(session).SelectAll<TCreatureProperty>(session, query);
        }
        #endregion
        #endregion
    }
}
