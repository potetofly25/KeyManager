namespace KeyManager.Models
{
    public class TypeItem : BaseItem, IEquatable<TypeItem>
    {
        public bool Equals(TypeItem? other)
        {
            if (other == null)
            {
                return false;
            }
            return this.Id == other.Id;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as TypeItem);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
