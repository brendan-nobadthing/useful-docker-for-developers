namespace clean_architecture.Application.Common.Interfaces;

public interface ICurrentUserService
{
    string? UserId { get; }
}
