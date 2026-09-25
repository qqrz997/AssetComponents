using System;
using UnityEngine;

namespace AssetComponents.Editor
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ConditionalFieldAttribute : PropertyAttribute
    {
        public interface ICondition
        {
            bool GetState(object target);
        }
        
        public ConditionalFieldAttribute(string fieldName, Type conditionType)
        {
            if (!conditionType.IsAssignableFrom(typeof(ICondition)))
                throw new ArgumentException($"{conditionType} is not assignable from {typeof(ICondition)}");
            FieldName = fieldName;
            ConditionType = conditionType;
        }

        public string FieldName { get; }
        public Type ConditionType { get; }
    }
}