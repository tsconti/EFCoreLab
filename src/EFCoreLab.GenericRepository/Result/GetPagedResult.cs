namespace EFCoreLab.GenericRepository;

public class GetPagedResult<T>
{
    public IEnumerable<T>? Result { get; set; }
    public int Count { get; set; }
}
