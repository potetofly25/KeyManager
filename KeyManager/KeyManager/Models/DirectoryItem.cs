namespace KeyManager.Models
{
    public class DirectoryItem : BaseItem, IEquatable<DirectoryItem>
    {
        public bool Equals(DirectoryItem? other)
        {
            if (other == null)
            {
                return false;
            }
            return this.Id == other.Id;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as DirectoryItem);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
