using PersonRegistrationASPNet.Database.DTOs;

namespace PersonRegistrationASPNet.Database.Repositories
{
    public interface IFieldUpdateRepository<T>
    {
        ResponseDto updateField(T item);
    }
}
