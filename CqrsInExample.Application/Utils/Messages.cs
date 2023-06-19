﻿using CqrsInExample.Application.Abstractions;
using CSharpFunctionalExtensions;

namespace CqrsInExample.Application.Utils
{
    public class Messages
    {
        private readonly IServiceProvider _provider;

        public Messages(
            IServiceProvider provider
            )
        {
            _provider = provider;
        }

        public Result Dispatch(ICommand command)
        {
            var type = typeof(ICommandHandler<>);
            Type[] typeArgs = { command.GetType() };
            var handlerType = type.MakeGenericType( typeArgs );

            dynamic handler = _provider.GetService(handlerType);

            Result result = handler.Handle((dynamic)command);
            return result;
        }

        public T Dispatch<T>(IQuery<T> query)
        {
            var type = typeof(IQueryHandler<,>);
            Type[] typeArgs = { query.GetType(), typeof(T) };
            var handlerType = type.MakeGenericType(typeArgs);

            dynamic handler = _provider.GetService(handlerType);
            T result = handler.Handle((dynamic)query);

            return result;
        }
    }
}
