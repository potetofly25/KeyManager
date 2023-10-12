namespace KeyManager.Models
{
    public class TagItem : BaseItem, IEquatable<TagItem>
    {
        public bool Equals(TagItem? other)
        {
            if (other == null)
            {
                return false;
            }
            return this.Id == other.Id;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as TagItem);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
