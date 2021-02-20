using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Not a Validator");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType); //reflection: create an instance of validator
            var entityType = _validatorType.BaseType.GetGenericArguments()[0]; //get generic type of its base type (entity)
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType); //get parameters of the method (i.e. add(parameters..)) which are the same of generic type of entityType
            foreach (var entity in entities) //validate each using ValidationTool
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
