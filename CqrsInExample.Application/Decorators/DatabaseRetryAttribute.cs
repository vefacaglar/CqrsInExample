namespace CqrsInExample.Application.Abstractions
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class DatabaseRetryAttribute : Attribute
    {
        public DatabaseRetryAttribute()
        {
        }
    }
}
