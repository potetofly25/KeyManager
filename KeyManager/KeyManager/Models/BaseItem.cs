namespace KeyManager.Models
{
    [Serializable]
    public class BaseItem// : IEquatable<BaseItem>
    {
        public long Id { get; set; } = 0;

        public string? Name { get; set; } = null;

        public long? SortNumber { get; set; } = null;

        //public bool Equals(BaseItem? other)
        //{
        //    if (other == null)
        //    {
        //        return false;
        //    }
        //    return this.Id == other.Id;
        //}

        //public override bool Equals(object? obj)
        //{
        //    return Equals(obj as BaseItem);
        //}

        //public override int GetHashCode()
        //{
        //    return Id.GetHashCode();
        //}

    }
}
