﻿using EventDriven.DDD.Abstractions.Entities;

namespace EventDriven.DDD.Abstractions.Commands;

/// <summary>
/// An object that is sent to the domain for a state change which is handled by a command handler.
/// </summary>
public abstract record Command(Guid EntityId = default) : ICommand;

/// <summary>
/// An object that is sent to the domain for a state change which is handled by a command handler.
/// </summary>
/// <typeparam name="TEntity">Entity type.</typeparam>
public abstract record Command<TEntity>(TEntity Entity) : ICommand<TEntity>
    where TEntity : IEntity
{
    /// <inheritdoc />
    public Guid EntityId { get; } = Entity.Id;

    /// <inheritdoc />
    public TEntity Entity { get; } = Entity;
}