namespace Ecommerce.Domain.Common
{
    public interface IEntityBase<T> : IDateTracking
    {
        public T Id { get; set; }
        public bool? IsDelete { get; set; }
    }
}
